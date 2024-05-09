using System.ComponentModel;
using Effekseer.swig;
using System.Diagnostics;
using System.Numerics;

namespace CSharpFormDX11;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
    }
    protected override void OnLoad( EventArgs e )
    {
        // Obtain values that can be accessed in this GUI thread only.
        _WindowHandle = this.Handle;
        _RenderTargetSize = new SharpDX.Size2F( this.ClientSize.Width, this.ClientSize.Height );

        // executes the main loop in the MTA thread.
        _MainLoopTask = Task.Factory.StartNew( () => _MainLoop() );

        base.OnLoad( e );
    }
    protected override void OnClosing( CancelEventArgs e )
    {
        // Send an exit message to the main loop thread.
        _MessageQueue.TryAdd( -1, Timeout.Infinite );
        _MainLoopTask.Wait( 5000 ); // Wait for main thread to exit. (5 seconds max.)

        _MessageQueue.Dispose();

        base.OnClosing( e );
    }


    // Rendering loop thread

    private void _MainLoop()
    {
        // initialize
        _InitializeDX11();
        _InitializeEffekseer();

        // load effect; sample effect by tktk
        // https://effekseer.github.io/jp/contributes/tktk02/index.html
        _LoadEffect( @"SampleEffect\tktk02\Blow5.efkefc" );

        // start effect and timer
        _EffectHandle = _EffekseerManager.Play( _Effect );
        _Timer = Stopwatch.StartNew();
        _LastUpdateTime = TimeSpan.Zero;

        // update, draw, present loop
        while( true )
        {
            // update Effekseer
            var now = _Timer.Elapsed;
            var delta = now.Subtract( _LastUpdateTime );
            _LastUpdateTime = now;
            _EffekseerManager.Update( (float) ( delta.TotalSeconds * 60.0 ) );  // 1frame in Effekseer = 1/60sec 

            // draw all Effekseer effects
            _D3D11Device1.ImmediateContext.OutputMerger.SetRenderTargets( _RenderTargetView );
            _D3D11Device1.ImmediateContext.Rasterizer.SetViewport( 0, 0, _RenderTargetSize.Width, _RenderTargetSize.Height );
            _D3D11Device1.ImmediateContext.ClearRenderTargetView( _RenderTargetView, new SharpDX.Color4( 0, 0, 0, 1 ) );
            _EffekseerManager.DrawBack();
            _EffekseerManager.DrawFront();

            // present
            _DXGISwapChain1.Present( 1, SharpDX.DXGI.PresentFlags.None );

            // Exit the loop when notified of the message to exit.
            if( _MessageQueue.TryTake( out int messsage ) )
            {
                if( messsage == -1 )
                    break;
            }
        }

        // stop effect
        _EffekseerManager.Stop( _EffectHandle );

        // Finalize
        _FinalizeEffekseer();
        _FinalizeDX11();
    }


    // Effekseer

    private EffekseerManagerCore _EffekseerManager = null!;
    private EffekseerEffectCore _Effect = null!;
    private int _EffectHandle;
    private Stopwatch _Timer = null!;
    private TimeSpan _LastUpdateTime;

    private void _InitializeEffekseer()
    {
        // initialize BackendCore
        EffekseerBackendCore.InitializeWithDirectX11( _D3D11Device1.NativePointer, _D3D11Device1.ImmediateContext.NativePointer );

        // create Manager
        _EffekseerManager = new EffekseerManagerCore();
        _EffekseerManager.InitializeDX11( _D3D11Device1.NativePointer, _D3D11Device1.ImmediateContext.NativePointer, 8000 );

        // setup Manager
        _EffekseerManager.SetViewProjectionMatrixWithSimpleWindow( (int) _RenderTargetSize.Width, (int) _RenderTargetSize.Height );
        var m = Matrix4x4.CreateLookAt( new Vector3( 0f, 0f, 10f ), Vector3.Zero, new Vector3( 0f, 1f, 0f ) );
        _EffekseerManager.SetCameraMatrix( m.M11, m.M21, m.M31, m.M41, m.M12, m.M22, m.M32, m.M42, m.M13, m.M23, m.M33, m.M43, m.M14, m.M24, m.M34, m.M44 );
        m = Matrix4x4.CreatePerspectiveFieldOfView( SharpDX.MathUtil.DegreesToRadians( 45.0f ), _RenderTargetSize.Width / _RenderTargetSize.Height, 1, 500 );
        _EffekseerManager.SetProjectionMatrix( m.M11, m.M21, m.M31, m.M41, m.M12, m.M22, m.M32, m.M42, m.M13, m.M23, m.M33, m.M43, m.M14, m.M24, m.M34, m.M44 );
    }
    private void _FinalizeEffekseer()
    {
        _Effect?.Dispose();
        _EffekseerManager?.Dispose();
        EffekseerBackendCore.Terminate();
    }
    private void _LoadEffect( string effectPath )
    {
        byte[] data;
        int count;

        // get base directory for effect resources
        var basePath = Path.GetDirectoryName( effectPath ) ?? string.Empty;

        // create new effect
        _Effect = new EffekseerEffectCore();

        // (1) load effect file
        data = _LoadFile( effectPath );
        if( !_Effect.Load( data, data.Length, magnification: 1.0f ) )
            throw new Exception( "Failed to load effect." );
        Debug.WriteLine( $"Loaded effect: {effectPath}" );

        // (2) load effect texture files
        var textureTypes = new EffekseerTextureType[] {
            EffekseerTextureType.Color,
            EffekseerTextureType.Normal,
            EffekseerTextureType.Distortion,
        };
        foreach( var ttype in textureTypes )
        {
            count = _Effect.GetTextureCount( ttype );
            Debug.WriteLine( $"{ttype}Texture count: {count}" );

            for( int i = 0; i < count; i++ )
            {
                var file = _Effect.GetTexturePath( i, ttype );
                Debug.Write( $"{ttype}Texture {i}; {file} ... " );
 
                data = _LoadFile( Path.Combine( basePath, file ) );
                var ret = _Effect.LoadTexture( data, data.Length, i, ttype );
                Debug.WriteLine( ret ? "OK" : "NG" );
            }
        }

        // (3) load effect model files.
        count = _Effect.GetModelCount();
        Debug.WriteLine( $"Model count: {count}" );
        for( int i = 0; i < count; i++ )
        {
            var file = _Effect.GetModelPath( i );
            Debug.WriteLine( $"Model {i}; {file}" );
            
            data = _LoadFile( Path.Combine( basePath, file ) );
            var ret = _Effect.LoadModel( data, data.Length, i );
            Debug.WriteLine( ret ? "OK" : "NG" );
        }

        // (4) laod effect material files.
        int num = _Effect.GetMaterialCount();
        Debug.WriteLine( $"Material count: {num}" );
        for( int i = 0; i < num; i++ )
        {
            var file = _Effect.GetMaterialPath( i );
            Debug.WriteLine( $"Material {i}; {file}" );

            data = _LoadFile( Path.Combine( basePath, file ) );
            var ret = _Effect.LoadMaterial( data, data.Length, i );
            Debug.WriteLine( ret ? "OK" : "NG" );
        }

        // (5) load effect curve files.
        num = _Effect.GetCurveCount();
        Debug.WriteLine( $"Curve count: {num}" );
        for( int i = 0; i < num; i++ )
        {
            var file = _Effect.GetCurvePath( i );
            Debug.WriteLine( $"Curve {i}; {file}" );

            data = _LoadFile( Path.Combine( basePath, file ) );
            var ret = _Effect.LoadCurve( data, data.Length, i );
            Debug.WriteLine( ret ? "OK" : "NG" );
        }
    }


    // DirectX

    private SharpDX.Direct3D11.Device1 _D3D11Device1 = null!;
    private SharpDX.DXGI.Device1 _DXGIDevice1 = null!;
    private SharpDX.DXGI.SwapChain1 _DXGISwapChain1 = null!;
    private SharpDX.Direct3D11.RenderTargetView _RenderTargetView = null!;

    private void _InitializeDX11()
    {
        // create D3D11 and Device
        using( var d3dDevice = new SharpDX.Direct3D11.Device(
            SharpDX.Direct3D.DriverType.Hardware,
            SharpDX.Direct3D11.DeviceCreationFlags.BgraSupport,
            [ SharpDX.Direct3D.FeatureLevel.Level_11_0 ] ) )
        {
            _D3D11Device1 = d3dDevice.QueryInterface<SharpDX.Direct3D11.Device1>();
        }

        // Set multi-threading mode to ON.
        using( var multithread = _D3D11Device1.QueryInterfaceOrNull<SharpDX.Direct3D.DeviceMultithread>() )
        {
            if( multithread is null )
                throw new Exception( "Direct3D11 device does not support ID3D10Multithread." );

            multithread.SetMultithreadProtected( true );
        }

        // get DXGI device
        this._DXGIDevice1 = _D3D11Device1.QueryInterface<SharpDX.DXGI.Device1>();
        this._DXGIDevice1.MaximumFrameLatency = 1;

        // create swapChain
        using( var dxgiDevice1 = _D3D11Device1.QueryInterface<SharpDX.DXGI.Device1>() )
        using( var dxgiAdapter = dxgiDevice1.Adapter )
        using( var dxgiFactory2 = dxgiAdapter.GetParent<SharpDX.DXGI.Factory2>() )
        {
            var swapChainDesc = new SharpDX.DXGI.SwapChainDescription1() {
                BufferCount = 2,
                Width = (int) _RenderTargetSize.Width,
                Height = (int) _RenderTargetSize.Height,
                Format = SharpDX.DXGI.Format.B8G8R8A8_UNorm,
                AlphaMode = SharpDX.DXGI.AlphaMode.Ignore,
                Stereo = false,
                SampleDescription = new SharpDX.DXGI.SampleDescription( 1, 0 ),
                SwapEffect = SharpDX.DXGI.SwapEffect.FlipDiscard,
                Scaling = SharpDX.DXGI.Scaling.Stretch,
                Usage = SharpDX.DXGI.Usage.RenderTargetOutput,
                Flags = SharpDX.DXGI.SwapChainFlags.None,
            };

            // this method will call CreateSwapChainForHWnd().
            _DXGISwapChain1 = new SharpDX.DXGI.SwapChain1( dxgiFactory2, _D3D11Device1, _WindowHandle, ref swapChainDesc );
        }

        // create renderTargetView to swapchain
        using( var backbufferTexture2D = _DXGISwapChain1.GetBackBuffer<SharpDX.Direct3D11.Texture2D>( 0 ) )
        {
            _RenderTargetView = new SharpDX.Direct3D11.RenderTargetView( _D3D11Device1, backbufferTexture2D );
        }
    }
    private void _FinalizeDX11()
    {
        _RenderTargetView?.Dispose();
        _DXGISwapChain1?.Dispose();
        _DXGIDevice1?.Dispose();
        _D3D11Device1?.Dispose();
    }


    // others

    private IntPtr _WindowHandle;
    private SharpDX.Size2F _RenderTargetSize;
    private Task _MainLoopTask = null!;
    private readonly System.Collections.Concurrent.BlockingCollection<int> _MessageQueue = new();

    private byte[] _LoadFile( string path )
    {
        using var fs = new FileStream( path, FileMode.Open, FileAccess.Read );
        byte[] buffer = new byte[ fs.Length ];
        fs.Read( buffer, 0, (int) fs.Length );
        return buffer;
    }
}

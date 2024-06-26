//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (https://www.swig.org).
// Version 4.2.1
//
// Do not make changes to this file unless you know what you are doing - modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------

namespace Effekseer.swig {

public class EffekseerManagerCore : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal EffekseerManagerCore(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(EffekseerManagerCore obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  internal static global::System.Runtime.InteropServices.HandleRef swigRelease(EffekseerManagerCore obj) {
    if (obj != null) {
      if (!obj.swigCMemOwn)
        throw new global::System.ApplicationException("Cannot release ownership as memory is not owned");
      global::System.Runtime.InteropServices.HandleRef ptr = obj.swigCPtr;
      obj.swigCMemOwn = false;
      obj.Dispose();
      return ptr;
    } else {
      return new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
    }
  }

  ~EffekseerManagerCore() {
    Dispose(false);
  }

  public void Dispose() {
    Dispose(true);
    global::System.GC.SuppressFinalize(this);
  }

  protected virtual void Dispose(bool disposing) {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          EffekseerCorePINVOKE.delete_EffekseerManagerCore(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
    }
  }

  public EffekseerManagerCore() : this(EffekseerCorePINVOKE.new_EffekseerManagerCore(), true) {
  }

  public bool InitializeOpenGL(int spriteMaxCount, bool srgbMode) {
    bool ret = EffekseerCorePINVOKE.EffekseerManagerCore_InitializeOpenGL__SWIG_0(swigCPtr, spriteMaxCount, srgbMode);
    return ret;
  }

  public bool InitializeOpenGL(int spriteMaxCount) {
    bool ret = EffekseerCorePINVOKE.EffekseerManagerCore_InitializeOpenGL__SWIG_1(swigCPtr, spriteMaxCount);
    return ret;
  }

  public bool InitializeDX11(global::System.IntPtr device, global::System.IntPtr context, int spriteMaxCount, D3D11_COMPARISON_FUNC comparisonFunc, bool srgbMode, bool isMSAAEnabled) {
    bool ret = EffekseerCorePINVOKE.EffekseerManagerCore_InitializeDX11__SWIG_0(swigCPtr, device, context, spriteMaxCount, (int)comparisonFunc, srgbMode, isMSAAEnabled);
    return ret;
  }

  public bool InitializeDX11(global::System.IntPtr device, global::System.IntPtr context, int spriteMaxCount, D3D11_COMPARISON_FUNC comparisonFunc, bool srgbMode) {
    bool ret = EffekseerCorePINVOKE.EffekseerManagerCore_InitializeDX11__SWIG_1(swigCPtr, device, context, spriteMaxCount, (int)comparisonFunc, srgbMode);
    return ret;
  }

  public bool InitializeDX11(global::System.IntPtr device, global::System.IntPtr context, int spriteMaxCount, D3D11_COMPARISON_FUNC comparisonFunc) {
    bool ret = EffekseerCorePINVOKE.EffekseerManagerCore_InitializeDX11__SWIG_2(swigCPtr, device, context, spriteMaxCount, (int)comparisonFunc);
    return ret;
  }

  public bool InitializeDX11(global::System.IntPtr device, global::System.IntPtr context, int spriteMaxCount) {
    bool ret = EffekseerCorePINVOKE.EffekseerManagerCore_InitializeDX11__SWIG_3(swigCPtr, device, context, spriteMaxCount);
    return ret;
  }

  public void Update(float deltaFrames) {
    EffekseerCorePINVOKE.EffekseerManagerCore_Update(swigCPtr, deltaFrames);
  }

  public void UpdateHandle(int handle) {
    EffekseerCorePINVOKE.EffekseerManagerCore_UpdateHandle__SWIG_0(swigCPtr, handle);
  }

  public void UpdateHandle(int handle, float deltaFrames) {
    EffekseerCorePINVOKE.EffekseerManagerCore_UpdateHandle__SWIG_1(swigCPtr, handle, deltaFrames);
  }

  public void BeginUpdate() {
    EffekseerCorePINVOKE.EffekseerManagerCore_BeginUpdate(swigCPtr);
  }

  public void EndUpdate() {
    EffekseerCorePINVOKE.EffekseerManagerCore_EndUpdate(swigCPtr);
  }

  public bool BeginRendering() {
    bool ret = EffekseerCorePINVOKE.EffekseerManagerCore_BeginRendering(swigCPtr);
    return ret;
  }

  public bool EndRendering() {
    bool ret = EffekseerCorePINVOKE.EffekseerManagerCore_EndRendering(swigCPtr);
    return ret;
  }

  public void UpdateHandleToMoveToFrame(int handle, float v) {
    EffekseerCorePINVOKE.EffekseerManagerCore_UpdateHandleToMoveToFrame(swigCPtr, handle, v);
  }

  public int Play(EffekseerEffectCore effect, float x, float y, float z, int startFrame) {
    int ret = EffekseerCorePINVOKE.EffekseerManagerCore_Play__SWIG_0(swigCPtr, EffekseerEffectCore.getCPtr(effect), x, y, z, startFrame);
    return ret;
  }

  public int Play(EffekseerEffectCore effect, float x, float y, float z) {
    int ret = EffekseerCorePINVOKE.EffekseerManagerCore_Play__SWIG_1(swigCPtr, EffekseerEffectCore.getCPtr(effect), x, y, z);
    return ret;
  }

  public int Play(EffekseerEffectCore effect, float x, float y) {
    int ret = EffekseerCorePINVOKE.EffekseerManagerCore_Play__SWIG_2(swigCPtr, EffekseerEffectCore.getCPtr(effect), x, y);
    return ret;
  }

  public int Play(EffekseerEffectCore effect, float x) {
    int ret = EffekseerCorePINVOKE.EffekseerManagerCore_Play__SWIG_3(swigCPtr, EffekseerEffectCore.getCPtr(effect), x);
    return ret;
  }

  public int Play(EffekseerEffectCore effect) {
    int ret = EffekseerCorePINVOKE.EffekseerManagerCore_Play__SWIG_4(swigCPtr, EffekseerEffectCore.getCPtr(effect));
    return ret;
  }

  public void StopAllEffects() {
    EffekseerCorePINVOKE.EffekseerManagerCore_StopAllEffects(swigCPtr);
  }

  public void Stop(int handle) {
    EffekseerCorePINVOKE.EffekseerManagerCore_Stop(swigCPtr, handle);
  }

  public void SetPaused(int handle, bool v) {
    EffekseerCorePINVOKE.EffekseerManagerCore_SetPaused(swigCPtr, handle, v);
  }

  public void SetShown(int handle, bool v) {
    EffekseerCorePINVOKE.EffekseerManagerCore_SetShown(swigCPtr, handle, v);
  }

  public void SendTrigger(int handle, int index) {
    EffekseerCorePINVOKE.EffekseerManagerCore_SendTrigger(swigCPtr, handle, index);
  }

  public void SetEffectPosition(int handle, float x, float y, float z) {
    EffekseerCorePINVOKE.EffekseerManagerCore_SetEffectPosition(swigCPtr, handle, x, y, z);
  }

  public void SetEffectRotation(int handle, float x, float y, float z) {
    EffekseerCorePINVOKE.EffekseerManagerCore_SetEffectRotation__SWIG_0(swigCPtr, handle, x, y, z);
  }

  public void SetEffectRotation(int handle, float axis_x, float axis_y, float axis_z, float angle) {
    EffekseerCorePINVOKE.EffekseerManagerCore_SetEffectRotation__SWIG_1(swigCPtr, handle, axis_x, axis_y, axis_z, angle);
  }

  public void SetEffectScale(int handle, float x, float y, float z) {
    EffekseerCorePINVOKE.EffekseerManagerCore_SetEffectScale(swigCPtr, handle, x, y, z);
  }

  public void SetLayerParameter(int layer, float viewerPosX, float viewerPosY, float viewerPosZ, float distanceBias) {
    EffekseerCorePINVOKE.EffekseerManagerCore_SetLayerParameter(swigCPtr, layer, viewerPosX, viewerPosY, viewerPosZ, distanceBias);
  }

  public void SetEffectTransformMatrix(int handle, float v0, float v1, float v2, float v3, float v4, float v5, float v6, float v7, float v8, float v9, float v10, float v11) {
    EffekseerCorePINVOKE.EffekseerManagerCore_SetEffectTransformMatrix(swigCPtr, handle, v0, v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v11);
  }

  public void SetEffectTransformBaseMatrix(int handle, float v0, float v1, float v2, float v3, float v4, float v5, float v6, float v7, float v8, float v9, float v10, float v11) {
    EffekseerCorePINVOKE.EffekseerManagerCore_SetEffectTransformBaseMatrix(swigCPtr, handle, v0, v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v11);
  }

  public void DrawBack(int layer) {
    EffekseerCorePINVOKE.EffekseerManagerCore_DrawBack__SWIG_0(swigCPtr, layer);
  }

  public void DrawBack() {
    EffekseerCorePINVOKE.EffekseerManagerCore_DrawBack__SWIG_1(swigCPtr);
  }

  public void DrawFront(int layer) {
    EffekseerCorePINVOKE.EffekseerManagerCore_DrawFront__SWIG_0(swigCPtr, layer);
  }

  public void DrawFront() {
    EffekseerCorePINVOKE.EffekseerManagerCore_DrawFront__SWIG_1(swigCPtr);
  }

  public void DrawHandle(int handle, float zNear, float zFar) {
    EffekseerCorePINVOKE.EffekseerManagerCore_DrawHandle__SWIG_0(swigCPtr, handle, zNear, zFar);
  }

  public void DrawHandle(int handle, float zNear) {
    EffekseerCorePINVOKE.EffekseerManagerCore_DrawHandle__SWIG_1(swigCPtr, handle, zNear);
  }

  public void DrawHandle(int handle) {
    EffekseerCorePINVOKE.EffekseerManagerCore_DrawHandle__SWIG_2(swigCPtr, handle);
  }

  public void SetLayer(int handle, int layer) {
    EffekseerCorePINVOKE.EffekseerManagerCore_SetLayer(swigCPtr, handle, layer);
  }

  public void SetCameraParameter(float frontX, float frontY, float frontZ, float posX, float posY, float posZ) {
    EffekseerCorePINVOKE.EffekseerManagerCore_SetCameraParameter(swigCPtr, frontX, frontY, frontZ, posX, posY, posZ);
  }

  public void SetProjectionMatrix(float v0, float v1, float v2, float v3, float v4, float v5, float v6, float v7, float v8, float v9, float v10, float v11, float v12, float v13, float v14, float v15) {
    EffekseerCorePINVOKE.EffekseerManagerCore_SetProjectionMatrix(swigCPtr, v0, v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v11, v12, v13, v14, v15);
  }

  public void SetCameraMatrix(float v0, float v1, float v2, float v3, float v4, float v5, float v6, float v7, float v8, float v9, float v10, float v11, float v12, float v13, float v14, float v15) {
    EffekseerCorePINVOKE.EffekseerManagerCore_SetCameraMatrix(swigCPtr, v0, v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v11, v12, v13, v14, v15);
  }

  public bool Exists(int handle) {
    bool ret = EffekseerCorePINVOKE.EffekseerManagerCore_Exists(swigCPtr, handle);
    return ret;
  }

  public void SetViewProjectionMatrixWithSimpleWindow(int windowWidth, int windowHeight) {
    EffekseerCorePINVOKE.EffekseerManagerCore_SetViewProjectionMatrixWithSimpleWindow(swigCPtr, windowWidth, windowHeight);
  }

  public void SetDynamicInput(int handle, int index, float value) {
    EffekseerCorePINVOKE.EffekseerManagerCore_SetDynamicInput(swigCPtr, handle, index, value);
  }

  public float GetDynamicInput(int handle, int index) {
    float ret = EffekseerCorePINVOKE.EffekseerManagerCore_GetDynamicInput(swigCPtr, handle, index);
    return ret;
  }

  public void LaunchWorkerThreads(int n) {
    EffekseerCorePINVOKE.EffekseerManagerCore_LaunchWorkerThreads(swigCPtr, n);
  }

  public void SetBackground(uint glid, bool hasMipmap) {
    EffekseerCorePINVOKE.EffekseerManagerCore_SetBackground(swigCPtr, glid, hasMipmap);
  }

  public void UnsetBackground() {
    EffekseerCorePINVOKE.EffekseerManagerCore_UnsetBackground(swigCPtr);
  }

  public void SetDepth(uint glid, bool hasMipmap) {
    EffekseerCorePINVOKE.EffekseerManagerCore_SetDepth(swigCPtr, glid, hasMipmap);
  }

  public void UnsetDepth() {
    EffekseerCorePINVOKE.EffekseerManagerCore_UnsetDepth(swigCPtr);
  }

  public int GetInstanceCount(int handle) {
    int ret = EffekseerCorePINVOKE.EffekseerManagerCore_GetInstanceCount(swigCPtr, handle);
    return ret;
  }

  public int GetTotalInstanceCount() {
    int ret = EffekseerCorePINVOKE.EffekseerManagerCore_GetTotalInstanceCount(swigCPtr);
    return ret;
  }

}

}

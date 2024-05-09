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

public class EffekseerEffectCore : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal EffekseerEffectCore(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(EffekseerEffectCore obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  internal static global::System.Runtime.InteropServices.HandleRef swigRelease(EffekseerEffectCore obj) {
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

  ~EffekseerEffectCore() {
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
          EffekseerCorePINVOKE.delete_EffekseerEffectCore(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
    }
  }

  public EffekseerEffectCore() : this(EffekseerCorePINVOKE.new_EffekseerEffectCore(), true) {
  }

  public bool Load(byte[] data, int len, float magnification) {
    bool ret = EffekseerCorePINVOKE.EffekseerEffectCore_Load(swigCPtr, data, len, magnification);
    return ret;
  }

  public string GetTexturePath(int index, EffekseerTextureType type) {
    string ret = System.Runtime.InteropServices.Marshal.PtrToStringUni(EffekseerCorePINVOKE.EffekseerEffectCore_GetTexturePath(swigCPtr, index, (int)type));
    return ret;
  }

  public int GetTextureCount(EffekseerTextureType type) {
    int ret = EffekseerCorePINVOKE.EffekseerEffectCore_GetTextureCount(swigCPtr, (int)type);
    return ret;
  }

  public bool LoadTexture(byte[] data, int len, int index, EffekseerTextureType type) {
    bool ret = EffekseerCorePINVOKE.EffekseerEffectCore_LoadTexture(swigCPtr, data, len, index, (int)type);
    return ret;
  }

  public bool HasTextureLoaded(int index, EffekseerTextureType type) {
    bool ret = EffekseerCorePINVOKE.EffekseerEffectCore_HasTextureLoaded(swigCPtr, index, (int)type);
    return ret;
  }

  public string GetModelPath(int index) {
    string ret = System.Runtime.InteropServices.Marshal.PtrToStringUni(EffekseerCorePINVOKE.EffekseerEffectCore_GetModelPath(swigCPtr, index));
    return ret;
  }

  public int GetModelCount() {
    int ret = EffekseerCorePINVOKE.EffekseerEffectCore_GetModelCount(swigCPtr);
    return ret;
  }

  public bool LoadModel(byte[] data, int len, int index) {
    bool ret = EffekseerCorePINVOKE.EffekseerEffectCore_LoadModel(swigCPtr, data, len, index);
    return ret;
  }

  public bool HasModelLoaded(int index) {
    bool ret = EffekseerCorePINVOKE.EffekseerEffectCore_HasModelLoaded(swigCPtr, index);
    return ret;
  }

  public string GetMaterialPath(int index) {
    string ret = System.Runtime.InteropServices.Marshal.PtrToStringUni(EffekseerCorePINVOKE.EffekseerEffectCore_GetMaterialPath(swigCPtr, index));
    return ret;
  }

  public int GetMaterialCount() {
    int ret = EffekseerCorePINVOKE.EffekseerEffectCore_GetMaterialCount(swigCPtr);
    return ret;
  }

  public bool LoadMaterial(byte[] data, int len, int index) {
    bool ret = EffekseerCorePINVOKE.EffekseerEffectCore_LoadMaterial(swigCPtr, data, len, index);
    return ret;
  }

  public string GetCurvePath(int index) {
    string ret = System.Runtime.InteropServices.Marshal.PtrToStringUni(EffekseerCorePINVOKE.EffekseerEffectCore_GetCurvePath(swigCPtr, index));
    return ret;
  }

  public bool HasMaterialLoaded(int index) {
    bool ret = EffekseerCorePINVOKE.EffekseerEffectCore_HasMaterialLoaded(swigCPtr, index);
    return ret;
  }

  public int GetCurveCount() {
    int ret = EffekseerCorePINVOKE.EffekseerEffectCore_GetCurveCount(swigCPtr);
    return ret;
  }

  public bool LoadCurve(byte[] data, int len, int index) {
    bool ret = EffekseerCorePINVOKE.EffekseerEffectCore_LoadCurve(swigCPtr, data, len, index);
    return ret;
  }

  public bool HasCurveLoaded(int index) {
    bool ret = EffekseerCorePINVOKE.EffekseerEffectCore_HasCurveLoaded(swigCPtr, index);
    return ret;
  }

  public int GetTermMax() {
    int ret = EffekseerCorePINVOKE.EffekseerEffectCore_GetTermMax(swigCPtr);
    return ret;
  }

  public int GetTermMin() {
    int ret = EffekseerCorePINVOKE.EffekseerEffectCore_GetTermMin(swigCPtr);
    return ret;
  }

  public string GetName() {
    string ret = System.Runtime.InteropServices.Marshal.PtrToStringUni(EffekseerCorePINVOKE.EffekseerEffectCore_GetName(swigCPtr));
    return ret;
  }

  public void SetName(string name) {
    EffekseerCorePINVOKE.EffekseerEffectCore_SetName(swigCPtr, name);
  }

  public int GetVersion() {
    int ret = EffekseerCorePINVOKE.EffekseerEffectCore_GetVersion(swigCPtr);
    return ret;
  }

}

}

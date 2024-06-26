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

public class Matrix44 : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal Matrix44(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(Matrix44 obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  internal static global::System.Runtime.InteropServices.HandleRef swigRelease(Matrix44 obj) {
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

  ~Matrix44() {
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
          EffekseerCorePINVOKE.delete_Matrix44(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
    }
  }

  public Matrix44() : this(EffekseerCorePINVOKE.new_Matrix44(), true) {
  }

  public SWIGTYPE_p_a_4__float Values {
    set {
      EffekseerCorePINVOKE.Matrix44_Values_set(swigCPtr, SWIGTYPE_p_a_4__float.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = EffekseerCorePINVOKE.Matrix44_Values_get(swigCPtr);
      SWIGTYPE_p_a_4__float ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_a_4__float(cPtr, false);
      return ret;
    } 
  }

  public Matrix44 Indentity() {
    Matrix44 ret = new Matrix44(EffekseerCorePINVOKE.Matrix44_Indentity(swigCPtr), false);
    return ret;
  }

  public Matrix44 Transpose() {
    Matrix44 ret = new Matrix44(EffekseerCorePINVOKE.Matrix44_Transpose(swigCPtr), false);
    return ret;
  }

  public Matrix44 LookAtRH(Vector3D eye, Vector3D at, Vector3D up) {
    Matrix44 ret = new Matrix44(EffekseerCorePINVOKE.Matrix44_LookAtRH(swigCPtr, Vector3D.getCPtr(eye), Vector3D.getCPtr(at), Vector3D.getCPtr(up)), false);
    if (EffekseerCorePINVOKE.SWIGPendingException.Pending) throw EffekseerCorePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public Matrix44 LookAtLH(Vector3D eye, Vector3D at, Vector3D up) {
    Matrix44 ret = new Matrix44(EffekseerCorePINVOKE.Matrix44_LookAtLH(swigCPtr, Vector3D.getCPtr(eye), Vector3D.getCPtr(at), Vector3D.getCPtr(up)), false);
    if (EffekseerCorePINVOKE.SWIGPendingException.Pending) throw EffekseerCorePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public Matrix44 PerspectiveFovRH(float ovY, float aspect, float zn, float zf) {
    Matrix44 ret = new Matrix44(EffekseerCorePINVOKE.Matrix44_PerspectiveFovRH(swigCPtr, ovY, aspect, zn, zf), false);
    return ret;
  }

  public Matrix44 PerspectiveFovRH_OpenGL(float ovY, float aspect, float zn, float zf) {
    Matrix44 ret = new Matrix44(EffekseerCorePINVOKE.Matrix44_PerspectiveFovRH_OpenGL(swigCPtr, ovY, aspect, zn, zf), false);
    return ret;
  }

  public Matrix44 PerspectiveFovLH(float ovY, float aspect, float zn, float zf) {
    Matrix44 ret = new Matrix44(EffekseerCorePINVOKE.Matrix44_PerspectiveFovLH(swigCPtr, ovY, aspect, zn, zf), false);
    return ret;
  }

  public Matrix44 PerspectiveFovLH_OpenGL(float ovY, float aspect, float zn, float zf) {
    Matrix44 ret = new Matrix44(EffekseerCorePINVOKE.Matrix44_PerspectiveFovLH_OpenGL(swigCPtr, ovY, aspect, zn, zf), false);
    return ret;
  }

  public Matrix44 OrthographicRH(float width, float height, float zn, float zf) {
    Matrix44 ret = new Matrix44(EffekseerCorePINVOKE.Matrix44_OrthographicRH(swigCPtr, width, height, zn, zf), false);
    return ret;
  }

  public Matrix44 OrthographicLH(float width, float height, float zn, float zf) {
    Matrix44 ret = new Matrix44(EffekseerCorePINVOKE.Matrix44_OrthographicLH(swigCPtr, width, height, zn, zf), false);
    return ret;
  }

  public void Scaling(float x, float y, float z) {
    EffekseerCorePINVOKE.Matrix44_Scaling(swigCPtr, x, y, z);
  }

  public void RotationX(float angle) {
    EffekseerCorePINVOKE.Matrix44_RotationX(swigCPtr, angle);
  }

  public void RotationY(float angle) {
    EffekseerCorePINVOKE.Matrix44_RotationY(swigCPtr, angle);
  }

  public void RotationZ(float angle) {
    EffekseerCorePINVOKE.Matrix44_RotationZ(swigCPtr, angle);
  }

  public void Translation(float x, float y, float z) {
    EffekseerCorePINVOKE.Matrix44_Translation(swigCPtr, x, y, z);
  }

  public void RotationAxis(Vector3D axis, float angle) {
    EffekseerCorePINVOKE.Matrix44_RotationAxis(swigCPtr, Vector3D.getCPtr(axis), angle);
    if (EffekseerCorePINVOKE.SWIGPendingException.Pending) throw EffekseerCorePINVOKE.SWIGPendingException.Retrieve();
  }

  public void Quaternion(float x, float y, float z, float w) {
    EffekseerCorePINVOKE.Matrix44_Quaternion(swigCPtr, x, y, z, w);
  }

  public static Matrix44 Mul(Matrix44 o, Matrix44 in1, Matrix44 in2) {
    Matrix44 ret = new Matrix44(EffekseerCorePINVOKE.Matrix44_Mul(Matrix44.getCPtr(o), Matrix44.getCPtr(in1), Matrix44.getCPtr(in2)), false);
    if (EffekseerCorePINVOKE.SWIGPendingException.Pending) throw EffekseerCorePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static Matrix44 Inverse(Matrix44 o, Matrix44 in_) {
    Matrix44 ret = new Matrix44(EffekseerCorePINVOKE.Matrix44_Inverse(Matrix44.getCPtr(o), Matrix44.getCPtr(in_)), false);
    if (EffekseerCorePINVOKE.SWIGPendingException.Pending) throw EffekseerCorePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

}

}

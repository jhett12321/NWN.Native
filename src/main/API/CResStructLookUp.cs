//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 4.0.2
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------

namespace NWN.Native.API {

public class CResStructLookUp : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal CResStructLookUp(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(CResStructLookUp obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~CResStructLookUp() {
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
          throw new global::System.MethodAccessException("C++ destructor does not have public access");
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
    }
  }

  public uint m_nType {
    set {
      NWNXLibPINVOKE.CResStructLookUp_m_nType_set(swigCPtr, value);
    } 
    get {
      uint ret = NWNXLibPINVOKE.CResStructLookUp_m_nType_get(swigCPtr);
      return ret;
    } 
  }

  public uint m_nSize {
    set {
      NWNXLibPINVOKE.CResStructLookUp_m_nSize_set(swigCPtr, value);
    } 
    get {
      uint ret = NWNXLibPINVOKE.CResStructLookUp_m_nSize_get(swigCPtr);
      return ret;
    } 
  }

  public uint m_nOffset {
    set {
      NWNXLibPINVOKE.CResStructLookUp_m_nOffset_set(swigCPtr, value);
    } 
    get {
      uint ret = NWNXLibPINVOKE.CResStructLookUp_m_nOffset_get(swigCPtr);
      return ret;
    } 
  }

}

}
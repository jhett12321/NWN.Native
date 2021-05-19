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

public unsafe class CEffectIconObject : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal CEffectIconObject(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(CEffectIconObject obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~CEffectIconObject() {
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
          NWNXLibPINVOKE.delete_CEffectIconObject(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
    }
  }
/*@SWIG:/__w/NWN.Native/NWN.Native/nwnx/Plugins/SWIG/SWIG_DotNET/API_NWNXLib.i,20,SWIG_DOTNET_EXTENSIONS@*/
  public global::System.IntPtr Pointer {
    get {
      return swigCPtr.Handle;
    }
  }

  public static unsafe implicit operator void*(CEffectIconObject self) {
    return (void*)self.swigCPtr.Handle;
  }

  public static unsafe CEffectIconObject FromPointer(void* pointer, bool memoryOwn = false) {
    return pointer != null ? new CEffectIconObject((global::System.IntPtr)pointer, memoryOwn) : null;
  }

  public static CEffectIconObject FromPointer(global::System.IntPtr pointer, bool memoryOwn = false) {
    return pointer != global::System.IntPtr.Zero ? new CEffectIconObject(pointer, memoryOwn) : null;
  }

  public bool Equals(CEffectIconObject other) {
    if (ReferenceEquals(null, other)) {
      return false;
    }

    if (ReferenceEquals(this, other)) {
      return true;
    }

    return Pointer.Equals(other.Pointer);
  }

  public override bool Equals(object obj) {
    return ReferenceEquals(this, obj) || obj is CEffectIconObject other && Equals(other);
  }

  public override int GetHashCode() {
    return swigCPtr.Handle.GetHashCode();
  }

  public static bool operator ==(CEffectIconObject left, CEffectIconObject right) {
    return Equals(left, right);
  }

  public static bool operator !=(CEffectIconObject left, CEffectIconObject right) {
    return !Equals(left, right);
  }
/*@SWIG@*/
  public byte m_nIcon {
    set {
      NWNXLibPINVOKE.CEffectIconObject_m_nIcon_set(swigCPtr, value);
    } 
    get {
      byte ret = NWNXLibPINVOKE.CEffectIconObject_m_nIcon_get(swigCPtr);
      return ret;
    } 
  }

  public int m_bFlashing {
    set {
      NWNXLibPINVOKE.CEffectIconObject_m_bFlashing_set(swigCPtr, value);
    } 
    get {
      int ret = NWNXLibPINVOKE.CEffectIconObject_m_bFlashing_get(swigCPtr);
      return ret;
    } 
  }

  public int m_nPlayerBar {
    set {
      NWNXLibPINVOKE.CEffectIconObject_m_nPlayerBar_set(swigCPtr, value);
    } 
    get {
      int ret = NWNXLibPINVOKE.CEffectIconObject_m_nPlayerBar_get(swigCPtr);
      return ret;
    } 
  }

  public CEffectIconObject() : this(NWNXLibPINVOKE.new_CEffectIconObject(), true) {
  }

}

}

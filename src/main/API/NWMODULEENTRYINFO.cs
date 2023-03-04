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

public unsafe class NWMODULEENTRYINFO : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal NWMODULEENTRYINFO(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(NWMODULEENTRYINFO obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~NWMODULEENTRYINFO() {
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
          NWNXLibPINVOKE.delete_NWMODULEENTRYINFO(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
    }
  }

  public global::System.IntPtr Pointer {
    get {
      return swigCPtr.Handle;
    }
  }

  public static unsafe implicit operator void*(NWMODULEENTRYINFO self) {
    return (void*)self.swigCPtr.Handle;
  }

  public static unsafe NWMODULEENTRYINFO FromPointer(void* pointer, bool memoryOwn = false) {
    return pointer != null ? new NWMODULEENTRYINFO((global::System.IntPtr)pointer, memoryOwn) : null;
  }

  public static NWMODULEENTRYINFO FromPointer(global::System.IntPtr pointer, bool memoryOwn = false) {
    return pointer != global::System.IntPtr.Zero ? new NWMODULEENTRYINFO(pointer, memoryOwn) : null;
  }

  public bool Equals(NWMODULEENTRYINFO other) {
    if (ReferenceEquals(null, other)) {
      return false;
    }

    if (ReferenceEquals(this, other)) {
      return true;
    }

    return Pointer.Equals(other.Pointer);
  }

  public override bool Equals(object obj) {
    return ReferenceEquals(this, obj) || obj is NWMODULEENTRYINFO other && Equals(other);
  }

  public override int GetHashCode() {
    return swigCPtr.Handle.GetHashCode();
  }

  public static bool operator ==(NWMODULEENTRYINFO left, NWMODULEENTRYINFO right) {
    return Equals(left, right);
  }

  public static bool operator !=(NWMODULEENTRYINFO left, NWMODULEENTRYINFO right) {
    return !Equals(left, right);
  }

  public CResRef refArea {
    set {
      NWNXLibPINVOKE.NWMODULEENTRYINFO_refArea_set(swigCPtr, CResRef.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = NWNXLibPINVOKE.NWMODULEENTRYINFO_refArea_get(swigCPtr);
      CResRef ret = (cPtr == global::System.IntPtr.Zero) ? null : new CResRef(cPtr, false);
      return ret;
    } 
  }

  public float nX {
    set {
      NWNXLibPINVOKE.NWMODULEENTRYINFO_nX_set(swigCPtr, value);
    } 
    get {
      float retVal = NWNXLibPINVOKE.NWMODULEENTRYINFO_nX_get(swigCPtr);
      return retVal;
    }

  }

  public float nY {
    set {
      NWNXLibPINVOKE.NWMODULEENTRYINFO_nY_set(swigCPtr, value);
    } 
    get {
      float retVal = NWNXLibPINVOKE.NWMODULEENTRYINFO_nY_get(swigCPtr);
      return retVal;
    }

  }

  public float nZ {
    set {
      NWNXLibPINVOKE.NWMODULEENTRYINFO_nZ_set(swigCPtr, value);
    } 
    get {
      float retVal = NWNXLibPINVOKE.NWMODULEENTRYINFO_nZ_get(swigCPtr);
      return retVal;
    }

  }

  public float fDirX {
    set {
      NWNXLibPINVOKE.NWMODULEENTRYINFO_fDirX_set(swigCPtr, value);
    } 
    get {
      float retVal = NWNXLibPINVOKE.NWMODULEENTRYINFO_fDirX_get(swigCPtr);
      return retVal;
    }

  }

  public float fDirY {
    set {
      NWNXLibPINVOKE.NWMODULEENTRYINFO_fDirY_set(swigCPtr, value);
    } 
    get {
      float retVal = NWNXLibPINVOKE.NWMODULEENTRYINFO_fDirY_get(swigCPtr);
      return retVal;
    }

  }

  public NWMODULEENTRYINFO() : this(NWNXLibPINVOKE.new_NWMODULEENTRYINFO(), true) {
  }

}

}

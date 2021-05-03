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

public unsafe class CResNSS : CRes {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;

  public CResNSS(global::System.IntPtr cPtr, bool cMemoryOwn) : base(NWNXLibPINVOKE.CResNSS_SWIGUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  public CResNSS(void* cPtr, bool cMemoryOwn) : base(NWNXLibPINVOKE.CResNSS_SWIGUpcast((global::System.IntPtr)cPtr), cMemoryOwn) {
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, (global::System.IntPtr)cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(CResNSS obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  protected override void Dispose(bool disposing) {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          NWNXLibPINVOKE.delete_CResNSS(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      base.Dispose(disposing);
    }
  }

  public global::System.IntPtr Pointer {
    get {
      return swigCPtr.Handle;
    }
  }

  public static unsafe implicit operator void*(CResNSS self) {
    return (void*)self.swigCPtr.Handle;
  }

  public static implicit operator global::System.IntPtr(CResNSS self) {
    return self.swigCPtr.Handle;
  }

  public bool Equals(CResNSS other) {
    if (ReferenceEquals(null, other)) {
      return false;
    }

    if (ReferenceEquals(this, other)) {
      return true;
    }

    return Pointer.Equals(other.Pointer);
  }

  public override bool Equals(object obj) {
    return ReferenceEquals(this, obj) || obj is CResNSS other && Equals(other);
  }

  public override int GetHashCode() {
    return swigCPtr.Handle.GetHashCode();
  }

  public static bool operator ==(CResNSS left, CResNSS right) {
    return Equals(left, right);
  }

  public static bool operator !=(CResNSS left, CResNSS right) {
    return !Equals(left, right);
  }

  public int m_bLoaded {
    set {
      NWNXLibPINVOKE.CResNSS_m_bLoaded_set(swigCPtr, value);
    } 
    get {
      int ret = NWNXLibPINVOKE.CResNSS_m_bLoaded_get(swigCPtr);
      return ret;
    } 
  }

  public uint m_nNSSNormalSize {
    set {
      NWNXLibPINVOKE.CResNSS_m_nNSSNormalSize_set(swigCPtr, value);
    } 
    get {
      uint ret = NWNXLibPINVOKE.CResNSS_m_nNSSNormalSize_get(swigCPtr);
      return ret;
    } 
  }

  public byte* m_pNSSData {
    set {
      NWNXLibPINVOKE.CResNSS_m_pNSSData_set(swigCPtr, (global::System.IntPtr)value);
    } 
    get {
        global::System.IntPtr retVal = NWNXLibPINVOKE.CResNSS_m_pNSSData_get(swigCPtr);
        return (byte*)retVal;
    }

  }

  public CResNSS() : this(NWNXLibPINVOKE.new_CResNSS(), true) {
  }

  public byte* GetNSSDataPtr() {
    global::System.IntPtr retVal = NWNXLibPINVOKE.CResNSS_GetNSSDataPtr(swigCPtr);
    return (byte*)retVal;
  }

  public uint GetNSSSize() {
    uint ret = NWNXLibPINVOKE.CResNSS_GetNSSSize(swigCPtr);
    return ret;
  }

  public int IsLoaded() {
    int ret = NWNXLibPINVOKE.CResNSS_IsLoaded(swigCPtr);
    return ret;
  }

  public override int OnResourceFreed() {
    int ret = NWNXLibPINVOKE.CResNSS_OnResourceFreed(swigCPtr);
    return ret;
  }

  public override int OnResourceServiced() {
    int ret = NWNXLibPINVOKE.CResNSS_OnResourceServiced(swigCPtr);
    return ret;
  }

}

}

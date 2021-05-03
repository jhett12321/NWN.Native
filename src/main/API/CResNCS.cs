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

public unsafe class CResNCS : CRes {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;

  public CResNCS(global::System.IntPtr cPtr, bool cMemoryOwn) : base(NWNXLibPINVOKE.CResNCS_SWIGUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  public CResNCS(void* cPtr, bool cMemoryOwn) : base(NWNXLibPINVOKE.CResNCS_SWIGUpcast((global::System.IntPtr)cPtr), cMemoryOwn) {
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, (global::System.IntPtr)cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(CResNCS obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  protected override void Dispose(bool disposing) {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          NWNXLibPINVOKE.delete_CResNCS(swigCPtr);
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

  public static unsafe implicit operator void*(CResNCS self) {
    return (void*)self.swigCPtr.Handle;
  }

  public static implicit operator global::System.IntPtr(CResNCS self) {
    return self.swigCPtr.Handle;
  }

  public bool Equals(CResNCS other) {
    if (ReferenceEquals(null, other)) {
      return false;
    }

    if (ReferenceEquals(this, other)) {
      return true;
    }

    return Pointer.Equals(other.Pointer);
  }

  public override bool Equals(object obj) {
    return ReferenceEquals(this, obj) || obj is CResNCS other && Equals(other);
  }

  public override int GetHashCode() {
    return swigCPtr.Handle.GetHashCode();
  }

  public static bool operator ==(CResNCS left, CResNCS right) {
    return Equals(left, right);
  }

  public static bool operator !=(CResNCS left, CResNCS right) {
    return !Equals(left, right);
  }

  public int m_bLoaded {
    set {
      NWNXLibPINVOKE.CResNCS_m_bLoaded_set(swigCPtr, value);
    } 
    get {
      int ret = NWNXLibPINVOKE.CResNCS_m_bLoaded_get(swigCPtr);
      return ret;
    } 
  }

  public uint m_nNCSNormalSize {
    set {
      NWNXLibPINVOKE.CResNCS_m_nNCSNormalSize_set(swigCPtr, value);
    } 
    get {
      uint ret = NWNXLibPINVOKE.CResNCS_m_nNCSNormalSize_get(swigCPtr);
      return ret;
    } 
  }

  public byte* m_pNCSData {
    set {
      NWNXLibPINVOKE.CResNCS_m_pNCSData_set(swigCPtr, (global::System.IntPtr)value);
    } 
    get {
        global::System.IntPtr retVal = NWNXLibPINVOKE.CResNCS_m_pNCSData_get(swigCPtr);
        return (byte*)retVal;
    }

  }

  public CResNCS() : this(NWNXLibPINVOKE.new_CResNCS(), true) {
  }

  public byte* GetNCSDataPtr() {
    global::System.IntPtr retVal = NWNXLibPINVOKE.CResNCS_GetNCSDataPtr(swigCPtr);
    return (byte*)retVal;
  }

  public uint GetNCSSize() {
    uint ret = NWNXLibPINVOKE.CResNCS_GetNCSSize(swigCPtr);
    return ret;
  }

  public int IsLoaded() {
    int ret = NWNXLibPINVOKE.CResNCS_IsLoaded(swigCPtr);
    return ret;
  }

  public override int OnResourceFreed() {
    int ret = NWNXLibPINVOKE.CResNCS_OnResourceFreed(swigCPtr);
    return ret;
  }

  public override int OnResourceServiced() {
    int ret = NWNXLibPINVOKE.CResNCS_OnResourceServiced(swigCPtr);
    return ret;
  }

}

}

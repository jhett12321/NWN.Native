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

public unsafe class CResDWK : CRes {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;

  internal CResDWK(global::System.IntPtr cPtr, bool cMemoryOwn) : base(NWNXLibPINVOKE.CResDWK_SWIGUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(CResDWK obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  protected override void Dispose(bool disposing) {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          NWNXLibPINVOKE.delete_CResDWK(swigCPtr);
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

  public static unsafe implicit operator void*(CResDWK self) {
    return (void*)self.swigCPtr.Handle;
  }

  public static unsafe CResDWK FromPointer(void* pointer, bool memoryOwn = false) {
    return pointer != null ? new CResDWK((global::System.IntPtr)pointer, memoryOwn) : null;
  }

  public static CResDWK FromPointer(global::System.IntPtr pointer, bool memoryOwn = false) {
    return pointer != global::System.IntPtr.Zero ? new CResDWK(pointer, memoryOwn) : null;
  }

  public bool Equals(CResDWK other) {
    if (ReferenceEquals(null, other)) {
      return false;
    }

    if (ReferenceEquals(this, other)) {
      return true;
    }

    return Pointer.Equals(other.Pointer);
  }

  public override bool Equals(object obj) {
    return ReferenceEquals(this, obj) || obj is CResDWK other && Equals(other);
  }

  public override int GetHashCode() {
    return swigCPtr.Handle.GetHashCode();
  }

  public static bool operator ==(CResDWK left, CResDWK right) {
    return Equals(left, right);
  }

  public static bool operator !=(CResDWK left, CResDWK right) {
    return !Equals(left, right);
  }

  public int m_bLoaded {
    set {
      NWNXLibPINVOKE.CResDWK_m_bLoaded_set(swigCPtr, value);
    } 
    get {
      int retVal = NWNXLibPINVOKE.CResDWK_m_bLoaded_get(swigCPtr);
      return retVal;
    }

  }

  public uint m_nDWKNormalSize {
    set {
      NWNXLibPINVOKE.CResDWK_m_nDWKNormalSize_set(swigCPtr, value);
    } 
    get {
      uint retVal = NWNXLibPINVOKE.CResDWK_m_nDWKNormalSize_get(swigCPtr);
      return retVal;
    }

  }

  public byte* m_pDWKData {
    set {
      NWNXLibPINVOKE.CResDWK_m_pDWKData_set(swigCPtr, value);
    } 
    get {
      byte* retVal = NWNXLibPINVOKE.CResDWK_m_pDWKData_get(swigCPtr);
      return retVal;
    }

  }

  public CResDWK() : this(NWNXLibPINVOKE.new_CResDWK(), true) {
  }

  public byte* GetDWKDataPtr() {
    byte* retVal = NWNXLibPINVOKE.CResDWK_GetDWKDataPtr(swigCPtr);
    return retVal;
  }

  public uint GetDWKSize() {
    uint retVal = NWNXLibPINVOKE.CResDWK_GetDWKSize(swigCPtr);
    return retVal;
  }

  public int IsLoaded() {
    int retVal = NWNXLibPINVOKE.CResDWK_IsLoaded(swigCPtr);
    return retVal;
  }

  public override int OnResourceFreed() {
    int retVal = NWNXLibPINVOKE.CResDWK_OnResourceFreed(swigCPtr);
    return retVal;
  }

  public override int OnResourceServiced() {
    int retVal = NWNXLibPINVOKE.CResDWK_OnResourceServiced(swigCPtr);
    return retVal;
  }

  public new void _Destructor() {
    NWNXLibPINVOKE.CResDWK__Destructor(swigCPtr);
  }

}

}

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

public unsafe class CStoreCustomer : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal CStoreCustomer(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(CStoreCustomer obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~CStoreCustomer() {
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
          NWNXLibPINVOKE.delete_CStoreCustomer(swigCPtr);
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

  public static unsafe implicit operator void*(CStoreCustomer self) {
    return (void*)self.swigCPtr.Handle;
  }

  public static unsafe CStoreCustomer FromPointer(void* pointer, bool memoryOwn = false) {
    return pointer != null ? new CStoreCustomer((global::System.IntPtr)pointer, memoryOwn) : null;
  }

  public static CStoreCustomer FromPointer(global::System.IntPtr pointer, bool memoryOwn = false) {
    return pointer != global::System.IntPtr.Zero ? new CStoreCustomer(pointer, memoryOwn) : null;
  }

  public bool Equals(CStoreCustomer other) {
    if (ReferenceEquals(null, other)) {
      return false;
    }

    if (ReferenceEquals(this, other)) {
      return true;
    }

    return Pointer.Equals(other.Pointer);
  }

  public override bool Equals(object obj) {
    return ReferenceEquals(this, obj) || obj is CStoreCustomer other && Equals(other);
  }

  public override int GetHashCode() {
    return swigCPtr.Handle.GetHashCode();
  }

  public static bool operator ==(CStoreCustomer left, CStoreCustomer right) {
    return Equals(left, right);
  }

  public static bool operator !=(CStoreCustomer left, CStoreCustomer right) {
    return !Equals(left, right);
  }
/*@SWIG@*/
  public uint m_oidObject {
    set {
      NWNXLibPINVOKE.CStoreCustomer_m_oidObject_set(swigCPtr, value);
    } 
    get {
      uint ret = NWNXLibPINVOKE.CStoreCustomer_m_oidObject_get(swigCPtr);
      return ret;
    } 
  }

  public byte m_nPage {
    set {
      NWNXLibPINVOKE.CStoreCustomer_m_nPage_set(swigCPtr, value);
    } 
    get {
      byte ret = NWNXLibPINVOKE.CStoreCustomer_m_nPage_get(swigCPtr);
      return ret;
    } 
  }

  public byte m_nPanel {
    set {
      NWNXLibPINVOKE.CStoreCustomer_m_nPanel_set(swigCPtr, value);
    } 
    get {
      byte ret = NWNXLibPINVOKE.CStoreCustomer_m_nPanel_get(swigCPtr);
      return ret;
    } 
  }

  public Vector m_vOpenPosition {
    set {
      NWNXLibPINVOKE.CStoreCustomer_m_vOpenPosition_set(swigCPtr, Vector.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = NWNXLibPINVOKE.CStoreCustomer_m_vOpenPosition_get(swigCPtr);
      Vector ret = (cPtr == global::System.IntPtr.Zero) ? null : new Vector(cPtr, false);
      return ret;
    } 
  }

  public char m_nBonusMarkUp {
    set {
      NWNXLibPINVOKE.CStoreCustomer_m_nBonusMarkUp_set(swigCPtr, value);
    } 
    get {
      char ret = NWNXLibPINVOKE.CStoreCustomer_m_nBonusMarkUp_get(swigCPtr);
      return ret;
    } 
  }

  public char m_nBonusMarkDown {
    set {
      NWNXLibPINVOKE.CStoreCustomer_m_nBonusMarkDown_set(swigCPtr, value);
    } 
    get {
      char ret = NWNXLibPINVOKE.CStoreCustomer_m_nBonusMarkDown_get(swigCPtr);
      return ret;
    } 
  }

  public CStoreCustomer() : this(NWNXLibPINVOKE.new_CStoreCustomer(), true) {
  }

}

}

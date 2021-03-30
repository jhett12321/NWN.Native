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

public unsafe class CExoInputClass : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  public CExoInputClass(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  public CExoInputClass(void* cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, (global::System.IntPtr)cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(CExoInputClass obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~CExoInputClass() {
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
          NWNXLibPINVOKE.delete_CExoInputClass(swigCPtr);
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

  public static unsafe implicit operator void*(CExoInputClass self) {
    return (void*)self.swigCPtr.Handle;
  }

  public static implicit operator global::System.IntPtr(CExoInputClass self) {
    return self.swigCPtr.Handle;
  }

  public bool Equals(CExoInputClass other) {
    if (ReferenceEquals(null, other)) {
      return false;
    }

    if (ReferenceEquals(this, other)) {
      return true;
    }

    return Pointer.Equals(other.Pointer);
  }

  public override bool Equals(object obj) {
    return ReferenceEquals(this, obj) || obj is CExoInputClass other && Equals(other);
  }

  public override int GetHashCode() {
    return swigCPtr.Handle.GetHashCode();
  }

  public static bool operator ==(CExoInputClass left, CExoInputClass right) {
    return Equals(left, right);
  }

  public static bool operator !=(CExoInputClass left, CExoInputClass right) {
    return !Equals(left, right);
  }

  public CExoString m_Label {
    set {
      NWNXLibPINVOKE.CExoInputClass_m_Label_set(swigCPtr, CExoString.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = NWNXLibPINVOKE.CExoInputClass_m_Label_get(swigCPtr);
      CExoString ret = (cPtr == global::System.IntPtr.Zero) ? null : new CExoString(cPtr, false);
      return ret;
    } 
  }

  public CExoLinkedListCExoInputEventDesc m_pUnassignedInputEventDescList {
    set {
      NWNXLibPINVOKE.CExoInputClass_m_pUnassignedInputEventDescList_set(swigCPtr, CExoLinkedListCExoInputEventDesc.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = NWNXLibPINVOKE.CExoInputClass_m_pUnassignedInputEventDescList_get(swigCPtr);
      CExoLinkedListCExoInputEventDesc ret = (cPtr == global::System.IntPtr.Zero) ? null : new CExoLinkedListCExoInputEventDesc(cPtr, false);
      return ret;
    } 
  }

  public CExoLinkedListCExoInputEventDesc m_pInputEventDescList {
    set {
      NWNXLibPINVOKE.CExoInputClass_m_pInputEventDescList_set(swigCPtr, CExoLinkedListCExoInputEventDesc.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = NWNXLibPINVOKE.CExoInputClass_m_pInputEventDescList_get(swigCPtr);
      CExoLinkedListCExoInputEventDesc ret = (cPtr == global::System.IntPtr.Zero) ? null : new CExoLinkedListCExoInputEventDesc(cPtr, false);
      return ret;
    } 
  }

  public CExoInputClass() : this(NWNXLibPINVOKE.new_CExoInputClass(), true) {
  }

}

}

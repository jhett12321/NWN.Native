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

public unsafe class CServerAIListArray : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  public CServerAIListArray(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  public CServerAIListArray(void* cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, (global::System.IntPtr)cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(CServerAIListArray obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~CServerAIListArray() {
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
          NWNXLibPINVOKE.delete_CServerAIListArray(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
    }
  }

  public CServerAIList this[int index] {
    get {
      return GetItem(index);
    }
    set {
      SetItem(index, value);
    }
  }

  public global::System.IntPtr Pointer {
    get {
      return swigCPtr.Handle;
    }
  }

  public static implicit operator void*(CServerAIListArray self) {
    return (void*)self.swigCPtr.Handle;
  }

  public static implicit operator global::System.IntPtr(CServerAIListArray self) {
    return self.swigCPtr.Handle;
  }

  public bool Equals(CServerAIListArray other) {
    if (ReferenceEquals(null, other)) {
      return false;
    }

    if (ReferenceEquals(this, other)) {
      return true;
    }

    return Pointer.Equals(other.Pointer);
  }

  public override bool Equals(object obj) {
    return ReferenceEquals(this, obj) || obj is CServerAIListArray other && Equals(other);
  }

  public override int GetHashCode() {
    return swigCPtr.Handle.GetHashCode();
  }

  public static bool operator ==(CServerAIListArray left, CServerAIListArray right) {
    return Equals(left, right);
  }

  public static bool operator !=(CServerAIListArray left, CServerAIListArray right) {
    return !Equals(left, right);
  }

  public CServerAIListArray(int nElements) : this(NWNXLibPINVOKE.new_CServerAIListArray(nElements), true) {
  }

  public CServerAIList GetItem(int index) {
    CServerAIList ret = new CServerAIList(NWNXLibPINVOKE.CServerAIListArray_GetItem(swigCPtr, index), true);
    return ret;
  }

  public void SetItem(int index, CServerAIList value) {
    NWNXLibPINVOKE.CServerAIListArray_SetItem(swigCPtr, index, CServerAIList.getCPtr(value));
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
  }

  public static CServerAIListArray FromPointer(CServerAIList ptr) {
    global::System.IntPtr cPtr = NWNXLibPINVOKE.CServerAIListArray_FromPointer(CServerAIList.getCPtr(ptr));
    CServerAIListArray ret = (cPtr == global::System.IntPtr.Zero) ? null : new CServerAIListArray(cPtr, false);
    return ret;
  }

}

}

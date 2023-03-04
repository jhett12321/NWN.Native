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

public unsafe class CNWActionNodeArray : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal CNWActionNodeArray(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(CNWActionNodeArray obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~CNWActionNodeArray() {
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
          NWNXLibPINVOKE.delete_CNWActionNodeArray(swigCPtr);
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

  public static unsafe implicit operator void*(CNWActionNodeArray self) {
    return (void*)self.swigCPtr.Handle;
  }

  public static unsafe CNWActionNodeArray FromPointer(void* pointer, bool memoryOwn = false) {
    return pointer != null ? new CNWActionNodeArray((global::System.IntPtr)pointer, memoryOwn) : null;
  }

  public static CNWActionNodeArray FromPointer(global::System.IntPtr pointer, bool memoryOwn = false) {
    return pointer != global::System.IntPtr.Zero ? new CNWActionNodeArray(pointer, memoryOwn) : null;
  }

  public bool Equals(CNWActionNodeArray other) {
    if (ReferenceEquals(null, other)) {
      return false;
    }

    if (ReferenceEquals(this, other)) {
      return true;
    }

    return Pointer.Equals(other.Pointer);
  }

  public override bool Equals(object obj) {
    return ReferenceEquals(this, obj) || obj is CNWActionNodeArray other && Equals(other);
  }

  public override int GetHashCode() {
    return swigCPtr.Handle.GetHashCode();
  }

  public static bool operator ==(CNWActionNodeArray left, CNWActionNodeArray right) {
    return Equals(left, right);
  }

  public static bool operator !=(CNWActionNodeArray left, CNWActionNodeArray right) {
    return !Equals(left, right);
  }


  public CNWActionNode this[int index] {
    get {
      return GetItem(index);
    }
    set {
      SetItem(index, value);
    }
  }
  public CNWActionNodeArray(int nElements) : this(NWNXLibPINVOKE.new_CNWActionNodeArray(nElements), true) {
  }

  public CNWActionNode GetItem(int index) {
    CNWActionNode ret = new CNWActionNode(NWNXLibPINVOKE.CNWActionNodeArray_GetItem(swigCPtr, index), true);
    return ret;
  }

  public void SetItem(int index, CNWActionNode value) {
    NWNXLibPINVOKE.CNWActionNodeArray_SetItem(swigCPtr, index, CNWActionNode.getCPtr(value));
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
  }

  public static CNWActionNodeArray FromPointer(CNWActionNode ptr) {
    global::System.IntPtr cPtr = NWNXLibPINVOKE.CNWActionNodeArray_FromPointer(CNWActionNode.getCPtr(ptr));
    CNWActionNodeArray ret = (cPtr == global::System.IntPtr.Zero) ? null : new CNWActionNodeArray(cPtr, false);
    return ret;
  }

}

}

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

public unsafe class CExoLinkedListNode : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal CExoLinkedListNode(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(CExoLinkedListNode obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~CExoLinkedListNode() {
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
          NWNXLibPINVOKE.delete_CExoLinkedListNode(swigCPtr);
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

  public static unsafe implicit operator void*(CExoLinkedListNode self) {
    return (void*)self.swigCPtr.Handle;
  }

  public static unsafe CExoLinkedListNode FromPointer(void* pointer, bool memoryOwn = false) {
    return pointer != null ? new CExoLinkedListNode((global::System.IntPtr)pointer, memoryOwn) : null;
  }

  public static CExoLinkedListNode FromPointer(global::System.IntPtr pointer, bool memoryOwn = false) {
    return pointer != global::System.IntPtr.Zero ? new CExoLinkedListNode(pointer, memoryOwn) : null;
  }

  public bool Equals(CExoLinkedListNode other) {
    if (ReferenceEquals(null, other)) {
      return false;
    }

    if (ReferenceEquals(this, other)) {
      return true;
    }

    return Pointer.Equals(other.Pointer);
  }

  public override bool Equals(object obj) {
    return ReferenceEquals(this, obj) || obj is CExoLinkedListNode other && Equals(other);
  }

  public override int GetHashCode() {
    return swigCPtr.Handle.GetHashCode();
  }

  public static bool operator ==(CExoLinkedListNode left, CExoLinkedListNode right) {
    return Equals(left, right);
  }

  public static bool operator !=(CExoLinkedListNode left, CExoLinkedListNode right) {
    return !Equals(left, right);
  }

  public CExoLinkedListNode pPrev {
    set {
      NWNXLibPINVOKE.CExoLinkedListNode_pPrev_set(swigCPtr, CExoLinkedListNode.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = NWNXLibPINVOKE.CExoLinkedListNode_pPrev_get(swigCPtr);
      CExoLinkedListNode ret = (cPtr == global::System.IntPtr.Zero) ? null : new CExoLinkedListNode(cPtr, false);
      return ret;
    } 
  }

  public CExoLinkedListNode pNext {
    set {
      NWNXLibPINVOKE.CExoLinkedListNode_pNext_set(swigCPtr, CExoLinkedListNode.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = NWNXLibPINVOKE.CExoLinkedListNode_pNext_get(swigCPtr);
      CExoLinkedListNode ret = (cPtr == global::System.IntPtr.Zero) ? null : new CExoLinkedListNode(cPtr, false);
      return ret;
    } 
  }

  public void* pObject {
    set {
      NWNXLibPINVOKE.CExoLinkedListNode_pObject_set(swigCPtr, (global::System.IntPtr)value);
    } 
    get {
        global::System.IntPtr retVal = NWNXLibPINVOKE.CExoLinkedListNode_pObject_get(swigCPtr);
        return (void*)retVal;
    }

  }

  public CExoLinkedListNode() : this(NWNXLibPINVOKE.new_CExoLinkedListNode(), true) {
  }

}

}

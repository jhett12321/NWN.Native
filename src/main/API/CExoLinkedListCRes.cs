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

public unsafe class CExoLinkedListCRes : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal CExoLinkedListCRes(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(CExoLinkedListCRes obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~CExoLinkedListCRes() {
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
          NWNXLibPINVOKE.delete_CExoLinkedListCRes(swigCPtr);
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

  public static unsafe implicit operator void*(CExoLinkedListCRes self) {
    return (void*)self.swigCPtr.Handle;
  }

  public static unsafe CExoLinkedListCRes FromPointer(void* pointer, bool memoryOwn = false) {
    return pointer != null ? new CExoLinkedListCRes((global::System.IntPtr)pointer, memoryOwn) : null;
  }

  public static CExoLinkedListCRes FromPointer(global::System.IntPtr pointer, bool memoryOwn = false) {
    return pointer != global::System.IntPtr.Zero ? new CExoLinkedListCRes(pointer, memoryOwn) : null;
  }

  public bool Equals(CExoLinkedListCRes other) {
    if (ReferenceEquals(null, other)) {
      return false;
    }

    if (ReferenceEquals(this, other)) {
      return true;
    }

    return Pointer.Equals(other.Pointer);
  }

  public override bool Equals(object obj) {
    return ReferenceEquals(this, obj) || obj is CExoLinkedListCRes other && Equals(other);
  }

  public override int GetHashCode() {
    return swigCPtr.Handle.GetHashCode();
  }

  public static bool operator ==(CExoLinkedListCRes left, CExoLinkedListCRes right) {
    return Equals(left, right);
  }

  public static bool operator !=(CExoLinkedListCRes left, CExoLinkedListCRes right) {
    return !Equals(left, right);
  }

  public CExoLinkedListInternal m_pcExoLinkedListInternal {
    set {
      NWNXLibPINVOKE.CExoLinkedListCRes_m_pcExoLinkedListInternal_set(swigCPtr, CExoLinkedListInternal.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = NWNXLibPINVOKE.CExoLinkedListCRes_m_pcExoLinkedListInternal_get(swigCPtr);
      CExoLinkedListInternal ret = (cPtr == global::System.IntPtr.Zero) ? null : new CExoLinkedListInternal(cPtr, false);
      return ret;
    } 
  }

  public CExoLinkedListCRes() : this(NWNXLibPINVOKE.new_CExoLinkedListCRes(), true) {
  }

  public CExoLinkedListNode AddHead(CRes Object) {
    global::System.IntPtr cPtr = NWNXLibPINVOKE.CExoLinkedListCRes_AddHead(swigCPtr, CRes.getCPtr(Object));
    CExoLinkedListNode ret = (cPtr == global::System.IntPtr.Zero) ? null : new CExoLinkedListNode(cPtr, false);
    return ret;
  }

  public CExoLinkedListNode AddTail(CRes Object) {
    global::System.IntPtr cPtr = NWNXLibPINVOKE.CExoLinkedListCRes_AddTail(swigCPtr, CRes.getCPtr(Object));
    CExoLinkedListNode ret = (cPtr == global::System.IntPtr.Zero) ? null : new CExoLinkedListNode(cPtr, false);
    return ret;
  }

  public CExoLinkedListNode AddAfter(CRes Object, CExoLinkedListNode Position) {
    global::System.IntPtr cPtr = NWNXLibPINVOKE.CExoLinkedListCRes_AddAfter(swigCPtr, CRes.getCPtr(Object), CExoLinkedListNode.getCPtr(Position));
    CExoLinkedListNode ret = (cPtr == global::System.IntPtr.Zero) ? null : new CExoLinkedListNode(cPtr, false);
    return ret;
  }

  public CExoLinkedListNode AddBefore(CRes Object, CExoLinkedListNode Position) {
    global::System.IntPtr cPtr = NWNXLibPINVOKE.CExoLinkedListCRes_AddBefore(swigCPtr, CRes.getCPtr(Object), CExoLinkedListNode.getCPtr(Position));
    CExoLinkedListNode ret = (cPtr == global::System.IntPtr.Zero) ? null : new CExoLinkedListNode(cPtr, false);
    return ret;
  }

  public uint Count() {
    uint retVal = NWNXLibPINVOKE.CExoLinkedListCRes_Count(swigCPtr);
    return retVal;
  }

  public CRes GetAtPos(CExoLinkedListNode Position) {
    global::System.IntPtr cPtr = NWNXLibPINVOKE.CExoLinkedListCRes_GetAtPos(swigCPtr, CExoLinkedListNode.getCPtr(Position));
    CRes ret = (cPtr == global::System.IntPtr.Zero) ? null : new CRes(cPtr, false);
    return ret;
  }

  public CRes GetHead() {
    global::System.IntPtr cPtr = NWNXLibPINVOKE.CExoLinkedListCRes_GetHead(swigCPtr);
    CRes ret = (cPtr == global::System.IntPtr.Zero) ? null : new CRes(cPtr, false);
    return ret;
  }

  public CExoLinkedListNode GetHeadPos() {
    global::System.IntPtr cPtr = NWNXLibPINVOKE.CExoLinkedListCRes_GetHeadPos(swigCPtr);
    CExoLinkedListNode ret = (cPtr == global::System.IntPtr.Zero) ? null : new CExoLinkedListNode(cPtr, false);
    return ret;
  }

  public CRes GetNext(void** Position) {
    global::System.IntPtr cPtr = NWNXLibPINVOKE.CExoLinkedListCRes_GetNext(swigCPtr, (global::System.IntPtr)Position);
    CRes ret = (cPtr == global::System.IntPtr.Zero) ? null : new CRes(cPtr, false);
    return ret;
  }

  public CRes GetPrev(void** Position) {
    global::System.IntPtr cPtr = NWNXLibPINVOKE.CExoLinkedListCRes_GetPrev(swigCPtr, (global::System.IntPtr)Position);
    CRes ret = (cPtr == global::System.IntPtr.Zero) ? null : new CRes(cPtr, false);
    return ret;
  }

  public CRes GetTail() {
    global::System.IntPtr cPtr = NWNXLibPINVOKE.CExoLinkedListCRes_GetTail(swigCPtr);
    CRes ret = (cPtr == global::System.IntPtr.Zero) ? null : new CRes(cPtr, false);
    return ret;
  }

  public CExoLinkedListNode GetTailPos() {
    global::System.IntPtr cPtr = NWNXLibPINVOKE.CExoLinkedListCRes_GetTailPos(swigCPtr);
    CExoLinkedListNode ret = (cPtr == global::System.IntPtr.Zero) ? null : new CExoLinkedListNode(cPtr, false);
    return ret;
  }

  public int IsEmpty() {
    int retVal = NWNXLibPINVOKE.CExoLinkedListCRes_IsEmpty(swigCPtr);
    return retVal;
  }

  public CRes RemoveHead() {
    global::System.IntPtr cPtr = NWNXLibPINVOKE.CExoLinkedListCRes_RemoveHead(swigCPtr);
    CRes ret = (cPtr == global::System.IntPtr.Zero) ? null : new CRes(cPtr, false);
    return ret;
  }

  public CRes RemoveTail() {
    global::System.IntPtr cPtr = NWNXLibPINVOKE.CExoLinkedListCRes_RemoveTail(swigCPtr);
    CRes ret = (cPtr == global::System.IntPtr.Zero) ? null : new CRes(cPtr, false);
    return ret;
  }

  public CRes Remove(CExoLinkedListNode Position) {
    global::System.IntPtr cPtr = NWNXLibPINVOKE.CExoLinkedListCRes_Remove(swigCPtr, CExoLinkedListNode.getCPtr(Position));
    CRes ret = (cPtr == global::System.IntPtr.Zero) ? null : new CRes(cPtr, false);
    return ret;
  }

}

}

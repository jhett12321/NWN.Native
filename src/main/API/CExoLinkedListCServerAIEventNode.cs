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

public unsafe class CExoLinkedListCServerAIEventNode : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal CExoLinkedListCServerAIEventNode(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(CExoLinkedListCServerAIEventNode obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~CExoLinkedListCServerAIEventNode() {
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
          NWNXLibPINVOKE.delete_CExoLinkedListCServerAIEventNode(swigCPtr);
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

  public static unsafe implicit operator void*(CExoLinkedListCServerAIEventNode self) {
    return (void*)self.swigCPtr.Handle;
  }

  public static unsafe CExoLinkedListCServerAIEventNode FromPointer(void* pointer, bool memoryOwn = false) {
    return pointer != null ? new CExoLinkedListCServerAIEventNode((global::System.IntPtr)pointer, memoryOwn) : null;
  }

  public static CExoLinkedListCServerAIEventNode FromPointer(global::System.IntPtr pointer, bool memoryOwn = false) {
    return pointer != global::System.IntPtr.Zero ? new CExoLinkedListCServerAIEventNode(pointer, memoryOwn) : null;
  }

  public bool Equals(CExoLinkedListCServerAIEventNode other) {
    if (ReferenceEquals(null, other)) {
      return false;
    }

    if (ReferenceEquals(this, other)) {
      return true;
    }

    return Pointer.Equals(other.Pointer);
  }

  public override bool Equals(object obj) {
    return ReferenceEquals(this, obj) || obj is CExoLinkedListCServerAIEventNode other && Equals(other);
  }

  public override int GetHashCode() {
    return swigCPtr.Handle.GetHashCode();
  }

  public static bool operator ==(CExoLinkedListCServerAIEventNode left, CExoLinkedListCServerAIEventNode right) {
    return Equals(left, right);
  }

  public static bool operator !=(CExoLinkedListCServerAIEventNode left, CExoLinkedListCServerAIEventNode right) {
    return !Equals(left, right);
  }

  public CExoLinkedListInternal m_pcExoLinkedListInternal {
    set {
      NWNXLibPINVOKE.CExoLinkedListCServerAIEventNode_m_pcExoLinkedListInternal_set(swigCPtr, CExoLinkedListInternal.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = NWNXLibPINVOKE.CExoLinkedListCServerAIEventNode_m_pcExoLinkedListInternal_get(swigCPtr);
      CExoLinkedListInternal ret = (cPtr == global::System.IntPtr.Zero) ? null : new CExoLinkedListInternal(cPtr, false);
      return ret;
    } 
  }

  public CExoLinkedListCServerAIEventNode() : this(NWNXLibPINVOKE.new_CExoLinkedListCServerAIEventNode(), true) {
  }

  public CExoLinkedListNode AddHead(CServerAIEventNode Object) {
    global::System.IntPtr cPtr = NWNXLibPINVOKE.CExoLinkedListCServerAIEventNode_AddHead(swigCPtr, CServerAIEventNode.getCPtr(Object));
    CExoLinkedListNode ret = (cPtr == global::System.IntPtr.Zero) ? null : new CExoLinkedListNode(cPtr, false);
    return ret;
  }

  public CExoLinkedListNode AddTail(CServerAIEventNode Object) {
    global::System.IntPtr cPtr = NWNXLibPINVOKE.CExoLinkedListCServerAIEventNode_AddTail(swigCPtr, CServerAIEventNode.getCPtr(Object));
    CExoLinkedListNode ret = (cPtr == global::System.IntPtr.Zero) ? null : new CExoLinkedListNode(cPtr, false);
    return ret;
  }

  public CExoLinkedListNode AddAfter(CServerAIEventNode Object, CExoLinkedListNode Position) {
    global::System.IntPtr cPtr = NWNXLibPINVOKE.CExoLinkedListCServerAIEventNode_AddAfter(swigCPtr, CServerAIEventNode.getCPtr(Object), CExoLinkedListNode.getCPtr(Position));
    CExoLinkedListNode ret = (cPtr == global::System.IntPtr.Zero) ? null : new CExoLinkedListNode(cPtr, false);
    return ret;
  }

  public CExoLinkedListNode AddBefore(CServerAIEventNode Object, CExoLinkedListNode Position) {
    global::System.IntPtr cPtr = NWNXLibPINVOKE.CExoLinkedListCServerAIEventNode_AddBefore(swigCPtr, CServerAIEventNode.getCPtr(Object), CExoLinkedListNode.getCPtr(Position));
    CExoLinkedListNode ret = (cPtr == global::System.IntPtr.Zero) ? null : new CExoLinkedListNode(cPtr, false);
    return ret;
  }

  public uint Count() {
    uint retVal = NWNXLibPINVOKE.CExoLinkedListCServerAIEventNode_Count(swigCPtr);
    return retVal;
  }

  public CServerAIEventNode GetAtPos(CExoLinkedListNode Position) {
    global::System.IntPtr cPtr = NWNXLibPINVOKE.CExoLinkedListCServerAIEventNode_GetAtPos(swigCPtr, CExoLinkedListNode.getCPtr(Position));
    CServerAIEventNode ret = (cPtr == global::System.IntPtr.Zero) ? null : new CServerAIEventNode(cPtr, false);
    return ret;
  }

  public CServerAIEventNode GetHead() {
    global::System.IntPtr cPtr = NWNXLibPINVOKE.CExoLinkedListCServerAIEventNode_GetHead(swigCPtr);
    CServerAIEventNode ret = (cPtr == global::System.IntPtr.Zero) ? null : new CServerAIEventNode(cPtr, false);
    return ret;
  }

  public CExoLinkedListNode GetHeadPos() {
    global::System.IntPtr cPtr = NWNXLibPINVOKE.CExoLinkedListCServerAIEventNode_GetHeadPos(swigCPtr);
    CExoLinkedListNode ret = (cPtr == global::System.IntPtr.Zero) ? null : new CExoLinkedListNode(cPtr, false);
    return ret;
  }

  public CServerAIEventNode GetNext(void** Position) {
    global::System.IntPtr cPtr = NWNXLibPINVOKE.CExoLinkedListCServerAIEventNode_GetNext(swigCPtr, (global::System.IntPtr)Position);
    CServerAIEventNode ret = (cPtr == global::System.IntPtr.Zero) ? null : new CServerAIEventNode(cPtr, false);
    return ret;
  }

  public CServerAIEventNode GetPrev(void** Position) {
    global::System.IntPtr cPtr = NWNXLibPINVOKE.CExoLinkedListCServerAIEventNode_GetPrev(swigCPtr, (global::System.IntPtr)Position);
    CServerAIEventNode ret = (cPtr == global::System.IntPtr.Zero) ? null : new CServerAIEventNode(cPtr, false);
    return ret;
  }

  public CServerAIEventNode GetTail() {
    global::System.IntPtr cPtr = NWNXLibPINVOKE.CExoLinkedListCServerAIEventNode_GetTail(swigCPtr);
    CServerAIEventNode ret = (cPtr == global::System.IntPtr.Zero) ? null : new CServerAIEventNode(cPtr, false);
    return ret;
  }

  public CExoLinkedListNode GetTailPos() {
    global::System.IntPtr cPtr = NWNXLibPINVOKE.CExoLinkedListCServerAIEventNode_GetTailPos(swigCPtr);
    CExoLinkedListNode ret = (cPtr == global::System.IntPtr.Zero) ? null : new CExoLinkedListNode(cPtr, false);
    return ret;
  }

  public int IsEmpty() {
    int retVal = NWNXLibPINVOKE.CExoLinkedListCServerAIEventNode_IsEmpty(swigCPtr);
    return retVal;
  }

  public CServerAIEventNode RemoveHead() {
    global::System.IntPtr cPtr = NWNXLibPINVOKE.CExoLinkedListCServerAIEventNode_RemoveHead(swigCPtr);
    CServerAIEventNode ret = (cPtr == global::System.IntPtr.Zero) ? null : new CServerAIEventNode(cPtr, false);
    return ret;
  }

  public CServerAIEventNode RemoveTail() {
    global::System.IntPtr cPtr = NWNXLibPINVOKE.CExoLinkedListCServerAIEventNode_RemoveTail(swigCPtr);
    CServerAIEventNode ret = (cPtr == global::System.IntPtr.Zero) ? null : new CServerAIEventNode(cPtr, false);
    return ret;
  }

  public CServerAIEventNode Remove(CExoLinkedListNode Position) {
    global::System.IntPtr cPtr = NWNXLibPINVOKE.CExoLinkedListCServerAIEventNode_Remove(swigCPtr, CExoLinkedListNode.getCPtr(Position));
    CServerAIEventNode ret = (cPtr == global::System.IntPtr.Zero) ? null : new CServerAIEventNode(cPtr, false);
    return ret;
  }

}

}

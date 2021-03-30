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

public unsafe class CExoLinkedListNWPlayerListItem : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  public CExoLinkedListNWPlayerListItem(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  public CExoLinkedListNWPlayerListItem(void* cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, (global::System.IntPtr)cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(CExoLinkedListNWPlayerListItem obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~CExoLinkedListNWPlayerListItem() {
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
          NWNXLibPINVOKE.delete_CExoLinkedListNWPlayerListItem(swigCPtr);
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

  public static unsafe implicit operator void*(CExoLinkedListNWPlayerListItem self) {
    return (void*)self.swigCPtr.Handle;
  }

  public static implicit operator global::System.IntPtr(CExoLinkedListNWPlayerListItem self) {
    return self.swigCPtr.Handle;
  }

  public bool Equals(CExoLinkedListNWPlayerListItem other) {
    if (ReferenceEquals(null, other)) {
      return false;
    }

    if (ReferenceEquals(this, other)) {
      return true;
    }

    return Pointer.Equals(other.Pointer);
  }

  public override bool Equals(object obj) {
    return ReferenceEquals(this, obj) || obj is CExoLinkedListNWPlayerListItem other && Equals(other);
  }

  public override int GetHashCode() {
    return swigCPtr.Handle.GetHashCode();
  }

  public static bool operator ==(CExoLinkedListNWPlayerListItem left, CExoLinkedListNWPlayerListItem right) {
    return Equals(left, right);
  }

  public static bool operator !=(CExoLinkedListNWPlayerListItem left, CExoLinkedListNWPlayerListItem right) {
    return !Equals(left, right);
  }

  public CExoLinkedListInternal m_pcExoLinkedListInternal {
    set {
      NWNXLibPINVOKE.CExoLinkedListNWPlayerListItem_m_pcExoLinkedListInternal_set(swigCPtr, CExoLinkedListInternal.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = NWNXLibPINVOKE.CExoLinkedListNWPlayerListItem_m_pcExoLinkedListInternal_get(swigCPtr);
      CExoLinkedListInternal ret = (cPtr == global::System.IntPtr.Zero) ? null : new CExoLinkedListInternal(cPtr, false);
      return ret;
    } 
  }

  public CExoLinkedListNWPlayerListItem() : this(NWNXLibPINVOKE.new_CExoLinkedListNWPlayerListItem(), true) {
  }

  public CExoLinkedListNode AddHead(NWPLAYERLISTITEM Object) {
    global::System.IntPtr cPtr = NWNXLibPINVOKE.CExoLinkedListNWPlayerListItem_AddHead(swigCPtr, NWPLAYERLISTITEM.getCPtr(Object));
    CExoLinkedListNode ret = (cPtr == global::System.IntPtr.Zero) ? null : new CExoLinkedListNode(cPtr, false);
    return ret;
  }

  public CExoLinkedListNode AddTail(NWPLAYERLISTITEM Object) {
    global::System.IntPtr cPtr = NWNXLibPINVOKE.CExoLinkedListNWPlayerListItem_AddTail(swigCPtr, NWPLAYERLISTITEM.getCPtr(Object));
    CExoLinkedListNode ret = (cPtr == global::System.IntPtr.Zero) ? null : new CExoLinkedListNode(cPtr, false);
    return ret;
  }

  public CExoLinkedListNode AddAfter(NWPLAYERLISTITEM Object, CExoLinkedListNode Position) {
    global::System.IntPtr cPtr = NWNXLibPINVOKE.CExoLinkedListNWPlayerListItem_AddAfter(swigCPtr, NWPLAYERLISTITEM.getCPtr(Object), CExoLinkedListNode.getCPtr(Position));
    CExoLinkedListNode ret = (cPtr == global::System.IntPtr.Zero) ? null : new CExoLinkedListNode(cPtr, false);
    return ret;
  }

  public CExoLinkedListNode AddBefore(NWPLAYERLISTITEM Object, CExoLinkedListNode Position) {
    global::System.IntPtr cPtr = NWNXLibPINVOKE.CExoLinkedListNWPlayerListItem_AddBefore(swigCPtr, NWPLAYERLISTITEM.getCPtr(Object), CExoLinkedListNode.getCPtr(Position));
    CExoLinkedListNode ret = (cPtr == global::System.IntPtr.Zero) ? null : new CExoLinkedListNode(cPtr, false);
    return ret;
  }

  public uint Count() {
    uint ret = NWNXLibPINVOKE.CExoLinkedListNWPlayerListItem_Count(swigCPtr);
    return ret;
  }

  public NWPLAYERLISTITEM GetAtPos(CExoLinkedListNode Position) {
    global::System.IntPtr cPtr = NWNXLibPINVOKE.CExoLinkedListNWPlayerListItem_GetAtPos(swigCPtr, CExoLinkedListNode.getCPtr(Position));
    NWPLAYERLISTITEM ret = (cPtr == global::System.IntPtr.Zero) ? null : new NWPLAYERLISTITEM(cPtr, false);
    return ret;
  }

  public NWPLAYERLISTITEM GetHead() {
    global::System.IntPtr cPtr = NWNXLibPINVOKE.CExoLinkedListNWPlayerListItem_GetHead(swigCPtr);
    NWPLAYERLISTITEM ret = (cPtr == global::System.IntPtr.Zero) ? null : new NWPLAYERLISTITEM(cPtr, false);
    return ret;
  }

  public CExoLinkedListNode GetHeadPos() {
    global::System.IntPtr cPtr = NWNXLibPINVOKE.CExoLinkedListNWPlayerListItem_GetHeadPos(swigCPtr);
    CExoLinkedListNode ret = (cPtr == global::System.IntPtr.Zero) ? null : new CExoLinkedListNode(cPtr, false);
    return ret;
  }

  public NWPLAYERLISTITEM GetNext(void** Position) {
    global::System.IntPtr cPtr = NWNXLibPINVOKE.CExoLinkedListNWPlayerListItem_GetNext(swigCPtr, (global::System.IntPtr)Position);
    NWPLAYERLISTITEM ret = (cPtr == global::System.IntPtr.Zero) ? null : new NWPLAYERLISTITEM(cPtr, false);
    return ret;
  }

  public NWPLAYERLISTITEM GetPrev(void** Position) {
    global::System.IntPtr cPtr = NWNXLibPINVOKE.CExoLinkedListNWPlayerListItem_GetPrev(swigCPtr, (global::System.IntPtr)Position);
    NWPLAYERLISTITEM ret = (cPtr == global::System.IntPtr.Zero) ? null : new NWPLAYERLISTITEM(cPtr, false);
    return ret;
  }

  public NWPLAYERLISTITEM GetTail() {
    global::System.IntPtr cPtr = NWNXLibPINVOKE.CExoLinkedListNWPlayerListItem_GetTail(swigCPtr);
    NWPLAYERLISTITEM ret = (cPtr == global::System.IntPtr.Zero) ? null : new NWPLAYERLISTITEM(cPtr, false);
    return ret;
  }

  public CExoLinkedListNode GetTailPos() {
    global::System.IntPtr cPtr = NWNXLibPINVOKE.CExoLinkedListNWPlayerListItem_GetTailPos(swigCPtr);
    CExoLinkedListNode ret = (cPtr == global::System.IntPtr.Zero) ? null : new CExoLinkedListNode(cPtr, false);
    return ret;
  }

  public int IsEmpty() {
    int ret = NWNXLibPINVOKE.CExoLinkedListNWPlayerListItem_IsEmpty(swigCPtr);
    return ret;
  }

  public NWPLAYERLISTITEM RemoveHead() {
    global::System.IntPtr cPtr = NWNXLibPINVOKE.CExoLinkedListNWPlayerListItem_RemoveHead(swigCPtr);
    NWPLAYERLISTITEM ret = (cPtr == global::System.IntPtr.Zero) ? null : new NWPLAYERLISTITEM(cPtr, false);
    return ret;
  }

  public NWPLAYERLISTITEM RemoveTail() {
    global::System.IntPtr cPtr = NWNXLibPINVOKE.CExoLinkedListNWPlayerListItem_RemoveTail(swigCPtr);
    NWPLAYERLISTITEM ret = (cPtr == global::System.IntPtr.Zero) ? null : new NWPLAYERLISTITEM(cPtr, false);
    return ret;
  }

  public NWPLAYERLISTITEM Remove(CExoLinkedListNode Position) {
    global::System.IntPtr cPtr = NWNXLibPINVOKE.CExoLinkedListNWPlayerListItem_Remove(swigCPtr, CExoLinkedListNode.getCPtr(Position));
    NWPLAYERLISTITEM ret = (cPtr == global::System.IntPtr.Zero) ? null : new NWPLAYERLISTITEM(cPtr, false);
    return ret;
  }

}

}

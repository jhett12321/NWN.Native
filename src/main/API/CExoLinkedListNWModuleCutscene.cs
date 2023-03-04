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

public unsafe class CExoLinkedListNWModuleCutscene : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal CExoLinkedListNWModuleCutscene(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(CExoLinkedListNWModuleCutscene obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~CExoLinkedListNWModuleCutscene() {
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
          NWNXLibPINVOKE.delete_CExoLinkedListNWModuleCutscene(swigCPtr);
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

  public static unsafe implicit operator void*(CExoLinkedListNWModuleCutscene self) {
    return (void*)self.swigCPtr.Handle;
  }

  public static unsafe CExoLinkedListNWModuleCutscene FromPointer(void* pointer, bool memoryOwn = false) {
    return pointer != null ? new CExoLinkedListNWModuleCutscene((global::System.IntPtr)pointer, memoryOwn) : null;
  }

  public static CExoLinkedListNWModuleCutscene FromPointer(global::System.IntPtr pointer, bool memoryOwn = false) {
    return pointer != global::System.IntPtr.Zero ? new CExoLinkedListNWModuleCutscene(pointer, memoryOwn) : null;
  }

  public bool Equals(CExoLinkedListNWModuleCutscene other) {
    if (ReferenceEquals(null, other)) {
      return false;
    }

    if (ReferenceEquals(this, other)) {
      return true;
    }

    return Pointer.Equals(other.Pointer);
  }

  public override bool Equals(object obj) {
    return ReferenceEquals(this, obj) || obj is CExoLinkedListNWModuleCutscene other && Equals(other);
  }

  public override int GetHashCode() {
    return swigCPtr.Handle.GetHashCode();
  }

  public static bool operator ==(CExoLinkedListNWModuleCutscene left, CExoLinkedListNWModuleCutscene right) {
    return Equals(left, right);
  }

  public static bool operator !=(CExoLinkedListNWModuleCutscene left, CExoLinkedListNWModuleCutscene right) {
    return !Equals(left, right);
  }

  public CExoLinkedListInternal m_pcExoLinkedListInternal {
    set {
      NWNXLibPINVOKE.CExoLinkedListNWModuleCutscene_m_pcExoLinkedListInternal_set(swigCPtr, CExoLinkedListInternal.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = NWNXLibPINVOKE.CExoLinkedListNWModuleCutscene_m_pcExoLinkedListInternal_get(swigCPtr);
      CExoLinkedListInternal ret = (cPtr == global::System.IntPtr.Zero) ? null : new CExoLinkedListInternal(cPtr, false);
      return ret;
    } 
  }

  public CExoLinkedListNWModuleCutscene() : this(NWNXLibPINVOKE.new_CExoLinkedListNWModuleCutscene(), true) {
  }

  public CExoLinkedListNode AddHead(NWMODULECUTSCENE Object) {
    global::System.IntPtr cPtr = NWNXLibPINVOKE.CExoLinkedListNWModuleCutscene_AddHead(swigCPtr, NWMODULECUTSCENE.getCPtr(Object));
    CExoLinkedListNode ret = (cPtr == global::System.IntPtr.Zero) ? null : new CExoLinkedListNode(cPtr, false);
    return ret;
  }

  public CExoLinkedListNode AddTail(NWMODULECUTSCENE Object) {
    global::System.IntPtr cPtr = NWNXLibPINVOKE.CExoLinkedListNWModuleCutscene_AddTail(swigCPtr, NWMODULECUTSCENE.getCPtr(Object));
    CExoLinkedListNode ret = (cPtr == global::System.IntPtr.Zero) ? null : new CExoLinkedListNode(cPtr, false);
    return ret;
  }

  public CExoLinkedListNode AddAfter(NWMODULECUTSCENE Object, CExoLinkedListNode Position) {
    global::System.IntPtr cPtr = NWNXLibPINVOKE.CExoLinkedListNWModuleCutscene_AddAfter(swigCPtr, NWMODULECUTSCENE.getCPtr(Object), CExoLinkedListNode.getCPtr(Position));
    CExoLinkedListNode ret = (cPtr == global::System.IntPtr.Zero) ? null : new CExoLinkedListNode(cPtr, false);
    return ret;
  }

  public CExoLinkedListNode AddBefore(NWMODULECUTSCENE Object, CExoLinkedListNode Position) {
    global::System.IntPtr cPtr = NWNXLibPINVOKE.CExoLinkedListNWModuleCutscene_AddBefore(swigCPtr, NWMODULECUTSCENE.getCPtr(Object), CExoLinkedListNode.getCPtr(Position));
    CExoLinkedListNode ret = (cPtr == global::System.IntPtr.Zero) ? null : new CExoLinkedListNode(cPtr, false);
    return ret;
  }

  public uint Count() {
    uint retVal = NWNXLibPINVOKE.CExoLinkedListNWModuleCutscene_Count(swigCPtr);
    return retVal;
  }

  public NWMODULECUTSCENE GetAtPos(CExoLinkedListNode Position) {
    global::System.IntPtr cPtr = NWNXLibPINVOKE.CExoLinkedListNWModuleCutscene_GetAtPos(swigCPtr, CExoLinkedListNode.getCPtr(Position));
    NWMODULECUTSCENE ret = (cPtr == global::System.IntPtr.Zero) ? null : new NWMODULECUTSCENE(cPtr, false);
    return ret;
  }

  public NWMODULECUTSCENE GetHead() {
    global::System.IntPtr cPtr = NWNXLibPINVOKE.CExoLinkedListNWModuleCutscene_GetHead(swigCPtr);
    NWMODULECUTSCENE ret = (cPtr == global::System.IntPtr.Zero) ? null : new NWMODULECUTSCENE(cPtr, false);
    return ret;
  }

  public CExoLinkedListNode GetHeadPos() {
    global::System.IntPtr cPtr = NWNXLibPINVOKE.CExoLinkedListNWModuleCutscene_GetHeadPos(swigCPtr);
    CExoLinkedListNode ret = (cPtr == global::System.IntPtr.Zero) ? null : new CExoLinkedListNode(cPtr, false);
    return ret;
  }

  public NWMODULECUTSCENE GetNext(void** Position) {
    global::System.IntPtr cPtr = NWNXLibPINVOKE.CExoLinkedListNWModuleCutscene_GetNext(swigCPtr, (global::System.IntPtr)Position);
    NWMODULECUTSCENE ret = (cPtr == global::System.IntPtr.Zero) ? null : new NWMODULECUTSCENE(cPtr, false);
    return ret;
  }

  public NWMODULECUTSCENE GetPrev(void** Position) {
    global::System.IntPtr cPtr = NWNXLibPINVOKE.CExoLinkedListNWModuleCutscene_GetPrev(swigCPtr, (global::System.IntPtr)Position);
    NWMODULECUTSCENE ret = (cPtr == global::System.IntPtr.Zero) ? null : new NWMODULECUTSCENE(cPtr, false);
    return ret;
  }

  public NWMODULECUTSCENE GetTail() {
    global::System.IntPtr cPtr = NWNXLibPINVOKE.CExoLinkedListNWModuleCutscene_GetTail(swigCPtr);
    NWMODULECUTSCENE ret = (cPtr == global::System.IntPtr.Zero) ? null : new NWMODULECUTSCENE(cPtr, false);
    return ret;
  }

  public CExoLinkedListNode GetTailPos() {
    global::System.IntPtr cPtr = NWNXLibPINVOKE.CExoLinkedListNWModuleCutscene_GetTailPos(swigCPtr);
    CExoLinkedListNode ret = (cPtr == global::System.IntPtr.Zero) ? null : new CExoLinkedListNode(cPtr, false);
    return ret;
  }

  public int IsEmpty() {
    int retVal = NWNXLibPINVOKE.CExoLinkedListNWModuleCutscene_IsEmpty(swigCPtr);
    return retVal;
  }

  public NWMODULECUTSCENE RemoveHead() {
    global::System.IntPtr cPtr = NWNXLibPINVOKE.CExoLinkedListNWModuleCutscene_RemoveHead(swigCPtr);
    NWMODULECUTSCENE ret = (cPtr == global::System.IntPtr.Zero) ? null : new NWMODULECUTSCENE(cPtr, false);
    return ret;
  }

  public NWMODULECUTSCENE RemoveTail() {
    global::System.IntPtr cPtr = NWNXLibPINVOKE.CExoLinkedListNWModuleCutscene_RemoveTail(swigCPtr);
    NWMODULECUTSCENE ret = (cPtr == global::System.IntPtr.Zero) ? null : new NWMODULECUTSCENE(cPtr, false);
    return ret;
  }

  public NWMODULECUTSCENE Remove(CExoLinkedListNode Position) {
    global::System.IntPtr cPtr = NWNXLibPINVOKE.CExoLinkedListNWModuleCutscene_Remove(swigCPtr, CExoLinkedListNode.getCPtr(Position));
    NWMODULECUTSCENE ret = (cPtr == global::System.IntPtr.Zero) ? null : new NWMODULECUTSCENE(cPtr, false);
    return ret;
  }

}

}

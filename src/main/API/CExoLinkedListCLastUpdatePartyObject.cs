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

public unsafe class CExoLinkedListCLastUpdatePartyObject : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal CExoLinkedListCLastUpdatePartyObject(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(CExoLinkedListCLastUpdatePartyObject obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~CExoLinkedListCLastUpdatePartyObject() {
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
          NWNXLibPINVOKE.delete_CExoLinkedListCLastUpdatePartyObject(swigCPtr);
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

  public static unsafe implicit operator void*(CExoLinkedListCLastUpdatePartyObject self) {
    return (void*)self.swigCPtr.Handle;
  }

  public static unsafe CExoLinkedListCLastUpdatePartyObject FromPointer(void* pointer, bool memoryOwn = false) {
    return pointer != null ? new CExoLinkedListCLastUpdatePartyObject((global::System.IntPtr)pointer, memoryOwn) : null;
  }

  public static CExoLinkedListCLastUpdatePartyObject FromPointer(global::System.IntPtr pointer, bool memoryOwn = false) {
    return pointer != global::System.IntPtr.Zero ? new CExoLinkedListCLastUpdatePartyObject(pointer, memoryOwn) : null;
  }

  public bool Equals(CExoLinkedListCLastUpdatePartyObject other) {
    if (ReferenceEquals(null, other)) {
      return false;
    }

    if (ReferenceEquals(this, other)) {
      return true;
    }

    return Pointer.Equals(other.Pointer);
  }

  public override bool Equals(object obj) {
    return ReferenceEquals(this, obj) || obj is CExoLinkedListCLastUpdatePartyObject other && Equals(other);
  }

  public override int GetHashCode() {
    return swigCPtr.Handle.GetHashCode();
  }

  public static bool operator ==(CExoLinkedListCLastUpdatePartyObject left, CExoLinkedListCLastUpdatePartyObject right) {
    return Equals(left, right);
  }

  public static bool operator !=(CExoLinkedListCLastUpdatePartyObject left, CExoLinkedListCLastUpdatePartyObject right) {
    return !Equals(left, right);
  }
/*@SWIG@*/
  public CExoLinkedListInternal m_pcExoLinkedListInternal {
    set {
      NWNXLibPINVOKE.CExoLinkedListCLastUpdatePartyObject_m_pcExoLinkedListInternal_set(swigCPtr, CExoLinkedListInternal.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = NWNXLibPINVOKE.CExoLinkedListCLastUpdatePartyObject_m_pcExoLinkedListInternal_get(swigCPtr);
      CExoLinkedListInternal ret = (cPtr == global::System.IntPtr.Zero) ? null : new CExoLinkedListInternal(cPtr, false);
      return ret;
    } 
  }

  public CExoLinkedListCLastUpdatePartyObject() : this(NWNXLibPINVOKE.new_CExoLinkedListCLastUpdatePartyObject(), true) {
  }

  public CExoLinkedListNode AddHead(CLastUpdatePartyObject Object) {
    global::System.IntPtr cPtr = NWNXLibPINVOKE.CExoLinkedListCLastUpdatePartyObject_AddHead(swigCPtr, CLastUpdatePartyObject.getCPtr(Object));
    CExoLinkedListNode ret = (cPtr == global::System.IntPtr.Zero) ? null : new CExoLinkedListNode(cPtr, false);
    return ret;
  }

  public CExoLinkedListNode AddTail(CLastUpdatePartyObject Object) {
    global::System.IntPtr cPtr = NWNXLibPINVOKE.CExoLinkedListCLastUpdatePartyObject_AddTail(swigCPtr, CLastUpdatePartyObject.getCPtr(Object));
    CExoLinkedListNode ret = (cPtr == global::System.IntPtr.Zero) ? null : new CExoLinkedListNode(cPtr, false);
    return ret;
  }

  public CExoLinkedListNode AddAfter(CLastUpdatePartyObject Object, CExoLinkedListNode Position) {
    global::System.IntPtr cPtr = NWNXLibPINVOKE.CExoLinkedListCLastUpdatePartyObject_AddAfter(swigCPtr, CLastUpdatePartyObject.getCPtr(Object), CExoLinkedListNode.getCPtr(Position));
    CExoLinkedListNode ret = (cPtr == global::System.IntPtr.Zero) ? null : new CExoLinkedListNode(cPtr, false);
    return ret;
  }

  public CExoLinkedListNode AddBefore(CLastUpdatePartyObject Object, CExoLinkedListNode Position) {
    global::System.IntPtr cPtr = NWNXLibPINVOKE.CExoLinkedListCLastUpdatePartyObject_AddBefore(swigCPtr, CLastUpdatePartyObject.getCPtr(Object), CExoLinkedListNode.getCPtr(Position));
    CExoLinkedListNode ret = (cPtr == global::System.IntPtr.Zero) ? null : new CExoLinkedListNode(cPtr, false);
    return ret;
  }

  public uint Count() {
    uint ret = NWNXLibPINVOKE.CExoLinkedListCLastUpdatePartyObject_Count(swigCPtr);
    return ret;
  }

  public CLastUpdatePartyObject GetAtPos(CExoLinkedListNode Position) {
    global::System.IntPtr cPtr = NWNXLibPINVOKE.CExoLinkedListCLastUpdatePartyObject_GetAtPos(swigCPtr, CExoLinkedListNode.getCPtr(Position));
    CLastUpdatePartyObject ret = (cPtr == global::System.IntPtr.Zero) ? null : new CLastUpdatePartyObject(cPtr, false);
    return ret;
  }

  public CLastUpdatePartyObject GetHead() {
    global::System.IntPtr cPtr = NWNXLibPINVOKE.CExoLinkedListCLastUpdatePartyObject_GetHead(swigCPtr);
    CLastUpdatePartyObject ret = (cPtr == global::System.IntPtr.Zero) ? null : new CLastUpdatePartyObject(cPtr, false);
    return ret;
  }

  public CExoLinkedListNode GetHeadPos() {
    global::System.IntPtr cPtr = NWNXLibPINVOKE.CExoLinkedListCLastUpdatePartyObject_GetHeadPos(swigCPtr);
    CExoLinkedListNode ret = (cPtr == global::System.IntPtr.Zero) ? null : new CExoLinkedListNode(cPtr, false);
    return ret;
  }

  public CLastUpdatePartyObject GetNext(void** Position) {
    global::System.IntPtr cPtr = NWNXLibPINVOKE.CExoLinkedListCLastUpdatePartyObject_GetNext(swigCPtr, (global::System.IntPtr)Position);
    CLastUpdatePartyObject ret = (cPtr == global::System.IntPtr.Zero) ? null : new CLastUpdatePartyObject(cPtr, false);
    return ret;
  }

  public CLastUpdatePartyObject GetPrev(void** Position) {
    global::System.IntPtr cPtr = NWNXLibPINVOKE.CExoLinkedListCLastUpdatePartyObject_GetPrev(swigCPtr, (global::System.IntPtr)Position);
    CLastUpdatePartyObject ret = (cPtr == global::System.IntPtr.Zero) ? null : new CLastUpdatePartyObject(cPtr, false);
    return ret;
  }

  public CLastUpdatePartyObject GetTail() {
    global::System.IntPtr cPtr = NWNXLibPINVOKE.CExoLinkedListCLastUpdatePartyObject_GetTail(swigCPtr);
    CLastUpdatePartyObject ret = (cPtr == global::System.IntPtr.Zero) ? null : new CLastUpdatePartyObject(cPtr, false);
    return ret;
  }

  public CExoLinkedListNode GetTailPos() {
    global::System.IntPtr cPtr = NWNXLibPINVOKE.CExoLinkedListCLastUpdatePartyObject_GetTailPos(swigCPtr);
    CExoLinkedListNode ret = (cPtr == global::System.IntPtr.Zero) ? null : new CExoLinkedListNode(cPtr, false);
    return ret;
  }

  public int IsEmpty() {
    int ret = NWNXLibPINVOKE.CExoLinkedListCLastUpdatePartyObject_IsEmpty(swigCPtr);
    return ret;
  }

  public CLastUpdatePartyObject RemoveHead() {
    global::System.IntPtr cPtr = NWNXLibPINVOKE.CExoLinkedListCLastUpdatePartyObject_RemoveHead(swigCPtr);
    CLastUpdatePartyObject ret = (cPtr == global::System.IntPtr.Zero) ? null : new CLastUpdatePartyObject(cPtr, false);
    return ret;
  }

  public CLastUpdatePartyObject RemoveTail() {
    global::System.IntPtr cPtr = NWNXLibPINVOKE.CExoLinkedListCLastUpdatePartyObject_RemoveTail(swigCPtr);
    CLastUpdatePartyObject ret = (cPtr == global::System.IntPtr.Zero) ? null : new CLastUpdatePartyObject(cPtr, false);
    return ret;
  }

  public CLastUpdatePartyObject Remove(CExoLinkedListNode Position) {
    global::System.IntPtr cPtr = NWNXLibPINVOKE.CExoLinkedListCLastUpdatePartyObject_Remove(swigCPtr, CExoLinkedListNode.getCPtr(Position));
    CLastUpdatePartyObject ret = (cPtr == global::System.IntPtr.Zero) ? null : new CLastUpdatePartyObject(cPtr, false);
    return ret;
  }

}

}

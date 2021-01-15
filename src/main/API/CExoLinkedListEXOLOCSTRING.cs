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

public class CExoLinkedListEXOLOCSTRING : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal CExoLinkedListEXOLOCSTRING(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(CExoLinkedListEXOLOCSTRING obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~CExoLinkedListEXOLOCSTRING() {
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
          NWNXLibPINVOKE.delete_CExoLinkedListEXOLOCSTRING(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
    }
  }

  public CExoLinkedListInternal m_pcExoLinkedListInternal {
    set {
      NWNXLibPINVOKE.CExoLinkedListEXOLOCSTRING_m_pcExoLinkedListInternal_set(swigCPtr, CExoLinkedListInternal.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = NWNXLibPINVOKE.CExoLinkedListEXOLOCSTRING_m_pcExoLinkedListInternal_get(swigCPtr);
      CExoLinkedListInternal ret = (cPtr == global::System.IntPtr.Zero) ? null : new CExoLinkedListInternal(cPtr, false);
      return ret;
    } 
  }

  public CExoLinkedListEXOLOCSTRING() : this(NWNXLibPINVOKE.new_CExoLinkedListEXOLOCSTRING(), true) {
  }

  public CExoLinkedListNode AddHead(EXOLOCSTRING Object) {
    global::System.IntPtr cPtr = NWNXLibPINVOKE.CExoLinkedListEXOLOCSTRING_AddHead(swigCPtr, EXOLOCSTRING.getCPtr(Object));
    CExoLinkedListNode ret = (cPtr == global::System.IntPtr.Zero) ? null : new CExoLinkedListNode(cPtr, false);
    return ret;
  }

  public CExoLinkedListNode AddTail(EXOLOCSTRING Object) {
    global::System.IntPtr cPtr = NWNXLibPINVOKE.CExoLinkedListEXOLOCSTRING_AddTail(swigCPtr, EXOLOCSTRING.getCPtr(Object));
    CExoLinkedListNode ret = (cPtr == global::System.IntPtr.Zero) ? null : new CExoLinkedListNode(cPtr, false);
    return ret;
  }

  public CExoLinkedListNode AddAfter(EXOLOCSTRING Object, CExoLinkedListNode Position) {
    global::System.IntPtr cPtr = NWNXLibPINVOKE.CExoLinkedListEXOLOCSTRING_AddAfter(swigCPtr, EXOLOCSTRING.getCPtr(Object), CExoLinkedListNode.getCPtr(Position));
    CExoLinkedListNode ret = (cPtr == global::System.IntPtr.Zero) ? null : new CExoLinkedListNode(cPtr, false);
    return ret;
  }

  public CExoLinkedListNode AddBefore(EXOLOCSTRING Object, CExoLinkedListNode Position) {
    global::System.IntPtr cPtr = NWNXLibPINVOKE.CExoLinkedListEXOLOCSTRING_AddBefore(swigCPtr, EXOLOCSTRING.getCPtr(Object), CExoLinkedListNode.getCPtr(Position));
    CExoLinkedListNode ret = (cPtr == global::System.IntPtr.Zero) ? null : new CExoLinkedListNode(cPtr, false);
    return ret;
  }

  public uint Count() {
    uint ret = NWNXLibPINVOKE.CExoLinkedListEXOLOCSTRING_Count(swigCPtr);
    return ret;
  }

  public EXOLOCSTRING GetAtPos(CExoLinkedListNode Position) {
    global::System.IntPtr cPtr = NWNXLibPINVOKE.CExoLinkedListEXOLOCSTRING_GetAtPos(swigCPtr, CExoLinkedListNode.getCPtr(Position));
    EXOLOCSTRING ret = (cPtr == global::System.IntPtr.Zero) ? null : new EXOLOCSTRING(cPtr, false);
    return ret;
  }

  public EXOLOCSTRING GetHead() {
    global::System.IntPtr cPtr = NWNXLibPINVOKE.CExoLinkedListEXOLOCSTRING_GetHead(swigCPtr);
    EXOLOCSTRING ret = (cPtr == global::System.IntPtr.Zero) ? null : new EXOLOCSTRING(cPtr, false);
    return ret;
  }

  public CExoLinkedListNode GetHeadPos() {
    global::System.IntPtr cPtr = NWNXLibPINVOKE.CExoLinkedListEXOLOCSTRING_GetHeadPos(swigCPtr);
    CExoLinkedListNode ret = (cPtr == global::System.IntPtr.Zero) ? null : new CExoLinkedListNode(cPtr, false);
    return ret;
  }

  public EXOLOCSTRING GetNext(SWIGTYPE_p_p_CExoLinkedListNode Position) {
    global::System.IntPtr cPtr = NWNXLibPINVOKE.CExoLinkedListEXOLOCSTRING_GetNext(swigCPtr, SWIGTYPE_p_p_CExoLinkedListNode.getCPtr(Position));
    EXOLOCSTRING ret = (cPtr == global::System.IntPtr.Zero) ? null : new EXOLOCSTRING(cPtr, false);
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public EXOLOCSTRING GetPrev(SWIGTYPE_p_p_CExoLinkedListNode Position) {
    global::System.IntPtr cPtr = NWNXLibPINVOKE.CExoLinkedListEXOLOCSTRING_GetPrev(swigCPtr, SWIGTYPE_p_p_CExoLinkedListNode.getCPtr(Position));
    EXOLOCSTRING ret = (cPtr == global::System.IntPtr.Zero) ? null : new EXOLOCSTRING(cPtr, false);
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public EXOLOCSTRING GetTail() {
    global::System.IntPtr cPtr = NWNXLibPINVOKE.CExoLinkedListEXOLOCSTRING_GetTail(swigCPtr);
    EXOLOCSTRING ret = (cPtr == global::System.IntPtr.Zero) ? null : new EXOLOCSTRING(cPtr, false);
    return ret;
  }

  public CExoLinkedListNode GetTailPos() {
    global::System.IntPtr cPtr = NWNXLibPINVOKE.CExoLinkedListEXOLOCSTRING_GetTailPos(swigCPtr);
    CExoLinkedListNode ret = (cPtr == global::System.IntPtr.Zero) ? null : new CExoLinkedListNode(cPtr, false);
    return ret;
  }

  public int IsEmpty() {
    int ret = NWNXLibPINVOKE.CExoLinkedListEXOLOCSTRING_IsEmpty(swigCPtr);
    return ret;
  }

  public EXOLOCSTRING RemoveHead() {
    global::System.IntPtr cPtr = NWNXLibPINVOKE.CExoLinkedListEXOLOCSTRING_RemoveHead(swigCPtr);
    EXOLOCSTRING ret = (cPtr == global::System.IntPtr.Zero) ? null : new EXOLOCSTRING(cPtr, false);
    return ret;
  }

  public EXOLOCSTRING RemoveTail() {
    global::System.IntPtr cPtr = NWNXLibPINVOKE.CExoLinkedListEXOLOCSTRING_RemoveTail(swigCPtr);
    EXOLOCSTRING ret = (cPtr == global::System.IntPtr.Zero) ? null : new EXOLOCSTRING(cPtr, false);
    return ret;
  }

  public EXOLOCSTRING Remove(CExoLinkedListNode Position) {
    global::System.IntPtr cPtr = NWNXLibPINVOKE.CExoLinkedListEXOLOCSTRING_Remove(swigCPtr, CExoLinkedListNode.getCPtr(Position));
    EXOLOCSTRING ret = (cPtr == global::System.IntPtr.Zero) ? null : new EXOLOCSTRING(cPtr, false);
    return ret;
  }

}

}
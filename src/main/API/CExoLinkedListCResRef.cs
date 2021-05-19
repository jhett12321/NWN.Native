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

public unsafe class CExoLinkedListCResRef : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal CExoLinkedListCResRef(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(CExoLinkedListCResRef obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~CExoLinkedListCResRef() {
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
          NWNXLibPINVOKE.delete_CExoLinkedListCResRef(swigCPtr);
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

  public static unsafe implicit operator void*(CExoLinkedListCResRef self) {
    return (void*)self.swigCPtr.Handle;
  }

  public static unsafe CExoLinkedListCResRef FromPointer(void* pointer, bool memoryOwn = false) {
    return pointer != null ? new CExoLinkedListCResRef((global::System.IntPtr)pointer, memoryOwn) : null;
  }

  public static CExoLinkedListCResRef FromPointer(global::System.IntPtr pointer, bool memoryOwn = false) {
    return pointer != global::System.IntPtr.Zero ? new CExoLinkedListCResRef(pointer, memoryOwn) : null;
  }

  public bool Equals(CExoLinkedListCResRef other) {
    if (ReferenceEquals(null, other)) {
      return false;
    }

    if (ReferenceEquals(this, other)) {
      return true;
    }

    return Pointer.Equals(other.Pointer);
  }

  public override bool Equals(object obj) {
    return ReferenceEquals(this, obj) || obj is CExoLinkedListCResRef other && Equals(other);
  }

  public override int GetHashCode() {
    return swigCPtr.Handle.GetHashCode();
  }

  public static bool operator ==(CExoLinkedListCResRef left, CExoLinkedListCResRef right) {
    return Equals(left, right);
  }

  public static bool operator !=(CExoLinkedListCResRef left, CExoLinkedListCResRef right) {
    return !Equals(left, right);
  }
/*@SWIG@*/
  public CExoLinkedListInternal m_pcExoLinkedListInternal {
    set {
      NWNXLibPINVOKE.CExoLinkedListCResRef_m_pcExoLinkedListInternal_set(swigCPtr, CExoLinkedListInternal.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = NWNXLibPINVOKE.CExoLinkedListCResRef_m_pcExoLinkedListInternal_get(swigCPtr);
      CExoLinkedListInternal ret = (cPtr == global::System.IntPtr.Zero) ? null : new CExoLinkedListInternal(cPtr, false);
      return ret;
    } 
  }

  public CExoLinkedListCResRef() : this(NWNXLibPINVOKE.new_CExoLinkedListCResRef(), true) {
  }

  public CExoLinkedListNode AddHead(CResRef Object) {
    global::System.IntPtr cPtr = NWNXLibPINVOKE.CExoLinkedListCResRef_AddHead(swigCPtr, CResRef.getCPtr(Object));
    CExoLinkedListNode ret = (cPtr == global::System.IntPtr.Zero) ? null : new CExoLinkedListNode(cPtr, false);
    return ret;
  }

  public CExoLinkedListNode AddTail(CResRef Object) {
    global::System.IntPtr cPtr = NWNXLibPINVOKE.CExoLinkedListCResRef_AddTail(swigCPtr, CResRef.getCPtr(Object));
    CExoLinkedListNode ret = (cPtr == global::System.IntPtr.Zero) ? null : new CExoLinkedListNode(cPtr, false);
    return ret;
  }

  public CExoLinkedListNode AddAfter(CResRef Object, CExoLinkedListNode Position) {
    global::System.IntPtr cPtr = NWNXLibPINVOKE.CExoLinkedListCResRef_AddAfter(swigCPtr, CResRef.getCPtr(Object), CExoLinkedListNode.getCPtr(Position));
    CExoLinkedListNode ret = (cPtr == global::System.IntPtr.Zero) ? null : new CExoLinkedListNode(cPtr, false);
    return ret;
  }

  public CExoLinkedListNode AddBefore(CResRef Object, CExoLinkedListNode Position) {
    global::System.IntPtr cPtr = NWNXLibPINVOKE.CExoLinkedListCResRef_AddBefore(swigCPtr, CResRef.getCPtr(Object), CExoLinkedListNode.getCPtr(Position));
    CExoLinkedListNode ret = (cPtr == global::System.IntPtr.Zero) ? null : new CExoLinkedListNode(cPtr, false);
    return ret;
  }

  public uint Count() {
    uint ret = NWNXLibPINVOKE.CExoLinkedListCResRef_Count(swigCPtr);
    return ret;
  }

  public CResRef GetAtPos(CExoLinkedListNode Position) {
    global::System.IntPtr cPtr = NWNXLibPINVOKE.CExoLinkedListCResRef_GetAtPos(swigCPtr, CExoLinkedListNode.getCPtr(Position));
    CResRef ret = (cPtr == global::System.IntPtr.Zero) ? null : new CResRef(cPtr, false);
    return ret;
  }

  public CResRef GetHead() {
    global::System.IntPtr cPtr = NWNXLibPINVOKE.CExoLinkedListCResRef_GetHead(swigCPtr);
    CResRef ret = (cPtr == global::System.IntPtr.Zero) ? null : new CResRef(cPtr, false);
    return ret;
  }

  public CExoLinkedListNode GetHeadPos() {
    global::System.IntPtr cPtr = NWNXLibPINVOKE.CExoLinkedListCResRef_GetHeadPos(swigCPtr);
    CExoLinkedListNode ret = (cPtr == global::System.IntPtr.Zero) ? null : new CExoLinkedListNode(cPtr, false);
    return ret;
  }

  public CResRef GetNext(void** Position) {
    global::System.IntPtr cPtr = NWNXLibPINVOKE.CExoLinkedListCResRef_GetNext(swigCPtr, (global::System.IntPtr)Position);
    CResRef ret = (cPtr == global::System.IntPtr.Zero) ? null : new CResRef(cPtr, false);
    return ret;
  }

  public CResRef GetPrev(void** Position) {
    global::System.IntPtr cPtr = NWNXLibPINVOKE.CExoLinkedListCResRef_GetPrev(swigCPtr, (global::System.IntPtr)Position);
    CResRef ret = (cPtr == global::System.IntPtr.Zero) ? null : new CResRef(cPtr, false);
    return ret;
  }

  public CResRef GetTail() {
    global::System.IntPtr cPtr = NWNXLibPINVOKE.CExoLinkedListCResRef_GetTail(swigCPtr);
    CResRef ret = (cPtr == global::System.IntPtr.Zero) ? null : new CResRef(cPtr, false);
    return ret;
  }

  public CExoLinkedListNode GetTailPos() {
    global::System.IntPtr cPtr = NWNXLibPINVOKE.CExoLinkedListCResRef_GetTailPos(swigCPtr);
    CExoLinkedListNode ret = (cPtr == global::System.IntPtr.Zero) ? null : new CExoLinkedListNode(cPtr, false);
    return ret;
  }

  public int IsEmpty() {
    int ret = NWNXLibPINVOKE.CExoLinkedListCResRef_IsEmpty(swigCPtr);
    return ret;
  }

  public CResRef RemoveHead() {
    global::System.IntPtr cPtr = NWNXLibPINVOKE.CExoLinkedListCResRef_RemoveHead(swigCPtr);
    CResRef ret = (cPtr == global::System.IntPtr.Zero) ? null : new CResRef(cPtr, false);
    return ret;
  }

  public CResRef RemoveTail() {
    global::System.IntPtr cPtr = NWNXLibPINVOKE.CExoLinkedListCResRef_RemoveTail(swigCPtr);
    CResRef ret = (cPtr == global::System.IntPtr.Zero) ? null : new CResRef(cPtr, false);
    return ret;
  }

  public CResRef Remove(CExoLinkedListNode Position) {
    global::System.IntPtr cPtr = NWNXLibPINVOKE.CExoLinkedListCResRef_Remove(swigCPtr, CExoLinkedListNode.getCPtr(Position));
    CResRef ret = (cPtr == global::System.IntPtr.Zero) ? null : new CResRef(cPtr, false);
    return ret;
  }

}

}

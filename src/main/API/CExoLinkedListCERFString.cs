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

public unsafe class CExoLinkedListCERFString : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal CExoLinkedListCERFString(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(CExoLinkedListCERFString obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~CExoLinkedListCERFString() {
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
          NWNXLibPINVOKE.delete_CExoLinkedListCERFString(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
    }
  }
/*@SWIG:/__w/NWN.Native/NWN.Native/nwnx/Plugins/SWIG/SWIG_DotNET/DotNETExtensions.i,1,SWIG_DOTNET_EXTENSIONS@*/
  public global::System.IntPtr Pointer {
    get {
      return swigCPtr.Handle;
    }
  }

  public static unsafe implicit operator void*(CExoLinkedListCERFString self) {
    return (void*)self.swigCPtr.Handle;
  }

  public static unsafe CExoLinkedListCERFString FromPointer(void* pointer, bool memoryOwn = false) {
    return pointer != null ? new CExoLinkedListCERFString((global::System.IntPtr)pointer, memoryOwn) : null;
  }

  public static CExoLinkedListCERFString FromPointer(global::System.IntPtr pointer, bool memoryOwn = false) {
    return pointer != global::System.IntPtr.Zero ? new CExoLinkedListCERFString(pointer, memoryOwn) : null;
  }

  public bool Equals(CExoLinkedListCERFString other) {
    if (ReferenceEquals(null, other)) {
      return false;
    }

    if (ReferenceEquals(this, other)) {
      return true;
    }

    return Pointer.Equals(other.Pointer);
  }

  public override bool Equals(object obj) {
    return ReferenceEquals(this, obj) || obj is CExoLinkedListCERFString other && Equals(other);
  }

  public override int GetHashCode() {
    return swigCPtr.Handle.GetHashCode();
  }

  public static bool operator ==(CExoLinkedListCERFString left, CExoLinkedListCERFString right) {
    return Equals(left, right);
  }

  public static bool operator !=(CExoLinkedListCERFString left, CExoLinkedListCERFString right) {
    return !Equals(left, right);
  }
/*@SWIG@*/
  public CExoLinkedListInternal m_pcExoLinkedListInternal {
    set {
      NWNXLibPINVOKE.CExoLinkedListCERFString_m_pcExoLinkedListInternal_set(swigCPtr, CExoLinkedListInternal.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = NWNXLibPINVOKE.CExoLinkedListCERFString_m_pcExoLinkedListInternal_get(swigCPtr);
      CExoLinkedListInternal ret = (cPtr == global::System.IntPtr.Zero) ? null : new CExoLinkedListInternal(cPtr, false);
      return ret;
    } 
  }

  public CExoLinkedListCERFString() : this(NWNXLibPINVOKE.new_CExoLinkedListCERFString(), true) {
  }

  public CExoLinkedListNode AddHead(CERFString Object) {
    global::System.IntPtr cPtr = NWNXLibPINVOKE.CExoLinkedListCERFString_AddHead(swigCPtr, CERFString.getCPtr(Object));
    CExoLinkedListNode ret = (cPtr == global::System.IntPtr.Zero) ? null : new CExoLinkedListNode(cPtr, false);
    return ret;
  }

  public CExoLinkedListNode AddTail(CERFString Object) {
    global::System.IntPtr cPtr = NWNXLibPINVOKE.CExoLinkedListCERFString_AddTail(swigCPtr, CERFString.getCPtr(Object));
    CExoLinkedListNode ret = (cPtr == global::System.IntPtr.Zero) ? null : new CExoLinkedListNode(cPtr, false);
    return ret;
  }

  public CExoLinkedListNode AddAfter(CERFString Object, CExoLinkedListNode Position) {
    global::System.IntPtr cPtr = NWNXLibPINVOKE.CExoLinkedListCERFString_AddAfter(swigCPtr, CERFString.getCPtr(Object), CExoLinkedListNode.getCPtr(Position));
    CExoLinkedListNode ret = (cPtr == global::System.IntPtr.Zero) ? null : new CExoLinkedListNode(cPtr, false);
    return ret;
  }

  public CExoLinkedListNode AddBefore(CERFString Object, CExoLinkedListNode Position) {
    global::System.IntPtr cPtr = NWNXLibPINVOKE.CExoLinkedListCERFString_AddBefore(swigCPtr, CERFString.getCPtr(Object), CExoLinkedListNode.getCPtr(Position));
    CExoLinkedListNode ret = (cPtr == global::System.IntPtr.Zero) ? null : new CExoLinkedListNode(cPtr, false);
    return ret;
  }

  public uint Count() {
    uint retVal = NWNXLibPINVOKE.CExoLinkedListCERFString_Count(swigCPtr);
    return retVal;
  }

  public CERFString GetAtPos(CExoLinkedListNode Position) {
    global::System.IntPtr cPtr = NWNXLibPINVOKE.CExoLinkedListCERFString_GetAtPos(swigCPtr, CExoLinkedListNode.getCPtr(Position));
    CERFString ret = (cPtr == global::System.IntPtr.Zero) ? null : new CERFString(cPtr, false);
    return ret;
  }

  public CERFString GetHead() {
    global::System.IntPtr cPtr = NWNXLibPINVOKE.CExoLinkedListCERFString_GetHead(swigCPtr);
    CERFString ret = (cPtr == global::System.IntPtr.Zero) ? null : new CERFString(cPtr, false);
    return ret;
  }

  public CExoLinkedListNode GetHeadPos() {
    global::System.IntPtr cPtr = NWNXLibPINVOKE.CExoLinkedListCERFString_GetHeadPos(swigCPtr);
    CExoLinkedListNode ret = (cPtr == global::System.IntPtr.Zero) ? null : new CExoLinkedListNode(cPtr, false);
    return ret;
  }

  public CERFString GetNext(void** Position) {
    global::System.IntPtr cPtr = NWNXLibPINVOKE.CExoLinkedListCERFString_GetNext(swigCPtr, (global::System.IntPtr)Position);
    CERFString ret = (cPtr == global::System.IntPtr.Zero) ? null : new CERFString(cPtr, false);
    return ret;
  }

  public CERFString GetPrev(void** Position) {
    global::System.IntPtr cPtr = NWNXLibPINVOKE.CExoLinkedListCERFString_GetPrev(swigCPtr, (global::System.IntPtr)Position);
    CERFString ret = (cPtr == global::System.IntPtr.Zero) ? null : new CERFString(cPtr, false);
    return ret;
  }

  public CERFString GetTail() {
    global::System.IntPtr cPtr = NWNXLibPINVOKE.CExoLinkedListCERFString_GetTail(swigCPtr);
    CERFString ret = (cPtr == global::System.IntPtr.Zero) ? null : new CERFString(cPtr, false);
    return ret;
  }

  public CExoLinkedListNode GetTailPos() {
    global::System.IntPtr cPtr = NWNXLibPINVOKE.CExoLinkedListCERFString_GetTailPos(swigCPtr);
    CExoLinkedListNode ret = (cPtr == global::System.IntPtr.Zero) ? null : new CExoLinkedListNode(cPtr, false);
    return ret;
  }

  public int IsEmpty() {
    int retVal = NWNXLibPINVOKE.CExoLinkedListCERFString_IsEmpty(swigCPtr);
    return retVal;
  }

  public CERFString RemoveHead() {
    global::System.IntPtr cPtr = NWNXLibPINVOKE.CExoLinkedListCERFString_RemoveHead(swigCPtr);
    CERFString ret = (cPtr == global::System.IntPtr.Zero) ? null : new CERFString(cPtr, false);
    return ret;
  }

  public CERFString RemoveTail() {
    global::System.IntPtr cPtr = NWNXLibPINVOKE.CExoLinkedListCERFString_RemoveTail(swigCPtr);
    CERFString ret = (cPtr == global::System.IntPtr.Zero) ? null : new CERFString(cPtr, false);
    return ret;
  }

  public CERFString Remove(CExoLinkedListNode Position) {
    global::System.IntPtr cPtr = NWNXLibPINVOKE.CExoLinkedListCERFString_Remove(swigCPtr, CExoLinkedListNode.getCPtr(Position));
    CERFString ret = (cPtr == global::System.IntPtr.Zero) ? null : new CERFString(cPtr, false);
    return ret;
  }

}

}

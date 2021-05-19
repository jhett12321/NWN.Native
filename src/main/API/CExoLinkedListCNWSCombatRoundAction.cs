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

public unsafe class CExoLinkedListCNWSCombatRoundAction : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal CExoLinkedListCNWSCombatRoundAction(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(CExoLinkedListCNWSCombatRoundAction obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~CExoLinkedListCNWSCombatRoundAction() {
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
          NWNXLibPINVOKE.delete_CExoLinkedListCNWSCombatRoundAction(swigCPtr);
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

  public static unsafe implicit operator void*(CExoLinkedListCNWSCombatRoundAction self) {
    return (void*)self.swigCPtr.Handle;
  }

  public static unsafe CExoLinkedListCNWSCombatRoundAction FromPointer(void* pointer, bool memoryOwn = false) {
    return pointer != null ? new CExoLinkedListCNWSCombatRoundAction((global::System.IntPtr)pointer, memoryOwn) : null;
  }

  public static CExoLinkedListCNWSCombatRoundAction FromPointer(global::System.IntPtr pointer, bool memoryOwn = false) {
    return pointer != global::System.IntPtr.Zero ? new CExoLinkedListCNWSCombatRoundAction(pointer, memoryOwn) : null;
  }

  public bool Equals(CExoLinkedListCNWSCombatRoundAction other) {
    if (ReferenceEquals(null, other)) {
      return false;
    }

    if (ReferenceEquals(this, other)) {
      return true;
    }

    return Pointer.Equals(other.Pointer);
  }

  public override bool Equals(object obj) {
    return ReferenceEquals(this, obj) || obj is CExoLinkedListCNWSCombatRoundAction other && Equals(other);
  }

  public override int GetHashCode() {
    return swigCPtr.Handle.GetHashCode();
  }

  public static bool operator ==(CExoLinkedListCNWSCombatRoundAction left, CExoLinkedListCNWSCombatRoundAction right) {
    return Equals(left, right);
  }

  public static bool operator !=(CExoLinkedListCNWSCombatRoundAction left, CExoLinkedListCNWSCombatRoundAction right) {
    return !Equals(left, right);
  }
/*@SWIG@*/
  public CExoLinkedListInternal m_pcExoLinkedListInternal {
    set {
      NWNXLibPINVOKE.CExoLinkedListCNWSCombatRoundAction_m_pcExoLinkedListInternal_set(swigCPtr, CExoLinkedListInternal.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = NWNXLibPINVOKE.CExoLinkedListCNWSCombatRoundAction_m_pcExoLinkedListInternal_get(swigCPtr);
      CExoLinkedListInternal ret = (cPtr == global::System.IntPtr.Zero) ? null : new CExoLinkedListInternal(cPtr, false);
      return ret;
    } 
  }

  public CExoLinkedListCNWSCombatRoundAction() : this(NWNXLibPINVOKE.new_CExoLinkedListCNWSCombatRoundAction(), true) {
  }

  public CExoLinkedListNode AddHead(CNWSCombatRoundAction Object) {
    global::System.IntPtr cPtr = NWNXLibPINVOKE.CExoLinkedListCNWSCombatRoundAction_AddHead(swigCPtr, CNWSCombatRoundAction.getCPtr(Object));
    CExoLinkedListNode ret = (cPtr == global::System.IntPtr.Zero) ? null : new CExoLinkedListNode(cPtr, false);
    return ret;
  }

  public CExoLinkedListNode AddTail(CNWSCombatRoundAction Object) {
    global::System.IntPtr cPtr = NWNXLibPINVOKE.CExoLinkedListCNWSCombatRoundAction_AddTail(swigCPtr, CNWSCombatRoundAction.getCPtr(Object));
    CExoLinkedListNode ret = (cPtr == global::System.IntPtr.Zero) ? null : new CExoLinkedListNode(cPtr, false);
    return ret;
  }

  public CExoLinkedListNode AddAfter(CNWSCombatRoundAction Object, CExoLinkedListNode Position) {
    global::System.IntPtr cPtr = NWNXLibPINVOKE.CExoLinkedListCNWSCombatRoundAction_AddAfter(swigCPtr, CNWSCombatRoundAction.getCPtr(Object), CExoLinkedListNode.getCPtr(Position));
    CExoLinkedListNode ret = (cPtr == global::System.IntPtr.Zero) ? null : new CExoLinkedListNode(cPtr, false);
    return ret;
  }

  public CExoLinkedListNode AddBefore(CNWSCombatRoundAction Object, CExoLinkedListNode Position) {
    global::System.IntPtr cPtr = NWNXLibPINVOKE.CExoLinkedListCNWSCombatRoundAction_AddBefore(swigCPtr, CNWSCombatRoundAction.getCPtr(Object), CExoLinkedListNode.getCPtr(Position));
    CExoLinkedListNode ret = (cPtr == global::System.IntPtr.Zero) ? null : new CExoLinkedListNode(cPtr, false);
    return ret;
  }

  public uint Count() {
    uint ret = NWNXLibPINVOKE.CExoLinkedListCNWSCombatRoundAction_Count(swigCPtr);
    return ret;
  }

  public CNWSCombatRoundAction GetAtPos(CExoLinkedListNode Position) {
    global::System.IntPtr cPtr = NWNXLibPINVOKE.CExoLinkedListCNWSCombatRoundAction_GetAtPos(swigCPtr, CExoLinkedListNode.getCPtr(Position));
    CNWSCombatRoundAction ret = (cPtr == global::System.IntPtr.Zero) ? null : new CNWSCombatRoundAction(cPtr, false);
    return ret;
  }

  public CNWSCombatRoundAction GetHead() {
    global::System.IntPtr cPtr = NWNXLibPINVOKE.CExoLinkedListCNWSCombatRoundAction_GetHead(swigCPtr);
    CNWSCombatRoundAction ret = (cPtr == global::System.IntPtr.Zero) ? null : new CNWSCombatRoundAction(cPtr, false);
    return ret;
  }

  public CExoLinkedListNode GetHeadPos() {
    global::System.IntPtr cPtr = NWNXLibPINVOKE.CExoLinkedListCNWSCombatRoundAction_GetHeadPos(swigCPtr);
    CExoLinkedListNode ret = (cPtr == global::System.IntPtr.Zero) ? null : new CExoLinkedListNode(cPtr, false);
    return ret;
  }

  public CNWSCombatRoundAction GetNext(void** Position) {
    global::System.IntPtr cPtr = NWNXLibPINVOKE.CExoLinkedListCNWSCombatRoundAction_GetNext(swigCPtr, (global::System.IntPtr)Position);
    CNWSCombatRoundAction ret = (cPtr == global::System.IntPtr.Zero) ? null : new CNWSCombatRoundAction(cPtr, false);
    return ret;
  }

  public CNWSCombatRoundAction GetPrev(void** Position) {
    global::System.IntPtr cPtr = NWNXLibPINVOKE.CExoLinkedListCNWSCombatRoundAction_GetPrev(swigCPtr, (global::System.IntPtr)Position);
    CNWSCombatRoundAction ret = (cPtr == global::System.IntPtr.Zero) ? null : new CNWSCombatRoundAction(cPtr, false);
    return ret;
  }

  public CNWSCombatRoundAction GetTail() {
    global::System.IntPtr cPtr = NWNXLibPINVOKE.CExoLinkedListCNWSCombatRoundAction_GetTail(swigCPtr);
    CNWSCombatRoundAction ret = (cPtr == global::System.IntPtr.Zero) ? null : new CNWSCombatRoundAction(cPtr, false);
    return ret;
  }

  public CExoLinkedListNode GetTailPos() {
    global::System.IntPtr cPtr = NWNXLibPINVOKE.CExoLinkedListCNWSCombatRoundAction_GetTailPos(swigCPtr);
    CExoLinkedListNode ret = (cPtr == global::System.IntPtr.Zero) ? null : new CExoLinkedListNode(cPtr, false);
    return ret;
  }

  public int IsEmpty() {
    int ret = NWNXLibPINVOKE.CExoLinkedListCNWSCombatRoundAction_IsEmpty(swigCPtr);
    return ret;
  }

  public CNWSCombatRoundAction RemoveHead() {
    global::System.IntPtr cPtr = NWNXLibPINVOKE.CExoLinkedListCNWSCombatRoundAction_RemoveHead(swigCPtr);
    CNWSCombatRoundAction ret = (cPtr == global::System.IntPtr.Zero) ? null : new CNWSCombatRoundAction(cPtr, false);
    return ret;
  }

  public CNWSCombatRoundAction RemoveTail() {
    global::System.IntPtr cPtr = NWNXLibPINVOKE.CExoLinkedListCNWSCombatRoundAction_RemoveTail(swigCPtr);
    CNWSCombatRoundAction ret = (cPtr == global::System.IntPtr.Zero) ? null : new CNWSCombatRoundAction(cPtr, false);
    return ret;
  }

  public CNWSCombatRoundAction Remove(CExoLinkedListNode Position) {
    global::System.IntPtr cPtr = NWNXLibPINVOKE.CExoLinkedListCNWSCombatRoundAction_Remove(swigCPtr, CExoLinkedListNode.getCPtr(Position));
    CNWSCombatRoundAction ret = (cPtr == global::System.IntPtr.Zero) ? null : new CNWSCombatRoundAction(cPtr, false);
    return ret;
  }

}

}

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

public unsafe class CExoArrayListCCombatInformationNodePtr : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  public CExoArrayListCCombatInformationNodePtr(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  public CExoArrayListCCombatInformationNodePtr(void* cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, (global::System.IntPtr)cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(CExoArrayListCCombatInformationNodePtr obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~CExoArrayListCCombatInformationNodePtr() {
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
          NWNXLibPINVOKE.delete_CExoArrayListCCombatInformationNodePtr(swigCPtr);
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

  public static unsafe implicit operator void*(CExoArrayListCCombatInformationNodePtr self) {
    return (void*)self.swigCPtr.Handle;
  }

  public static implicit operator global::System.IntPtr(CExoArrayListCCombatInformationNodePtr self) {
    return self.swigCPtr.Handle;
  }

  public bool Equals(CExoArrayListCCombatInformationNodePtr other) {
    if (ReferenceEquals(null, other)) {
      return false;
    }

    if (ReferenceEquals(this, other)) {
      return true;
    }

    return Pointer.Equals(other.Pointer);
  }

  public override bool Equals(object obj) {
    return ReferenceEquals(this, obj) || obj is CExoArrayListCCombatInformationNodePtr other && Equals(other);
  }

  public override int GetHashCode() {
    return swigCPtr.Handle.GetHashCode();
  }

  public static bool operator ==(CExoArrayListCCombatInformationNodePtr left, CExoArrayListCCombatInformationNodePtr right) {
    return Equals(left, right);
  }

  public static bool operator !=(CExoArrayListCCombatInformationNodePtr left, CExoArrayListCCombatInformationNodePtr right) {
    return !Equals(left, right);
  }

  public void** element {
    set {
      NWNXLibPINVOKE.CExoArrayListCCombatInformationNodePtr_element_set(swigCPtr, (global::System.IntPtr)value);
    }  
    get {
        global::System.IntPtr retVal = NWNXLibPINVOKE.CExoArrayListCCombatInformationNodePtr_element_get(swigCPtr); 
        return (void**)retVal; 
    }

  }

  public int num {
    set {
      NWNXLibPINVOKE.CExoArrayListCCombatInformationNodePtr_num_set(swigCPtr, value);
    } 
    get {
      int ret = NWNXLibPINVOKE.CExoArrayListCCombatInformationNodePtr_num_get(swigCPtr);
      return ret;
    } 
  }

  public int array_size {
    set {
      NWNXLibPINVOKE.CExoArrayListCCombatInformationNodePtr_array_size_set(swigCPtr, value);
    } 
    get {
      int ret = NWNXLibPINVOKE.CExoArrayListCCombatInformationNodePtr_array_size_get(swigCPtr);
      return ret;
    } 
  }

  public CExoArrayListCCombatInformationNodePtr(int s) : this(NWNXLibPINVOKE.new_CExoArrayListCCombatInformationNodePtr__SWIG_0(s), true) {
  }

  public CExoArrayListCCombatInformationNodePtr() : this(NWNXLibPINVOKE.new_CExoArrayListCCombatInformationNodePtr__SWIG_1(), true) {
  }

  public CExoArrayListCCombatInformationNodePtr(CExoArrayListCCombatInformationNodePtr list) : this(NWNXLibPINVOKE.new_CExoArrayListCCombatInformationNodePtr__SWIG_2(CExoArrayListCCombatInformationNodePtr.getCPtr(list)), true) {
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
  }

  public CExoArrayListCCombatInformationNodePtr _OpAssign(CExoArrayListCCombatInformationNodePtr list) {
    CExoArrayListCCombatInformationNodePtr ret = new CExoArrayListCCombatInformationNodePtr(NWNXLibPINVOKE.CExoArrayListCCombatInformationNodePtr__OpAssign(swigCPtr, CExoArrayListCCombatInformationNodePtr.getCPtr(list)), false);
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void** _OpIndex(int i) { 
    global::System.IntPtr retVal = NWNXLibPINVOKE.CExoArrayListCCombatInformationNodePtr__OpIndex(swigCPtr, i);
    return (void**)retVal;
  }

  public void Allocate(int s) {
    NWNXLibPINVOKE.CExoArrayListCCombatInformationNodePtr_Allocate(swigCPtr, s);
  }

  public void SetSize(int s) {
    NWNXLibPINVOKE.CExoArrayListCCombatInformationNodePtr_SetSize(swigCPtr, s);
  }

  public void Pack() {
    NWNXLibPINVOKE.CExoArrayListCCombatInformationNodePtr_Pack(swigCPtr);
  }

  public void Add(CCombatInformationNode t) {
    NWNXLibPINVOKE.CExoArrayListCCombatInformationNodePtr_Add(swigCPtr, CCombatInformationNode.getCPtr(t));
  }

  public void Insert(CCombatInformationNode t, int k) {
    NWNXLibPINVOKE.CExoArrayListCCombatInformationNodePtr_Insert(swigCPtr, CCombatInformationNode.getCPtr(t), k);
  }

  public void DelIndex(int i) {
    NWNXLibPINVOKE.CExoArrayListCCombatInformationNodePtr_DelIndex(swigCPtr, i);
  }

  public void** begin() { 
    global::System.IntPtr retVal = NWNXLibPINVOKE.CExoArrayListCCombatInformationNodePtr_begin(swigCPtr);
    return (void**)retVal;
  }

  public void** end() { 
    global::System.IntPtr retVal = NWNXLibPINVOKE.CExoArrayListCCombatInformationNodePtr_end(swigCPtr);
    return (void**)retVal;
  }

}

}

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

public unsafe class CExoArrayListCNWSStatsSpellLikeAbility : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  public CExoArrayListCNWSStatsSpellLikeAbility(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  public CExoArrayListCNWSStatsSpellLikeAbility(void* cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, (global::System.IntPtr)cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(CExoArrayListCNWSStatsSpellLikeAbility obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~CExoArrayListCNWSStatsSpellLikeAbility() {
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
          NWNXLibPINVOKE.delete_CExoArrayListCNWSStatsSpellLikeAbility(swigCPtr);
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

  public static unsafe implicit operator void*(CExoArrayListCNWSStatsSpellLikeAbility self) {
    return (void*)self.swigCPtr.Handle;
  }

  public static implicit operator global::System.IntPtr(CExoArrayListCNWSStatsSpellLikeAbility self) {
    return self.swigCPtr.Handle;
  }

  public bool Equals(CExoArrayListCNWSStatsSpellLikeAbility other) {
    if (ReferenceEquals(null, other)) {
      return false;
    }

    if (ReferenceEquals(this, other)) {
      return true;
    }

    return Pointer.Equals(other.Pointer);
  }

  public override bool Equals(object obj) {
    return ReferenceEquals(this, obj) || obj is CExoArrayListCNWSStatsSpellLikeAbility other && Equals(other);
  }

  public override int GetHashCode() {
    return swigCPtr.Handle.GetHashCode();
  }

  public static bool operator ==(CExoArrayListCNWSStatsSpellLikeAbility left, CExoArrayListCNWSStatsSpellLikeAbility right) {
    return Equals(left, right);
  }

  public static bool operator !=(CExoArrayListCNWSStatsSpellLikeAbility left, CExoArrayListCNWSStatsSpellLikeAbility right) {
    return !Equals(left, right);
  }

  public CNWSStats_SpellLikeAbility element {
    set {
      NWNXLibPINVOKE.CExoArrayListCNWSStatsSpellLikeAbility_element_set(swigCPtr, CNWSStats_SpellLikeAbility.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = NWNXLibPINVOKE.CExoArrayListCNWSStatsSpellLikeAbility_element_get(swigCPtr);
      CNWSStats_SpellLikeAbility ret = (cPtr == global::System.IntPtr.Zero) ? null : new CNWSStats_SpellLikeAbility(cPtr, false);
      return ret;
    } 
  }

  public int num {
    set {
      NWNXLibPINVOKE.CExoArrayListCNWSStatsSpellLikeAbility_num_set(swigCPtr, value);
    } 
    get {
      int ret = NWNXLibPINVOKE.CExoArrayListCNWSStatsSpellLikeAbility_num_get(swigCPtr);
      return ret;
    } 
  }

  public int array_size {
    set {
      NWNXLibPINVOKE.CExoArrayListCNWSStatsSpellLikeAbility_array_size_set(swigCPtr, value);
    } 
    get {
      int ret = NWNXLibPINVOKE.CExoArrayListCNWSStatsSpellLikeAbility_array_size_get(swigCPtr);
      return ret;
    } 
  }

  public CExoArrayListCNWSStatsSpellLikeAbility(int s) : this(NWNXLibPINVOKE.new_CExoArrayListCNWSStatsSpellLikeAbility__SWIG_0(s), true) {
  }

  public CExoArrayListCNWSStatsSpellLikeAbility() : this(NWNXLibPINVOKE.new_CExoArrayListCNWSStatsSpellLikeAbility__SWIG_1(), true) {
  }

  public CExoArrayListCNWSStatsSpellLikeAbility(CExoArrayListCNWSStatsSpellLikeAbility list) : this(NWNXLibPINVOKE.new_CExoArrayListCNWSStatsSpellLikeAbility__SWIG_2(CExoArrayListCNWSStatsSpellLikeAbility.getCPtr(list)), true) {
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
  }

  public CExoArrayListCNWSStatsSpellLikeAbility _OpAssign(CExoArrayListCNWSStatsSpellLikeAbility list) {
    CExoArrayListCNWSStatsSpellLikeAbility ret = new CExoArrayListCNWSStatsSpellLikeAbility(NWNXLibPINVOKE.CExoArrayListCNWSStatsSpellLikeAbility__OpAssign(swigCPtr, CExoArrayListCNWSStatsSpellLikeAbility.getCPtr(list)), false);
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public CNWSStats_SpellLikeAbility _OpIndex(int i) {
    CNWSStats_SpellLikeAbility ret = new CNWSStats_SpellLikeAbility(NWNXLibPINVOKE.CExoArrayListCNWSStatsSpellLikeAbility__OpIndex(swigCPtr, i), false);
    return ret;
  }

  public void Allocate(int s) {
    NWNXLibPINVOKE.CExoArrayListCNWSStatsSpellLikeAbility_Allocate(swigCPtr, s);
  }

  public void SetSize(int s) {
    NWNXLibPINVOKE.CExoArrayListCNWSStatsSpellLikeAbility_SetSize(swigCPtr, s);
  }

  public void Pack() {
    NWNXLibPINVOKE.CExoArrayListCNWSStatsSpellLikeAbility_Pack(swigCPtr);
  }

  public void Add(CNWSStats_SpellLikeAbility t) {
    NWNXLibPINVOKE.CExoArrayListCNWSStatsSpellLikeAbility_Add(swigCPtr, CNWSStats_SpellLikeAbility.getCPtr(t));
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
  }

  public void Insert(CNWSStats_SpellLikeAbility t, int k) {
    NWNXLibPINVOKE.CExoArrayListCNWSStatsSpellLikeAbility_Insert(swigCPtr, CNWSStats_SpellLikeAbility.getCPtr(t), k);
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
  }

  public void DelIndex(int i) {
    NWNXLibPINVOKE.CExoArrayListCNWSStatsSpellLikeAbility_DelIndex(swigCPtr, i);
  }

  public CNWSStats_SpellLikeAbility begin() {
    global::System.IntPtr cPtr = NWNXLibPINVOKE.CExoArrayListCNWSStatsSpellLikeAbility_begin(swigCPtr);
    CNWSStats_SpellLikeAbility ret = (cPtr == global::System.IntPtr.Zero) ? null : new CNWSStats_SpellLikeAbility(cPtr, false);
    return ret;
  }

  public CNWSStats_SpellLikeAbility end() {
    global::System.IntPtr cPtr = NWNXLibPINVOKE.CExoArrayListCNWSStatsSpellLikeAbility_end(swigCPtr);
    CNWSStats_SpellLikeAbility ret = (cPtr == global::System.IntPtr.Zero) ? null : new CNWSStats_SpellLikeAbility(cPtr, false);
    return ret;
  }

}

}

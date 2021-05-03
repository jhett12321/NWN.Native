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

public unsafe class CExoArrayListCSpellDeletePtr : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  public CExoArrayListCSpellDeletePtr(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  public CExoArrayListCSpellDeletePtr(void* cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, (global::System.IntPtr)cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(CExoArrayListCSpellDeletePtr obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~CExoArrayListCSpellDeletePtr() {
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
          NWNXLibPINVOKE.delete_CExoArrayListCSpellDeletePtr(swigCPtr);
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

  public static unsafe implicit operator void*(CExoArrayListCSpellDeletePtr self) {
    return (void*)self.swigCPtr.Handle;
  }

  public static implicit operator global::System.IntPtr(CExoArrayListCSpellDeletePtr self) {
    return self.swigCPtr.Handle;
  }

  public bool Equals(CExoArrayListCSpellDeletePtr other) {
    if (ReferenceEquals(null, other)) {
      return false;
    }

    if (ReferenceEquals(this, other)) {
      return true;
    }

    return Pointer.Equals(other.Pointer);
  }

  public override bool Equals(object obj) {
    return ReferenceEquals(this, obj) || obj is CExoArrayListCSpellDeletePtr other && Equals(other);
  }

  public override int GetHashCode() {
    return swigCPtr.Handle.GetHashCode();
  }

  public static bool operator ==(CExoArrayListCSpellDeletePtr left, CExoArrayListCSpellDeletePtr right) {
    return Equals(left, right);
  }

  public static bool operator !=(CExoArrayListCSpellDeletePtr left, CExoArrayListCSpellDeletePtr right) {
    return !Equals(left, right);
  }

  public void** element {
    set {
      NWNXLibPINVOKE.CExoArrayListCSpellDeletePtr_element_set(swigCPtr, (global::System.IntPtr)value);
    } 
    get {
        global::System.IntPtr retVal = NWNXLibPINVOKE.CExoArrayListCSpellDeletePtr_element_get(swigCPtr);
        return (void**)retVal;
    }

  }

  public int num {
    set {
      NWNXLibPINVOKE.CExoArrayListCSpellDeletePtr_num_set(swigCPtr, value);
    } 
    get {
      int ret = NWNXLibPINVOKE.CExoArrayListCSpellDeletePtr_num_get(swigCPtr);
      return ret;
    } 
  }

  public int array_size {
    set {
      NWNXLibPINVOKE.CExoArrayListCSpellDeletePtr_array_size_set(swigCPtr, value);
    } 
    get {
      int ret = NWNXLibPINVOKE.CExoArrayListCSpellDeletePtr_array_size_get(swigCPtr);
      return ret;
    } 
  }

  public CExoArrayListCSpellDeletePtr(int s) : this(NWNXLibPINVOKE.new_CExoArrayListCSpellDeletePtr__SWIG_0(s), true) {
  }

  public CExoArrayListCSpellDeletePtr() : this(NWNXLibPINVOKE.new_CExoArrayListCSpellDeletePtr__SWIG_1(), true) {
  }

  public CExoArrayListCSpellDeletePtr(CExoArrayListCSpellDeletePtr list) : this(NWNXLibPINVOKE.new_CExoArrayListCSpellDeletePtr__SWIG_2(CExoArrayListCSpellDeletePtr.getCPtr(list)), true) {
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
  }

  public CExoArrayListCSpellDeletePtr _OpAssign(CExoArrayListCSpellDeletePtr list) {
    CExoArrayListCSpellDeletePtr ret = new CExoArrayListCSpellDeletePtr(NWNXLibPINVOKE.CExoArrayListCSpellDeletePtr__OpAssign(swigCPtr, CExoArrayListCSpellDeletePtr.getCPtr(list)), false);
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void** _OpIndex(int i) {
    global::System.IntPtr retVal = NWNXLibPINVOKE.CExoArrayListCSpellDeletePtr__OpIndex(swigCPtr, i);
    return (void**)retVal;
  }

  public void Allocate(int s) {
    NWNXLibPINVOKE.CExoArrayListCSpellDeletePtr_Allocate(swigCPtr, s);
  }

  public void SetSize(int s) {
    NWNXLibPINVOKE.CExoArrayListCSpellDeletePtr_SetSize(swigCPtr, s);
  }

  public void Pack() {
    NWNXLibPINVOKE.CExoArrayListCSpellDeletePtr_Pack(swigCPtr);
  }

  public void Add(CSpell_Delete t) {
    NWNXLibPINVOKE.CExoArrayListCSpellDeletePtr_Add(swigCPtr, CSpell_Delete.getCPtr(t));
  }

  public void Insert(CSpell_Delete t, int k) {
    NWNXLibPINVOKE.CExoArrayListCSpellDeletePtr_Insert(swigCPtr, CSpell_Delete.getCPtr(t), k);
  }

  public void DelIndex(int i) {
    NWNXLibPINVOKE.CExoArrayListCSpellDeletePtr_DelIndex(swigCPtr, i);
  }

  public void** begin() {
    global::System.IntPtr retVal = NWNXLibPINVOKE.CExoArrayListCSpellDeletePtr_begin(swigCPtr);
    return (void**)retVal;
  }

  public void** end() {
    global::System.IntPtr retVal = NWNXLibPINVOKE.CExoArrayListCSpellDeletePtr_end(swigCPtr);
    return (void**)retVal;
  }

}

}

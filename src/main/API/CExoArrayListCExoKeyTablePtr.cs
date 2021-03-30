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

public unsafe class CExoArrayListCExoKeyTablePtr : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  public CExoArrayListCExoKeyTablePtr(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  public CExoArrayListCExoKeyTablePtr(void* cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, (global::System.IntPtr)cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(CExoArrayListCExoKeyTablePtr obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~CExoArrayListCExoKeyTablePtr() {
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
          NWNXLibPINVOKE.delete_CExoArrayListCExoKeyTablePtr(swigCPtr);
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

  public static unsafe implicit operator void*(CExoArrayListCExoKeyTablePtr self) {
    return (void*)self.swigCPtr.Handle;
  }

  public static implicit operator global::System.IntPtr(CExoArrayListCExoKeyTablePtr self) {
    return self.swigCPtr.Handle;
  }

  public bool Equals(CExoArrayListCExoKeyTablePtr other) {
    if (ReferenceEquals(null, other)) {
      return false;
    }

    if (ReferenceEquals(this, other)) {
      return true;
    }

    return Pointer.Equals(other.Pointer);
  }

  public override bool Equals(object obj) {
    return ReferenceEquals(this, obj) || obj is CExoArrayListCExoKeyTablePtr other && Equals(other);
  }

  public override int GetHashCode() {
    return swigCPtr.Handle.GetHashCode();
  }

  public static bool operator ==(CExoArrayListCExoKeyTablePtr left, CExoArrayListCExoKeyTablePtr right) {
    return Equals(left, right);
  }

  public static bool operator !=(CExoArrayListCExoKeyTablePtr left, CExoArrayListCExoKeyTablePtr right) {
    return !Equals(left, right);
  }

  public void** element {
    set {
      NWNXLibPINVOKE.CExoArrayListCExoKeyTablePtr_element_set(swigCPtr, (global::System.IntPtr)value);
    }  
    get {
        global::System.IntPtr retVal = NWNXLibPINVOKE.CExoArrayListCExoKeyTablePtr_element_get(swigCPtr); 
        return (void**)retVal; 
    }

  }

  public int num {
    set {
      NWNXLibPINVOKE.CExoArrayListCExoKeyTablePtr_num_set(swigCPtr, value);
    } 
    get {
      int ret = NWNXLibPINVOKE.CExoArrayListCExoKeyTablePtr_num_get(swigCPtr);
      return ret;
    } 
  }

  public int array_size {
    set {
      NWNXLibPINVOKE.CExoArrayListCExoKeyTablePtr_array_size_set(swigCPtr, value);
    } 
    get {
      int ret = NWNXLibPINVOKE.CExoArrayListCExoKeyTablePtr_array_size_get(swigCPtr);
      return ret;
    } 
  }

  public CExoArrayListCExoKeyTablePtr(int s) : this(NWNXLibPINVOKE.new_CExoArrayListCExoKeyTablePtr__SWIG_0(s), true) {
  }

  public CExoArrayListCExoKeyTablePtr() : this(NWNXLibPINVOKE.new_CExoArrayListCExoKeyTablePtr__SWIG_1(), true) {
  }

  public CExoArrayListCExoKeyTablePtr(CExoArrayListCExoKeyTablePtr list) : this(NWNXLibPINVOKE.new_CExoArrayListCExoKeyTablePtr__SWIG_2(CExoArrayListCExoKeyTablePtr.getCPtr(list)), true) {
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
  }

  public CExoArrayListCExoKeyTablePtr _OpAssign(CExoArrayListCExoKeyTablePtr list) {
    CExoArrayListCExoKeyTablePtr ret = new CExoArrayListCExoKeyTablePtr(NWNXLibPINVOKE.CExoArrayListCExoKeyTablePtr__OpAssign(swigCPtr, CExoArrayListCExoKeyTablePtr.getCPtr(list)), false);
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void** _OpIndex(int i) { 
    global::System.IntPtr retVal = NWNXLibPINVOKE.CExoArrayListCExoKeyTablePtr__OpIndex(swigCPtr, i);
    return (void**)retVal;
  }

  public void Allocate(int s) {
    NWNXLibPINVOKE.CExoArrayListCExoKeyTablePtr_Allocate(swigCPtr, s);
  }

  public void SetSize(int s) {
    NWNXLibPINVOKE.CExoArrayListCExoKeyTablePtr_SetSize(swigCPtr, s);
  }

  public void Pack() {
    NWNXLibPINVOKE.CExoArrayListCExoKeyTablePtr_Pack(swigCPtr);
  }

  public void Add(CExoKeyTable t) {
    NWNXLibPINVOKE.CExoArrayListCExoKeyTablePtr_Add(swigCPtr, CExoKeyTable.getCPtr(t));
  }

  public void Insert(CExoKeyTable t, int k) {
    NWNXLibPINVOKE.CExoArrayListCExoKeyTablePtr_Insert(swigCPtr, CExoKeyTable.getCPtr(t), k);
  }

  public void DelIndex(int i) {
    NWNXLibPINVOKE.CExoArrayListCExoKeyTablePtr_DelIndex(swigCPtr, i);
  }

  public void** begin() { 
    global::System.IntPtr retVal = NWNXLibPINVOKE.CExoArrayListCExoKeyTablePtr_begin(swigCPtr);
    return (void**)retVal;
  }

  public void** end() { 
    global::System.IntPtr retVal = NWNXLibPINVOKE.CExoArrayListCExoKeyTablePtr_end(swigCPtr);
    return (void**)retVal;
  }

}

}

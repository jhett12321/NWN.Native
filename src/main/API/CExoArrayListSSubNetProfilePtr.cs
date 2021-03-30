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

public unsafe class CExoArrayListSSubNetProfilePtr : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  public CExoArrayListSSubNetProfilePtr(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  public CExoArrayListSSubNetProfilePtr(void* cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, (global::System.IntPtr)cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(CExoArrayListSSubNetProfilePtr obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~CExoArrayListSSubNetProfilePtr() {
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
          NWNXLibPINVOKE.delete_CExoArrayListSSubNetProfilePtr(swigCPtr);
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

  public static unsafe implicit operator void*(CExoArrayListSSubNetProfilePtr self) {
    return (void*)self.swigCPtr.Handle;
  }

  public static implicit operator global::System.IntPtr(CExoArrayListSSubNetProfilePtr self) {
    return self.swigCPtr.Handle;
  }

  public bool Equals(CExoArrayListSSubNetProfilePtr other) {
    if (ReferenceEquals(null, other)) {
      return false;
    }

    if (ReferenceEquals(this, other)) {
      return true;
    }

    return Pointer.Equals(other.Pointer);
  }

  public override bool Equals(object obj) {
    return ReferenceEquals(this, obj) || obj is CExoArrayListSSubNetProfilePtr other && Equals(other);
  }

  public override int GetHashCode() {
    return swigCPtr.Handle.GetHashCode();
  }

  public static bool operator ==(CExoArrayListSSubNetProfilePtr left, CExoArrayListSSubNetProfilePtr right) {
    return Equals(left, right);
  }

  public static bool operator !=(CExoArrayListSSubNetProfilePtr left, CExoArrayListSSubNetProfilePtr right) {
    return !Equals(left, right);
  }

  public void** element {
    set {
      NWNXLibPINVOKE.CExoArrayListSSubNetProfilePtr_element_set(swigCPtr, (global::System.IntPtr)value);
    }  
    get {
        global::System.IntPtr retVal = NWNXLibPINVOKE.CExoArrayListSSubNetProfilePtr_element_get(swigCPtr); 
        return (void**)retVal; 
    }

  }

  public int num {
    set {
      NWNXLibPINVOKE.CExoArrayListSSubNetProfilePtr_num_set(swigCPtr, value);
    } 
    get {
      int ret = NWNXLibPINVOKE.CExoArrayListSSubNetProfilePtr_num_get(swigCPtr);
      return ret;
    } 
  }

  public int array_size {
    set {
      NWNXLibPINVOKE.CExoArrayListSSubNetProfilePtr_array_size_set(swigCPtr, value);
    } 
    get {
      int ret = NWNXLibPINVOKE.CExoArrayListSSubNetProfilePtr_array_size_get(swigCPtr);
      return ret;
    } 
  }

  public CExoArrayListSSubNetProfilePtr(int s) : this(NWNXLibPINVOKE.new_CExoArrayListSSubNetProfilePtr__SWIG_0(s), true) {
  }

  public CExoArrayListSSubNetProfilePtr() : this(NWNXLibPINVOKE.new_CExoArrayListSSubNetProfilePtr__SWIG_1(), true) {
  }

  public CExoArrayListSSubNetProfilePtr(CExoArrayListSSubNetProfilePtr list) : this(NWNXLibPINVOKE.new_CExoArrayListSSubNetProfilePtr__SWIG_2(CExoArrayListSSubNetProfilePtr.getCPtr(list)), true) {
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
  }

  public CExoArrayListSSubNetProfilePtr _OpAssign(CExoArrayListSSubNetProfilePtr list) {
    CExoArrayListSSubNetProfilePtr ret = new CExoArrayListSSubNetProfilePtr(NWNXLibPINVOKE.CExoArrayListSSubNetProfilePtr__OpAssign(swigCPtr, CExoArrayListSSubNetProfilePtr.getCPtr(list)), false);
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void** _OpIndex(int i) { 
    global::System.IntPtr retVal = NWNXLibPINVOKE.CExoArrayListSSubNetProfilePtr__OpIndex(swigCPtr, i);
    return (void**)retVal;
  }

  public void Allocate(int s) {
    NWNXLibPINVOKE.CExoArrayListSSubNetProfilePtr_Allocate(swigCPtr, s);
  }

  public void SetSize(int s) {
    NWNXLibPINVOKE.CExoArrayListSSubNetProfilePtr_SetSize(swigCPtr, s);
  }

  public void Pack() {
    NWNXLibPINVOKE.CExoArrayListSSubNetProfilePtr_Pack(swigCPtr);
  }

  public void Add(SSubNetProfile t) {
    NWNXLibPINVOKE.CExoArrayListSSubNetProfilePtr_Add(swigCPtr, SSubNetProfile.getCPtr(t));
  }

  public void Insert(SSubNetProfile t, int k) {
    NWNXLibPINVOKE.CExoArrayListSSubNetProfilePtr_Insert(swigCPtr, SSubNetProfile.getCPtr(t), k);
  }

  public void DelIndex(int i) {
    NWNXLibPINVOKE.CExoArrayListSSubNetProfilePtr_DelIndex(swigCPtr, i);
  }

  public void** begin() { 
    global::System.IntPtr retVal = NWNXLibPINVOKE.CExoArrayListSSubNetProfilePtr_begin(swigCPtr);
    return (void**)retVal;
  }

  public void** end() { 
    global::System.IntPtr retVal = NWNXLibPINVOKE.CExoArrayListSSubNetProfilePtr_end(swigCPtr);
    return (void**)retVal;
  }

}

}

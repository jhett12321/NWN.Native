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

public unsafe class CExoArrayListCNWSPersonalReputation : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal CExoArrayListCNWSPersonalReputation(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(CExoArrayListCNWSPersonalReputation obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~CExoArrayListCNWSPersonalReputation() {
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
          NWNXLibPINVOKE.delete_CExoArrayListCNWSPersonalReputation(swigCPtr);
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

  public static unsafe implicit operator void*(CExoArrayListCNWSPersonalReputation self) {
    return (void*)self.swigCPtr.Handle;
  }

  public static unsafe CExoArrayListCNWSPersonalReputation FromPointer(void* pointer, bool memoryOwn = false) {
    return pointer != null ? new CExoArrayListCNWSPersonalReputation((global::System.IntPtr)pointer, memoryOwn) : null;
  }

  public static CExoArrayListCNWSPersonalReputation FromPointer(global::System.IntPtr pointer, bool memoryOwn = false) {
    return pointer != global::System.IntPtr.Zero ? new CExoArrayListCNWSPersonalReputation(pointer, memoryOwn) : null;
  }

  public bool Equals(CExoArrayListCNWSPersonalReputation other) {
    if (ReferenceEquals(null, other)) {
      return false;
    }

    if (ReferenceEquals(this, other)) {
      return true;
    }

    return Pointer.Equals(other.Pointer);
  }

  public override bool Equals(object obj) {
    return ReferenceEquals(this, obj) || obj is CExoArrayListCNWSPersonalReputation other && Equals(other);
  }

  public override int GetHashCode() {
    return swigCPtr.Handle.GetHashCode();
  }

  public static bool operator ==(CExoArrayListCNWSPersonalReputation left, CExoArrayListCNWSPersonalReputation right) {
    return Equals(left, right);
  }

  public static bool operator !=(CExoArrayListCNWSPersonalReputation left, CExoArrayListCNWSPersonalReputation right) {
    return !Equals(left, right);
  }
/*@SWIG@*/
  public CNWSPersonalReputation element {
    set {
      NWNXLibPINVOKE.CExoArrayListCNWSPersonalReputation_element_set(swigCPtr, CNWSPersonalReputation.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = NWNXLibPINVOKE.CExoArrayListCNWSPersonalReputation_element_get(swigCPtr);
      CNWSPersonalReputation ret = (cPtr == global::System.IntPtr.Zero) ? null : new CNWSPersonalReputation(cPtr, false);
      return ret;
    } 
  }

  public int num {
    set {
      NWNXLibPINVOKE.CExoArrayListCNWSPersonalReputation_num_set(swigCPtr, value);
    } 
    get {
      int ret = NWNXLibPINVOKE.CExoArrayListCNWSPersonalReputation_num_get(swigCPtr);
      return ret;
    } 
  }

  public int array_size {
    set {
      NWNXLibPINVOKE.CExoArrayListCNWSPersonalReputation_array_size_set(swigCPtr, value);
    } 
    get {
      int ret = NWNXLibPINVOKE.CExoArrayListCNWSPersonalReputation_array_size_get(swigCPtr);
      return ret;
    } 
  }

  public CExoArrayListCNWSPersonalReputation(int s) : this(NWNXLibPINVOKE.new_CExoArrayListCNWSPersonalReputation__SWIG_0(s), true) {
  }

  public CExoArrayListCNWSPersonalReputation() : this(NWNXLibPINVOKE.new_CExoArrayListCNWSPersonalReputation__SWIG_1(), true) {
  }

  public CExoArrayListCNWSPersonalReputation(CExoArrayListCNWSPersonalReputation list) : this(NWNXLibPINVOKE.new_CExoArrayListCNWSPersonalReputation__SWIG_2(CExoArrayListCNWSPersonalReputation.getCPtr(list)), true) {
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
  }

  public CExoArrayListCNWSPersonalReputation _OpAssign(CExoArrayListCNWSPersonalReputation list) {
    CExoArrayListCNWSPersonalReputation ret = new CExoArrayListCNWSPersonalReputation(NWNXLibPINVOKE.CExoArrayListCNWSPersonalReputation__OpAssign(swigCPtr, CExoArrayListCNWSPersonalReputation.getCPtr(list)), false);
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public CNWSPersonalReputation _OpIndex(int i) {
    CNWSPersonalReputation ret = new CNWSPersonalReputation(NWNXLibPINVOKE.CExoArrayListCNWSPersonalReputation__OpIndex(swigCPtr, i), false);
    return ret;
  }

  public void Allocate(int s) {
    NWNXLibPINVOKE.CExoArrayListCNWSPersonalReputation_Allocate(swigCPtr, s);
  }

  public void SetSize(int s) {
    NWNXLibPINVOKE.CExoArrayListCNWSPersonalReputation_SetSize(swigCPtr, s);
  }

  public void Pack() {
    NWNXLibPINVOKE.CExoArrayListCNWSPersonalReputation_Pack(swigCPtr);
  }

  public void Add(CNWSPersonalReputation t) {
    NWNXLibPINVOKE.CExoArrayListCNWSPersonalReputation_Add(swigCPtr, CNWSPersonalReputation.getCPtr(t));
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
  }

  public void Insert(CNWSPersonalReputation t, int k) {
    NWNXLibPINVOKE.CExoArrayListCNWSPersonalReputation_Insert(swigCPtr, CNWSPersonalReputation.getCPtr(t), k);
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
  }

  public void DelIndex(int i) {
    NWNXLibPINVOKE.CExoArrayListCNWSPersonalReputation_DelIndex(swigCPtr, i);
  }

  public CNWSPersonalReputation begin() {
    global::System.IntPtr cPtr = NWNXLibPINVOKE.CExoArrayListCNWSPersonalReputation_begin(swigCPtr);
    CNWSPersonalReputation ret = (cPtr == global::System.IntPtr.Zero) ? null : new CNWSPersonalReputation(cPtr, false);
    return ret;
  }

  public CNWSPersonalReputation end() {
    global::System.IntPtr cPtr = NWNXLibPINVOKE.CExoArrayListCNWSPersonalReputation_end(swigCPtr);
    CNWSPersonalReputation ret = (cPtr == global::System.IntPtr.Zero) ? null : new CNWSPersonalReputation(cPtr, false);
    return ret;
  }

}

}

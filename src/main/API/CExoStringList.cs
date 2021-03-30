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

public unsafe class CExoStringList : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  public CExoStringList(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  public CExoStringList(void* cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, (global::System.IntPtr)cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(CExoStringList obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~CExoStringList() {
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
          NWNXLibPINVOKE.delete_CExoStringList(swigCPtr);
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

  public static unsafe implicit operator void*(CExoStringList self) {
    return (void*)self.swigCPtr.Handle;
  }

  public static implicit operator global::System.IntPtr(CExoStringList self) {
    return self.swigCPtr.Handle;
  }

  public bool Equals(CExoStringList other) {
    if (ReferenceEquals(null, other)) {
      return false;
    }

    if (ReferenceEquals(this, other)) {
      return true;
    }

    return Pointer.Equals(other.Pointer);
  }

  public override bool Equals(object obj) {
    return ReferenceEquals(this, obj) || obj is CExoStringList other && Equals(other);
  }

  public override int GetHashCode() {
    return swigCPtr.Handle.GetHashCode();
  }

  public static bool operator ==(CExoStringList left, CExoStringList right) {
    return Equals(left, right);
  }

  public static bool operator !=(CExoStringList left, CExoStringList right) {
    return !Equals(left, right);
  }

  public void** m_pStrings {
    set {
      NWNXLibPINVOKE.CExoStringList_m_pStrings_set(swigCPtr, (global::System.IntPtr)value);
    }  
    get {
        global::System.IntPtr retVal = NWNXLibPINVOKE.CExoStringList_m_pStrings_get(swigCPtr); 
        return (void**)retVal; 
    }

  }

  public int m_nCount {
    set {
      NWNXLibPINVOKE.CExoStringList_m_nCount_set(swigCPtr, value);
    } 
    get {
      int ret = NWNXLibPINVOKE.CExoStringList_m_nCount_get(swigCPtr);
      return ret;
    } 
  }

  public int m_nDuplicates {
    set {
      NWNXLibPINVOKE.CExoStringList_m_nDuplicates_set(swigCPtr, value);
    } 
    get {
      int ret = NWNXLibPINVOKE.CExoStringList_m_nDuplicates_get(swigCPtr);
      return ret;
    } 
  }

  public int m_nSorted {
    set {
      NWNXLibPINVOKE.CExoStringList_m_nSorted_set(swigCPtr, value);
    } 
    get {
      int ret = NWNXLibPINVOKE.CExoStringList_m_nSorted_get(swigCPtr);
      return ret;
    } 
  }

  public int m_nSize {
    set {
      NWNXLibPINVOKE.CExoStringList_m_nSize_set(swigCPtr, value);
    } 
    get {
      int ret = NWNXLibPINVOKE.CExoStringList_m_nSize_get(swigCPtr);
      return ret;
    } 
  }

  public CExoStringList() : this(NWNXLibPINVOKE.new_CExoStringList__SWIG_0(), true) {
  }

  public CExoStringList(int a_nSorted, int a_nDuplicates, int a_nSize) : this(NWNXLibPINVOKE.new_CExoStringList__SWIG_1(a_nSorted, a_nDuplicates, a_nSize), true) {
  }

  public CExoStringList(CExoStringList a_nList) : this(NWNXLibPINVOKE.new_CExoStringList__SWIG_2(CExoStringList.getCPtr(a_nList)), true) {
  }

  public void Add(CExoString a_nString) {
    NWNXLibPINVOKE.CExoStringList_Add(swigCPtr, CExoString.getCPtr(a_nString));
  }

  public void Clear() {
    NWNXLibPINVOKE.CExoStringList_Clear(swigCPtr);
  }

  public void Delete(CExoString a_nString) {
    NWNXLibPINVOKE.CExoStringList_Delete(swigCPtr, CExoString.getCPtr(a_nString));
  }

  public int GetCount() {
    int ret = NWNXLibPINVOKE.CExoStringList_GetCount(swigCPtr);
    return ret;
  }

  public int GetDuplicate() {
    int ret = NWNXLibPINVOKE.CExoStringList_GetDuplicate(swigCPtr);
    return ret;
  }

  public int GetSize() {
    int ret = NWNXLibPINVOKE.CExoStringList_GetSize(swigCPtr);
    return ret;
  }

  public int GetSorted() {
    int ret = NWNXLibPINVOKE.CExoStringList_GetSorted(swigCPtr);
    return ret;
  }

  public CExoString GetString(int a_nPosition) {
    global::System.IntPtr cPtr = NWNXLibPINVOKE.CExoStringList_GetString(swigCPtr, a_nPosition);
    CExoString ret = (cPtr == global::System.IntPtr.Zero) ? null : new CExoString(cPtr, false);
    return ret;
  }

  public void Insert(CExoString a_nString, int a_nPosition) {
    NWNXLibPINVOKE.CExoStringList_Insert(swigCPtr, CExoString.getCPtr(a_nString), a_nPosition);
  }

  public CExoStringList Merge(CExoStringList a_nSecond, int a_nSorted, int a_nDuplicates) {
    global::System.IntPtr cPtr = NWNXLibPINVOKE.CExoStringList_Merge(swigCPtr, CExoStringList.getCPtr(a_nSecond), a_nSorted, a_nDuplicates);
    CExoStringList ret = (cPtr == global::System.IntPtr.Zero) ? null : new CExoStringList(cPtr, false);
    return ret;
  }

  public void Remove(int a_nPosition) {
    NWNXLibPINVOKE.CExoStringList_Remove(swigCPtr, a_nPosition);
  }

  public CExoString _OpIndex(int a_nPosition) {
    global::System.IntPtr cPtr = NWNXLibPINVOKE.CExoStringList__OpIndex(swigCPtr, a_nPosition);
    CExoString ret = (cPtr == global::System.IntPtr.Zero) ? null : new CExoString(cPtr, false);
    return ret;
  }

  public CExoStringList _OpAssign(CExoStringList a_slList) {
    CExoStringList ret = new CExoStringList(NWNXLibPINVOKE.CExoStringList__OpAssign(swigCPtr, CExoStringList.getCPtr(a_slList)), false);
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void AddSorted(CExoString a_nString) {
    NWNXLibPINVOKE.CExoStringList_AddSorted(swigCPtr, CExoString.getCPtr(a_nString));
  }

  public void Introduce(CExoString a_nString, int a_nPosition) {
    NWNXLibPINVOKE.CExoStringList_Introduce(swigCPtr, CExoString.getCPtr(a_nString), a_nPosition);
  }

}

}

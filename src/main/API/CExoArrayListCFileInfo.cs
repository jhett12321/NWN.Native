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

public unsafe class CExoArrayListCFileInfo : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal CExoArrayListCFileInfo(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(CExoArrayListCFileInfo obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~CExoArrayListCFileInfo() {
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
          NWNXLibPINVOKE.delete_CExoArrayListCFileInfo(swigCPtr);
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

  public static unsafe implicit operator void*(CExoArrayListCFileInfo self) {
    return (void*)self.swigCPtr.Handle;
  }

  public static unsafe CExoArrayListCFileInfo FromPointer(void* pointer, bool memoryOwn = false) {
    return pointer != null ? new CExoArrayListCFileInfo((global::System.IntPtr)pointer, memoryOwn) : null;
  }

  public static CExoArrayListCFileInfo FromPointer(global::System.IntPtr pointer, bool memoryOwn = false) {
    return pointer != global::System.IntPtr.Zero ? new CExoArrayListCFileInfo(pointer, memoryOwn) : null;
  }

  public bool Equals(CExoArrayListCFileInfo other) {
    if (ReferenceEquals(null, other)) {
      return false;
    }

    if (ReferenceEquals(this, other)) {
      return true;
    }

    return Pointer.Equals(other.Pointer);
  }

  public override bool Equals(object obj) {
    return ReferenceEquals(this, obj) || obj is CExoArrayListCFileInfo other && Equals(other);
  }

  public override int GetHashCode() {
    return swigCPtr.Handle.GetHashCode();
  }

  public static bool operator ==(CExoArrayListCFileInfo left, CExoArrayListCFileInfo right) {
    return Equals(left, right);
  }

  public static bool operator !=(CExoArrayListCFileInfo left, CExoArrayListCFileInfo right) {
    return !Equals(left, right);
  }
/*@SWIG@*/
  public CFileInfo element {
    set {
      NWNXLibPINVOKE.CExoArrayListCFileInfo_element_set(swigCPtr, CFileInfo.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = NWNXLibPINVOKE.CExoArrayListCFileInfo_element_get(swigCPtr);
      CFileInfo ret = (cPtr == global::System.IntPtr.Zero) ? null : new CFileInfo(cPtr, false);
      return ret;
    } 
  }

  public int num {
    set {
      NWNXLibPINVOKE.CExoArrayListCFileInfo_num_set(swigCPtr, value);
    } 
    get {
      int ret = NWNXLibPINVOKE.CExoArrayListCFileInfo_num_get(swigCPtr);
      return ret;
    } 
  }

  public int array_size {
    set {
      NWNXLibPINVOKE.CExoArrayListCFileInfo_array_size_set(swigCPtr, value);
    } 
    get {
      int ret = NWNXLibPINVOKE.CExoArrayListCFileInfo_array_size_get(swigCPtr);
      return ret;
    } 
  }

  public CExoArrayListCFileInfo(int s) : this(NWNXLibPINVOKE.new_CExoArrayListCFileInfo__SWIG_0(s), true) {
  }

  public CExoArrayListCFileInfo() : this(NWNXLibPINVOKE.new_CExoArrayListCFileInfo__SWIG_1(), true) {
  }

  public CExoArrayListCFileInfo(CExoArrayListCFileInfo list) : this(NWNXLibPINVOKE.new_CExoArrayListCFileInfo__SWIG_2(CExoArrayListCFileInfo.getCPtr(list)), true) {
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
  }

  public CExoArrayListCFileInfo _OpAssign(CExoArrayListCFileInfo list) {
    CExoArrayListCFileInfo ret = new CExoArrayListCFileInfo(NWNXLibPINVOKE.CExoArrayListCFileInfo__OpAssign(swigCPtr, CExoArrayListCFileInfo.getCPtr(list)), false);
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public CFileInfo _OpIndex(int i) {
    CFileInfo ret = new CFileInfo(NWNXLibPINVOKE.CExoArrayListCFileInfo__OpIndex(swigCPtr, i), false);
    return ret;
  }

  public void Allocate(int s) {
    NWNXLibPINVOKE.CExoArrayListCFileInfo_Allocate(swigCPtr, s);
  }

  public void SetSize(int s) {
    NWNXLibPINVOKE.CExoArrayListCFileInfo_SetSize(swigCPtr, s);
  }

  public void Pack() {
    NWNXLibPINVOKE.CExoArrayListCFileInfo_Pack(swigCPtr);
  }

  public void Add(CFileInfo t) {
    NWNXLibPINVOKE.CExoArrayListCFileInfo_Add(swigCPtr, CFileInfo.getCPtr(t));
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
  }

  public void Insert(CFileInfo t, int k) {
    NWNXLibPINVOKE.CExoArrayListCFileInfo_Insert(swigCPtr, CFileInfo.getCPtr(t), k);
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
  }

  public void DelIndex(int i) {
    NWNXLibPINVOKE.CExoArrayListCFileInfo_DelIndex(swigCPtr, i);
  }

  public CFileInfo begin() {
    global::System.IntPtr cPtr = NWNXLibPINVOKE.CExoArrayListCFileInfo_begin(swigCPtr);
    CFileInfo ret = (cPtr == global::System.IntPtr.Zero) ? null : new CFileInfo(cPtr, false);
    return ret;
  }

  public CFileInfo end() {
    global::System.IntPtr cPtr = NWNXLibPINVOKE.CExoArrayListCFileInfo_end(swigCPtr);
    CFileInfo ret = (cPtr == global::System.IntPtr.Zero) ? null : new CFileInfo(cPtr, false);
    return ret;
  }

}

}

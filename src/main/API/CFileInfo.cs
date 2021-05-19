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

public unsafe class CFileInfo : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal CFileInfo(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(CFileInfo obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~CFileInfo() {
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
          NWNXLibPINVOKE.delete_CFileInfo(swigCPtr);
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

  public static unsafe implicit operator void*(CFileInfo self) {
    return (void*)self.swigCPtr.Handle;
  }

  public static unsafe CFileInfo FromPointer(void* pointer, bool memoryOwn = false) {
    return pointer != null ? new CFileInfo((global::System.IntPtr)pointer, memoryOwn) : null;
  }

  public static CFileInfo FromPointer(global::System.IntPtr pointer, bool memoryOwn = false) {
    return pointer != global::System.IntPtr.Zero ? new CFileInfo(pointer, memoryOwn) : null;
  }

  public bool Equals(CFileInfo other) {
    if (ReferenceEquals(null, other)) {
      return false;
    }

    if (ReferenceEquals(this, other)) {
      return true;
    }

    return Pointer.Equals(other.Pointer);
  }

  public override bool Equals(object obj) {
    return ReferenceEquals(this, obj) || obj is CFileInfo other && Equals(other);
  }

  public override int GetHashCode() {
    return swigCPtr.Handle.GetHashCode();
  }

  public static bool operator ==(CFileInfo left, CFileInfo right) {
    return Equals(left, right);
  }

  public static bool operator !=(CFileInfo left, CFileInfo right) {
    return !Equals(left, right);
  }
/*@SWIG@*/
  public CExoString sFileName {
    set {
      NWNXLibPINVOKE.CFileInfo_sFileName_set(swigCPtr, CExoString.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = NWNXLibPINVOKE.CFileInfo_sFileName_get(swigCPtr);
      CExoString ret = (cPtr == global::System.IntPtr.Zero) ? null : new CExoString(cPtr, false);
      return ret;
    } 
  }

  public ushort nYear {
    set {
      NWNXLibPINVOKE.CFileInfo_nYear_set(swigCPtr, value);
    } 
    get {
      ushort ret = NWNXLibPINVOKE.CFileInfo_nYear_get(swigCPtr);
      return ret;
    } 
  }

  public ushort nMonth {
    set {
      NWNXLibPINVOKE.CFileInfo_nMonth_set(swigCPtr, value);
    } 
    get {
      ushort ret = NWNXLibPINVOKE.CFileInfo_nMonth_get(swigCPtr);
      return ret;
    } 
  }

  public ushort nDay {
    set {
      NWNXLibPINVOKE.CFileInfo_nDay_set(swigCPtr, value);
    } 
    get {
      ushort ret = NWNXLibPINVOKE.CFileInfo_nDay_get(swigCPtr);
      return ret;
    } 
  }

  public ushort nHour {
    set {
      NWNXLibPINVOKE.CFileInfo_nHour_set(swigCPtr, value);
    } 
    get {
      ushort ret = NWNXLibPINVOKE.CFileInfo_nHour_get(swigCPtr);
      return ret;
    } 
  }

  public ushort nMinute {
    set {
      NWNXLibPINVOKE.CFileInfo_nMinute_set(swigCPtr, value);
    } 
    get {
      ushort ret = NWNXLibPINVOKE.CFileInfo_nMinute_get(swigCPtr);
      return ret;
    } 
  }

  public ushort nSecond {
    set {
      NWNXLibPINVOKE.CFileInfo_nSecond_set(swigCPtr, value);
    } 
    get {
      ushort ret = NWNXLibPINVOKE.CFileInfo_nSecond_get(swigCPtr);
      return ret;
    } 
  }

  public CFileInfo() : this(NWNXLibPINVOKE.new_CFileInfo(), true) {
  }

}

}

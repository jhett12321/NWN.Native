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

public unsafe class RES_FIXED_HEADER : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal RES_FIXED_HEADER(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(RES_FIXED_HEADER obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~RES_FIXED_HEADER() {
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
          NWNXLibPINVOKE.delete_RES_FIXED_HEADER(swigCPtr);
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

  public static unsafe implicit operator void*(RES_FIXED_HEADER self) {
    return (void*)self.swigCPtr.Handle;
  }

  public static unsafe RES_FIXED_HEADER FromPointer(void* pointer, bool memoryOwn = false) {
    return pointer != null ? new RES_FIXED_HEADER((global::System.IntPtr)pointer, memoryOwn) : null;
  }

  public static RES_FIXED_HEADER FromPointer(global::System.IntPtr pointer, bool memoryOwn = false) {
    return pointer != global::System.IntPtr.Zero ? new RES_FIXED_HEADER(pointer, memoryOwn) : null;
  }

  public bool Equals(RES_FIXED_HEADER other) {
    if (ReferenceEquals(null, other)) {
      return false;
    }

    if (ReferenceEquals(this, other)) {
      return true;
    }

    return Pointer.Equals(other.Pointer);
  }

  public override bool Equals(object obj) {
    return ReferenceEquals(this, obj) || obj is RES_FIXED_HEADER other && Equals(other);
  }

  public override int GetHashCode() {
    return swigCPtr.Handle.GetHashCode();
  }

  public static bool operator ==(RES_FIXED_HEADER left, RES_FIXED_HEADER right) {
    return Equals(left, right);
  }

  public static bool operator !=(RES_FIXED_HEADER left, RES_FIXED_HEADER right) {
    return !Equals(left, right);
  }
/*@SWIG@*/
  public uint nFileType {
    set {
      NWNXLibPINVOKE.RES_FIXED_HEADER_nFileType_set(swigCPtr, value);
    } 
    get {
      uint ret = NWNXLibPINVOKE.RES_FIXED_HEADER_nFileType_get(swigCPtr);
      return ret;
    } 
  }

  public uint nFileVersion {
    set {
      NWNXLibPINVOKE.RES_FIXED_HEADER_nFileVersion_set(swigCPtr, value);
    } 
    get {
      uint ret = NWNXLibPINVOKE.RES_FIXED_HEADER_nFileVersion_get(swigCPtr);
      return ret;
    } 
  }

  public uint nNumber {
    set {
      NWNXLibPINVOKE.RES_FIXED_HEADER_nNumber_set(swigCPtr, value);
    } 
    get {
      uint ret = NWNXLibPINVOKE.RES_FIXED_HEADER_nNumber_get(swigCPtr);
      return ret;
    } 
  }

  public uint nSize {
    set {
      NWNXLibPINVOKE.RES_FIXED_HEADER_nSize_set(swigCPtr, value);
    } 
    get {
      uint ret = NWNXLibPINVOKE.RES_FIXED_HEADER_nSize_get(swigCPtr);
      return ret;
    } 
  }

  public uint nTableOffset {
    set {
      NWNXLibPINVOKE.RES_FIXED_HEADER_nTableOffset_set(swigCPtr, value);
    } 
    get {
      uint ret = NWNXLibPINVOKE.RES_FIXED_HEADER_nTableOffset_get(swigCPtr);
      return ret;
    } 
  }

  public RES_FIXED_HEADER() : this(NWNXLibPINVOKE.new_RES_FIXED_HEADER(), true) {
  }

}

}

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

public unsafe class BIFFFILE_VARRESENTRY_V1 : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal BIFFFILE_VARRESENTRY_V1(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(BIFFFILE_VARRESENTRY_V1 obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~BIFFFILE_VARRESENTRY_V1() {
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
          NWNXLibPINVOKE.delete_BIFFFILE_VARRESENTRY_V1(swigCPtr);
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

  public static unsafe implicit operator void*(BIFFFILE_VARRESENTRY_V1 self) {
    return (void*)self.swigCPtr.Handle;
  }

  public static unsafe BIFFFILE_VARRESENTRY_V1 FromPointer(void* pointer, bool memoryOwn = false) {
    return pointer != null ? new BIFFFILE_VARRESENTRY_V1((global::System.IntPtr)pointer, memoryOwn) : null;
  }

  public static BIFFFILE_VARRESENTRY_V1 FromPointer(global::System.IntPtr pointer, bool memoryOwn = false) {
    return pointer != global::System.IntPtr.Zero ? new BIFFFILE_VARRESENTRY_V1(pointer, memoryOwn) : null;
  }

  public bool Equals(BIFFFILE_VARRESENTRY_V1 other) {
    if (ReferenceEquals(null, other)) {
      return false;
    }

    if (ReferenceEquals(this, other)) {
      return true;
    }

    return Pointer.Equals(other.Pointer);
  }

  public override bool Equals(object obj) {
    return ReferenceEquals(this, obj) || obj is BIFFFILE_VARRESENTRY_V1 other && Equals(other);
  }

  public override int GetHashCode() {
    return swigCPtr.Handle.GetHashCode();
  }

  public static bool operator ==(BIFFFILE_VARRESENTRY_V1 left, BIFFFILE_VARRESENTRY_V1 right) {
    return Equals(left, right);
  }

  public static bool operator !=(BIFFFILE_VARRESENTRY_V1 left, BIFFFILE_VARRESENTRY_V1 right) {
    return !Equals(left, right);
  }
/*@SWIG@*/
  public uint nID {
    set {
      NWNXLibPINVOKE.BIFFFILE_VARRESENTRY_V1_nID_set(swigCPtr, value);
    } 
    get {
      uint ret = NWNXLibPINVOKE.BIFFFILE_VARRESENTRY_V1_nID_get(swigCPtr);
      return ret;
    } 
  }

  public uint nOffset {
    set {
      NWNXLibPINVOKE.BIFFFILE_VARRESENTRY_V1_nOffset_set(swigCPtr, value);
    } 
    get {
      uint ret = NWNXLibPINVOKE.BIFFFILE_VARRESENTRY_V1_nOffset_get(swigCPtr);
      return ret;
    } 
  }

  public uint nSize {
    set {
      NWNXLibPINVOKE.BIFFFILE_VARRESENTRY_V1_nSize_set(swigCPtr, value);
    } 
    get {
      uint ret = NWNXLibPINVOKE.BIFFFILE_VARRESENTRY_V1_nSize_get(swigCPtr);
      return ret;
    } 
  }

  public uint nType {
    set {
      NWNXLibPINVOKE.BIFFFILE_VARRESENTRY_V1_nType_set(swigCPtr, value);
    } 
    get {
      uint ret = NWNXLibPINVOKE.BIFFFILE_VARRESENTRY_V1_nType_get(swigCPtr);
      return ret;
    } 
  }

  public BIFFFILE_VARRESENTRY_V1() : this(NWNXLibPINVOKE.new_BIFFFILE_VARRESENTRY_V1(), true) {
  }

}

}

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

public unsafe class CUUID : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal CUUID(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(CUUID obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~CUUID() {
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
          NWNXLibPINVOKE.delete_CUUID(swigCPtr);
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

  public static unsafe implicit operator void*(CUUID self) {
    return (void*)self.swigCPtr.Handle;
  }

  public static unsafe CUUID FromPointer(void* pointer, bool memoryOwn = false) {
    return pointer != null ? new CUUID((global::System.IntPtr)pointer, memoryOwn) : null;
  }

  public static CUUID FromPointer(global::System.IntPtr pointer, bool memoryOwn = false) {
    return pointer != global::System.IntPtr.Zero ? new CUUID(pointer, memoryOwn) : null;
  }

  public bool Equals(CUUID other) {
    if (ReferenceEquals(null, other)) {
      return false;
    }

    if (ReferenceEquals(this, other)) {
      return true;
    }

    return Pointer.Equals(other.Pointer);
  }

  public override bool Equals(object obj) {
    return ReferenceEquals(this, obj) || obj is CUUID other && Equals(other);
  }

  public override int GetHashCode() {
    return swigCPtr.Handle.GetHashCode();
  }

  public static bool operator ==(CUUID left, CUUID right) {
    return Equals(left, right);
  }

  public static bool operator !=(CUUID left, CUUID right) {
    return !Equals(left, right);
  }
/*@SWIG@*/
  public uint ab {
    set {
      NWNXLibPINVOKE.CUUID_ab_set(swigCPtr, value);
    } 
    get {
      uint ret = NWNXLibPINVOKE.CUUID_ab_get(swigCPtr);
      return ret;
    } 
  }

  public uint cd {
    set {
      NWNXLibPINVOKE.CUUID_cd_set(swigCPtr, value);
    } 
    get {
      uint ret = NWNXLibPINVOKE.CUUID_cd_get(swigCPtr);
      return ret;
    } 
  }

  public CUUID() : this(NWNXLibPINVOKE.new_CUUID(), true) {
  }

}

}

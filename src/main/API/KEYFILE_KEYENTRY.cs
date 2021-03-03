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

public unsafe class KEYFILE_KEYENTRY : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  public KEYFILE_KEYENTRY(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  public KEYFILE_KEYENTRY(void* cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, (global::System.IntPtr)cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(KEYFILE_KEYENTRY obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~KEYFILE_KEYENTRY() {
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
          NWNXLibPINVOKE.delete_KEYFILE_KEYENTRY(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
    }
  }

  public System.IntPtr Pointer {
    get {
      return swigCPtr.Handle;
    }
  }

  public static unsafe implicit operator void*(KEYFILE_KEYENTRY self) {
    return (void*)self.swigCPtr.Handle;
  }

  public static implicit operator System.IntPtr(KEYFILE_KEYENTRY self) {
    return self.swigCPtr.Handle;
  }

  public bool Equals(KEYFILE_KEYENTRY other) {
    if (ReferenceEquals(null, other)) {
      return false;
    }

    if (ReferenceEquals(this, other)) {
      return true;
    }

    return Pointer.Equals(other.Pointer);
  }

  public override bool Equals(object obj) {
    return ReferenceEquals(this, obj) || obj is KEYFILE_KEYENTRY other && Equals(other);
  }

  public override int GetHashCode() {
    return swigCPtr.Handle.GetHashCode();
  }

  public static bool operator ==(KEYFILE_KEYENTRY left, KEYFILE_KEYENTRY right) {
    return Equals(left, right);
  }

  public static bool operator !=(KEYFILE_KEYENTRY left, KEYFILE_KEYENTRY right) {
    return !Equals(left, right);
  }

  public byte[] resRef {
    set {
      NWNXLibPINVOKE.KEYFILE_KEYENTRY_resRef_set(swigCPtr, value);
    }  
    get {
      byte* arrayPtr = NWNXLibPINVOKE.KEYFILE_KEYENTRY_resRef_get(swigCPtr);
      byte[] retVal = new byte[16];

      for(int i = 0; i < 16; i++) {
        retVal[i] = arrayPtr[i];
      }

      return retVal;
    }

  }

  public ushort nType {
    set {
      NWNXLibPINVOKE.KEYFILE_KEYENTRY_nType_set(swigCPtr, value);
    } 
    get {
      ushort ret = NWNXLibPINVOKE.KEYFILE_KEYENTRY_nType_get(swigCPtr);
      return ret;
    } 
  }

  public uint nID {
    set {
      NWNXLibPINVOKE.KEYFILE_KEYENTRY_nID_set(swigCPtr, value);
    } 
    get {
      uint ret = NWNXLibPINVOKE.KEYFILE_KEYENTRY_nID_get(swigCPtr);
      return ret;
    } 
  }

  public KEYFILE_KEYENTRY() : this(NWNXLibPINVOKE.new_KEYFILE_KEYENTRY(), true) {
  }

}

}

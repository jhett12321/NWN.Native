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

  internal KEYFILE_KEYENTRY(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
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

  public global::System.IntPtr Pointer {
    get {
      return swigCPtr.Handle;
    }
  }

  public static unsafe implicit operator void*(KEYFILE_KEYENTRY self) {
    return (void*)self.swigCPtr.Handle;
  }

  public static unsafe KEYFILE_KEYENTRY FromPointer(void* pointer, bool memoryOwn = false) {
    return pointer != null ? new KEYFILE_KEYENTRY((global::System.IntPtr)pointer, memoryOwn) : null;
  }

  public static KEYFILE_KEYENTRY FromPointer(global::System.IntPtr pointer, bool memoryOwn = false) {
    return pointer != global::System.IntPtr.Zero ? new KEYFILE_KEYENTRY(pointer, memoryOwn) : null;
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

  public NativeArray<byte> resRef {
    set {
      NWNXLibPINVOKE.KEYFILE_KEYENTRY_resRef_set(swigCPtr, value);
    } 
    get {
      global::System.IntPtr arrayPtr = NWNXLibPINVOKE.KEYFILE_KEYENTRY_resRef_get(swigCPtr);
      NativeArray<byte> retVal = new NativeArray<byte>(arrayPtr, 16);

      return retVal; // byte[16]
    }

  }

  public ushort nType {
    set {
      NWNXLibPINVOKE.KEYFILE_KEYENTRY_nType_set(swigCPtr, value);
    } 
    get {
      ushort retVal = NWNXLibPINVOKE.KEYFILE_KEYENTRY_nType_get(swigCPtr);
      return retVal;
    }

  }

  public uint nID {
    set {
      NWNXLibPINVOKE.KEYFILE_KEYENTRY_nID_set(swigCPtr, value);
    } 
    get {
      uint retVal = NWNXLibPINVOKE.KEYFILE_KEYENTRY_nID_get(swigCPtr);
      return retVal;
    }

  }

  public KEYFILE_KEYENTRY() : this(NWNXLibPINVOKE.new_KEYFILE_KEYENTRY(), true) {
  }

}

}

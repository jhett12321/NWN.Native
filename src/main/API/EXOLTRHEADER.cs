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

public unsafe class EXOLTRHEADER : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  public EXOLTRHEADER(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  public EXOLTRHEADER(void* cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, (global::System.IntPtr)cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(EXOLTRHEADER obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~EXOLTRHEADER() {
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
          NWNXLibPINVOKE.delete_EXOLTRHEADER(swigCPtr);
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

  public static unsafe implicit operator void*(EXOLTRHEADER self) {
    return (void*)self.swigCPtr.Handle;
  }

  public static implicit operator global::System.IntPtr(EXOLTRHEADER self) {
    return self.swigCPtr.Handle;
  }

  public bool Equals(EXOLTRHEADER other) {
    if (ReferenceEquals(null, other)) {
      return false;
    }

    if (ReferenceEquals(this, other)) {
      return true;
    }

    return Pointer.Equals(other.Pointer);
  }

  public override bool Equals(object obj) {
    return ReferenceEquals(this, obj) || obj is EXOLTRHEADER other && Equals(other);
  }

  public override int GetHashCode() {
    return swigCPtr.Handle.GetHashCode();
  }

  public static bool operator ==(EXOLTRHEADER left, EXOLTRHEADER right) {
    return Equals(left, right);
  }

  public static bool operator !=(EXOLTRHEADER left, EXOLTRHEADER right) {
    return !Equals(left, right);
  }

  public uint m_nType {
    set {
      NWNXLibPINVOKE.EXOLTRHEADER_m_nType_set(swigCPtr, value);
    } 
    get {
      uint ret = NWNXLibPINVOKE.EXOLTRHEADER_m_nType_get(swigCPtr);
      return ret;
    } 
  }

  public uint m_nVersion {
    set {
      NWNXLibPINVOKE.EXOLTRHEADER_m_nVersion_set(swigCPtr, value);
    } 
    get {
      uint ret = NWNXLibPINVOKE.EXOLTRHEADER_m_nVersion_get(swigCPtr);
      return ret;
    } 
  }

  public byte m_nNumLetters {
    set {
      NWNXLibPINVOKE.EXOLTRHEADER_m_nNumLetters_set(swigCPtr, value);
    } 
    get {
      byte ret = NWNXLibPINVOKE.EXOLTRHEADER_m_nNumLetters_get(swigCPtr);
      return ret;
    } 
  }

  public EXOLTRHEADER() : this(NWNXLibPINVOKE.new_EXOLTRHEADER(), true) {
  }

}

}

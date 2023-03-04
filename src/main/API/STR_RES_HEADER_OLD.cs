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

public unsafe class STR_RES_HEADER_OLD : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal STR_RES_HEADER_OLD(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(STR_RES_HEADER_OLD obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~STR_RES_HEADER_OLD() {
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
          NWNXLibPINVOKE.delete_STR_RES_HEADER_OLD(swigCPtr);
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

  public static unsafe implicit operator void*(STR_RES_HEADER_OLD self) {
    return (void*)self.swigCPtr.Handle;
  }

  public static unsafe STR_RES_HEADER_OLD FromPointer(void* pointer, bool memoryOwn = false) {
    return pointer != null ? new STR_RES_HEADER_OLD((global::System.IntPtr)pointer, memoryOwn) : null;
  }

  public static STR_RES_HEADER_OLD FromPointer(global::System.IntPtr pointer, bool memoryOwn = false) {
    return pointer != global::System.IntPtr.Zero ? new STR_RES_HEADER_OLD(pointer, memoryOwn) : null;
  }

  public bool Equals(STR_RES_HEADER_OLD other) {
    if (ReferenceEquals(null, other)) {
      return false;
    }

    if (ReferenceEquals(this, other)) {
      return true;
    }

    return Pointer.Equals(other.Pointer);
  }

  public override bool Equals(object obj) {
    return ReferenceEquals(this, obj) || obj is STR_RES_HEADER_OLD other && Equals(other);
  }

  public override int GetHashCode() {
    return swigCPtr.Handle.GetHashCode();
  }

  public static bool operator ==(STR_RES_HEADER_OLD left, STR_RES_HEADER_OLD right) {
    return Equals(left, right);
  }

  public static bool operator !=(STR_RES_HEADER_OLD left, STR_RES_HEADER_OLD right) {
    return !Equals(left, right);
  }

  public uint wFlags {
    set {
      NWNXLibPINVOKE.STR_RES_HEADER_OLD_wFlags_set(swigCPtr, value);
    } 
    get {
      uint retVal = NWNXLibPINVOKE.STR_RES_HEADER_OLD_wFlags_get(swigCPtr);
      return retVal;
    }

  }

  public NativeArray<byte> sndResRef {
    set {
      NWNXLibPINVOKE.STR_RES_HEADER_OLD_sndResRef_set(swigCPtr, value);
    } 
    get {
      global::System.IntPtr arrayPtr = NWNXLibPINVOKE.STR_RES_HEADER_OLD_sndResRef_get(swigCPtr);
      NativeArray<byte> retVal = new NativeArray<byte>(arrayPtr, 16);

      return retVal; // byte[16]
    }

  }

  public uint volumeVariance {
    set {
      NWNXLibPINVOKE.STR_RES_HEADER_OLD_volumeVariance_set(swigCPtr, value);
    } 
    get {
      uint retVal = NWNXLibPINVOKE.STR_RES_HEADER_OLD_volumeVariance_get(swigCPtr);
      return retVal;
    }

  }

  public uint pitchVariance {
    set {
      NWNXLibPINVOKE.STR_RES_HEADER_OLD_pitchVariance_set(swigCPtr, value);
    } 
    get {
      uint retVal = NWNXLibPINVOKE.STR_RES_HEADER_OLD_pitchVariance_get(swigCPtr);
      return retVal;
    }

  }

  public uint offsetToStr {
    set {
      NWNXLibPINVOKE.STR_RES_HEADER_OLD_offsetToStr_set(swigCPtr, value);
    } 
    get {
      uint retVal = NWNXLibPINVOKE.STR_RES_HEADER_OLD_offsetToStr_get(swigCPtr);
      return retVal;
    }

  }

  public uint strSize {
    set {
      NWNXLibPINVOKE.STR_RES_HEADER_OLD_strSize_set(swigCPtr, value);
    } 
    get {
      uint retVal = NWNXLibPINVOKE.STR_RES_HEADER_OLD_strSize_get(swigCPtr);
      return retVal;
    }

  }

  public STR_RES_HEADER_OLD() : this(NWNXLibPINVOKE.new_STR_RES_HEADER_OLD(), true) {
  }

}

}

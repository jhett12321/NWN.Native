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

public unsafe class CNWSPVPEntry : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal CNWSPVPEntry(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(CNWSPVPEntry obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~CNWSPVPEntry() {
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
          NWNXLibPINVOKE.delete_CNWSPVPEntry(swigCPtr);
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

  public static unsafe implicit operator void*(CNWSPVPEntry self) {
    return (void*)self.swigCPtr.Handle;
  }

  public static unsafe CNWSPVPEntry FromPointer(void* pointer, bool memoryOwn = false) {
    return pointer != null ? new CNWSPVPEntry((global::System.IntPtr)pointer, memoryOwn) : null;
  }

  public static CNWSPVPEntry FromPointer(global::System.IntPtr pointer, bool memoryOwn = false) {
    return pointer != global::System.IntPtr.Zero ? new CNWSPVPEntry(pointer, memoryOwn) : null;
  }

  public bool Equals(CNWSPVPEntry other) {
    if (ReferenceEquals(null, other)) {
      return false;
    }

    if (ReferenceEquals(this, other)) {
      return true;
    }

    return Pointer.Equals(other.Pointer);
  }

  public override bool Equals(object obj) {
    return ReferenceEquals(this, obj) || obj is CNWSPVPEntry other && Equals(other);
  }

  public override int GetHashCode() {
    return swigCPtr.Handle.GetHashCode();
  }

  public static bool operator ==(CNWSPVPEntry left, CNWSPVPEntry right) {
    return Equals(left, right);
  }

  public static bool operator !=(CNWSPVPEntry left, CNWSPVPEntry right) {
    return !Equals(left, right);
  }

  public uint m_oidPC {
    set {
      NWNXLibPINVOKE.CNWSPVPEntry_m_oidPC_set(swigCPtr, value);
    } 
    get {
      uint retVal = NWNXLibPINVOKE.CNWSPVPEntry_m_oidPC_get(swigCPtr);
      return retVal;
    }

  }

  public int m_bILikePlayer {
    set {
      NWNXLibPINVOKE.CNWSPVPEntry_m_bILikePlayer_set(swigCPtr, value);
    } 
    get {
      int retVal = NWNXLibPINVOKE.CNWSPVPEntry_m_bILikePlayer_get(swigCPtr);
      return retVal;
    }

  }

  public int m_bPlayerLikesMe {
    set {
      NWNXLibPINVOKE.CNWSPVPEntry_m_bPlayerLikesMe_set(swigCPtr, value);
    } 
    get {
      int retVal = NWNXLibPINVOKE.CNWSPVPEntry_m_bPlayerLikesMe_get(swigCPtr);
      return retVal;
    }

  }

  public CNWSPVPEntry() : this(NWNXLibPINVOKE.new_CNWSPVPEntry(), true) {
  }

}

}

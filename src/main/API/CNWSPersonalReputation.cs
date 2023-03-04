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

public unsafe class CNWSPersonalReputation : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal CNWSPersonalReputation(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(CNWSPersonalReputation obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~CNWSPersonalReputation() {
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
          NWNXLibPINVOKE.delete_CNWSPersonalReputation(swigCPtr);
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

  public static unsafe implicit operator void*(CNWSPersonalReputation self) {
    return (void*)self.swigCPtr.Handle;
  }

  public static unsafe CNWSPersonalReputation FromPointer(void* pointer, bool memoryOwn = false) {
    return pointer != null ? new CNWSPersonalReputation((global::System.IntPtr)pointer, memoryOwn) : null;
  }

  public static CNWSPersonalReputation FromPointer(global::System.IntPtr pointer, bool memoryOwn = false) {
    return pointer != global::System.IntPtr.Zero ? new CNWSPersonalReputation(pointer, memoryOwn) : null;
  }

  public bool Equals(CNWSPersonalReputation other) {
    if (ReferenceEquals(null, other)) {
      return false;
    }

    if (ReferenceEquals(this, other)) {
      return true;
    }

    return Pointer.Equals(other.Pointer);
  }

  public override bool Equals(object obj) {
    return ReferenceEquals(this, obj) || obj is CNWSPersonalReputation other && Equals(other);
  }

  public override int GetHashCode() {
    return swigCPtr.Handle.GetHashCode();
  }

  public static bool operator ==(CNWSPersonalReputation left, CNWSPersonalReputation right) {
    return Equals(left, right);
  }

  public static bool operator !=(CNWSPersonalReputation left, CNWSPersonalReputation right) {
    return !Equals(left, right);
  }

  public uint m_nDay {
    set {
      NWNXLibPINVOKE.CNWSPersonalReputation_m_nDay_set(swigCPtr, value);
    } 
    get {
      uint retVal = NWNXLibPINVOKE.CNWSPersonalReputation_m_nDay_get(swigCPtr);
      return retVal;
    }

  }

  public uint m_nTime {
    set {
      NWNXLibPINVOKE.CNWSPersonalReputation_m_nTime_set(swigCPtr, value);
    } 
    get {
      uint retVal = NWNXLibPINVOKE.CNWSPersonalReputation_m_nTime_get(swigCPtr);
      return retVal;
    }

  }

  public int m_bValueDecays {
    set {
      NWNXLibPINVOKE.CNWSPersonalReputation_m_bValueDecays_set(swigCPtr, value);
    } 
    get {
      int retVal = NWNXLibPINVOKE.CNWSPersonalReputation_m_bValueDecays_get(swigCPtr);
      return retVal;
    }

  }

  public int m_nDurationInSeconds {
    set {
      NWNXLibPINVOKE.CNWSPersonalReputation_m_nDurationInSeconds_set(swigCPtr, value);
    } 
    get {
      int retVal = NWNXLibPINVOKE.CNWSPersonalReputation_m_nDurationInSeconds_get(swigCPtr);
      return retVal;
    }

  }

  public uint m_oidCreature {
    set {
      NWNXLibPINVOKE.CNWSPersonalReputation_m_oidCreature_set(swigCPtr, value);
    } 
    get {
      uint retVal = NWNXLibPINVOKE.CNWSPersonalReputation_m_oidCreature_get(swigCPtr);
      return retVal;
    }

  }

  public int m_nAmount {
    set {
      NWNXLibPINVOKE.CNWSPersonalReputation_m_nAmount_set(swigCPtr, value);
    } 
    get {
      int retVal = NWNXLibPINVOKE.CNWSPersonalReputation_m_nAmount_get(swigCPtr);
      return retVal;
    }

  }

  public CNWSPersonalReputation() : this(NWNXLibPINVOKE.new_CNWSPersonalReputation(), true) {
  }

}

}

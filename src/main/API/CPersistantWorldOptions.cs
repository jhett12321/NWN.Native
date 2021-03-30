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

public unsafe class CPersistantWorldOptions : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  public CPersistantWorldOptions(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  public CPersistantWorldOptions(void* cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, (global::System.IntPtr)cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(CPersistantWorldOptions obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~CPersistantWorldOptions() {
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
          NWNXLibPINVOKE.delete_CPersistantWorldOptions(swigCPtr);
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

  public static unsafe implicit operator void*(CPersistantWorldOptions self) {
    return (void*)self.swigCPtr.Handle;
  }

  public static implicit operator global::System.IntPtr(CPersistantWorldOptions self) {
    return self.swigCPtr.Handle;
  }

  public bool Equals(CPersistantWorldOptions other) {
    if (ReferenceEquals(null, other)) {
      return false;
    }

    if (ReferenceEquals(this, other)) {
      return true;
    }

    return Pointer.Equals(other.Pointer);
  }

  public override bool Equals(object obj) {
    return ReferenceEquals(this, obj) || obj is CPersistantWorldOptions other && Equals(other);
  }

  public override int GetHashCode() {
    return swigCPtr.Handle.GetHashCode();
  }

  public static bool operator ==(CPersistantWorldOptions left, CPersistantWorldOptions right) {
    return Equals(left, right);
  }

  public static bool operator !=(CPersistantWorldOptions left, CPersistantWorldOptions right) {
    return !Equals(left, right);
  }

  public int bVaultCharsOnly {
    set {
      NWNXLibPINVOKE.CPersistantWorldOptions_bVaultCharsOnly_set(swigCPtr, value);
    } 
    get {
      int ret = NWNXLibPINVOKE.CPersistantWorldOptions_bVaultCharsOnly_get(swigCPtr);
      return ret;
    } 
  }

  public int bSaveCharsInSaveGame {
    set {
      NWNXLibPINVOKE.CPersistantWorldOptions_bSaveCharsInSaveGame_set(swigCPtr, value);
    } 
    get {
      int ret = NWNXLibPINVOKE.CPersistantWorldOptions_bSaveCharsInSaveGame_get(swigCPtr);
      return ret;
    } 
  }

  public int bSuppressBaseServerVault {
    set {
      NWNXLibPINVOKE.CPersistantWorldOptions_bSuppressBaseServerVault_set(swigCPtr, value);
    } 
    get {
      int ret = NWNXLibPINVOKE.CPersistantWorldOptions_bSuppressBaseServerVault_get(swigCPtr);
      return ret;
    } 
  }

  public int bStickyPlayerNames {
    set {
      NWNXLibPINVOKE.CPersistantWorldOptions_bStickyPlayerNames_set(swigCPtr, value);
    } 
    get {
      int ret = NWNXLibPINVOKE.CPersistantWorldOptions_bStickyPlayerNames_get(swigCPtr);
      return ret;
    } 
  }

  public int bServerVaultByPlayerName {
    set {
      NWNXLibPINVOKE.CPersistantWorldOptions_bServerVaultByPlayerName_set(swigCPtr, value);
    } 
    get {
      int ret = NWNXLibPINVOKE.CPersistantWorldOptions_bServerVaultByPlayerName_get(swigCPtr);
      return ret;
    } 
  }

  public CPersistantWorldOptions() : this(NWNXLibPINVOKE.new_CPersistantWorldOptions(), true) {
  }

}

}

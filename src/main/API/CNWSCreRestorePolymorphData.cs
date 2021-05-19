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

public unsafe class CNWSCreRestorePolymorphData : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal CNWSCreRestorePolymorphData(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(CNWSCreRestorePolymorphData obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~CNWSCreRestorePolymorphData() {
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
          NWNXLibPINVOKE.delete_CNWSCreRestorePolymorphData(swigCPtr);
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

  public static unsafe implicit operator void*(CNWSCreRestorePolymorphData self) {
    return (void*)self.swigCPtr.Handle;
  }

  public static unsafe CNWSCreRestorePolymorphData FromPointer(void* pointer, bool memoryOwn = false) {
    return pointer != null ? new CNWSCreRestorePolymorphData((global::System.IntPtr)pointer, memoryOwn) : null;
  }

  public static CNWSCreRestorePolymorphData FromPointer(global::System.IntPtr pointer, bool memoryOwn = false) {
    return pointer != global::System.IntPtr.Zero ? new CNWSCreRestorePolymorphData(pointer, memoryOwn) : null;
  }

  public bool Equals(CNWSCreRestorePolymorphData other) {
    if (ReferenceEquals(null, other)) {
      return false;
    }

    if (ReferenceEquals(this, other)) {
      return true;
    }

    return Pointer.Equals(other.Pointer);
  }

  public override bool Equals(object obj) {
    return ReferenceEquals(this, obj) || obj is CNWSCreRestorePolymorphData other && Equals(other);
  }

  public override int GetHashCode() {
    return swigCPtr.Handle.GetHashCode();
  }

  public static bool operator ==(CNWSCreRestorePolymorphData left, CNWSCreRestorePolymorphData right) {
    return Equals(left, right);
  }

  public static bool operator !=(CNWSCreRestorePolymorphData left, CNWSCreRestorePolymorphData right) {
    return !Equals(left, right);
  }
/*@SWIG@*/
  public int nCurrentHitPoints {
    set {
      NWNXLibPINVOKE.CNWSCreRestorePolymorphData_nCurrentHitPoints_set(swigCPtr, value);
    } 
    get {
      int ret = NWNXLibPINVOKE.CNWSCreRestorePolymorphData_nCurrentHitPoints_get(swigCPtr);
      return ret;
    } 
  }

  public int nTemporaryHitPoints {
    set {
      NWNXLibPINVOKE.CNWSCreRestorePolymorphData_nTemporaryHitPoints_set(swigCPtr, value);
    } 
    get {
      int ret = NWNXLibPINVOKE.CNWSCreRestorePolymorphData_nTemporaryHitPoints_get(swigCPtr);
      return ret;
    } 
  }

  public CGameEffect effect {
    set {
      NWNXLibPINVOKE.CNWSCreRestorePolymorphData_effect_set(swigCPtr, CGameEffect.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = NWNXLibPINVOKE.CNWSCreRestorePolymorphData_effect_get(swigCPtr);
      CGameEffect ret = (cPtr == global::System.IntPtr.Zero) ? null : new CGameEffect(cPtr, false);
      return ret;
    } 
  }

  public CNWSItem pItemCreatureHide {
    set {
      NWNXLibPINVOKE.CNWSCreRestorePolymorphData_pItemCreatureHide_set(swigCPtr, CNWSItem.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = NWNXLibPINVOKE.CNWSCreRestorePolymorphData_pItemCreatureHide_get(swigCPtr);
      CNWSItem ret = (cPtr == global::System.IntPtr.Zero) ? null : new CNWSItem(cPtr, false);
      return ret;
    } 
  }

  public CNWSItem pItemCreatureWeapon {
    set {
      NWNXLibPINVOKE.CNWSCreRestorePolymorphData_pItemCreatureWeapon_set(swigCPtr, CNWSItem.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = NWNXLibPINVOKE.CNWSCreRestorePolymorphData_pItemCreatureWeapon_get(swigCPtr);
      CNWSItem ret = (cPtr == global::System.IntPtr.Zero) ? null : new CNWSItem(cPtr, false);
      return ret;
    } 
  }

  public int bTemporaryEffect {
    set {
      NWNXLibPINVOKE.CNWSCreRestorePolymorphData_bTemporaryEffect_set(swigCPtr, value);
    } 
    get {
      int ret = NWNXLibPINVOKE.CNWSCreRestorePolymorphData_bTemporaryEffect_get(swigCPtr);
      return ret;
    } 
  }

  public uint nExpiryDate {
    set {
      NWNXLibPINVOKE.CNWSCreRestorePolymorphData_nExpiryDate_set(swigCPtr, value);
    } 
    get {
      uint ret = NWNXLibPINVOKE.CNWSCreRestorePolymorphData_nExpiryDate_get(swigCPtr);
      return ret;
    } 
  }

  public uint nExpiryTime {
    set {
      NWNXLibPINVOKE.CNWSCreRestorePolymorphData_nExpiryTime_set(swigCPtr, value);
    } 
    get {
      uint ret = NWNXLibPINVOKE.CNWSCreRestorePolymorphData_nExpiryTime_get(swigCPtr);
      return ret;
    } 
  }

  public CNWSCreRestorePolymorphData() : this(NWNXLibPINVOKE.new_CNWSCreRestorePolymorphData(), true) {
  }

}

}

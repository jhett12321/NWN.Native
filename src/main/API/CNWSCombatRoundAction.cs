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

public unsafe class CNWSCombatRoundAction : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal CNWSCombatRoundAction(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(CNWSCombatRoundAction obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~CNWSCombatRoundAction() {
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
          NWNXLibPINVOKE.delete_CNWSCombatRoundAction(swigCPtr);
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

  public static unsafe implicit operator void*(CNWSCombatRoundAction self) {
    return (void*)self.swigCPtr.Handle;
  }

  public static unsafe CNWSCombatRoundAction FromPointer(void* pointer, bool memoryOwn = false) {
    return pointer != null ? new CNWSCombatRoundAction((global::System.IntPtr)pointer, memoryOwn) : null;
  }

  public static CNWSCombatRoundAction FromPointer(global::System.IntPtr pointer, bool memoryOwn = false) {
    return pointer != global::System.IntPtr.Zero ? new CNWSCombatRoundAction(pointer, memoryOwn) : null;
  }

  public bool Equals(CNWSCombatRoundAction other) {
    if (ReferenceEquals(null, other)) {
      return false;
    }

    if (ReferenceEquals(this, other)) {
      return true;
    }

    return Pointer.Equals(other.Pointer);
  }

  public override bool Equals(object obj) {
    return ReferenceEquals(this, obj) || obj is CNWSCombatRoundAction other && Equals(other);
  }

  public override int GetHashCode() {
    return swigCPtr.Handle.GetHashCode();
  }

  public static bool operator ==(CNWSCombatRoundAction left, CNWSCombatRoundAction right) {
    return Equals(left, right);
  }

  public static bool operator !=(CNWSCombatRoundAction left, CNWSCombatRoundAction right) {
    return !Equals(left, right);
  }

  public int m_nActionTimer {
    set {
      NWNXLibPINVOKE.CNWSCombatRoundAction_m_nActionTimer_set(swigCPtr, value);
    } 
    get {
      int retVal = NWNXLibPINVOKE.CNWSCombatRoundAction_m_nActionTimer_get(swigCPtr);
      return retVal;
    }

  }

  public ushort m_nAnimation {
    set {
      NWNXLibPINVOKE.CNWSCombatRoundAction_m_nAnimation_set(swigCPtr, value);
    } 
    get {
      ushort retVal = NWNXLibPINVOKE.CNWSCombatRoundAction_m_nAnimation_get(swigCPtr);
      return retVal;
    }

  }

  public int m_nAnimationTime {
    set {
      NWNXLibPINVOKE.CNWSCombatRoundAction_m_nAnimationTime_set(swigCPtr, value);
    } 
    get {
      int retVal = NWNXLibPINVOKE.CNWSCombatRoundAction_m_nAnimationTime_get(swigCPtr);
      return retVal;
    }

  }

  public int m_nNumAttacks {
    set {
      NWNXLibPINVOKE.CNWSCombatRoundAction_m_nNumAttacks_set(swigCPtr, value);
    } 
    get {
      int retVal = NWNXLibPINVOKE.CNWSCombatRoundAction_m_nNumAttacks_get(swigCPtr);
      return retVal;
    }

  }

  public byte m_nActionType {
    set {
      NWNXLibPINVOKE.CNWSCombatRoundAction_m_nActionType_set(swigCPtr, value);
    } 
    get {
      byte retVal = NWNXLibPINVOKE.CNWSCombatRoundAction_m_nActionType_get(swigCPtr);
      return retVal;
    }

  }

  public uint m_oidTarget {
    set {
      NWNXLibPINVOKE.CNWSCombatRoundAction_m_oidTarget_set(swigCPtr, value);
    } 
    get {
      uint retVal = NWNXLibPINVOKE.CNWSCombatRoundAction_m_oidTarget_get(swigCPtr);
      return retVal;
    }

  }

  public int m_bActionRetargettable {
    set {
      NWNXLibPINVOKE.CNWSCombatRoundAction_m_bActionRetargettable_set(swigCPtr, value);
    } 
    get {
      int retVal = NWNXLibPINVOKE.CNWSCombatRoundAction_m_bActionRetargettable_get(swigCPtr);
      return retVal;
    }

  }

  public uint m_nInventorySlot {
    set {
      NWNXLibPINVOKE.CNWSCombatRoundAction_m_nInventorySlot_set(swigCPtr, value);
    } 
    get {
      uint retVal = NWNXLibPINVOKE.CNWSCombatRoundAction_m_nInventorySlot_get(swigCPtr);
      return retVal;
    }

  }

  public uint m_oidTargetRepository {
    set {
      NWNXLibPINVOKE.CNWSCombatRoundAction_m_oidTargetRepository_set(swigCPtr, value);
    } 
    get {
      uint retVal = NWNXLibPINVOKE.CNWSCombatRoundAction_m_oidTargetRepository_get(swigCPtr);
      return retVal;
    }

  }

  public byte m_nRepositoryX {
    set {
      NWNXLibPINVOKE.CNWSCombatRoundAction_m_nRepositoryX_set(swigCPtr, value);
    } 
    get {
      byte retVal = NWNXLibPINVOKE.CNWSCombatRoundAction_m_nRepositoryX_get(swigCPtr);
      return retVal;
    }

  }

  public byte m_nRepositoryY {
    set {
      NWNXLibPINVOKE.CNWSCombatRoundAction_m_nRepositoryY_set(swigCPtr, value);
    } 
    get {
      byte retVal = NWNXLibPINVOKE.CNWSCombatRoundAction_m_nRepositoryY_get(swigCPtr);
      return retVal;
    }

  }

  public CNWSCombatRoundAction() : this(NWNXLibPINVOKE.new_CNWSCombatRoundAction(), true) {
  }

  public int SaveData(CResGFF pRes, CResStruct pStruct) {
    int retVal = NWNXLibPINVOKE.CNWSCombatRoundAction_SaveData(swigCPtr, CResGFF.getCPtr(pRes), CResStruct.getCPtr(pStruct));
    return retVal;
  }

  public int LoadData(CResGFF pRes, CResStruct pStruct) {
    int retVal = NWNXLibPINVOKE.CNWSCombatRoundAction_LoadData(swigCPtr, CResGFF.getCPtr(pRes), CResStruct.getCPtr(pStruct));
    return retVal;
  }

  public void _Destructor() {
    NWNXLibPINVOKE.CNWSCombatRoundAction__Destructor(swigCPtr);
  }

}

}

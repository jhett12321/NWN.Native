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

public unsafe class CLastUpdateObject : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal CLastUpdateObject(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(CLastUpdateObject obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~CLastUpdateObject() {
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
          NWNXLibPINVOKE.delete_CLastUpdateObject(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
    }
  }
/*@SWIG:/__w/NWN.Native/NWN.Native/nwnx/Plugins/SWIG/SWIG_DotNET/DotNETExtensions.i,1,SWIG_DOTNET_EXTENSIONS@*/
  public global::System.IntPtr Pointer {
    get {
      return swigCPtr.Handle;
    }
  }

  public static unsafe implicit operator void*(CLastUpdateObject self) {
    return (void*)self.swigCPtr.Handle;
  }

  public static unsafe CLastUpdateObject FromPointer(void* pointer, bool memoryOwn = false) {
    return pointer != null ? new CLastUpdateObject((global::System.IntPtr)pointer, memoryOwn) : null;
  }

  public static CLastUpdateObject FromPointer(global::System.IntPtr pointer, bool memoryOwn = false) {
    return pointer != global::System.IntPtr.Zero ? new CLastUpdateObject(pointer, memoryOwn) : null;
  }

  public bool Equals(CLastUpdateObject other) {
    if (ReferenceEquals(null, other)) {
      return false;
    }

    if (ReferenceEquals(this, other)) {
      return true;
    }

    return Pointer.Equals(other.Pointer);
  }

  public override bool Equals(object obj) {
    return ReferenceEquals(this, obj) || obj is CLastUpdateObject other && Equals(other);
  }

  public override int GetHashCode() {
    return swigCPtr.Handle.GetHashCode();
  }

  public static bool operator ==(CLastUpdateObject left, CLastUpdateObject right) {
    return Equals(left, right);
  }

  public static bool operator !=(CLastUpdateObject left, CLastUpdateObject right) {
    return !Equals(left, right);
  }
/*@SWIG@*/
  public CNWSPlayerLUOAppearanceInfo m_cAppearance {
    set {
      NWNXLibPINVOKE.CLastUpdateObject_m_cAppearance_set(swigCPtr, CNWSPlayerLUOAppearanceInfo.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = NWNXLibPINVOKE.CLastUpdateObject_m_cAppearance_get(swigCPtr);
      CNWSPlayerLUOAppearanceInfo ret = (cPtr == global::System.IntPtr.Zero) ? null : new CNWSPlayerLUOAppearanceInfo(cPtr, false);
      return ret;
    } 
  }

  public int m_bActive {
    set {
      NWNXLibPINVOKE.CLastUpdateObject_m_bActive_set(swigCPtr, value);
    } 
    get {
      int retVal = NWNXLibPINVOKE.CLastUpdateObject_m_bActive_get(swigCPtr);
      return retVal;
    }

  }

  public byte m_nObjectType {
    set {
      NWNXLibPINVOKE.CLastUpdateObject_m_nObjectType_set(swigCPtr, value);
    } 
    get {
      byte retVal = NWNXLibPINVOKE.CLastUpdateObject_m_nObjectType_get(swigCPtr);
      return retVal;
    }

  }

  public ushort m_nSoundSet {
    set {
      NWNXLibPINVOKE.CLastUpdateObject_m_nSoundSet_set(swigCPtr, value);
    } 
    get {
      ushort retVal = NWNXLibPINVOKE.CLastUpdateObject_m_nSoundSet_get(swigCPtr);
      return retVal;
    }

  }

  public int m_nFootstepType {
    set {
      NWNXLibPINVOKE.CLastUpdateObject_m_nFootstepType_set(swigCPtr, value);
    } 
    get {
      int retVal = NWNXLibPINVOKE.CLastUpdateObject_m_nFootstepType_get(swigCPtr);
      return retVal;
    }

  }

  public uint m_nId {
    set {
      NWNXLibPINVOKE.CLastUpdateObject_m_nId_set(swigCPtr, value);
    } 
    get {
      uint retVal = NWNXLibPINVOKE.CLastUpdateObject_m_nId_get(swigCPtr);
      return retVal;
    }

  }

  public Vector m_vPosition {
    set {
      NWNXLibPINVOKE.CLastUpdateObject_m_vPosition_set(swigCPtr, Vector.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = NWNXLibPINVOKE.CLastUpdateObject_m_vPosition_get(swigCPtr);
      Vector ret = (cPtr == global::System.IntPtr.Zero) ? null : new Vector(cPtr, false);
      return ret;
    } 
  }

  public uint m_oidArea {
    set {
      NWNXLibPINVOKE.CLastUpdateObject_m_oidArea_set(swigCPtr, value);
    } 
    get {
      uint retVal = NWNXLibPINVOKE.CLastUpdateObject_m_oidArea_get(swigCPtr);
      return retVal;
    }

  }

  public Vector m_vOrientation {
    set {
      NWNXLibPINVOKE.CLastUpdateObject_m_vOrientation_set(swigCPtr, Vector.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = NWNXLibPINVOKE.CLastUpdateObject_m_vOrientation_get(swigCPtr);
      Vector ret = (cPtr == global::System.IntPtr.Zero) ? null : new Vector(cPtr, false);
      return ret;
    } 
  }

  public int m_nAnimation {
    set {
      NWNXLibPINVOKE.CLastUpdateObject_m_nAnimation_set(swigCPtr, value);
    } 
    get {
      int retVal = NWNXLibPINVOKE.CLastUpdateObject_m_nAnimation_get(swigCPtr);
      return retVal;
    }

  }

  public float m_fAnimSpeed {
    set {
      NWNXLibPINVOKE.CLastUpdateObject_m_fAnimSpeed_set(swigCPtr, value);
    } 
    get {
      float retVal = NWNXLibPINVOKE.CLastUpdateObject_m_fAnimSpeed_get(swigCPtr);
      return retVal;
    }

  }

  public byte m_nWalkAnimation {
    set {
      NWNXLibPINVOKE.CLastUpdateObject_m_nWalkAnimation_set(swigCPtr, value);
    } 
    get {
      byte retVal = NWNXLibPINVOKE.CLastUpdateObject_m_nWalkAnimation_get(swigCPtr);
      return retVal;
    }

  }

  public Vector m_vWalkTo {
    set {
      NWNXLibPINVOKE.CLastUpdateObject_m_vWalkTo_set(swigCPtr, Vector.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = NWNXLibPINVOKE.CLastUpdateObject_m_vWalkTo_get(swigCPtr);
      Vector ret = (cPtr == global::System.IntPtr.Zero) ? null : new Vector(cPtr, false);
      return ret;
    } 
  }

  public byte m_nPlayerPathNumber {
    set {
      NWNXLibPINVOKE.CLastUpdateObject_m_nPlayerPathNumber_set(swigCPtr, value);
    } 
    get {
      byte retVal = NWNXLibPINVOKE.CLastUpdateObject_m_nPlayerPathNumber_get(swigCPtr);
      return retVal;
    }

  }

  public byte m_nWalkedPathCutVerify {
    set {
      NWNXLibPINVOKE.CLastUpdateObject_m_nWalkedPathCutVerify_set(swigCPtr, value);
    } 
    get {
      byte retVal = NWNXLibPINVOKE.CLastUpdateObject_m_nWalkedPathCutVerify_get(swigCPtr);
      return retVal;
    }

  }

  public ushort m_nAIState {
    set {
      NWNXLibPINVOKE.CLastUpdateObject_m_nAIState_set(swigCPtr, value);
    } 
    get {
      ushort retVal = NWNXLibPINVOKE.CLastUpdateObject_m_nAIState_get(swigCPtr);
      return retVal;
    }

  }

  public byte m_nAIStateAction {
    set {
      NWNXLibPINVOKE.CLastUpdateObject_m_nAIStateAction_set(swigCPtr, value);
    } 
    get {
      byte retVal = NWNXLibPINVOKE.CLastUpdateObject_m_nAIStateAction_get(swigCPtr);
      return retVal;
    }

  }

  public ushort m_nAIStateActivities {
    set {
      NWNXLibPINVOKE.CLastUpdateObject_m_nAIStateActivities_set(swigCPtr, value);
    } 
    get {
      ushort retVal = NWNXLibPINVOKE.CLastUpdateObject_m_nAIStateActivities_get(swigCPtr);
      return retVal;
    }

  }

  public int m_bCombatState {
    set {
      NWNXLibPINVOKE.CLastUpdateObject_m_bCombatState_set(swigCPtr, value);
    } 
    get {
      int retVal = NWNXLibPINVOKE.CLastUpdateObject_m_bCombatState_get(swigCPtr);
      return retVal;
    }

  }

  public uint m_oidAIStateActee {
    set {
      NWNXLibPINVOKE.CLastUpdateObject_m_oidAIStateActee_set(swigCPtr, value);
    } 
    get {
      uint retVal = NWNXLibPINVOKE.CLastUpdateObject_m_oidAIStateActee_get(swigCPtr);
      return retVal;
    }

  }

  public uint m_oidLockOnTarget {
    set {
      NWNXLibPINVOKE.CLastUpdateObject_m_oidLockOnTarget_set(swigCPtr, value);
    } 
    get {
      uint retVal = NWNXLibPINVOKE.CLastUpdateObject_m_oidLockOnTarget_get(swigCPtr);
      return retVal;
    }

  }

  public uint m_oidAttackTarget {
    set {
      NWNXLibPINVOKE.CLastUpdateObject_m_oidAttackTarget_set(swigCPtr, value);
    } 
    get {
      uint retVal = NWNXLibPINVOKE.CLastUpdateObject_m_oidAttackTarget_get(swigCPtr);
      return retVal;
    }

  }

  public CResRef m_cPortrait {
    set {
      NWNXLibPINVOKE.CLastUpdateObject_m_cPortrait_set(swigCPtr, CResRef.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = NWNXLibPINVOKE.CLastUpdateObject_m_cPortrait_get(swigCPtr);
      CResRef ret = (cPtr == global::System.IntPtr.Zero) ? null : new CResRef(cPtr, false);
      return ret;
    } 
  }

  public ushort m_nPortraitId {
    set {
      NWNXLibPINVOKE.CLastUpdateObject_m_nPortraitId_set(swigCPtr, value);
    } 
    get {
      ushort retVal = NWNXLibPINVOKE.CLastUpdateObject_m_nPortraitId_get(swigCPtr);
      return retVal;
    }

  }

  public CExoLocString m_sLocFirstName {
    set {
      NWNXLibPINVOKE.CLastUpdateObject_m_sLocFirstName_set(swigCPtr, CExoLocString.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = NWNXLibPINVOKE.CLastUpdateObject_m_sLocFirstName_get(swigCPtr);
      CExoLocString ret = (cPtr == global::System.IntPtr.Zero) ? null : new CExoLocString(cPtr, false);
      return ret;
    } 
  }

  public CExoLocString m_sLocLastName {
    set {
      NWNXLibPINVOKE.CLastUpdateObject_m_sLocLastName_set(swigCPtr, CExoLocString.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = NWNXLibPINVOKE.CLastUpdateObject_m_sLocLastName_get(swigCPtr);
      CExoLocString ret = (cPtr == global::System.IntPtr.Zero) ? null : new CExoLocString(cPtr, false);
      return ret;
    } 
  }

  public float m_fWalkRate {
    set {
      NWNXLibPINVOKE.CLastUpdateObject_m_fWalkRate_set(swigCPtr, value);
    } 
    get {
      float retVal = NWNXLibPINVOKE.CLastUpdateObject_m_fWalkRate_get(swigCPtr);
      return retVal;
    }

  }

  public float m_fRunRate {
    set {
      NWNXLibPINVOKE.CLastUpdateObject_m_fRunRate_set(swigCPtr, value);
    } 
    get {
      float retVal = NWNXLibPINVOKE.CLastUpdateObject_m_fRunRate_get(swigCPtr);
      return retVal;
    }

  }

  public CExoArrayListCLoopingVisualEffectPtr m_lstLoopingVisualEffects {
    set {
      NWNXLibPINVOKE.CLastUpdateObject_m_lstLoopingVisualEffects_set(swigCPtr, CExoArrayListCLoopingVisualEffectPtr.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = NWNXLibPINVOKE.CLastUpdateObject_m_lstLoopingVisualEffects_get(swigCPtr);
      CExoArrayListCLoopingVisualEffectPtr ret = (cPtr == global::System.IntPtr.Zero) ? null : new CExoArrayListCLoopingVisualEffectPtr(cPtr, false);
      return ret;
    } 
  }

  public ushort m_nAssociateState {
    set {
      NWNXLibPINVOKE.CLastUpdateObject_m_nAssociateState_set(swigCPtr, value);
    } 
    get {
      ushort retVal = NWNXLibPINVOKE.CLastUpdateObject_m_nAssociateState_get(swigCPtr);
      return retVal;
    }

  }

  public byte m_nDamageLevel {
    set {
      NWNXLibPINVOKE.CLastUpdateObject_m_nDamageLevel_set(swigCPtr, value);
    } 
    get {
      byte retVal = NWNXLibPINVOKE.CLastUpdateObject_m_nDamageLevel_get(swigCPtr);
      return retVal;
    }

  }

  public byte m_nDomain1 {
    set {
      NWNXLibPINVOKE.CLastUpdateObject_m_nDomain1_set(swigCPtr, value);
    } 
    get {
      byte retVal = NWNXLibPINVOKE.CLastUpdateObject_m_nDomain1_get(swigCPtr);
      return retVal;
    }

  }

  public byte m_nDomain2 {
    set {
      NWNXLibPINVOKE.CLastUpdateObject_m_nDomain2_set(swigCPtr, value);
    } 
    get {
      byte retVal = NWNXLibPINVOKE.CLastUpdateObject_m_nDomain2_get(swigCPtr);
      return retVal;
    }

  }

  public byte m_nSchool {
    set {
      NWNXLibPINVOKE.CLastUpdateObject_m_nSchool_set(swigCPtr, value);
    } 
    get {
      byte retVal = NWNXLibPINVOKE.CLastUpdateObject_m_nSchool_get(swigCPtr);
      return retVal;
    }

  }

  public short m_nCurrentHitPoints {
    set {
      NWNXLibPINVOKE.CLastUpdateObject_m_nCurrentHitPoints_set(swigCPtr, value);
    } 
    get {
      short retVal = NWNXLibPINVOKE.CLastUpdateObject_m_nCurrentHitPoints_get(swigCPtr);
      return retVal;
    }

  }

  public short m_nBaseHitPoints {
    set {
      NWNXLibPINVOKE.CLastUpdateObject_m_nBaseHitPoints_set(swigCPtr, value);
    } 
    get {
      short retVal = NWNXLibPINVOKE.CLastUpdateObject_m_nBaseHitPoints_get(swigCPtr);
      return retVal;
    }

  }

  public short m_nTemporaryHitPoints {
    set {
      NWNXLibPINVOKE.CLastUpdateObject_m_nTemporaryHitPoints_set(swigCPtr, value);
    } 
    get {
      short retVal = NWNXLibPINVOKE.CLastUpdateObject_m_nTemporaryHitPoints_get(swigCPtr);
      return retVal;
    }

  }

  public short m_nMaxHitPoints {
    set {
      NWNXLibPINVOKE.CLastUpdateObject_m_nMaxHitPoints_set(swigCPtr, value);
    } 
    get {
      short retVal = NWNXLibPINVOKE.CLastUpdateObject_m_nMaxHitPoints_get(swigCPtr);
      return retVal;
    }

  }

  public int m_bFreeWill {
    set {
      NWNXLibPINVOKE.CLastUpdateObject_m_bFreeWill_set(swigCPtr, value);
    } 
    get {
      int retVal = NWNXLibPINVOKE.CLastUpdateObject_m_bFreeWill_get(swigCPtr);
      return retVal;
    }

  }

  public int m_bPartyLeader {
    set {
      NWNXLibPINVOKE.CLastUpdateObject_m_bPartyLeader_set(swigCPtr, value);
    } 
    get {
      int retVal = NWNXLibPINVOKE.CLastUpdateObject_m_bPartyLeader_get(swigCPtr);
      return retVal;
    }

  }

  public int m_bSingletonParty {
    set {
      NWNXLibPINVOKE.CLastUpdateObject_m_bSingletonParty_set(swigCPtr, value);
    } 
    get {
      int retVal = NWNXLibPINVOKE.CLastUpdateObject_m_bSingletonParty_get(swigCPtr);
      return retVal;
    }

  }

  public int m_bInvitedToParty {
    set {
      NWNXLibPINVOKE.CLastUpdateObject_m_bInvitedToParty_set(swigCPtr, value);
    } 
    get {
      int retVal = NWNXLibPINVOKE.CLastUpdateObject_m_bInvitedToParty_get(swigCPtr);
      return retVal;
    }

  }

  public CExoArrayListUInt32 m_poidCreatureList {
    set {
      NWNXLibPINVOKE.CLastUpdateObject_m_poidCreatureList_set(swigCPtr, CExoArrayListUInt32.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = NWNXLibPINVOKE.CLastUpdateObject_m_poidCreatureList_get(swigCPtr);
      CExoArrayListUInt32 ret = (cPtr == global::System.IntPtr.Zero) ? null : new CExoArrayListUInt32(cPtr, false);
      return ret;
    } 
  }

  public int m_bTrapped {
    set {
      NWNXLibPINVOKE.CLastUpdateObject_m_bTrapped_set(swigCPtr, value);
    } 
    get {
      int retVal = NWNXLibPINVOKE.CLastUpdateObject_m_bTrapped_get(swigCPtr);
      return retVal;
    }

  }

  public int m_bFlagged {
    set {
      NWNXLibPINVOKE.CLastUpdateObject_m_bFlagged_set(swigCPtr, value);
    } 
    get {
      int retVal = NWNXLibPINVOKE.CLastUpdateObject_m_bFlagged_get(swigCPtr);
      return retVal;
    }

  }

  public int m_nTrapFaction {
    set {
      NWNXLibPINVOKE.CLastUpdateObject_m_nTrapFaction_set(swigCPtr, value);
    } 
    get {
      int retVal = NWNXLibPINVOKE.CLastUpdateObject_m_nTrapFaction_get(swigCPtr);
      return retVal;
    }

  }

  public int m_bLocked {
    set {
      NWNXLibPINVOKE.CLastUpdateObject_m_bLocked_set(swigCPtr, value);
    } 
    get {
      int retVal = NWNXLibPINVOKE.CLastUpdateObject_m_bLocked_get(swigCPtr);
      return retVal;
    }

  }

  public int m_bLockable {
    set {
      NWNXLibPINVOKE.CLastUpdateObject_m_bLockable_set(swigCPtr, value);
    } 
    get {
      int retVal = NWNXLibPINVOKE.CLastUpdateObject_m_bLockable_get(swigCPtr);
      return retVal;
    }

  }

  public int m_bRecoverable {
    set {
      NWNXLibPINVOKE.CLastUpdateObject_m_bRecoverable_set(swigCPtr, value);
    } 
    get {
      int retVal = NWNXLibPINVOKE.CLastUpdateObject_m_bRecoverable_get(swigCPtr);
      return retVal;
    }

  }

  public int m_bClickable {
    set {
      NWNXLibPINVOKE.CLastUpdateObject_m_bClickable_set(swigCPtr, value);
    } 
    get {
      int retVal = NWNXLibPINVOKE.CLastUpdateObject_m_bClickable_get(swigCPtr);
      return retVal;
    }

  }

  public byte m_nAIStateReaction {
    set {
      NWNXLibPINVOKE.CLastUpdateObject_m_nAIStateReaction_set(swigCPtr, value);
    } 
    get {
      byte retVal = NWNXLibPINVOKE.CLastUpdateObject_m_nAIStateReaction_get(swigCPtr);
      return retVal;
    }

  }

  public uint m_oidMaster {
    set {
      NWNXLibPINVOKE.CLastUpdateObject_m_oidMaster_set(swigCPtr, value);
    } 
    get {
      uint retVal = NWNXLibPINVOKE.CLastUpdateObject_m_oidMaster_get(swigCPtr);
      return retVal;
    }

  }

  public ushort m_nAssociateType {
    set {
      NWNXLibPINVOKE.CLastUpdateObject_m_nAssociateType_set(swigCPtr, value);
    } 
    get {
      ushort retVal = NWNXLibPINVOKE.CLastUpdateObject_m_nAssociateType_get(swigCPtr);
      return retVal;
    }

  }

  public int m_bSummonedAnimalCompanion {
    set {
      NWNXLibPINVOKE.CLastUpdateObject_m_bSummonedAnimalCompanion_set(swigCPtr, value);
    } 
    get {
      int retVal = NWNXLibPINVOKE.CLastUpdateObject_m_bSummonedAnimalCompanion_get(swigCPtr);
      return retVal;
    }

  }

  public int m_bSummonedFamiliar {
    set {
      NWNXLibPINVOKE.CLastUpdateObject_m_bSummonedFamiliar_set(swigCPtr, value);
    } 
    get {
      int retVal = NWNXLibPINVOKE.CLastUpdateObject_m_bSummonedFamiliar_get(swigCPtr);
      return retVal;
    }

  }

  public int m_bTakesCommands {
    set {
      NWNXLibPINVOKE.CLastUpdateObject_m_bTakesCommands_set(swigCPtr, value);
    } 
    get {
      int retVal = NWNXLibPINVOKE.CLastUpdateObject_m_bTakesCommands_get(swigCPtr);
      return retVal;
    }

  }

  public int m_bObjectSeen {
    set {
      NWNXLibPINVOKE.CLastUpdateObject_m_bObjectSeen_set(swigCPtr, value);
    } 
    get {
      int retVal = NWNXLibPINVOKE.CLastUpdateObject_m_bObjectSeen_get(swigCPtr);
      return retVal;
    }

  }

  public int m_bObjectHeard {
    set {
      NWNXLibPINVOKE.CLastUpdateObject_m_bObjectHeard_set(swigCPtr, value);
    } 
    get {
      int retVal = NWNXLibPINVOKE.CLastUpdateObject_m_bObjectHeard_get(swigCPtr);
      return retVal;
    }

  }

  public int m_bObjectInvisible {
    set {
      NWNXLibPINVOKE.CLastUpdateObject_m_bObjectInvisible_set(swigCPtr, value);
    } 
    get {
      int retVal = NWNXLibPINVOKE.CLastUpdateObject_m_bObjectInvisible_get(swigCPtr);
      return retVal;
    }

  }

  public ushort m_nRace {
    set {
      NWNXLibPINVOKE.CLastUpdateObject_m_nRace_set(swigCPtr, value);
    } 
    get {
      ushort retVal = NWNXLibPINVOKE.CLastUpdateObject_m_nRace_get(swigCPtr);
      return retVal;
    }

  }

  public CExoString m_sSubRace {
    set {
      NWNXLibPINVOKE.CLastUpdateObject_m_sSubRace_set(swigCPtr, CExoString.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = NWNXLibPINVOKE.CLastUpdateObject_m_sSubRace_get(swigCPtr);
      CExoString ret = (cPtr == global::System.IntPtr.Zero) ? null : new CExoString(cPtr, false);
      return ret;
    } 
  }

  public CExoString m_sDeity {
    set {
      NWNXLibPINVOKE.CLastUpdateObject_m_sDeity_set(swigCPtr, CExoString.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = NWNXLibPINVOKE.CLastUpdateObject_m_sDeity_get(swigCPtr);
      CExoString ret = (cPtr == global::System.IntPtr.Zero) ? null : new CExoString(cPtr, false);
      return ret;
    } 
  }

  public byte m_nGender {
    set {
      NWNXLibPINVOKE.CLastUpdateObject_m_nGender_set(swigCPtr, value);
    } 
    get {
      byte retVal = NWNXLibPINVOKE.CLastUpdateObject_m_nGender_get(swigCPtr);
      return retVal;
    }

  }

  public NativeArray<byte> m_nClass {
    set {
      NWNXLibPINVOKE.CLastUpdateObject_m_nClass_set(swigCPtr, value);
    } 
    get {
      global::System.IntPtr arrayPtr = NWNXLibPINVOKE.CLastUpdateObject_m_nClass_get(swigCPtr);
      NativeArray<byte> retVal = new NativeArray<byte>(arrayPtr, 3);

      return retVal; // byte[3]
    }

  }

  public NativeArray<byte> m_nLevel {
    set {
      NWNXLibPINVOKE.CLastUpdateObject_m_nLevel_set(swigCPtr, value);
    } 
    get {
      global::System.IntPtr arrayPtr = NWNXLibPINVOKE.CLastUpdateObject_m_nLevel_get(swigCPtr);
      NativeArray<byte> retVal = new NativeArray<byte>(arrayPtr, 3);

      return retVal; // byte[3]
    }

  }

  public short m_nAlignmentLawChaos {
    set {
      NWNXLibPINVOKE.CLastUpdateObject_m_nAlignmentLawChaos_set(swigCPtr, value);
    } 
    get {
      short retVal = NWNXLibPINVOKE.CLastUpdateObject_m_nAlignmentLawChaos_get(swigCPtr);
      return retVal;
    }

  }

  public short m_nAlignmentGoodEvil {
    set {
      NWNXLibPINVOKE.CLastUpdateObject_m_nAlignmentGoodEvil_set(swigCPtr, value);
    } 
    get {
      short retVal = NWNXLibPINVOKE.CLastUpdateObject_m_nAlignmentGoodEvil_get(swigCPtr);
      return retVal;
    }

  }

  public int m_bSelectableWhenDead {
    set {
      NWNXLibPINVOKE.CLastUpdateObject_m_bSelectableWhenDead_set(swigCPtr, value);
    } 
    get {
      int retVal = NWNXLibPINVOKE.CLastUpdateObject_m_bSelectableWhenDead_get(swigCPtr);
      return retVal;
    }

  }

  public int m_bLootable {
    set {
      NWNXLibPINVOKE.CLastUpdateObject_m_bLootable_set(swigCPtr, value);
    } 
    get {
      int retVal = NWNXLibPINVOKE.CLastUpdateObject_m_bLootable_get(swigCPtr);
      return retVal;
    }

  }

  public int m_bPC {
    set {
      NWNXLibPINVOKE.CLastUpdateObject_m_bPC_set(swigCPtr, value);
    } 
    get {
      int retVal = NWNXLibPINVOKE.CLastUpdateObject_m_bPC_get(swigCPtr);
      return retVal;
    }

  }

  public byte m_nAbilityBaseSTR {
    set {
      NWNXLibPINVOKE.CLastUpdateObject_m_nAbilityBaseSTR_set(swigCPtr, value);
    } 
    get {
      byte retVal = NWNXLibPINVOKE.CLastUpdateObject_m_nAbilityBaseSTR_get(swigCPtr);
      return retVal;
    }

  }

  public byte m_nAbilityBaseDEX {
    set {
      NWNXLibPINVOKE.CLastUpdateObject_m_nAbilityBaseDEX_set(swigCPtr, value);
    } 
    get {
      byte retVal = NWNXLibPINVOKE.CLastUpdateObject_m_nAbilityBaseDEX_get(swigCPtr);
      return retVal;
    }

  }

  public byte m_nAbilityBaseCON {
    set {
      NWNXLibPINVOKE.CLastUpdateObject_m_nAbilityBaseCON_set(swigCPtr, value);
    } 
    get {
      byte retVal = NWNXLibPINVOKE.CLastUpdateObject_m_nAbilityBaseCON_get(swigCPtr);
      return retVal;
    }

  }

  public byte m_nAbilityBaseINT {
    set {
      NWNXLibPINVOKE.CLastUpdateObject_m_nAbilityBaseINT_set(swigCPtr, value);
    } 
    get {
      byte retVal = NWNXLibPINVOKE.CLastUpdateObject_m_nAbilityBaseINT_get(swigCPtr);
      return retVal;
    }

  }

  public byte m_nAbilityBaseWIS {
    set {
      NWNXLibPINVOKE.CLastUpdateObject_m_nAbilityBaseWIS_set(swigCPtr, value);
    } 
    get {
      byte retVal = NWNXLibPINVOKE.CLastUpdateObject_m_nAbilityBaseWIS_get(swigCPtr);
      return retVal;
    }

  }

  public byte m_nAbilityBaseCHA {
    set {
      NWNXLibPINVOKE.CLastUpdateObject_m_nAbilityBaseCHA_set(swigCPtr, value);
    } 
    get {
      byte retVal = NWNXLibPINVOKE.CLastUpdateObject_m_nAbilityBaseCHA_get(swigCPtr);
      return retVal;
    }

  }

  public byte m_nAbilityFinalSTR {
    set {
      NWNXLibPINVOKE.CLastUpdateObject_m_nAbilityFinalSTR_set(swigCPtr, value);
    } 
    get {
      byte retVal = NWNXLibPINVOKE.CLastUpdateObject_m_nAbilityFinalSTR_get(swigCPtr);
      return retVal;
    }

  }

  public byte m_nAbilityFinalDEX {
    set {
      NWNXLibPINVOKE.CLastUpdateObject_m_nAbilityFinalDEX_set(swigCPtr, value);
    } 
    get {
      byte retVal = NWNXLibPINVOKE.CLastUpdateObject_m_nAbilityFinalDEX_get(swigCPtr);
      return retVal;
    }

  }

  public byte m_nAbilityFinalCON {
    set {
      NWNXLibPINVOKE.CLastUpdateObject_m_nAbilityFinalCON_set(swigCPtr, value);
    } 
    get {
      byte retVal = NWNXLibPINVOKE.CLastUpdateObject_m_nAbilityFinalCON_get(swigCPtr);
      return retVal;
    }

  }

  public byte m_nAbilityFinalINT {
    set {
      NWNXLibPINVOKE.CLastUpdateObject_m_nAbilityFinalINT_set(swigCPtr, value);
    } 
    get {
      byte retVal = NWNXLibPINVOKE.CLastUpdateObject_m_nAbilityFinalINT_get(swigCPtr);
      return retVal;
    }

  }

  public byte m_nAbilityFinalWIS {
    set {
      NWNXLibPINVOKE.CLastUpdateObject_m_nAbilityFinalWIS_set(swigCPtr, value);
    } 
    get {
      byte retVal = NWNXLibPINVOKE.CLastUpdateObject_m_nAbilityFinalWIS_get(swigCPtr);
      return retVal;
    }

  }

  public byte m_nAbilityFinalCHA {
    set {
      NWNXLibPINVOKE.CLastUpdateObject_m_nAbilityFinalCHA_set(swigCPtr, value);
    } 
    get {
      byte retVal = NWNXLibPINVOKE.CLastUpdateObject_m_nAbilityFinalCHA_get(swigCPtr);
      return retVal;
    }

  }

  public ObjectVisualTransformData m_pObjectVisualTransformData {
    set {
      NWNXLibPINVOKE.CLastUpdateObject_m_pObjectVisualTransformData_set(swigCPtr, ObjectVisualTransformData.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = NWNXLibPINVOKE.CLastUpdateObject_m_pObjectVisualTransformData_get(swigCPtr);
      ObjectVisualTransformData ret = (cPtr == global::System.IntPtr.Zero) ? null : new ObjectVisualTransformData(cPtr, false);
      return ret;
    } 
  }

  public CExoArrayListMaterialShaderParam m_lMaterialShaderParameters {
    set {
      NWNXLibPINVOKE.CLastUpdateObject_m_lMaterialShaderParameters_set(swigCPtr, CExoArrayListMaterialShaderParam.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = NWNXLibPINVOKE.CLastUpdateObject_m_lMaterialShaderParameters_get(swigCPtr);
      CExoArrayListMaterialShaderParam ret = (cPtr == global::System.IntPtr.Zero) ? null : new CExoArrayListMaterialShaderParam(cPtr, false);
      return ret;
    } 
  }

  public CExoArrayListTextureReplaceInfo m_lTextureReplaceInfo {
    set {
      NWNXLibPINVOKE.CLastUpdateObject_m_lTextureReplaceInfo_set(swigCPtr, CExoArrayListTextureReplaceInfo.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = NWNXLibPINVOKE.CLastUpdateObject_m_lTextureReplaceInfo_get(swigCPtr);
      CExoArrayListTextureReplaceInfo ret = (cPtr == global::System.IntPtr.Zero) ? null : new CExoArrayListTextureReplaceInfo(cPtr, false);
      return ret;
    } 
  }

  public Vector m_vHiliteColor {
    set {
      NWNXLibPINVOKE.CLastUpdateObject_m_vHiliteColor_set(swigCPtr, Vector.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = NWNXLibPINVOKE.CLastUpdateObject_m_vHiliteColor_get(swigCPtr);
      Vector ret = (cPtr == global::System.IntPtr.Zero) ? null : new Vector(cPtr, false);
      return ret;
    } 
  }

  public int m_nMouseCursor {
    set {
      NWNXLibPINVOKE.CLastUpdateObject_m_nMouseCursor_set(swigCPtr, value);
    } 
    get {
      int retVal = NWNXLibPINVOKE.CLastUpdateObject_m_nMouseCursor_get(swigCPtr);
      return retVal;
    }

  }

  public int m_nUpdateDisplayNameSeq {
    set {
      NWNXLibPINVOKE.CLastUpdateObject_m_nUpdateDisplayNameSeq_set(swigCPtr, value);
    } 
    get {
      int retVal = NWNXLibPINVOKE.CLastUpdateObject_m_nUpdateDisplayNameSeq_get(swigCPtr);
      return retVal;
    }

  }

  public int m_nUpdateHiddenSeq {
    set {
      NWNXLibPINVOKE.CLastUpdateObject_m_nUpdateHiddenSeq_set(swigCPtr, value);
    } 
    get {
      int retVal = NWNXLibPINVOKE.CLastUpdateObject_m_nUpdateHiddenSeq_get(swigCPtr);
      return retVal;
    }

  }

  public CNWSPlayerLUOQuickbarItemButton m_pQuickbarButton {
    set {
      NWNXLibPINVOKE.CLastUpdateObject_m_pQuickbarButton_set(swigCPtr, CNWSPlayerLUOQuickbarItemButton.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = NWNXLibPINVOKE.CLastUpdateObject_m_pQuickbarButton_get(swigCPtr);
      CNWSPlayerLUOQuickbarItemButton ret = (cPtr == global::System.IntPtr.Zero) ? null : new CNWSPlayerLUOQuickbarItemButton(cPtr, false);
      return ret;
    } 
  }

  public CLastUpdateObject() : this(NWNXLibPINVOKE.new_CLastUpdateObject(), true) {
  }

  public void InitializeQuickbar() {
    NWNXLibPINVOKE.CLastUpdateObject_InitializeQuickbar(swigCPtr);
  }

  public void _Destructor() {
    NWNXLibPINVOKE.CLastUpdateObject__Destructor(swigCPtr);
  }

}

}

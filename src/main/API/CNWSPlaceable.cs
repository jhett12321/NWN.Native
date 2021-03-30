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

public unsafe class CNWSPlaceable : CNWSObject {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;

  public CNWSPlaceable(global::System.IntPtr cPtr, bool cMemoryOwn) : base(NWNXLibPINVOKE.CNWSPlaceable_SWIGUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  public CNWSPlaceable(void* cPtr, bool cMemoryOwn) : base(NWNXLibPINVOKE.CNWSPlaceable_SWIGUpcast((global::System.IntPtr)cPtr), cMemoryOwn) {
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, (global::System.IntPtr)cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(CNWSPlaceable obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  protected override void Dispose(bool disposing) {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          NWNXLibPINVOKE.delete_CNWSPlaceable(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      base.Dispose(disposing);
    }
  }

  public global::System.IntPtr Pointer {
    get {
      return swigCPtr.Handle;
    }
  }

  public static unsafe implicit operator void*(CNWSPlaceable self) {
    return (void*)self.swigCPtr.Handle;
  }

  public static implicit operator global::System.IntPtr(CNWSPlaceable self) {
    return self.swigCPtr.Handle;
  }

  public bool Equals(CNWSPlaceable other) {
    if (ReferenceEquals(null, other)) {
      return false;
    }

    if (ReferenceEquals(this, other)) {
      return true;
    }

    return Pointer.Equals(other.Pointer);
  }

  public override bool Equals(object obj) {
    return ReferenceEquals(this, obj) || obj is CNWSPlaceable other && Equals(other);
  }

  public override int GetHashCode() {
    return swigCPtr.Handle.GetHashCode();
  }

  public static bool operator ==(CNWSPlaceable left, CNWSPlaceable right) {
    return Equals(left, right);
  }

  public static bool operator !=(CNWSPlaceable left, CNWSPlaceable right) {
    return !Equals(left, right);
  }

  public CExoLocString m_sLocName {
    set {
      NWNXLibPINVOKE.CNWSPlaceable_m_sLocName_set(swigCPtr, CExoLocString.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = NWNXLibPINVOKE.CNWSPlaceable_m_sLocName_get(swigCPtr);
      CExoLocString ret = (cPtr == global::System.IntPtr.Zero) ? null : new CExoLocString(cPtr, false);
      return ret;
    } 
  }

  public CExoString m_sDisplayName {
    set {
      NWNXLibPINVOKE.CNWSPlaceable_m_sDisplayName_set(swigCPtr, CExoString.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = NWNXLibPINVOKE.CNWSPlaceable_m_sDisplayName_get(swigCPtr);
      CExoString ret = (cPtr == global::System.IntPtr.Zero) ? null : new CExoString(cPtr, false);
      return ret;
    } 
  }

  public int m_nUpdateDisplayNameSeq {
    set {
      NWNXLibPINVOKE.CNWSPlaceable_m_nUpdateDisplayNameSeq_set(swigCPtr, value);
    } 
    get {
      int ret = NWNXLibPINVOKE.CNWSPlaceable_m_nUpdateDisplayNameSeq_get(swigCPtr);
      return ret;
    } 
  }

  public ushort m_nAppearance {
    set {
      NWNXLibPINVOKE.CNWSPlaceable_m_nAppearance_set(swigCPtr, value);
    } 
    get {
      ushort ret = NWNXLibPINVOKE.CNWSPlaceable_m_nAppearance_get(swigCPtr);
      return ret;
    } 
  }

  public CExoLocString m_sDescription {
    set {
      NWNXLibPINVOKE.CNWSPlaceable_m_sDescription_set(swigCPtr, CExoLocString.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = NWNXLibPINVOKE.CNWSPlaceable_m_sDescription_get(swigCPtr);
      CExoLocString ret = (cPtr == global::System.IntPtr.Zero) ? null : new CExoLocString(cPtr, false);
      return ret;
    } 
  }

  public CExoString m_sDescriptionOverride {
    set {
      NWNXLibPINVOKE.CNWSPlaceable_m_sDescriptionOverride_set(swigCPtr, CExoString.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = NWNXLibPINVOKE.CNWSPlaceable_m_sDescriptionOverride_get(swigCPtr);
      CExoString ret = (cPtr == global::System.IntPtr.Zero) ? null : new CExoString(cPtr, false);
      return ret;
    } 
  }

  public int m_nFactionId {
    set {
      NWNXLibPINVOKE.CNWSPlaceable_m_nFactionId_set(swigCPtr, value);
    } 
    get {
      int ret = NWNXLibPINVOKE.CNWSPlaceable_m_nFactionId_get(swigCPtr);
      return ret;
    } 
  }

  public CResRef m_cDialog {
    set {
      NWNXLibPINVOKE.CNWSPlaceable_m_cDialog_set(swigCPtr, CResRef.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = NWNXLibPINVOKE.CNWSPlaceable_m_cDialog_get(swigCPtr);
      CResRef ret = (cPtr == global::System.IntPtr.Zero) ? null : new CResRef(cPtr, false);
      return ret;
    } 
  }

  public byte m_nType {
    set {
      NWNXLibPINVOKE.CNWSPlaceable_m_nType_set(swigCPtr, value);
    } 
    get {
      byte ret = NWNXLibPINVOKE.CNWSPlaceable_m_nType_get(swigCPtr);
      return ret;
    } 
  }

  public int m_bGroundPile {
    set {
      NWNXLibPINVOKE.CNWSPlaceable_m_bGroundPile_set(swigCPtr, value);
    } 
    get {
      int ret = NWNXLibPINVOKE.CNWSPlaceable_m_bGroundPile_get(swigCPtr);
      return ret;
    } 
  }

  public uint m_oidSittingCreature {
    set {
      NWNXLibPINVOKE.CNWSPlaceable_m_oidSittingCreature_set(swigCPtr, value);
    } 
    get {
      uint ret = NWNXLibPINVOKE.CNWSPlaceable_m_oidSittingCreature_get(swigCPtr);
      return ret;
    } 
  }

  public byte m_nHardness {
    set {
      NWNXLibPINVOKE.CNWSPlaceable_m_nHardness_set(swigCPtr, value);
    } 
    get {
      byte ret = NWNXLibPINVOKE.CNWSPlaceable_m_nHardness_get(swigCPtr);
      return ret;
    } 
  }

  public float m_fBearing {
    set {
      NWNXLibPINVOKE.CNWSPlaceable_m_fBearing_set(swigCPtr, value);
    } 
    get {
      float ret = NWNXLibPINVOKE.CNWSPlaceable_m_fBearing_get(swigCPtr);
      return ret;
    } 
  }

  public int m_bLocked {
    set {
      NWNXLibPINVOKE.CNWSPlaceable_m_bLocked_set(swigCPtr, value);
    } 
    get {
      int ret = NWNXLibPINVOKE.CNWSPlaceable_m_bLocked_get(swigCPtr);
      return ret;
    } 
  }

  public CExoString m_sKeyName {
    set {
      NWNXLibPINVOKE.CNWSPlaceable_m_sKeyName_set(swigCPtr, CExoString.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = NWNXLibPINVOKE.CNWSPlaceable_m_sKeyName_get(swigCPtr);
      CExoString ret = (cPtr == global::System.IntPtr.Zero) ? null : new CExoString(cPtr, false);
      return ret;
    } 
  }

  public CExoString m_sKeyRequiredFeedbackMessage {
    set {
      NWNXLibPINVOKE.CNWSPlaceable_m_sKeyRequiredFeedbackMessage_set(swigCPtr, CExoString.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = NWNXLibPINVOKE.CNWSPlaceable_m_sKeyRequiredFeedbackMessage_get(swigCPtr);
      CExoString ret = (cPtr == global::System.IntPtr.Zero) ? null : new CExoString(cPtr, false);
      return ret;
    } 
  }

  public int m_bKeyRequired {
    set {
      NWNXLibPINVOKE.CNWSPlaceable_m_bKeyRequired_set(swigCPtr, value);
    } 
    get {
      int ret = NWNXLibPINVOKE.CNWSPlaceable_m_bKeyRequired_get(swigCPtr);
      return ret;
    } 
  }

  public int m_bAutoRemoveKey {
    set {
      NWNXLibPINVOKE.CNWSPlaceable_m_bAutoRemoveKey_set(swigCPtr, value);
    } 
    get {
      int ret = NWNXLibPINVOKE.CNWSPlaceable_m_bAutoRemoveKey_get(swigCPtr);
      return ret;
    } 
  }

  public byte m_nOpenLockDC {
    set {
      NWNXLibPINVOKE.CNWSPlaceable_m_nOpenLockDC_set(swigCPtr, value);
    } 
    get {
      byte ret = NWNXLibPINVOKE.CNWSPlaceable_m_nOpenLockDC_get(swigCPtr);
      return ret;
    } 
  }

  public byte m_nCloseLockDC {
    set {
      NWNXLibPINVOKE.CNWSPlaceable_m_nCloseLockDC_set(swigCPtr, value);
    } 
    get {
      byte ret = NWNXLibPINVOKE.CNWSPlaceable_m_nCloseLockDC_get(swigCPtr);
      return ret;
    } 
  }

  public uint m_oidTrapCreator {
    set {
      NWNXLibPINVOKE.CNWSPlaceable_m_oidTrapCreator_set(swigCPtr, value);
    } 
    get {
      uint ret = NWNXLibPINVOKE.CNWSPlaceable_m_oidTrapCreator_get(swigCPtr);
      return ret;
    } 
  }

  public byte m_nTrapDetectionDC {
    set {
      NWNXLibPINVOKE.CNWSPlaceable_m_nTrapDetectionDC_set(swigCPtr, value);
    } 
    get {
      byte ret = NWNXLibPINVOKE.CNWSPlaceable_m_nTrapDetectionDC_get(swigCPtr);
      return ret;
    } 
  }

  public int m_bTrapFlag {
    set {
      NWNXLibPINVOKE.CNWSPlaceable_m_bTrapFlag_set(swigCPtr, value);
    } 
    get {
      int ret = NWNXLibPINVOKE.CNWSPlaceable_m_bTrapFlag_get(swigCPtr);
      return ret;
    } 
  }

  public byte m_nDisarmDC {
    set {
      NWNXLibPINVOKE.CNWSPlaceable_m_nDisarmDC_set(swigCPtr, value);
    } 
    get {
      byte ret = NWNXLibPINVOKE.CNWSPlaceable_m_nDisarmDC_get(swigCPtr);
      return ret;
    } 
  }

  public int m_bDisarmable {
    set {
      NWNXLibPINVOKE.CNWSPlaceable_m_bDisarmable_set(swigCPtr, value);
    } 
    get {
      int ret = NWNXLibPINVOKE.CNWSPlaceable_m_bDisarmable_get(swigCPtr);
      return ret;
    } 
  }

  public int m_bDetectable {
    set {
      NWNXLibPINVOKE.CNWSPlaceable_m_bDetectable_set(swigCPtr, value);
    } 
    get {
      int ret = NWNXLibPINVOKE.CNWSPlaceable_m_bDetectable_get(swigCPtr);
      return ret;
    } 
  }

  public int m_bOneShot {
    set {
      NWNXLibPINVOKE.CNWSPlaceable_m_bOneShot_set(swigCPtr, value);
    } 
    get {
      int ret = NWNXLibPINVOKE.CNWSPlaceable_m_bOneShot_get(swigCPtr);
      return ret;
    } 
  }

  public int m_bRecoverable {
    set {
      NWNXLibPINVOKE.CNWSPlaceable_m_bRecoverable_set(swigCPtr, value);
    } 
    get {
      int ret = NWNXLibPINVOKE.CNWSPlaceable_m_bRecoverable_get(swigCPtr);
      return ret;
    } 
  }

  public int m_bFlagged {
    set {
      NWNXLibPINVOKE.CNWSPlaceable_m_bFlagged_set(swigCPtr, value);
    } 
    get {
      int ret = NWNXLibPINVOKE.CNWSPlaceable_m_bFlagged_get(swigCPtr);
      return ret;
    } 
  }

  public byte m_nBaseType {
    set {
      NWNXLibPINVOKE.CNWSPlaceable_m_nBaseType_set(swigCPtr, value);
    } 
    get {
      byte ret = NWNXLibPINVOKE.CNWSPlaceable_m_nBaseType_get(swigCPtr);
      return ret;
    } 
  }

  public int m_bTrapIsActive {
    set {
      NWNXLibPINVOKE.CNWSPlaceable_m_bTrapIsActive_set(swigCPtr, value);
    } 
    get {
      int ret = NWNXLibPINVOKE.CNWSPlaceable_m_bTrapIsActive_get(swigCPtr);
      return ret;
    } 
  }

  public int m_nTrapFaction {
    set {
      NWNXLibPINVOKE.CNWSPlaceable_m_nTrapFaction_set(swigCPtr, value);
    } 
    get {
      int ret = NWNXLibPINVOKE.CNWSPlaceable_m_nTrapFaction_get(swigCPtr);
      return ret;
    } 
  }

  public CExoStringArray m_sScripts {
    set {
      NWNXLibPINVOKE.CNWSPlaceable_m_sScripts_set(swigCPtr, CExoStringArray.getCPtr(value));
    }  
    get {
        global::System.IntPtr cPtr = NWNXLibPINVOKE.CNWSPlaceable_m_sScripts_get(swigCPtr);;
        CExoStringArray ret = (cPtr == global::System.IntPtr.Zero) ? null : new CExoStringArray(cPtr, false);
        return ret;
    }

  }

  public byte m_nFortSave {
    set {
      NWNXLibPINVOKE.CNWSPlaceable_m_nFortSave_set(swigCPtr, value);
    } 
    get {
      byte ret = NWNXLibPINVOKE.CNWSPlaceable_m_nFortSave_get(swigCPtr);
      return ret;
    } 
  }

  public byte m_nWillSave {
    set {
      NWNXLibPINVOKE.CNWSPlaceable_m_nWillSave_set(swigCPtr, value);
    } 
    get {
      byte ret = NWNXLibPINVOKE.CNWSPlaceable_m_nWillSave_get(swigCPtr);
      return ret;
    } 
  }

  public byte m_nReflexSave {
    set {
      NWNXLibPINVOKE.CNWSPlaceable_m_nReflexSave_set(swigCPtr, value);
    } 
    get {
      byte ret = NWNXLibPINVOKE.CNWSPlaceable_m_nReflexSave_get(swigCPtr);
      return ret;
    } 
  }

  public CExoArrayListObjectId m_poidCreatures {
    set {
      NWNXLibPINVOKE.CNWSPlaceable_m_poidCreatures_set(swigCPtr, CExoArrayListObjectId.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = NWNXLibPINVOKE.CNWSPlaceable_m_poidCreatures_get(swigCPtr);
      CExoArrayListObjectId ret = (cPtr == global::System.IntPtr.Zero) ? null : new CExoArrayListObjectId(cPtr, false);
      return ret;
    } 
  }

  public int m_bHasInventory {
    set {
      NWNXLibPINVOKE.CNWSPlaceable_m_bHasInventory_set(swigCPtr, value);
    } 
    get {
      int ret = NWNXLibPINVOKE.CNWSPlaceable_m_bHasInventory_get(swigCPtr);
      return ret;
    } 
  }

  public int m_bUseable {
    set {
      NWNXLibPINVOKE.CNWSPlaceable_m_bUseable_set(swigCPtr, value);
    } 
    get {
      int ret = NWNXLibPINVOKE.CNWSPlaceable_m_bUseable_get(swigCPtr);
      return ret;
    } 
  }

  public int m_bPickable {
    set {
      NWNXLibPINVOKE.CNWSPlaceable_m_bPickable_set(swigCPtr, value);
    } 
    get {
      int ret = NWNXLibPINVOKE.CNWSPlaceable_m_bPickable_get(swigCPtr);
      return ret;
    } 
  }

  public int m_bLockable {
    set {
      NWNXLibPINVOKE.CNWSPlaceable_m_bLockable_set(swigCPtr, value);
    } 
    get {
      int ret = NWNXLibPINVOKE.CNWSPlaceable_m_bLockable_get(swigCPtr);
      return ret;
    } 
  }

  public int m_bDieWhenEmpty {
    set {
      NWNXLibPINVOKE.CNWSPlaceable_m_bDieWhenEmpty_set(swigCPtr, value);
    } 
    get {
      int ret = NWNXLibPINVOKE.CNWSPlaceable_m_bDieWhenEmpty_get(swigCPtr);
      return ret;
    } 
  }

  public uint m_nOpenCount {
    set {
      NWNXLibPINVOKE.CNWSPlaceable_m_nOpenCount_set(swigCPtr, value);
    } 
    get {
      uint ret = NWNXLibPINVOKE.CNWSPlaceable_m_nOpenCount_get(swigCPtr);
      return ret;
    } 
  }

  public int m_nStaticObjectPosition {
    set {
      NWNXLibPINVOKE.CNWSPlaceable_m_nStaticObjectPosition_set(swigCPtr, value);
    } 
    get {
      int ret = NWNXLibPINVOKE.CNWSPlaceable_m_nStaticObjectPosition_get(swigCPtr);
      return ret;
    } 
  }

  public uint m_oidLootCreature {
    set {
      NWNXLibPINVOKE.CNWSPlaceable_m_oidLootCreature_set(swigCPtr, value);
    } 
    get {
      uint ret = NWNXLibPINVOKE.CNWSPlaceable_m_oidLootCreature_get(swigCPtr);
      return ret;
    } 
  }

  public int m_bIsBodyBag {
    set {
      NWNXLibPINVOKE.CNWSPlaceable_m_bIsBodyBag_set(swigCPtr, value);
    } 
    get {
      int ret = NWNXLibPINVOKE.CNWSPlaceable_m_bIsBodyBag_get(swigCPtr);
      return ret;
    } 
  }

  public uint m_nLastHeartbeatScriptCalendarDay {
    set {
      NWNXLibPINVOKE.CNWSPlaceable_m_nLastHeartbeatScriptCalendarDay_set(swigCPtr, value);
    } 
    get {
      uint ret = NWNXLibPINVOKE.CNWSPlaceable_m_nLastHeartbeatScriptCalendarDay_get(swigCPtr);
      return ret;
    } 
  }

  public uint m_nLastHeartbeatScriptTimeOfDay {
    set {
      NWNXLibPINVOKE.CNWSPlaceable_m_nLastHeartbeatScriptTimeOfDay_set(swigCPtr, value);
    } 
    get {
      uint ret = NWNXLibPINVOKE.CNWSPlaceable_m_nLastHeartbeatScriptTimeOfDay_get(swigCPtr);
      return ret;
    } 
  }

  public uint m_oidLastOpened {
    set {
      NWNXLibPINVOKE.CNWSPlaceable_m_oidLastOpened_set(swigCPtr, value);
    } 
    get {
      uint ret = NWNXLibPINVOKE.CNWSPlaceable_m_oidLastOpened_get(swigCPtr);
      return ret;
    } 
  }

  public uint m_oidLastClosed {
    set {
      NWNXLibPINVOKE.CNWSPlaceable_m_oidLastClosed_set(swigCPtr, value);
    } 
    get {
      uint ret = NWNXLibPINVOKE.CNWSPlaceable_m_oidLastClosed_get(swigCPtr);
      return ret;
    } 
  }

  public uint m_oidLastUser {
    set {
      NWNXLibPINVOKE.CNWSPlaceable_m_oidLastUser_set(swigCPtr, value);
    } 
    get {
      uint ret = NWNXLibPINVOKE.CNWSPlaceable_m_oidLastUser_get(swigCPtr);
      return ret;
    } 
  }

  public uint m_oidLastDefaultClickedBy {
    set {
      NWNXLibPINVOKE.CNWSPlaceable_m_oidLastDefaultClickedBy_set(swigCPtr, value);
    } 
    get {
      uint ret = NWNXLibPINVOKE.CNWSPlaceable_m_oidLastDefaultClickedBy_get(swigCPtr);
      return ret;
    } 
  }

  public uint m_oidLastTriggered {
    set {
      NWNXLibPINVOKE.CNWSPlaceable_m_oidLastTriggered_set(swigCPtr, value);
    } 
    get {
      uint ret = NWNXLibPINVOKE.CNWSPlaceable_m_oidLastTriggered_get(swigCPtr);
      return ret;
    } 
  }

  public uint m_oidLastDisarmed {
    set {
      NWNXLibPINVOKE.CNWSPlaceable_m_oidLastDisarmed_set(swigCPtr, value);
    } 
    get {
      uint ret = NWNXLibPINVOKE.CNWSPlaceable_m_oidLastDisarmed_get(swigCPtr);
      return ret;
    } 
  }

  public uint m_oidLastLocked {
    set {
      NWNXLibPINVOKE.CNWSPlaceable_m_oidLastLocked_set(swigCPtr, value);
    } 
    get {
      uint ret = NWNXLibPINVOKE.CNWSPlaceable_m_oidLastLocked_get(swigCPtr);
      return ret;
    } 
  }

  public uint m_oidLastUnlocked {
    set {
      NWNXLibPINVOKE.CNWSPlaceable_m_oidLastUnlocked_set(swigCPtr, value);
    } 
    get {
      uint ret = NWNXLibPINVOKE.CNWSPlaceable_m_oidLastUnlocked_get(swigCPtr);
      return ret;
    } 
  }

  public CItemRepository m_pcItemRepository {
    set {
      NWNXLibPINVOKE.CNWSPlaceable_m_pcItemRepository_set(swigCPtr, CItemRepository.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = NWNXLibPINVOKE.CNWSPlaceable_m_pcItemRepository_get(swigCPtr);
      CItemRepository ret = (cPtr == global::System.IntPtr.Zero) ? null : new CItemRepository(cPtr, false);
      return ret;
    } 
  }

  public ushort m_nRepositoryArrayIndex {
    set {
      NWNXLibPINVOKE.CNWSPlaceable_m_nRepositoryArrayIndex_set(swigCPtr, value);
    } 
    get {
      ushort ret = NWNXLibPINVOKE.CNWSPlaceable_m_nRepositoryArrayIndex_get(swigCPtr);
      return ret;
    } 
  }

  public ushort m_nItemContainerArrayIndex {
    set {
      NWNXLibPINVOKE.CNWSPlaceable_m_nItemContainerArrayIndex_set(swigCPtr, value);
    } 
    get {
      ushort ret = NWNXLibPINVOKE.CNWSPlaceable_m_nItemContainerArrayIndex_get(swigCPtr);
      return ret;
    } 
  }

  public uint m_oidCurrentItemContainer {
    set {
      NWNXLibPINVOKE.CNWSPlaceable_m_oidCurrentItemContainer_set(swigCPtr, value);
    } 
    get {
      uint ret = NWNXLibPINVOKE.CNWSPlaceable_m_oidCurrentItemContainer_get(swigCPtr);
      return ret;
    } 
  }

  public VectorArray m_pvActionPoints {
    set {
      NWNXLibPINVOKE.CNWSPlaceable_m_pvActionPoints_set(swigCPtr, VectorArray.getCPtr(value));
    }  
    get {
        global::System.IntPtr cPtr = NWNXLibPINVOKE.CNWSPlaceable_m_pvActionPoints_get(swigCPtr);;
        VectorArray ret = (cPtr == global::System.IntPtr.Zero) ? null : new VectorArray(cPtr, false);
        return ret;
    }

  }

  public CResRef m_cTemplateResRef {
    set {
      NWNXLibPINVOKE.CNWSPlaceable_m_cTemplateResRef_set(swigCPtr, CResRef.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = NWNXLibPINVOKE.CNWSPlaceable_m_cTemplateResRef_get(swigCPtr);
      CResRef ret = (cPtr == global::System.IntPtr.Zero) ? null : new CResRef(cPtr, false);
      return ret;
    } 
  }

  public CExoString m_szPortalInfo {
    set {
      NWNXLibPINVOKE.CNWSPlaceable_m_szPortalInfo_set(swigCPtr, CExoString.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = NWNXLibPINVOKE.CNWSPlaceable_m_szPortalInfo_get(swigCPtr);
      CExoString ret = (cPtr == global::System.IntPtr.Zero) ? null : new CExoString(cPtr, false);
      return ret;
    } 
  }

  public uint m_nEffectSpellId {
    set {
      NWNXLibPINVOKE.CNWSPlaceable_m_nEffectSpellId_set(swigCPtr, value);
    } 
    get {
      uint ret = NWNXLibPINVOKE.CNWSPlaceable_m_nEffectSpellId_get(swigCPtr);
      return ret;
    } 
  }

  public int m_bLightIsOn {
    set {
      NWNXLibPINVOKE.CNWSPlaceable_m_bLightIsOn_set(swigCPtr, value);
    } 
    get {
      int ret = NWNXLibPINVOKE.CNWSPlaceable_m_bLightIsOn_get(swigCPtr);
      return ret;
    } 
  }

  public int m_bLightStateChange {
    set {
      NWNXLibPINVOKE.CNWSPlaceable_m_bLightStateChange_set(swigCPtr, value);
    } 
    get {
      int ret = NWNXLibPINVOKE.CNWSPlaceable_m_bLightStateChange_get(swigCPtr);
      return ret;
    } 
  }

  public byte m_nBodyBag {
    set {
      NWNXLibPINVOKE.CNWSPlaceable_m_nBodyBag_set(swigCPtr, value);
    } 
    get {
      byte ret = NWNXLibPINVOKE.CNWSPlaceable_m_nBodyBag_get(swigCPtr);
      return ret;
    } 
  }

  public int m_bStaticObject {
    set {
      NWNXLibPINVOKE.CNWSPlaceable_m_bStaticObject_set(swigCPtr, value);
    } 
    get {
      int ret = NWNXLibPINVOKE.CNWSPlaceable_m_bStaticObject_get(swigCPtr);
      return ret;
    } 
  }

  public int m_bNeverMakeIntoStaticObject {
    set {
      NWNXLibPINVOKE.CNWSPlaceable_m_bNeverMakeIntoStaticObject_set(swigCPtr, value);
    } 
    get {
      int ret = NWNXLibPINVOKE.CNWSPlaceable_m_bNeverMakeIntoStaticObject_get(swigCPtr);
      return ret;
    } 
  }

  public override CNWSPlaceable AsNWSPlaceable() {
    global::System.IntPtr cPtr = NWNXLibPINVOKE.CNWSPlaceable_AsNWSPlaceable(swigCPtr);
    CNWSPlaceable ret = (cPtr == global::System.IntPtr.Zero) ? null : new CNWSPlaceable(cPtr, false);
    return ret;
  }

  public CNWSPlaceable(uint oidId) : this(NWNXLibPINVOKE.new_CNWSPlaceable__SWIG_0(oidId), true) {
  }

  public CNWSPlaceable() : this(NWNXLibPINVOKE.new_CNWSPlaceable__SWIG_1(), true) {
  }

  public void AddToArea(CNWSArea pArea, float fX, float fY, float fZ, int bRunScripts) {
    NWNXLibPINVOKE.CNWSPlaceable_AddToArea__SWIG_0(swigCPtr, CNWSArea.getCPtr(pArea), fX, fY, fZ, bRunScripts);
  }

  public void AddToArea(CNWSArea pArea, float fX, float fY, float fZ) {
    NWNXLibPINVOKE.CNWSPlaceable_AddToArea__SWIG_1(swigCPtr, CNWSArea.getCPtr(pArea), fX, fY, fZ);
  }

  public void RemoveFromArea() {
    NWNXLibPINVOKE.CNWSPlaceable_RemoveFromArea(swigCPtr);
  }

  public new void SetOrientation(Vector vOrientation) {
    NWNXLibPINVOKE.CNWSPlaceable_SetOrientation(swigCPtr, Vector.getCPtr(vOrientation));
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
  }

  public override void AIUpdate() {
    NWNXLibPINVOKE.CNWSPlaceable_AIUpdate(swigCPtr);
  }

  public override void DoDamage(int nDamage) {
    NWNXLibPINVOKE.CNWSPlaceable_DoDamage(swigCPtr, nDamage);
  }

  public override void EventHandler(uint nEventId, uint nCallerObjectId, void* pScript, uint nCalendarDay, uint nTimeOfDay) {
    NWNXLibPINVOKE.CNWSPlaceable_EventHandler(swigCPtr, nEventId, nCallerObjectId, (global::System.IntPtr)pScript, nCalendarDay, nTimeOfDay);
  }

  public int LoadPlaceable(CResGFF pRes, CResStruct cPlaceableStruct, CExoString pTag) {
    int ret = NWNXLibPINVOKE.CNWSPlaceable_LoadPlaceable__SWIG_0(swigCPtr, CResGFF.getCPtr(pRes), CResStruct.getCPtr(cPlaceableStruct), CExoString.getCPtr(pTag));
    return ret;
  }

  public int LoadPlaceable(CResGFF pRes, CResStruct cPlaceableStruct) {
    int ret = NWNXLibPINVOKE.CNWSPlaceable_LoadPlaceable__SWIG_1(swigCPtr, CResGFF.getCPtr(pRes), CResStruct.getCPtr(cPlaceableStruct));
    return ret;
  }

  public int LoadFromTemplate(CResRef cResRef, CExoString pTag) {
    int ret = NWNXLibPINVOKE.CNWSPlaceable_LoadFromTemplate__SWIG_0(swigCPtr, CResRef.getCPtr(cResRef), CExoString.getCPtr(pTag));
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public int LoadFromTemplate(CResRef cResRef) {
    int ret = NWNXLibPINVOKE.CNWSPlaceable_LoadFromTemplate__SWIG_1(swigCPtr, CResRef.getCPtr(cResRef));
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public int LoadBodyBag(ushort nAppearance) {
    int ret = NWNXLibPINVOKE.CNWSPlaceable_LoadBodyBag(swigCPtr, nAppearance);
    return ret;
  }

  public int SavePlaceable(CResGFF pRes, CResStruct pStruct, int bSaveOIDs) {
    int ret = NWNXLibPINVOKE.CNWSPlaceable_SavePlaceable(swigCPtr, CResGFF.getCPtr(pRes), CResStruct.getCPtr(pStruct), bSaveOIDs);
    return ret;
  }

  public void PostProcess() {
    NWNXLibPINVOKE.CNWSPlaceable_PostProcess(swigCPtr);
  }

  public int AcquireItem(void** pItem, uint oidPossessor, byte x, byte y, int bDisplayFeedback) {
    int ret = NWNXLibPINVOKE.CNWSPlaceable_AcquireItem__SWIG_0(swigCPtr, (global::System.IntPtr)pItem, oidPossessor, x, y, bDisplayFeedback);
    return ret;
  }

  public int AcquireItem(void** pItem, uint oidPossessor, byte x, byte y) {
    int ret = NWNXLibPINVOKE.CNWSPlaceable_AcquireItem__SWIG_1(swigCPtr, (global::System.IntPtr)pItem, oidPossessor, x, y);
    return ret;
  }

  public int AcquireItem(void** pItem, uint oidPossessor, byte x) {
    int ret = NWNXLibPINVOKE.CNWSPlaceable_AcquireItem__SWIG_2(swigCPtr, (global::System.IntPtr)pItem, oidPossessor, x);
    return ret;
  }

  public int AcquireItem(void** pItem, uint oidPossessor) {
    int ret = NWNXLibPINVOKE.CNWSPlaceable_AcquireItem__SWIG_3(swigCPtr, (global::System.IntPtr)pItem, oidPossessor);
    return ret;
  }

  public int AcquireItem(void** pItem) {
    int ret = NWNXLibPINVOKE.CNWSPlaceable_AcquireItem__SWIG_4(swigCPtr, (global::System.IntPtr)pItem);
    return ret;
  }

  public int RemoveItem(CNWSItem pItem, int bSetPossessor) {
    int ret = NWNXLibPINVOKE.CNWSPlaceable_RemoveItem__SWIG_0(swigCPtr, CNWSItem.getCPtr(pItem), bSetPossessor);
    return ret;
  }

  public int RemoveItem(CNWSItem pItem) {
    int ret = NWNXLibPINVOKE.CNWSPlaceable_RemoveItem__SWIG_1(swigCPtr, CNWSItem.getCPtr(pItem));
    return ret;
  }

  public uint AcquireItemsFromObject(uint oidObject, int bAcquireDroppablesOnly) {
    uint ret = NWNXLibPINVOKE.CNWSPlaceable_AcquireItemsFromObject__SWIG_0(swigCPtr, oidObject, bAcquireDroppablesOnly);
    return ret;
  }

  public uint AcquireItemsFromObject(uint oidObject) {
    uint ret = NWNXLibPINVOKE.CNWSPlaceable_AcquireItemsFromObject__SWIG_1(swigCPtr, oidObject);
    return ret;
  }

  public void OpenInventory(uint oidOpener) {
    NWNXLibPINVOKE.CNWSPlaceable_OpenInventory(swigCPtr, oidOpener);
  }

  public void CloseInventory(uint oidCloser, int bUpdatePlayer) {
    NWNXLibPINVOKE.CNWSPlaceable_CloseInventory__SWIG_0(swigCPtr, oidCloser, bUpdatePlayer);
  }

  public void CloseInventory(uint oidCloser) {
    NWNXLibPINVOKE.CNWSPlaceable_CloseInventory__SWIG_1(swigCPtr, oidCloser);
  }

  public void DropItemsIntoArea() {
    NWNXLibPINVOKE.CNWSPlaceable_DropItemsIntoArea(swigCPtr);
  }

  public Vector GetNearestActionPoint(Vector vPosition) {
    Vector ret = new Vector(NWNXLibPINVOKE.CNWSPlaceable_GetNearestActionPoint(swigCPtr, Vector.getCPtr(vPosition)), true);
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public int AddCastSpellActions(uint nSpellId, int nMetaType, Vector vTargetLocation, uint oidTarget, int bFake, byte nProjectilePathType) {
    int ret = NWNXLibPINVOKE.CNWSPlaceable_AddCastSpellActions__SWIG_0(swigCPtr, nSpellId, nMetaType, Vector.getCPtr(vTargetLocation), oidTarget, bFake, nProjectilePathType);
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public int AddCastSpellActions(uint nSpellId, int nMetaType, Vector vTargetLocation, uint oidTarget, int bFake) {
    int ret = NWNXLibPINVOKE.CNWSPlaceable_AddCastSpellActions__SWIG_1(swigCPtr, nSpellId, nMetaType, Vector.getCPtr(vTargetLocation), oidTarget, bFake);
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public int AddCastSpellActions(uint nSpellId, int nMetaType, Vector vTargetLocation, uint oidTarget) {
    int ret = NWNXLibPINVOKE.CNWSPlaceable_AddCastSpellActions__SWIG_2(swigCPtr, nSpellId, nMetaType, Vector.getCPtr(vTargetLocation), oidTarget);
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public uint AIActionCastSpell(CNWSObjectActionNode pNode) {
    uint ret = NWNXLibPINVOKE.CNWSPlaceable_AIActionCastSpell(swigCPtr, CNWSObjectActionNode.getCPtr(pNode));
    return ret;
  }

  public int GetLightIsOn() {
    int ret = NWNXLibPINVOKE.CNWSPlaceable_GetLightIsOn(swigCPtr);
    return ret;
  }

  public void SetLightIsOn(int b) {
    NWNXLibPINVOKE.CNWSPlaceable_SetLightIsOn(swigCPtr, b);
  }

  public ushort GetBodyBagAppearance() {
    ushort ret = NWNXLibPINVOKE.CNWSPlaceable_GetBodyBagAppearance(swigCPtr);
    return ret;
  }

  public uint GetItemCount(int bDroppableOnly) {
    uint ret = NWNXLibPINVOKE.CNWSPlaceable_GetItemCount__SWIG_0(swigCPtr, bDroppableOnly);
    return ret;
  }

  public uint GetItemCount() {
    uint ret = NWNXLibPINVOKE.CNWSPlaceable_GetItemCount__SWIG_1(swigCPtr);
    return ret;
  }

  public void ClosePlaceableForAllPlayers() {
    NWNXLibPINVOKE.CNWSPlaceable_ClosePlaceableForAllPlayers(swigCPtr);
  }

  public void CalculateActionPoints() {
    NWNXLibPINVOKE.CNWSPlaceable_CalculateActionPoints(swigCPtr);
  }

}

}

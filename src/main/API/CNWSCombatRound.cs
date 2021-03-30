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

public unsafe class CNWSCombatRound : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  public CNWSCombatRound(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  public CNWSCombatRound(void* cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, (global::System.IntPtr)cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(CNWSCombatRound obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~CNWSCombatRound() {
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
          NWNXLibPINVOKE.delete_CNWSCombatRound(swigCPtr);
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

  public static unsafe implicit operator void*(CNWSCombatRound self) {
    return (void*)self.swigCPtr.Handle;
  }

  public static implicit operator global::System.IntPtr(CNWSCombatRound self) {
    return self.swigCPtr.Handle;
  }

  public bool Equals(CNWSCombatRound other) {
    if (ReferenceEquals(null, other)) {
      return false;
    }

    if (ReferenceEquals(this, other)) {
      return true;
    }

    return Pointer.Equals(other.Pointer);
  }

  public override bool Equals(object obj) {
    return ReferenceEquals(this, obj) || obj is CNWSCombatRound other && Equals(other);
  }

  public override int GetHashCode() {
    return swigCPtr.Handle.GetHashCode();
  }

  public static bool operator ==(CNWSCombatRound left, CNWSCombatRound right) {
    return Equals(left, right);
  }

  public static bool operator !=(CNWSCombatRound left, CNWSCombatRound right) {
    return !Equals(left, right);
  }

  public CNWSCombatAttackDataArray m_pcLastAttack {
    set {
      NWNXLibPINVOKE.CNWSCombatRound_m_pcLastAttack_set(swigCPtr, CNWSCombatAttackDataArray.getCPtr(value));
    }  
    get {
        global::System.IntPtr cPtr = NWNXLibPINVOKE.CNWSCombatRound_m_pcLastAttack_get(swigCPtr);;
        CNWSCombatAttackDataArray ret = (cPtr == global::System.IntPtr.Zero) ? null : new CNWSCombatAttackDataArray(cPtr, false);
        return ret;
    }

  }

  public CExoArrayListUInt16 m_nSpecialAttacks {
    set {
      NWNXLibPINVOKE.CNWSCombatRound_m_nSpecialAttacks_set(swigCPtr, CExoArrayListUInt16.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = NWNXLibPINVOKE.CNWSCombatRound_m_nSpecialAttacks_get(swigCPtr);
      CExoArrayListUInt16 ret = (cPtr == global::System.IntPtr.Zero) ? null : new CExoArrayListUInt16(cPtr, false);
      return ret;
    } 
  }

  public CExoArrayListUInt16 m_nSpecialAttackIDs {
    set {
      NWNXLibPINVOKE.CNWSCombatRound_m_nSpecialAttackIDs_set(swigCPtr, CExoArrayListUInt16.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = NWNXLibPINVOKE.CNWSCombatRound_m_nSpecialAttackIDs_get(swigCPtr);
      CExoArrayListUInt16 ret = (cPtr == global::System.IntPtr.Zero) ? null : new CExoArrayListUInt16(cPtr, false);
      return ret;
    } 
  }

  public ushort m_nAttackID {
    set {
      NWNXLibPINVOKE.CNWSCombatRound_m_nAttackID_set(swigCPtr, value);
    } 
    get {
      ushort ret = NWNXLibPINVOKE.CNWSCombatRound_m_nAttackID_get(swigCPtr);
      return ret;
    } 
  }

  public int m_bRoundStarted {
    set {
      NWNXLibPINVOKE.CNWSCombatRound_m_bRoundStarted_set(swigCPtr, value);
    } 
    get {
      int ret = NWNXLibPINVOKE.CNWSCombatRound_m_bRoundStarted_get(swigCPtr);
      return ret;
    } 
  }

  public int m_bSpellCastRound {
    set {
      NWNXLibPINVOKE.CNWSCombatRound_m_bSpellCastRound_set(swigCPtr, value);
    } 
    get {
      int ret = NWNXLibPINVOKE.CNWSCombatRound_m_bSpellCastRound_get(swigCPtr);
      return ret;
    } 
  }

  public int m_nTimer {
    set {
      NWNXLibPINVOKE.CNWSCombatRound_m_nTimer_set(swigCPtr, value);
    } 
    get {
      int ret = NWNXLibPINVOKE.CNWSCombatRound_m_nTimer_get(swigCPtr);
      return ret;
    } 
  }

  public int m_nRoundLength {
    set {
      NWNXLibPINVOKE.CNWSCombatRound_m_nRoundLength_set(swigCPtr, value);
    } 
    get {
      int ret = NWNXLibPINVOKE.CNWSCombatRound_m_nRoundLength_get(swigCPtr);
      return ret;
    } 
  }

  public int m_nOverlapAmount {
    set {
      NWNXLibPINVOKE.CNWSCombatRound_m_nOverlapAmount_set(swigCPtr, value);
    } 
    get {
      int ret = NWNXLibPINVOKE.CNWSCombatRound_m_nOverlapAmount_get(swigCPtr);
      return ret;
    } 
  }

  public int m_nBleedAmount {
    set {
      NWNXLibPINVOKE.CNWSCombatRound_m_nBleedAmount_set(swigCPtr, value);
    } 
    get {
      int ret = NWNXLibPINVOKE.CNWSCombatRound_m_nBleedAmount_get(swigCPtr);
      return ret;
    } 
  }

  public int m_bRoundPaused {
    set {
      NWNXLibPINVOKE.CNWSCombatRound_m_bRoundPaused_set(swigCPtr, value);
    } 
    get {
      int ret = NWNXLibPINVOKE.CNWSCombatRound_m_bRoundPaused_get(swigCPtr);
      return ret;
    } 
  }

  public uint m_oidRoundPausedBy {
    set {
      NWNXLibPINVOKE.CNWSCombatRound_m_oidRoundPausedBy_set(swigCPtr, value);
    } 
    get {
      uint ret = NWNXLibPINVOKE.CNWSCombatRound_m_oidRoundPausedBy_get(swigCPtr);
      return ret;
    } 
  }

  public int m_nPauseTimer {
    set {
      NWNXLibPINVOKE.CNWSCombatRound_m_nPauseTimer_set(swigCPtr, value);
    } 
    get {
      int ret = NWNXLibPINVOKE.CNWSCombatRound_m_nPauseTimer_get(swigCPtr);
      return ret;
    } 
  }

  public int m_bInfinitePause {
    set {
      NWNXLibPINVOKE.CNWSCombatRound_m_bInfinitePause_set(swigCPtr, value);
    } 
    get {
      int ret = NWNXLibPINVOKE.CNWSCombatRound_m_bInfinitePause_get(swigCPtr);
      return ret;
    } 
  }

  public byte m_nCurrentAttack {
    set {
      NWNXLibPINVOKE.CNWSCombatRound_m_nCurrentAttack_set(swigCPtr, value);
    } 
    get {
      byte ret = NWNXLibPINVOKE.CNWSCombatRound_m_nCurrentAttack_get(swigCPtr);
      return ret;
    } 
  }

  public byte m_nAttackGroup {
    set {
      NWNXLibPINVOKE.CNWSCombatRound_m_nAttackGroup_set(swigCPtr, value);
    } 
    get {
      byte ret = NWNXLibPINVOKE.CNWSCombatRound_m_nAttackGroup_get(swigCPtr);
      return ret;
    } 
  }

  public int m_bDeflectArrow {
    set {
      NWNXLibPINVOKE.CNWSCombatRound_m_bDeflectArrow_set(swigCPtr, value);
    } 
    get {
      int ret = NWNXLibPINVOKE.CNWSCombatRound_m_bDeflectArrow_get(swigCPtr);
      return ret;
    } 
  }

  public int m_bWeaponSucks {
    set {
      NWNXLibPINVOKE.CNWSCombatRound_m_bWeaponSucks_set(swigCPtr, value);
    } 
    get {
      int ret = NWNXLibPINVOKE.CNWSCombatRound_m_bWeaponSucks_get(swigCPtr);
      return ret;
    } 
  }

  public int m_bEpicDodgeUsed {
    set {
      NWNXLibPINVOKE.CNWSCombatRound_m_bEpicDodgeUsed_set(swigCPtr, value);
    } 
    get {
      int ret = NWNXLibPINVOKE.CNWSCombatRound_m_bEpicDodgeUsed_get(swigCPtr);
      return ret;
    } 
  }

  public int m_nParryIndex {
    set {
      NWNXLibPINVOKE.CNWSCombatRound_m_nParryIndex_set(swigCPtr, value);
    } 
    get {
      int ret = NWNXLibPINVOKE.CNWSCombatRound_m_nParryIndex_get(swigCPtr);
      return ret;
    } 
  }

  public int m_nAttacksOfOpportunity {
    set {
      NWNXLibPINVOKE.CNWSCombatRound_m_nAttacksOfOpportunity_set(swigCPtr, value);
    } 
    get {
      int ret = NWNXLibPINVOKE.CNWSCombatRound_m_nAttacksOfOpportunity_get(swigCPtr);
      return ret;
    } 
  }

  public int m_nCleaveAttacks {
    set {
      NWNXLibPINVOKE.CNWSCombatRound_m_nCleaveAttacks_set(swigCPtr, value);
    } 
    get {
      int ret = NWNXLibPINVOKE.CNWSCombatRound_m_nCleaveAttacks_get(swigCPtr);
      return ret;
    } 
  }

  public int m_nCircleKickAttacks {
    set {
      NWNXLibPINVOKE.CNWSCombatRound_m_nCircleKickAttacks_set(swigCPtr, value);
    } 
    get {
      int ret = NWNXLibPINVOKE.CNWSCombatRound_m_nCircleKickAttacks_get(swigCPtr);
      return ret;
    } 
  }

  public uint m_oidNewAttackTarget {
    set {
      NWNXLibPINVOKE.CNWSCombatRound_m_oidNewAttackTarget_set(swigCPtr, value);
    } 
    get {
      uint ret = NWNXLibPINVOKE.CNWSCombatRound_m_oidNewAttackTarget_get(swigCPtr);
      return ret;
    } 
  }

  public int m_nOnHandAttacks {
    set {
      NWNXLibPINVOKE.CNWSCombatRound_m_nOnHandAttacks_set(swigCPtr, value);
    } 
    get {
      int ret = NWNXLibPINVOKE.CNWSCombatRound_m_nOnHandAttacks_get(swigCPtr);
      return ret;
    } 
  }

  public int m_nOffHandAttacks {
    set {
      NWNXLibPINVOKE.CNWSCombatRound_m_nOffHandAttacks_set(swigCPtr, value);
    } 
    get {
      int ret = NWNXLibPINVOKE.CNWSCombatRound_m_nOffHandAttacks_get(swigCPtr);
      return ret;
    } 
  }

  public int m_nOffHandAttacksTaken {
    set {
      NWNXLibPINVOKE.CNWSCombatRound_m_nOffHandAttacksTaken_set(swigCPtr, value);
    } 
    get {
      int ret = NWNXLibPINVOKE.CNWSCombatRound_m_nOffHandAttacksTaken_get(swigCPtr);
      return ret;
    } 
  }

  public int m_nExtraAttacksTaken {
    set {
      NWNXLibPINVOKE.CNWSCombatRound_m_nExtraAttacksTaken_set(swigCPtr, value);
    } 
    get {
      int ret = NWNXLibPINVOKE.CNWSCombatRound_m_nExtraAttacksTaken_get(swigCPtr);
      return ret;
    } 
  }

  public int m_nAdditionalAttacks {
    set {
      NWNXLibPINVOKE.CNWSCombatRound_m_nAdditionalAttacks_set(swigCPtr, value);
    } 
    get {
      int ret = NWNXLibPINVOKE.CNWSCombatRound_m_nAdditionalAttacks_get(swigCPtr);
      return ret;
    } 
  }

  public int m_nBonusEffectAttacks {
    set {
      NWNXLibPINVOKE.CNWSCombatRound_m_nBonusEffectAttacks_set(swigCPtr, value);
    } 
    get {
      int ret = NWNXLibPINVOKE.CNWSCombatRound_m_nBonusEffectAttacks_get(swigCPtr);
      return ret;
    } 
  }

  public byte m_nParryActions {
    set {
      NWNXLibPINVOKE.CNWSCombatRound_m_nParryActions_set(swigCPtr, value);
    } 
    get {
      byte ret = NWNXLibPINVOKE.CNWSCombatRound_m_nParryActions_get(swigCPtr);
      return ret;
    } 
  }

  public uint m_oidDodgeTarget {
    set {
      NWNXLibPINVOKE.CNWSCombatRound_m_oidDodgeTarget_set(swigCPtr, value);
    } 
    get {
      uint ret = NWNXLibPINVOKE.CNWSCombatRound_m_oidDodgeTarget_get(swigCPtr);
      return ret;
    } 
  }

  public CExoLinkedListCNWSCombatRoundAction m_pScheduledActions {
    set {
      NWNXLibPINVOKE.CNWSCombatRound_m_pScheduledActions_set(swigCPtr, CExoLinkedListCNWSCombatRoundAction.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = NWNXLibPINVOKE.CNWSCombatRound_m_pScheduledActions_get(swigCPtr);
      CExoLinkedListCNWSCombatRoundAction ret = (cPtr == global::System.IntPtr.Zero) ? null : new CExoLinkedListCNWSCombatRoundAction(cPtr, false);
      return ret;
    } 
  }

  public CNWSCreature m_pBaseCreature {
    set {
      NWNXLibPINVOKE.CNWSCombatRound_m_pBaseCreature_set(swigCPtr, CNWSCreature.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = NWNXLibPINVOKE.CNWSCombatRound_m_pBaseCreature_get(swigCPtr);
      CNWSCreature ret = (cPtr == global::System.IntPtr.Zero) ? null : new CNWSCreature(cPtr, false);
      return ret;
    } 
  }

  public CNWSCombatRound(CNWSCreature pCreature) : this(NWNXLibPINVOKE.new_CNWSCombatRound(CNWSCreature.getCPtr(pCreature)), true) {
  }

  public void StartCombatRound(uint oidTarget) {
    NWNXLibPINVOKE.CNWSCombatRound_StartCombatRound(swigCPtr, oidTarget);
  }

  public void StartCombatRoundCast(uint nRoundLength) {
    NWNXLibPINVOKE.CNWSCombatRound_StartCombatRoundCast__SWIG_0(swigCPtr, nRoundLength);
  }

  public void StartCombatRoundCast() {
    NWNXLibPINVOKE.CNWSCombatRound_StartCombatRoundCast__SWIG_1(swigCPtr);
  }

  public void EndCombatRound() {
    NWNXLibPINVOKE.CNWSCombatRound_EndCombatRound(swigCPtr);
  }

  public void RecomputeRound() {
    NWNXLibPINVOKE.CNWSCombatRound_RecomputeRound(swigCPtr);
  }

  public void IncrementTimer(int nTimeDelta) {
    NWNXLibPINVOKE.CNWSCombatRound_IncrementTimer(swigCPtr, nTimeDelta);
  }

  public void DecrementPauseTimer(int nTimeDelta) {
    NWNXLibPINVOKE.CNWSCombatRound_DecrementPauseTimer(swigCPtr, nTimeDelta);
  }

  public void SetRoundPaused(int bValue, uint oidPausedBy) {
    NWNXLibPINVOKE.CNWSCombatRound_SetRoundPaused__SWIG_0(swigCPtr, bValue, oidPausedBy);
  }

  public void SetRoundPaused(int bValue) {
    NWNXLibPINVOKE.CNWSCombatRound_SetRoundPaused__SWIG_1(swigCPtr, bValue);
  }

  public void SetPauseTimer(int nValue, int bInfinite) {
    NWNXLibPINVOKE.CNWSCombatRound_SetPauseTimer__SWIG_0(swigCPtr, nValue, bInfinite);
  }

  public void SetPauseTimer(int nValue) {
    NWNXLibPINVOKE.CNWSCombatRound_SetPauseTimer__SWIG_1(swigCPtr, nValue);
  }

  public void DecrementRoundLength(int nValue, int bBleed) {
    NWNXLibPINVOKE.CNWSCombatRound_DecrementRoundLength__SWIG_0(swigCPtr, nValue, bBleed);
  }

  public void DecrementRoundLength(int nValue) {
    NWNXLibPINVOKE.CNWSCombatRound_DecrementRoundLength__SWIG_1(swigCPtr, nValue);
  }

  public CNWSCombatAttackData GetAttack(int nAttack) {
    global::System.IntPtr cPtr = NWNXLibPINVOKE.CNWSCombatRound_GetAttack(swigCPtr, nAttack);
    CNWSCombatAttackData ret = (cPtr == global::System.IntPtr.Zero) ? null : new CNWSCombatAttackData(cPtr, false);
    return ret;
  }

  public void ClearAllAttacks() {
    NWNXLibPINVOKE.CNWSCombatRound_ClearAllAttacks(swigCPtr);
  }

  public void SignalCombatRoundStarted() {
    NWNXLibPINVOKE.CNWSCombatRound_SignalCombatRoundStarted(swigCPtr);
  }

  public int CheckActionLength(uint oidPauser, int nActionLength) {
    int ret = NWNXLibPINVOKE.CNWSCombatRound_CheckActionLength(swigCPtr, oidPauser, nActionLength);
    return ret;
  }

  public int CheckActionLengthAtTime(uint oidPauser, int nActionLength, int nTimeIndex) {
    int ret = NWNXLibPINVOKE.CNWSCombatRound_CheckActionLengthAtTime(swigCPtr, oidPauser, nActionLength, nTimeIndex);
    return ret;
  }

  public int GetActionPending() {
    int ret = NWNXLibPINVOKE.CNWSCombatRound_GetActionPending(swigCPtr);
    return ret;
  }

  public int GetAttackActionPending() {
    int ret = NWNXLibPINVOKE.CNWSCombatRound_GetAttackActionPending(swigCPtr);
    return ret;
  }

  public int GetSpellActionPending() {
    int ret = NWNXLibPINVOKE.CNWSCombatRound_GetSpellActionPending(swigCPtr);
    return ret;
  }

  public CNWSCombatRoundAction GetAction() {
    global::System.IntPtr cPtr = NWNXLibPINVOKE.CNWSCombatRound_GetAction(swigCPtr);
    CNWSCombatRoundAction ret = (cPtr == global::System.IntPtr.Zero) ? null : new CNWSCombatRoundAction(cPtr, false);
    return ret;
  }

  public void AddAction(CNWSCombatRoundAction pAction) {
    NWNXLibPINVOKE.CNWSCombatRound_AddAction(swigCPtr, CNWSCombatRoundAction.getCPtr(pAction));
  }

  public void RemoveAllActions() {
    NWNXLibPINVOKE.CNWSCombatRound_RemoveAllActions(swigCPtr);
  }

  public void AddReaction(int nTimeIndex, int nTimeAnimation) {
    NWNXLibPINVOKE.CNWSCombatRound_AddReaction(swigCPtr, nTimeIndex, nTimeAnimation);
  }

  public void AddSpellAction() {
    NWNXLibPINVOKE.CNWSCombatRound_AddSpellAction(swigCPtr);
  }

  public void RemoveSpellAction() {
    NWNXLibPINVOKE.CNWSCombatRound_RemoveSpellAction(swigCPtr);
  }

  public void AddParryAttack(uint oidTarget) {
    NWNXLibPINVOKE.CNWSCombatRound_AddParryAttack(swigCPtr, oidTarget);
  }

  public void AddParryIndex() {
    NWNXLibPINVOKE.CNWSCombatRound_AddParryIndex(swigCPtr);
  }

  public void AddCleaveAttack(uint oidTarget, int bGreatCleave) {
    NWNXLibPINVOKE.CNWSCombatRound_AddCleaveAttack__SWIG_0(swigCPtr, oidTarget, bGreatCleave);
  }

  public void AddCleaveAttack(uint oidTarget) {
    NWNXLibPINVOKE.CNWSCombatRound_AddCleaveAttack__SWIG_1(swigCPtr, oidTarget);
  }

  public void AddCircleKickAttack(uint oidTarget) {
    NWNXLibPINVOKE.CNWSCombatRound_AddCircleKickAttack(swigCPtr, oidTarget);
  }

  public void AddAttackOfOpportunity(uint oidTarget) {
    NWNXLibPINVOKE.CNWSCombatRound_AddAttackOfOpportunity(swigCPtr, oidTarget);
  }

  public void AddWhirlwindAttack(uint oidTarget, int bImproved) {
    NWNXLibPINVOKE.CNWSCombatRound_AddWhirlwindAttack(swigCPtr, oidTarget, bImproved);
  }

  public void AddEquipAction(uint oidItem, uint nInventorySlot) {
    NWNXLibPINVOKE.CNWSCombatRound_AddEquipAction(swigCPtr, oidItem, nInventorySlot);
  }

  public void AddUnequipAction(uint oidItem, uint oidTargetRepository, byte x, byte y) {
    NWNXLibPINVOKE.CNWSCombatRound_AddUnequipAction(swigCPtr, oidItem, oidTargetRepository, x, y);
  }

  public void AddCombatStepAction(uint nTimeIndex, uint oidTarget) {
    NWNXLibPINVOKE.CNWSCombatRound_AddCombatStepAction(swigCPtr, nTimeIndex, oidTarget);
  }

  public void InitializeAttackActions(uint oidTarget) {
    NWNXLibPINVOKE.CNWSCombatRound_InitializeAttackActions(swigCPtr, oidTarget);
  }

  public void InitializeNumberOfAttacks() {
    NWNXLibPINVOKE.CNWSCombatRound_InitializeNumberOfAttacks(swigCPtr);
  }

  public void InitializeCombatModes() {
    NWNXLibPINVOKE.CNWSCombatRound_InitializeCombatModes(swigCPtr);
  }

  public int CalculateOffHandAttacks() {
    int ret = NWNXLibPINVOKE.CNWSCombatRound_CalculateOffHandAttacks(swigCPtr);
    return ret;
  }

  public int GetCombatStepRequired(uint oidTarget) {
    int ret = NWNXLibPINVOKE.CNWSCombatRound_GetCombatStepRequired(swigCPtr, oidTarget);
    return ret;
  }

  public byte GetTotalAttacks() {
    byte ret = NWNXLibPINVOKE.CNWSCombatRound_GetTotalAttacks(swigCPtr);
    return ret;
  }

  public void SetDeflectArrow(int bValue) {
    NWNXLibPINVOKE.CNWSCombatRound_SetDeflectArrow(swigCPtr, bValue);
  }

  public void SetCurrentAttack(byte nCurrentAttack) {
    NWNXLibPINVOKE.CNWSCombatRound_SetCurrentAttack(swigCPtr, nCurrentAttack);
  }

  public int GetOffHandAttack() {
    int ret = NWNXLibPINVOKE.CNWSCombatRound_GetOffHandAttack(swigCPtr);
    return ret;
  }

  public int GetExtraAttack() {
    int ret = NWNXLibPINVOKE.CNWSCombatRound_GetExtraAttack(swigCPtr);
    return ret;
  }

  public int HasCreatureWeapons() {
    int ret = NWNXLibPINVOKE.CNWSCombatRound_HasCreatureWeapons(swigCPtr);
    return ret;
  }

  public int GetWeaponAttackType() {
    int ret = NWNXLibPINVOKE.CNWSCombatRound_GetWeaponAttackType(swigCPtr);
    return ret;
  }

  public CNWSItem GetCurrentAttackWeapon(int nWeaponAttackType) {
    global::System.IntPtr cPtr = NWNXLibPINVOKE.CNWSCombatRound_GetCurrentAttackWeapon__SWIG_0(swigCPtr, nWeaponAttackType);
    CNWSItem ret = (cPtr == global::System.IntPtr.Zero) ? null : new CNWSItem(cPtr, false);
    return ret;
  }

  public CNWSItem GetCurrentAttackWeapon() {
    global::System.IntPtr cPtr = NWNXLibPINVOKE.CNWSCombatRound_GetCurrentAttackWeapon__SWIG_1(swigCPtr);
    CNWSItem ret = (cPtr == global::System.IntPtr.Zero) ? null : new CNWSItem(cPtr, false);
    return ret;
  }

  public void UpdateAttackTargetForAllActions(uint oidNewTarget) {
    NWNXLibPINVOKE.CNWSCombatRound_UpdateAttackTargetForAllActions(swigCPtr, oidNewTarget);
  }

  public void InsertSpecialAttack(ushort nSpecialAttack, int nIndex) {
    NWNXLibPINVOKE.CNWSCombatRound_InsertSpecialAttack(swigCPtr, nSpecialAttack, nIndex);
  }

  public void AddSpecialAttack(ushort nSpecialAttack) {
    NWNXLibPINVOKE.CNWSCombatRound_AddSpecialAttack(swigCPtr, nSpecialAttack);
  }

  public void RemoveSpecialAttack(int nIndex) {
    NWNXLibPINVOKE.CNWSCombatRound_RemoveSpecialAttack(swigCPtr, nIndex);
  }

  public int GetNumSpecialAttacks() {
    int ret = NWNXLibPINVOKE.CNWSCombatRound_GetNumSpecialAttacks(swigCPtr);
    return ret;
  }

  public ushort GetSpecialAttack(int nIndex) {
    ushort ret = NWNXLibPINVOKE.CNWSCombatRound_GetSpecialAttack(swigCPtr, nIndex);
    return ret;
  }

  public ushort GetSpecialAttackID(int nIndex) {
    ushort ret = NWNXLibPINVOKE.CNWSCombatRound_GetSpecialAttackID(swigCPtr, nIndex);
    return ret;
  }

  public ushort GetNewAttackID() {
    ushort ret = NWNXLibPINVOKE.CNWSCombatRound_GetNewAttackID(swigCPtr);
    return ret;
  }

  public void ClearAllSpecialAttacks() {
    NWNXLibPINVOKE.CNWSCombatRound_ClearAllSpecialAttacks(swigCPtr);
  }

  public int SaveCombatRound(CResGFF pRes, CResStruct pStruct) {
    int ret = NWNXLibPINVOKE.CNWSCombatRound_SaveCombatRound(swigCPtr, CResGFF.getCPtr(pRes), CResStruct.getCPtr(pStruct));
    return ret;
  }

  public int LoadCombatRound(CResGFF pRes, CResStruct pStruct) {
    int ret = NWNXLibPINVOKE.CNWSCombatRound_LoadCombatRound(swigCPtr, CResGFF.getCPtr(pRes), CResStruct.getCPtr(pStruct));
    return ret;
  }

}

}

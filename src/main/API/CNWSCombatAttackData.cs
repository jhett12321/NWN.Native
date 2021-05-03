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

public unsafe class CNWSCombatAttackData : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  public CNWSCombatAttackData(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  public CNWSCombatAttackData(void* cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, (global::System.IntPtr)cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(CNWSCombatAttackData obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~CNWSCombatAttackData() {
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
          NWNXLibPINVOKE.delete_CNWSCombatAttackData(swigCPtr);
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

  public static unsafe implicit operator void*(CNWSCombatAttackData self) {
    return (void*)self.swigCPtr.Handle;
  }

  public static implicit operator global::System.IntPtr(CNWSCombatAttackData self) {
    return self.swigCPtr.Handle;
  }

  public bool Equals(CNWSCombatAttackData other) {
    if (ReferenceEquals(null, other)) {
      return false;
    }

    if (ReferenceEquals(this, other)) {
      return true;
    }

    return Pointer.Equals(other.Pointer);
  }

  public override bool Equals(object obj) {
    return ReferenceEquals(this, obj) || obj is CNWSCombatAttackData other && Equals(other);
  }

  public override int GetHashCode() {
    return swigCPtr.Handle.GetHashCode();
  }

  public static bool operator ==(CNWSCombatAttackData left, CNWSCombatAttackData right) {
    return Equals(left, right);
  }

  public static bool operator !=(CNWSCombatAttackData left, CNWSCombatAttackData right) {
    return !Equals(left, right);
  }

  public byte m_nAttackGroup {
    set {
      NWNXLibPINVOKE.CNWSCombatAttackData_m_nAttackGroup_set(swigCPtr, value);
    } 
    get {
      byte ret = NWNXLibPINVOKE.CNWSCombatAttackData_m_nAttackGroup_get(swigCPtr);
      return ret;
    } 
  }

  public ushort m_nAnimationLength {
    set {
      NWNXLibPINVOKE.CNWSCombatAttackData_m_nAnimationLength_set(swigCPtr, value);
    } 
    get {
      ushort ret = NWNXLibPINVOKE.CNWSCombatAttackData_m_nAnimationLength_get(swigCPtr);
      return ret;
    } 
  }

  public uint m_oidReactObject {
    set {
      NWNXLibPINVOKE.CNWSCombatAttackData_m_oidReactObject_set(swigCPtr, value);
    } 
    get {
      uint ret = NWNXLibPINVOKE.CNWSCombatAttackData_m_oidReactObject_get(swigCPtr);
      return ret;
    } 
  }

  public ushort m_nReactionDelay {
    set {
      NWNXLibPINVOKE.CNWSCombatAttackData_m_nReactionDelay_set(swigCPtr, value);
    } 
    get {
      ushort ret = NWNXLibPINVOKE.CNWSCombatAttackData_m_nReactionDelay_get(swigCPtr);
      return ret;
    } 
  }

  public ushort m_nReactionAnimation {
    set {
      NWNXLibPINVOKE.CNWSCombatAttackData_m_nReactionAnimation_set(swigCPtr, value);
    } 
    get {
      ushort ret = NWNXLibPINVOKE.CNWSCombatAttackData_m_nReactionAnimation_get(swigCPtr);
      return ret;
    } 
  }

  public ushort m_nReactionAnimationLength {
    set {
      NWNXLibPINVOKE.CNWSCombatAttackData_m_nReactionAnimationLength_set(swigCPtr, value);
    } 
    get {
      ushort ret = NWNXLibPINVOKE.CNWSCombatAttackData_m_nReactionAnimationLength_get(swigCPtr);
      return ret;
    } 
  }

  public byte m_nToHitRoll {
    set {
      NWNXLibPINVOKE.CNWSCombatAttackData_m_nToHitRoll_set(swigCPtr, value);
    } 
    get {
      byte ret = NWNXLibPINVOKE.CNWSCombatAttackData_m_nToHitRoll_get(swigCPtr);
      return ret;
    } 
  }

  public byte m_nThreatRoll {
    set {
      NWNXLibPINVOKE.CNWSCombatAttackData_m_nThreatRoll_set(swigCPtr, value);
    } 
    get {
      byte ret = NWNXLibPINVOKE.CNWSCombatAttackData_m_nThreatRoll_get(swigCPtr);
      return ret;
    } 
  }

  public int m_nToHitMod {
    set {
      NWNXLibPINVOKE.CNWSCombatAttackData_m_nToHitMod_set(swigCPtr, value);
    } 
    get {
      int ret = NWNXLibPINVOKE.CNWSCombatAttackData_m_nToHitMod_get(swigCPtr);
      return ret;
    } 
  }

  public char m_nMissedBy {
    set {
      NWNXLibPINVOKE.CNWSCombatAttackData_m_nMissedBy_set(swigCPtr, value);
    } 
    get {
      char ret = NWNXLibPINVOKE.CNWSCombatAttackData_m_nMissedBy_get(swigCPtr);
      return ret;
    } 
  }

  public NativeArray<short> m_nDamage {
    set {
      NWNXLibPINVOKE.CNWSCombatAttackData_m_nDamage_set(swigCPtr, value);
    } 
    get {
      global::System.IntPtr arrayPtr = NWNXLibPINVOKE.CNWSCombatAttackData_m_nDamage_get(swigCPtr);
      NativeArray<short> retVal = new NativeArray<short>(arrayPtr, 13);

      return retVal; // short[13]
    }

  }

  public byte m_nWeaponAttackType {
    set {
      NWNXLibPINVOKE.CNWSCombatAttackData_m_nWeaponAttackType_set(swigCPtr, value);
    } 
    get {
      byte ret = NWNXLibPINVOKE.CNWSCombatAttackData_m_nWeaponAttackType_get(swigCPtr);
      return ret;
    } 
  }

  public byte m_nAttackMode {
    set {
      NWNXLibPINVOKE.CNWSCombatAttackData_m_nAttackMode_set(swigCPtr, value);
    } 
    get {
      byte ret = NWNXLibPINVOKE.CNWSCombatAttackData_m_nAttackMode_get(swigCPtr);
      return ret;
    } 
  }

  public byte m_nConcealment {
    set {
      NWNXLibPINVOKE.CNWSCombatAttackData_m_nConcealment_set(swigCPtr, value);
    } 
    get {
      byte ret = NWNXLibPINVOKE.CNWSCombatAttackData_m_nConcealment_get(swigCPtr);
      return ret;
    } 
  }

  public int m_bRangedAttack {
    set {
      NWNXLibPINVOKE.CNWSCombatAttackData_m_bRangedAttack_set(swigCPtr, value);
    } 
    get {
      int ret = NWNXLibPINVOKE.CNWSCombatAttackData_m_bRangedAttack_get(swigCPtr);
      return ret;
    } 
  }

  public int m_bSneakAttack {
    set {
      NWNXLibPINVOKE.CNWSCombatAttackData_m_bSneakAttack_set(swigCPtr, value);
    } 
    get {
      int ret = NWNXLibPINVOKE.CNWSCombatAttackData_m_bSneakAttack_get(swigCPtr);
      return ret;
    } 
  }

  public int m_bDeathAttack {
    set {
      NWNXLibPINVOKE.CNWSCombatAttackData_m_bDeathAttack_set(swigCPtr, value);
    } 
    get {
      int ret = NWNXLibPINVOKE.CNWSCombatAttackData_m_bDeathAttack_get(swigCPtr);
      return ret;
    } 
  }

  public int m_bKillingBlow {
    set {
      NWNXLibPINVOKE.CNWSCombatAttackData_m_bKillingBlow_set(swigCPtr, value);
    } 
    get {
      int ret = NWNXLibPINVOKE.CNWSCombatAttackData_m_bKillingBlow_get(swigCPtr);
      return ret;
    } 
  }

  public int m_bCoupDeGrace {
    set {
      NWNXLibPINVOKE.CNWSCombatAttackData_m_bCoupDeGrace_set(swigCPtr, value);
    } 
    get {
      int ret = NWNXLibPINVOKE.CNWSCombatAttackData_m_bCoupDeGrace_get(swigCPtr);
      return ret;
    } 
  }

  public int m_bCriticalThreat {
    set {
      NWNXLibPINVOKE.CNWSCombatAttackData_m_bCriticalThreat_set(swigCPtr, value);
    } 
    get {
      int ret = NWNXLibPINVOKE.CNWSCombatAttackData_m_bCriticalThreat_get(swigCPtr);
      return ret;
    } 
  }

  public int m_bAttackDeflected {
    set {
      NWNXLibPINVOKE.CNWSCombatAttackData_m_bAttackDeflected_set(swigCPtr, value);
    } 
    get {
      int ret = NWNXLibPINVOKE.CNWSCombatAttackData_m_bAttackDeflected_get(swigCPtr);
      return ret;
    } 
  }

  public byte m_nAttackResult {
    set {
      NWNXLibPINVOKE.CNWSCombatAttackData_m_nAttackResult_set(swigCPtr, value);
    } 
    get {
      byte ret = NWNXLibPINVOKE.CNWSCombatAttackData_m_nAttackResult_get(swigCPtr);
      return ret;
    } 
  }

  public ushort m_nAttackType {
    set {
      NWNXLibPINVOKE.CNWSCombatAttackData_m_nAttackType_set(swigCPtr, value);
    } 
    get {
      ushort ret = NWNXLibPINVOKE.CNWSCombatAttackData_m_nAttackType_get(swigCPtr);
      return ret;
    } 
  }

  public ushort m_nSpecialAttackID {
    set {
      NWNXLibPINVOKE.CNWSCombatAttackData_m_nSpecialAttackID_set(swigCPtr, value);
    } 
    get {
      ushort ret = NWNXLibPINVOKE.CNWSCombatAttackData_m_nSpecialAttackID_get(swigCPtr);
      return ret;
    } 
  }

  public Vector m_vRangedTarget {
    set {
      NWNXLibPINVOKE.CNWSCombatAttackData_m_vRangedTarget_set(swigCPtr, Vector.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = NWNXLibPINVOKE.CNWSCombatAttackData_m_vRangedTarget_get(swigCPtr);
      Vector ret = (cPtr == global::System.IntPtr.Zero) ? null : new Vector(cPtr, false);
      return ret;
    } 
  }

  public uint m_oidAmmunition {
    set {
      NWNXLibPINVOKE.CNWSCombatAttackData_m_oidAmmunition_set(swigCPtr, value);
    } 
    get {
      uint ret = NWNXLibPINVOKE.CNWSCombatAttackData_m_oidAmmunition_get(swigCPtr);
      return ret;
    } 
  }

  public CExoString m_sAttackDebugText {
    set {
      NWNXLibPINVOKE.CNWSCombatAttackData_m_sAttackDebugText_set(swigCPtr, CExoString.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = NWNXLibPINVOKE.CNWSCombatAttackData_m_sAttackDebugText_get(swigCPtr);
      CExoString ret = (cPtr == global::System.IntPtr.Zero) ? null : new CExoString(cPtr, false);
      return ret;
    } 
  }

  public CExoString m_sDamageDebugText {
    set {
      NWNXLibPINVOKE.CNWSCombatAttackData_m_sDamageDebugText_set(swigCPtr, CExoString.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = NWNXLibPINVOKE.CNWSCombatAttackData_m_sDamageDebugText_get(swigCPtr);
      CExoString ret = (cPtr == global::System.IntPtr.Zero) ? null : new CExoString(cPtr, false);
      return ret;
    } 
  }

  public CExoArrayListCGameEffectPtr m_alstOnHitGameEffects {
    set {
      NWNXLibPINVOKE.CNWSCombatAttackData_m_alstOnHitGameEffects_set(swigCPtr, CExoArrayListCGameEffectPtr.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = NWNXLibPINVOKE.CNWSCombatAttackData_m_alstOnHitGameEffects_get(swigCPtr);
      CExoArrayListCGameEffectPtr ret = (cPtr == global::System.IntPtr.Zero) ? null : new CExoArrayListCGameEffectPtr(cPtr, false);
      return ret;
    } 
  }

  public CExoArrayListCNWSSpellScriptDataPtr m_alstOnHitSpellScripts {
    set {
      NWNXLibPINVOKE.CNWSCombatAttackData_m_alstOnHitSpellScripts_set(swigCPtr, CExoArrayListCNWSSpellScriptDataPtr.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = NWNXLibPINVOKE.CNWSCombatAttackData_m_alstOnHitSpellScripts_get(swigCPtr);
      CExoArrayListCNWSSpellScriptDataPtr ret = (cPtr == global::System.IntPtr.Zero) ? null : new CExoArrayListCNWSSpellScriptDataPtr(cPtr, false);
      return ret;
    } 
  }

  public CExoArrayListCNWSSpellScriptDataPtr m_alstOnHitEnemySpellScripts {
    set {
      NWNXLibPINVOKE.CNWSCombatAttackData_m_alstOnHitEnemySpellScripts_set(swigCPtr, CExoArrayListCNWSSpellScriptDataPtr.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = NWNXLibPINVOKE.CNWSCombatAttackData_m_alstOnHitEnemySpellScripts_get(swigCPtr);
      CExoArrayListCNWSSpellScriptDataPtr ret = (cPtr == global::System.IntPtr.Zero) ? null : new CExoArrayListCNWSSpellScriptDataPtr(cPtr, false);
      return ret;
    } 
  }

  public CExoArrayListCNWCCMessageDataPtr m_alstPendingFeedback {
    set {
      NWNXLibPINVOKE.CNWSCombatAttackData_m_alstPendingFeedback_set(swigCPtr, CExoArrayListCNWCCMessageDataPtr.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = NWNXLibPINVOKE.CNWSCombatAttackData_m_alstPendingFeedback_get(swigCPtr);
      CExoArrayListCNWCCMessageDataPtr ret = (cPtr == global::System.IntPtr.Zero) ? null : new CExoArrayListCNWCCMessageDataPtr(cPtr, false);
      return ret;
    } 
  }

  public CNWSCombatAttackData() : this(NWNXLibPINVOKE.new_CNWSCombatAttackData(), true) {
  }

  public void ClearAttackData() {
    NWNXLibPINVOKE.CNWSCombatAttackData_ClearAttackData(swigCPtr);
  }

  public void Copy(CNWSCombatAttackData pData, int bCopyDebugInfo) {
    NWNXLibPINVOKE.CNWSCombatAttackData_Copy__SWIG_0(swigCPtr, CNWSCombatAttackData.getCPtr(pData), bCopyDebugInfo);
  }

  public void Copy(CNWSCombatAttackData pData) {
    NWNXLibPINVOKE.CNWSCombatAttackData_Copy__SWIG_1(swigCPtr, CNWSCombatAttackData.getCPtr(pData));
  }

  public void SetBaseDamage(int nDamage) {
    NWNXLibPINVOKE.CNWSCombatAttackData_SetBaseDamage(swigCPtr, nDamage);
  }

  public void SetDamage(ushort nDamageType, int nDamage) {
    NWNXLibPINVOKE.CNWSCombatAttackData_SetDamage(swigCPtr, nDamageType, nDamage);
  }

  public void AddDamage(ushort nDamageType, int nDamage) {
    NWNXLibPINVOKE.CNWSCombatAttackData_AddDamage(swigCPtr, nDamageType, nDamage);
  }

  public int GetDamage(ushort nDamageType) {
    int ret = NWNXLibPINVOKE.CNWSCombatAttackData_GetDamage(swigCPtr, nDamageType);
    return ret;
  }

  public int GetTotalDamage(int bBaseDamage) {
    int ret = NWNXLibPINVOKE.CNWSCombatAttackData_GetTotalDamage__SWIG_0(swigCPtr, bBaseDamage);
    return ret;
  }

  public int GetTotalDamage() {
    int ret = NWNXLibPINVOKE.CNWSCombatAttackData_GetTotalDamage__SWIG_1(swigCPtr);
    return ret;
  }

  public int SaveData(CResGFF pRes, CResStruct pStruct) {
    int ret = NWNXLibPINVOKE.CNWSCombatAttackData_SaveData(swigCPtr, CResGFF.getCPtr(pRes), CResStruct.getCPtr(pStruct));
    return ret;
  }

  public int LoadData(CResGFF pRes, CResStruct pStruct) {
    int ret = NWNXLibPINVOKE.CNWSCombatAttackData_LoadData(swigCPtr, CResGFF.getCPtr(pRes), CResStruct.getCPtr(pStruct));
    return ret;
  }

}

}

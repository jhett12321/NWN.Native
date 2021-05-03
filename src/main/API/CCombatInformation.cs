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

public unsafe class CCombatInformation : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  public CCombatInformation(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  public CCombatInformation(void* cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, (global::System.IntPtr)cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(CCombatInformation obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~CCombatInformation() {
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
          NWNXLibPINVOKE.delete_CCombatInformation(swigCPtr);
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

  public static unsafe implicit operator void*(CCombatInformation self) {
    return (void*)self.swigCPtr.Handle;
  }

  public static implicit operator global::System.IntPtr(CCombatInformation self) {
    return self.swigCPtr.Handle;
  }

  public bool Equals(CCombatInformation other) {
    if (ReferenceEquals(null, other)) {
      return false;
    }

    if (ReferenceEquals(this, other)) {
      return true;
    }

    return Pointer.Equals(other.Pointer);
  }

  public override bool Equals(object obj) {
    return ReferenceEquals(this, obj) || obj is CCombatInformation other && Equals(other);
  }

  public override int GetHashCode() {
    return swigCPtr.Handle.GetHashCode();
  }

  public static bool operator ==(CCombatInformation left, CCombatInformation right) {
    return Equals(left, right);
  }

  public static bool operator !=(CCombatInformation left, CCombatInformation right) {
    return !Equals(left, right);
  }

  public byte m_nNumAttacks {
    set {
      NWNXLibPINVOKE.CCombatInformation_m_nNumAttacks_set(swigCPtr, value);
    } 
    get {
      byte ret = NWNXLibPINVOKE.CCombatInformation_m_nNumAttacks_get(swigCPtr);
      return ret;
    } 
  }

  public char m_nOnHandAttackModifier {
    set {
      NWNXLibPINVOKE.CCombatInformation_m_nOnHandAttackModifier_set(swigCPtr, value);
    } 
    get {
      char ret = NWNXLibPINVOKE.CCombatInformation_m_nOnHandAttackModifier_get(swigCPtr);
      return ret;
    } 
  }

  public char m_nOnHandDamageModifier {
    set {
      NWNXLibPINVOKE.CCombatInformation_m_nOnHandDamageModifier_set(swigCPtr, value);
    } 
    get {
      char ret = NWNXLibPINVOKE.CCombatInformation_m_nOnHandDamageModifier_get(swigCPtr);
      return ret;
    } 
  }

  public char m_nOffHandAttackModifier {
    set {
      NWNXLibPINVOKE.CCombatInformation_m_nOffHandAttackModifier_set(swigCPtr, value);
    } 
    get {
      char ret = NWNXLibPINVOKE.CCombatInformation_m_nOffHandAttackModifier_get(swigCPtr);
      return ret;
    } 
  }

  public char m_nOffHandDamageModifier {
    set {
      NWNXLibPINVOKE.CCombatInformation_m_nOffHandDamageModifier_set(swigCPtr, value);
    } 
    get {
      char ret = NWNXLibPINVOKE.CCombatInformation_m_nOffHandDamageModifier_get(swigCPtr);
      return ret;
    } 
  }

  public byte m_nSpellResistance {
    set {
      NWNXLibPINVOKE.CCombatInformation_m_nSpellResistance_set(swigCPtr, value);
    } 
    get {
      byte ret = NWNXLibPINVOKE.CCombatInformation_m_nSpellResistance_get(swigCPtr);
      return ret;
    } 
  }

  public byte m_nArcaneSpellFailure {
    set {
      NWNXLibPINVOKE.CCombatInformation_m_nArcaneSpellFailure_set(swigCPtr, value);
    } 
    get {
      byte ret = NWNXLibPINVOKE.CCombatInformation_m_nArcaneSpellFailure_get(swigCPtr);
      return ret;
    } 
  }

  public byte m_nArmorCheckPenalty {
    set {
      NWNXLibPINVOKE.CCombatInformation_m_nArmorCheckPenalty_set(swigCPtr, value);
    } 
    get {
      byte ret = NWNXLibPINVOKE.CCombatInformation_m_nArmorCheckPenalty_get(swigCPtr);
      return ret;
    } 
  }

  public byte m_nUnarmedDamageDice {
    set {
      NWNXLibPINVOKE.CCombatInformation_m_nUnarmedDamageDice_set(swigCPtr, value);
    } 
    get {
      byte ret = NWNXLibPINVOKE.CCombatInformation_m_nUnarmedDamageDice_get(swigCPtr);
      return ret;
    } 
  }

  public byte m_nUnarmedDamageDie {
    set {
      NWNXLibPINVOKE.CCombatInformation_m_nUnarmedDamageDie_set(swigCPtr, value);
    } 
    get {
      byte ret = NWNXLibPINVOKE.CCombatInformation_m_nUnarmedDamageDie_get(swigCPtr);
      return ret;
    } 
  }

  public NativeArray<byte> m_nCreatureDamageDice {
    set {
      NWNXLibPINVOKE.CCombatInformation_m_nCreatureDamageDice_set(swigCPtr, value);
    } 
    get {
      global::System.IntPtr arrayPtr = NWNXLibPINVOKE.CCombatInformation_m_nCreatureDamageDice_get(swigCPtr);
      NativeArray<byte> retVal = new NativeArray<byte>(arrayPtr, 3);

      return retVal; // byte[3]
    }

  }

  public NativeArray<byte> m_nCreatureDamageDie {
    set {
      NWNXLibPINVOKE.CCombatInformation_m_nCreatureDamageDie_set(swigCPtr, value);
    } 
    get {
      global::System.IntPtr arrayPtr = NWNXLibPINVOKE.CCombatInformation_m_nCreatureDamageDie_get(swigCPtr);
      NativeArray<byte> retVal = new NativeArray<byte>(arrayPtr, 3);

      return retVal; // byte[3]
    }

  }

  public string m_nCreatureDamageModifier {
    set {
      NWNXLibPINVOKE.CCombatInformation_m_nCreatureDamageModifier_set(swigCPtr, value);
    } 
    get {
      string ret = NWNXLibPINVOKE.CCombatInformation_m_nCreatureDamageModifier_get(swigCPtr);
      return ret;
    } 
  }

  public byte m_nOnHandCriticalHitRange {
    set {
      NWNXLibPINVOKE.CCombatInformation_m_nOnHandCriticalHitRange_set(swigCPtr, value);
    } 
    get {
      byte ret = NWNXLibPINVOKE.CCombatInformation_m_nOnHandCriticalHitRange_get(swigCPtr);
      return ret;
    } 
  }

  public byte m_nOnHandCriticalHitMultiplier {
    set {
      NWNXLibPINVOKE.CCombatInformation_m_nOnHandCriticalHitMultiplier_set(swigCPtr, value);
    } 
    get {
      byte ret = NWNXLibPINVOKE.CCombatInformation_m_nOnHandCriticalHitMultiplier_get(swigCPtr);
      return ret;
    } 
  }

  public int m_bOffHandWeaponEquipped {
    set {
      NWNXLibPINVOKE.CCombatInformation_m_bOffHandWeaponEquipped_set(swigCPtr, value);
    } 
    get {
      int ret = NWNXLibPINVOKE.CCombatInformation_m_bOffHandWeaponEquipped_get(swigCPtr);
      return ret;
    } 
  }

  public byte m_nOffHandCriticalHitRange {
    set {
      NWNXLibPINVOKE.CCombatInformation_m_nOffHandCriticalHitRange_set(swigCPtr, value);
    } 
    get {
      byte ret = NWNXLibPINVOKE.CCombatInformation_m_nOffHandCriticalHitRange_get(swigCPtr);
      return ret;
    } 
  }

  public byte m_nOffHandCriticalHitMultiplier {
    set {
      NWNXLibPINVOKE.CCombatInformation_m_nOffHandCriticalHitMultiplier_set(swigCPtr, value);
    } 
    get {
      byte ret = NWNXLibPINVOKE.CCombatInformation_m_nOffHandCriticalHitMultiplier_get(swigCPtr);
      return ret;
    } 
  }

  public CExoArrayListCCombatInformationNodePtr m_pAttackList {
    set {
      NWNXLibPINVOKE.CCombatInformation_m_pAttackList_set(swigCPtr, CExoArrayListCCombatInformationNodePtr.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = NWNXLibPINVOKE.CCombatInformation_m_pAttackList_get(swigCPtr);
      CExoArrayListCCombatInformationNodePtr ret = (cPtr == global::System.IntPtr.Zero) ? null : new CExoArrayListCCombatInformationNodePtr(cPtr, false);
      return ret;
    } 
  }

  public CExoArrayListCCombatInformationNodePtr m_pDamageList {
    set {
      NWNXLibPINVOKE.CCombatInformation_m_pDamageList_set(swigCPtr, CExoArrayListCCombatInformationNodePtr.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = NWNXLibPINVOKE.CCombatInformation_m_pDamageList_get(swigCPtr);
      CExoArrayListCCombatInformationNodePtr ret = (cPtr == global::System.IntPtr.Zero) ? null : new CExoArrayListCCombatInformationNodePtr(cPtr, false);
      return ret;
    } 
  }

  public uint m_oidRightEquipped {
    set {
      NWNXLibPINVOKE.CCombatInformation_m_oidRightEquipped_set(swigCPtr, value);
    } 
    get {
      uint ret = NWNXLibPINVOKE.CCombatInformation_m_oidRightEquipped_get(swigCPtr);
      return ret;
    } 
  }

  public uint m_oidLeftEquipped {
    set {
      NWNXLibPINVOKE.CCombatInformation_m_oidLeftEquipped_set(swigCPtr, value);
    } 
    get {
      uint ret = NWNXLibPINVOKE.CCombatInformation_m_oidLeftEquipped_get(swigCPtr);
      return ret;
    } 
  }

  public CExoString m_sRightEquipped {
    set {
      NWNXLibPINVOKE.CCombatInformation_m_sRightEquipped_set(swigCPtr, CExoString.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = NWNXLibPINVOKE.CCombatInformation_m_sRightEquipped_get(swigCPtr);
      CExoString ret = (cPtr == global::System.IntPtr.Zero) ? null : new CExoString(cPtr, false);
      return ret;
    } 
  }

  public CExoString m_sLeftEquipped {
    set {
      NWNXLibPINVOKE.CCombatInformation_m_sLeftEquipped_set(swigCPtr, CExoString.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = NWNXLibPINVOKE.CCombatInformation_m_sLeftEquipped_get(swigCPtr);
      CExoString ret = (cPtr == global::System.IntPtr.Zero) ? null : new CExoString(cPtr, false);
      return ret;
    } 
  }

  public byte m_nDamageDice {
    set {
      NWNXLibPINVOKE.CCombatInformation_m_nDamageDice_set(swigCPtr, value);
    } 
    get {
      byte ret = NWNXLibPINVOKE.CCombatInformation_m_nDamageDice_get(swigCPtr);
      return ret;
    } 
  }

  public byte m_nDamageDie {
    set {
      NWNXLibPINVOKE.CCombatInformation_m_nDamageDie_set(swigCPtr, value);
    } 
    get {
      byte ret = NWNXLibPINVOKE.CCombatInformation_m_nDamageDie_get(swigCPtr);
      return ret;
    } 
  }

  public CCombatInformation() : this(NWNXLibPINVOKE.new_CCombatInformation(), true) {
  }

  public int SaveData(CResGFF pRes, CResStruct pStruct) {
    int ret = NWNXLibPINVOKE.CCombatInformation_SaveData(swigCPtr, CResGFF.getCPtr(pRes), CResStruct.getCPtr(pStruct));
    return ret;
  }

  public int LoadData(CResGFF pRes, CResStruct pStruct) {
    int ret = NWNXLibPINVOKE.CCombatInformation_LoadData(swigCPtr, CResGFF.getCPtr(pRes), CResStruct.getCPtr(pStruct));
    return ret;
  }

  public int _OpEquals(CCombatInformation pData) {
    int ret = NWNXLibPINVOKE.CCombatInformation__OpEquals(swigCPtr, CCombatInformation.getCPtr(pData));
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public int _OpNotEquals(CCombatInformation pData) {
    int ret = NWNXLibPINVOKE.CCombatInformation__OpNotEquals(swigCPtr, CCombatInformation.getCPtr(pData));
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public CCombatInformation _OpAssign(CCombatInformation pData) {
    CCombatInformation ret = new CCombatInformation(NWNXLibPINVOKE.CCombatInformation__OpAssign(swigCPtr, CCombatInformation.getCPtr(pData)), false);
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

}

}

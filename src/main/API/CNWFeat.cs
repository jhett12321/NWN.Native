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

public class CNWFeat : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal CNWFeat(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(CNWFeat obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~CNWFeat() {
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
          NWNXLibPINVOKE.delete_CNWFeat(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
    }
  }

  public int m_nNameStrref {
    set {
      NWNXLibPINVOKE.CNWFeat_m_nNameStrref_set(swigCPtr, value);
    } 
    get {
      int ret = NWNXLibPINVOKE.CNWFeat_m_nNameStrref_get(swigCPtr);
      return ret;
    } 
  }

  public int m_nDescriptionStrref {
    set {
      NWNXLibPINVOKE.CNWFeat_m_nDescriptionStrref_set(swigCPtr, value);
    } 
    get {
      int ret = NWNXLibPINVOKE.CNWFeat_m_nDescriptionStrref_get(swigCPtr);
      return ret;
    } 
  }

  public int m_nTalentCategory {
    set {
      NWNXLibPINVOKE.CNWFeat_m_nTalentCategory_set(swigCPtr, value);
    } 
    get {
      int ret = NWNXLibPINVOKE.CNWFeat_m_nTalentCategory_get(swigCPtr);
      return ret;
    } 
  }

  public int m_nTalentMaxCR {
    set {
      NWNXLibPINVOKE.CNWFeat_m_nTalentMaxCR_set(swigCPtr, value);
    } 
    get {
      int ret = NWNXLibPINVOKE.CNWFeat_m_nTalentMaxCR_get(swigCPtr);
      return ret;
    } 
  }

  public CResRef m_cIcon {
    set {
      NWNXLibPINVOKE.CNWFeat_m_cIcon_set(swigCPtr, CResRef.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = NWNXLibPINVOKE.CNWFeat_m_cIcon_get(swigCPtr);
      CResRef ret = (cPtr == global::System.IntPtr.Zero) ? null : new CResRef(cPtr, false);
      return ret;
    } 
  }

  public int m_bGainMultiple {
    set {
      NWNXLibPINVOKE.CNWFeat_m_bGainMultiple_set(swigCPtr, value);
    } 
    get {
      int ret = NWNXLibPINVOKE.CNWFeat_m_bGainMultiple_get(swigCPtr);
      return ret;
    } 
  }

  public int m_bAllClassesCanUse {
    set {
      NWNXLibPINVOKE.CNWFeat_m_bAllClassesCanUse_set(swigCPtr, value);
    } 
    get {
      int ret = NWNXLibPINVOKE.CNWFeat_m_bAllClassesCanUse_get(swigCPtr);
      return ret;
    } 
  }

  public int m_bTargetSelf {
    set {
      NWNXLibPINVOKE.CNWFeat_m_bTargetSelf_set(swigCPtr, value);
    } 
    get {
      int ret = NWNXLibPINVOKE.CNWFeat_m_bTargetSelf_get(swigCPtr);
      return ret;
    } 
  }

  public int m_bHostileFeat {
    set {
      NWNXLibPINVOKE.CNWFeat_m_bHostileFeat_set(swigCPtr, value);
    } 
    get {
      int ret = NWNXLibPINVOKE.CNWFeat_m_bHostileFeat_get(swigCPtr);
      return ret;
    } 
  }

  public byte m_nMinAttackBonus {
    set {
      NWNXLibPINVOKE.CNWFeat_m_nMinAttackBonus_set(swigCPtr, value);
    } 
    get {
      byte ret = NWNXLibPINVOKE.CNWFeat_m_nMinAttackBonus_get(swigCPtr);
      return ret;
    } 
  }

  public byte m_nMinSTR {
    set {
      NWNXLibPINVOKE.CNWFeat_m_nMinSTR_set(swigCPtr, value);
    } 
    get {
      byte ret = NWNXLibPINVOKE.CNWFeat_m_nMinSTR_get(swigCPtr);
      return ret;
    } 
  }

  public byte m_nMinDEX {
    set {
      NWNXLibPINVOKE.CNWFeat_m_nMinDEX_set(swigCPtr, value);
    } 
    get {
      byte ret = NWNXLibPINVOKE.CNWFeat_m_nMinDEX_get(swigCPtr);
      return ret;
    } 
  }

  public byte m_nMinINT {
    set {
      NWNXLibPINVOKE.CNWFeat_m_nMinINT_set(swigCPtr, value);
    } 
    get {
      byte ret = NWNXLibPINVOKE.CNWFeat_m_nMinINT_get(swigCPtr);
      return ret;
    } 
  }

  public byte m_nMinWIS {
    set {
      NWNXLibPINVOKE.CNWFeat_m_nMinWIS_set(swigCPtr, value);
    } 
    get {
      byte ret = NWNXLibPINVOKE.CNWFeat_m_nMinWIS_get(swigCPtr);
      return ret;
    } 
  }

  public byte m_nMinCON {
    set {
      NWNXLibPINVOKE.CNWFeat_m_nMinCON_set(swigCPtr, value);
    } 
    get {
      byte ret = NWNXLibPINVOKE.CNWFeat_m_nMinCON_get(swigCPtr);
      return ret;
    } 
  }

  public byte m_nMinCHA {
    set {
      NWNXLibPINVOKE.CNWFeat_m_nMinCHA_set(swigCPtr, value);
    } 
    get {
      byte ret = NWNXLibPINVOKE.CNWFeat_m_nMinCHA_get(swigCPtr);
      return ret;
    } 
  }

  public byte m_nMinSpellLevel {
    set {
      NWNXLibPINVOKE.CNWFeat_m_nMinSpellLevel_set(swigCPtr, value);
    } 
    get {
      byte ret = NWNXLibPINVOKE.CNWFeat_m_nMinSpellLevel_get(swigCPtr);
      return ret;
    } 
  }

  public SWIGTYPE_p_unsigned_short m_lstPrereqFeats {
    set {
      NWNXLibPINVOKE.CNWFeat_m_lstPrereqFeats_set(swigCPtr, SWIGTYPE_p_unsigned_short.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = NWNXLibPINVOKE.CNWFeat_m_lstPrereqFeats_get(swigCPtr);
      SWIGTYPE_p_unsigned_short ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_unsigned_short(cPtr, false);
      return ret;
    } 
  }

  public SWIGTYPE_p_unsigned_short m_lstOrPrereqFeats {
    set {
      NWNXLibPINVOKE.CNWFeat_m_lstOrPrereqFeats_set(swigCPtr, SWIGTYPE_p_unsigned_short.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = NWNXLibPINVOKE.CNWFeat_m_lstOrPrereqFeats_get(swigCPtr);
      SWIGTYPE_p_unsigned_short ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_unsigned_short(cPtr, false);
      return ret;
    } 
  }

  public ushort m_nRequiredSkill {
    set {
      NWNXLibPINVOKE.CNWFeat_m_nRequiredSkill_set(swigCPtr, value);
    } 
    get {
      ushort ret = NWNXLibPINVOKE.CNWFeat_m_nRequiredSkill_get(swigCPtr);
      return ret;
    } 
  }

  public ushort m_nMinRequiredSkillRank {
    set {
      NWNXLibPINVOKE.CNWFeat_m_nMinRequiredSkillRank_set(swigCPtr, value);
    } 
    get {
      ushort ret = NWNXLibPINVOKE.CNWFeat_m_nMinRequiredSkillRank_get(swigCPtr);
      return ret;
    } 
  }

  public ushort m_nRequiredSkill2 {
    set {
      NWNXLibPINVOKE.CNWFeat_m_nRequiredSkill2_set(swigCPtr, value);
    } 
    get {
      ushort ret = NWNXLibPINVOKE.CNWFeat_m_nRequiredSkill2_get(swigCPtr);
      return ret;
    } 
  }

  public ushort m_nMinRequiredSkillRank2 {
    set {
      NWNXLibPINVOKE.CNWFeat_m_nMinRequiredSkillRank2_set(swigCPtr, value);
    } 
    get {
      ushort ret = NWNXLibPINVOKE.CNWFeat_m_nMinRequiredSkillRank2_get(swigCPtr);
      return ret;
    } 
  }

  public int m_nSuccessor {
    set {
      NWNXLibPINVOKE.CNWFeat_m_nSuccessor_set(swigCPtr, value);
    } 
    get {
      int ret = NWNXLibPINVOKE.CNWFeat_m_nSuccessor_get(swigCPtr);
      return ret;
    } 
  }

  public char m_nMasterFeat {
    set {
      NWNXLibPINVOKE.CNWFeat_m_nMasterFeat_set(swigCPtr, value);
    } 
    get {
      char ret = NWNXLibPINVOKE.CNWFeat_m_nMasterFeat_get(swigCPtr);
      return ret;
    } 
  }

  public byte m_nMinLevel {
    set {
      NWNXLibPINVOKE.CNWFeat_m_nMinLevel_set(swigCPtr, value);
    } 
    get {
      byte ret = NWNXLibPINVOKE.CNWFeat_m_nMinLevel_get(swigCPtr);
      return ret;
    } 
  }

  public byte m_nMaxLevel {
    set {
      NWNXLibPINVOKE.CNWFeat_m_nMaxLevel_set(swigCPtr, value);
    } 
    get {
      byte ret = NWNXLibPINVOKE.CNWFeat_m_nMaxLevel_get(swigCPtr);
      return ret;
    } 
  }

  public byte m_nMinLevelClass {
    set {
      NWNXLibPINVOKE.CNWFeat_m_nMinLevelClass_set(swigCPtr, value);
    } 
    get {
      byte ret = NWNXLibPINVOKE.CNWFeat_m_nMinLevelClass_get(swigCPtr);
      return ret;
    } 
  }

  public byte m_nMinFortSave {
    set {
      NWNXLibPINVOKE.CNWFeat_m_nMinFortSave_set(swigCPtr, value);
    } 
    get {
      byte ret = NWNXLibPINVOKE.CNWFeat_m_nMinFortSave_get(swigCPtr);
      return ret;
    } 
  }

  public int m_nSpellId {
    set {
      NWNXLibPINVOKE.CNWFeat_m_nSpellId_set(swigCPtr, value);
    } 
    get {
      int ret = NWNXLibPINVOKE.CNWFeat_m_nSpellId_get(swigCPtr);
      return ret;
    } 
  }

  public byte m_nUsesPerDay {
    set {
      NWNXLibPINVOKE.CNWFeat_m_nUsesPerDay_set(swigCPtr, value);
    } 
    get {
      byte ret = NWNXLibPINVOKE.CNWFeat_m_nUsesPerDay_get(swigCPtr);
      return ret;
    } 
  }

  public int m_bValidFeat {
    set {
      NWNXLibPINVOKE.CNWFeat_m_bValidFeat_set(swigCPtr, value);
    } 
    get {
      int ret = NWNXLibPINVOKE.CNWFeat_m_bValidFeat_get(swigCPtr);
      return ret;
    } 
  }

  public int m_bRequiresEpic {
    set {
      NWNXLibPINVOKE.CNWFeat_m_bRequiresEpic_set(swigCPtr, value);
    } 
    get {
      int ret = NWNXLibPINVOKE.CNWFeat_m_bRequiresEpic_get(swigCPtr);
      return ret;
    } 
  }

  public int m_bRequiresAction {
    set {
      NWNXLibPINVOKE.CNWFeat_m_bRequiresAction_set(swigCPtr, value);
    } 
    get {
      int ret = NWNXLibPINVOKE.CNWFeat_m_bRequiresAction_get(swigCPtr);
      return ret;
    } 
  }

  public CNWFeat() : this(NWNXLibPINVOKE.new_CNWFeat(), true) {
  }

  public CExoString GetNameText() {
    CExoString ret = new CExoString(NWNXLibPINVOKE.CNWFeat_GetNameText(swigCPtr), true);
    return ret;
  }

  public CExoString GetDescriptionText() {
    CExoString ret = new CExoString(NWNXLibPINVOKE.CNWFeat_GetDescriptionText(swigCPtr), true);
    return ret;
  }

}

}
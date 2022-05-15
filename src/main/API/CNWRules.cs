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

public unsafe class CNWRules : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal CNWRules(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(CNWRules obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~CNWRules() {
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
          NWNXLibPINVOKE.delete_CNWRules(swigCPtr);
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

  public static unsafe implicit operator void*(CNWRules self) {
    return (void*)self.swigCPtr.Handle;
  }

  public static unsafe CNWRules FromPointer(void* pointer, bool memoryOwn = false) {
    return pointer != null ? new CNWRules((global::System.IntPtr)pointer, memoryOwn) : null;
  }

  public static CNWRules FromPointer(global::System.IntPtr pointer, bool memoryOwn = false) {
    return pointer != global::System.IntPtr.Zero ? new CNWRules(pointer, memoryOwn) : null;
  }

  public bool Equals(CNWRules other) {
    if (ReferenceEquals(null, other)) {
      return false;
    }

    if (ReferenceEquals(this, other)) {
      return true;
    }

    return Pointer.Equals(other.Pointer);
  }

  public override bool Equals(object obj) {
    return ReferenceEquals(this, obj) || obj is CNWRules other && Equals(other);
  }

  public override int GetHashCode() {
    return swigCPtr.Handle.GetHashCode();
  }

  public static bool operator ==(CNWRules left, CNWRules right) {
    return Equals(left, right);
  }

  public static bool operator !=(CNWRules left, CNWRules right) {
    return !Equals(left, right);
  }
/*@SWIG@*/
  public NativeArray<float> m_fRangeTypes {
    set {
      NWNXLibPINVOKE.CNWRules_m_fRangeTypes_set(swigCPtr, value);
    } 
    get {
      global::System.IntPtr arrayPtr = NWNXLibPINVOKE.CNWRules_m_fRangeTypes_get(swigCPtr);
      NativeArray<float> retVal = new NativeArray<float>(arrayPtr, 5);

      return retVal; // float[5]
    }

  }

  public CNWBaseItemArray m_pBaseItemArray {
    set {
      NWNXLibPINVOKE.CNWRules_m_pBaseItemArray_set(swigCPtr, CNWBaseItemArray.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = NWNXLibPINVOKE.CNWRules_m_pBaseItemArray_get(swigCPtr);
      CNWBaseItemArray ret = (cPtr == global::System.IntPtr.Zero) ? null : new CNWBaseItemArray(cPtr, false);
      return ret;
    } 
  }

  public NativeArray<uint> m_nExperienceTable {
    set {
      NWNXLibPINVOKE.CNWRules_m_nExperienceTable_set(swigCPtr, value);
    } 
    get {
      global::System.IntPtr arrayPtr = NWNXLibPINVOKE.CNWRules_m_nExperienceTable_get(swigCPtr);
      NativeArray<uint> retVal = new NativeArray<uint>(arrayPtr, 40+1);

      return retVal; // uint[40+1]
    }

  }

  public CNWSpellArray m_pSpellArray {
    set {
      NWNXLibPINVOKE.CNWRules_m_pSpellArray_set(swigCPtr, CNWSpellArray.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = NWNXLibPINVOKE.CNWRules_m_pSpellArray_get(swigCPtr);
      CNWSpellArray ret = (cPtr == global::System.IntPtr.Zero) ? null : new CNWSpellArray(cPtr, false);
      return ret;
    } 
  }

  public CNWFeat m_lstFeats {
    set {
      NWNXLibPINVOKE.CNWRules_m_lstFeats_set(swigCPtr, CNWFeat.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = NWNXLibPINVOKE.CNWRules_m_lstFeats_get(swigCPtr);
      CNWFeat ret = (cPtr == global::System.IntPtr.Zero) ? null : new CNWFeat(cPtr, false);
      return ret;
    } 
  }

  public uint* m_lstMasterFeats {
    set {
      NWNXLibPINVOKE.CNWRules_m_lstMasterFeats_set(swigCPtr, value);
    } 
    get {
      uint* retVal = NWNXLibPINVOKE.CNWRules_m_lstMasterFeats_get(swigCPtr);
      return retVal;
    }

  }

  public uint* m_lstMasterFeatDescriptions {
    set {
      NWNXLibPINVOKE.CNWRules_m_lstMasterFeatDescriptions_set(swigCPtr, value);
    } 
    get {
      uint* retVal = NWNXLibPINVOKE.CNWRules_m_lstMasterFeatDescriptions_get(swigCPtr);
      return retVal;
    }

  }

  public CResRef m_lstMasterFeatIcons {
    set {
      NWNXLibPINVOKE.CNWRules_m_lstMasterFeatIcons_set(swigCPtr, CResRef.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = NWNXLibPINVOKE.CNWRules_m_lstMasterFeatIcons_get(swigCPtr);
      CResRef ret = (cPtr == global::System.IntPtr.Zero) ? null : new CResRef(cPtr, false);
      return ret;
    } 
  }

  public ushort* m_lstSortedFeatIDs {
    set {
      NWNXLibPINVOKE.CNWRules_m_lstSortedFeatIDs_set(swigCPtr, (global::System.IntPtr)value);
    } 
    get {
        global::System.IntPtr retVal = NWNXLibPINVOKE.CNWRules_m_lstSortedFeatIDs_get(swigCPtr);
        return (ushort*)retVal;
    }

  }

  public ushort m_nNumFeats {
    set {
      NWNXLibPINVOKE.CNWRules_m_nNumFeats_set(swigCPtr, value);
    } 
    get {
      ushort retVal = NWNXLibPINVOKE.CNWRules_m_nNumFeats_get(swigCPtr);
      return retVal;
    }

  }

  public ushort m_nNumSortedFeats {
    set {
      NWNXLibPINVOKE.CNWRules_m_nNumSortedFeats_set(swigCPtr, value);
    } 
    get {
      ushort retVal = NWNXLibPINVOKE.CNWRules_m_nNumSortedFeats_get(swigCPtr);
      return retVal;
    }

  }

  public byte m_nNumMasterFeats {
    set {
      NWNXLibPINVOKE.CNWRules_m_nNumMasterFeats_set(swigCPtr, value);
    } 
    get {
      byte retVal = NWNXLibPINVOKE.CNWRules_m_nNumMasterFeats_get(swigCPtr);
      return retVal;
    }

  }

  public byte m_nNumClasses {
    set {
      NWNXLibPINVOKE.CNWRules_m_nNumClasses_set(swigCPtr, value);
    } 
    get {
      byte retVal = NWNXLibPINVOKE.CNWRules_m_nNumClasses_get(swigCPtr);
      return retVal;
    }

  }

  public byte m_nNumRaces {
    set {
      NWNXLibPINVOKE.CNWRules_m_nNumRaces_set(swigCPtr, value);
    } 
    get {
      byte retVal = NWNXLibPINVOKE.CNWRules_m_nNumRaces_get(swigCPtr);
      return retVal;
    }

  }

  public byte m_nNumSkills {
    set {
      NWNXLibPINVOKE.CNWRules_m_nNumSkills_set(swigCPtr, value);
    } 
    get {
      byte retVal = NWNXLibPINVOKE.CNWRules_m_nNumSkills_get(swigCPtr);
      return retVal;
    }

  }

  public byte m_nNumDomains {
    set {
      NWNXLibPINVOKE.CNWRules_m_nNumDomains_set(swigCPtr, value);
    } 
    get {
      byte retVal = NWNXLibPINVOKE.CNWRules_m_nNumDomains_get(swigCPtr);
      return retVal;
    }

  }

  public CNWClass m_lstClasses {
    set {
      NWNXLibPINVOKE.CNWRules_m_lstClasses_set(swigCPtr, CNWClass.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = NWNXLibPINVOKE.CNWRules_m_lstClasses_get(swigCPtr);
      CNWClass ret = (cPtr == global::System.IntPtr.Zero) ? null : new CNWClass(cPtr, false);
      return ret;
    } 
  }

  public CNWRace m_lstRaces {
    set {
      NWNXLibPINVOKE.CNWRules_m_lstRaces_set(swigCPtr, CNWRace.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = NWNXLibPINVOKE.CNWRules_m_lstRaces_get(swigCPtr);
      CNWRace ret = (cPtr == global::System.IntPtr.Zero) ? null : new CNWRace(cPtr, false);
      return ret;
    } 
  }

  public CNWSkill m_lstSkills {
    set {
      NWNXLibPINVOKE.CNWRules_m_lstSkills_set(swigCPtr, CNWSkill.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = NWNXLibPINVOKE.CNWRules_m_lstSkills_get(swigCPtr);
      CNWSkill ret = (cPtr == global::System.IntPtr.Zero) ? null : new CNWSkill(cPtr, false);
      return ret;
    } 
  }

  public CNWDomain m_lstDomains {
    set {
      NWNXLibPINVOKE.CNWRules_m_lstDomains_set(swigCPtr, CNWDomain.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = NWNXLibPINVOKE.CNWRules_m_lstDomains_get(swigCPtr);
      CNWDomain ret = (cPtr == global::System.IntPtr.Zero) ? null : new CNWDomain(cPtr, false);
      return ret;
    } 
  }

  public CTwoDimArrays m_p2DArrays {
    set {
      NWNXLibPINVOKE.CNWRules_m_p2DArrays_set(swigCPtr, CTwoDimArrays.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = NWNXLibPINVOKE.CNWRules_m_p2DArrays_get(swigCPtr);
      CTwoDimArrays ret = (cPtr == global::System.IntPtr.Zero) ? null : new CTwoDimArrays(cPtr, false);
      return ret;
    } 
  }

  public TwoDimNativeArray<byte> m_nDifficultyOptions {
    set {
      NWNXLibPINVOKE.CNWRules_m_nDifficultyOptions_set(swigCPtr, value);
    } 
    get {
      global::System.IntPtr arrayPtr = NWNXLibPINVOKE.CNWRules_m_nDifficultyOptions_get(swigCPtr);
      TwoDimNativeArray<byte> retVal = new TwoDimNativeArray<byte>(arrayPtr, 5, 7);

      return retVal; // byte[5][7]
    }

  }

  public UnorderedMapStringCachedRulesetEntry m_ruleset_2da_cache {
    set {
      NWNXLibPINVOKE.CNWRules_m_ruleset_2da_cache_set(swigCPtr, UnorderedMapStringCachedRulesetEntry.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = NWNXLibPINVOKE.CNWRules_m_ruleset_2da_cache_get(swigCPtr);
      UnorderedMapStringCachedRulesetEntry ret = (cPtr == global::System.IntPtr.Zero) ? null : new UnorderedMapStringCachedRulesetEntry(cPtr, false);
      return ret;
    } 
  }

  public CNWRules() : this(NWNXLibPINVOKE.new_CNWRules(), true) {
  }

  public CNWDomain GetDomain(ushort nDomain) {
    global::System.IntPtr cPtr = NWNXLibPINVOKE.CNWRules_GetDomain(swigCPtr, nDomain);
    CNWDomain ret = (cPtr == global::System.IntPtr.Zero) ? null : new CNWDomain(cPtr, false);
    return ret;
  }

  public int IsArcaneClass(byte nClass) {
    int retVal = NWNXLibPINVOKE.CNWRules_IsArcaneClass(swigCPtr, nClass);
    return retVal;
  }

  public byte GetFeatExpansionLevel(ushort nFeat) {
    byte retVal = NWNXLibPINVOKE.CNWRules_GetFeatExpansionLevel(swigCPtr, nFeat);
    return retVal;
  }

  public byte GetSkillExpansionLevel(ushort nSkill) {
    byte retVal = NWNXLibPINVOKE.CNWRules_GetSkillExpansionLevel(swigCPtr, nSkill);
    return retVal;
  }

  public byte GetClassExpansionLevel(byte nClass) {
    byte retVal = NWNXLibPINVOKE.CNWRules_GetClassExpansionLevel(swigCPtr, nClass);
    return retVal;
  }

  public byte GetSpellExpansionLevel(uint nSpellId) {
    byte retVal = NWNXLibPINVOKE.CNWRules_GetSpellExpansionLevel(swigCPtr, nSpellId);
    return retVal;
  }

  public byte GetFamiliarExpansionLevel(byte nFamiliar, int bAnimalCompanion) {
    byte retVal = NWNXLibPINVOKE.CNWRules_GetFamiliarExpansionLevel(swigCPtr, nFamiliar, bAnimalCompanion);
    return retVal;
  }

  public CNWFeat GetFeat(ushort nFeat) {
    global::System.IntPtr cPtr = NWNXLibPINVOKE.CNWRules_GetFeat(swigCPtr, nFeat);
    CNWFeat ret = (cPtr == global::System.IntPtr.Zero) ? null : new CNWFeat(cPtr, false);
    return ret;
  }

  public CExoString GetMasterFeatNameText(byte nMasterFeat) {
    CExoString ret = new CExoString(NWNXLibPINVOKE.CNWRules_GetMasterFeatNameText(swigCPtr, nMasterFeat), true);
    return ret;
  }

  public CExoString GetMasterFeatDescriptionText(byte nMasterFeat) {
    CExoString ret = new CExoString(NWNXLibPINVOKE.CNWRules_GetMasterFeatDescriptionText(swigCPtr, nMasterFeat), true);
    return ret;
  }

  public CResRef GetMasterFeatIcon(byte nMasterFeat) {
    CResRef ret = new CResRef(NWNXLibPINVOKE.CNWRules_GetMasterFeatIcon(swigCPtr, nMasterFeat), true);
    return ret;
  }

  public void SortFeats() {
    NWNXLibPINVOKE.CNWRules_SortFeats(swigCPtr);
  }

  public byte GetMetaMagicLevelCost(byte nMetaType) {
    byte retVal = NWNXLibPINVOKE.CNWRules_GetMetaMagicLevelCost(swigCPtr, nMetaType);
    return retVal;
  }

  public int IsFeatUseable(byte nWISBase, ushort nFeat) {
    int retVal = NWNXLibPINVOKE.CNWRules_IsFeatUseable(swigCPtr, nWISBase, nFeat);
    return retVal;
  }

  public ushort RollDice(byte nNumberOfDice, byte nSides) {
    ushort retVal = NWNXLibPINVOKE.CNWRules_RollDice(swigCPtr, nNumberOfDice, nSides);
    return retVal;
  }

  public int GetDifficultyOption(int nOption, int nDifficultyLevel) {
    int retVal = NWNXLibPINVOKE.CNWRules_GetDifficultyOption(swigCPtr, nOption, nDifficultyLevel);
    return retVal;
  }

  public int GetWeightedDamageAmount(int nDamageDealt, int nMaxPossibleDamage, int bPCvsNPC, int bNPCvsPC, int nDamageWeight) {
    int retVal = NWNXLibPINVOKE.CNWRules_GetWeightedDamageAmount(swigCPtr, nDamageDealt, nMaxPossibleDamage, bPCvsNPC, bNPCvsPC, nDamageWeight);
    return retVal;
  }

  public int GetDamageIndexFromFlags(uint nDamageFlags) {
    int retVal = NWNXLibPINVOKE.CNWRules_GetDamageIndexFromFlags(swigCPtr, nDamageFlags);
    return retVal;
  }

  public void ReloadAll() {
    NWNXLibPINVOKE.CNWRules_ReloadAll(swigCPtr);
  }

  public void UnloadAll() {
    NWNXLibPINVOKE.CNWRules_UnloadAll(swigCPtr);
  }

  public CExoString GetRulesetStringEntry(CExoString label, CExoString whenMissing) {
    CExoString ret = new CExoString(NWNXLibPINVOKE.CNWRules_GetRulesetStringEntry(swigCPtr, CExoString.getCPtr(label), CExoString.getCPtr(whenMissing)), true);
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public int GetRulesetIntEntry(CExoString label, int whenMissing) {
    int retVal = NWNXLibPINVOKE.CNWRules_GetRulesetIntEntry(swigCPtr, CExoString.getCPtr(label), whenMissing);
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
    return retVal;
  }

  public float GetRulesetFloatEntry(CExoString label, float whenMissing) {
    float retVal = NWNXLibPINVOKE.CNWRules_GetRulesetFloatEntry(swigCPtr, CExoString.getCPtr(label), whenMissing);
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
    return retVal;
  }

  public void LoadFeatInfo() {
    NWNXLibPINVOKE.CNWRules_LoadFeatInfo(swigCPtr);
  }

  public void LoadClassInfo() {
    NWNXLibPINVOKE.CNWRules_LoadClassInfo(swigCPtr);
  }

  public void LoadRaceInfo() {
    NWNXLibPINVOKE.CNWRules_LoadRaceInfo(swigCPtr);
  }

  public void LoadSkillInfo() {
    NWNXLibPINVOKE.CNWRules_LoadSkillInfo(swigCPtr);
  }

  public void LoadDomainInfo() {
    NWNXLibPINVOKE.CNWRules_LoadDomainInfo(swigCPtr);
  }

  public void InitLegacyClassDefaults(byte nClass) {
    NWNXLibPINVOKE.CNWRules_InitLegacyClassDefaults(swigCPtr, nClass);
  }

  public void LoadDifficultyInfo() {
    NWNXLibPINVOKE.CNWRules_LoadDifficultyInfo(swigCPtr);
  }

  public void LoadRulesetInfo() {
    NWNXLibPINVOKE.CNWRules_LoadRulesetInfo(swigCPtr);
  }

  public void _Destructor() {
    NWNXLibPINVOKE.CNWRules__Destructor(swigCPtr);
  }

}

}

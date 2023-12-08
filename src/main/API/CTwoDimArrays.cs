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

public unsafe class CTwoDimArrays : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal CTwoDimArrays(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(CTwoDimArrays obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~CTwoDimArrays() {
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
          NWNXLibPINVOKE.delete_CTwoDimArrays(swigCPtr);
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

  public static unsafe implicit operator void*(CTwoDimArrays self) {
    return (void*)self.swigCPtr.Handle;
  }

  public static unsafe CTwoDimArrays FromPointer(void* pointer, bool memoryOwn = false) {
    return pointer != null ? new CTwoDimArrays((global::System.IntPtr)pointer, memoryOwn) : null;
  }

  public static CTwoDimArrays FromPointer(global::System.IntPtr pointer, bool memoryOwn = false) {
    return pointer != global::System.IntPtr.Zero ? new CTwoDimArrays(pointer, memoryOwn) : null;
  }

  public bool Equals(CTwoDimArrays other) {
    if (ReferenceEquals(null, other)) {
      return false;
    }

    if (ReferenceEquals(this, other)) {
      return true;
    }

    return Pointer.Equals(other.Pointer);
  }

  public override bool Equals(object obj) {
    return ReferenceEquals(this, obj) || obj is CTwoDimArrays other && Equals(other);
  }

  public override int GetHashCode() {
    return swigCPtr.Handle.GetHashCode();
  }

  public static bool operator ==(CTwoDimArrays left, CTwoDimArrays right) {
    return Equals(left, right);
  }

  public static bool operator !=(CTwoDimArrays left, CTwoDimArrays right) {
    return !Equals(left, right);
  }

  public void** m_paIPRPCostTables {
    set {
      NWNXLibPINVOKE.CTwoDimArrays_m_paIPRPCostTables_set(swigCPtr, (global::System.IntPtr)value);
    } 
    get {
        global::System.IntPtr retVal = NWNXLibPINVOKE.CTwoDimArrays_m_paIPRPCostTables_get(swigCPtr);
        return (void**)retVal;
    }

  }

  public byte m_nNumIPRPCostTables {
    set {
      NWNXLibPINVOKE.CTwoDimArrays_m_nNumIPRPCostTables_set(swigCPtr, value);
    } 
    get {
      byte retVal = NWNXLibPINVOKE.CTwoDimArrays_m_nNumIPRPCostTables_get(swigCPtr);
      return retVal;
    }

  }

  public NativeArray<byte> m_lstEpicBaseAttackBonus {
    set {
      NWNXLibPINVOKE.CTwoDimArrays_m_lstEpicBaseAttackBonus_set(swigCPtr, value);
    } 
    get {
      global::System.IntPtr arrayPtr = NWNXLibPINVOKE.CTwoDimArrays_m_lstEpicBaseAttackBonus_get(swigCPtr);
      NativeArray<byte> retVal = new NativeArray<byte>(arrayPtr, 60);

      return retVal; // byte[60]
    }

  }

  public NativeArray<byte> m_lstEpicFortificationSaveThrowBonus {
    set {
      NWNXLibPINVOKE.CTwoDimArrays_m_lstEpicFortificationSaveThrowBonus_set(swigCPtr, value);
    } 
    get {
      global::System.IntPtr arrayPtr = NWNXLibPINVOKE.CTwoDimArrays_m_lstEpicFortificationSaveThrowBonus_get(swigCPtr);
      NativeArray<byte> retVal = new NativeArray<byte>(arrayPtr, 60);

      return retVal; // byte[60]
    }

  }

  public NativeArray<byte> m_lstEpicWillSaveThrowBonus {
    set {
      NWNXLibPINVOKE.CTwoDimArrays_m_lstEpicWillSaveThrowBonus_set(swigCPtr, value);
    } 
    get {
      global::System.IntPtr arrayPtr = NWNXLibPINVOKE.CTwoDimArrays_m_lstEpicWillSaveThrowBonus_get(swigCPtr);
      NativeArray<byte> retVal = new NativeArray<byte>(arrayPtr, 60);

      return retVal; // byte[60]
    }

  }

  public NativeArray<byte> m_lstEpicReflexSaveThrowBonus {
    set {
      NWNXLibPINVOKE.CTwoDimArrays_m_lstEpicReflexSaveThrowBonus_set(swigCPtr, value);
    } 
    get {
      global::System.IntPtr arrayPtr = NWNXLibPINVOKE.CTwoDimArrays_m_lstEpicReflexSaveThrowBonus_get(swigCPtr);
      NativeArray<byte> retVal = new NativeArray<byte>(arrayPtr, 60);

      return retVal; // byte[60]
    }

  }

  public SWIGTYPE_p_p_C2DA m_p2DAs {
    set {
      NWNXLibPINVOKE.CTwoDimArrays_m_p2DAs_set(swigCPtr, SWIGTYPE_p_p_C2DA.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = NWNXLibPINVOKE.CTwoDimArrays_m_p2DAs_get(swigCPtr);
      SWIGTYPE_p_p_C2DA ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_p_C2DA(cPtr, false);
      return ret;
    } 
  }

  public CExoLinkedListC2DA m_lstCached2DAs {
    set {
      NWNXLibPINVOKE.CTwoDimArrays_m_lstCached2DAs_set(swigCPtr, CExoLinkedListC2DA.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = NWNXLibPINVOKE.CTwoDimArrays_m_lstCached2DAs_get(swigCPtr);
      CExoLinkedListC2DA ret = (cPtr == global::System.IntPtr.Zero) ? null : new CExoLinkedListC2DA(cPtr, false);
      return ret;
    } 
  }

  public byte m_n2daCacheSize {
    set {
      NWNXLibPINVOKE.CTwoDimArrays_m_n2daCacheSize_set(swigCPtr, value);
    } 
    get {
      byte retVal = NWNXLibPINVOKE.CTwoDimArrays_m_n2daCacheSize_get(swigCPtr);
      return retVal;
    }

  }

  public CExoLinkedListC2DA m_lstUserCached2DAs {
    set {
      NWNXLibPINVOKE.CTwoDimArrays_m_lstUserCached2DAs_set(swigCPtr, CExoLinkedListC2DA.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = NWNXLibPINVOKE.CTwoDimArrays_m_lstUserCached2DAs_get(swigCPtr);
      CExoLinkedListC2DA ret = (cPtr == global::System.IntPtr.Zero) ? null : new CExoLinkedListC2DA(cPtr, false);
      return ret;
    } 
  }

  public byte m_nUser2daCacheSize {
    set {
      NWNXLibPINVOKE.CTwoDimArrays_m_nUser2daCacheSize_set(swigCPtr, value);
    } 
    get {
      byte retVal = NWNXLibPINVOKE.CTwoDimArrays_m_nUser2daCacheSize_get(swigCPtr);
      return retVal;
    }

  }

  public byte GetEpicFortSaveBonus(byte nLevel) {
    byte retVal = NWNXLibPINVOKE.CTwoDimArrays_GetEpicFortSaveBonus(swigCPtr, nLevel);
    return retVal;
  }

  public byte GetEpicRefSaveBonus(byte nLevel) {
    byte retVal = NWNXLibPINVOKE.CTwoDimArrays_GetEpicRefSaveBonus(swigCPtr, nLevel);
    return retVal;
  }

  public byte GetEpicWillSaveBonus(byte nLevel) {
    byte retVal = NWNXLibPINVOKE.CTwoDimArrays_GetEpicWillSaveBonus(swigCPtr, nLevel);
    return retVal;
  }

  public byte GetEpicAttackBonus(byte nLevel) {
    byte retVal = NWNXLibPINVOKE.CTwoDimArrays_GetEpicAttackBonus(swigCPtr, nLevel);
    return retVal;
  }

  public CTwoDimArrays() : this(NWNXLibPINVOKE.new_CTwoDimArrays(), true) {
  }

  public int Load2DArrays() {
    int retVal = NWNXLibPINVOKE.CTwoDimArrays_Load2DArrays(swigCPtr);
    return retVal;
  }

  public int UnLoad2DArrays() {
    int retVal = NWNXLibPINVOKE.CTwoDimArrays_UnLoad2DArrays(swigCPtr);
    return retVal;
  }

  public C2DA GetCached2DA(CExoString s2DAName, int bUpdateUser2daCache) {
    global::System.IntPtr cPtr = NWNXLibPINVOKE.CTwoDimArrays_GetCached2DA__SWIG_0(swigCPtr, CExoString.getCPtr(s2DAName), bUpdateUser2daCache);
    C2DA ret = (cPtr == global::System.IntPtr.Zero) ? null : new C2DA(cPtr, false);
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public C2DA GetCached2DA(CExoString s2DAName) {
    global::System.IntPtr cPtr = NWNXLibPINVOKE.CTwoDimArrays_GetCached2DA__SWIG_1(swigCPtr, CExoString.getCPtr(s2DAName));
    C2DA ret = (cPtr == global::System.IntPtr.Zero) ? null : new C2DA(cPtr, false);
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void ClearCached2DAs() {
    NWNXLibPINVOKE.CTwoDimArrays_ClearCached2DAs(swigCPtr);
  }

  public C2DA GetIPRPCostTable(byte nCostTable) {
    global::System.IntPtr cPtr = NWNXLibPINVOKE.CTwoDimArrays_GetIPRPCostTable(swigCPtr, nCostTable);
    C2DA ret = (cPtr == global::System.IntPtr.Zero) ? null : new C2DA(cPtr, false);
    return ret;
  }

  public int LoadIPRPCostTables() {
    int retVal = NWNXLibPINVOKE.CTwoDimArrays_LoadIPRPCostTables(swigCPtr);
    return retVal;
  }

  public int UnLoadIPRPCostTables() {
    int retVal = NWNXLibPINVOKE.CTwoDimArrays_UnLoadIPRPCostTables(swigCPtr);
    return retVal;
  }

  public int LoadEpicSaves() {
    int retVal = NWNXLibPINVOKE.CTwoDimArrays_LoadEpicSaves(swigCPtr);
    return retVal;
  }

  public int LoadEpicAttacks() {
    int retVal = NWNXLibPINVOKE.CTwoDimArrays_LoadEpicAttacks(swigCPtr);
    return retVal;
  }

  public void Update2DACache(CExoLinkedListC2DA lstCached2DAs, int nMaxCacheSize, C2DA p2DA) {
    NWNXLibPINVOKE.CTwoDimArrays_Update2DACache(swigCPtr, CExoLinkedListC2DA.getCPtr(lstCached2DAs), nMaxCacheSize, C2DA.getCPtr(p2DA));
  }

  public C2DA GetAppearanceTable() {
    global::System.IntPtr cPtr = NWNXLibPINVOKE.CTwoDimArrays_GetAppearanceTable(swigCPtr);
    C2DA ret = (cPtr == global::System.IntPtr.Zero) ? null : new C2DA(cPtr, false);
    return ret;
  }

  public C2DA GetGenderTable() {
    global::System.IntPtr cPtr = NWNXLibPINVOKE.CTwoDimArrays_GetGenderTable(swigCPtr);
    C2DA ret = (cPtr == global::System.IntPtr.Zero) ? null : new C2DA(cPtr, false);
    return ret;
  }

  public C2DA GetSurfaceMaterialTable() {
    global::System.IntPtr cPtr = NWNXLibPINVOKE.CTwoDimArrays_GetSurfaceMaterialTable(swigCPtr);
    C2DA ret = (cPtr == global::System.IntPtr.Zero) ? null : new C2DA(cPtr, false);
    return ret;
  }

  public C2DA GetVisualEffectTable() {
    global::System.IntPtr cPtr = NWNXLibPINVOKE.CTwoDimArrays_GetVisualEffectTable(swigCPtr);
    C2DA ret = (cPtr == global::System.IntPtr.Zero) ? null : new C2DA(cPtr, false);
    return ret;
  }

  public C2DA GetPersistentVisualEffectTable() {
    global::System.IntPtr cPtr = NWNXLibPINVOKE.CTwoDimArrays_GetPersistentVisualEffectTable(swigCPtr);
    C2DA ret = (cPtr == global::System.IntPtr.Zero) ? null : new C2DA(cPtr, false);
    return ret;
  }

  public C2DA GetCreatureSpeedTable() {
    global::System.IntPtr cPtr = NWNXLibPINVOKE.CTwoDimArrays_GetCreatureSpeedTable(swigCPtr);
    C2DA ret = (cPtr == global::System.IntPtr.Zero) ? null : new C2DA(cPtr, false);
    return ret;
  }

  public C2DA GetDoorTypesTable() {
    global::System.IntPtr cPtr = NWNXLibPINVOKE.CTwoDimArrays_GetDoorTypesTable(swigCPtr);
    C2DA ret = (cPtr == global::System.IntPtr.Zero) ? null : new C2DA(cPtr, false);
    return ret;
  }

  public C2DA GetGenericDoorsTable() {
    global::System.IntPtr cPtr = NWNXLibPINVOKE.CTwoDimArrays_GetGenericDoorsTable(swigCPtr);
    C2DA ret = (cPtr == global::System.IntPtr.Zero) ? null : new C2DA(cPtr, false);
    return ret;
  }

  public C2DA GetPlaceablesTable() {
    global::System.IntPtr cPtr = NWNXLibPINVOKE.CTwoDimArrays_GetPlaceablesTable(swigCPtr);
    C2DA ret = (cPtr == global::System.IntPtr.Zero) ? null : new C2DA(cPtr, false);
    return ret;
  }

  public C2DA GetAreaTransitionTable() {
    global::System.IntPtr cPtr = NWNXLibPINVOKE.CTwoDimArrays_GetAreaTransitionTable(swigCPtr);
    C2DA ret = (cPtr == global::System.IntPtr.Zero) ? null : new C2DA(cPtr, false);
    return ret;
  }

  public C2DA GetIPRPSpells() {
    global::System.IntPtr cPtr = NWNXLibPINVOKE.CTwoDimArrays_GetIPRPSpells(swigCPtr);
    C2DA ret = (cPtr == global::System.IntPtr.Zero) ? null : new C2DA(cPtr, false);
    return ret;
  }

  public C2DA GetLightTable() {
    global::System.IntPtr cPtr = NWNXLibPINVOKE.CTwoDimArrays_GetLightTable(swigCPtr);
    C2DA ret = (cPtr == global::System.IntPtr.Zero) ? null : new C2DA(cPtr, false);
    return ret;
  }

  public C2DA GetIPRPColor() {
    global::System.IntPtr cPtr = NWNXLibPINVOKE.CTwoDimArrays_GetIPRPColor(swigCPtr);
    C2DA ret = (cPtr == global::System.IntPtr.Zero) ? null : new C2DA(cPtr, false);
    return ret;
  }

  public C2DA GetIPRPMelee() {
    global::System.IntPtr cPtr = NWNXLibPINVOKE.CTwoDimArrays_GetIPRPMelee(swigCPtr);
    C2DA ret = (cPtr == global::System.IntPtr.Zero) ? null : new C2DA(cPtr, false);
    return ret;
  }

  public C2DA GetItemPropDefTable() {
    global::System.IntPtr cPtr = NWNXLibPINVOKE.CTwoDimArrays_GetItemPropDefTable(swigCPtr);
    C2DA ret = (cPtr == global::System.IntPtr.Zero) ? null : new C2DA(cPtr, false);
    return ret;
  }

  public C2DA GetItemPropsTable() {
    global::System.IntPtr cPtr = NWNXLibPINVOKE.CTwoDimArrays_GetItemPropsTable(swigCPtr);
    C2DA ret = (cPtr == global::System.IntPtr.Zero) ? null : new C2DA(cPtr, false);
    return ret;
  }

  public C2DA GetCreatureSizeTable() {
    global::System.IntPtr cPtr = NWNXLibPINVOKE.CTwoDimArrays_GetCreatureSizeTable(swigCPtr);
    C2DA ret = (cPtr == global::System.IntPtr.Zero) ? null : new C2DA(cPtr, false);
    return ret;
  }

  public C2DA GetArmorTable() {
    global::System.IntPtr cPtr = NWNXLibPINVOKE.CTwoDimArrays_GetArmorTable(swigCPtr);
    C2DA ret = (cPtr == global::System.IntPtr.Zero) ? null : new C2DA(cPtr, false);
    return ret;
  }

  public C2DA GetEncumbranceTable() {
    global::System.IntPtr cPtr = NWNXLibPINVOKE.CTwoDimArrays_GetEncumbranceTable(swigCPtr);
    C2DA ret = (cPtr == global::System.IntPtr.Zero) ? null : new C2DA(cPtr, false);
    return ret;
  }

  public C2DA GetPortraitTable() {
    global::System.IntPtr cPtr = NWNXLibPINVOKE.CTwoDimArrays_GetPortraitTable(swigCPtr);
    C2DA ret = (cPtr == global::System.IntPtr.Zero) ? null : new C2DA(cPtr, false);
    return ret;
  }

  public C2DA GetPartsChest() {
    global::System.IntPtr cPtr = NWNXLibPINVOKE.CTwoDimArrays_GetPartsChest(swigCPtr);
    C2DA ret = (cPtr == global::System.IntPtr.Zero) ? null : new C2DA(cPtr, false);
    return ret;
  }

  public C2DA GetSpellSchoolTable() {
    global::System.IntPtr cPtr = NWNXLibPINVOKE.CTwoDimArrays_GetSpellSchoolTable(swigCPtr);
    C2DA ret = (cPtr == global::System.IntPtr.Zero) ? null : new C2DA(cPtr, false);
    return ret;
  }

  public C2DA GetTrapTable() {
    global::System.IntPtr cPtr = NWNXLibPINVOKE.CTwoDimArrays_GetTrapTable(swigCPtr);
    C2DA ret = (cPtr == global::System.IntPtr.Zero) ? null : new C2DA(cPtr, false);
    return ret;
  }

  public C2DA GetLightColorTable() {
    global::System.IntPtr cPtr = NWNXLibPINVOKE.CTwoDimArrays_GetLightColorTable(swigCPtr);
    C2DA ret = (cPtr == global::System.IntPtr.Zero) ? null : new C2DA(cPtr, false);
    return ret;
  }

  public C2DA GetDamageTable() {
    global::System.IntPtr cPtr = NWNXLibPINVOKE.CTwoDimArrays_GetDamageTable(swigCPtr);
    C2DA ret = (cPtr == global::System.IntPtr.Zero) ? null : new C2DA(cPtr, false);
    return ret;
  }

  public C2DA GetPartsRobe() {
    global::System.IntPtr cPtr = NWNXLibPINVOKE.CTwoDimArrays_GetPartsRobe(swigCPtr);
    C2DA ret = (cPtr == global::System.IntPtr.Zero) ? null : new C2DA(cPtr, false);
    return ret;
  }

  public C2DA GetItemValueTable() {
    global::System.IntPtr cPtr = NWNXLibPINVOKE.CTwoDimArrays_GetItemValueTable(swigCPtr);
    C2DA ret = (cPtr == global::System.IntPtr.Zero) ? null : new C2DA(cPtr, false);
    return ret;
  }

  public C2DA GetPackagesTable() {
    global::System.IntPtr cPtr = NWNXLibPINVOKE.CTwoDimArrays_GetPackagesTable(swigCPtr);
    C2DA ret = (cPtr == global::System.IntPtr.Zero) ? null : new C2DA(cPtr, false);
    return ret;
  }

  public C2DA GetRulesetTable() {
    global::System.IntPtr cPtr = NWNXLibPINVOKE.CTwoDimArrays_GetRulesetTable(swigCPtr);
    C2DA ret = (cPtr == global::System.IntPtr.Zero) ? null : new C2DA(cPtr, false);
    return ret;
  }

  public C2DA GetDamageTypesTable() {
    global::System.IntPtr cPtr = NWNXLibPINVOKE.CTwoDimArrays_GetDamageTypesTable(swigCPtr);
    C2DA ret = (cPtr == global::System.IntPtr.Zero) ? null : new C2DA(cPtr, false);
    return ret;
  }

  public C2DA GetDamageTypeGroupsTable() {
    global::System.IntPtr cPtr = NWNXLibPINVOKE.CTwoDimArrays_GetDamageTypeGroupsTable(swigCPtr);
    C2DA ret = (cPtr == global::System.IntPtr.Zero) ? null : new C2DA(cPtr, false);
    return ret;
  }

  public C2DA GetPartTable() {
    global::System.IntPtr cPtr = NWNXLibPINVOKE.CTwoDimArrays_GetPartTable(swigCPtr);
    C2DA ret = (cPtr == global::System.IntPtr.Zero) ? null : new C2DA(cPtr, false);
    return ret;
  }

  public C2DA GetArmorTypesTable() {
    global::System.IntPtr cPtr = NWNXLibPINVOKE.CTwoDimArrays_GetArmorTypesTable(swigCPtr);
    C2DA ret = (cPtr == global::System.IntPtr.Zero) ? null : new C2DA(cPtr, false);
    return ret;
  }

  public C2DA GetTileColorTable() {
    global::System.IntPtr cPtr = NWNXLibPINVOKE.CTwoDimArrays_GetTileColorTable(swigCPtr);
    C2DA ret = (cPtr == global::System.IntPtr.Zero) ? null : new C2DA(cPtr, false);
    return ret;
  }

  public C2DA GetReplaceTextureTable() {
    global::System.IntPtr cPtr = NWNXLibPINVOKE.CTwoDimArrays_GetReplaceTextureTable(swigCPtr);
    C2DA ret = (cPtr == global::System.IntPtr.Zero) ? null : new C2DA(cPtr, false);
    return ret;
  }

  public C2DA GetTailModelTable() {
    global::System.IntPtr cPtr = NWNXLibPINVOKE.CTwoDimArrays_GetTailModelTable(swigCPtr);
    C2DA ret = (cPtr == global::System.IntPtr.Zero) ? null : new C2DA(cPtr, false);
    return ret;
  }

  public C2DA GetWingModelTable() {
    global::System.IntPtr cPtr = NWNXLibPINVOKE.CTwoDimArrays_GetWingModelTable(swigCPtr);
    C2DA ret = (cPtr == global::System.IntPtr.Zero) ? null : new C2DA(cPtr, false);
    return ret;
  }

  public C2DA GetCloakModelTable() {
    global::System.IntPtr cPtr = NWNXLibPINVOKE.CTwoDimArrays_GetCloakModelTable(swigCPtr);
    C2DA ret = (cPtr == global::System.IntPtr.Zero) ? null : new C2DA(cPtr, false);
    return ret;
  }

  public C2DA GetCursorTable() {
    global::System.IntPtr cPtr = NWNXLibPINVOKE.CTwoDimArrays_GetCursorTable(swigCPtr);
    C2DA ret = (cPtr == global::System.IntPtr.Zero) ? null : new C2DA(cPtr, false);
    return ret;
  }

  public C2DA GetActionsTable() {
    global::System.IntPtr cPtr = NWNXLibPINVOKE.CTwoDimArrays_GetActionsTable(swigCPtr);
    C2DA ret = (cPtr == global::System.IntPtr.Zero) ? null : new C2DA(cPtr, false);
    return ret;
  }

  public C2DA GetAmbientMusicTable() {
    global::System.IntPtr cPtr = NWNXLibPINVOKE.CTwoDimArrays_GetAmbientMusicTable(swigCPtr);
    C2DA ret = (cPtr == global::System.IntPtr.Zero) ? null : new C2DA(cPtr, false);
    return ret;
  }

  public C2DA GetAmbientSoundTable() {
    global::System.IntPtr cPtr = NWNXLibPINVOKE.CTwoDimArrays_GetAmbientSoundTable(swigCPtr);
    C2DA ret = (cPtr == global::System.IntPtr.Zero) ? null : new C2DA(cPtr, false);
    return ret;
  }

  public C2DA GetFootstepSoundsTable() {
    global::System.IntPtr cPtr = NWNXLibPINVOKE.CTwoDimArrays_GetFootstepSoundsTable(swigCPtr);
    C2DA ret = (cPtr == global::System.IntPtr.Zero) ? null : new C2DA(cPtr, false);
    return ret;
  }

  public C2DA GetAppearanceSoundsTable() {
    global::System.IntPtr cPtr = NWNXLibPINVOKE.CTwoDimArrays_GetAppearanceSoundsTable(swigCPtr);
    C2DA ret = (cPtr == global::System.IntPtr.Zero) ? null : new C2DA(cPtr, false);
    return ret;
  }

  public C2DA GetWeaponSoundsTable() {
    global::System.IntPtr cPtr = NWNXLibPINVOKE.CTwoDimArrays_GetWeaponSoundsTable(swigCPtr);
    C2DA ret = (cPtr == global::System.IntPtr.Zero) ? null : new C2DA(cPtr, false);
    return ret;
  }

  public C2DA GetDefaultACSoundsTable() {
    global::System.IntPtr cPtr = NWNXLibPINVOKE.CTwoDimArrays_GetDefaultACSoundsTable(swigCPtr);
    C2DA ret = (cPtr == global::System.IntPtr.Zero) ? null : new C2DA(cPtr, false);
    return ret;
  }

  public C2DA GetAmmunitionTypesTable() {
    global::System.IntPtr cPtr = NWNXLibPINVOKE.CTwoDimArrays_GetAmmunitionTypesTable(swigCPtr);
    C2DA ret = (cPtr == global::System.IntPtr.Zero) ? null : new C2DA(cPtr, false);
    return ret;
  }

  public C2DA GetKeymapTable() {
    global::System.IntPtr cPtr = NWNXLibPINVOKE.CTwoDimArrays_GetKeymapTable(swigCPtr);
    C2DA ret = (cPtr == global::System.IntPtr.Zero) ? null : new C2DA(cPtr, false);
    return ret;
  }

  public C2DA GetPlaceableSoundsTable() {
    global::System.IntPtr cPtr = NWNXLibPINVOKE.CTwoDimArrays_GetPlaceableSoundsTable(swigCPtr);
    C2DA ret = (cPtr == global::System.IntPtr.Zero) ? null : new C2DA(cPtr, false);
    return ret;
  }

  public C2DA GetDamageLevelTable() {
    global::System.IntPtr cPtr = NWNXLibPINVOKE.CTwoDimArrays_GetDamageLevelTable(swigCPtr);
    C2DA ret = (cPtr == global::System.IntPtr.Zero) ? null : new C2DA(cPtr, false);
    return ret;
  }

  public C2DA GetEffectIconsTable() {
    global::System.IntPtr cPtr = NWNXLibPINVOKE.CTwoDimArrays_GetEffectIconsTable(swigCPtr);
    C2DA ret = (cPtr == global::System.IntPtr.Zero) ? null : new C2DA(cPtr, false);
    return ret;
  }

  public C2DA GetLoadHintsTable() {
    global::System.IntPtr cPtr = NWNXLibPINVOKE.CTwoDimArrays_GetLoadHintsTable(swigCPtr);
    C2DA ret = (cPtr == global::System.IntPtr.Zero) ? null : new C2DA(cPtr, false);
    return ret;
  }

  public C2DA GetSwearFilterTable() {
    global::System.IntPtr cPtr = NWNXLibPINVOKE.CTwoDimArrays_GetSwearFilterTable(swigCPtr);
    C2DA ret = (cPtr == global::System.IntPtr.Zero) ? null : new C2DA(cPtr, false);
    return ret;
  }

  public C2DA GetPhenoTypeTable() {
    global::System.IntPtr cPtr = NWNXLibPINVOKE.CTwoDimArrays_GetPhenoTypeTable(swigCPtr);
    C2DA ret = (cPtr == global::System.IntPtr.Zero) ? null : new C2DA(cPtr, false);
    return ret;
  }

  public C2DA GetIPRPVisualFxTable() {
    global::System.IntPtr cPtr = NWNXLibPINVOKE.CTwoDimArrays_GetIPRPVisualFxTable(swigCPtr);
    C2DA ret = (cPtr == global::System.IntPtr.Zero) ? null : new C2DA(cPtr, false);
    return ret;
  }

  public C2DA GetWeatherTypesTable() {
    global::System.IntPtr cPtr = NWNXLibPINVOKE.CTwoDimArrays_GetWeatherTypesTable(swigCPtr);
    C2DA ret = (cPtr == global::System.IntPtr.Zero) ? null : new C2DA(cPtr, false);
    return ret;
  }

  public C2DA GetProgFxTable() {
    global::System.IntPtr cPtr = NWNXLibPINVOKE.CTwoDimArrays_GetProgFxTable(swigCPtr);
    C2DA ret = (cPtr == global::System.IntPtr.Zero) ? null : new C2DA(cPtr, false);
    return ret;
  }

  public C2DA GetStateScriptsTable() {
    global::System.IntPtr cPtr = NWNXLibPINVOKE.CTwoDimArrays_GetStateScriptsTable(swigCPtr);
    C2DA ret = (cPtr == global::System.IntPtr.Zero) ? null : new C2DA(cPtr, false);
    return ret;
  }

  public C2DA GetPoisonTable() {
    global::System.IntPtr cPtr = NWNXLibPINVOKE.CTwoDimArrays_GetPoisonTable(swigCPtr);
    C2DA ret = (cPtr == global::System.IntPtr.Zero) ? null : new C2DA(cPtr, false);
    return ret;
  }

  public C2DA GetDiseaseTable() {
    global::System.IntPtr cPtr = NWNXLibPINVOKE.CTwoDimArrays_GetDiseaseTable(swigCPtr);
    C2DA ret = (cPtr == global::System.IntPtr.Zero) ? null : new C2DA(cPtr, false);
    return ret;
  }

  public C2DA GetRepAdjustmentsTable() {
    global::System.IntPtr cPtr = NWNXLibPINVOKE.CTwoDimArrays_GetRepAdjustmentsTable(swigCPtr);
    C2DA ret = (cPtr == global::System.IntPtr.Zero) ? null : new C2DA(cPtr, false);
    return ret;
  }

  public C2DA GetFractionalCRTable() {
    global::System.IntPtr cPtr = NWNXLibPINVOKE.CTwoDimArrays_GetFractionalCRTable(swigCPtr);
    C2DA ret = (cPtr == global::System.IntPtr.Zero) ? null : new C2DA(cPtr, false);
    return ret;
  }

  public C2DA GetEncounterDifficultyTable() {
    global::System.IntPtr cPtr = NWNXLibPINVOKE.CTwoDimArrays_GetEncounterDifficultyTable(swigCPtr);
    C2DA ret = (cPtr == global::System.IntPtr.Zero) ? null : new C2DA(cPtr, false);
    return ret;
  }

  public C2DA GetCategoryTable() {
    global::System.IntPtr cPtr = NWNXLibPINVOKE.CTwoDimArrays_GetCategoryTable(swigCPtr);
    C2DA ret = (cPtr == global::System.IntPtr.Zero) ? null : new C2DA(cPtr, false);
    return ret;
  }

  public C2DA GetExcitedDurationTable() {
    global::System.IntPtr cPtr = NWNXLibPINVOKE.CTwoDimArrays_GetExcitedDurationTable(swigCPtr);
    C2DA ret = (cPtr == global::System.IntPtr.Zero) ? null : new C2DA(cPtr, false);
    return ret;
  }

  public C2DA GetRestDurationTable() {
    global::System.IntPtr cPtr = NWNXLibPINVOKE.CTwoDimArrays_GetRestDurationTable(swigCPtr);
    C2DA ret = (cPtr == global::System.IntPtr.Zero) ? null : new C2DA(cPtr, false);
    return ret;
  }

  public C2DA GetPartsBelt() {
    global::System.IntPtr cPtr = NWNXLibPINVOKE.CTwoDimArrays_GetPartsBelt(swigCPtr);
    C2DA ret = (cPtr == global::System.IntPtr.Zero) ? null : new C2DA(cPtr, false);
    return ret;
  }

  public C2DA GetPartsBicep() {
    global::System.IntPtr cPtr = NWNXLibPINVOKE.CTwoDimArrays_GetPartsBicep(swigCPtr);
    C2DA ret = (cPtr == global::System.IntPtr.Zero) ? null : new C2DA(cPtr, false);
    return ret;
  }

  public C2DA GetPartsFoot() {
    global::System.IntPtr cPtr = NWNXLibPINVOKE.CTwoDimArrays_GetPartsFoot(swigCPtr);
    C2DA ret = (cPtr == global::System.IntPtr.Zero) ? null : new C2DA(cPtr, false);
    return ret;
  }

  public C2DA GetPartsForearm() {
    global::System.IntPtr cPtr = NWNXLibPINVOKE.CTwoDimArrays_GetPartsForearm(swigCPtr);
    C2DA ret = (cPtr == global::System.IntPtr.Zero) ? null : new C2DA(cPtr, false);
    return ret;
  }

  public C2DA GetPartsHand() {
    global::System.IntPtr cPtr = NWNXLibPINVOKE.CTwoDimArrays_GetPartsHand(swigCPtr);
    C2DA ret = (cPtr == global::System.IntPtr.Zero) ? null : new C2DA(cPtr, false);
    return ret;
  }

  public C2DA GetPartsLegs() {
    global::System.IntPtr cPtr = NWNXLibPINVOKE.CTwoDimArrays_GetPartsLegs(swigCPtr);
    C2DA ret = (cPtr == global::System.IntPtr.Zero) ? null : new C2DA(cPtr, false);
    return ret;
  }

  public C2DA GetPartsNeck() {
    global::System.IntPtr cPtr = NWNXLibPINVOKE.CTwoDimArrays_GetPartsNeck(swigCPtr);
    C2DA ret = (cPtr == global::System.IntPtr.Zero) ? null : new C2DA(cPtr, false);
    return ret;
  }

  public C2DA GetPartsPelvis() {
    global::System.IntPtr cPtr = NWNXLibPINVOKE.CTwoDimArrays_GetPartsPelvis(swigCPtr);
    C2DA ret = (cPtr == global::System.IntPtr.Zero) ? null : new C2DA(cPtr, false);
    return ret;
  }

  public C2DA GetPartsShin() {
    global::System.IntPtr cPtr = NWNXLibPINVOKE.CTwoDimArrays_GetPartsShin(swigCPtr);
    C2DA ret = (cPtr == global::System.IntPtr.Zero) ? null : new C2DA(cPtr, false);
    return ret;
  }

  public C2DA GetPartsShoulder() {
    global::System.IntPtr cPtr = NWNXLibPINVOKE.CTwoDimArrays_GetPartsShoulder(swigCPtr);
    C2DA ret = (cPtr == global::System.IntPtr.Zero) ? null : new C2DA(cPtr, false);
    return ret;
  }

  public C2DA GetXpBase() {
    global::System.IntPtr cPtr = NWNXLibPINVOKE.CTwoDimArrays_GetXpBase(swigCPtr);
    C2DA ret = (cPtr == global::System.IntPtr.Zero) ? null : new C2DA(cPtr, false);
    return ret;
  }

  public C2DA GetAssociatesAnimalCompanionTable() {
    global::System.IntPtr cPtr = NWNXLibPINVOKE.CTwoDimArrays_GetAssociatesAnimalCompanionTable(swigCPtr);
    C2DA ret = (cPtr == global::System.IntPtr.Zero) ? null : new C2DA(cPtr, false);
    return ret;
  }

  public C2DA GetAssociatesFamiliarTable() {
    global::System.IntPtr cPtr = NWNXLibPINVOKE.CTwoDimArrays_GetAssociatesFamiliarTable(swigCPtr);
    C2DA ret = (cPtr == global::System.IntPtr.Zero) ? null : new C2DA(cPtr, false);
    return ret;
  }

  public C2DA GetSkillVsItemCostTable() {
    global::System.IntPtr cPtr = NWNXLibPINVOKE.CTwoDimArrays_GetSkillVsItemCostTable(swigCPtr);
    C2DA ret = (cPtr == global::System.IntPtr.Zero) ? null : new C2DA(cPtr, false);
    return ret;
  }

  public C2DA GetRangesTable() {
    global::System.IntPtr cPtr = NWNXLibPINVOKE.CTwoDimArrays_GetRangesTable(swigCPtr);
    C2DA ret = (cPtr == global::System.IntPtr.Zero) ? null : new C2DA(cPtr, false);
    return ret;
  }

  public C2DA GetPolymorphTable() {
    global::System.IntPtr cPtr = NWNXLibPINVOKE.CTwoDimArrays_GetPolymorphTable(swigCPtr);
    C2DA ret = (cPtr == global::System.IntPtr.Zero) ? null : new C2DA(cPtr, false);
    return ret;
  }

  public C2DA GetDamageHitVisualTable() {
    global::System.IntPtr cPtr = NWNXLibPINVOKE.CTwoDimArrays_GetDamageHitVisualTable(swigCPtr);
    C2DA ret = (cPtr == global::System.IntPtr.Zero) ? null : new C2DA(cPtr, false);
    return ret;
  }

  public C2DA GetBodyBagTable() {
    global::System.IntPtr cPtr = NWNXLibPINVOKE.CTwoDimArrays_GetBodyBagTable(swigCPtr);
    C2DA ret = (cPtr == global::System.IntPtr.Zero) ? null : new C2DA(cPtr, false);
    return ret;
  }

  public C2DA GetIPRPFeatsTable() {
    global::System.IntPtr cPtr = NWNXLibPINVOKE.CTwoDimArrays_GetIPRPFeatsTable(swigCPtr);
    C2DA ret = (cPtr == global::System.IntPtr.Zero) ? null : new C2DA(cPtr, false);
    return ret;
  }

  public C2DA GetMonsterDamageTable() {
    global::System.IntPtr cPtr = NWNXLibPINVOKE.CTwoDimArrays_GetMonsterDamageTable(swigCPtr);
    C2DA ret = (cPtr == global::System.IntPtr.Zero) ? null : new C2DA(cPtr, false);
    return ret;
  }

  public C2DA GetOnHitTable() {
    global::System.IntPtr cPtr = NWNXLibPINVOKE.CTwoDimArrays_GetOnHitTable(swigCPtr);
    C2DA ret = (cPtr == global::System.IntPtr.Zero) ? null : new C2DA(cPtr, false);
    return ret;
  }

  public C2DA GetOnHitSpellTable() {
    global::System.IntPtr cPtr = NWNXLibPINVOKE.CTwoDimArrays_GetOnHitSpellTable(swigCPtr);
    C2DA ret = (cPtr == global::System.IntPtr.Zero) ? null : new C2DA(cPtr, false);
    return ret;
  }

  public C2DA GetOnHitDurationTable() {
    global::System.IntPtr cPtr = NWNXLibPINVOKE.CTwoDimArrays_GetOnHitDurationTable(swigCPtr);
    C2DA ret = (cPtr == global::System.IntPtr.Zero) ? null : new C2DA(cPtr, false);
    return ret;
  }

  public C2DA GetACModTypeTable() {
    global::System.IntPtr cPtr = NWNXLibPINVOKE.CTwoDimArrays_GetACModTypeTable(swigCPtr);
    C2DA ret = (cPtr == global::System.IntPtr.Zero) ? null : new C2DA(cPtr, false);
    return ret;
  }

  public C2DA GetWeightIncTable() {
    global::System.IntPtr cPtr = NWNXLibPINVOKE.CTwoDimArrays_GetWeightIncTable(swigCPtr);
    C2DA ret = (cPtr == global::System.IntPtr.Zero) ? null : new C2DA(cPtr, false);
    return ret;
  }

  public C2DA GetArcaneSpellFailureTable() {
    global::System.IntPtr cPtr = NWNXLibPINVOKE.CTwoDimArrays_GetArcaneSpellFailureTable(swigCPtr);
    C2DA ret = (cPtr == global::System.IntPtr.Zero) ? null : new C2DA(cPtr, false);
    return ret;
  }

  public C2DA GetItemPropBonusCostTable() {
    global::System.IntPtr cPtr = NWNXLibPINVOKE.CTwoDimArrays_GetItemPropBonusCostTable(swigCPtr);
    C2DA ret = (cPtr == global::System.IntPtr.Zero) ? null : new C2DA(cPtr, false);
    return ret;
  }

  public C2DA GetItemPropSRTable() {
    global::System.IntPtr cPtr = NWNXLibPINVOKE.CTwoDimArrays_GetItemPropSRTable(swigCPtr);
    C2DA ret = (cPtr == global::System.IntPtr.Zero) ? null : new C2DA(cPtr, false);
    return ret;
  }

  public C2DA GetItemPropNeg5CostTable() {
    global::System.IntPtr cPtr = NWNXLibPINVOKE.CTwoDimArrays_GetItemPropNeg5CostTable(swigCPtr);
    C2DA ret = (cPtr == global::System.IntPtr.Zero) ? null : new C2DA(cPtr, false);
    return ret;
  }

  public void _Destructor() {
    NWNXLibPINVOKE.CTwoDimArrays__Destructor(swigCPtr);
  }

  public enum TwoDAIndex {
    TwoDA_AppearanceTable,
    TwoDA_GenderTable,
    TwoDA_SurfaceMaterialTable,
    TwoDA_AreaTransitionTable,
    TwoDA_PersistentVisualEffectTable,
    TwoDA_CreatureSpeedTable,
    TwoDA_DoorTypesTable,
    TwoDA_GenericDoorsTable,
    TwoDA_PlaceablesTable,
    TwoDA_IPRPSpells,
    TwoDA_IPRPLightTable,
    TwoDA_IPRPColor,
    TwoDA_IPRPMelee,
    TwoDA_ItemPropDefTable,
    TwoDA_ItemPropsTable,
    TwoDA_CreatureSizeTable,
    TwoDA_ArmorTable,
    TwoDA_PortraitTable,
    TwoDA_PartTable,
    TwoDA_ArmorTypesTable,
    TwoDA_TileColorTable,
    TwoDA_LightColorTable,
    TwoDA_ReplaceTextureTable,
    TwoDA_TailModelTable,
    TwoDA_WingModelTable,
    TwoDA_CloakModelTable,
    TwoDA_CursorTable,
    TwoDA_ActionsTable,
    TwoDA_AmbientMusicTable,
    TwoDA_AmbientSoundTable,
    TwoDA_FootstepSoundsTable,
    TwoDA_AppearanceSoundsTable,
    TwoDA_WeaponSoundsTable,
    TwoDA_DefaultACSoundsTable,
    TwoDA_AmmunitionTypesTable,
    TwoDA_KeymapTable,
    TwoDA_PlaceableSoundsTable,
    TwoDA_DamageLevelTable,
    TwoDA_EffectIconsTable,
    TwoDA_LoadHintsTable,
    TwoDA_SwearFilterTable,
    TwoDA_PhenoTypeTable,
    TwoDA_IPRPVisualFxTable,
    TwoDA_WeatherTypesTable,
    TwoDA_ProgFxTable,
    TwoDA_StateScriptsTable,
    TwoDA_VisualEffectTable,
    TwoDA_TrapTable,
    TwoDA_SpellSchoolTable,
    TwoDA_PoisonTable,
    TwoDA_DiseaseTable,
    TwoDA_RepAdjustmentsTable,
    TwoDA_FractionalCRTable,
    TwoDA_CategoryTable,
    TwoDA_ExcitedDurationTable,
    TwoDA_RestDurationTable,
    TwoDA_EncounterDifficultyTable,
    TwoDA_IPRPMonsterDamageTable,
    TwoDA_AssociatesAnimalCompanionTable,
    TwoDA_AssociatesFamiliarTable,
    TwoDA_IPRPDamageTable,
    TwoDA_SkillVsItemCostTable,
    TwoDA_IPRPBonusCostTable,
    TwoDA_IPRPSRCostTable,
    TwoDA_IPRPNeg5CostTable,
    TwoDA_IPRPArcSpell,
    TwoDA_EncumbranceTable,
    TwoDA_PartsBelt,
    TwoDA_PartsBicep,
    TwoDA_PartsChest,
    TwoDA_PartsFoot,
    TwoDA_PartsForearm,
    TwoDA_PartsHand,
    TwoDA_PartsLegs,
    TwoDA_PartsNeck,
    TwoDA_PartsPelvis,
    TwoDA_PartsShin,
    TwoDA_PartsShoulder,
    TwoDA_PartsRobe,
    TwoDA_ItemValue,
    TwoDA_Packages,
    TwoDA_Ruleset,
    TwoDA_DamageTypes,
    TwoDA_DamageTypeGroups,
    TwoDA_XpBase,
    TwoDA_RangesTable,
    TwoDA_PolymorphTable,
    TwoDA_OnHitTable,
    TwoDA_OnHitSpellTable,
    TwoDA_OnHitDurationTable,
    TwoDA_DamageHitVisualTable,
    TwoDA_IPRPACModTypeTable,
    TwoDA_IPRPWeightIncTable,
    TwoDA_BodyBagTable,
    TwoDA_IPRPFeatsTable,
    TWODA_COUNT
  }

}

}

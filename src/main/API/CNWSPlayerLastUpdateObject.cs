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

public unsafe class CNWSPlayerLastUpdateObject : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal CNWSPlayerLastUpdateObject(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(CNWSPlayerLastUpdateObject obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~CNWSPlayerLastUpdateObject() {
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
          NWNXLibPINVOKE.delete_CNWSPlayerLastUpdateObject(swigCPtr);
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

  public static unsafe implicit operator void*(CNWSPlayerLastUpdateObject self) {
    return (void*)self.swigCPtr.Handle;
  }

  public static unsafe CNWSPlayerLastUpdateObject FromPointer(void* pointer, bool memoryOwn = false) {
    return pointer != null ? new CNWSPlayerLastUpdateObject((global::System.IntPtr)pointer, memoryOwn) : null;
  }

  public static CNWSPlayerLastUpdateObject FromPointer(global::System.IntPtr pointer, bool memoryOwn = false) {
    return pointer != global::System.IntPtr.Zero ? new CNWSPlayerLastUpdateObject(pointer, memoryOwn) : null;
  }

  public bool Equals(CNWSPlayerLastUpdateObject other) {
    if (ReferenceEquals(null, other)) {
      return false;
    }

    if (ReferenceEquals(this, other)) {
      return true;
    }

    return Pointer.Equals(other.Pointer);
  }

  public override bool Equals(object obj) {
    return ReferenceEquals(this, obj) || obj is CNWSPlayerLastUpdateObject other && Equals(other);
  }

  public override int GetHashCode() {
    return swigCPtr.Handle.GetHashCode();
  }

  public static bool operator ==(CNWSPlayerLastUpdateObject left, CNWSPlayerLastUpdateObject right) {
    return Equals(left, right);
  }

  public static bool operator !=(CNWSPlayerLastUpdateObject left, CNWSPlayerLastUpdateObject right) {
    return !Equals(left, right);
  }
/*@SWIG@*/
  public uint m_nGold {
    set {
      NWNXLibPINVOKE.CNWSPlayerLastUpdateObject_m_nGold_set(swigCPtr, value);
    } 
    get {
      uint retVal = NWNXLibPINVOKE.CNWSPlayerLastUpdateObject_m_nGold_get(swigCPtr);
      return retVal;
    }

  }

  public short m_nArmorClass {
    set {
      NWNXLibPINVOKE.CNWSPlayerLastUpdateObject_m_nArmorClass_set(swigCPtr, value);
    } 
    get {
      short retVal = NWNXLibPINVOKE.CNWSPlayerLastUpdateObject_m_nArmorClass_get(swigCPtr);
      return retVal;
    }

  }

  public short m_nHenchmanArmorClass {
    set {
      NWNXLibPINVOKE.CNWSPlayerLastUpdateObject_m_nHenchmanArmorClass_set(swigCPtr, value);
    } 
    get {
      short retVal = NWNXLibPINVOKE.CNWSPlayerLastUpdateObject_m_nHenchmanArmorClass_get(swigCPtr);
      return retVal;
    }

  }

  public short m_nTotalWeightCarried {
    set {
      NWNXLibPINVOKE.CNWSPlayerLastUpdateObject_m_nTotalWeightCarried_set(swigCPtr, value);
    } 
    get {
      short retVal = NWNXLibPINVOKE.CNWSPlayerLastUpdateObject_m_nTotalWeightCarried_get(swigCPtr);
      return retVal;
    }

  }

  public short m_nHenchmanTotalWeightCarried {
    set {
      NWNXLibPINVOKE.CNWSPlayerLastUpdateObject_m_nHenchmanTotalWeightCarried_set(swigCPtr, value);
    } 
    get {
      short retVal = NWNXLibPINVOKE.CNWSPlayerLastUpdateObject_m_nHenchmanTotalWeightCarried_get(swigCPtr);
      return retVal;
    }

  }

  public int m_bCanLevelUp {
    set {
      NWNXLibPINVOKE.CNWSPlayerLastUpdateObject_m_bCanLevelUp_set(swigCPtr, value);
    } 
    get {
      int retVal = NWNXLibPINVOKE.CNWSPlayerLastUpdateObject_m_bCanLevelUp_get(swigCPtr);
      return retVal;
    }

  }

  public int m_nLevel {
    set {
      NWNXLibPINVOKE.CNWSPlayerLastUpdateObject_m_nLevel_set(swigCPtr, value);
    } 
    get {
      int retVal = NWNXLibPINVOKE.CNWSPlayerLastUpdateObject_m_nLevel_get(swigCPtr);
      return retVal;
    }

  }

  public uint m_nGuiSkills {
    set {
      NWNXLibPINVOKE.CNWSPlayerLastUpdateObject_m_nGuiSkills_set(swigCPtr, value);
    } 
    get {
      uint retVal = NWNXLibPINVOKE.CNWSPlayerLastUpdateObject_m_nGuiSkills_get(swigCPtr);
      return retVal;
    }

  }

  public CExoArrayListUInt16 m_lstFeats {
    set {
      NWNXLibPINVOKE.CNWSPlayerLastUpdateObject_m_lstFeats_set(swigCPtr, CExoArrayListUInt16.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = NWNXLibPINVOKE.CNWSPlayerLastUpdateObject_m_lstFeats_get(swigCPtr);
      CExoArrayListUInt16 ret = (cPtr == global::System.IntPtr.Zero) ? null : new CExoArrayListUInt16(cPtr, false);
      return ret;
    } 
  }

  public CExoArrayListUInt16 m_lstBonusFeats {
    set {
      NWNXLibPINVOKE.CNWSPlayerLastUpdateObject_m_lstBonusFeats_set(swigCPtr, CExoArrayListUInt16.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = NWNXLibPINVOKE.CNWSPlayerLastUpdateObject_m_lstBonusFeats_get(swigCPtr);
      CExoArrayListUInt16 ret = (cPtr == global::System.IntPtr.Zero) ? null : new CExoArrayListUInt16(cPtr, false);
      return ret;
    } 
  }

  public CExoArrayListCFeatUseListEntryPtr m_lstFeatUses {
    set {
      NWNXLibPINVOKE.CNWSPlayerLastUpdateObject_m_lstFeatUses_set(swigCPtr, CExoArrayListCFeatUseListEntryPtr.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = NWNXLibPINVOKE.CNWSPlayerLastUpdateObject_m_lstFeatUses_get(swigCPtr);
      CExoArrayListCFeatUseListEntryPtr ret = (cPtr == global::System.IntPtr.Zero) ? null : new CExoArrayListCFeatUseListEntryPtr(cPtr, false);
      return ret;
    } 
  }

  public uint m_nPlayerState {
    set {
      NWNXLibPINVOKE.CNWSPlayerLastUpdateObject_m_nPlayerState_set(swigCPtr, value);
    } 
    get {
      uint retVal = NWNXLibPINVOKE.CNWSPlayerLastUpdateObject_m_nPlayerState_get(swigCPtr);
      return retVal;
    }

  }

  public int m_nPolymorphSpellId1 {
    set {
      NWNXLibPINVOKE.CNWSPlayerLastUpdateObject_m_nPolymorphSpellId1_set(swigCPtr, value);
    } 
    get {
      int retVal = NWNXLibPINVOKE.CNWSPlayerLastUpdateObject_m_nPolymorphSpellId1_get(swigCPtr);
      return retVal;
    }

  }

  public int m_nPolymorphSpellId2 {
    set {
      NWNXLibPINVOKE.CNWSPlayerLastUpdateObject_m_nPolymorphSpellId2_set(swigCPtr, value);
    } 
    get {
      int retVal = NWNXLibPINVOKE.CNWSPlayerLastUpdateObject_m_nPolymorphSpellId2_get(swigCPtr);
      return retVal;
    }

  }

  public int m_nPolymorphSpellId3 {
    set {
      NWNXLibPINVOKE.CNWSPlayerLastUpdateObject_m_nPolymorphSpellId3_set(swigCPtr, value);
    } 
    get {
      int retVal = NWNXLibPINVOKE.CNWSPlayerLastUpdateObject_m_nPolymorphSpellId3_get(swigCPtr);
      return retVal;
    }

  }

  public CNWActionNodeArray m_pActionQueueList {
    set {
      NWNXLibPINVOKE.CNWSPlayerLastUpdateObject_m_pActionQueueList_set(swigCPtr, CNWActionNodeArray.getCPtr(value));
    } 
    get {
        global::System.IntPtr cPtr = NWNXLibPINVOKE.CNWSPlayerLastUpdateObject_m_pActionQueueList_get(swigCPtr);;
        CNWActionNodeArray ret = (cPtr == global::System.IntPtr.Zero) ? null : new CNWActionNodeArray(cPtr, false);
        return ret;
    }

  }

  public byte* m_pAutoMapTileData {
    set {
      NWNXLibPINVOKE.CNWSPlayerLastUpdateObject_m_pAutoMapTileData_set(swigCPtr, value);
    } 
    get {
      byte* retVal = NWNXLibPINVOKE.CNWSPlayerLastUpdateObject_m_pAutoMapTileData_get(swigCPtr);
      return retVal;
    }

  }

  public uint m_oidAutoMapArea {
    set {
      NWNXLibPINVOKE.CNWSPlayerLastUpdateObject_m_oidAutoMapArea_set(swigCPtr, value);
    } 
    get {
      uint retVal = NWNXLibPINVOKE.CNWSPlayerLastUpdateObject_m_oidAutoMapArea_get(swigCPtr);
      return retVal;
    }

  }

  public CExoArrayListCNWVisibilityNodePtr m_lstVisibilityList {
    set {
      NWNXLibPINVOKE.CNWSPlayerLastUpdateObject_m_lstVisibilityList_set(swigCPtr, CExoArrayListCNWVisibilityNodePtr.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = NWNXLibPINVOKE.CNWSPlayerLastUpdateObject_m_lstVisibilityList_get(swigCPtr);
      CExoArrayListCNWVisibilityNodePtr ret = (cPtr == global::System.IntPtr.Zero) ? null : new CExoArrayListCNWVisibilityNodePtr(cPtr, false);
      return ret;
    } 
  }

  public SWIGTYPE_p_a_10__CExoArrayListT_unsigned_int_t m_pKnownSpellList {
    set {
      NWNXLibPINVOKE.CNWSPlayerLastUpdateObject_m_pKnownSpellList_set(swigCPtr, SWIGTYPE_p_a_10__CExoArrayListT_unsigned_int_t.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = NWNXLibPINVOKE.CNWSPlayerLastUpdateObject_m_pKnownSpellList_get(swigCPtr);
      SWIGTYPE_p_a_10__CExoArrayListT_unsigned_int_t ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_a_10__CExoArrayListT_unsigned_int_t(cPtr, false);
      return ret;
    } 
  }

  public SWIGTYPE_p_a_10__CExoArrayListT_CNWSStats_Spell_p_t m_pMemorizedSpellList {
    set {
      NWNXLibPINVOKE.CNWSPlayerLastUpdateObject_m_pMemorizedSpellList_set(swigCPtr, SWIGTYPE_p_a_10__CExoArrayListT_CNWSStats_Spell_p_t.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = NWNXLibPINVOKE.CNWSPlayerLastUpdateObject_m_pMemorizedSpellList_get(swigCPtr);
      SWIGTYPE_p_a_10__CExoArrayListT_CNWSStats_Spell_p_t ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_a_10__CExoArrayListT_CNWSStats_Spell_p_t(cPtr, false);
      return ret;
    } 
  }

  public CExoArrayListUInt32Array m_lstKnownSpellsToDelete {
    set {
      NWNXLibPINVOKE.CNWSPlayerLastUpdateObject_m_lstKnownSpellsToDelete_set(swigCPtr, CExoArrayListUInt32Array.getCPtr(value));
    } 
    get {
        global::System.IntPtr cPtr = NWNXLibPINVOKE.CNWSPlayerLastUpdateObject_m_lstKnownSpellsToDelete_get(swigCPtr);;
        CExoArrayListUInt32Array ret = (cPtr == global::System.IntPtr.Zero) ? null : new CExoArrayListUInt32Array(cPtr, false);
        return ret;
    }

  }

  public CExoArrayListUInt32Array m_lstKnownSpellsToAdd {
    set {
      NWNXLibPINVOKE.CNWSPlayerLastUpdateObject_m_lstKnownSpellsToAdd_set(swigCPtr, CExoArrayListUInt32Array.getCPtr(value));
    } 
    get {
        global::System.IntPtr cPtr = NWNXLibPINVOKE.CNWSPlayerLastUpdateObject_m_lstKnownSpellsToAdd_get(swigCPtr);;
        CExoArrayListUInt32Array ret = (cPtr == global::System.IntPtr.Zero) ? null : new CExoArrayListUInt32Array(cPtr, false);
        return ret;
    }

  }

  public CExoArrayListCSpellDeletePtrArray m_lstMemorizedSpellsToDelete {
    set {
      NWNXLibPINVOKE.CNWSPlayerLastUpdateObject_m_lstMemorizedSpellsToDelete_set(swigCPtr, CExoArrayListCSpellDeletePtrArray.getCPtr(value));
    } 
    get {
        global::System.IntPtr cPtr = NWNXLibPINVOKE.CNWSPlayerLastUpdateObject_m_lstMemorizedSpellsToDelete_get(swigCPtr);;
        CExoArrayListCSpellDeletePtrArray ret = (cPtr == global::System.IntPtr.Zero) ? null : new CExoArrayListCSpellDeletePtrArray(cPtr, false);
        return ret;
    }

  }

  public CExoArrayListCSpellAddPtrArray m_lstMemorizedSpellsToAdd {
    set {
      NWNXLibPINVOKE.CNWSPlayerLastUpdateObject_m_lstMemorizedSpellsToAdd_set(swigCPtr, CExoArrayListCSpellAddPtrArray.getCPtr(value));
    } 
    get {
        global::System.IntPtr cPtr = NWNXLibPINVOKE.CNWSPlayerLastUpdateObject_m_lstMemorizedSpellsToAdd_get(swigCPtr);;
        CExoArrayListCSpellAddPtrArray ret = (cPtr == global::System.IntPtr.Zero) ? null : new CExoArrayListCSpellAddPtrArray(cPtr, false);
        return ret;
    }

  }

  public SWIGTYPE_p_a_10__unsigned_char m_pKnownSpellUsesLeft {
    set {
      NWNXLibPINVOKE.CNWSPlayerLastUpdateObject_m_pKnownSpellUsesLeft_set(swigCPtr, SWIGTYPE_p_a_10__unsigned_char.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = NWNXLibPINVOKE.CNWSPlayerLastUpdateObject_m_pKnownSpellUsesLeft_get(swigCPtr);
      SWIGTYPE_p_a_10__unsigned_char ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_a_10__unsigned_char(cPtr, false);
      return ret;
    } 
  }

  public CExoArrayListCEffectIconObjectPtr m_aEffectIcons {
    set {
      NWNXLibPINVOKE.CNWSPlayerLastUpdateObject_m_aEffectIcons_set(swigCPtr, CExoArrayListCEffectIconObjectPtr.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = NWNXLibPINVOKE.CNWSPlayerLastUpdateObject_m_aEffectIcons_get(swigCPtr);
      CExoArrayListCEffectIconObjectPtr ret = (cPtr == global::System.IntPtr.Zero) ? null : new CExoArrayListCEffectIconObjectPtr(cPtr, false);
      return ret;
    } 
  }

  public CExoArrayListCNWSStatsSpellLikeAbility m_pSpellLikeAbilityList {
    set {
      NWNXLibPINVOKE.CNWSPlayerLastUpdateObject_m_pSpellLikeAbilityList_set(swigCPtr, CExoArrayListCNWSStatsSpellLikeAbility.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = NWNXLibPINVOKE.CNWSPlayerLastUpdateObject_m_pSpellLikeAbilityList_get(swigCPtr);
      CExoArrayListCNWSStatsSpellLikeAbility ret = (cPtr == global::System.IntPtr.Zero) ? null : new CExoArrayListCNWSStatsSpellLikeAbility(cPtr, false);
      return ret;
    } 
  }

  public CNWSPlayerLastUpdateObject() : this(NWNXLibPINVOKE.new_CNWSPlayerLastUpdateObject(), true) {
  }

  public void SetMemorizedSpellSlot(byte nMultiClass, byte nSpellLevel, byte nSpellSlot, uint nSpellId, int bDomainSpell, byte nMetaType) {
    NWNXLibPINVOKE.CNWSPlayerLastUpdateObject_SetMemorizedSpellSlot(swigCPtr, nMultiClass, nSpellLevel, nSpellSlot, nSpellId, bDomainSpell, nMetaType);
  }

  public void AddKnownSpell(byte nMultiClass, byte nSpellLevel, uint nSpellId) {
    NWNXLibPINVOKE.CNWSPlayerLastUpdateObject_AddKnownSpell(swigCPtr, nMultiClass, nSpellLevel, nSpellId);
  }

  public void ClearKnownSpells() {
    NWNXLibPINVOKE.CNWSPlayerLastUpdateObject_ClearKnownSpells(swigCPtr);
  }

  public void ClearMemorizedSpells() {
    NWNXLibPINVOKE.CNWSPlayerLastUpdateObject_ClearMemorizedSpells(swigCPtr);
  }

  public uint GetKnownSpell(byte nMultiClass, byte nSpellLevel, byte nSpellSlot) {
    uint retVal = NWNXLibPINVOKE.CNWSPlayerLastUpdateObject_GetKnownSpell(swigCPtr, nMultiClass, nSpellLevel, nSpellSlot);
    return retVal;
  }

  public uint GetMemorizedSpell(byte nMultiClass, byte nSpellLevel, byte nSpellSlot) {
    uint retVal = NWNXLibPINVOKE.CNWSPlayerLastUpdateObject_GetMemorizedSpell(swigCPtr, nMultiClass, nSpellLevel, nSpellSlot);
    return retVal;
  }

  public int GetMemorizedSpellReadied(byte nMultiClass, byte nSpellLevel, byte nSpellSlot) {
    int retVal = NWNXLibPINVOKE.CNWSPlayerLastUpdateObject_GetMemorizedSpellReadied(swigCPtr, nMultiClass, nSpellLevel, nSpellSlot);
    return retVal;
  }

  public void SetMemorizedSpellReadied(byte nMultiClass, byte nSpellLevel, byte nSpellSlot, int bReadied) {
    NWNXLibPINVOKE.CNWSPlayerLastUpdateObject_SetMemorizedSpellReadied(swigCPtr, nMultiClass, nSpellLevel, nSpellSlot, bReadied);
  }

  public byte GetMemorizedSpellMetaType(byte nMultiClass, byte nSpellLevel, byte nSpellSlot) {
    byte retVal = NWNXLibPINVOKE.CNWSPlayerLastUpdateObject_GetMemorizedSpellMetaType(swigCPtr, nMultiClass, nSpellLevel, nSpellSlot);
    return retVal;
  }

  public int GetIsDomainSpell(byte nMultiClass, byte nSpellLevel, byte nSpellSlot) {
    int retVal = NWNXLibPINVOKE.CNWSPlayerLastUpdateObject_GetIsDomainSpell(swigCPtr, nMultiClass, nSpellLevel, nSpellSlot);
    return retVal;
  }

  public void SetNumberMemorizedSpellSlots(byte nMultiClass, byte nSpellLevel, byte nNumSlots) {
    NWNXLibPINVOKE.CNWSPlayerLastUpdateObject_SetNumberMemorizedSpellSlots(swigCPtr, nMultiClass, nSpellLevel, nNumSlots);
  }

  public void ClearSpellAddDeleteLists() {
    NWNXLibPINVOKE.CNWSPlayerLastUpdateObject_ClearSpellAddDeleteLists(swigCPtr);
  }

  public void ClearKnownSpellUsesLeft() {
    NWNXLibPINVOKE.CNWSPlayerLastUpdateObject_ClearKnownSpellUsesLeft(swigCPtr);
  }

  public byte GetKnownSpellUsesLeft(byte nMultiClass, byte nSpellLevel) {
    byte retVal = NWNXLibPINVOKE.CNWSPlayerLastUpdateObject_GetKnownSpellUsesLeft(swigCPtr, nMultiClass, nSpellLevel);
    return retVal;
  }

  public void SetKnownSpellUsesLeft(byte nMultiClass, byte nSpellLevel, byte nUses) {
    NWNXLibPINVOKE.CNWSPlayerLastUpdateObject_SetKnownSpellUsesLeft(swigCPtr, nMultiClass, nSpellLevel, nUses);
  }

  public void ClearVisibilityList() {
    NWNXLibPINVOKE.CNWSPlayerLastUpdateObject_ClearVisibilityList(swigCPtr);
  }

  public void ClearActionQueue() {
    NWNXLibPINVOKE.CNWSPlayerLastUpdateObject_ClearActionQueue(swigCPtr);
  }

  public void ClearAutoMapData() {
    NWNXLibPINVOKE.CNWSPlayerLastUpdateObject_ClearAutoMapData(swigCPtr);
  }

  public void ResetAutoMapData(uint oidArea) {
    NWNXLibPINVOKE.CNWSPlayerLastUpdateObject_ResetAutoMapData(swigCPtr, oidArea);
  }

  public int InitializeAutoMapData() {
    int retVal = NWNXLibPINVOKE.CNWSPlayerLastUpdateObject_InitializeAutoMapData(swigCPtr);
    return retVal;
  }

  public void ClearEffectIcons() {
    NWNXLibPINVOKE.CNWSPlayerLastUpdateObject_ClearEffectIcons(swigCPtr);
  }

}

}

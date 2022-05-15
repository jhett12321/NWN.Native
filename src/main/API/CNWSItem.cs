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

public unsafe class CNWSItem : CNWSObject, ICNWItem {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;

  internal CNWSItem(global::System.IntPtr cPtr, bool cMemoryOwn) : base(NWNXLibPINVOKE.CNWSItem_SWIGUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(CNWSItem obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  protected override void Dispose(bool disposing) {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          NWNXLibPINVOKE.delete_CNWSItem(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      base.Dispose(disposing);
    }
  }

  [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
  global::System.Runtime.InteropServices.HandleRef ICNWItem.GetInterfaceCPtr() {
    return new global::System.Runtime.InteropServices.HandleRef(this, NWNXLibPINVOKE.CNWSItem_ICNWItem_GetInterfaceCPtr(swigCPtr.Handle));
  }
/*@SWIG:/__w/NWN.Native/NWN.Native/nwnx/Plugins/SWIG/SWIG_DotNET/DotNETExtensions.i,1,SWIG_DOTNET_EXTENSIONS@*/
  public global::System.IntPtr Pointer {
    get {
      return swigCPtr.Handle;
    }
  }

  public static unsafe implicit operator void*(CNWSItem self) {
    return (void*)self.swigCPtr.Handle;
  }

  public static unsafe CNWSItem FromPointer(void* pointer, bool memoryOwn = false) {
    return pointer != null ? new CNWSItem((global::System.IntPtr)pointer, memoryOwn) : null;
  }

  public static CNWSItem FromPointer(global::System.IntPtr pointer, bool memoryOwn = false) {
    return pointer != global::System.IntPtr.Zero ? new CNWSItem(pointer, memoryOwn) : null;
  }

  public bool Equals(CNWSItem other) {
    if (ReferenceEquals(null, other)) {
      return false;
    }

    if (ReferenceEquals(this, other)) {
      return true;
    }

    return Pointer.Equals(other.Pointer);
  }

  public override bool Equals(object obj) {
    return ReferenceEquals(this, obj) || obj is CNWSItem other && Equals(other);
  }

  public override int GetHashCode() {
    return swigCPtr.Handle.GetHashCode();
  }

  public static bool operator ==(CNWSItem left, CNWSItem right) {
    return Equals(left, right);
  }

  public static bool operator !=(CNWSItem left, CNWSItem right) {
    return !Equals(left, right);
  }
/*@SWIG@*/
  public byte m_nLastUsedActiveProperties {
    set {
      NWNXLibPINVOKE.CNWSItem_m_nLastUsedActiveProperties_set(swigCPtr, value);
    } 
    get {
      byte retVal = NWNXLibPINVOKE.CNWSItem_m_nLastUsedActiveProperties_get(swigCPtr);
      return retVal;
    }

  }

  public NativeArray<byte> m_pLastUsedActivePropertyUsesLeft {
    set {
      NWNXLibPINVOKE.CNWSItem_m_pLastUsedActivePropertyUsesLeft_set(swigCPtr, value);
    } 
    get {
      global::System.IntPtr arrayPtr = NWNXLibPINVOKE.CNWSItem_m_pLastUsedActivePropertyUsesLeft_get(swigCPtr);
      NativeArray<byte> retVal = new NativeArray<byte>(arrayPtr, 8);

      return retVal; // byte[8]
    }

  }

  public int m_nArmorValue {
    set {
      NWNXLibPINVOKE.CNWSItem_m_nArmorValue_set(swigCPtr, value);
    } 
    get {
      int retVal = NWNXLibPINVOKE.CNWSItem_m_nArmorValue_get(swigCPtr);
      return retVal;
    }

  }

  public int m_bIdentified {
    set {
      NWNXLibPINVOKE.CNWSItem_m_bIdentified_set(swigCPtr, value);
    } 
    get {
      int retVal = NWNXLibPINVOKE.CNWSItem_m_bIdentified_get(swigCPtr);
      return retVal;
    }

  }

  public uint m_nOpenCount {
    set {
      NWNXLibPINVOKE.CNWSItem_m_nOpenCount_set(swigCPtr, value);
    } 
    get {
      uint retVal = NWNXLibPINVOKE.CNWSItem_m_nOpenCount_get(swigCPtr);
      return retVal;
    }

  }

  public CExoArrayListCNWItemProperty m_lstActiveProperties {
    set {
      NWNXLibPINVOKE.CNWSItem_m_lstActiveProperties_set(swigCPtr, CExoArrayListCNWItemProperty.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = NWNXLibPINVOKE.CNWSItem_m_lstActiveProperties_get(swigCPtr);
      CExoArrayListCNWItemProperty ret = (cPtr == global::System.IntPtr.Zero) ? null : new CExoArrayListCNWItemProperty(cPtr, false);
      return ret;
    } 
  }

  public CExoArrayListCNWItemProperty m_lstPassiveProperties {
    set {
      NWNXLibPINVOKE.CNWSItem_m_lstPassiveProperties_set(swigCPtr, CExoArrayListCNWItemProperty.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = NWNXLibPINVOKE.CNWSItem_m_lstPassiveProperties_get(swigCPtr);
      CExoArrayListCNWItemProperty ret = (cPtr == global::System.IntPtr.Zero) ? null : new CExoArrayListCNWItemProperty(cPtr, false);
      return ret;
    } 
  }

  public int m_nNumCharges {
    set {
      NWNXLibPINVOKE.CNWSItem_m_nNumCharges_set(swigCPtr, value);
    } 
    get {
      int retVal = NWNXLibPINVOKE.CNWSItem_m_nNumCharges_get(swigCPtr);
      return retVal;
    }

  }

  public uint m_nBaseUnitCost {
    set {
      NWNXLibPINVOKE.CNWSItem_m_nBaseUnitCost_set(swigCPtr, value);
    } 
    get {
      uint retVal = NWNXLibPINVOKE.CNWSItem_m_nBaseUnitCost_get(swigCPtr);
      return retVal;
    }

  }

  public uint m_nUnidentifiedCost {
    set {
      NWNXLibPINVOKE.CNWSItem_m_nUnidentifiedCost_set(swigCPtr, value);
    } 
    get {
      uint retVal = NWNXLibPINVOKE.CNWSItem_m_nUnidentifiedCost_get(swigCPtr);
      return retVal;
    }

  }

  public int m_nAdditionalCost {
    set {
      NWNXLibPINVOKE.CNWSItem_m_nAdditionalCost_set(swigCPtr, value);
    } 
    get {
      int retVal = NWNXLibPINVOKE.CNWSItem_m_nAdditionalCost_get(swigCPtr);
      return retVal;
    }

  }

  public int m_bRecalculateCost {
    set {
      NWNXLibPINVOKE.CNWSItem_m_bRecalculateCost_set(swigCPtr, value);
    } 
    get {
      int retVal = NWNXLibPINVOKE.CNWSItem_m_bRecalculateCost_get(swigCPtr);
      return retVal;
    }

  }

  public NativeArray<byte> m_nModelPart {
    set {
      NWNXLibPINVOKE.CNWSItem_m_nModelPart_set(swigCPtr, value);
    } 
    get {
      global::System.IntPtr arrayPtr = NWNXLibPINVOKE.CNWSItem_m_nModelPart_get(swigCPtr);
      NativeArray<byte> retVal = new NativeArray<byte>(arrayPtr, 3);

      return retVal; // byte[3]
    }

  }

  public NativeArray<byte> m_nArmorModelPart {
    set {
      NWNXLibPINVOKE.CNWSItem_m_nArmorModelPart_set(swigCPtr, value);
    } 
    get {
      global::System.IntPtr arrayPtr = NWNXLibPINVOKE.CNWSItem_m_nArmorModelPart_get(swigCPtr);
      NativeArray<byte> retVal = new NativeArray<byte>(arrayPtr, 19);

      return retVal; // byte[19]
    }

  }

  public NativeArray<byte> m_nUnalteredArmorModelPart {
    set {
      NWNXLibPINVOKE.CNWSItem_m_nUnalteredArmorModelPart_set(swigCPtr, value);
    } 
    get {
      global::System.IntPtr arrayPtr = NWNXLibPINVOKE.CNWSItem_m_nUnalteredArmorModelPart_get(swigCPtr);
      NativeArray<byte> retVal = new NativeArray<byte>(arrayPtr, 19);

      return retVal; // byte[19]
    }

  }

  public uint m_oidPossessor {
    set {
      NWNXLibPINVOKE.CNWSItem_m_oidPossessor_set(swigCPtr, value);
    } 
    get {
      uint retVal = NWNXLibPINVOKE.CNWSItem_m_oidPossessor_get(swigCPtr);
      return retVal;
    }

  }

  public CItemRepository m_pItemRepository {
    set {
      NWNXLibPINVOKE.CNWSItem_m_pItemRepository_set(swigCPtr, CItemRepository.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = NWNXLibPINVOKE.CNWSItem_m_pItemRepository_get(swigCPtr);
      CItemRepository ret = (cPtr == global::System.IntPtr.Zero) ? null : new CItemRepository(cPtr, false);
      return ret;
    } 
  }

  public byte m_nRepositoryPositionX {
    set {
      NWNXLibPINVOKE.CNWSItem_m_nRepositoryPositionX_set(swigCPtr, value);
    } 
    get {
      byte retVal = NWNXLibPINVOKE.CNWSItem_m_nRepositoryPositionX_get(swigCPtr);
      return retVal;
    }

  }

  public byte m_nRepositoryPositionY {
    set {
      NWNXLibPINVOKE.CNWSItem_m_nRepositoryPositionY_set(swigCPtr, value);
    } 
    get {
      byte retVal = NWNXLibPINVOKE.CNWSItem_m_nRepositoryPositionY_get(swigCPtr);
      return retVal;
    }

  }

  public CExoLocString m_sIdentifiedDescription {
    set {
      NWNXLibPINVOKE.CNWSItem_m_sIdentifiedDescription_set(swigCPtr, CExoLocString.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = NWNXLibPINVOKE.CNWSItem_m_sIdentifiedDescription_get(swigCPtr);
      CExoLocString ret = (cPtr == global::System.IntPtr.Zero) ? null : new CExoLocString(cPtr, false);
      return ret;
    } 
  }

  public CExoLocString m_sUnidentifiedDescription {
    set {
      NWNXLibPINVOKE.CNWSItem_m_sUnidentifiedDescription_set(swigCPtr, CExoLocString.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = NWNXLibPINVOKE.CNWSItem_m_sUnidentifiedDescription_get(swigCPtr);
      CExoLocString ret = (cPtr == global::System.IntPtr.Zero) ? null : new CExoLocString(cPtr, false);
      return ret;
    } 
  }

  public CExoString m_sIdentifiedDescriptionOverride {
    set {
      NWNXLibPINVOKE.CNWSItem_m_sIdentifiedDescriptionOverride_set(swigCPtr, CExoString.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = NWNXLibPINVOKE.CNWSItem_m_sIdentifiedDescriptionOverride_get(swigCPtr);
      CExoString ret = (cPtr == global::System.IntPtr.Zero) ? null : new CExoString(cPtr, false);
      return ret;
    } 
  }

  public CExoString m_sUnidentifiedDescriptionOverride {
    set {
      NWNXLibPINVOKE.CNWSItem_m_sUnidentifiedDescriptionOverride_set(swigCPtr, CExoString.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = NWNXLibPINVOKE.CNWSItem_m_sUnidentifiedDescriptionOverride_get(swigCPtr);
      CExoString ret = (cPtr == global::System.IntPtr.Zero) ? null : new CExoString(cPtr, false);
      return ret;
    } 
  }

  public CExoLocString m_sName {
    set {
      NWNXLibPINVOKE.CNWSItem_m_sName_set(swigCPtr, CExoLocString.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = NWNXLibPINVOKE.CNWSItem_m_sName_get(swigCPtr);
      CExoLocString ret = (cPtr == global::System.IntPtr.Zero) ? null : new CExoLocString(cPtr, false);
      return ret;
    } 
  }

  public CExoString m_sDisplayName {
    set {
      NWNXLibPINVOKE.CNWSItem_m_sDisplayName_set(swigCPtr, CExoString.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = NWNXLibPINVOKE.CNWSItem_m_sDisplayName_get(swigCPtr);
      CExoString ret = (cPtr == global::System.IntPtr.Zero) ? null : new CExoString(cPtr, false);
      return ret;
    } 
  }

  public int m_nUpdateDisplayNameSeq {
    set {
      NWNXLibPINVOKE.CNWSItem_m_nUpdateDisplayNameSeq_set(swigCPtr, value);
    } 
    get {
      int retVal = NWNXLibPINVOKE.CNWSItem_m_nUpdateDisplayNameSeq_get(swigCPtr);
      return retVal;
    }

  }

  public int m_bInfinite {
    set {
      NWNXLibPINVOKE.CNWSItem_m_bInfinite_set(swigCPtr, value);
    } 
    get {
      int retVal = NWNXLibPINVOKE.CNWSItem_m_bInfinite_get(swigCPtr);
      return retVal;
    }

  }

  public int m_bDroppable {
    set {
      NWNXLibPINVOKE.CNWSItem_m_bDroppable_set(swigCPtr, value);
    } 
    get {
      int retVal = NWNXLibPINVOKE.CNWSItem_m_bDroppable_get(swigCPtr);
      return retVal;
    }

  }

  public int m_bPickPocketable {
    set {
      NWNXLibPINVOKE.CNWSItem_m_bPickPocketable_set(swigCPtr, value);
    } 
    get {
      int retVal = NWNXLibPINVOKE.CNWSItem_m_bPickPocketable_get(swigCPtr);
      return retVal;
    }

  }

  public int m_bCursed {
    set {
      NWNXLibPINVOKE.CNWSItem_m_bCursed_set(swigCPtr, value);
    } 
    get {
      int retVal = NWNXLibPINVOKE.CNWSItem_m_bCursed_get(swigCPtr);
      return retVal;
    }

  }

  public int m_nStackSize {
    set {
      NWNXLibPINVOKE.CNWSItem_m_nStackSize_set(swigCPtr, value);
    } 
    get {
      int retVal = NWNXLibPINVOKE.CNWSItem_m_nStackSize_get(swigCPtr);
      return retVal;
    }

  }

  public int m_bStolen {
    set {
      NWNXLibPINVOKE.CNWSItem_m_bStolen_set(swigCPtr, value);
    } 
    get {
      int retVal = NWNXLibPINVOKE.CNWSItem_m_bStolen_get(swigCPtr);
      return retVal;
    }

  }

  public int m_nWeight {
    set {
      NWNXLibPINVOKE.CNWSItem_m_nWeight_set(swigCPtr, value);
    } 
    get {
      int retVal = NWNXLibPINVOKE.CNWSItem_m_nWeight_get(swigCPtr);
      return retVal;
    }

  }

  public ushort m_nRepositoryArrayIndex {
    set {
      NWNXLibPINVOKE.CNWSItem_m_nRepositoryArrayIndex_set(swigCPtr, value);
    } 
    get {
      ushort retVal = NWNXLibPINVOKE.CNWSItem_m_nRepositoryArrayIndex_get(swigCPtr);
      return retVal;
    }

  }

  public byte m_nVisualEffect {
    set {
      NWNXLibPINVOKE.CNWSItem_m_nVisualEffect_set(swigCPtr, value);
    } 
    get {
      byte retVal = NWNXLibPINVOKE.CNWSItem_m_nVisualEffect_get(swigCPtr);
      return retVal;
    }

  }

  public uint m_oidBarterOwner {
    set {
      NWNXLibPINVOKE.CNWSItem_m_oidBarterOwner_set(swigCPtr, value);
    } 
    get {
      uint retVal = NWNXLibPINVOKE.CNWSItem_m_oidBarterOwner_get(swigCPtr);
      return retVal;
    }

  }

  public int m_bHidden {
    set {
      NWNXLibPINVOKE.CNWSItem_m_bHidden_set(swigCPtr, value);
    } 
    get {
      int retVal = NWNXLibPINVOKE.CNWSItem_m_bHidden_get(swigCPtr);
      return retVal;
    }

  }

  public int m_nUpdateHiddenSeq {
    set {
      NWNXLibPINVOKE.CNWSItem_m_nUpdateHiddenSeq_set(swigCPtr, value);
    } 
    get {
      int retVal = NWNXLibPINVOKE.CNWSItem_m_nUpdateHiddenSeq_get(swigCPtr);
      return retVal;
    }

  }

  public CNWSItem(uint oidID) : this(NWNXLibPINVOKE.new_CNWSItem__SWIG_0(oidID), true) {
  }

  public CNWSItem() : this(NWNXLibPINVOKE.new_CNWSItem__SWIG_1(), true) {
  }

  public void AddToArea(CNWSArea pArea, float fX, float fY, float fZ, int bRunScripts) {
    NWNXLibPINVOKE.CNWSItem_AddToArea__SWIG_0(swigCPtr, CNWSArea.getCPtr(pArea), fX, fY, fZ, bRunScripts);
  }

  public void AddToArea(CNWSArea pArea, float fX, float fY, float fZ) {
    NWNXLibPINVOKE.CNWSItem_AddToArea__SWIG_1(swigCPtr, CNWSArea.getCPtr(pArea), fX, fY, fZ);
  }

  public override void AIUpdate() {
    NWNXLibPINVOKE.CNWSItem_AIUpdate(swigCPtr);
  }

  public override CNWSItem AsNWSItem() {
    global::System.IntPtr cPtr = NWNXLibPINVOKE.CNWSItem_AsNWSItem(swigCPtr);
    CNWSItem ret = (cPtr == global::System.IntPtr.Zero) ? null : new CNWSItem(cPtr, false);
    return ret;
  }

  public override void EventHandler(uint nEventId, uint nCallerObjectId, void* pScript, uint nCalendarDay, uint nTimeOfDay) {
    NWNXLibPINVOKE.CNWSItem_EventHandler(swigCPtr, nEventId, nCallerObjectId, (global::System.IntPtr)pScript, nCalendarDay, nTimeOfDay);
  }

  public void InitRepository(uint nObjectID) {
    NWNXLibPINVOKE.CNWSItem_InitRepository(swigCPtr, nObjectID);
  }

  public int LoadFromTemplate(CResRef cResRef, CExoString pTag) {
    int retVal = NWNXLibPINVOKE.CNWSItem_LoadFromTemplate__SWIG_0(swigCPtr, CResRef.getCPtr(cResRef), CExoString.getCPtr(pTag));
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
    return retVal;
  }

  public int LoadFromTemplate(CResRef cResRef) {
    int retVal = NWNXLibPINVOKE.CNWSItem_LoadFromTemplate__SWIG_1(swigCPtr, CResRef.getCPtr(cResRef));
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
    return retVal;
  }

  public int LoadItem(CResGFF pRes, CResStruct cItemStruct, int bLoadOID, int bIsInsideAContainer) {
    int retVal = NWNXLibPINVOKE.CNWSItem_LoadItem__SWIG_0(swigCPtr, CResGFF.getCPtr(pRes), CResStruct.getCPtr(cItemStruct), bLoadOID, bIsInsideAContainer);
    return retVal;
  }

  public int LoadItem(CResGFF pRes, CResStruct cItemStruct, int bLoadOID) {
    int retVal = NWNXLibPINVOKE.CNWSItem_LoadItem__SWIG_1(swigCPtr, CResGFF.getCPtr(pRes), CResStruct.getCPtr(cItemStruct), bLoadOID);
    return retVal;
  }

  public void ComputeWeight() {
    NWNXLibPINVOKE.CNWSItem_ComputeWeight(swigCPtr);
  }

  public int SaveItem(CResGFF pRes, CResStruct pStruct, int bExportingChar) {
    int retVal = NWNXLibPINVOKE.CNWSItem_SaveItem__SWIG_0(swigCPtr, CResGFF.getCPtr(pRes), CResStruct.getCPtr(pStruct), bExportingChar);
    return retVal;
  }

  public int SaveItem(CResGFF pRes, CResStruct pStruct) {
    int retVal = NWNXLibPINVOKE.CNWSItem_SaveItem__SWIG_1(swigCPtr, CResGFF.getCPtr(pRes), CResStruct.getCPtr(pStruct));
    return retVal;
  }

  public int AcquireItem(void** pItem, uint oidPossessor, byte x, byte y, int bDisplayFeedback) {
    int retVal = NWNXLibPINVOKE.CNWSItem_AcquireItem__SWIG_0(swigCPtr, (global::System.IntPtr)pItem, oidPossessor, x, y, bDisplayFeedback);
    return retVal;
  }

  public int AcquireItem(void** pItem, uint oidPossessor, byte x, byte y) {
    int retVal = NWNXLibPINVOKE.CNWSItem_AcquireItem__SWIG_1(swigCPtr, (global::System.IntPtr)pItem, oidPossessor, x, y);
    return retVal;
  }

  public int AcquireItem(void** pItem, uint oidPossessor, byte x) {
    int retVal = NWNXLibPINVOKE.CNWSItem_AcquireItem__SWIG_2(swigCPtr, (global::System.IntPtr)pItem, oidPossessor, x);
    return retVal;
  }

  public int AcquireItem(void** pItem, uint oidPossessor) {
    int retVal = NWNXLibPINVOKE.CNWSItem_AcquireItem__SWIG_3(swigCPtr, (global::System.IntPtr)pItem, oidPossessor);
    return retVal;
  }

  public int AcquireItem(void** pItem) {
    int retVal = NWNXLibPINVOKE.CNWSItem_AcquireItem__SWIG_4(swigCPtr, (global::System.IntPtr)pItem);
    return retVal;
  }

  public int SaveContainerItems(CResGFF pRes, CResStruct pStruct, int bExportingChar) {
    int retVal = NWNXLibPINVOKE.CNWSItem_SaveContainerItems(swigCPtr, CResGFF.getCPtr(pRes), CResStruct.getCPtr(pStruct), bExportingChar);
    return retVal;
  }

  public int SaveItemProperties(CResGFF pRes, CResStruct pStruct) {
    int retVal = NWNXLibPINVOKE.CNWSItem_SaveItemProperties(swigCPtr, CResGFF.getCPtr(pRes), CResStruct.getCPtr(pStruct));
    return retVal;
  }

  public int LoadDataFromGff(CResGFF pRes, CResStruct pCreatureStruct, int bLoadOID, int bIsInsideAContainer) {
    int retVal = NWNXLibPINVOKE.CNWSItem_LoadDataFromGff__SWIG_0(swigCPtr, CResGFF.getCPtr(pRes), CResStruct.getCPtr(pCreatureStruct), bLoadOID, bIsInsideAContainer);
    return retVal;
  }

  public int LoadDataFromGff(CResGFF pRes, CResStruct pCreatureStruct, int bLoadOID) {
    int retVal = NWNXLibPINVOKE.CNWSItem_LoadDataFromGff__SWIG_1(swigCPtr, CResGFF.getCPtr(pRes), CResStruct.getCPtr(pCreatureStruct), bLoadOID);
    return retVal;
  }

  public void RemoveFromArea() {
    NWNXLibPINVOKE.CNWSItem_RemoveFromArea(swigCPtr);
  }

  public void SetPossessor(uint oidPossessor, int bRunScripts, int bDisplayFeedback, int nStackSize) {
    NWNXLibPINVOKE.CNWSItem_SetPossessor__SWIG_0(swigCPtr, oidPossessor, bRunScripts, bDisplayFeedback, nStackSize);
  }

  public void SetPossessor(uint oidPossessor, int bRunScripts, int bDisplayFeedback) {
    NWNXLibPINVOKE.CNWSItem_SetPossessor__SWIG_1(swigCPtr, oidPossessor, bRunScripts, bDisplayFeedback);
  }

  public void OpenInventory(uint oidOpener) {
    NWNXLibPINVOKE.CNWSItem_OpenInventory(swigCPtr, oidOpener);
  }

  public void CloseInventory(uint oidCloser, int bUpdatePlayer) {
    NWNXLibPINVOKE.CNWSItem_CloseInventory__SWIG_0(swigCPtr, oidCloser, bUpdatePlayer);
  }

  public void CloseInventory(uint oidCloser) {
    NWNXLibPINVOKE.CNWSItem_CloseInventory__SWIG_1(swigCPtr, oidCloser);
  }

  public int CopyItem(CNWSItem pSourceItem, int bCopyVars) {
    int retVal = NWNXLibPINVOKE.CNWSItem_CopyItem__SWIG_0(swigCPtr, CNWSItem.getCPtr(pSourceItem), bCopyVars);
    return retVal;
  }

  public int CopyItem(CNWSItem pSourceItem) {
    int retVal = NWNXLibPINVOKE.CNWSItem_CopyItem__SWIG_1(swigCPtr, CNWSItem.getCPtr(pSourceItem));
    return retVal;
  }

  public void ReadContainerItemsFromGff(CResGFF pRes, CResStruct pGffItemStruct, int bLoadOID) {
    NWNXLibPINVOKE.CNWSItem_ReadContainerItemsFromGff(swigCPtr, CResGFF.getCPtr(pRes), CResStruct.getCPtr(pGffItemStruct), bLoadOID);
  }

  public uint GetCost(int bIncludeStackSize, int bIdentifiedCost, int bUseILRStackSize, int bIgnorePlotFlag) {
    uint retVal = NWNXLibPINVOKE.CNWSItem_GetCost__SWIG_0(swigCPtr, bIncludeStackSize, bIdentifiedCost, bUseILRStackSize, bIgnorePlotFlag);
    return retVal;
  }

  public uint GetCost(int bIncludeStackSize, int bIdentifiedCost, int bUseILRStackSize) {
    uint retVal = NWNXLibPINVOKE.CNWSItem_GetCost__SWIG_1(swigCPtr, bIncludeStackSize, bIdentifiedCost, bUseILRStackSize);
    return retVal;
  }

  public uint GetCost(int bIncludeStackSize, int bIdentifiedCost) {
    uint retVal = NWNXLibPINVOKE.CNWSItem_GetCost__SWIG_2(swigCPtr, bIncludeStackSize, bIdentifiedCost);
    return retVal;
  }

  public uint GetCost(int bIncludeStackSize) {
    uint retVal = NWNXLibPINVOKE.CNWSItem_GetCost__SWIG_3(swigCPtr, bIncludeStackSize);
    return retVal;
  }

  public uint GetCost() {
    uint retVal = NWNXLibPINVOKE.CNWSItem_GetCost__SWIG_4(swigCPtr);
    return retVal;
  }

  public void SetIdentified(int bIdentified) {
    NWNXLibPINVOKE.CNWSItem_SetIdentified(swigCPtr, bIdentified);
  }

  public int ComputeArmorClass() {
    int retVal = NWNXLibPINVOKE.CNWSItem_ComputeArmorClass(swigCPtr);
    return retVal;
  }

  public ushort GetDamageFlags() {
    ushort retVal = NWNXLibPINVOKE.CNWSItem_GetDamageFlags(swigCPtr);
    return retVal;
  }

  public int MergeItem(CNWSItem pItemToMerge) {
    int retVal = NWNXLibPINVOKE.CNWSItem_MergeItem(swigCPtr, CNWSItem.getCPtr(pItemToMerge));
    return retVal;
  }

  public CNWSItem SplitItem(int nNumberToSplitOff) {
    global::System.IntPtr cPtr = NWNXLibPINVOKE.CNWSItem_SplitItem(swigCPtr, nNumberToSplitOff);
    CNWSItem ret = (cPtr == global::System.IntPtr.Zero) ? null : new CNWSItem(cPtr, false);
    return ret;
  }

  public void SetNumCharges(int nNumCharges, int bUpdateActiveProperties) {
    NWNXLibPINVOKE.CNWSItem_SetNumCharges__SWIG_0(swigCPtr, nNumCharges, bUpdateActiveProperties);
  }

  public void SetNumCharges(int nNumCharges) {
    NWNXLibPINVOKE.CNWSItem_SetNumCharges__SWIG_1(swigCPtr, nNumCharges);
  }

  public ushort GetUsedActivePropertyUsesLeft(byte nProperty) {
    ushort retVal = NWNXLibPINVOKE.CNWSItem_GetUsedActivePropertyUsesLeft(swigCPtr, nProperty);
    return retVal;
  }

  public void UpdateUsedActiveProperties(int bSendFullList) {
    NWNXLibPINVOKE.CNWSItem_UpdateUsedActiveProperties__SWIG_0(swigCPtr, bSendFullList);
  }

  public void UpdateUsedActiveProperties() {
    NWNXLibPINVOKE.CNWSItem_UpdateUsedActiveProperties__SWIG_1(swigCPtr);
  }

  public void RestoreUsedActiveProperties(int bLoading) {
    NWNXLibPINVOKE.CNWSItem_RestoreUsedActiveProperties(swigCPtr, bLoading);
  }

  public void RestoreUsedActiveProperty(CNWItemProperty pProperty, int bLoading) {
    NWNXLibPINVOKE.CNWSItem_RestoreUsedActiveProperty(swigCPtr, CNWItemProperty.getCPtr(pProperty), bLoading);
  }

  public int ActiveProperty(ushort nPropertyName) {
    int retVal = NWNXLibPINVOKE.CNWSItem_ActiveProperty(swigCPtr, nPropertyName);
    return retVal;
  }

  public void AddActiveProperty(CNWItemProperty cNewProperty) {
    NWNXLibPINVOKE.CNWSItem_AddActiveProperty(swigCPtr, CNWItemProperty.getCPtr(cNewProperty));
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
  }

  public int RemoveActiveProperty(int nIndex) {
    int retVal = NWNXLibPINVOKE.CNWSItem_RemoveActiveProperty(swigCPtr, nIndex);
    return retVal;
  }

  public void AddPassiveProperty(CNWItemProperty cNewProperty) {
    NWNXLibPINVOKE.CNWSItem_AddPassiveProperty(swigCPtr, CNWItemProperty.getCPtr(cNewProperty));
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
  }

  public int RemovePassiveProperty(int nIndex) {
    int retVal = NWNXLibPINVOKE.CNWSItem_RemovePassiveProperty(swigCPtr, nIndex);
    return retVal;
  }

  public CNWItemProperty GetActiveProperty(int nIndex) {
    global::System.IntPtr cPtr = NWNXLibPINVOKE.CNWSItem_GetActiveProperty(swigCPtr, nIndex);
    CNWItemProperty ret = (cPtr == global::System.IntPtr.Zero) ? null : new CNWItemProperty(cPtr, false);
    return ret;
  }

  public CNWItemProperty GetPassiveProperty(int nIndex) {
    global::System.IntPtr cPtr = NWNXLibPINVOKE.CNWSItem_GetPassiveProperty(swigCPtr, nIndex);
    CNWItemProperty ret = (cPtr == global::System.IntPtr.Zero) ? null : new CNWItemProperty(cPtr, false);
    return ret;
  }

  public int GetPropertyByTypeExists(ushort nPropertyName, ushort nSubType) {
    int retVal = NWNXLibPINVOKE.CNWSItem_GetPropertyByTypeExists__SWIG_0(swigCPtr, nPropertyName, nSubType);
    return retVal;
  }

  public int GetPropertyByTypeExists(ushort nPropertyName) {
    int retVal = NWNXLibPINVOKE.CNWSItem_GetPropertyByTypeExists__SWIG_1(swigCPtr, nPropertyName);
    return retVal;
  }

  public int GetPropertyByType(void** ppcItemProperty, ushort nPropertyName, ushort nSubType) {
    int retVal = NWNXLibPINVOKE.CNWSItem_GetPropertyByType__SWIG_0(swigCPtr, (global::System.IntPtr)ppcItemProperty, nPropertyName, nSubType);
    return retVal;
  }

  public int GetPropertyByType(void** ppcItemProperty, ushort nPropertyName) {
    int retVal = NWNXLibPINVOKE.CNWSItem_GetPropertyByType__SWIG_1(swigCPtr, (global::System.IntPtr)ppcItemProperty, nPropertyName);
    return retVal;
  }

  public void ApplyItemProperties(CNWSCreature pCreature, uint nInventorySlot, int bLoadingGame) {
    NWNXLibPINVOKE.CNWSItem_ApplyItemProperties(swigCPtr, CNWSCreature.getCPtr(pCreature), nInventorySlot, bLoadingGame);
  }

  public void RemoveItemProperties(CNWSCreature pCreature, uint nInventorySlot) {
    NWNXLibPINVOKE.CNWSItem_RemoveItemProperties(swigCPtr, CNWSCreature.getCPtr(pCreature), nInventorySlot);
  }

  public int GetWeight() {
    int retVal = NWNXLibPINVOKE.CNWSItem_GetWeight(swigCPtr);
    return retVal;
  }

  public int CompareItem(CNWSItem pItemToCompare) {
    int retVal = NWNXLibPINVOKE.CNWSItem_CompareItem(swigCPtr, CNWSItem.getCPtr(pItemToCompare));
    return retVal;
  }

  public byte GetMinEquipLevel() {
    byte retVal = NWNXLibPINVOKE.CNWSItem_GetMinEquipLevel(swigCPtr);
    return retVal;
  }

  public void CloseItemForAllPlayers() {
    NWNXLibPINVOKE.CNWSItem_CloseItemForAllPlayers(swigCPtr);
  }

  public void UpdateVisualEffect() {
    NWNXLibPINVOKE.CNWSItem_UpdateVisualEffect(swigCPtr);
  }

  public void CalculateBaseCosts() {
    NWNXLibPINVOKE.CNWSItem_CalculateBaseCosts(swigCPtr);
  }

  public float CalculatePassiveCost(CNWItemProperty pItemProperty) {
    float retVal = NWNXLibPINVOKE.CNWSItem_CalculatePassiveCost(swigCPtr, CNWItemProperty.getCPtr(pItemProperty));
    return retVal;
  }

  public new void _Destructor() {
    NWNXLibPINVOKE.CNWSItem__Destructor(swigCPtr);
  }

  public NativeArray<byte> m_nLayeredTextureColors {
    set {
      NWNXLibPINVOKE.CNWSItem_m_nLayeredTextureColors_set(swigCPtr, value);
    } 
    get {
      global::System.IntPtr arrayPtr = NWNXLibPINVOKE.CNWSItem_m_nLayeredTextureColors_get(swigCPtr);
      NativeArray<byte> retVal = new NativeArray<byte>(arrayPtr, 6);

      return retVal; // byte[6]
    }

  }

  public NativeArray<global::System.IntPtr> m_pLayeredTextureColorsPerPart {
    set {
      NWNXLibPINVOKE.CNWSItem_m_pLayeredTextureColorsPerPart_set(swigCPtr, value);
    } 
    get {
      global::System.IntPtr arrayPtr = NWNXLibPINVOKE.CNWSItem_m_pLayeredTextureColorsPerPart_get(swigCPtr);
      NativeArray<global::System.IntPtr> retVal = new NativeArray<global::System.IntPtr>(arrayPtr, 6);

      return retVal; // byte*[6]
    }

  }

  public uint m_nBaseItem {
    set {
      NWNXLibPINVOKE.CNWSItem_m_nBaseItem_set(swigCPtr, value);
    } 
    get {
      uint retVal = NWNXLibPINVOKE.CNWSItem_m_nBaseItem_get(swigCPtr);
      return retVal;
    }

  }

  public byte GetLayeredTextureColorPerPart(byte nTexture, byte nPart) {
    byte retVal = NWNXLibPINVOKE.CNWSItem_GetLayeredTextureColorPerPart(swigCPtr, nTexture, nPart);
    return retVal;
  }

  public void SetLayeredTextureColorPerPart(byte nTexture, byte nPart, byte nColor) {
    NWNXLibPINVOKE.CNWSItem_SetLayeredTextureColorPerPart(swigCPtr, nTexture, nPart, nColor);
  }

}

}

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

public unsafe class CNWSStore : CNWSObject {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;

  internal CNWSStore(global::System.IntPtr cPtr, bool cMemoryOwn) : base(NWNXLibPINVOKE.CNWSStore_SWIGUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(CNWSStore obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  protected override void Dispose(bool disposing) {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          NWNXLibPINVOKE.delete_CNWSStore(swigCPtr);
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

  public static unsafe implicit operator void*(CNWSStore self) {
    return (void*)self.swigCPtr.Handle;
  }

  public static unsafe CNWSStore FromPointer(void* pointer, bool memoryOwn = false) {
    return pointer != null ? new CNWSStore((global::System.IntPtr)pointer, memoryOwn) : null;
  }

  public static CNWSStore FromPointer(global::System.IntPtr pointer, bool memoryOwn = false) {
    return pointer != global::System.IntPtr.Zero ? new CNWSStore(pointer, memoryOwn) : null;
  }

  public bool Equals(CNWSStore other) {
    if (ReferenceEquals(null, other)) {
      return false;
    }

    if (ReferenceEquals(this, other)) {
      return true;
    }

    return Pointer.Equals(other.Pointer);
  }

  public override bool Equals(object obj) {
    return ReferenceEquals(this, obj) || obj is CNWSStore other && Equals(other);
  }

  public override int GetHashCode() {
    return swigCPtr.Handle.GetHashCode();
  }

  public static bool operator ==(CNWSStore left, CNWSStore right) {
    return Equals(left, right);
  }

  public static bool operator !=(CNWSStore left, CNWSStore right) {
    return !Equals(left, right);
  }

  public CExoStringArray m_sScripts {
    set {
      NWNXLibPINVOKE.CNWSStore_m_sScripts_set(swigCPtr, CExoStringArray.getCPtr(value));
    } 
    get {
        global::System.IntPtr cPtr = NWNXLibPINVOKE.CNWSStore_m_sScripts_get(swigCPtr);;
        CExoStringArray ret = (cPtr == global::System.IntPtr.Zero) ? null : new CExoStringArray(cPtr, false);
        return ret;
    }

  }

  public CItemRepositoryPtrArray m_aInventory {
    set {
      NWNXLibPINVOKE.CNWSStore_m_aInventory_set(swigCPtr, CItemRepositoryPtrArray.getCPtr(value));
    } 
    get {
        global::System.IntPtr cPtr = NWNXLibPINVOKE.CNWSStore_m_aInventory_get(swigCPtr);;
        CItemRepositoryPtrArray ret = (cPtr == global::System.IntPtr.Zero) ? null : new CItemRepositoryPtrArray(cPtr, false);
        return ret;
    }

  }

  public CExoArrayListCStoreCustomerPtr m_aCurrentCustomers {
    set {
      NWNXLibPINVOKE.CNWSStore_m_aCurrentCustomers_set(swigCPtr, CExoArrayListCStoreCustomerPtr.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = NWNXLibPINVOKE.CNWSStore_m_aCurrentCustomers_get(swigCPtr);
      CExoArrayListCStoreCustomerPtr ret = (cPtr == global::System.IntPtr.Zero) ? null : new CExoArrayListCStoreCustomerPtr(cPtr, false);
      return ret;
    } 
  }

  public CExoLocString m_sName {
    set {
      NWNXLibPINVOKE.CNWSStore_m_sName_set(swigCPtr, CExoLocString.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = NWNXLibPINVOKE.CNWSStore_m_sName_get(swigCPtr);
      CExoLocString ret = (cPtr == global::System.IntPtr.Zero) ? null : new CExoLocString(cPtr, false);
      return ret;
    } 
  }

  public uint m_oidLastOpened {
    set {
      NWNXLibPINVOKE.CNWSStore_m_oidLastOpened_set(swigCPtr, value);
    } 
    get {
      uint retVal = NWNXLibPINVOKE.CNWSStore_m_oidLastOpened_get(swigCPtr);
      return retVal;
    }

  }

  public uint m_oidLastClosed {
    set {
      NWNXLibPINVOKE.CNWSStore_m_oidLastClosed_set(swigCPtr, value);
    } 
    get {
      uint retVal = NWNXLibPINVOKE.CNWSStore_m_oidLastClosed_get(swigCPtr);
      return retVal;
    }

  }

  public int m_bBlackMarket {
    set {
      NWNXLibPINVOKE.CNWSStore_m_bBlackMarket_set(swigCPtr, value);
    } 
    get {
      int retVal = NWNXLibPINVOKE.CNWSStore_m_bBlackMarket_get(swigCPtr);
      return retVal;
    }

  }

  public int m_nBlackMarketMarkDown {
    set {
      NWNXLibPINVOKE.CNWSStore_m_nBlackMarketMarkDown_set(swigCPtr, value);
    } 
    get {
      int retVal = NWNXLibPINVOKE.CNWSStore_m_nBlackMarketMarkDown_get(swigCPtr);
      return retVal;
    }

  }

  public int m_nMarkDown {
    set {
      NWNXLibPINVOKE.CNWSStore_m_nMarkDown_set(swigCPtr, value);
    } 
    get {
      int retVal = NWNXLibPINVOKE.CNWSStore_m_nMarkDown_get(swigCPtr);
      return retVal;
    }

  }

  public int m_nMarkUp {
    set {
      NWNXLibPINVOKE.CNWSStore_m_nMarkUp_set(swigCPtr, value);
    } 
    get {
      int retVal = NWNXLibPINVOKE.CNWSStore_m_nMarkUp_get(swigCPtr);
      return retVal;
    }

  }

  public ushort m_nRepositoryArrayIndex {
    set {
      NWNXLibPINVOKE.CNWSStore_m_nRepositoryArrayIndex_set(swigCPtr, value);
    } 
    get {
      ushort retVal = NWNXLibPINVOKE.CNWSStore_m_nRepositoryArrayIndex_get(swigCPtr);
      return retVal;
    }

  }

  public byte m_nRepositoryListNumber {
    set {
      NWNXLibPINVOKE.CNWSStore_m_nRepositoryListNumber_set(swigCPtr, value);
    } 
    get {
      byte retVal = NWNXLibPINVOKE.CNWSStore_m_nRepositoryListNumber_get(swigCPtr);
      return retVal;
    }

  }

  public int m_iGold {
    set {
      NWNXLibPINVOKE.CNWSStore_m_iGold_set(swigCPtr, value);
    } 
    get {
      int retVal = NWNXLibPINVOKE.CNWSStore_m_iGold_get(swigCPtr);
      return retVal;
    }

  }

  public int m_iIdentifyCost {
    set {
      NWNXLibPINVOKE.CNWSStore_m_iIdentifyCost_set(swigCPtr, value);
    } 
    get {
      int retVal = NWNXLibPINVOKE.CNWSStore_m_iIdentifyCost_get(swigCPtr);
      return retVal;
    }

  }

  public int m_iMaxBuyPrice {
    set {
      NWNXLibPINVOKE.CNWSStore_m_iMaxBuyPrice_set(swigCPtr, value);
    } 
    get {
      int retVal = NWNXLibPINVOKE.CNWSStore_m_iMaxBuyPrice_get(swigCPtr);
      return retVal;
    }

  }

  public CExoArrayListInt32 m_lstWillNotBuy {
    set {
      NWNXLibPINVOKE.CNWSStore_m_lstWillNotBuy_set(swigCPtr, CExoArrayListInt32.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = NWNXLibPINVOKE.CNWSStore_m_lstWillNotBuy_get(swigCPtr);
      CExoArrayListInt32 ret = (cPtr == global::System.IntPtr.Zero) ? null : new CExoArrayListInt32(cPtr, false);
      return ret;
    } 
  }

  public CExoArrayListInt32 m_lstWillOnlyBuy {
    set {
      NWNXLibPINVOKE.CNWSStore_m_lstWillOnlyBuy_set(swigCPtr, CExoArrayListInt32.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = NWNXLibPINVOKE.CNWSStore_m_lstWillOnlyBuy_get(swigCPtr);
      CExoArrayListInt32 ret = (cPtr == global::System.IntPtr.Zero) ? null : new CExoArrayListInt32(cPtr, false);
      return ret;
    } 
  }

  public CNWSStore(uint oidId) : this(NWNXLibPINVOKE.new_CNWSStore__SWIG_0(oidId), true) {
  }

  public CNWSStore() : this(NWNXLibPINVOKE.new_CNWSStore__SWIG_1(), true) {
  }

  public override CNWSStore AsNWSStore() {
    global::System.IntPtr cPtr = NWNXLibPINVOKE.CNWSStore_AsNWSStore(swigCPtr);
    CNWSStore ret = (cPtr == global::System.IntPtr.Zero) ? null : new CNWSStore(cPtr, false);
    return ret;
  }

  public int LoadFromTemplate(CResRef cResRef, CExoString pTag) {
    int retVal = NWNXLibPINVOKE.CNWSStore_LoadFromTemplate__SWIG_0(swigCPtr, CResRef.getCPtr(cResRef), CExoString.getCPtr(pTag));
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
    return retVal;
  }

  public int LoadFromTemplate(CResRef cResRef) {
    int retVal = NWNXLibPINVOKE.CNWSStore_LoadFromTemplate__SWIG_1(swigCPtr, CResRef.getCPtr(cResRef));
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
    return retVal;
  }

  public int LoadStore(CResGFF pRes, CResStruct cStoreStruct, int bLoadOID, CExoString pTag) {
    int retVal = NWNXLibPINVOKE.CNWSStore_LoadStore__SWIG_0(swigCPtr, CResGFF.getCPtr(pRes), CResStruct.getCPtr(cStoreStruct), bLoadOID, CExoString.getCPtr(pTag));
    return retVal;
  }

  public int LoadStore(CResGFF pRes, CResStruct cStoreStruct, int bLoadOID) {
    int retVal = NWNXLibPINVOKE.CNWSStore_LoadStore__SWIG_1(swigCPtr, CResGFF.getCPtr(pRes), CResStruct.getCPtr(cStoreStruct), bLoadOID);
    return retVal;
  }

  public int SaveStore(CResGFF pRes, CResStruct pStruct, int bSaveOIDs) {
    int retVal = NWNXLibPINVOKE.CNWSStore_SaveStore(swigCPtr, CResGFF.getCPtr(pRes), CResStruct.getCPtr(pStruct), bSaveOIDs);
    return retVal;
  }

  public void AddToArea(CNWSArea pArea, float fX, float fY, float fZ, int bRunScripts) {
    NWNXLibPINVOKE.CNWSStore_AddToArea__SWIG_0(swigCPtr, CNWSArea.getCPtr(pArea), fX, fY, fZ, bRunScripts);
  }

  public void AddToArea(CNWSArea pArea, float fX, float fY, float fZ) {
    NWNXLibPINVOKE.CNWSStore_AddToArea__SWIG_1(swigCPtr, CNWSArea.getCPtr(pArea), fX, fY, fZ);
  }

  public void RemoveFromArea() {
    NWNXLibPINVOKE.CNWSStore_RemoveFromArea(swigCPtr);
  }

  public override void AIUpdate() {
    NWNXLibPINVOKE.CNWSStore_AIUpdate(swigCPtr);
  }

  public override void EventHandler(uint nEventId, uint nCallerObjectId, void* pScript, uint nCalendarDay, uint nTimeOfDay) {
    NWNXLibPINVOKE.CNWSStore_EventHandler(swigCPtr, nEventId, nCallerObjectId, (global::System.IntPtr)pScript, nCalendarDay, nTimeOfDay);
  }

  public int GetIsRestrictedBuyItem(int nBaseItemID) {
    int retVal = NWNXLibPINVOKE.CNWSStore_GetIsRestrictedBuyItem(swigCPtr, nBaseItemID);
    return retVal;
  }

  public CStoreCustomer GetCustomer(uint oidPlayer) {
    global::System.IntPtr cPtr = NWNXLibPINVOKE.CNWSStore_GetCustomer(swigCPtr, oidPlayer);
    CStoreCustomer ret = (cPtr == global::System.IntPtr.Zero) ? null : new CStoreCustomer(cPtr, false);
    return ret;
  }

  public void AddCustomer(CNWSPlayer pPlayer, byte nMarkUp, byte nMarkDown) {
    NWNXLibPINVOKE.CNWSStore_AddCustomer__SWIG_0(swigCPtr, CNWSPlayer.getCPtr(pPlayer), nMarkUp, nMarkDown);
  }

  public void AddCustomer(CNWSPlayer pPlayer, byte nMarkUp) {
    NWNXLibPINVOKE.CNWSStore_AddCustomer__SWIG_1(swigCPtr, CNWSPlayer.getCPtr(pPlayer), nMarkUp);
  }

  public void AddCustomer(CNWSPlayer pPlayer) {
    NWNXLibPINVOKE.CNWSStore_AddCustomer__SWIG_2(swigCPtr, CNWSPlayer.getCPtr(pPlayer));
  }

  public void RemoveCustomer(CNWSPlayer pPlayer) {
    NWNXLibPINVOKE.CNWSStore_RemoveCustomer(swigCPtr, CNWSPlayer.getCPtr(pPlayer));
  }

  public short GetCustomerSellRate(uint oidBuyer) {
    short retVal = NWNXLibPINVOKE.CNWSStore_GetCustomerSellRate(swigCPtr, oidBuyer);
    return retVal;
  }

  public byte GetCustomerBuyRate(uint oidSeller, int bBlackMarket) {
    byte retVal = NWNXLibPINVOKE.CNWSStore_GetCustomerBuyRate(swigCPtr, oidSeller, bBlackMarket);
    return retVal;
  }

  public int CalculateItemBuyPrice(CNWSItem pItem, uint oidSeller) {
    int retVal = NWNXLibPINVOKE.CNWSStore_CalculateItemBuyPrice(swigCPtr, CNWSItem.getCPtr(pItem), oidSeller);
    return retVal;
  }

  public int CalculateItemSellPrice(CNWSItem pItem, uint oidBuyer) {
    int retVal = NWNXLibPINVOKE.CNWSStore_CalculateItemSellPrice(swigCPtr, CNWSItem.getCPtr(pItem), oidBuyer);
    return retVal;
  }

  public int AcquireItem(CNWSItem pItem, int bInfinite, byte x, byte y) {
    int retVal = NWNXLibPINVOKE.CNWSStore_AcquireItem__SWIG_0(swigCPtr, CNWSItem.getCPtr(pItem), bInfinite, x, y);
    return retVal;
  }

  public int AcquireItem(CNWSItem pItem, int bInfinite, byte x) {
    int retVal = NWNXLibPINVOKE.CNWSStore_AcquireItem__SWIG_1(swigCPtr, CNWSItem.getCPtr(pItem), bInfinite, x);
    return retVal;
  }

  public int AcquireItem(CNWSItem pItem, int bInfinite) {
    int retVal = NWNXLibPINVOKE.CNWSStore_AcquireItem__SWIG_2(swigCPtr, CNWSItem.getCPtr(pItem), bInfinite);
    return retVal;
  }

  public int AcquireItem(CNWSItem pItem) {
    int retVal = NWNXLibPINVOKE.CNWSStore_AcquireItem__SWIG_3(swigCPtr, CNWSItem.getCPtr(pItem));
    return retVal;
  }

  public int SellItem(CNWSItem pItem, CNWSCreature pCreature, byte x, byte y) {
    int retVal = NWNXLibPINVOKE.CNWSStore_SellItem(swigCPtr, CNWSItem.getCPtr(pItem), CNWSCreature.getCPtr(pCreature), x, y);
    return retVal;
  }

  public void RemoveItem(CNWSItem pItem) {
    NWNXLibPINVOKE.CNWSStore_RemoveItem(swigCPtr, CNWSItem.getCPtr(pItem));
  }

  public int GetItemInInventory(uint oidItem) {
    int retVal = NWNXLibPINVOKE.CNWSStore_GetItemInInventory__SWIG_0(swigCPtr, oidItem);
    return retVal;
  }

  public int GetItemInInventory(CExoString sTag) {
    int retVal = NWNXLibPINVOKE.CNWSStore_GetItemInInventory__SWIG_1(swigCPtr, CExoString.getCPtr(sTag));
    return retVal;
  }

  public byte GetAppropriateListId(uint nBaseItemId) {
    byte retVal = NWNXLibPINVOKE.CNWSStore_GetAppropriateListId(swigCPtr, nBaseItemId);
    return retVal;
  }

  public int AddItemToInventory(void** pItem, byte nInventoryList, byte x, byte y) {
    int retVal = NWNXLibPINVOKE.CNWSStore_AddItemToInventory__SWIG_0(swigCPtr, (global::System.IntPtr)pItem, nInventoryList, x, y);
    return retVal;
  }

  public int AddItemToInventory(void** pItem, byte nInventoryList, byte x) {
    int retVal = NWNXLibPINVOKE.CNWSStore_AddItemToInventory__SWIG_1(swigCPtr, (global::System.IntPtr)pItem, nInventoryList, x);
    return retVal;
  }

  public int AddItemToInventory(void** pItem, byte nInventoryList) {
    int retVal = NWNXLibPINVOKE.CNWSStore_AddItemToInventory__SWIG_2(swigCPtr, (global::System.IntPtr)pItem, nInventoryList);
    return retVal;
  }

  public int RemoveItemFromInventory(CNWSItem pItem, byte nInventoryList) {
    int retVal = NWNXLibPINVOKE.CNWSStore_RemoveItemFromInventory(swigCPtr, CNWSItem.getCPtr(pItem), nInventoryList);
    return retVal;
  }

  public new void _Destructor() {
    NWNXLibPINVOKE.CNWSStore__Destructor(swigCPtr);
  }

}

}

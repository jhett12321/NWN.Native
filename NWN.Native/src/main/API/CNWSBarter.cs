using NWN.Native.Attributes;

namespace NWN.Native.API;

[CStruct]
public unsafe partial struct CNWSBarter
{
  public CItemRepository * m_pBarterList;
  public CNWSPlayerLUOInventory * m_pLastUpdate;
  public CNWSPlayerLUOInventory * m_pOtherLastUpdate;
  public BOOL m_bListLocked;
  public BOOL m_bListAccepted;
  public BOOL m_bInitiator;
  public BOOL m_bWindowOpen;
  public OBJECT_ID m_oidBarrator;
  public CNWSCreature * m_pOwner;
  public BOOL m_bDoReset;

  [CMethod("_ZN10CNWSBarterC1EP12CNWSCreature")]
  public static partial CNWSBarter Construct(CNWSCreature* pCreature);

  [CMethod("_ZN10CNWSBarter5ResetEji")]
  public partial void Reset(OBJECT_ID oidBarrator = 0x7f000000, BOOL bInitiator = 0);

  [CMethod("_ZN10CNWSBarter7CleanUpEv")]
  public partial void CleanUp();

  [CMethod("_ZN10CNWSBarter7AddItemEjRhS0_")]
  public partial BOOL AddItem(OBJECT_ID oidItem, uint8_t* xPos, uint8_t* yPos);

  [CMethod("_ZN10CNWSBarter10RemoveItemEjRhS0_")]
  public partial BOOL RemoveItem(OBJECT_ID oidItem, uint8_t* xPos, uint8_t* yPos);

  [CMethod("_ZN10CNWSBarter8MoveItemEjRhS0_")]
  public partial BOOL MoveItem(OBJECT_ID oidItem, uint8_t* xPos, uint8_t* yPos);

  [CMethod("_ZN10CNWSBarter11PullItemOutEj")]
  public partial BOOL PullItemOut(OBJECT_ID oidItem);

  [CMethod("_ZN10CNWSBarter13SetListLockedEi")]
  public partial BOOL SetListLocked(BOOL bLocked);

  [CMethod("_ZN10CNWSBarter15SetListAcceptedEi")]
  public partial BOOL SetListAccepted(BOOL bAccepted);

  [CMethod("_ZN10CNWSBarter8GetStateEv")]
  public partial uint8_t GetState();
}

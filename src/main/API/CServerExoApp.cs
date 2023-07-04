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

public unsafe class CServerExoApp : CBaseExoApp {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;

  internal CServerExoApp(global::System.IntPtr cPtr, bool cMemoryOwn) : base(NWNXLibPINVOKE.CServerExoApp_SWIGUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(CServerExoApp obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  protected override void Dispose(bool disposing) {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          NWNXLibPINVOKE.delete_CServerExoApp(swigCPtr);
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

  public static unsafe implicit operator void*(CServerExoApp self) {
    return (void*)self.swigCPtr.Handle;
  }

  public static unsafe CServerExoApp FromPointer(void* pointer, bool memoryOwn = false) {
    return pointer != null ? new CServerExoApp((global::System.IntPtr)pointer, memoryOwn) : null;
  }

  public static CServerExoApp FromPointer(global::System.IntPtr pointer, bool memoryOwn = false) {
    return pointer != global::System.IntPtr.Zero ? new CServerExoApp(pointer, memoryOwn) : null;
  }

  public bool Equals(CServerExoApp other) {
    if (ReferenceEquals(null, other)) {
      return false;
    }

    if (ReferenceEquals(this, other)) {
      return true;
    }

    return Pointer.Equals(other.Pointer);
  }

  public override bool Equals(object obj) {
    return ReferenceEquals(this, obj) || obj is CServerExoApp other && Equals(other);
  }

  public override int GetHashCode() {
    return swigCPtr.Handle.GetHashCode();
  }

  public static bool operator ==(CServerExoApp left, CServerExoApp right) {
    return Equals(left, right);
  }

  public static bool operator !=(CServerExoApp left, CServerExoApp right) {
    return !Equals(left, right);
  }

  public CServerExoAppInternal m_pcExoAppInternal {
    set {
      NWNXLibPINVOKE.CServerExoApp_m_pcExoAppInternal_set(swigCPtr, CServerExoAppInternal.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = NWNXLibPINVOKE.CServerExoApp_m_pcExoAppInternal_get(swigCPtr);
      CServerExoAppInternal ret = (cPtr == global::System.IntPtr.Zero) ? null : new CServerExoAppInternal(cPtr, false);
      return ret;
    } 
  }

  public CServerExoApp() : this(NWNXLibPINVOKE.new_CServerExoApp(), true) {
  }

  public override int AdmitNetworkAddress(uint nProtocol, CExoString sAddress) {
    int retVal = NWNXLibPINVOKE.CServerExoApp_AdmitNetworkAddress(swigCPtr, nProtocol, CExoString.getCPtr(sAddress));
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
    return retVal;
  }

  public override int SetNetworkAddressBan(uint nProtocol, CExoString sAddress, int bBanPlayer) {
    int retVal = NWNXLibPINVOKE.CServerExoApp_SetNetworkAddressBan(swigCPtr, nProtocol, CExoString.getCPtr(sAddress), bBanPlayer);
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
    return retVal;
  }

  public override int AdmitPlayerName(CExoString sPlayerName) {
    int retVal = NWNXLibPINVOKE.CServerExoApp_AdmitPlayerName(swigCPtr, CExoString.getCPtr(sPlayerName));
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
    return retVal;
  }

  public override void PlayerListChange(uint nPlayerId, int bEnter, int bPrimaryPlayer) {
    NWNXLibPINVOKE.CServerExoApp_PlayerListChange__SWIG_0(swigCPtr, nPlayerId, bEnter, bPrimaryPlayer);
  }

  public override void PlayerListChange(uint nPlayerId, int bEnter) {
    NWNXLibPINVOKE.CServerExoApp_PlayerListChange__SWIG_1(swigCPtr, nPlayerId, bEnter);
  }

  public void VomitServerOptionsToLog() {
    NWNXLibPINVOKE.CServerExoApp_VomitServerOptionsToLog(swigCPtr);
  }

  public override int ContinueMessageProcessing() {
    int retVal = NWNXLibPINVOKE.CServerExoApp_ContinueMessageProcessing(swigCPtr);
    return retVal;
  }

  public void RemovePCFromWorld(CNWSPlayer pPlayer) {
    NWNXLibPINVOKE.CServerExoApp_RemovePCFromWorld(swigCPtr, CNWSPlayer.getCPtr(pPlayer));
  }

  public void Shutdown(int bWarnLocals, int bFromMessage) {
    NWNXLibPINVOKE.CServerExoApp_Shutdown__SWIG_0(swigCPtr, bWarnLocals, bFromMessage);
  }

  public void Shutdown(int bWarnLocals) {
    NWNXLibPINVOKE.CServerExoApp_Shutdown__SWIG_1(swigCPtr, bWarnLocals);
  }

  public void SetGameSpyReporting(int bEnabled) {
    NWNXLibPINVOKE.CServerExoApp_SetGameSpyReporting(swigCPtr, bEnabled);
  }

  public override CServerInfo GetServerInfo() {
    global::System.IntPtr cPtr = NWNXLibPINVOKE.CServerExoApp_GetServerInfo(swigCPtr);
    CServerInfo ret = (cPtr == global::System.IntPtr.Zero) ? null : new CServerInfo(cPtr, false);
    return ret;
  }

  public override CExoLocString GetModuleDescription() {
    CExoLocString ret = new CExoLocString(NWNXLibPINVOKE.CServerExoApp_GetModuleDescription(swigCPtr), true);
    return ret;
  }

  public override void GetExtendedServerInfo(CExtendedServerInfo pInfo) {
    NWNXLibPINVOKE.CServerExoApp_GetExtendedServerInfo(swigCPtr, CExtendedServerInfo.getCPtr(pInfo));
  }

  public CNWSModule GetModule() {
    global::System.IntPtr cPtr = NWNXLibPINVOKE.CServerExoApp_GetModule(swigCPtr);
    CNWSModule ret = (cPtr == global::System.IntPtr.Zero) ? null : new CNWSModule(cPtr, false);
    return ret;
  }

  public CExoString GetModuleName() {
    CExoString ret = new CExoString(NWNXLibPINVOKE.CServerExoApp_GetModuleName(swigCPtr), true);
    return ret;
  }

  public int LoadGame(uint nSlot, CExoString sSaveName, CExoString sModuleName, CNWSPlayer pPlayer) {
    int retVal = NWNXLibPINVOKE.CServerExoApp_LoadGame__SWIG_0(swigCPtr, nSlot, CExoString.getCPtr(sSaveName), CExoString.getCPtr(sModuleName), CNWSPlayer.getCPtr(pPlayer));
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
    return retVal;
  }

  public int LoadGame(uint nSlot, CExoString sSaveName, CExoString sModuleName) {
    int retVal = NWNXLibPINVOKE.CServerExoApp_LoadGame__SWIG_1(swigCPtr, nSlot, CExoString.getCPtr(sSaveName), CExoString.getCPtr(sModuleName));
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
    return retVal;
  }

  public int StartNewModule(CExoString sModuleName) {
    int retVal = NWNXLibPINVOKE.CServerExoApp_StartNewModule(swigCPtr, CExoString.getCPtr(sModuleName));
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
    return retVal;
  }

  public void SetMoveToModulePending(int bPending) {
    NWNXLibPINVOKE.CServerExoApp_SetMoveToModulePending(swigCPtr, bPending);
  }

  public int GetMoveToModulePending() {
    int retVal = NWNXLibPINVOKE.CServerExoApp_GetMoveToModulePending(swigCPtr);
    return retVal;
  }

  public void SetEndGamePending(int bPending) {
    NWNXLibPINVOKE.CServerExoApp_SetEndGamePending(swigCPtr, bPending);
  }

  public void SetEndGameString(CExoString sMovieName) {
    NWNXLibPINVOKE.CServerExoApp_SetEndGameString(swigCPtr, CExoString.getCPtr(sMovieName));
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
  }

  public void SetMoveToModuleString(CExoString sModName) {
    NWNXLibPINVOKE.CServerExoApp_SetMoveToModuleString(swigCPtr, CExoString.getCPtr(sModName));
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
  }

  public CExoString GetMoveToModuleString() {
    CExoString ret = new CExoString(NWNXLibPINVOKE.CServerExoApp_GetMoveToModuleString(swigCPtr), true);
    return ret;
  }

  public void SetLoadingModule(int bLoading) {
    NWNXLibPINVOKE.CServerExoApp_SetLoadingModule(swigCPtr, bLoading);
  }

  public int GetLoadingModule() {
    int retVal = NWNXLibPINVOKE.CServerExoApp_GetLoadingModule(swigCPtr);
    return retVal;
  }

  public void SetImportingChar(int bImporting) {
    NWNXLibPINVOKE.CServerExoApp_SetImportingChar(swigCPtr, bImporting);
  }

  public int GetImportingChar() {
    int retVal = NWNXLibPINVOKE.CServerExoApp_GetImportingChar(swigCPtr);
    return retVal;
  }

  public void SetAutoSavePending(int bPending) {
    NWNXLibPINVOKE.CServerExoApp_SetAutoSavePending(swigCPtr, bPending);
  }

  public int GetAutoSavePending() {
    int retVal = NWNXLibPINVOKE.CServerExoApp_GetAutoSavePending(swigCPtr);
    return retVal;
  }

  public int ExportAllPlayers() {
    int retVal = NWNXLibPINVOKE.CServerExoApp_ExportAllPlayers(swigCPtr);
    return retVal;
  }

  public int GetExportCharacterPending() {
    int retVal = NWNXLibPINVOKE.CServerExoApp_GetExportCharacterPending(swigCPtr);
    return retVal;
  }

  public void SetExportCharacterPending(int bPending) {
    NWNXLibPINVOKE.CServerExoApp_SetExportCharacterPending(swigCPtr, bPending);
  }

  public void AddExportPlayersCharacterRequest(uint oid) {
    NWNXLibPINVOKE.CServerExoApp_AddExportPlayersCharacterRequest(swigCPtr, oid);
  }

  public CExoArrayListUInt32 GetExportPlayersCharacterRequests() {
    CExoArrayListUInt32 ret = new CExoArrayListUInt32(NWNXLibPINVOKE.CServerExoApp_GetExportPlayersCharacterRequests(swigCPtr), false);
    return ret;
  }

  public void ClearExportPlayerCharacterRequests() {
    NWNXLibPINVOKE.CServerExoApp_ClearExportPlayerCharacterRequests(swigCPtr);
  }

  public int LoadCharacterStart(byte nType, CNWSPlayer pPlayer, CResRef cResRef, void* pCharData, uint nSize) {
    int retVal = NWNXLibPINVOKE.CServerExoApp_LoadCharacterStart__SWIG_0(swigCPtr, nType, CNWSPlayer.getCPtr(pPlayer), CResRef.getCPtr(cResRef), (global::System.IntPtr)pCharData, nSize);
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
    return retVal;
  }

  public int LoadCharacterStart(byte nType, CNWSPlayer pPlayer, CResRef cResRef, void* pCharData) {
    int retVal = NWNXLibPINVOKE.CServerExoApp_LoadCharacterStart__SWIG_1(swigCPtr, nType, CNWSPlayer.getCPtr(pPlayer), CResRef.getCPtr(cResRef), (global::System.IntPtr)pCharData);
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
    return retVal;
  }

  public int LoadCharacterStart(byte nType, CNWSPlayer pPlayer, CResRef cResRef) {
    int retVal = NWNXLibPINVOKE.CServerExoApp_LoadCharacterStart__SWIG_2(swigCPtr, nType, CNWSPlayer.getCPtr(pPlayer), CResRef.getCPtr(cResRef));
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
    return retVal;
  }

  public int LoadCharacterFinish(CNWSPlayer pPlayer, int bUseSaveGameCharacter, int bUseStateDataInSaveGame) {
    int retVal = NWNXLibPINVOKE.CServerExoApp_LoadCharacterFinish__SWIG_0(swigCPtr, CNWSPlayer.getCPtr(pPlayer), bUseSaveGameCharacter, bUseStateDataInSaveGame);
    return retVal;
  }

  public int LoadCharacterFinish(CNWSPlayer pPlayer, int bUseSaveGameCharacter) {
    int retVal = NWNXLibPINVOKE.CServerExoApp_LoadCharacterFinish__SWIG_1(swigCPtr, CNWSPlayer.getCPtr(pPlayer), bUseSaveGameCharacter);
    return retVal;
  }

  public int LoadCharacterFinish(CNWSPlayer pPlayer) {
    int retVal = NWNXLibPINVOKE.CServerExoApp_LoadCharacterFinish__SWIG_2(swigCPtr, CNWSPlayer.getCPtr(pPlayer));
    return retVal;
  }

  public int LoadPrimaryPlayer(CNWSPlayer pPlayer) {
    int retVal = NWNXLibPINVOKE.CServerExoApp_LoadPrimaryPlayer(swigCPtr, CNWSPlayer.getCPtr(pPlayer));
    return retVal;
  }

  public CGameObjectArray GetObjectArray() {
    global::System.IntPtr cPtr = NWNXLibPINVOKE.CServerExoApp_GetObjectArray(swigCPtr);
    CGameObjectArray ret = (cPtr == global::System.IntPtr.Zero) ? null : new CGameObjectArray(cPtr, false);
    return ret;
  }

  public ICGameObject GetGameObject(uint nObjectID) {
    global::System.IntPtr cPtr = NWNXLibPINVOKE.CServerExoApp_GetGameObject(swigCPtr, nObjectID);
    CGameObject ret = (cPtr == global::System.IntPtr.Zero) ? null : new CGameObject(cPtr, false);
    return (ICGameObject)ret;
  }

  public CNWSStore GetStoreByGameObjectID(uint nObjectID) {
    global::System.IntPtr cPtr = NWNXLibPINVOKE.CServerExoApp_GetStoreByGameObjectID(swigCPtr, nObjectID);
    CNWSStore ret = (cPtr == global::System.IntPtr.Zero) ? null : new CNWSStore(cPtr, false);
    return ret;
  }

  public CNWSItem GetItemByGameObjectID(uint nObjectID) {
    global::System.IntPtr cPtr = NWNXLibPINVOKE.CServerExoApp_GetItemByGameObjectID(swigCPtr, nObjectID);
    CNWSItem ret = (cPtr == global::System.IntPtr.Zero) ? null : new CNWSItem(cPtr, false);
    return ret;
  }

  public CNWSCreature GetCreatureByGameObjectID(uint nObjectID) {
    global::System.IntPtr cPtr = NWNXLibPINVOKE.CServerExoApp_GetCreatureByGameObjectID(swigCPtr, nObjectID);
    CNWSCreature ret = (cPtr == global::System.IntPtr.Zero) ? null : new CNWSCreature(cPtr, false);
    return ret;
  }

  public CNWSModule GetModuleByGameObjectID(uint nObjectID) {
    global::System.IntPtr cPtr = NWNXLibPINVOKE.CServerExoApp_GetModuleByGameObjectID(swigCPtr, nObjectID);
    CNWSModule ret = (cPtr == global::System.IntPtr.Zero) ? null : new CNWSModule(cPtr, false);
    return ret;
  }

  public CNWSArea GetAreaByGameObjectID(uint nObjectID) {
    global::System.IntPtr cPtr = NWNXLibPINVOKE.CServerExoApp_GetAreaByGameObjectID(swigCPtr, nObjectID);
    CNWSArea ret = (cPtr == global::System.IntPtr.Zero) ? null : new CNWSArea(cPtr, false);
    return ret;
  }

  public CNWSTrigger GetTriggerByGameObjectID(uint nObjectID) {
    global::System.IntPtr cPtr = NWNXLibPINVOKE.CServerExoApp_GetTriggerByGameObjectID(swigCPtr, nObjectID);
    CNWSTrigger ret = (cPtr == global::System.IntPtr.Zero) ? null : new CNWSTrigger(cPtr, false);
    return ret;
  }

  public CNWSPlaceable GetPlaceableByGameObjectID(uint nObjectID) {
    global::System.IntPtr cPtr = NWNXLibPINVOKE.CServerExoApp_GetPlaceableByGameObjectID(swigCPtr, nObjectID);
    CNWSPlaceable ret = (cPtr == global::System.IntPtr.Zero) ? null : new CNWSPlaceable(cPtr, false);
    return ret;
  }

  public CNWSDoor GetDoorByGameObjectID(uint nObjectID) {
    global::System.IntPtr cPtr = NWNXLibPINVOKE.CServerExoApp_GetDoorByGameObjectID(swigCPtr, nObjectID);
    CNWSDoor ret = (cPtr == global::System.IntPtr.Zero) ? null : new CNWSDoor(cPtr, false);
    return ret;
  }

  public CNWSAreaOfEffectObject GetAreaOfEffectByGameObjectID(uint nObjectID) {
    global::System.IntPtr cPtr = NWNXLibPINVOKE.CServerExoApp_GetAreaOfEffectByGameObjectID(swigCPtr, nObjectID);
    CNWSAreaOfEffectObject ret = (cPtr == global::System.IntPtr.Zero) ? null : new CNWSAreaOfEffectObject(cPtr, false);
    return ret;
  }

  public CNWSWaypoint GetWaypointByGameObjectID(uint nObjectID) {
    global::System.IntPtr cPtr = NWNXLibPINVOKE.CServerExoApp_GetWaypointByGameObjectID(swigCPtr, nObjectID);
    CNWSWaypoint ret = (cPtr == global::System.IntPtr.Zero) ? null : new CNWSWaypoint(cPtr, false);
    return ret;
  }

  public CNWSEncounter GetEncounterByGameObjectID(uint nObjectID) {
    global::System.IntPtr cPtr = NWNXLibPINVOKE.CServerExoApp_GetEncounterByGameObjectID(swigCPtr, nObjectID);
    CNWSEncounter ret = (cPtr == global::System.IntPtr.Zero) ? null : new CNWSEncounter(cPtr, false);
    return ret;
  }

  public CNWSSoundObject GetSoundObjectByGameObjectID(uint nObjectID) {
    global::System.IntPtr cPtr = NWNXLibPINVOKE.CServerExoApp_GetSoundObjectByGameObjectID(swigCPtr, nObjectID);
    CNWSSoundObject ret = (cPtr == global::System.IntPtr.Zero) ? null : new CNWSSoundObject(cPtr, false);
    return ret;
  }

  public uint GetPlayerIDByGameObjectID(uint nObjectID) {
    uint retVal = NWNXLibPINVOKE.CServerExoApp_GetPlayerIDByGameObjectID(swigCPtr, nObjectID);
    return retVal;
  }

  public int GetPlayerLanguage(uint nPlayerID) {
    int retVal = NWNXLibPINVOKE.CServerExoApp_GetPlayerLanguage(swigCPtr, nPlayerID);
    return retVal;
  }

  public int GetModuleLanguage() {
    int retVal = NWNXLibPINVOKE.CServerExoApp_GetModuleLanguage(swigCPtr);
    return retVal;
  }

  public CServerAIMaster GetServerAIMaster() {
    global::System.IntPtr cPtr = NWNXLibPINVOKE.CServerExoApp_GetServerAIMaster(swigCPtr);
    CServerAIMaster ret = (cPtr == global::System.IntPtr.Zero) ? null : new CServerAIMaster(cPtr, false);
    return ret;
  }

  public void* GetSysAdminList() {
    global::System.IntPtr retVal = NWNXLibPINVOKE.CServerExoApp_GetSysAdminList(swigCPtr);
    return (void*)retVal;
  }

  public void* GetPlayerList() {
    global::System.IntPtr retVal = NWNXLibPINVOKE.CServerExoApp_GetPlayerList(swigCPtr);
    return (void*)retVal;
  }

  public CNWSMessage GetNWSMessage() {
    global::System.IntPtr cPtr = NWNXLibPINVOKE.CServerExoApp_GetNWSMessage(swigCPtr);
    CNWSMessage ret = (cPtr == global::System.IntPtr.Zero) ? null : new CNWSMessage(cPtr, false);
    return ret;
  }

  public override CNetLayer GetNetLayer() {
    global::System.IntPtr cPtr = NWNXLibPINVOKE.CServerExoApp_GetNetLayer(swigCPtr);
    CNetLayer ret = (cPtr == global::System.IntPtr.Zero) ? null : new CNetLayer(cPtr, false);
    return ret;
  }

  public CNWPlaceMeshManager GetPlaceMeshManager() {
    global::System.IntPtr cPtr = NWNXLibPINVOKE.CServerExoApp_GetPlaceMeshManager(swigCPtr);
    CNWPlaceMeshManager ret = (cPtr == global::System.IntPtr.Zero) ? null : new CNWPlaceMeshManager(cPtr, false);
    return ret;
  }

  public short GetServerMode() {
    short retVal = NWNXLibPINVOKE.CServerExoApp_GetServerMode(swigCPtr);
    return retVal;
  }

  public void SetDebugMode(int bMode) {
    NWNXLibPINVOKE.CServerExoApp_SetDebugMode(swigCPtr, bMode);
  }

  public int GetDebugMode() {
    int retVal = NWNXLibPINVOKE.CServerExoApp_GetDebugMode(swigCPtr);
    return retVal;
  }

  public CWorldTimer GetActiveTimer(uint oid) {
    global::System.IntPtr cPtr = NWNXLibPINVOKE.CServerExoApp_GetActiveTimer__SWIG_0(swigCPtr, oid);
    CWorldTimer ret = (cPtr == global::System.IntPtr.Zero) ? null : new CWorldTimer(cPtr, false);
    return ret;
  }

  public CWorldTimer GetActiveTimer() {
    global::System.IntPtr cPtr = NWNXLibPINVOKE.CServerExoApp_GetActiveTimer__SWIG_1(swigCPtr);
    CWorldTimer ret = (cPtr == global::System.IntPtr.Zero) ? null : new CWorldTimer(cPtr, false);
    return ret;
  }

  public CWorldTimer GetWorldTimer() {
    global::System.IntPtr cPtr = NWNXLibPINVOKE.CServerExoApp_GetWorldTimer(swigCPtr);
    CWorldTimer ret = (cPtr == global::System.IntPtr.Zero) ? null : new CWorldTimer(cPtr, false);
    return ret;
  }

  public CWorldTimer GetTimestopTimer() {
    global::System.IntPtr cPtr = NWNXLibPINVOKE.CServerExoApp_GetTimestopTimer(swigCPtr);
    CWorldTimer ret = (cPtr == global::System.IntPtr.Zero) ? null : new CWorldTimer(cPtr, false);
    return ret;
  }

  public CWorldTimer GetPauseTimer() {
    global::System.IntPtr cPtr = NWNXLibPINVOKE.CServerExoApp_GetPauseTimer(swigCPtr);
    CWorldTimer ret = (cPtr == global::System.IntPtr.Zero) ? null : new CWorldTimer(cPtr, false);
    return ret;
  }

  public override int HandleMessage(uint nPlayerId, byte* pData, uint dwSize, int bRawMessage) {
    int retVal = NWNXLibPINVOKE.CServerExoApp_HandleMessage(swigCPtr, nPlayerId, pData, dwSize, bRawMessage);
    return retVal;
  }

  public int Initialize() {
    int retVal = NWNXLibPINVOKE.CServerExoApp_Initialize(swigCPtr);
    return retVal;
  }

  public int UnloadModule() {
    int retVal = NWNXLibPINVOKE.CServerExoApp_UnloadModule(swigCPtr);
    return retVal;
  }

  public int LoadModule(CExoString moduleResRef, CUUID uuidOverride, int bIsSaveGame, CNWSPlayer pPlayer, int sourceType, Advertisement nwsyncModuleSourceAdvert) {
    int retVal = NWNXLibPINVOKE.CServerExoApp_LoadModule(swigCPtr, CExoString.getCPtr(moduleResRef), CUUID.getCPtr(uuidOverride), bIsSaveGame, CNWSPlayer.getCPtr(pPlayer), sourceType, Advertisement.getCPtr(nwsyncModuleSourceAdvert));
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
    return retVal;
  }

  public int RunModule() {
    int retVal = NWNXLibPINVOKE.CServerExoApp_RunModule(swigCPtr);
    return retVal;
  }

  public CExoString GetPlayerListString() {
    CExoString ret = new CExoString(NWNXLibPINVOKE.CServerExoApp_GetPlayerListString(swigCPtr), true);
    return ret;
  }

  public CExoString GetBannedListString() {
    CExoString ret = new CExoString(NWNXLibPINVOKE.CServerExoApp_GetBannedListString(swigCPtr), true);
    return ret;
  }

  public CExoString GetPortalListString() {
    CExoString ret = new CExoString(NWNXLibPINVOKE.CServerExoApp_GetPortalListString(swigCPtr), true);
    return ret;
  }

  public int MainLoop() {
    int retVal = NWNXLibPINVOKE.CServerExoApp_MainLoop(swigCPtr);
    return retVal;
  }

  public void OnCDChange() {
    NWNXLibPINVOKE.CServerExoApp_OnCDChange(swigCPtr);
  }

  public void OnExit() {
    NWNXLibPINVOKE.CServerExoApp_OnExit(swigCPtr);
  }

  public void OnGainFocus() {
    NWNXLibPINVOKE.CServerExoApp_OnGainFocus(swigCPtr);
  }

  public void OnLostFocus() {
    NWNXLibPINVOKE.CServerExoApp_OnLostFocus(swigCPtr);
  }

  public void OnVideoChange() {
    NWNXLibPINVOKE.CServerExoApp_OnVideoChange(swigCPtr);
  }

  public void StartServices() {
    NWNXLibPINVOKE.CServerExoApp_StartServices(swigCPtr);
  }

  public void ShutdownNetLayer() {
    NWNXLibPINVOKE.CServerExoApp_ShutdownNetLayer(swigCPtr);
  }

  public void RestartNetLayer() {
    NWNXLibPINVOKE.CServerExoApp_RestartNetLayer(swigCPtr);
  }

  public void StopServices() {
    NWNXLibPINVOKE.CServerExoApp_StopServices(swigCPtr);
  }

  public void Uninitialize() {
    NWNXLibPINVOKE.CServerExoApp_Uninitialize(swigCPtr);
  }

  public void SetForceUpdate() {
    NWNXLibPINVOKE.CServerExoApp_SetForceUpdate(swigCPtr);
  }

  public int SendCharacterQuery(CNWSPlayer pPlayer) {
    int retVal = NWNXLibPINVOKE.CServerExoApp_SendCharacterQuery(swigCPtr, CNWSPlayer.getCPtr(pPlayer));
    return retVal;
  }

  public CNWSPlayer GetClientObjectByObjectId(uint nObjectId) {
    global::System.IntPtr cPtr = NWNXLibPINVOKE.CServerExoApp_GetClientObjectByObjectId(swigCPtr, nObjectId);
    CNWSPlayer ret = (cPtr == global::System.IntPtr.Zero) ? null : new CNWSPlayer(cPtr, false);
    return ret;
  }

  public void TogglePauseState(byte nState) {
    NWNXLibPINVOKE.CServerExoApp_TogglePauseState(swigCPtr, nState);
  }

  public int GetPauseState(byte nState) {
    int retVal = NWNXLibPINVOKE.CServerExoApp_GetPauseState(swigCPtr, nState);
    return retVal;
  }

  public byte GetActivePauseState() {
    byte retVal = NWNXLibPINVOKE.CServerExoApp_GetActivePauseState(swigCPtr);
    return retVal;
  }

  public void SetPauseState(byte nState, int bPause) {
    NWNXLibPINVOKE.CServerExoApp_SetPauseState(swigCPtr, nState, bPause);
  }

  public CExoArrayListUInt32 GetActiveExclusionList() {
    global::System.IntPtr cPtr = NWNXLibPINVOKE.CServerExoApp_GetActiveExclusionList(swigCPtr);
    CExoArrayListUInt32 ret = (cPtr == global::System.IntPtr.Zero) ? null : new CExoArrayListUInt32(cPtr, false);
    return ret;
  }

  public void AddToExclusionList(uint oidExclude, byte nList) {
    NWNXLibPINVOKE.CServerExoApp_AddToExclusionList(swigCPtr, oidExclude, nList);
  }

  public void RemoveFromExclusionList(uint oidExclude, byte nList) {
    NWNXLibPINVOKE.CServerExoApp_RemoveFromExclusionList(swigCPtr, oidExclude, nList);
  }

  public int IsOnActiveExclusionList(uint oidExclude) {
    int retVal = NWNXLibPINVOKE.CServerExoApp_IsOnActiveExclusionList(swigCPtr, oidExclude);
    return retVal;
  }

  public int GetIsControlledByPlayer(uint oidObject) {
    int retVal = NWNXLibPINVOKE.CServerExoApp_GetIsControlledByPlayer(swigCPtr, oidObject);
    return retVal;
  }

  public CNWSClient GetClientObjectByPlayerId(uint nPlayerId, byte nClientType) {
    global::System.IntPtr cPtr = NWNXLibPINVOKE.CServerExoApp_GetClientObjectByPlayerId__SWIG_0(swigCPtr, nPlayerId, nClientType);
    CNWSClient ret = (cPtr == global::System.IntPtr.Zero) ? null : new CNWSClient(cPtr, false);
    return ret;
  }

  public CNWSClient GetClientObjectByPlayerId(uint nPlayerId) {
    global::System.IntPtr cPtr = NWNXLibPINVOKE.CServerExoApp_GetClientObjectByPlayerId__SWIG_1(swigCPtr, nPlayerId);
    CNWSClient ret = (cPtr == global::System.IntPtr.Zero) ? null : new CNWSClient(cPtr, false);
    return ret;
  }

  public int ValidatePlayerLogin(void* pPlayer) {
    int retVal = NWNXLibPINVOKE.CServerExoApp_ValidatePlayerLogin(swigCPtr, (global::System.IntPtr)pPlayer);
    return retVal;
  }

  public void MovePlayerToArea(void* pPlayer) {
    NWNXLibPINVOKE.CServerExoApp_MovePlayerToArea(swigCPtr, (global::System.IntPtr)pPlayer);
  }

  public void InitiateModuleForPlayer(void* pPlayer) {
    NWNXLibPINVOKE.CServerExoApp_InitiateModuleForPlayer(swigCPtr, (global::System.IntPtr)pPlayer);
  }

  public override void HandleGameSpyToServerMessage(int nKeyId, void* pOutBuf, int nIndex) {
    NWNXLibPINVOKE.CServerExoApp_HandleGameSpyToServerMessage__SWIG_0(swigCPtr, nKeyId, (global::System.IntPtr)pOutBuf, nIndex);
  }

  public override void HandleGameSpyToServerMessage(int nKeyId, void* pOutBuf) {
    NWNXLibPINVOKE.CServerExoApp_HandleGameSpyToServerMessage__SWIG_1(swigCPtr, nKeyId, (global::System.IntPtr)pOutBuf);
  }

  public override SWIGTYPE_p_CConnectionLib GetConnectionLib() {
    global::System.IntPtr cPtr = NWNXLibPINVOKE.CServerExoApp_GetConnectionLib(swigCPtr);
    SWIGTYPE_p_CConnectionLib ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_CConnectionLib(cPtr, false);
    return ret;
  }

  public SWIGTYPE_p_CCampaignDB GetCampaignDB() {
    global::System.IntPtr cPtr = NWNXLibPINVOKE.CServerExoApp_GetCampaignDB(swigCPtr);
    SWIGTYPE_p_CCampaignDB ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_CCampaignDB(cPtr, false);
    return ret;
  }

  public int GetPlayerAddressData(uint nConnectionId, uint* nProtocol, byte** pNetAddress1, byte** pNetAddress2, uint* nPort) {
    int retVal = NWNXLibPINVOKE.CServerExoApp_GetPlayerAddressData(swigCPtr, nConnectionId, nProtocol, (global::System.IntPtr)pNetAddress1, (global::System.IntPtr)pNetAddress2, nPort);
    return retVal;
  }

  public int GetFactionOfObject(uint oObject, int* nFaction) {
    int retVal = NWNXLibPINVOKE.CServerExoApp_GetFactionOfObject(swigCPtr, oObject, nFaction);
    return retVal;
  }

  public uint ResolvePlayerByFirstName(CExoString sName) {
    uint retVal = NWNXLibPINVOKE.CServerExoApp_ResolvePlayerByFirstName(swigCPtr, CExoString.getCPtr(sName));
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
    return retVal;
  }

  public override int GetMultiplayerEnabled() {
    int retVal = NWNXLibPINVOKE.CServerExoApp_GetMultiplayerEnabled(swigCPtr);
    return retVal;
  }

  public void SetReloadModuleWhenEmpty(int bReloadModuleWhenEmpty) {
    NWNXLibPINVOKE.CServerExoApp_SetReloadModuleWhenEmpty(swigCPtr, bReloadModuleWhenEmpty);
  }

  public int GetReloadModuleWhenEmpty() {
    int retVal = NWNXLibPINVOKE.CServerExoApp_GetReloadModuleWhenEmpty(swigCPtr);
    return retVal;
  }

  public int GetDifficultyOption(int nOption) {
    int retVal = NWNXLibPINVOKE.CServerExoApp_GetDifficultyOption(swigCPtr, nOption);
    return retVal;
  }

  public void AddCharListRequest(uint nPlayerId) {
    NWNXLibPINVOKE.CServerExoApp_AddCharListRequest(swigCPtr, nPlayerId);
  }

  public override uint GetApplicationId() {
    uint retVal = NWNXLibPINVOKE.CServerExoApp_GetApplicationId(swigCPtr);
    return retVal;
  }

  public int IsOnExclusionList(uint oidTarget) {
    int retVal = NWNXLibPINVOKE.CServerExoApp_IsOnExclusionList(swigCPtr, oidTarget);
    return retVal;
  }

  public void AddIPToBannedList(CExoString sIP) {
    NWNXLibPINVOKE.CServerExoApp_AddIPToBannedList(swigCPtr, CExoString.getCPtr(sIP));
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
  }

  public void AddPlayerNameToBannedList(CExoString sPlayerName) {
    NWNXLibPINVOKE.CServerExoApp_AddPlayerNameToBannedList(swigCPtr, CExoString.getCPtr(sPlayerName));
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
  }

  public void AddCDKeyToBannedList(CExoString sKey) {
    NWNXLibPINVOKE.CServerExoApp_AddCDKeyToBannedList(swigCPtr, CExoString.getCPtr(sKey));
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
  }

  public void RemoveIPFromBannedList(CExoString sIP) {
    NWNXLibPINVOKE.CServerExoApp_RemoveIPFromBannedList(swigCPtr, CExoString.getCPtr(sIP));
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
  }

  public void RemovePlayerNameFromBannedList(CExoString sPlayerName) {
    NWNXLibPINVOKE.CServerExoApp_RemovePlayerNameFromBannedList(swigCPtr, CExoString.getCPtr(sPlayerName));
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
  }

  public void RemoveCDKeyFromBannedList(CExoString sKey) {
    NWNXLibPINVOKE.CServerExoApp_RemoveCDKeyFromBannedList(swigCPtr, CExoString.getCPtr(sKey));
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
  }

  public override int GetIsIPOnBannedList(CExoString sIP) {
    int retVal = NWNXLibPINVOKE.CServerExoApp_GetIsIPOnBannedList(swigCPtr, CExoString.getCPtr(sIP));
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
    return retVal;
  }

  public override int GetIsPlayerNameOnBannedList(CExoString sPlayerName) {
    int retVal = NWNXLibPINVOKE.CServerExoApp_GetIsPlayerNameOnBannedList(swigCPtr, CExoString.getCPtr(sPlayerName));
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
    return retVal;
  }

  public override int GetIsCDKeyOnBannedList(CExoString sKey) {
    int retVal = NWNXLibPINVOKE.CServerExoApp_GetIsCDKeyOnBannedList(swigCPtr, CExoString.getCPtr(sKey));
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
    return retVal;
  }

  public override void HandleOldServerVaultMigration(CExoString sClientCDKey, CExoString sClientLegacyCDKey, CExoString sPlayerName) {
    NWNXLibPINVOKE.CServerExoApp_HandleOldServerVaultMigration(swigCPtr, CExoString.getCPtr(sClientCDKey), CExoString.getCPtr(sClientLegacyCDKey), CExoString.getCPtr(sPlayerName));
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
  }

  public override int IsPlayerNameSticky() {
    int retVal = NWNXLibPINVOKE.CServerExoApp_IsPlayerNameSticky(swigCPtr);
    return retVal;
  }

  public override int CheckStickyPlayerNameReserved(CExoString sClientCDKey, CExoString sClientLegacyCDKey, CExoString sPlayerName, int nConnectionType) {
    int retVal = NWNXLibPINVOKE.CServerExoApp_CheckStickyPlayerNameReserved(swigCPtr, CExoString.getCPtr(sClientCDKey), CExoString.getCPtr(sClientLegacyCDKey), CExoString.getCPtr(sPlayerName), nConnectionType);
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
    return retVal;
  }

  public uint GetFirstPCObject() {
    uint retVal = NWNXLibPINVOKE.CServerExoApp_GetFirstPCObject(swigCPtr);
    return retVal;
  }

  public uint GetNextPCObject() {
    uint retVal = NWNXLibPINVOKE.CServerExoApp_GetNextPCObject(swigCPtr);
    return retVal;
  }

  public override void PushMessageOverWall(byte* pData, uint nMsgLength) {
    NWNXLibPINVOKE.CServerExoApp_PushMessageOverWall(swigCPtr, pData, nMsgLength);
  }

  public override int GetIsMultiPlayer() {
    int retVal = NWNXLibPINVOKE.CServerExoApp_GetIsMultiPlayer(swigCPtr);
    return retVal;
  }

  public void SetGameSpyEnabled(int b) {
    NWNXLibPINVOKE.CServerExoApp_SetGameSpyEnabled(swigCPtr, b);
  }

  public int GetGameSpyEnabled() {
    int retVal = NWNXLibPINVOKE.CServerExoApp_GetGameSpyEnabled(swigCPtr);
    return retVal;
  }

  public int StripColorTokens(CExoString sInput) {
    int retVal = NWNXLibPINVOKE.CServerExoApp_StripColorTokens(swigCPtr, CExoString.getCPtr(sInput));
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
    return retVal;
  }

  public void AddSubNetProfileSendSize(uint nPlayerID, uint nSize) {
    NWNXLibPINVOKE.CServerExoApp_AddSubNetProfileSendSize(swigCPtr, nPlayerID, nSize);
  }

  public int GetCreatureDeathLogging() {
    int retVal = NWNXLibPINVOKE.CServerExoApp_GetCreatureDeathLogging(swigCPtr);
    return retVal;
  }

  public void SetCreatureDeathLogging(int arg0) {
    NWNXLibPINVOKE.CServerExoApp_SetCreatureDeathLogging(swigCPtr, arg0);
  }

  public int GetHeartBeatLogging() {
    int retVal = NWNXLibPINVOKE.CServerExoApp_GetHeartBeatLogging(swigCPtr);
    return retVal;
  }

  public void SetHeartBeatLogging(int arg0) {
    NWNXLibPINVOKE.CServerExoApp_SetHeartBeatLogging(swigCPtr, arg0);
  }

  public uint GetClientsRequiredToDisableCPUSleep() {
    uint retVal = NWNXLibPINVOKE.CServerExoApp_GetClientsRequiredToDisableCPUSleep(swigCPtr);
    return retVal;
  }

  public int GetStickyCombatModesEnabled() {
    int retVal = NWNXLibPINVOKE.CServerExoApp_GetStickyCombatModesEnabled(swigCPtr);
    return retVal;
  }

  public void SetStickyCombatModesEnabled(int v) {
    NWNXLibPINVOKE.CServerExoApp_SetStickyCombatModesEnabled(swigCPtr, v);
  }

  public int GetAttackBonusLimit() {
    int retVal = NWNXLibPINVOKE.CServerExoApp_GetAttackBonusLimit(swigCPtr);
    return retVal;
  }

  public void SetAttackBonusLimit(int newLimit, int isModuleOverride) {
    NWNXLibPINVOKE.CServerExoApp_SetAttackBonusLimit__SWIG_0(swigCPtr, newLimit, isModuleOverride);
  }

  public void SetAttackBonusLimit(int newLimit) {
    NWNXLibPINVOKE.CServerExoApp_SetAttackBonusLimit__SWIG_1(swigCPtr, newLimit);
  }

  public int GetDamageBonusLimit() {
    int retVal = NWNXLibPINVOKE.CServerExoApp_GetDamageBonusLimit(swigCPtr);
    return retVal;
  }

  public void SetDamageBonusLimit(int newLimit, int isModuleOverride) {
    NWNXLibPINVOKE.CServerExoApp_SetDamageBonusLimit__SWIG_0(swigCPtr, newLimit, isModuleOverride);
  }

  public void SetDamageBonusLimit(int newLimit) {
    NWNXLibPINVOKE.CServerExoApp_SetDamageBonusLimit__SWIG_1(swigCPtr, newLimit);
  }

  public int GetSavingThrowBonusLimit() {
    int retVal = NWNXLibPINVOKE.CServerExoApp_GetSavingThrowBonusLimit(swigCPtr);
    return retVal;
  }

  public void SetSavingThrowBonusLimit(int newLimit, int isModuleOverride) {
    NWNXLibPINVOKE.CServerExoApp_SetSavingThrowBonusLimit__SWIG_0(swigCPtr, newLimit, isModuleOverride);
  }

  public void SetSavingThrowBonusLimit(int newLimit) {
    NWNXLibPINVOKE.CServerExoApp_SetSavingThrowBonusLimit__SWIG_1(swigCPtr, newLimit);
  }

  public int GetAbilityBonusLimit() {
    int retVal = NWNXLibPINVOKE.CServerExoApp_GetAbilityBonusLimit(swigCPtr);
    return retVal;
  }

  public void SetAbilityBonusLimit(int newLimit, int isModuleOverride) {
    NWNXLibPINVOKE.CServerExoApp_SetAbilityBonusLimit__SWIG_0(swigCPtr, newLimit, isModuleOverride);
  }

  public void SetAbilityBonusLimit(int newLimit) {
    NWNXLibPINVOKE.CServerExoApp_SetAbilityBonusLimit__SWIG_1(swigCPtr, newLimit);
  }

  public int GetAbilityPenaltyLimit() {
    int retVal = NWNXLibPINVOKE.CServerExoApp_GetAbilityPenaltyLimit(swigCPtr);
    return retVal;
  }

  public void SetAbilityPenaltyLimit(int newLimit, int isModuleOverride) {
    NWNXLibPINVOKE.CServerExoApp_SetAbilityPenaltyLimit__SWIG_0(swigCPtr, newLimit, isModuleOverride);
  }

  public void SetAbilityPenaltyLimit(int newLimit) {
    NWNXLibPINVOKE.CServerExoApp_SetAbilityPenaltyLimit__SWIG_1(swigCPtr, newLimit);
  }

  public int GetSkillBonusLimit() {
    int retVal = NWNXLibPINVOKE.CServerExoApp_GetSkillBonusLimit(swigCPtr);
    return retVal;
  }

  public void SetSkillBonusLimit(int newLimit, int isModuleOverride) {
    NWNXLibPINVOKE.CServerExoApp_SetSkillBonusLimit__SWIG_0(swigCPtr, newLimit, isModuleOverride);
  }

  public void SetSkillBonusLimit(int newLimit) {
    NWNXLibPINVOKE.CServerExoApp_SetSkillBonusLimit__SWIG_1(swigCPtr, newLimit);
  }

  public CExoString GetHostedPublicInternetAddressAndPort() {
    CExoString ret = new CExoString(NWNXLibPINVOKE.CServerExoApp_GetHostedPublicInternetAddressAndPort(swigCPtr), true);
    return ret;
  }

  public int SetDDCipherForModule(CExoString moduleName) {
    int retVal = NWNXLibPINVOKE.CServerExoApp_SetDDCipherForModule(swigCPtr, CExoString.getCPtr(moduleName));
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
    return retVal;
  }

  public AdvertLUT GetNWSyncAdvertLUT() {
    AdvertLUT ret = new AdvertLUT(NWNXLibPINVOKE.CServerExoApp_GetNWSyncAdvertLUT(swigCPtr), false);
    return ret;
  }

  public void SetGameObjectUpdateIntervalTarget(int target) {
    NWNXLibPINVOKE.CServerExoApp_SetGameObjectUpdateIntervalTarget(swigCPtr, target);
  }

  public void SetGameObjectUpdateIntervalTargetLoading(int target) {
    NWNXLibPINVOKE.CServerExoApp_SetGameObjectUpdateIntervalTargetLoading(swigCPtr, target);
  }

  public void SetGameObjectUpdateMessageLimit(int target) {
    NWNXLibPINVOKE.CServerExoApp_SetGameObjectUpdateMessageLimit(swigCPtr, target);
  }

  public void SetGameObjectUpdateMessageLimitLoading(int target) {
    NWNXLibPINVOKE.CServerExoApp_SetGameObjectUpdateMessageLimitLoading(swigCPtr, target);
  }

  public void _Destructor() {
    NWNXLibPINVOKE.CServerExoApp__Destructor(swigCPtr);
  }

}

}

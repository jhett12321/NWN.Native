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

public unsafe class CAppManager : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  public CAppManager(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  public CAppManager(void* cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, (global::System.IntPtr)cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(CAppManager obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~CAppManager() {
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
          NWNXLibPINVOKE.delete_CAppManager(swigCPtr);
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

  public static unsafe implicit operator void*(CAppManager self) {
    return (void*)self.swigCPtr.Handle;
  }

  public static implicit operator global::System.IntPtr(CAppManager self) {
    return self.swigCPtr.Handle;
  }

  public bool Equals(CAppManager other) {
    if (ReferenceEquals(null, other)) {
      return false;
    }

    if (ReferenceEquals(this, other)) {
      return true;
    }

    return Pointer.Equals(other.Pointer);
  }

  public override bool Equals(object obj) {
    return ReferenceEquals(this, obj) || obj is CAppManager other && Equals(other);
  }

  public override int GetHashCode() {
    return swigCPtr.Handle.GetHashCode();
  }

  public static bool operator ==(CAppManager left, CAppManager right) {
    return Equals(left, right);
  }

  public static bool operator !=(CAppManager left, CAppManager right) {
    return !Equals(left, right);
  }

  public SWIGTYPE_p_CClientExoApp m_pClientExoApp {
    set {
      NWNXLibPINVOKE.CAppManager_m_pClientExoApp_set(swigCPtr, SWIGTYPE_p_CClientExoApp.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = NWNXLibPINVOKE.CAppManager_m_pClientExoApp_get(swigCPtr);
      SWIGTYPE_p_CClientExoApp ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_CClientExoApp(cPtr, false);
      return ret;
    } 
  }

  public CServerExoApp m_pServerExoApp {
    set {
      NWNXLibPINVOKE.CAppManager_m_pServerExoApp_set(swigCPtr, CServerExoApp.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = NWNXLibPINVOKE.CAppManager_m_pServerExoApp_get(swigCPtr);
      CServerExoApp ret = (cPtr == global::System.IntPtr.Zero) ? null : new CServerExoApp(cPtr, false);
      return ret;
    } 
  }

  public CNWTileSetManager m_pNWTileSetManager {
    set {
      NWNXLibPINVOKE.CAppManager_m_pNWTileSetManager_set(swigCPtr, CNWTileSetManager.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = NWNXLibPINVOKE.CAppManager_m_pNWTileSetManager_get(swigCPtr);
      CNWTileSetManager ret = (cPtr == global::System.IntPtr.Zero) ? null : new CNWTileSetManager(cPtr, false);
      return ret;
    } 
  }

  public CObjectTableManager m_pClientObjectTableManager {
    set {
      NWNXLibPINVOKE.CAppManager_m_pClientObjectTableManager_set(swigCPtr, CObjectTableManager.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = NWNXLibPINVOKE.CAppManager_m_pClientObjectTableManager_get(swigCPtr);
      CObjectTableManager ret = (cPtr == global::System.IntPtr.Zero) ? null : new CObjectTableManager(cPtr, false);
      return ret;
    } 
  }

  public CObjectTableManager m_pServerObjectTableManager {
    set {
      NWNXLibPINVOKE.CAppManager_m_pServerObjectTableManager_set(swigCPtr, CObjectTableManager.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = NWNXLibPINVOKE.CAppManager_m_pServerObjectTableManager_get(swigCPtr);
      CObjectTableManager ret = (cPtr == global::System.IntPtr.Zero) ? null : new CObjectTableManager(cPtr, false);
      return ret;
    } 
  }

  public SWIGTYPE_p_CNWReentrantServerStats m_pReentrantServerStats {
    set {
      NWNXLibPINVOKE.CAppManager_m_pReentrantServerStats_set(swigCPtr, SWIGTYPE_p_CNWReentrantServerStats.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = NWNXLibPINVOKE.CAppManager_m_pReentrantServerStats_get(swigCPtr);
      SWIGTYPE_p_CNWReentrantServerStats ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_CNWReentrantServerStats(cPtr, false);
      return ret;
    } 
  }

  public int m_bDungeonMasterEXERunning {
    set {
      NWNXLibPINVOKE.CAppManager_m_bDungeonMasterEXERunning_set(swigCPtr, value);
    } 
    get {
      int ret = NWNXLibPINVOKE.CAppManager_m_bDungeonMasterEXERunning_get(swigCPtr);
      return ret;
    } 
  }

  public uint m_nApplicationId {
    set {
      NWNXLibPINVOKE.CAppManager_m_nApplicationId_set(swigCPtr, value);
    } 
    get {
      uint ret = NWNXLibPINVOKE.CAppManager_m_nApplicationId_get(swigCPtr);
      return ret;
    } 
  }

  public int m_bMultiplayerEnabled {
    set {
      NWNXLibPINVOKE.CAppManager_m_bMultiplayerEnabled_set(swigCPtr, value);
    } 
    get {
      int ret = NWNXLibPINVOKE.CAppManager_m_bMultiplayerEnabled_get(swigCPtr);
      return ret;
    } 
  }

  public int m_bWasPaused {
    set {
      NWNXLibPINVOKE.CAppManager_m_bWasPaused_set(swigCPtr, value);
    } 
    get {
      int ret = NWNXLibPINVOKE.CAppManager_m_bWasPaused_get(swigCPtr);
      return ret;
    } 
  }

  public int m_bDigitalDistributionModule {
    set {
      NWNXLibPINVOKE.CAppManager_m_bDigitalDistributionModule_set(swigCPtr, value);
    } 
    get {
      int ret = NWNXLibPINVOKE.CAppManager_m_bDigitalDistributionModule_get(swigCPtr);
      return ret;
    } 
  }

  public byte* m_pDDCipher {
    set {
      NWNXLibPINVOKE.CAppManager_m_pDDCipher_set(swigCPtr, (global::System.IntPtr)value);
    }  
    get {
        global::System.IntPtr retVal = NWNXLibPINVOKE.CAppManager_m_pDDCipher_get(swigCPtr); 
        return (byte*)retVal; 
    }

  }

  public uint m_nDDOffset {
    set {
      NWNXLibPINVOKE.CAppManager_m_nDDOffset_set(swigCPtr, value);
    } 
    get {
      uint ret = NWNXLibPINVOKE.CAppManager_m_nDDOffset_get(swigCPtr);
      return ret;
    } 
  }

  public uint m_nPlayerTimeout {
    set {
      NWNXLibPINVOKE.CAppManager_m_nPlayerTimeout_set(swigCPtr, value);
    } 
    get {
      uint ret = NWNXLibPINVOKE.CAppManager_m_nPlayerTimeout_get(swigCPtr);
      return ret;
    } 
  }

  public int m_bLogModelErrors {
    set {
      NWNXLibPINVOKE.CAppManager_m_bLogModelErrors_set(swigCPtr, value);
    } 
    get {
      int ret = NWNXLibPINVOKE.CAppManager_m_bLogModelErrors_get(swigCPtr);
      return ret;
    } 
  }

  public CAppManager() : this(NWNXLibPINVOKE.new_CAppManager(), true) {
  }

  public CObjectTableManager GetObjectTableManager(uint dwClientServer) {
    global::System.IntPtr cPtr = NWNXLibPINVOKE.CAppManager_GetObjectTableManager(swigCPtr, dwClientServer);
    CObjectTableManager ret = (cPtr == global::System.IntPtr.Zero) ? null : new CObjectTableManager(cPtr, false);
    return ret;
  }

  public void DoSaveGameScreenShot(CExoString sFile) {
    NWNXLibPINVOKE.CAppManager_DoSaveGameScreenShot(swigCPtr, CExoString.getCPtr(sFile));
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
  }

  public void ShowServerMem() {
    NWNXLibPINVOKE.CAppManager_ShowServerMem(swigCPtr);
  }

  public void CreateServer() {
    NWNXLibPINVOKE.CAppManager_CreateServer(swigCPtr);
  }

  public void DestroyServer() {
    NWNXLibPINVOKE.CAppManager_DestroyServer(swigCPtr);
  }

  public void SetDungeonMasterEXERunning(int bDM) {
    NWNXLibPINVOKE.CAppManager_SetDungeonMasterEXERunning(swigCPtr, bDM);
  }

  public int GetDungeonMasterEXERunning() {
    int ret = NWNXLibPINVOKE.CAppManager_GetDungeonMasterEXERunning(swigCPtr);
    return ret;
  }

  public void DisplayScriptDebuggerPopup() {
    NWNXLibPINVOKE.CAppManager_DisplayScriptDebuggerPopup(swigCPtr);
  }

  public void DestroyScriptDebuggerPopup() {
    NWNXLibPINVOKE.CAppManager_DestroyScriptDebuggerPopup(swigCPtr);
  }

  public int SetDDCipherForModule(CExoString moduleName) {
    int ret = NWNXLibPINVOKE.CAppManager_SetDDCipherForModule(swigCPtr, CExoString.getCPtr(moduleName));
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public byte ReadProgressFromINI(byte m_nCampaign) {
    byte ret = NWNXLibPINVOKE.CAppManager_ReadProgressFromINI(swigCPtr, m_nCampaign);
    return ret;
  }

  public void ConnectToServer(CExoString sAddress, int bPasswordRequired) {
    NWNXLibPINVOKE.CAppManager_ConnectToServer(swigCPtr, CExoString.getCPtr(sAddress), bPasswordRequired);
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
  }

  public CWorldTimer GetWorldTimer() {
    global::System.IntPtr cPtr = NWNXLibPINVOKE.CAppManager_GetWorldTimer(swigCPtr);
    CWorldTimer ret = (cPtr == global::System.IntPtr.Zero) ? null : new CWorldTimer(cPtr, false);
    return ret;
  }

  public CExoString GetCryptoKxPublicKeyBase64() {
    CExoString ret = new CExoString(NWNXLibPINVOKE.CAppManager_GetCryptoKxPublicKeyBase64(swigCPtr), true);
    return ret;
  }

  public CExoString GetPublicCdKey() {
    CExoString ret = new CExoString(NWNXLibPINVOKE.CAppManager_GetPublicCdKey(swigCPtr), true);
    return ret;
  }

  public byte GetPlatformId() {
    byte ret = NWNXLibPINVOKE.CAppManager_GetPlatformId(swigCPtr);
    return ret;
  }

  public byte GetLanguageId() {
    byte ret = NWNXLibPINVOKE.CAppManager_GetLanguageId(swigCPtr);
    return ret;
  }

}

}

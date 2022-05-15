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

public unsafe class CServerAIMaster : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal CServerAIMaster(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(CServerAIMaster obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~CServerAIMaster() {
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
          NWNXLibPINVOKE.delete_CServerAIMaster(swigCPtr);
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

  public static unsafe implicit operator void*(CServerAIMaster self) {
    return (void*)self.swigCPtr.Handle;
  }

  public static unsafe CServerAIMaster FromPointer(void* pointer, bool memoryOwn = false) {
    return pointer != null ? new CServerAIMaster((global::System.IntPtr)pointer, memoryOwn) : null;
  }

  public static CServerAIMaster FromPointer(global::System.IntPtr pointer, bool memoryOwn = false) {
    return pointer != global::System.IntPtr.Zero ? new CServerAIMaster(pointer, memoryOwn) : null;
  }

  public bool Equals(CServerAIMaster other) {
    if (ReferenceEquals(null, other)) {
      return false;
    }

    if (ReferenceEquals(this, other)) {
      return true;
    }

    return Pointer.Equals(other.Pointer);
  }

  public override bool Equals(object obj) {
    return ReferenceEquals(this, obj) || obj is CServerAIMaster other && Equals(other);
  }

  public override int GetHashCode() {
    return swigCPtr.Handle.GetHashCode();
  }

  public static bool operator ==(CServerAIMaster left, CServerAIMaster right) {
    return Equals(left, right);
  }

  public static bool operator !=(CServerAIMaster left, CServerAIMaster right) {
    return !Equals(left, right);
  }
/*@SWIG@*/
  public CServerExoAppInternal m_pExoAppInternal {
    set {
      NWNXLibPINVOKE.CServerAIMaster_m_pExoAppInternal_set(swigCPtr, CServerExoAppInternal.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = NWNXLibPINVOKE.CServerAIMaster_m_pExoAppInternal_get(swigCPtr);
      CServerExoAppInternal ret = (cPtr == global::System.IntPtr.Zero) ? null : new CServerExoAppInternal(cPtr, false);
      return ret;
    } 
  }

  public CServerAIListArray m_apGameAIList {
    set {
      NWNXLibPINVOKE.CServerAIMaster_m_apGameAIList_set(swigCPtr, CServerAIListArray.getCPtr(value));
    } 
    get {
        global::System.IntPtr cPtr = NWNXLibPINVOKE.CServerAIMaster_m_apGameAIList_get(swigCPtr);;
        CServerAIListArray ret = (cPtr == global::System.IntPtr.Zero) ? null : new CServerAIListArray(cPtr, false);
        return ret;
    }

  }

  public CExoLinkedListCServerAIEventNode m_lEventQueue {
    set {
      NWNXLibPINVOKE.CServerAIMaster_m_lEventQueue_set(swigCPtr, CExoLinkedListCServerAIEventNode.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = NWNXLibPINVOKE.CServerAIMaster_m_lEventQueue_get(swigCPtr);
      CExoLinkedListCServerAIEventNode ret = (cPtr == global::System.IntPtr.Zero) ? null : new CExoLinkedListCServerAIEventNode(cPtr, false);
      return ret;
    } 
  }

  public CGameEffectApplierRemover m_pGameEffectApplierRemover {
    set {
      NWNXLibPINVOKE.CServerAIMaster_m_pGameEffectApplierRemover_set(swigCPtr, CGameEffectApplierRemover.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = NWNXLibPINVOKE.CServerAIMaster_m_pGameEffectApplierRemover_get(swigCPtr);
      CGameEffectApplierRemover ret = (cPtr == global::System.IntPtr.Zero) ? null : new CGameEffectApplierRemover(cPtr, false);
      return ret;
    } 
  }

  public CItemPropertyApplierRemover m_pItemPropertyApplierRemover {
    set {
      NWNXLibPINVOKE.CServerAIMaster_m_pItemPropertyApplierRemover_set(swigCPtr, CItemPropertyApplierRemover.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = NWNXLibPINVOKE.CServerAIMaster_m_pItemPropertyApplierRemover_get(swigCPtr);
      CItemPropertyApplierRemover ret = (cPtr == global::System.IntPtr.Zero) ? null : new CItemPropertyApplierRemover(cPtr, false);
      return ret;
    } 
  }

  public int m_nScriptsRun {
    set {
      NWNXLibPINVOKE.CServerAIMaster_m_nScriptsRun_set(swigCPtr, value);
    } 
    get {
      int retVal = NWNXLibPINVOKE.CServerAIMaster_m_nScriptsRun_get(swigCPtr);
      return retVal;
    }

  }

  public int m_nScriptsRunSize {
    set {
      NWNXLibPINVOKE.CServerAIMaster_m_nScriptsRunSize_set(swigCPtr, value);
    } 
    get {
      int retVal = NWNXLibPINVOKE.CServerAIMaster_m_nScriptsRunSize_get(swigCPtr);
      return retVal;
    }

  }

  public CExoString m_psScriptsRun {
    set {
      NWNXLibPINVOKE.CServerAIMaster_m_psScriptsRun_set(swigCPtr, CExoString.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = NWNXLibPINVOKE.CServerAIMaster_m_psScriptsRun_get(swigCPtr);
      CExoString ret = (cPtr == global::System.IntPtr.Zero) ? null : new CExoString(cPtr, false);
      return ret;
    } 
  }

  public int m_bPlotPathRun {
    set {
      NWNXLibPINVOKE.CServerAIMaster_m_bPlotPathRun_set(swigCPtr, value);
    } 
    get {
      int retVal = NWNXLibPINVOKE.CServerAIMaster_m_bPlotPathRun_get(swigCPtr);
      return retVal;
    }

  }

  public int m_bGridPathRun {
    set {
      NWNXLibPINVOKE.CServerAIMaster_m_bGridPathRun_set(swigCPtr, value);
    } 
    get {
      int retVal = NWNXLibPINVOKE.CServerAIMaster_m_bGridPathRun_get(swigCPtr);
      return retVal;
    }

  }

  public int m_bUpdateVisibleListRun {
    set {
      NWNXLibPINVOKE.CServerAIMaster_m_bUpdateVisibleListRun_set(swigCPtr, value);
    } 
    get {
      int retVal = NWNXLibPINVOKE.CServerAIMaster_m_bUpdateVisibleListRun_get(swigCPtr);
      return retVal;
    }

  }

  public int m_bBroadcastAOORun {
    set {
      NWNXLibPINVOKE.CServerAIMaster_m_bBroadcastAOORun_set(swigCPtr, value);
    } 
    get {
      int retVal = NWNXLibPINVOKE.CServerAIMaster_m_bBroadcastAOORun_get(swigCPtr);
      return retVal;
    }

  }

  public int m_bTrapCheckRun {
    set {
      NWNXLibPINVOKE.CServerAIMaster_m_bTrapCheckRun_set(swigCPtr, value);
    } 
    get {
      int retVal = NWNXLibPINVOKE.CServerAIMaster_m_bTrapCheckRun_get(swigCPtr);
      return retVal;
    }

  }

  public int m_nLastActionRun {
    set {
      NWNXLibPINVOKE.CServerAIMaster_m_nLastActionRun_set(swigCPtr, value);
    } 
    get {
      int retVal = NWNXLibPINVOKE.CServerAIMaster_m_nLastActionRun_get(swigCPtr);
      return retVal;
    }

  }

  public CExoArrayListInt32 m_pAttackRepAdj {
    set {
      NWNXLibPINVOKE.CServerAIMaster_m_pAttackRepAdj_set(swigCPtr, CExoArrayListInt32.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = NWNXLibPINVOKE.CServerAIMaster_m_pAttackRepAdj_get(swigCPtr);
      CExoArrayListInt32 ret = (cPtr == global::System.IntPtr.Zero) ? null : new CExoArrayListInt32(cPtr, false);
      return ret;
    } 
  }

  public CExoArrayListInt32 m_pTheftRepAdj {
    set {
      NWNXLibPINVOKE.CServerAIMaster_m_pTheftRepAdj_set(swigCPtr, CExoArrayListInt32.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = NWNXLibPINVOKE.CServerAIMaster_m_pTheftRepAdj_get(swigCPtr);
      CExoArrayListInt32 ret = (cPtr == global::System.IntPtr.Zero) ? null : new CExoArrayListInt32(cPtr, false);
      return ret;
    } 
  }

  public CExoArrayListInt32 m_pKillRepAdj {
    set {
      NWNXLibPINVOKE.CServerAIMaster_m_pKillRepAdj_set(swigCPtr, CExoArrayListInt32.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = NWNXLibPINVOKE.CServerAIMaster_m_pKillRepAdj_get(swigCPtr);
      CExoArrayListInt32 ret = (cPtr == global::System.IntPtr.Zero) ? null : new CExoArrayListInt32(cPtr, false);
      return ret;
    } 
  }

  public CExoArrayListInt32 m_pHelpRepAdj {
    set {
      NWNXLibPINVOKE.CServerAIMaster_m_pHelpRepAdj_set(swigCPtr, CExoArrayListInt32.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = NWNXLibPINVOKE.CServerAIMaster_m_pHelpRepAdj_get(swigCPtr);
      CExoArrayListInt32 ret = (cPtr == global::System.IntPtr.Zero) ? null : new CExoArrayListInt32(cPtr, false);
      return ret;
    } 
  }

  public CServerAIMaster() : this(NWNXLibPINVOKE.new_CServerAIMaster(), true) {
  }

  public void SetExoAppInternal(CServerExoAppInternal pExoAppInternal) {
    NWNXLibPINVOKE.CServerAIMaster_SetExoAppInternal(swigCPtr, CServerExoAppInternal.getCPtr(pExoAppInternal));
  }

  public void UpdateState() {
    NWNXLibPINVOKE.CServerAIMaster_UpdateState(swigCPtr);
  }

  public void ClearEventQueue() {
    NWNXLibPINVOKE.CServerAIMaster_ClearEventQueue(swigCPtr);
  }

  public int AddObject(CNWSObject pObject, int nAILevel) {
    int retVal = NWNXLibPINVOKE.CServerAIMaster_AddObject(swigCPtr, CNWSObject.getCPtr(pObject), nAILevel);
    return retVal;
  }

  public int RemoveObject(CNWSObject pObject) {
    int retVal = NWNXLibPINVOKE.CServerAIMaster_RemoveObject(swigCPtr, CNWSObject.getCPtr(pObject));
    return retVal;
  }

  public int SetAILevel(CNWSObject pObject, int nAILevel) {
    int retVal = NWNXLibPINVOKE.CServerAIMaster_SetAILevel(swigCPtr, CNWSObject.getCPtr(pObject), nAILevel);
    return retVal;
  }

  public int AddEventDeltaTime(uint nDaysFromNow, uint nTimeFromNow, uint nCallerObjectId, uint nObjectId, uint nEventId, void* pScript) {
    int retVal = NWNXLibPINVOKE.CServerAIMaster_AddEventDeltaTime__SWIG_0(swigCPtr, nDaysFromNow, nTimeFromNow, nCallerObjectId, nObjectId, nEventId, (global::System.IntPtr)pScript);
    return retVal;
  }

  public int AddEventDeltaTime(uint nDaysFromNow, uint nTimeFromNow, uint nCallerObjectId, uint nObjectId, uint nEventId) {
    int retVal = NWNXLibPINVOKE.CServerAIMaster_AddEventDeltaTime__SWIG_1(swigCPtr, nDaysFromNow, nTimeFromNow, nCallerObjectId, nObjectId, nEventId);
    return retVal;
  }

  public int AddEventAbsoluteTime(uint nCalendarDay, uint nTimeOfDay, uint nCallerObjectId, uint nObjectId, uint nEventId, void* pScript) {
    int retVal = NWNXLibPINVOKE.CServerAIMaster_AddEventAbsoluteTime__SWIG_0(swigCPtr, nCalendarDay, nTimeOfDay, nCallerObjectId, nObjectId, nEventId, (global::System.IntPtr)pScript);
    return retVal;
  }

  public int AddEventAbsoluteTime(uint nCalendarDay, uint nTimeOfDay, uint nCallerObjectId, uint nObjectId, uint nEventId) {
    int retVal = NWNXLibPINVOKE.CServerAIMaster_AddEventAbsoluteTime__SWIG_1(swigCPtr, nCalendarDay, nTimeOfDay, nCallerObjectId, nObjectId, nEventId);
    return retVal;
  }

  public int AddEventAbsoluteTimeViaTail(uint nCalendarDay, uint nTimeOfDay, uint nCallerObjectId, uint nObjectId, uint nEventId, void* pScript) {
    int retVal = NWNXLibPINVOKE.CServerAIMaster_AddEventAbsoluteTimeViaTail__SWIG_0(swigCPtr, nCalendarDay, nTimeOfDay, nCallerObjectId, nObjectId, nEventId, (global::System.IntPtr)pScript);
    return retVal;
  }

  public int AddEventAbsoluteTimeViaTail(uint nCalendarDay, uint nTimeOfDay, uint nCallerObjectId, uint nObjectId, uint nEventId) {
    int retVal = NWNXLibPINVOKE.CServerAIMaster_AddEventAbsoluteTimeViaTail__SWIG_1(swigCPtr, nCalendarDay, nTimeOfDay, nCallerObjectId, nObjectId, nEventId);
    return retVal;
  }

  public int EventPending(uint nCalendarDay, uint nTimeOfDay) {
    int retVal = NWNXLibPINVOKE.CServerAIMaster_EventPending(swigCPtr, nCalendarDay, nTimeOfDay);
    return retVal;
  }

  public int GetPendingEvent(uint* nCalendarDay, uint* nTimeOfDay, uint* nCallerObjectId, uint* nObjectId, uint* nEventId, void** pScript) {
    int retVal = NWNXLibPINVOKE.CServerAIMaster_GetPendingEvent(swigCPtr, nCalendarDay, nTimeOfDay, nCallerObjectId, nObjectId, nEventId, (global::System.IntPtr)pScript);
    return retVal;
  }

  public int SaveEventQueue(CResGFF pRes, CResStruct pStruct) {
    int retVal = NWNXLibPINVOKE.CServerAIMaster_SaveEventQueue(swigCPtr, CResGFF.getCPtr(pRes), CResStruct.getCPtr(pStruct));
    return retVal;
  }

  public int LoadEventQueue(CResGFF pRes, CResStruct pStruct) {
    int retVal = NWNXLibPINVOKE.CServerAIMaster_LoadEventQueue(swigCPtr, CResGFF.getCPtr(pRes), CResStruct.getCPtr(pStruct));
    return retVal;
  }

  public int OnEffectApplied(CNWSObject pObject, CGameEffect effect, int bLoadingGame) {
    int retVal = NWNXLibPINVOKE.CServerAIMaster_OnEffectApplied__SWIG_0(swigCPtr, CNWSObject.getCPtr(pObject), CGameEffect.getCPtr(effect), bLoadingGame);
    return retVal;
  }

  public int OnEffectApplied(CNWSObject pObject, CGameEffect effect) {
    int retVal = NWNXLibPINVOKE.CServerAIMaster_OnEffectApplied__SWIG_1(swigCPtr, CNWSObject.getCPtr(pObject), CGameEffect.getCPtr(effect));
    return retVal;
  }

  public int OnEffectRemoved(CNWSObject pObject, CGameEffect effect) {
    int retVal = NWNXLibPINVOKE.CServerAIMaster_OnEffectRemoved(swigCPtr, CNWSObject.getCPtr(pObject), CGameEffect.getCPtr(effect));
    return retVal;
  }

  public int OnItemPropertyApplied(CNWSItem pItem, CNWItemProperty pItemProperty, CNWSCreature pTargetCreature, uint nTargetInventorySlot, int bLoadingGame) {
    int retVal = NWNXLibPINVOKE.CServerAIMaster_OnItemPropertyApplied(swigCPtr, CNWSItem.getCPtr(pItem), CNWItemProperty.getCPtr(pItemProperty), CNWSCreature.getCPtr(pTargetCreature), nTargetInventorySlot, bLoadingGame);
    return retVal;
  }

  public int OnItemPropertyRemoved(CNWSItem pItem, CNWItemProperty pItemProperty, CNWSCreature pTargetCreature, uint nTargetInventorySlot) {
    int retVal = NWNXLibPINVOKE.CServerAIMaster_OnItemPropertyRemoved(swigCPtr, CNWSItem.getCPtr(pItem), CNWItemProperty.getCPtr(pItemProperty), CNWSCreature.getCPtr(pTargetCreature), nTargetInventorySlot);
    return retVal;
  }

  public void AdjustTargetAndWitnessReputations(uint oidTarget, uint oidSource, int nActionType) {
    NWNXLibPINVOKE.CServerAIMaster_AdjustTargetAndWitnessReputations(swigCPtr, oidTarget, oidSource, nActionType);
  }

  public void LoadReputationAdjustments() {
    NWNXLibPINVOKE.CServerAIMaster_LoadReputationAdjustments(swigCPtr);
  }

  public void ClearScriptsRun() {
    NWNXLibPINVOKE.CServerAIMaster_ClearScriptsRun(swigCPtr);
  }

  public CExoString GetScriptsRun() {
    global::System.IntPtr cPtr = NWNXLibPINVOKE.CServerAIMaster_GetScriptsRun(swigCPtr);
    CExoString ret = (cPtr == global::System.IntPtr.Zero) ? null : new CExoString(cPtr, false);
    return ret;
  }

  public void AppendToScriptsRun(CExoString sScriptName) {
    NWNXLibPINVOKE.CServerAIMaster_AppendToScriptsRun(swigCPtr, CExoString.getCPtr(sScriptName));
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
  }

  public void DeleteEventData(uint nEventId, void* pEventData) {
    NWNXLibPINVOKE.CServerAIMaster_DeleteEventData(swigCPtr, nEventId, (global::System.IntPtr)pEventData);
  }

  public void _Destructor() {
    NWNXLibPINVOKE.CServerAIMaster__Destructor(swigCPtr);
  }

}

}

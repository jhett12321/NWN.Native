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

public class CNWSTrigger : CNWSObject {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;

  internal CNWSTrigger(global::System.IntPtr cPtr, bool cMemoryOwn) : base(NWNXLibPINVOKE.CNWSTrigger_SWIGUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(CNWSTrigger obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  protected override void Dispose(bool disposing) {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          NWNXLibPINVOKE.delete_CNWSTrigger(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      base.Dispose(disposing);
    }
  }

  public CExoLocString m_sLocalizedName {
    set {
      NWNXLibPINVOKE.CNWSTrigger_m_sLocalizedName_set(swigCPtr, CExoLocString.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = NWNXLibPINVOKE.CNWSTrigger_m_sLocalizedName_get(swigCPtr);
      CExoLocString ret = (cPtr == global::System.IntPtr.Zero) ? null : new CExoLocString(cPtr, false);
      return ret;
    } 
  }

  public CExoString m_sDescriptionOverride {
    set {
      NWNXLibPINVOKE.CNWSTrigger_m_sDescriptionOverride_set(swigCPtr, CExoString.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = NWNXLibPINVOKE.CNWSTrigger_m_sDescriptionOverride_get(swigCPtr);
      CExoString ret = (cPtr == global::System.IntPtr.Zero) ? null : new CExoString(cPtr, false);
      return ret;
    } 
  }

  public CExoString m_sScripts {
    set {
      NWNXLibPINVOKE.CNWSTrigger_m_sScripts_set(swigCPtr, CExoString.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = NWNXLibPINVOKE.CNWSTrigger_m_sScripts_get(swigCPtr);
      CExoString ret = (cPtr == global::System.IntPtr.Zero) ? null : new CExoString(cPtr, false);
      return ret;
    } 
  }

  public CExoString m_sKey {
    set {
      NWNXLibPINVOKE.CNWSTrigger_m_sKey_set(swigCPtr, CExoString.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = NWNXLibPINVOKE.CNWSTrigger_m_sKey_get(swigCPtr);
      CExoString ret = (cPtr == global::System.IntPtr.Zero) ? null : new CExoString(cPtr, false);
      return ret;
    } 
  }

  public int m_nVertices {
    set {
      NWNXLibPINVOKE.CNWSTrigger_m_nVertices_set(swigCPtr, value);
    } 
    get {
      int ret = NWNXLibPINVOKE.CNWSTrigger_m_nVertices_get(swigCPtr);
      return ret;
    } 
  }

  public Vector m_pvVertices {
    set {
      NWNXLibPINVOKE.CNWSTrigger_m_pvVertices_set(swigCPtr, Vector.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = NWNXLibPINVOKE.CNWSTrigger_m_pvVertices_get(swigCPtr);
      Vector ret = (cPtr == global::System.IntPtr.Zero) ? null : new Vector(cPtr, false);
      return ret;
    } 
  }

  public int m_nTriangles {
    set {
      NWNXLibPINVOKE.CNWSTrigger_m_nTriangles_set(swigCPtr, value);
    } 
    get {
      int ret = NWNXLibPINVOKE.CNWSTrigger_m_nTriangles_get(swigCPtr);
      return ret;
    } 
  }

  public SWIGTYPE_p_int m_pnTriangles {
    set {
      NWNXLibPINVOKE.CNWSTrigger_m_pnTriangles_set(swigCPtr, SWIGTYPE_p_int.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = NWNXLibPINVOKE.CNWSTrigger_m_pnTriangles_get(swigCPtr);
      SWIGTYPE_p_int ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_int(cPtr, false);
      return ret;
    } 
  }

  public int m_nOutlineVertices {
    set {
      NWNXLibPINVOKE.CNWSTrigger_m_nOutlineVertices_set(swigCPtr, value);
    } 
    get {
      int ret = NWNXLibPINVOKE.CNWSTrigger_m_nOutlineVertices_get(swigCPtr);
      return ret;
    } 
  }

  public SWIGTYPE_p_int m_pnOutlineVertices {
    set {
      NWNXLibPINVOKE.CNWSTrigger_m_pnOutlineVertices_set(swigCPtr, SWIGTYPE_p_int.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = NWNXLibPINVOKE.CNWSTrigger_m_pnOutlineVertices_get(swigCPtr);
      SWIGTYPE_p_int ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_int(cPtr, false);
      return ret;
    } 
  }

  public uint m_oidLastEntered {
    set {
      NWNXLibPINVOKE.CNWSTrigger_m_oidLastEntered_set(swigCPtr, value);
    } 
    get {
      uint ret = NWNXLibPINVOKE.CNWSTrigger_m_oidLastEntered_get(swigCPtr);
      return ret;
    } 
  }

  public uint m_oidLastLeft {
    set {
      NWNXLibPINVOKE.CNWSTrigger_m_oidLastLeft_set(swigCPtr, value);
    } 
    get {
      uint ret = NWNXLibPINVOKE.CNWSTrigger_m_oidLastLeft_get(swigCPtr);
      return ret;
    } 
  }

  public uint m_oidLastDisarmed {
    set {
      NWNXLibPINVOKE.CNWSTrigger_m_oidLastDisarmed_set(swigCPtr, value);
    } 
    get {
      uint ret = NWNXLibPINVOKE.CNWSTrigger_m_oidLastDisarmed_get(swigCPtr);
      return ret;
    } 
  }

  public CExoArrayListObjectId m_poidCreatures {
    set {
      NWNXLibPINVOKE.CNWSTrigger_m_poidCreatures_set(swigCPtr, CExoArrayListObjectId.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = NWNXLibPINVOKE.CNWSTrigger_m_poidCreatures_get(swigCPtr);
      CExoArrayListObjectId ret = (cPtr == global::System.IntPtr.Zero) ? null : new CExoArrayListObjectId(cPtr, false);
      return ret;
    } 
  }

  public int m_nFactionId {
    set {
      NWNXLibPINVOKE.CNWSTrigger_m_nFactionId_set(swigCPtr, value);
    } 
    get {
      int ret = NWNXLibPINVOKE.CNWSTrigger_m_nFactionId_get(swigCPtr);
      return ret;
    } 
  }

  public int m_bTrap {
    set {
      NWNXLibPINVOKE.CNWSTrigger_m_bTrap_set(swigCPtr, value);
    } 
    get {
      int ret = NWNXLibPINVOKE.CNWSTrigger_m_bTrap_get(swigCPtr);
      return ret;
    } 
  }

  public int m_bDetectable {
    set {
      NWNXLibPINVOKE.CNWSTrigger_m_bDetectable_set(swigCPtr, value);
    } 
    get {
      int ret = NWNXLibPINVOKE.CNWSTrigger_m_bDetectable_get(swigCPtr);
      return ret;
    } 
  }

  public int m_bDisarmable {
    set {
      NWNXLibPINVOKE.CNWSTrigger_m_bDisarmable_set(swigCPtr, value);
    } 
    get {
      int ret = NWNXLibPINVOKE.CNWSTrigger_m_bDisarmable_get(swigCPtr);
      return ret;
    } 
  }

  public int m_bFlagged {
    set {
      NWNXLibPINVOKE.CNWSTrigger_m_bFlagged_set(swigCPtr, value);
    } 
    get {
      int ret = NWNXLibPINVOKE.CNWSTrigger_m_bFlagged_get(swigCPtr);
      return ret;
    } 
  }

  public int m_bAutoRemoveKey {
    set {
      NWNXLibPINVOKE.CNWSTrigger_m_bAutoRemoveKey_set(swigCPtr, value);
    } 
    get {
      int ret = NWNXLibPINVOKE.CNWSTrigger_m_bAutoRemoveKey_get(swigCPtr);
      return ret;
    } 
  }

  public int m_bOneShot {
    set {
      NWNXLibPINVOKE.CNWSTrigger_m_bOneShot_set(swigCPtr, value);
    } 
    get {
      int ret = NWNXLibPINVOKE.CNWSTrigger_m_bOneShot_get(swigCPtr);
      return ret;
    } 
  }

  public byte m_nBaseType {
    set {
      NWNXLibPINVOKE.CNWSTrigger_m_nBaseType_set(swigCPtr, value);
    } 
    get {
      byte ret = NWNXLibPINVOKE.CNWSTrigger_m_nBaseType_get(swigCPtr);
      return ret;
    } 
  }

  public int m_nDCDetectCheck {
    set {
      NWNXLibPINVOKE.CNWSTrigger_m_nDCDetectCheck_set(swigCPtr, value);
    } 
    get {
      int ret = NWNXLibPINVOKE.CNWSTrigger_m_nDCDetectCheck_get(swigCPtr);
      return ret;
    } 
  }

  public int m_nDCDisarmCheck {
    set {
      NWNXLibPINVOKE.CNWSTrigger_m_nDCDisarmCheck_set(swigCPtr, value);
    } 
    get {
      int ret = NWNXLibPINVOKE.CNWSTrigger_m_nDCDisarmCheck_get(swigCPtr);
      return ret;
    } 
  }

  public int m_bRecoverable {
    set {
      NWNXLibPINVOKE.CNWSTrigger_m_bRecoverable_set(swigCPtr, value);
    } 
    get {
      int ret = NWNXLibPINVOKE.CNWSTrigger_m_bRecoverable_get(swigCPtr);
      return ret;
    } 
  }

  public int m_bTrapIsActive {
    set {
      NWNXLibPINVOKE.CNWSTrigger_m_bTrapIsActive_set(swigCPtr, value);
    } 
    get {
      int ret = NWNXLibPINVOKE.CNWSTrigger_m_bTrapIsActive_get(swigCPtr);
      return ret;
    } 
  }

  public ushort m_nObjectArrayIndex {
    set {
      NWNXLibPINVOKE.CNWSTrigger_m_nObjectArrayIndex_set(swigCPtr, value);
    } 
    get {
      ushort ret = NWNXLibPINVOKE.CNWSTrigger_m_nObjectArrayIndex_get(swigCPtr);
      return ret;
    } 
  }

  public float m_fTriggerHeight {
    set {
      NWNXLibPINVOKE.CNWSTrigger_m_fTriggerHeight_set(swigCPtr, value);
    } 
    get {
      float ret = NWNXLibPINVOKE.CNWSTrigger_m_fTriggerHeight_get(swigCPtr);
      return ret;
    } 
  }

  public uint m_oidCreator {
    set {
      NWNXLibPINVOKE.CNWSTrigger_m_oidCreator_set(swigCPtr, value);
    } 
    get {
      uint ret = NWNXLibPINVOKE.CNWSTrigger_m_oidCreator_get(swigCPtr);
      return ret;
    } 
  }

  public float m_fBoundingBoxMinX {
    set {
      NWNXLibPINVOKE.CNWSTrigger_m_fBoundingBoxMinX_set(swigCPtr, value);
    } 
    get {
      float ret = NWNXLibPINVOKE.CNWSTrigger_m_fBoundingBoxMinX_get(swigCPtr);
      return ret;
    } 
  }

  public float m_fBoundingBoxMaxX {
    set {
      NWNXLibPINVOKE.CNWSTrigger_m_fBoundingBoxMaxX_set(swigCPtr, value);
    } 
    get {
      float ret = NWNXLibPINVOKE.CNWSTrigger_m_fBoundingBoxMaxX_get(swigCPtr);
      return ret;
    } 
  }

  public float m_fBoundingBoxMinY {
    set {
      NWNXLibPINVOKE.CNWSTrigger_m_fBoundingBoxMinY_set(swigCPtr, value);
    } 
    get {
      float ret = NWNXLibPINVOKE.CNWSTrigger_m_fBoundingBoxMinY_get(swigCPtr);
      return ret;
    } 
  }

  public float m_fBoundingBoxMaxY {
    set {
      NWNXLibPINVOKE.CNWSTrigger_m_fBoundingBoxMaxY_set(swigCPtr, value);
    } 
    get {
      float ret = NWNXLibPINVOKE.CNWSTrigger_m_fBoundingBoxMaxY_get(swigCPtr);
      return ret;
    } 
  }

  public int m_nCustomScriptEventId {
    set {
      NWNXLibPINVOKE.CNWSTrigger_m_nCustomScriptEventId_set(swigCPtr, value);
    } 
    get {
      int ret = NWNXLibPINVOKE.CNWSTrigger_m_nCustomScriptEventId_get(swigCPtr);
      return ret;
    } 
  }

  public byte m_nCursor {
    set {
      NWNXLibPINVOKE.CNWSTrigger_m_nCursor_set(swigCPtr, value);
    } 
    get {
      byte ret = NWNXLibPINVOKE.CNWSTrigger_m_nCursor_get(swigCPtr);
      return ret;
    } 
  }

  public uint m_nLastHeartbeatScriptTimeOfDay {
    set {
      NWNXLibPINVOKE.CNWSTrigger_m_nLastHeartbeatScriptTimeOfDay_set(swigCPtr, value);
    } 
    get {
      uint ret = NWNXLibPINVOKE.CNWSTrigger_m_nLastHeartbeatScriptTimeOfDay_get(swigCPtr);
      return ret;
    } 
  }

  public uint m_nLastHeartbeatScriptCalendarDay {
    set {
      NWNXLibPINVOKE.CNWSTrigger_m_nLastHeartbeatScriptCalendarDay_set(swigCPtr, value);
    } 
    get {
      uint ret = NWNXLibPINVOKE.CNWSTrigger_m_nLastHeartbeatScriptCalendarDay_get(swigCPtr);
      return ret;
    } 
  }

  public ushort m_nLoadScreenID {
    set {
      NWNXLibPINVOKE.CNWSTrigger_m_nLoadScreenID_set(swigCPtr, value);
    } 
    get {
      ushort ret = NWNXLibPINVOKE.CNWSTrigger_m_nLoadScreenID_get(swigCPtr);
      return ret;
    } 
  }

  public CNWSTrigger(uint oidId) : this(NWNXLibPINVOKE.new_CNWSTrigger__SWIG_0(oidId), true) {
  }

  public CNWSTrigger() : this(NWNXLibPINVOKE.new_CNWSTrigger__SWIG_1(), true) {
  }

  public void AddToArea(CNWSArea pArea, float fX, float fY, float fZ, int bRunScripts) {
    NWNXLibPINVOKE.CNWSTrigger_AddToArea__SWIG_0(swigCPtr, CNWSArea.getCPtr(pArea), fX, fY, fZ, bRunScripts);
  }

  public void AddToArea(CNWSArea pArea, float fX, float fY, float fZ) {
    NWNXLibPINVOKE.CNWSTrigger_AddToArea__SWIG_1(swigCPtr, CNWSArea.getCPtr(pArea), fX, fY, fZ);
  }

  public override void AIUpdate() {
    NWNXLibPINVOKE.CNWSTrigger_AIUpdate(swigCPtr);
  }

  public Vector GetFacingPosition() {
    Vector ret = new Vector(NWNXLibPINVOKE.CNWSTrigger_GetFacingPosition(swigCPtr), true);
    return ret;
  }

  public override CNWSTrigger AsNWSTrigger() {
    global::System.IntPtr cPtr = NWNXLibPINVOKE.CNWSTrigger_AsNWSTrigger(swigCPtr);
    CNWSTrigger ret = (cPtr == global::System.IntPtr.Zero) ? null : new CNWSTrigger(cPtr, false);
    return ret;
  }

  public void ComputeBoundingBox(SWIGTYPE_p_float fXMin, SWIGTYPE_p_float fYMin, SWIGTYPE_p_float fXMax, SWIGTYPE_p_float fYMax) {
    NWNXLibPINVOKE.CNWSTrigger_ComputeBoundingBox(swigCPtr, SWIGTYPE_p_float.getCPtr(fXMin), SWIGTYPE_p_float.getCPtr(fYMin), SWIGTYPE_p_float.getCPtr(fXMax), SWIGTYPE_p_float.getCPtr(fYMax));
  }

  public override void EventHandler(uint nEventId, uint nCallerObjectId, SWIGTYPE_p_void pScript, uint nCalendarDay, uint nTimeOfDay) {
    NWNXLibPINVOKE.CNWSTrigger_EventHandler(swigCPtr, nEventId, nCallerObjectId, SWIGTYPE_p_void.getCPtr(pScript), nCalendarDay, nTimeOfDay);
  }

  public uint GetTargetArea() {
    uint ret = NWNXLibPINVOKE.CNWSTrigger_GetTargetArea(swigCPtr);
    return ret;
  }

  public int GetClosestPointWithinTrigger(Vector vCurrentPosition, Vector vTriggerPoint) {
    int ret = NWNXLibPINVOKE.CNWSTrigger_GetClosestPointWithinTrigger(swigCPtr, Vector.getCPtr(vCurrentPosition), Vector.getCPtr(vTriggerPoint));
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public int CalculateNearestPoint(Vector vPosition, Vector vIntersectionPoint) {
    int ret = NWNXLibPINVOKE.CNWSTrigger_CalculateNearestPoint(swigCPtr, Vector.getCPtr(vPosition), Vector.getCPtr(vIntersectionPoint));
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public int InTrigger(Vector vPosition) {
    int ret = NWNXLibPINVOKE.CNWSTrigger_InTrigger(swigCPtr, Vector.getCPtr(vPosition));
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public CExoString GetScriptName(int nScript) {
    global::System.IntPtr cPtr = NWNXLibPINVOKE.CNWSTrigger_GetScriptName(swigCPtr, nScript);
    CExoString ret = (cPtr == global::System.IntPtr.Zero) ? null : new CExoString(cPtr, false);
    return ret;
  }

  public int LoadFromTemplate(CResRef cResRef) {
    int ret = NWNXLibPINVOKE.CNWSTrigger_LoadFromTemplate(swigCPtr, CResRef.getCPtr(cResRef));
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public int LoadTrigger(CResGFF pRes, CResStruct cTriggerStruct) {
    int ret = NWNXLibPINVOKE.CNWSTrigger_LoadTrigger(swigCPtr, CResGFF.getCPtr(pRes), CResStruct.getCPtr(cTriggerStruct));
    return ret;
  }

  public int SaveTrigger(CResGFF pRes, CResStruct pStruct) {
    int ret = NWNXLibPINVOKE.CNWSTrigger_SaveTrigger(swigCPtr, CResGFF.getCPtr(pRes), CResStruct.getCPtr(pStruct));
    return ret;
  }

  public void RemoveFromArea() {
    NWNXLibPINVOKE.CNWSTrigger_RemoveFromArea(swigCPtr);
  }

  public void CreateNewGeometry(float fGeometrySize, Vector vPosition, CNWSArea pArea) {
    NWNXLibPINVOKE.CNWSTrigger_CreateNewGeometry__SWIG_0(swigCPtr, fGeometrySize, Vector.getCPtr(vPosition), CNWSArea.getCPtr(pArea));
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
  }

  public void CreateNewGeometry(float fGeometrySize, CScriptLocation lTriggerLocation, CNWSArea pArea) {
    NWNXLibPINVOKE.CNWSTrigger_CreateNewGeometry__SWIG_1(swigCPtr, fGeometrySize, CScriptLocation.getCPtr(lTriggerLocation), CNWSArea.getCPtr(pArea));
  }

  public int LineSegmentIntersectTrigger(Vector vStartLine, Vector vEndLine) {
    int ret = NWNXLibPINVOKE.CNWSTrigger_LineSegmentIntersectTrigger(swigCPtr, Vector.getCPtr(vStartLine), Vector.getCPtr(vEndLine));
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public int GetCanFireTrapOnObject(uint oidCreatureEntered, int bForceSet) {
    int ret = NWNXLibPINVOKE.CNWSTrigger_GetCanFireTrapOnObject(swigCPtr, oidCreatureEntered, bForceSet);
    return ret;
  }

  public void OnEnterTrap(int bForceSet) {
    NWNXLibPINVOKE.CNWSTrigger_OnEnterTrap(swigCPtr, bForceSet);
  }

}

}
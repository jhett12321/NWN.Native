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

public unsafe class CNWSTile : CNWTile {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;

  internal CNWSTile(global::System.IntPtr cPtr, bool cMemoryOwn) : base(NWNXLibPINVOKE.CNWSTile_SWIGUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(CNWSTile obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  protected override void Dispose(bool disposing) {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          NWNXLibPINVOKE.delete_CNWSTile(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      base.Dispose(disposing);
    }
  }
/*@SWIG:/__w/NWN.Native/NWN.Native/nwnx/Plugins/SWIG/SWIG_DotNET/API_NWNXLib.i,20,SWIG_DOTNET_EXTENSIONS@*/
  public global::System.IntPtr Pointer {
    get {
      return swigCPtr.Handle;
    }
  }

  public static unsafe implicit operator void*(CNWSTile self) {
    return (void*)self.swigCPtr.Handle;
  }

  public static unsafe CNWSTile FromPointer(void* pointer, bool memoryOwn = false) {
    return pointer != null ? new CNWSTile((global::System.IntPtr)pointer, memoryOwn) : null;
  }

  public static CNWSTile FromPointer(global::System.IntPtr pointer, bool memoryOwn = false) {
    return pointer != global::System.IntPtr.Zero ? new CNWSTile(pointer, memoryOwn) : null;
  }

  public bool Equals(CNWSTile other) {
    if (ReferenceEquals(null, other)) {
      return false;
    }

    if (ReferenceEquals(this, other)) {
      return true;
    }

    return Pointer.Equals(other.Pointer);
  }

  public override bool Equals(object obj) {
    return ReferenceEquals(this, obj) || obj is CNWSTile other && Equals(other);
  }

  public override int GetHashCode() {
    return swigCPtr.Handle.GetHashCode();
  }

  public static bool operator ==(CNWSTile left, CNWSTile right) {
    return Equals(left, right);
  }

  public static bool operator !=(CNWSTile left, CNWSTile right) {
    return !Equals(left, right);
  }
/*@SWIG@*/
  public CNWTileData m_pTileData {
    set {
      NWNXLibPINVOKE.CNWSTile_m_pTileData_set(swigCPtr, CNWTileData.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = NWNXLibPINVOKE.CNWSTile_m_pTileData_get(swigCPtr);
      CNWTileData ret = (cPtr == global::System.IntPtr.Zero) ? null : new CNWTileData(cPtr, false);
      return ret;
    } 
  }

  public int m_nTriggers {
    set {
      NWNXLibPINVOKE.CNWSTile_m_nTriggers_set(swigCPtr, value);
    } 
    get {
      int ret = NWNXLibPINVOKE.CNWSTile_m_nTriggers_get(swigCPtr);
      return ret;
    } 
  }

  public int m_nTriggerSize {
    set {
      NWNXLibPINVOKE.CNWSTile_m_nTriggerSize_set(swigCPtr, value);
    } 
    get {
      int ret = NWNXLibPINVOKE.CNWSTile_m_nTriggerSize_get(swigCPtr);
      return ret;
    } 
  }

  public uint* m_poidTriggers {
    set {
      NWNXLibPINVOKE.CNWSTile_m_poidTriggers_set(swigCPtr, (global::System.IntPtr)value);
    } 
    get {
        global::System.IntPtr retVal = NWNXLibPINVOKE.CNWSTile_m_poidTriggers_get(swigCPtr);
        return (uint*)retVal;
    }

  }

  public CExoArrayListObjectId m_aDoors {
    set {
      NWNXLibPINVOKE.CNWSTile_m_aDoors_set(swigCPtr, CExoArrayListObjectId.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = NWNXLibPINVOKE.CNWSTile_m_aDoors_get(swigCPtr);
      CExoArrayListObjectId ret = (cPtr == global::System.IntPtr.Zero) ? null : new CExoArrayListObjectId(cPtr, false);
      return ret;
    } 
  }

  public int m_bMainLightColorChange {
    set {
      NWNXLibPINVOKE.CNWSTile_m_bMainLightColorChange_set(swigCPtr, value);
    } 
    get {
      int ret = NWNXLibPINVOKE.CNWSTile_m_bMainLightColorChange_get(swigCPtr);
      return ret;
    } 
  }

  public int m_bSourceLightColorChange {
    set {
      NWNXLibPINVOKE.CNWSTile_m_bSourceLightColorChange_set(swigCPtr, value);
    } 
    get {
      int ret = NWNXLibPINVOKE.CNWSTile_m_bSourceLightColorChange_get(swigCPtr);
      return ret;
    } 
  }

  public int m_bFlaggedAsProblem {
    set {
      NWNXLibPINVOKE.CNWSTile_m_bFlaggedAsProblem_set(swigCPtr, value);
    } 
    get {
      int ret = NWNXLibPINVOKE.CNWSTile_m_bFlaggedAsProblem_get(swigCPtr);
      return ret;
    } 
  }

  public int m_bHasPlaceableWithWalkMesh {
    set {
      NWNXLibPINVOKE.CNWSTile_m_bHasPlaceableWithWalkMesh_set(swigCPtr, value);
    } 
    get {
      int ret = NWNXLibPINVOKE.CNWSTile_m_bHasPlaceableWithWalkMesh_get(swigCPtr);
      return ret;
    } 
  }

  public CNWSTile() : this(NWNXLibPINVOKE.new_CNWSTile(), true) {
  }

  public void AddTrigger(uint oidTrigger) {
    NWNXLibPINVOKE.CNWSTile_AddTrigger(swigCPtr, oidTrigger);
  }

  public int ClearLineOfSight(int nDirectionHeuristic, Vector vSource, Vector vTarget, Vector vImpact) {
    int ret = NWNXLibPINVOKE.CNWSTile_ClearLineOfSight(swigCPtr, nDirectionHeuristic, Vector.getCPtr(vSource), Vector.getCPtr(vTarget), Vector.getCPtr(vImpact));
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public int ClippedLineSegmentWalkable(float fStartX, float fStartY, float fEndX, float fEndY, float* fClipStartX, float* fClipStartY, float* fClipEndX, float* fClipEndY, float* fClipMinZ, float* fClipMaxZ) {
    int ret = NWNXLibPINVOKE.CNWSTile_ClippedLineSegmentWalkable(swigCPtr, fStartX, fStartY, fEndX, fEndY, (global::System.IntPtr)fClipStartX, (global::System.IntPtr)fClipStartY, (global::System.IntPtr)fClipEndX, (global::System.IntPtr)fClipEndY, (global::System.IntPtr)fClipMinZ, (global::System.IntPtr)fClipMaxZ);
    return ret;
  }

  public int ComputeClippedLineSegment(Vector vSource, Vector vTarget, Vector vClipSource, Vector vClipTarget) {
    int ret = NWNXLibPINVOKE.CNWSTile_ComputeClippedLineSegment(swigCPtr, Vector.getCPtr(vSource), Vector.getCPtr(vTarget), Vector.getCPtr(vClipSource), Vector.getCPtr(vClipTarget));
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public float ComputeHeight(Vector vPosition) {
    float ret = NWNXLibPINVOKE.CNWSTile_ComputeHeight(swigCPtr, Vector.getCPtr(vPosition));
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public int FindClosestRegion(float fX, float fY) {
    int ret = NWNXLibPINVOKE.CNWSTile_FindClosestRegion(swigCPtr, fX, fY);
    return ret;
  }

  public int GetExit(int nExit, float* fX, float* fY, int* nRegion) {
    int ret = NWNXLibPINVOKE.CNWSTile_GetExit(swigCPtr, nExit, (global::System.IntPtr)fX, (global::System.IntPtr)fY, (global::System.IntPtr)nRegion);
    return ret;
  }

  public int GetExitNumber(float fX, float fY) {
    int ret = NWNXLibPINVOKE.CNWSTile_GetExitNumber(swigCPtr, fX, fY);
    return ret;
  }

  public int GetRegionCoords(int nRegion, float* fX, float* fY) {
    int ret = NWNXLibPINVOKE.CNWSTile_GetRegionCoords(swigCPtr, nRegion, (global::System.IntPtr)fX, (global::System.IntPtr)fY);
    return ret;
  }

  public int GetRegionEntrance(float fX, float fY) {
    int ret = NWNXLibPINVOKE.CNWSTile_GetRegionEntrance(swigCPtr, fX, fY);
    return ret;
  }

  public int GetSurfaceMaterial(Vector vPosition) {
    int ret = NWNXLibPINVOKE.CNWSTile_GetSurfaceMaterial(swigCPtr, Vector.getCPtr(vPosition));
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public CNWTileData GetTileData() {
    global::System.IntPtr cPtr = NWNXLibPINVOKE.CNWSTile_GetTileData(swigCPtr);
    CNWTileData ret = (cPtr == global::System.IntPtr.Zero) ? null : new CNWTileData(cPtr, false);
    return ret;
  }

  public int GetTotalExits() {
    int ret = NWNXLibPINVOKE.CNWSTile_GetTotalExits(swigCPtr);
    return ret;
  }

  public int IntersectLineSegments(float fX1, float fY1, float fX2, float fY2, float fX3, float fY3, float fX4, float fY4, float* fXIntersect, float* fYIntersect) {
    int ret = NWNXLibPINVOKE.CNWSTile_IntersectLineSegments(swigCPtr, fX1, fY1, fX2, fY2, fX3, fY3, fX4, fY4, (global::System.IntPtr)fXIntersect, (global::System.IntPtr)fYIntersect);
    return ret;
  }

  public int InTrigger(Vector vPosition, CExoArrayListObjectId aTriggers) {
    int ret = NWNXLibPINVOKE.CNWSTile_InTrigger(swigCPtr, Vector.getCPtr(vPosition), CExoArrayListObjectId.getCPtr(aTriggers));
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public CResRef GetWalkMesh() {
    CResRef ret = new CResRef(NWNXLibPINVOKE.CNWSTile_GetWalkMesh(swigCPtr), true);
    return ret;
  }

  public int LoadWalkMesh() {
    int ret = NWNXLibPINVOKE.CNWSTile_LoadWalkMesh(swigCPtr);
    return ret;
  }

  public int NoNonWalkPolysOnTile(float fSourceX, float fSourceY, float fTargetX, float fTargetY, float fMinZ, float fMaxZ, float fPersonalSpace, int bTestSinglePoint) {
    int ret = NWNXLibPINVOKE.CNWSTile_NoNonWalkPolysOnTile__SWIG_0(swigCPtr, fSourceX, fSourceY, fTargetX, fTargetY, fMinZ, fMaxZ, fPersonalSpace, bTestSinglePoint);
    return ret;
  }

  public int NoNonWalkPolysOnTile(float fSourceX, float fSourceY, float fTargetX, float fTargetY, float fMinZ, float fMaxZ, float fPersonalSpace) {
    int ret = NWNXLibPINVOKE.CNWSTile_NoNonWalkPolysOnTile__SWIG_1(swigCPtr, fSourceX, fSourceY, fTargetX, fTargetY, fMinZ, fMaxZ, fPersonalSpace);
    return ret;
  }

  public uint PlotIntraTilePath(CNWArea pWalkGeometry, CPathfindInformation pPathfindInformation, float fCurrentIntraTileX, float fCurrentIntraTileY, float fInterTileStartX, float fInterTileStartY, uint nMaxTimeAllowed) {
    uint ret = NWNXLibPINVOKE.CNWSTile_PlotIntraTilePath(swigCPtr, CNWArea.getCPtr(pWalkGeometry), CPathfindInformation.getCPtr(pPathfindInformation), fCurrentIntraTileX, fCurrentIntraTileY, fInterTileStartX, fInterTileStartY, nMaxTimeAllowed);
    return ret;
  }

  public void SetTileData(CNWTileData pTileData) {
    NWNXLibPINVOKE.CNWSTile_SetTileData(swigCPtr, CNWTileData.getCPtr(pTileData));
  }

  public virtual new void SetMainLightColor(byte nMainLight1Color, byte nMainLight2Color) {
    NWNXLibPINVOKE.CNWSTile_SetMainLightColor(swigCPtr, nMainLight1Color, nMainLight2Color);
  }

  public virtual new void SetSourceLightColor(byte nSourceLight1Color, byte nSourceLight2Color) {
    NWNXLibPINVOKE.CNWSTile_SetSourceLightColor(swigCPtr, nSourceLight1Color, nSourceLight2Color);
  }

}

}

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

public unsafe class CNWSAreaOfEffectObject : CNWSObject {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;

  internal CNWSAreaOfEffectObject(global::System.IntPtr cPtr, bool cMemoryOwn) : base(NWNXLibPINVOKE.CNWSAreaOfEffectObject_SWIGUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(CNWSAreaOfEffectObject obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  protected override void Dispose(bool disposing) {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          NWNXLibPINVOKE.delete_CNWSAreaOfEffectObject(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      base.Dispose(disposing);
    }
  }
/*@SWIG:/__w/NWN.Native/NWN.Native/nwnx/Plugins/SWIG/SWIG_DotNET/DotNETExtensions.i,1,SWIG_DOTNET_EXTENSIONS@*/
  public global::System.IntPtr Pointer {
    get {
      return swigCPtr.Handle;
    }
  }

  public static unsafe implicit operator void*(CNWSAreaOfEffectObject self) {
    return (void*)self.swigCPtr.Handle;
  }

  public static unsafe CNWSAreaOfEffectObject FromPointer(void* pointer, bool memoryOwn = false) {
    return pointer != null ? new CNWSAreaOfEffectObject((global::System.IntPtr)pointer, memoryOwn) : null;
  }

  public static CNWSAreaOfEffectObject FromPointer(global::System.IntPtr pointer, bool memoryOwn = false) {
    return pointer != global::System.IntPtr.Zero ? new CNWSAreaOfEffectObject(pointer, memoryOwn) : null;
  }

  public bool Equals(CNWSAreaOfEffectObject other) {
    if (ReferenceEquals(null, other)) {
      return false;
    }

    if (ReferenceEquals(this, other)) {
      return true;
    }

    return Pointer.Equals(other.Pointer);
  }

  public override bool Equals(object obj) {
    return ReferenceEquals(this, obj) || obj is CNWSAreaOfEffectObject other && Equals(other);
  }

  public override int GetHashCode() {
    return swigCPtr.Handle.GetHashCode();
  }

  public static bool operator ==(CNWSAreaOfEffectObject left, CNWSAreaOfEffectObject right) {
    return Equals(left, right);
  }

  public static bool operator !=(CNWSAreaOfEffectObject left, CNWSAreaOfEffectObject right) {
    return !Equals(left, right);
  }
/*@SWIG@*/
  public ushort m_nObjectArrayIndex {
    set {
      NWNXLibPINVOKE.CNWSAreaOfEffectObject_m_nObjectArrayIndex_set(swigCPtr, value);
    } 
    get {
      ushort retVal = NWNXLibPINVOKE.CNWSAreaOfEffectObject_m_nObjectArrayIndex_get(swigCPtr);
      return retVal;
    }

  }

  public int m_nAreaEffectId {
    set {
      NWNXLibPINVOKE.CNWSAreaOfEffectObject_m_nAreaEffectId_set(swigCPtr, value);
    } 
    get {
      int retVal = NWNXLibPINVOKE.CNWSAreaOfEffectObject_m_nAreaEffectId_get(swigCPtr);
      return retVal;
    }

  }

  public byte m_nShape {
    set {
      NWNXLibPINVOKE.CNWSAreaOfEffectObject_m_nShape_set(swigCPtr, value);
    } 
    get {
      byte retVal = NWNXLibPINVOKE.CNWSAreaOfEffectObject_m_nShape_get(swigCPtr);
      return retVal;
    }

  }

  public uint m_nSpellId {
    set {
      NWNXLibPINVOKE.CNWSAreaOfEffectObject_m_nSpellId_set(swigCPtr, value);
    } 
    get {
      uint retVal = NWNXLibPINVOKE.CNWSAreaOfEffectObject_m_nSpellId_get(swigCPtr);
      return retVal;
    }

  }

  public float m_fRadius {
    set {
      NWNXLibPINVOKE.CNWSAreaOfEffectObject_m_fRadius_set(swigCPtr, value);
    } 
    get {
      float retVal = NWNXLibPINVOKE.CNWSAreaOfEffectObject_m_fRadius_get(swigCPtr);
      return retVal;
    }

  }

  public float m_fWidth {
    set {
      NWNXLibPINVOKE.CNWSAreaOfEffectObject_m_fWidth_set(swigCPtr, value);
    } 
    get {
      float retVal = NWNXLibPINVOKE.CNWSAreaOfEffectObject_m_fWidth_get(swigCPtr);
      return retVal;
    }

  }

  public float m_fLength {
    set {
      NWNXLibPINVOKE.CNWSAreaOfEffectObject_m_fLength_set(swigCPtr, value);
    } 
    get {
      float retVal = NWNXLibPINVOKE.CNWSAreaOfEffectObject_m_fLength_get(swigCPtr);
      return retVal;
    }

  }

  public Vector m_pVertices {
    set {
      NWNXLibPINVOKE.CNWSAreaOfEffectObject_m_pVertices_set(swigCPtr, Vector.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = NWNXLibPINVOKE.CNWSAreaOfEffectObject_m_pVertices_get(swigCPtr);
      Vector ret = (cPtr == global::System.IntPtr.Zero) ? null : new Vector(cPtr, false);
      return ret;
    } 
  }

  public uint m_oidCreator {
    set {
      NWNXLibPINVOKE.CNWSAreaOfEffectObject_m_oidCreator_set(swigCPtr, value);
    } 
    get {
      uint retVal = NWNXLibPINVOKE.CNWSAreaOfEffectObject_m_oidCreator_get(swigCPtr);
      return retVal;
    }

  }

  public uint m_oidLinkedToObj {
    set {
      NWNXLibPINVOKE.CNWSAreaOfEffectObject_m_oidLinkedToObj_set(swigCPtr, value);
    } 
    get {
      uint retVal = NWNXLibPINVOKE.CNWSAreaOfEffectObject_m_oidLinkedToObj_get(swigCPtr);
      return retVal;
    }

  }

  public uint m_oidLastEntered {
    set {
      NWNXLibPINVOKE.CNWSAreaOfEffectObject_m_oidLastEntered_set(swigCPtr, value);
    } 
    get {
      uint retVal = NWNXLibPINVOKE.CNWSAreaOfEffectObject_m_oidLastEntered_get(swigCPtr);
      return retVal;
    }

  }

  public uint m_oidLastLeft {
    set {
      NWNXLibPINVOKE.CNWSAreaOfEffectObject_m_oidLastLeft_set(swigCPtr, value);
    } 
    get {
      uint retVal = NWNXLibPINVOKE.CNWSAreaOfEffectObject_m_oidLastLeft_get(swigCPtr);
      return retVal;
    }

  }

  public int m_nSpellSaveDC {
    set {
      NWNXLibPINVOKE.CNWSAreaOfEffectObject_m_nSpellSaveDC_set(swigCPtr, value);
    } 
    get {
      int retVal = NWNXLibPINVOKE.CNWSAreaOfEffectObject_m_nSpellSaveDC_get(swigCPtr);
      return retVal;
    }

  }

  public int m_nSpellLevel {
    set {
      NWNXLibPINVOKE.CNWSAreaOfEffectObject_m_nSpellLevel_set(swigCPtr, value);
    } 
    get {
      int retVal = NWNXLibPINVOKE.CNWSAreaOfEffectObject_m_nSpellLevel_get(swigCPtr);
      return retVal;
    }

  }

  public CExoStringArray m_sScripts {
    set {
      NWNXLibPINVOKE.CNWSAreaOfEffectObject_m_sScripts_set(swigCPtr, CExoStringArray.getCPtr(value));
    } 
    get {
        global::System.IntPtr cPtr = NWNXLibPINVOKE.CNWSAreaOfEffectObject_m_sScripts_get(swigCPtr);;
        CExoStringArray ret = (cPtr == global::System.IntPtr.Zero) ? null : new CExoStringArray(cPtr, false);
        return ret;
    }

  }

  public uint m_nLastHeartbeatScriptCalendarDay {
    set {
      NWNXLibPINVOKE.CNWSAreaOfEffectObject_m_nLastHeartbeatScriptCalendarDay_set(swigCPtr, value);
    } 
    get {
      uint retVal = NWNXLibPINVOKE.CNWSAreaOfEffectObject_m_nLastHeartbeatScriptCalendarDay_get(swigCPtr);
      return retVal;
    }

  }

  public uint m_nLastHeartbeatScriptTimeOfDay {
    set {
      NWNXLibPINVOKE.CNWSAreaOfEffectObject_m_nLastHeartbeatScriptTimeOfDay_set(swigCPtr, value);
    } 
    get {
      uint retVal = NWNXLibPINVOKE.CNWSAreaOfEffectObject_m_nLastHeartbeatScriptTimeOfDay_get(swigCPtr);
      return retVal;
    }

  }

  public uint m_nDuration {
    set {
      NWNXLibPINVOKE.CNWSAreaOfEffectObject_m_nDuration_set(swigCPtr, value);
    } 
    get {
      uint retVal = NWNXLibPINVOKE.CNWSAreaOfEffectObject_m_nDuration_get(swigCPtr);
      return retVal;
    }

  }

  public byte m_nDurationType {
    set {
      NWNXLibPINVOKE.CNWSAreaOfEffectObject_m_nDurationType_set(swigCPtr, value);
    } 
    get {
      byte retVal = NWNXLibPINVOKE.CNWSAreaOfEffectObject_m_nDurationType_get(swigCPtr);
      return retVal;
    }

  }

  public CNWSAreaOfEffectObject(uint oidId) : this(NWNXLibPINVOKE.new_CNWSAreaOfEffectObject__SWIG_0(oidId), true) {
  }

  public CNWSAreaOfEffectObject() : this(NWNXLibPINVOKE.new_CNWSAreaOfEffectObject__SWIG_1(), true) {
  }

  public override void AIUpdate() {
    NWNXLibPINVOKE.CNWSAreaOfEffectObject_AIUpdate(swigCPtr);
  }

  public override void EventHandler(uint nEventId, uint nCallerObjectId, void* pScript, uint nCalendarDay, uint nTimeOfDay) {
    NWNXLibPINVOKE.CNWSAreaOfEffectObject_EventHandler(swigCPtr, nEventId, nCallerObjectId, (global::System.IntPtr)pScript, nCalendarDay, nTimeOfDay);
  }

  public void AddToArea(CNWSArea pArea, float fX, float fY, float fZ, int bRunScripts) {
    NWNXLibPINVOKE.CNWSAreaOfEffectObject_AddToArea__SWIG_0(swigCPtr, CNWSArea.getCPtr(pArea), fX, fY, fZ, bRunScripts);
  }

  public void AddToArea(CNWSArea pArea, float fX, float fY, float fZ) {
    NWNXLibPINVOKE.CNWSAreaOfEffectObject_AddToArea__SWIG_1(swigCPtr, CNWSArea.getCPtr(pArea), fX, fY, fZ);
  }

  public void RemoveFromArea() {
    NWNXLibPINVOKE.CNWSAreaOfEffectObject_RemoveFromArea(swigCPtr);
  }

  public int LineSegmentIntersectAreaOfEffect(Vector vStartLine, Vector vEndLine) {
    int retVal = NWNXLibPINVOKE.CNWSAreaOfEffectObject_LineSegmentIntersectAreaOfEffect(swigCPtr, Vector.getCPtr(vStartLine), Vector.getCPtr(vEndLine));
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
    return retVal;
  }

  public int InAreaOfEffect(Vector vPosition) {
    int retVal = NWNXLibPINVOKE.CNWSAreaOfEffectObject_InAreaOfEffect(swigCPtr, Vector.getCPtr(vPosition));
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
    return retVal;
  }

  public int LoadEffect(CResGFF pRes, CResStruct pStruct) {
    int retVal = NWNXLibPINVOKE.CNWSAreaOfEffectObject_LoadEffect(swigCPtr, CResGFF.getCPtr(pRes), CResStruct.getCPtr(pStruct));
    return retVal;
  }

  public int SaveEffect(CResGFF pRes, CResStruct pStruct) {
    int retVal = NWNXLibPINVOKE.CNWSAreaOfEffectObject_SaveEffect(swigCPtr, CResGFF.getCPtr(pRes), CResStruct.getCPtr(pStruct));
    return retVal;
  }

  public void SetTargetObjID(uint oidValue) {
    NWNXLibPINVOKE.CNWSAreaOfEffectObject_SetTargetObjID(swigCPtr, oidValue);
  }

  public void LoadAreaEffect(int nId) {
    NWNXLibPINVOKE.CNWSAreaOfEffectObject_LoadAreaEffect(swigCPtr, nId);
  }

  public void SetDuration(byte nDurationType, float fDuration) {
    NWNXLibPINVOKE.CNWSAreaOfEffectObject_SetDuration__SWIG_0(swigCPtr, nDurationType, fDuration);
  }

  public void SetDuration(byte nDurationType) {
    NWNXLibPINVOKE.CNWSAreaOfEffectObject_SetDuration__SWIG_1(swigCPtr, nDurationType);
  }

  public Vector GetPosition() {
    Vector ret = new Vector(NWNXLibPINVOKE.CNWSAreaOfEffectObject_GetPosition(swigCPtr), true);
    return ret;
  }

  public void SetCreator(uint oidObject) {
    NWNXLibPINVOKE.CNWSAreaOfEffectObject_SetCreator(swigCPtr, oidObject);
  }

  public override uint GetEffectSpellId() {
    uint retVal = NWNXLibPINVOKE.CNWSAreaOfEffectObject_GetEffectSpellId(swigCPtr);
    return retVal;
  }

  public override void SetEffectSpellId(uint nSpellId) {
    NWNXLibPINVOKE.CNWSAreaOfEffectObject_SetEffectSpellId(swigCPtr, nSpellId);
  }

  public void JumpToPoint(CNWSArea pNewArea, Vector vNewPos) {
    NWNXLibPINVOKE.CNWSAreaOfEffectObject_JumpToPoint(swigCPtr, CNWSArea.getCPtr(pNewArea), Vector.getCPtr(vNewPos));
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
  }

  public void MoveToPoint(Vector vNewPos) {
    NWNXLibPINVOKE.CNWSAreaOfEffectObject_MoveToPoint(swigCPtr, Vector.getCPtr(vNewPos));
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
  }

  public void SetShape(byte nShape, float f1, float f2) {
    NWNXLibPINVOKE.CNWSAreaOfEffectObject_SetShape__SWIG_0(swigCPtr, nShape, f1, f2);
  }

  public void SetShape(byte nShape, float f1) {
    NWNXLibPINVOKE.CNWSAreaOfEffectObject_SetShape__SWIG_1(swigCPtr, nShape, f1);
  }

  public void SetShape(byte nShape) {
    NWNXLibPINVOKE.CNWSAreaOfEffectObject_SetShape__SWIG_2(swigCPtr, nShape);
  }

  public void UpdateSubAreas(Vector NewPos) {
    NWNXLibPINVOKE.CNWSAreaOfEffectObject_UpdateSubAreas__SWIG_0(swigCPtr, Vector.getCPtr(NewPos));
  }

  public void UpdateSubAreas() {
    NWNXLibPINVOKE.CNWSAreaOfEffectObject_UpdateSubAreas__SWIG_1(swigCPtr);
  }

  public void RemoveFromSubAreas(int bInstantEvents) {
    NWNXLibPINVOKE.CNWSAreaOfEffectObject_RemoveFromSubAreas__SWIG_0(swigCPtr, bInstantEvents);
  }

  public void RemoveFromSubAreas() {
    NWNXLibPINVOKE.CNWSAreaOfEffectObject_RemoveFromSubAreas__SWIG_1(swigCPtr);
  }

  public new void _Destructor() {
    NWNXLibPINVOKE.CNWSAreaOfEffectObject__Destructor(swigCPtr);
  }

}

}

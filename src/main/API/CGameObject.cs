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

public unsafe class CGameObject : ICGameObject, global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal CGameObject(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(CGameObject obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~CGameObject() {
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
          NWNXLibPINVOKE.delete_CGameObject(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
    }
  }

  [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
  global::System.Runtime.InteropServices.HandleRef ICGameObject.GetInterfaceCPtr() {
    return new global::System.Runtime.InteropServices.HandleRef(this, NWNXLibPINVOKE.CGameObject_ICGameObject_GetInterfaceCPtr(swigCPtr.Handle));
  }
/*@SWIG:/__w/NWN.Native/NWN.Native/nwnx/Plugins/SWIG/SWIG_DotNET/DotNETExtensions.i,1,SWIG_DOTNET_EXTENSIONS@*/
  public global::System.IntPtr Pointer {
    get {
      return swigCPtr.Handle;
    }
  }

  public static unsafe implicit operator void*(CGameObject self) {
    return (void*)self.swigCPtr.Handle;
  }

  public static unsafe CGameObject FromPointer(void* pointer, bool memoryOwn = false) {
    return pointer != null ? new CGameObject((global::System.IntPtr)pointer, memoryOwn) : null;
  }

  public static CGameObject FromPointer(global::System.IntPtr pointer, bool memoryOwn = false) {
    return pointer != global::System.IntPtr.Zero ? new CGameObject(pointer, memoryOwn) : null;
  }

  public bool Equals(CGameObject other) {
    if (ReferenceEquals(null, other)) {
      return false;
    }

    if (ReferenceEquals(this, other)) {
      return true;
    }

    return Pointer.Equals(other.Pointer);
  }

  public override bool Equals(object obj) {
    return ReferenceEquals(this, obj) || obj is CGameObject other && Equals(other);
  }

  public override int GetHashCode() {
    return swigCPtr.Handle.GetHashCode();
  }

  public static bool operator ==(CGameObject left, CGameObject right) {
    return Equals(left, right);
  }

  public static bool operator !=(CGameObject left, CGameObject right) {
    return !Equals(left, right);
  }
/*@SWIG@*/
  public uint m_idSelf {
    set {
      NWNXLibPINVOKE.CGameObject_m_idSelf_set(swigCPtr, value);
    } 
    get {
      uint retVal = NWNXLibPINVOKE.CGameObject_m_idSelf_get(swigCPtr);
      return retVal;
    }

  }

  public byte m_nObjectType {
    set {
      NWNXLibPINVOKE.CGameObject_m_nObjectType_set(swigCPtr, value);
    } 
    get {
      byte retVal = NWNXLibPINVOKE.CGameObject_m_nObjectType_get(swigCPtr);
      return retVal;
    }

  }

  public void* m_pNwnxData {
    set {
      NWNXLibPINVOKE.CGameObject_m_pNwnxData_set(swigCPtr, (global::System.IntPtr)value);
    } 
    get {
        global::System.IntPtr retVal = NWNXLibPINVOKE.CGameObject_m_pNwnxData_get(swigCPtr);
        return (void*)retVal;
    }

  }

  public CGameObject(byte nObjectType, uint oidId) : this(NWNXLibPINVOKE.new_CGameObject__SWIG_0(nObjectType, oidId), true) {
  }

  public CGameObject(byte nObjectType) : this(NWNXLibPINVOKE.new_CGameObject__SWIG_1(nObjectType), true) {
  }

  public virtual void SetId(uint oidNew) {
    NWNXLibPINVOKE.CGameObject_SetId(swigCPtr, oidNew);
  }

  public virtual void ResetUpdateTimes(uint nCalendarDay, uint nTimeOfDay) {
    NWNXLibPINVOKE.CGameObject_ResetUpdateTimes(swigCPtr, nCalendarDay, nTimeOfDay);
  }

  public virtual SWIGTYPE_p_CNWCObject AsNWCObject() {
    global::System.IntPtr cPtr = NWNXLibPINVOKE.CGameObject_AsNWCObject(swigCPtr);
    SWIGTYPE_p_CNWCObject ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_CNWCObject(cPtr, false);
    return ret;
  }

  public virtual CNWSObject AsNWSObject() {
    global::System.IntPtr cPtr = NWNXLibPINVOKE.CGameObject_AsNWSObject(swigCPtr);
    CNWSObject ret = (cPtr == global::System.IntPtr.Zero) ? null : new CNWSObject(cPtr, false);
    return ret;
  }

  public virtual SWIGTYPE_p_CNWCDoor AsNWCDoor() {
    global::System.IntPtr cPtr = NWNXLibPINVOKE.CGameObject_AsNWCDoor(swigCPtr);
    SWIGTYPE_p_CNWCDoor ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_CNWCDoor(cPtr, false);
    return ret;
  }

  public virtual CNWSDoor AsNWSDoor() {
    global::System.IntPtr cPtr = NWNXLibPINVOKE.CGameObject_AsNWSDoor(swigCPtr);
    CNWSDoor ret = (cPtr == global::System.IntPtr.Zero) ? null : new CNWSDoor(cPtr, false);
    return ret;
  }

  public virtual SWIGTYPE_p_CNWCModule AsNWCModule() {
    global::System.IntPtr cPtr = NWNXLibPINVOKE.CGameObject_AsNWCModule(swigCPtr);
    SWIGTYPE_p_CNWCModule ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_CNWCModule(cPtr, false);
    return ret;
  }

  public virtual CNWSModule AsNWSModule() {
    global::System.IntPtr cPtr = NWNXLibPINVOKE.CGameObject_AsNWSModule(swigCPtr);
    CNWSModule ret = (cPtr == global::System.IntPtr.Zero) ? null : new CNWSModule(cPtr, false);
    return ret;
  }

  public virtual SWIGTYPE_p_CNWCArea AsNWCArea() {
    global::System.IntPtr cPtr = NWNXLibPINVOKE.CGameObject_AsNWCArea(swigCPtr);
    SWIGTYPE_p_CNWCArea ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_CNWCArea(cPtr, false);
    return ret;
  }

  public virtual CNWSArea AsNWSArea() {
    global::System.IntPtr cPtr = NWNXLibPINVOKE.CGameObject_AsNWSArea(swigCPtr);
    CNWSArea ret = (cPtr == global::System.IntPtr.Zero) ? null : new CNWSArea(cPtr, false);
    return ret;
  }

  public virtual SWIGTYPE_p_CNWCCreature AsNWCCreature() {
    global::System.IntPtr cPtr = NWNXLibPINVOKE.CGameObject_AsNWCCreature(swigCPtr);
    SWIGTYPE_p_CNWCCreature ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_CNWCCreature(cPtr, false);
    return ret;
  }

  public virtual CNWSCreature AsNWSCreature() {
    global::System.IntPtr cPtr = NWNXLibPINVOKE.CGameObject_AsNWSCreature(swigCPtr);
    CNWSCreature ret = (cPtr == global::System.IntPtr.Zero) ? null : new CNWSCreature(cPtr, false);
    return ret;
  }

  public virtual SWIGTYPE_p_CNWCItem AsNWCItem() {
    global::System.IntPtr cPtr = NWNXLibPINVOKE.CGameObject_AsNWCItem(swigCPtr);
    SWIGTYPE_p_CNWCItem ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_CNWCItem(cPtr, false);
    return ret;
  }

  public virtual CNWSItem AsNWSItem() {
    global::System.IntPtr cPtr = NWNXLibPINVOKE.CGameObject_AsNWSItem(swigCPtr);
    CNWSItem ret = (cPtr == global::System.IntPtr.Zero) ? null : new CNWSItem(cPtr, false);
    return ret;
  }

  public virtual SWIGTYPE_p_CNWCTrigger AsNWCTrigger() {
    global::System.IntPtr cPtr = NWNXLibPINVOKE.CGameObject_AsNWCTrigger(swigCPtr);
    SWIGTYPE_p_CNWCTrigger ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_CNWCTrigger(cPtr, false);
    return ret;
  }

  public virtual CNWSTrigger AsNWSTrigger() {
    global::System.IntPtr cPtr = NWNXLibPINVOKE.CGameObject_AsNWSTrigger(swigCPtr);
    CNWSTrigger ret = (cPtr == global::System.IntPtr.Zero) ? null : new CNWSTrigger(cPtr, false);
    return ret;
  }

  public virtual SWIGTYPE_p_CNWCProjectile AsNWCProjectile() {
    global::System.IntPtr cPtr = NWNXLibPINVOKE.CGameObject_AsNWCProjectile(swigCPtr);
    SWIGTYPE_p_CNWCProjectile ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_CNWCProjectile(cPtr, false);
    return ret;
  }

  public virtual CNWSPlayerTURD AsNWSPlayerTURD() {
    global::System.IntPtr cPtr = NWNXLibPINVOKE.CGameObject_AsNWSPlayerTURD(swigCPtr);
    CNWSPlayerTURD ret = (cPtr == global::System.IntPtr.Zero) ? null : new CNWSPlayerTURD(cPtr, false);
    return ret;
  }

  public virtual CNWSPlaceable AsNWSPlaceable() {
    global::System.IntPtr cPtr = NWNXLibPINVOKE.CGameObject_AsNWSPlaceable(swigCPtr);
    CNWSPlaceable ret = (cPtr == global::System.IntPtr.Zero) ? null : new CNWSPlaceable(cPtr, false);
    return ret;
  }

  public virtual SWIGTYPE_p_CNWCPlaceable AsNWCPlaceable() {
    global::System.IntPtr cPtr = NWNXLibPINVOKE.CGameObject_AsNWCPlaceable(swigCPtr);
    SWIGTYPE_p_CNWCPlaceable ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_CNWCPlaceable(cPtr, false);
    return ret;
  }

  public virtual CNWSAreaOfEffectObject AsNWSAreaOfEffectObject() {
    global::System.IntPtr cPtr = NWNXLibPINVOKE.CGameObject_AsNWSAreaOfEffectObject(swigCPtr);
    CNWSAreaOfEffectObject ret = (cPtr == global::System.IntPtr.Zero) ? null : new CNWSAreaOfEffectObject(cPtr, false);
    return ret;
  }

  public virtual SWIGTYPE_p_CNWCAreaOfEffectObject AsNWCAreaOfEffectObject() {
    global::System.IntPtr cPtr = NWNXLibPINVOKE.CGameObject_AsNWCAreaOfEffectObject(swigCPtr);
    SWIGTYPE_p_CNWCAreaOfEffectObject ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_CNWCAreaOfEffectObject(cPtr, false);
    return ret;
  }

  public virtual CNWSWaypoint AsNWSWaypoint() {
    global::System.IntPtr cPtr = NWNXLibPINVOKE.CGameObject_AsNWSWaypoint(swigCPtr);
    CNWSWaypoint ret = (cPtr == global::System.IntPtr.Zero) ? null : new CNWSWaypoint(cPtr, false);
    return ret;
  }

  public virtual CNWSEncounter AsNWSEncounter() {
    global::System.IntPtr cPtr = NWNXLibPINVOKE.CGameObject_AsNWSEncounter(swigCPtr);
    CNWSEncounter ret = (cPtr == global::System.IntPtr.Zero) ? null : new CNWSEncounter(cPtr, false);
    return ret;
  }

  public virtual SWIGTYPE_p_CNWCStore AsNWCStore() {
    global::System.IntPtr cPtr = NWNXLibPINVOKE.CGameObject_AsNWCStore(swigCPtr);
    SWIGTYPE_p_CNWCStore ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_CNWCStore(cPtr, false);
    return ret;
  }

  public virtual CNWSStore AsNWSStore() {
    global::System.IntPtr cPtr = NWNXLibPINVOKE.CGameObject_AsNWSStore(swigCPtr);
    CNWSStore ret = (cPtr == global::System.IntPtr.Zero) ? null : new CNWSStore(cPtr, false);
    return ret;
  }

  public virtual CNWSSoundObject AsNWSSoundObject() {
    global::System.IntPtr cPtr = NWNXLibPINVOKE.CGameObject_AsNWSSoundObject(swigCPtr);
    CNWSSoundObject ret = (cPtr == global::System.IntPtr.Zero) ? null : new CNWSSoundObject(cPtr, false);
    return ret;
  }

  public virtual SWIGTYPE_p_CNWCSoundObject AsNWCSoundObject() {
    global::System.IntPtr cPtr = NWNXLibPINVOKE.CGameObject_AsNWCSoundObject(swigCPtr);
    SWIGTYPE_p_CNWCSoundObject ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_CNWCSoundObject(cPtr, false);
    return ret;
  }

}

}

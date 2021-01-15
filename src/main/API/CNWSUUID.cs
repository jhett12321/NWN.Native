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

public class CNWSUUID : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal CNWSUUID(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(CNWSUUID obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~CNWSUUID() {
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
          NWNXLibPINVOKE.delete_CNWSUUID(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
    }
  }

  public CGameObject m_parent {
    set {
      NWNXLibPINVOKE.CNWSUUID_m_parent_set(swigCPtr, CGameObject.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = NWNXLibPINVOKE.CNWSUUID_m_parent_get(swigCPtr);
      CGameObject ret = (cPtr == global::System.IntPtr.Zero) ? null : new CGameObject(cPtr, false);
      return ret;
    } 
  }

  public CExoString m_uuid {
    set {
      NWNXLibPINVOKE.CNWSUUID_m_uuid_set(swigCPtr, CExoString.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = NWNXLibPINVOKE.CNWSUUID_m_uuid_get(swigCPtr);
      CExoString ret = (cPtr == global::System.IntPtr.Zero) ? null : new CExoString(cPtr, false);
      return ret;
    } 
  }

  public CNWSUUID(CGameObject arg0) : this(NWNXLibPINVOKE.new_CNWSUUID(CGameObject.getCPtr(arg0)), true) {
  }

  public bool CanCarryUUID() {
    bool ret = NWNXLibPINVOKE.CNWSUUID_CanCarryUUID(swigCPtr);
    return ret;
  }

  public bool TryAssign(CExoString uuid) {
    bool ret = NWNXLibPINVOKE.CNWSUUID_TryAssign(swigCPtr, CExoString.getCPtr(uuid));
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void AssignRandom() {
    NWNXLibPINVOKE.CNWSUUID_AssignRandom(swigCPtr);
  }

  public CExoString GetOrAssignRandom() {
    CExoString ret = new CExoString(NWNXLibPINVOKE.CNWSUUID_GetOrAssignRandom(swigCPtr), true);
    return ret;
  }

  public bool LoadFromGff(CResGFF pRes, CResStruct pStruct) {
    bool ret = NWNXLibPINVOKE.CNWSUUID_LoadFromGff(swigCPtr, CResGFF.getCPtr(pRes), CResStruct.getCPtr(pStruct));
    return ret;
  }

  public void SaveToGff(CResGFF pRes, CResStruct pStruct) {
    NWNXLibPINVOKE.CNWSUUID_SaveToGff(swigCPtr, CResGFF.getCPtr(pRes), CResStruct.getCPtr(pStruct));
  }

}

}
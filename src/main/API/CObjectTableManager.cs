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

public unsafe class CObjectTableManager : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal CObjectTableManager(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(CObjectTableManager obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~CObjectTableManager() {
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
          NWNXLibPINVOKE.delete_CObjectTableManager(swigCPtr);
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

  public static unsafe implicit operator void*(CObjectTableManager self) {
    return (void*)self.swigCPtr.Handle;
  }

  public static unsafe CObjectTableManager FromPointer(void* pointer, bool memoryOwn = false) {
    return pointer != null ? new CObjectTableManager((global::System.IntPtr)pointer, memoryOwn) : null;
  }

  public static CObjectTableManager FromPointer(global::System.IntPtr pointer, bool memoryOwn = false) {
    return pointer != global::System.IntPtr.Zero ? new CObjectTableManager(pointer, memoryOwn) : null;
  }

  public bool Equals(CObjectTableManager other) {
    if (ReferenceEquals(null, other)) {
      return false;
    }

    if (ReferenceEquals(this, other)) {
      return true;
    }

    return Pointer.Equals(other.Pointer);
  }

  public override bool Equals(object obj) {
    return ReferenceEquals(this, obj) || obj is CObjectTableManager other && Equals(other);
  }

  public override int GetHashCode() {
    return swigCPtr.Handle.GetHashCode();
  }

  public static bool operator ==(CObjectTableManager left, CObjectTableManager right) {
    return Equals(left, right);
  }

  public static bool operator !=(CObjectTableManager left, CObjectTableManager right) {
    return !Equals(left, right);
  }

  public CObjectLookupTablePtrArray m_pObjectTableArray {
    set {
      NWNXLibPINVOKE.CObjectTableManager_m_pObjectTableArray_set(swigCPtr, CObjectLookupTablePtrArray.getCPtr(value));
    } 
    get {
        global::System.IntPtr cPtr = NWNXLibPINVOKE.CObjectTableManager_m_pObjectTableArray_get(swigCPtr);;
        CObjectLookupTablePtrArray ret = (cPtr == global::System.IntPtr.Zero) ? null : new CObjectLookupTablePtrArray(cPtr, false);
        return ret;
    }

  }

  public uint m_dwMaxPlayerID {
    set {
      NWNXLibPINVOKE.CObjectTableManager_m_dwMaxPlayerID_set(swigCPtr, value);
    } 
    get {
      uint retVal = NWNXLibPINVOKE.CObjectTableManager_m_dwMaxPlayerID_get(swigCPtr);
      return retVal;
    }

  }

  public CObjectTableManager() : this(NWNXLibPINVOKE.new_CObjectTableManager(), true) {
  }

  public int AddID(uint oidID, uint* dwSlot, uint dwPlayerID) {
    int retVal = NWNXLibPINVOKE.CObjectTableManager_AddID__SWIG_0(swigCPtr, oidID, dwSlot, dwPlayerID);
    return retVal;
  }

  public int AddID(uint oidID, uint* dwSlot) {
    int retVal = NWNXLibPINVOKE.CObjectTableManager_AddID__SWIG_1(swigCPtr, oidID, dwSlot);
    return retVal;
  }

  public uint GetIDFromIndex(uint dwIndex, uint dwPlayerID) {
    uint retVal = NWNXLibPINVOKE.CObjectTableManager_GetIDFromIndex__SWIG_0(swigCPtr, dwIndex, dwPlayerID);
    return retVal;
  }

  public uint GetIDFromIndex(uint dwIndex) {
    uint retVal = NWNXLibPINVOKE.CObjectTableManager_GetIDFromIndex__SWIG_1(swigCPtr, dwIndex);
    return retVal;
  }

  public uint GetIndexFromID(uint oidID, uint dwPlayerID) {
    uint retVal = NWNXLibPINVOKE.CObjectTableManager_GetIndexFromID__SWIG_0(swigCPtr, oidID, dwPlayerID);
    return retVal;
  }

  public uint GetIndexFromID(uint oidID) {
    uint retVal = NWNXLibPINVOKE.CObjectTableManager_GetIndexFromID__SWIG_1(swigCPtr, oidID);
    return retVal;
  }

  public int Touch(uint dwIndex, uint dwPlayerID) {
    int retVal = NWNXLibPINVOKE.CObjectTableManager_Touch__SWIG_0(swigCPtr, dwIndex, dwPlayerID);
    return retVal;
  }

  public int Touch(uint dwIndex) {
    int retVal = NWNXLibPINVOKE.CObjectTableManager_Touch__SWIG_1(swigCPtr, dwIndex);
    return retVal;
  }

  public int RemovePlayer(uint dwPlayerID) {
    int retVal = NWNXLibPINVOKE.CObjectTableManager_RemovePlayer__SWIG_0(swigCPtr, dwPlayerID);
    return retVal;
  }

  public int RemovePlayer() {
    int retVal = NWNXLibPINVOKE.CObjectTableManager_RemovePlayer__SWIG_1(swigCPtr);
    return retVal;
  }

  public void ClearAll() {
    NWNXLibPINVOKE.CObjectTableManager_ClearAll(swigCPtr);
  }

  public int CreateNewPlayer(uint dwPlayerID) {
    int retVal = NWNXLibPINVOKE.CObjectTableManager_CreateNewPlayer__SWIG_0(swigCPtr, dwPlayerID);
    return retVal;
  }

  public int CreateNewPlayer() {
    int retVal = NWNXLibPINVOKE.CObjectTableManager_CreateNewPlayer__SWIG_1(swigCPtr);
    return retVal;
  }

  public void _Destructor() {
    NWNXLibPINVOKE.CObjectTableManager__Destructor(swigCPtr);
  }

}

}

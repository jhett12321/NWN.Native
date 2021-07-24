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

public unsafe class CRes : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal CRes(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(CRes obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~CRes() {
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
          NWNXLibPINVOKE.delete_CRes(swigCPtr);
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

  public static unsafe implicit operator void*(CRes self) {
    return (void*)self.swigCPtr.Handle;
  }

  public static unsafe CRes FromPointer(void* pointer, bool memoryOwn = false) {
    return pointer != null ? new CRes((global::System.IntPtr)pointer, memoryOwn) : null;
  }

  public static CRes FromPointer(global::System.IntPtr pointer, bool memoryOwn = false) {
    return pointer != global::System.IntPtr.Zero ? new CRes(pointer, memoryOwn) : null;
  }

  public bool Equals(CRes other) {
    if (ReferenceEquals(null, other)) {
      return false;
    }

    if (ReferenceEquals(this, other)) {
      return true;
    }

    return Pointer.Equals(other.Pointer);
  }

  public override bool Equals(object obj) {
    return ReferenceEquals(this, obj) || obj is CRes other && Equals(other);
  }

  public override int GetHashCode() {
    return swigCPtr.Handle.GetHashCode();
  }

  public static bool operator ==(CRes left, CRes right) {
    return Equals(left, right);
  }

  public static bool operator !=(CRes left, CRes right) {
    return !Equals(left, right);
  }
/*@SWIG@*/
  public ushort m_nDemands {
    set {
      NWNXLibPINVOKE.CRes_m_nDemands_set(swigCPtr, value);
    } 
    get {
      ushort retVal = NWNXLibPINVOKE.CRes_m_nDemands_get(swigCPtr);
      return retVal;
    }

  }

  public ushort m_nRequests {
    set {
      NWNXLibPINVOKE.CRes_m_nRequests_set(swigCPtr, value);
    } 
    get {
      ushort retVal = NWNXLibPINVOKE.CRes_m_nRequests_get(swigCPtr);
      return retVal;
    }

  }

  public RESID m_nID {
    set {
      NWNXLibPINVOKE.CRes_m_nID_set(swigCPtr, RESID.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = NWNXLibPINVOKE.CRes_m_nID_get(swigCPtr);
      RESID ret = (cPtr == global::System.IntPtr.Zero) ? null : new RESID(cPtr, false);
      return ret;
    } 
  }

  public uint m_status {
    set {
      NWNXLibPINVOKE.CRes_m_status_set(swigCPtr, value);
    } 
    get {
      uint retVal = NWNXLibPINVOKE.CRes_m_status_get(swigCPtr);
      return retVal;
    }

  }

  public void* m_pResource {
    set {
      NWNXLibPINVOKE.CRes_m_pResource_set(swigCPtr, (global::System.IntPtr)value);
    } 
    get {
        global::System.IntPtr retVal = NWNXLibPINVOKE.CRes_m_pResource_get(swigCPtr);
        return (void*)retVal;
    }

  }

  public CKeyTableEntry m_pKeyEntry {
    set {
      NWNXLibPINVOKE.CRes_m_pKeyEntry_set(swigCPtr, CKeyTableEntry.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = NWNXLibPINVOKE.CRes_m_pKeyEntry_get(swigCPtr);
      CKeyTableEntry ret = (cPtr == global::System.IntPtr.Zero) ? null : new CKeyTableEntry(cPtr, false);
      return ret;
    } 
  }

  public uint m_nSize {
    set {
      NWNXLibPINVOKE.CRes_m_nSize_set(swigCPtr, value);
    } 
    get {
      uint retVal = NWNXLibPINVOKE.CRes_m_nSize_get(swigCPtr);
      return retVal;
    }

  }

  public uint m_nRefs {
    set {
      NWNXLibPINVOKE.CRes_m_nRefs_set(swigCPtr, value);
    } 
    get {
      uint retVal = NWNXLibPINVOKE.CRes_m_nRefs_get(swigCPtr);
      return retVal;
    }

  }

  public int m_bAllocHeaderData {
    set {
      NWNXLibPINVOKE.CRes_m_bAllocHeaderData_set(swigCPtr, value);
    } 
    get {
      int retVal = NWNXLibPINVOKE.CRes_m_bAllocHeaderData_get(swigCPtr);
      return retVal;
    }

  }

  public int m_bAllocTrailingData {
    set {
      NWNXLibPINVOKE.CRes_m_bAllocTrailingData_set(swigCPtr, value);
    } 
    get {
      int retVal = NWNXLibPINVOKE.CRes_m_bAllocTrailingData_get(swigCPtr);
      return retVal;
    }

  }

  public CExoLinkedListNode m_pos {
    set {
      NWNXLibPINVOKE.CRes_m_pos_set(swigCPtr, CExoLinkedListNode.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = NWNXLibPINVOKE.CRes_m_pos_get(swigCPtr);
      CExoLinkedListNode ret = (cPtr == global::System.IntPtr.Zero) ? null : new CExoLinkedListNode(cPtr, false);
      return ret;
    } 
  }

  public int m_bAllowCaching {
    set {
      NWNXLibPINVOKE.CRes_m_bAllowCaching_set(swigCPtr, value);
    } 
    get {
      int retVal = NWNXLibPINVOKE.CRes_m_bAllowCaching_get(swigCPtr);
      return retVal;
    }

  }

  public CRes() : this(NWNXLibPINVOKE.new_CRes__SWIG_0(), true) {
  }

  public CRes(RESID nNewID) : this(NWNXLibPINVOKE.new_CRes__SWIG_1(RESID.getCPtr(nNewID)), true) {
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
  }

  public int CancelRequest() {
    int retVal = NWNXLibPINVOKE.CRes_CancelRequest(swigCPtr);
    return retVal;
  }

  public void* Demand() {
    global::System.IntPtr retVal = NWNXLibPINVOKE.CRes_Demand(swigCPtr);
    return (void*)retVal;
  }

  public int ReadRaw(int nSize, byte* pBuffer) {
    int retVal = NWNXLibPINVOKE.CRes_ReadRaw(swigCPtr, nSize, pBuffer);
    return retVal;
  }

  public void Dump(int bRemove) {
    NWNXLibPINVOKE.CRes_Dump__SWIG_0(swigCPtr, bRemove);
  }

  public void Dump() {
    NWNXLibPINVOKE.CRes_Dump__SWIG_1(swigCPtr);
  }

  public void* GetData() {
    global::System.IntPtr retVal = NWNXLibPINVOKE.CRes_GetData(swigCPtr);
    return (void*)retVal;
  }

  public int GetDemands() {
    int retVal = NWNXLibPINVOKE.CRes_GetDemands(swigCPtr);
    return retVal;
  }

  public virtual int GetFixedResourceSize() {
    int retVal = NWNXLibPINVOKE.CRes_GetFixedResourceSize(swigCPtr);
    return retVal;
  }

  public virtual int GetFixedResourceDataOffset() {
    int retVal = NWNXLibPINVOKE.CRes_GetFixedResourceDataOffset(swigCPtr);
    return retVal;
  }

  public int GetRequests() {
    int retVal = NWNXLibPINVOKE.CRes_GetRequests(swigCPtr);
    return retVal;
  }

  public RESID GetID() {
    RESID ret = new RESID(NWNXLibPINVOKE.CRes_GetID(swigCPtr), true);
    return ret;
  }

  public int GetSize() {
    int retVal = NWNXLibPINVOKE.CRes_GetSize(swigCPtr);
    return retVal;
  }

  public virtual int OnResourceFreed() {
    int retVal = NWNXLibPINVOKE.CRes_OnResourceFreed(swigCPtr);
    return retVal;
  }

  public virtual int OnResourceServiced() {
    int retVal = NWNXLibPINVOKE.CRes_OnResourceServiced(swigCPtr);
    return retVal;
  }

  public int Release() {
    int retVal = NWNXLibPINVOKE.CRes_Release(swigCPtr);
    return retVal;
  }

  public int Request() {
    int retVal = NWNXLibPINVOKE.CRes_Request(swigCPtr);
    return retVal;
  }

  public void SetID(RESID nNewID) {
    NWNXLibPINVOKE.CRes_SetID(swigCPtr, RESID.getCPtr(nNewID));
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
  }

}

}

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

public unsafe class CExoPackedFile : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal CExoPackedFile(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(CExoPackedFile obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~CExoPackedFile() {
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
          NWNXLibPINVOKE.delete_CExoPackedFile(swigCPtr);
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

  public static unsafe implicit operator void*(CExoPackedFile self) {
    return (void*)self.swigCPtr.Handle;
  }

  public static unsafe CExoPackedFile FromPointer(void* pointer, bool memoryOwn = false) {
    return pointer != null ? new CExoPackedFile((global::System.IntPtr)pointer, memoryOwn) : null;
  }

  public static CExoPackedFile FromPointer(global::System.IntPtr pointer, bool memoryOwn = false) {
    return pointer != global::System.IntPtr.Zero ? new CExoPackedFile(pointer, memoryOwn) : null;
  }

  public bool Equals(CExoPackedFile other) {
    if (ReferenceEquals(null, other)) {
      return false;
    }

    if (ReferenceEquals(this, other)) {
      return true;
    }

    return Pointer.Equals(other.Pointer);
  }

  public override bool Equals(object obj) {
    return ReferenceEquals(this, obj) || obj is CExoPackedFile other && Equals(other);
  }

  public override int GetHashCode() {
    return swigCPtr.Handle.GetHashCode();
  }

  public static bool operator ==(CExoPackedFile left, CExoPackedFile right) {
    return Equals(left, right);
  }

  public static bool operator !=(CExoPackedFile left, CExoPackedFile right) {
    return !Equals(left, right);
  }

  public CExoString m_sFileName {
    set {
      NWNXLibPINVOKE.CExoPackedFile_m_sFileName_set(swigCPtr, CExoString.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = NWNXLibPINVOKE.CExoPackedFile_m_sFileName_get(swigCPtr);
      CExoString ret = (cPtr == global::System.IntPtr.Zero) ? null : new CExoString(cPtr, false);
      return ret;
    } 
  }

  public ushort m_wDrives {
    set {
      NWNXLibPINVOKE.CExoPackedFile_m_wDrives_set(swigCPtr, value);
    } 
    get {
      ushort retVal = NWNXLibPINVOKE.CExoPackedFile_m_wDrives_get(swigCPtr);
      return retVal;
    }

  }

  public uint m_nFileSize {
    set {
      NWNXLibPINVOKE.CExoPackedFile_m_nFileSize_set(swigCPtr, value);
    } 
    get {
      uint retVal = NWNXLibPINVOKE.CExoPackedFile_m_nFileSize_get(swigCPtr);
      return retVal;
    }

  }

  public CExoFile m_pExoFile {
    set {
      NWNXLibPINVOKE.CExoPackedFile_m_pExoFile_set(swigCPtr, CExoFile.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = NWNXLibPINVOKE.CExoPackedFile_m_pExoFile_get(swigCPtr);
      CExoFile ret = (cPtr == global::System.IntPtr.Zero) ? null : new CExoFile(cPtr, false);
      return ret;
    } 
  }

  public CExoFile m_pAsyncExoFile {
    set {
      NWNXLibPINVOKE.CExoPackedFile_m_pAsyncExoFile_set(swigCPtr, CExoFile.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = NWNXLibPINVOKE.CExoPackedFile_m_pAsyncExoFile_get(swigCPtr);
      CExoFile ret = (cPtr == global::System.IntPtr.Zero) ? null : new CExoFile(cPtr, false);
      return ret;
    } 
  }

  public int m_nRefCount {
    set {
      NWNXLibPINVOKE.CExoPackedFile_m_nRefCount_set(swigCPtr, value);
    } 
    get {
      int retVal = NWNXLibPINVOKE.CExoPackedFile_m_nRefCount_get(swigCPtr);
      return retVal;
    }

  }

  public int m_nAsyncRefCount {
    set {
      NWNXLibPINVOKE.CExoPackedFile_m_nAsyncRefCount_set(swigCPtr, value);
    } 
    get {
      int retVal = NWNXLibPINVOKE.CExoPackedFile_m_nAsyncRefCount_get(swigCPtr);
      return retVal;
    }

  }

  public int m_bLoaded {
    set {
      NWNXLibPINVOKE.CExoPackedFile_m_bLoaded_set(swigCPtr, value);
    } 
    get {
      int retVal = NWNXLibPINVOKE.CExoPackedFile_m_bLoaded_get(swigCPtr);
      return retVal;
    }

  }

  public int m_bAsyncLoaded {
    set {
      NWNXLibPINVOKE.CExoPackedFile_m_bAsyncLoaded_set(swigCPtr, value);
    } 
    get {
      int retVal = NWNXLibPINVOKE.CExoPackedFile_m_bAsyncLoaded_get(swigCPtr);
      return retVal;
    }

  }

  public int m_bHeaderLoaded {
    set {
      NWNXLibPINVOKE.CExoPackedFile_m_bHeaderLoaded_set(swigCPtr, value);
    } 
    get {
      int retVal = NWNXLibPINVOKE.CExoPackedFile_m_bHeaderLoaded_get(swigCPtr);
      return retVal;
    }

  }

  public CExoPackedFile() : this(NWNXLibPINVOKE.new_CExoPackedFile(), true) {
  }

  public virtual void AddRefCount() {
    NWNXLibPINVOKE.CExoPackedFile_AddRefCount(swigCPtr);
  }

  public virtual void AddAsyncRefCount() {
    NWNXLibPINVOKE.CExoPackedFile_AddAsyncRefCount(swigCPtr);
  }

  public virtual int CloseFile() {
    int retVal = NWNXLibPINVOKE.CExoPackedFile_CloseFile(swigCPtr);
    return retVal;
  }

  public virtual int CloseAsyncFile() {
    int retVal = NWNXLibPINVOKE.CExoPackedFile_CloseAsyncFile(swigCPtr);
    return retVal;
  }

  public virtual void DeleteRefCount() {
    NWNXLibPINVOKE.CExoPackedFile_DeleteRefCount(swigCPtr);
  }

  public virtual void DeleteAsyncRefCount() {
    NWNXLibPINVOKE.CExoPackedFile_DeleteAsyncRefCount(swigCPtr);
  }

  public virtual CExoFile GetFile() {
    global::System.IntPtr cPtr = NWNXLibPINVOKE.CExoPackedFile_GetFile(swigCPtr);
    CExoFile ret = (cPtr == global::System.IntPtr.Zero) ? null : new CExoFile(cPtr, false);
    return ret;
  }

  public virtual CExoFile GetAsyncFile() {
    global::System.IntPtr cPtr = NWNXLibPINVOKE.CExoPackedFile_GetAsyncFile(swigCPtr);
    CExoFile ret = (cPtr == global::System.IntPtr.Zero) ? null : new CExoFile(cPtr, false);
    return ret;
  }

  public virtual uint GetResourceSize(RESID nID) {
    uint retVal = NWNXLibPINVOKE.CExoPackedFile_GetResourceSize(swigCPtr, RESID.getCPtr(nID));
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
    return retVal;
  }

  public virtual int Initialize() {
    int retVal = NWNXLibPINVOKE.CExoPackedFile_Initialize(swigCPtr);
    return retVal;
  }

  public virtual int OpenFile() {
    int retVal = NWNXLibPINVOKE.CExoPackedFile_OpenFile__SWIG_0(swigCPtr);
    return retVal;
  }

  public virtual int OpenFile(byte* pCipher) {
    int retVal = NWNXLibPINVOKE.CExoPackedFile_OpenFile__SWIG_1(swigCPtr, pCipher);
    return retVal;
  }

  public virtual int OpenAsyncFile() {
    int retVal = NWNXLibPINVOKE.CExoPackedFile_OpenAsyncFile(swigCPtr);
    return retVal;
  }

  public virtual uint ReadResource(RESID nID, void* pData, uint nSize, uint nDataOffset) {
    uint retVal = NWNXLibPINVOKE.CExoPackedFile_ReadResource(swigCPtr, RESID.getCPtr(nID), (global::System.IntPtr)pData, nSize, nDataOffset);
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
    return retVal;
  }

  public virtual void ReadResourceAsync(RESID nID, void* pData, uint nSize, uint nDataOffset) {
    NWNXLibPINVOKE.CExoPackedFile_ReadResourceAsync(swigCPtr, RESID.getCPtr(nID), (global::System.IntPtr)pData, nSize, nDataOffset);
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual int LoadHeader(byte* expectOid, byte nType) {
    int retVal = NWNXLibPINVOKE.CExoPackedFile_LoadHeader__SWIG_0(swigCPtr, expectOid, nType);
    return retVal;
  }

  public virtual int LoadHeader(byte* expectOid) {
    int retVal = NWNXLibPINVOKE.CExoPackedFile_LoadHeader__SWIG_1(swigCPtr, expectOid);
    return retVal;
  }

  public virtual int UnloadHeader() {
    int retVal = NWNXLibPINVOKE.CExoPackedFile_UnloadHeader(swigCPtr);
    return retVal;
  }

  public uint ReadNWCompressedBuffer(void* outBuffer, uint outBufSize, uint readLength) {
    uint retVal = NWNXLibPINVOKE.CExoPackedFile_ReadNWCompressedBuffer(swigCPtr, (global::System.IntPtr)outBuffer, outBufSize, readLength);
    return retVal;
  }

  public void _Destructor() {
    NWNXLibPINVOKE.CExoPackedFile__Destructor(swigCPtr);
  }

}

}

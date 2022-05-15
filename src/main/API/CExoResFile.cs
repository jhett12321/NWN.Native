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

public unsafe class CExoResFile : CExoPackedFile {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;

  internal CExoResFile(global::System.IntPtr cPtr, bool cMemoryOwn) : base(NWNXLibPINVOKE.CExoResFile_SWIGUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(CExoResFile obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  protected override void Dispose(bool disposing) {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          NWNXLibPINVOKE.delete_CExoResFile(swigCPtr);
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

  public static unsafe implicit operator void*(CExoResFile self) {
    return (void*)self.swigCPtr.Handle;
  }

  public static unsafe CExoResFile FromPointer(void* pointer, bool memoryOwn = false) {
    return pointer != null ? new CExoResFile((global::System.IntPtr)pointer, memoryOwn) : null;
  }

  public static CExoResFile FromPointer(global::System.IntPtr pointer, bool memoryOwn = false) {
    return pointer != global::System.IntPtr.Zero ? new CExoResFile(pointer, memoryOwn) : null;
  }

  public bool Equals(CExoResFile other) {
    if (ReferenceEquals(null, other)) {
      return false;
    }

    if (ReferenceEquals(this, other)) {
      return true;
    }

    return Pointer.Equals(other.Pointer);
  }

  public override bool Equals(object obj) {
    return ReferenceEquals(this, obj) || obj is CExoResFile other && Equals(other);
  }

  public override int GetHashCode() {
    return swigCPtr.Handle.GetHashCode();
  }

  public static bool operator ==(CExoResFile left, CExoResFile right) {
    return Equals(left, right);
  }

  public static bool operator !=(CExoResFile left, CExoResFile right) {
    return !Equals(left, right);
  }
/*@SWIG@*/
  public BIFFFILE_Version m_nVersion {
    set {
      NWNXLibPINVOKE.CExoResFile_m_nVersion_set(swigCPtr, (int)value);
    } 
    get {
      BIFFFILE_Version ret = (BIFFFILE_Version)NWNXLibPINVOKE.CExoResFile_m_nVersion_get(swigCPtr);
      return ret;
    } 
  }

  public BIFFFILE_HEADER m_pBiffHeader {
    set {
      NWNXLibPINVOKE.CExoResFile_m_pBiffHeader_set(swigCPtr, BIFFFILE_HEADER.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = NWNXLibPINVOKE.CExoResFile_m_pBiffHeader_get(swigCPtr);
      BIFFFILE_HEADER ret = (cPtr == global::System.IntPtr.Zero) ? null : new BIFFFILE_HEADER(cPtr, false);
      return ret;
    } 
  }

  public BIFFFILE_VARRESENTRY_E1 m_pBiffVarResEntry {
    set {
      NWNXLibPINVOKE.CExoResFile_m_pBiffVarResEntry_set(swigCPtr, BIFFFILE_VARRESENTRY_E1.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = NWNXLibPINVOKE.CExoResFile_m_pBiffVarResEntry_get(swigCPtr);
      BIFFFILE_VARRESENTRY_E1 ret = (cPtr == global::System.IntPtr.Zero) ? null : new BIFFFILE_VARRESENTRY_E1(cPtr, false);
      return ret;
    } 
  }

  public CExoResFile() : this(NWNXLibPINVOKE.new_CExoResFile(), true) {
  }

  public override void AddRefCount() {
    NWNXLibPINVOKE.CExoResFile_AddRefCount(swigCPtr);
  }

  public override void AddAsyncRefCount() {
    NWNXLibPINVOKE.CExoResFile_AddAsyncRefCount(swigCPtr);
  }

  public override int CloseFile() {
    int retVal = NWNXLibPINVOKE.CExoResFile_CloseFile(swigCPtr);
    return retVal;
  }

  public override int CloseAsyncFile() {
    int retVal = NWNXLibPINVOKE.CExoResFile_CloseAsyncFile(swigCPtr);
    return retVal;
  }

  public override void DeleteRefCount() {
    NWNXLibPINVOKE.CExoResFile_DeleteRefCount(swigCPtr);
  }

  public override void DeleteAsyncRefCount() {
    NWNXLibPINVOKE.CExoResFile_DeleteAsyncRefCount(swigCPtr);
  }

  public override uint GetResourceSize(RESID nID) {
    uint retVal = NWNXLibPINVOKE.CExoResFile_GetResourceSize(swigCPtr, RESID.getCPtr(nID));
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
    return retVal;
  }

  public override int Initialize() {
    int retVal = NWNXLibPINVOKE.CExoResFile_Initialize(swigCPtr);
    return retVal;
  }

  public override int OpenFile() {
    int retVal = NWNXLibPINVOKE.CExoResFile_OpenFile__SWIG_0(swigCPtr);
    return retVal;
  }

  public override int OpenFile(byte* pCipher) {
    int retVal = NWNXLibPINVOKE.CExoResFile_OpenFile__SWIG_1(swigCPtr, pCipher);
    return retVal;
  }

  public override int OpenAsyncFile() {
    int retVal = NWNXLibPINVOKE.CExoResFile_OpenAsyncFile(swigCPtr);
    return retVal;
  }

  public override uint ReadResource(RESID nID, void* pData, uint nSize, uint nDataOffset) {
    uint retVal = NWNXLibPINVOKE.CExoResFile_ReadResource(swigCPtr, RESID.getCPtr(nID), (global::System.IntPtr)pData, nSize, nDataOffset);
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
    return retVal;
  }

  public override void ReadResourceAsync(RESID nID, void* pData, uint nSize, uint nDataOffset) {
    NWNXLibPINVOKE.CExoResFile_ReadResourceAsync(swigCPtr, RESID.getCPtr(nID), (global::System.IntPtr)pData, nSize, nDataOffset);
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
  }

  public override int LoadHeader(byte* expectOid, byte nType) {
    int retVal = NWNXLibPINVOKE.CExoResFile_LoadHeader__SWIG_0(swigCPtr, expectOid, nType);
    return retVal;
  }

  public override int LoadHeader(byte* expectOid) {
    int retVal = NWNXLibPINVOKE.CExoResFile_LoadHeader__SWIG_1(swigCPtr, expectOid);
    return retVal;
  }

  public override int UnloadHeader() {
    int retVal = NWNXLibPINVOKE.CExoResFile_UnloadHeader(swigCPtr);
    return retVal;
  }

  public new void _Destructor() {
    NWNXLibPINVOKE.CExoResFile__Destructor(swigCPtr);
  }

}

}

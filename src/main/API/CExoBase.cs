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

public unsafe class CExoBase : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal CExoBase(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(CExoBase obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~CExoBase() {
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
          NWNXLibPINVOKE.delete_CExoBase(swigCPtr);
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

  public static unsafe implicit operator void*(CExoBase self) {
    return (void*)self.swigCPtr.Handle;
  }

  public static unsafe CExoBase FromPointer(void* pointer, bool memoryOwn = false) {
    return pointer != null ? new CExoBase((global::System.IntPtr)pointer, memoryOwn) : null;
  }

  public static CExoBase FromPointer(global::System.IntPtr pointer, bool memoryOwn = false) {
    return pointer != global::System.IntPtr.Zero ? new CExoBase(pointer, memoryOwn) : null;
  }

  public bool Equals(CExoBase other) {
    if (ReferenceEquals(null, other)) {
      return false;
    }

    if (ReferenceEquals(this, other)) {
      return true;
    }

    return Pointer.Equals(other.Pointer);
  }

  public override bool Equals(object obj) {
    return ReferenceEquals(this, obj) || obj is CExoBase other && Equals(other);
  }

  public override int GetHashCode() {
    return swigCPtr.Handle.GetHashCode();
  }

  public static bool operator ==(CExoBase left, CExoBase right) {
    return Equals(left, right);
  }

  public static bool operator !=(CExoBase left, CExoBase right) {
    return !Equals(left, right);
  }

  public SWIGTYPE_p_CExoConfig m_pcExoConfig {
    set {
      NWNXLibPINVOKE.CExoBase_m_pcExoConfig_set(swigCPtr, SWIGTYPE_p_CExoConfig.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = NWNXLibPINVOKE.CExoBase_m_pcExoConfig_get(swigCPtr);
      SWIGTYPE_p_CExoConfig ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_CExoConfig(cPtr, false);
      return ret;
    } 
  }

  public CExoIni m_pcExoIni {
    set {
      NWNXLibPINVOKE.CExoBase_m_pcExoIni_set(swigCPtr, CExoIni.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = NWNXLibPINVOKE.CExoBase_m_pcExoIni_get(swigCPtr);
      CExoIni ret = (cPtr == global::System.IntPtr.Zero) ? null : new CExoIni(cPtr, false);
      return ret;
    } 
  }

  public CExoTimers m_pcExoTimers {
    set {
      NWNXLibPINVOKE.CExoBase_m_pcExoTimers_set(swigCPtr, CExoTimers.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = NWNXLibPINVOKE.CExoBase_m_pcExoTimers_get(swigCPtr);
      CExoTimers ret = (cPtr == global::System.IntPtr.Zero) ? null : new CExoTimers(cPtr, false);
      return ret;
    } 
  }

  public CExoDebug m_pcExoDebug {
    set {
      NWNXLibPINVOKE.CExoBase_m_pcExoDebug_set(swigCPtr, CExoDebug.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = NWNXLibPINVOKE.CExoBase_m_pcExoDebug_get(swigCPtr);
      CExoDebug ret = (cPtr == global::System.IntPtr.Zero) ? null : new CExoDebug(cPtr, false);
      return ret;
    } 
  }

  public CExoAliasList m_pcExoAliasList {
    set {
      NWNXLibPINVOKE.CExoBase_m_pcExoAliasList_set(swigCPtr, CExoAliasList.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = NWNXLibPINVOKE.CExoBase_m_pcExoAliasList_get(swigCPtr);
      CExoAliasList ret = (cPtr == global::System.IntPtr.Zero) ? null : new CExoAliasList(cPtr, false);
      return ret;
    } 
  }

  public CExoRand m_pcExoRand {
    set {
      NWNXLibPINVOKE.CExoBase_m_pcExoRand_set(swigCPtr, CExoRand.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = NWNXLibPINVOKE.CExoBase_m_pcExoRand_get(swigCPtr);
      CExoRand ret = (cPtr == global::System.IntPtr.Zero) ? null : new CExoRand(cPtr, false);
      return ret;
    } 
  }

  public SWIGTYPE_p_CExoIdentity m_pcExoIdentity {
    set {
      NWNXLibPINVOKE.CExoBase_m_pcExoIdentity_set(swigCPtr, SWIGTYPE_p_CExoIdentity.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = NWNXLibPINVOKE.CExoBase_m_pcExoIdentity_get(swigCPtr);
      SWIGTYPE_p_CExoIdentity ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_CExoIdentity(cPtr, false);
      return ret;
    } 
  }

  public uint m_nExpansionPacks {
    set {
      NWNXLibPINVOKE.CExoBase_m_nExpansionPacks_set(swigCPtr, value);
    } 
    get {
      uint retVal = NWNXLibPINVOKE.CExoBase_m_nExpansionPacks_get(swigCPtr);
      return retVal;
    }

  }

  public CExoBaseInternal m_pcExoBaseInternal {
    set {
      NWNXLibPINVOKE.CExoBase_m_pcExoBaseInternal_set(swigCPtr, CExoBaseInternal.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = NWNXLibPINVOKE.CExoBase_m_pcExoBaseInternal_get(swigCPtr);
      CExoBaseInternal ret = (cPtr == global::System.IntPtr.Zero) ? null : new CExoBaseInternal(cPtr, false);
      return ret;
    } 
  }

  public CExoString m_sUserDirectory {
    set {
      NWNXLibPINVOKE.CExoBase_m_sUserDirectory_set(swigCPtr, CExoString.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = NWNXLibPINVOKE.CExoBase_m_sUserDirectory_get(swigCPtr);
      CExoString ret = (cPtr == global::System.IntPtr.Zero) ? null : new CExoString(cPtr, false);
      return ret;
    } 
  }

  public CExoBase(CExoString sUserDirectory) : this(NWNXLibPINVOKE.new_CExoBase(CExoString.getCPtr(sUserDirectory)), true) {
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
  }

  public int GetDirectoryList(CExoArrayListCExoString lstFilename, CExoString sAliasOrPath, ushort nResType, int bGetDirectories, int bSort, int bResolveAlias) {
    int retVal = NWNXLibPINVOKE.CExoBase_GetDirectoryList__SWIG_0(swigCPtr, CExoArrayListCExoString.getCPtr(lstFilename), CExoString.getCPtr(sAliasOrPath), nResType, bGetDirectories, bSort, bResolveAlias);
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
    return retVal;
  }

  public int GetDirectoryList(CExoArrayListCExoString lstFilename, CExoString sAliasOrPath, ushort nResType, int bGetDirectories, int bSort) {
    int retVal = NWNXLibPINVOKE.CExoBase_GetDirectoryList__SWIG_1(swigCPtr, CExoArrayListCExoString.getCPtr(lstFilename), CExoString.getCPtr(sAliasOrPath), nResType, bGetDirectories, bSort);
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
    return retVal;
  }

  public int GetDirectoryList(CExoArrayListCExoString lstFilename, CExoString sAliasOrPath, ushort nResType, int bGetDirectories) {
    int retVal = NWNXLibPINVOKE.CExoBase_GetDirectoryList__SWIG_2(swigCPtr, CExoArrayListCExoString.getCPtr(lstFilename), CExoString.getCPtr(sAliasOrPath), nResType, bGetDirectories);
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
    return retVal;
  }

  public int GetDirectoryList(CExoArrayListCExoString lstFilename, CExoString sAliasOrPath, ushort nResType) {
    int retVal = NWNXLibPINVOKE.CExoBase_GetDirectoryList__SWIG_3(swigCPtr, CExoArrayListCExoString.getCPtr(lstFilename), CExoString.getCPtr(sAliasOrPath), nResType);
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
    return retVal;
  }

  public int GetDirectoryAndWorkshopList(CExoArrayListCExoString lstFilename, CExoString sAlias, ushort nResType, int bGetDirectories, int bSort) {
    int retVal = NWNXLibPINVOKE.CExoBase_GetDirectoryAndWorkshopList__SWIG_0(swigCPtr, CExoArrayListCExoString.getCPtr(lstFilename), CExoString.getCPtr(sAlias), nResType, bGetDirectories, bSort);
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
    return retVal;
  }

  public int GetDirectoryAndWorkshopList(CExoArrayListCExoString lstFilename, CExoString sAlias, ushort nResType, int bGetDirectories) {
    int retVal = NWNXLibPINVOKE.CExoBase_GetDirectoryAndWorkshopList__SWIG_1(swigCPtr, CExoArrayListCExoString.getCPtr(lstFilename), CExoString.getCPtr(sAlias), nResType, bGetDirectories);
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
    return retVal;
  }

  public int GetDirectoryAndWorkshopList(CExoArrayListCExoString lstFilename, CExoString sAlias, ushort nResType) {
    int retVal = NWNXLibPINVOKE.CExoBase_GetDirectoryAndWorkshopList__SWIG_2(swigCPtr, CExoArrayListCExoString.getCPtr(lstFilename), CExoString.getCPtr(sAlias), nResType);
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
    return retVal;
  }

  public int GetAugmentedDirectoryList(CExoArrayListCFileInfo lstFileInfo, CExoString sAlias, ushort nResType, int bSort) {
    int retVal = NWNXLibPINVOKE.CExoBase_GetAugmentedDirectoryList__SWIG_0(swigCPtr, CExoArrayListCFileInfo.getCPtr(lstFileInfo), CExoString.getCPtr(sAlias), nResType, bSort);
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
    return retVal;
  }

  public int GetAugmentedDirectoryList(CExoArrayListCFileInfo lstFileInfo, CExoString sAlias, ushort nResType) {
    int retVal = NWNXLibPINVOKE.CExoBase_GetAugmentedDirectoryList__SWIG_1(swigCPtr, CExoArrayListCFileInfo.getCPtr(lstFileInfo), CExoString.getCPtr(sAlias), nResType);
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
    return retVal;
  }

  public CExoString GetInstallDirectory() {
    CExoString ret = new CExoString(NWNXLibPINVOKE.CExoBase_GetInstallDirectory(swigCPtr), false);
    return ret;
  }

  public CExoString GetResourceExtension(ushort nType) {
    CExoString ret = new CExoString(NWNXLibPINVOKE.CExoBase_GetResourceExtension(swigCPtr, nType), false);
    return ret;
  }

  public ushort GetResTypeFromExtension(CExoString sExtension) {
    ushort retVal = NWNXLibPINVOKE.CExoBase_GetResTypeFromExtension(swigCPtr, CExoString.getCPtr(sExtension));
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
    return retVal;
  }

  public void LoadAliases(int idxIniFile) {
    NWNXLibPINVOKE.CExoBase_LoadAliases(swigCPtr, idxIniFile);
  }

  public void ShutDown() {
    NWNXLibPINVOKE.CExoBase_ShutDown(swigCPtr);
  }

  public int CheckForCD(uint nLanguage) {
    int retVal = NWNXLibPINVOKE.CExoBase_CheckForCD__SWIG_0(swigCPtr, nLanguage);
    return retVal;
  }

  public int CheckForCD() {
    int retVal = NWNXLibPINVOKE.CExoBase_CheckForCD__SWIG_1(swigCPtr);
    return retVal;
  }

  public void _Destructor() {
    NWNXLibPINVOKE.CExoBase__Destructor(swigCPtr);
  }

}

}

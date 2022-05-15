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

public unsafe class CResGFF : CRes {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;

  internal CResGFF(global::System.IntPtr cPtr, bool cMemoryOwn) : base(NWNXLibPINVOKE.CResGFF_SWIGUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(CResGFF obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  protected override void Dispose(bool disposing) {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          NWNXLibPINVOKE.delete_CResGFF(swigCPtr);
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

  public static unsafe implicit operator void*(CResGFF self) {
    return (void*)self.swigCPtr.Handle;
  }

  public static unsafe CResGFF FromPointer(void* pointer, bool memoryOwn = false) {
    return pointer != null ? new CResGFF((global::System.IntPtr)pointer, memoryOwn) : null;
  }

  public static CResGFF FromPointer(global::System.IntPtr pointer, bool memoryOwn = false) {
    return pointer != global::System.IntPtr.Zero ? new CResGFF(pointer, memoryOwn) : null;
  }

  public bool Equals(CResGFF other) {
    if (ReferenceEquals(null, other)) {
      return false;
    }

    if (ReferenceEquals(this, other)) {
      return true;
    }

    return Pointer.Equals(other.Pointer);
  }

  public override bool Equals(object obj) {
    return ReferenceEquals(this, obj) || obj is CResGFF other && Equals(other);
  }

  public override int GetHashCode() {
    return swigCPtr.Handle.GetHashCode();
  }

  public static bool operator ==(CResGFF left, CResGFF right) {
    return Equals(left, right);
  }

  public static bool operator !=(CResGFF left, CResGFF right) {
    return !Equals(left, right);
  }
/*@SWIG@*/
  public uint STRUCT_GROWSIZE {
    set {
      NWNXLibPINVOKE.CResGFF_STRUCT_GROWSIZE_set(swigCPtr, value);
    } 
    get {
      uint retVal = NWNXLibPINVOKE.CResGFF_STRUCT_GROWSIZE_get(swigCPtr);
      return retVal;
    }

  }

  public uint FIELD_GROWSIZE {
    set {
      NWNXLibPINVOKE.CResGFF_FIELD_GROWSIZE_set(swigCPtr, value);
    } 
    get {
      uint retVal = NWNXLibPINVOKE.CResGFF_FIELD_GROWSIZE_get(swigCPtr);
      return retVal;
    }

  }

  public uint LABEL_GROWSIZE {
    set {
      NWNXLibPINVOKE.CResGFF_LABEL_GROWSIZE_set(swigCPtr, value);
    } 
    get {
      uint retVal = NWNXLibPINVOKE.CResGFF_LABEL_GROWSIZE_get(swigCPtr);
      return retVal;
    }

  }

  public uint DATAFIELD_GROWSIZE {
    set {
      NWNXLibPINVOKE.CResGFF_DATAFIELD_GROWSIZE_set(swigCPtr, value);
    } 
    get {
      uint retVal = NWNXLibPINVOKE.CResGFF_DATAFIELD_GROWSIZE_get(swigCPtr);
      return retVal;
    }

  }

  public uint DATALAYOUTFIELD_GROWSIZE {
    set {
      NWNXLibPINVOKE.CResGFF_DATALAYOUTFIELD_GROWSIZE_set(swigCPtr, value);
    } 
    get {
      uint retVal = NWNXLibPINVOKE.CResGFF_DATALAYOUTFIELD_GROWSIZE_get(swigCPtr);
      return retVal;
    }

  }

  public uint DATALAYOUTLIST_GROWSIZE {
    set {
      NWNXLibPINVOKE.CResGFF_DATALAYOUTLIST_GROWSIZE_set(swigCPtr, value);
    } 
    get {
      uint retVal = NWNXLibPINVOKE.CResGFF_DATALAYOUTLIST_GROWSIZE_get(swigCPtr);
      return retVal;
    }

  }

  public CResGFFFileHeader m_pFileHeader {
    set {
      NWNXLibPINVOKE.CResGFF_m_pFileHeader_set(swigCPtr, CResGFFFileHeader.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = NWNXLibPINVOKE.CResGFF_m_pFileHeader_get(swigCPtr);
      CResGFFFileHeader ret = (cPtr == global::System.IntPtr.Zero) ? null : new CResGFFFileHeader(cPtr, false);
      return ret;
    } 
  }

  public byte* m_pDDFileHeader {
    set {
      NWNXLibPINVOKE.CResGFF_m_pDDFileHeader_set(swigCPtr, value);
    } 
    get {
      byte* retVal = NWNXLibPINVOKE.CResGFF_m_pDDFileHeader_get(swigCPtr);
      return retVal;
    }

  }

  public uint m_nHeaderOffset {
    set {
      NWNXLibPINVOKE.CResGFF_m_nHeaderOffset_set(swigCPtr, value);
    } 
    get {
      uint retVal = NWNXLibPINVOKE.CResGFF_m_nHeaderOffset_get(swigCPtr);
      return retVal;
    }

  }

  public CResGFFStruct m_pStruct {
    set {
      NWNXLibPINVOKE.CResGFF_m_pStruct_set(swigCPtr, CResGFFStruct.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = NWNXLibPINVOKE.CResGFF_m_pStruct_get(swigCPtr);
      CResGFFStruct ret = (cPtr == global::System.IntPtr.Zero) ? null : new CResGFFStruct(cPtr, false);
      return ret;
    } 
  }

  public uint m_nStructAllocated {
    set {
      NWNXLibPINVOKE.CResGFF_m_nStructAllocated_set(swigCPtr, value);
    } 
    get {
      uint retVal = NWNXLibPINVOKE.CResGFF_m_nStructAllocated_get(swigCPtr);
      return retVal;
    }

  }

  public CResGFFField m_pField {
    set {
      NWNXLibPINVOKE.CResGFF_m_pField_set(swigCPtr, CResGFFField.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = NWNXLibPINVOKE.CResGFF_m_pField_get(swigCPtr);
      CResGFFField ret = (cPtr == global::System.IntPtr.Zero) ? null : new CResGFFField(cPtr, false);
      return ret;
    } 
  }

  public uint m_nFieldAllocated {
    set {
      NWNXLibPINVOKE.CResGFF_m_nFieldAllocated_set(swigCPtr, value);
    } 
    get {
      uint retVal = NWNXLibPINVOKE.CResGFF_m_nFieldAllocated_get(swigCPtr);
      return retVal;
    }

  }

  public CResGFFLabel m_pLabel {
    set {
      NWNXLibPINVOKE.CResGFF_m_pLabel_set(swigCPtr, CResGFFLabel.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = NWNXLibPINVOKE.CResGFF_m_pLabel_get(swigCPtr);
      CResGFFLabel ret = (cPtr == global::System.IntPtr.Zero) ? null : new CResGFFLabel(cPtr, false);
      return ret;
    } 
  }

  public uint m_nLabelAllocated {
    set {
      NWNXLibPINVOKE.CResGFF_m_nLabelAllocated_set(swigCPtr, value);
    } 
    get {
      uint retVal = NWNXLibPINVOKE.CResGFF_m_nLabelAllocated_get(swigCPtr);
      return retVal;
    }

  }

  public byte* m_pDataField {
    set {
      NWNXLibPINVOKE.CResGFF_m_pDataField_set(swigCPtr, value);
    } 
    get {
      byte* retVal = NWNXLibPINVOKE.CResGFF_m_pDataField_get(swigCPtr);
      return retVal;
    }

  }

  public uint m_nDataFieldAllocated {
    set {
      NWNXLibPINVOKE.CResGFF_m_nDataFieldAllocated_set(swigCPtr, value);
    } 
    get {
      uint retVal = NWNXLibPINVOKE.CResGFF_m_nDataFieldAllocated_get(swigCPtr);
      return retVal;
    }

  }

  public byte* m_pDataLayoutField {
    set {
      NWNXLibPINVOKE.CResGFF_m_pDataLayoutField_set(swigCPtr, value);
    } 
    get {
      byte* retVal = NWNXLibPINVOKE.CResGFF_m_pDataLayoutField_get(swigCPtr);
      return retVal;
    }

  }

  public uint m_nDataLayoutFieldAllocated {
    set {
      NWNXLibPINVOKE.CResGFF_m_nDataLayoutFieldAllocated_set(swigCPtr, value);
    } 
    get {
      uint retVal = NWNXLibPINVOKE.CResGFF_m_nDataLayoutFieldAllocated_get(swigCPtr);
      return retVal;
    }

  }

  public uint m_nDataLayoutFieldWasted {
    set {
      NWNXLibPINVOKE.CResGFF_m_nDataLayoutFieldWasted_set(swigCPtr, value);
    } 
    get {
      uint retVal = NWNXLibPINVOKE.CResGFF_m_nDataLayoutFieldWasted_get(swigCPtr);
      return retVal;
    }

  }

  public byte* m_pDataLayoutList {
    set {
      NWNXLibPINVOKE.CResGFF_m_pDataLayoutList_set(swigCPtr, value);
    } 
    get {
      byte* retVal = NWNXLibPINVOKE.CResGFF_m_pDataLayoutList_get(swigCPtr);
      return retVal;
    }

  }

  public uint m_nDataLayoutListAllocated {
    set {
      NWNXLibPINVOKE.CResGFF_m_nDataLayoutListAllocated_set(swigCPtr, value);
    } 
    get {
      uint retVal = NWNXLibPINVOKE.CResGFF_m_nDataLayoutListAllocated_get(swigCPtr);
      return retVal;
    }

  }

  public uint m_nDataLayoutListWasted {
    set {
      NWNXLibPINVOKE.CResGFF_m_nDataLayoutListWasted_set(swigCPtr, value);
    } 
    get {
      uint retVal = NWNXLibPINVOKE.CResGFF_m_nDataLayoutListWasted_get(swigCPtr);
      return retVal;
    }

  }

  public NativeArray<byte> m_pLabelBuffer {
    set {
      NWNXLibPINVOKE.CResGFF_m_pLabelBuffer_set(swigCPtr, value);
    } 
    get {
      global::System.IntPtr arrayPtr = NWNXLibPINVOKE.CResGFF_m_pLabelBuffer_get(swigCPtr);
      NativeArray<byte> retVal = new NativeArray<byte>(arrayPtr, 17);

      return retVal; // byte[17]
    }

  }

  public NativeArray<byte> m_pFileType {
    set {
      NWNXLibPINVOKE.CResGFF_m_pFileType_set(swigCPtr, value);
    } 
    get {
      global::System.IntPtr arrayPtr = NWNXLibPINVOKE.CResGFF_m_pFileType_get(swigCPtr);
      NativeArray<byte> retVal = new NativeArray<byte>(arrayPtr, 4);

      return retVal; // byte[4]
    }

  }

  public int m_bLoaded {
    set {
      NWNXLibPINVOKE.CResGFF_m_bLoaded_set(swigCPtr, value);
    } 
    get {
      int retVal = NWNXLibPINVOKE.CResGFF_m_bLoaded_get(swigCPtr);
      return retVal;
    }

  }

  public int m_bResourceLoaded {
    set {
      NWNXLibPINVOKE.CResGFF_m_bResourceLoaded_set(swigCPtr, value);
    } 
    get {
      int retVal = NWNXLibPINVOKE.CResGFF_m_bResourceLoaded_get(swigCPtr);
      return retVal;
    }

  }

  public int m_bSelfDemanded {
    set {
      NWNXLibPINVOKE.CResGFF_m_bSelfDemanded_set(swigCPtr, value);
    } 
    get {
      int retVal = NWNXLibPINVOKE.CResGFF_m_bSelfDemanded_get(swigCPtr);
      return retVal;
    }

  }

  public int m_bDataPtrOwned {
    set {
      NWNXLibPINVOKE.CResGFF_m_bDataPtrOwned_set(swigCPtr, value);
    } 
    get {
      int retVal = NWNXLibPINVOKE.CResGFF_m_bDataPtrOwned_get(swigCPtr);
      return retVal;
    }

  }

  public int m_bReplaceExistingFields {
    set {
      NWNXLibPINVOKE.CResGFF_m_bReplaceExistingFields_set(swigCPtr, value);
    } 
    get {
      int retVal = NWNXLibPINVOKE.CResGFF_m_bReplaceExistingFields_get(swigCPtr);
      return retVal;
    }

  }

  public int m_bValidationFailed {
    set {
      NWNXLibPINVOKE.CResGFF_m_bValidationFailed_set(swigCPtr, value);
    } 
    get {
      int retVal = NWNXLibPINVOKE.CResGFF_m_bValidationFailed_get(swigCPtr);
      return retVal;
    }

  }

  public CResGFF() : this(NWNXLibPINVOKE.new_CResGFF__SWIG_0(), true) {
  }

  public CResGFF(ushort nType, byte* cIDStr, CResRef cResRef) : this(NWNXLibPINVOKE.new_CResGFF__SWIG_1(nType, cIDStr, CResRef.getCPtr(cResRef)), true) {
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
  }

  public override int OnResourceServiced() {
    int retVal = NWNXLibPINVOKE.CResGFF_OnResourceServiced(swigCPtr);
    return retVal;
  }

  public override int OnResourceFreed() {
    int retVal = NWNXLibPINVOKE.CResGFF_OnResourceFreed(swigCPtr);
    return retVal;
  }

  public int GetDataFromFile(byte* pFileName) {
    int retVal = NWNXLibPINVOKE.CResGFF_GetDataFromFile(swigCPtr, pFileName);
    return retVal;
  }

  public int GetDataFromPointer(void* pData, int nDataSize, bool bTakeOwnership) {
    int retVal = NWNXLibPINVOKE.CResGFF_GetDataFromPointer(swigCPtr, (global::System.IntPtr)pData, nDataSize, bTakeOwnership);
    return retVal;
  }

  public void GetGFFFileInfo(CExoString pFileType, CExoString pVersion) {
    NWNXLibPINVOKE.CResGFF_GetGFFFileInfo(swigCPtr, CExoString.getCPtr(pFileType), CExoString.getCPtr(pVersion));
  }

  public uint GetElementType(CResStruct pStructure) {
    uint retVal = NWNXLibPINVOKE.CResGFF_GetElementType(swigCPtr, CResStruct.getCPtr(pStructure));
    return retVal;
  }

  public uint GetFieldCount(CResStruct pStructure) {
    uint retVal = NWNXLibPINVOKE.CResGFF_GetFieldCount__SWIG_0(swigCPtr, CResStruct.getCPtr(pStructure));
    return retVal;
  }

  public uint GetFieldType(CResStruct pStructure, byte* szFieldID, uint nFieldIndex) {
    uint retVal = NWNXLibPINVOKE.CResGFF_GetFieldType__SWIG_0(swigCPtr, CResStruct.getCPtr(pStructure), szFieldID, nFieldIndex);
    return retVal;
  }

  public uint GetFieldType(CResStruct pStructure, byte* szFieldID) {
    uint retVal = NWNXLibPINVOKE.CResGFF_GetFieldType__SWIG_1(swigCPtr, CResStruct.getCPtr(pStructure), szFieldID);
    return retVal;
  }

  public byte* GetFieldStringID(CResStruct pStructure, uint nFieldIndex) {
    byte* retVal = NWNXLibPINVOKE.CResGFF_GetFieldStringID(swigCPtr, CResStruct.getCPtr(pStructure), nFieldIndex);
    return retVal;
  }

  public uint GetFieldSize(CResStruct pStructure, byte* szFieldID, uint nFieldIndex) {
    uint retVal = NWNXLibPINVOKE.CResGFF_GetFieldSize__SWIG_0(swigCPtr, CResStruct.getCPtr(pStructure), szFieldID, nFieldIndex);
    return retVal;
  }

  public uint GetFieldSize(CResStruct pStructure, byte* szFieldID) {
    uint retVal = NWNXLibPINVOKE.CResGFF_GetFieldSize__SWIG_1(swigCPtr, CResStruct.getCPtr(pStructure), szFieldID);
    return retVal;
  }

  public int GetList(CResList pList, CResStruct pStructure, byte* szFieldID) {
    int retVal = NWNXLibPINVOKE.CResGFF_GetList(swigCPtr, CResList.getCPtr(pList), CResStruct.getCPtr(pStructure), szFieldID);
    return retVal;
  }

  public uint GetListCount(CResList pList) {
    uint retVal = NWNXLibPINVOKE.CResGFF_GetListCount(swigCPtr, CResList.getCPtr(pList));
    return retVal;
  }

  public int GetListElement(CResStruct pStruct, CResList pList, uint nIndex) {
    int retVal = NWNXLibPINVOKE.CResGFF_GetListElement(swigCPtr, CResStruct.getCPtr(pStruct), CResList.getCPtr(pList), nIndex);
    return retVal;
  }

  public int GetStructFromStruct(CResStruct pStruct, CResStruct pParentStruct, byte* szFieldID) {
    int retVal = NWNXLibPINVOKE.CResGFF_GetStructFromStruct(swigCPtr, CResStruct.getCPtr(pStruct), CResStruct.getCPtr(pParentStruct), szFieldID);
    return retVal;
  }

  public int GetTopLevelStruct(CResStruct pStructure) {
    int retVal = NWNXLibPINVOKE.CResGFF_GetTopLevelStruct(swigCPtr, CResStruct.getCPtr(pStructure));
    return retVal;
  }

  public byte ReadFieldBYTE(CResStruct pStructure, byte* szFieldID, int* bSuccess, byte nDefault) {
    byte retVal = NWNXLibPINVOKE.CResGFF_ReadFieldBYTE__SWIG_0(swigCPtr, CResStruct.getCPtr(pStructure), szFieldID, (global::System.IntPtr)bSuccess, nDefault);
    return retVal;
  }

  public byte ReadFieldBYTE(CResStruct pStructure, byte* szFieldID, int* bSuccess) {
    byte retVal = NWNXLibPINVOKE.CResGFF_ReadFieldBYTE__SWIG_1(swigCPtr, CResStruct.getCPtr(pStructure), szFieldID, (global::System.IntPtr)bSuccess);
    return retVal;
  }

  public byte ReadFieldCHAR(CResStruct pStructure, byte* szFieldID, int* bSuccess, byte nDefault) {
    byte retVal = NWNXLibPINVOKE.CResGFF_ReadFieldCHAR__SWIG_0(swigCPtr, CResStruct.getCPtr(pStructure), szFieldID, (global::System.IntPtr)bSuccess, nDefault);
    return retVal;
  }

  public byte ReadFieldCHAR(CResStruct pStructure, byte* szFieldID, int* bSuccess) {
    byte retVal = NWNXLibPINVOKE.CResGFF_ReadFieldCHAR__SWIG_1(swigCPtr, CResStruct.getCPtr(pStructure), szFieldID, (global::System.IntPtr)bSuccess);
    return retVal;
  }

  public ushort ReadFieldWORD(CResStruct pStructure, byte* szFieldID, int* bSuccess, ushort nDefault) {
    ushort retVal = NWNXLibPINVOKE.CResGFF_ReadFieldWORD__SWIG_0(swigCPtr, CResStruct.getCPtr(pStructure), szFieldID, (global::System.IntPtr)bSuccess, nDefault);
    return retVal;
  }

  public ushort ReadFieldWORD(CResStruct pStructure, byte* szFieldID, int* bSuccess) {
    ushort retVal = NWNXLibPINVOKE.CResGFF_ReadFieldWORD__SWIG_1(swigCPtr, CResStruct.getCPtr(pStructure), szFieldID, (global::System.IntPtr)bSuccess);
    return retVal;
  }

  public short ReadFieldSHORT(CResStruct pStructure, byte* szFieldID, int* bSuccess, short nDefault) {
    short retVal = NWNXLibPINVOKE.CResGFF_ReadFieldSHORT__SWIG_0(swigCPtr, CResStruct.getCPtr(pStructure), szFieldID, (global::System.IntPtr)bSuccess, nDefault);
    return retVal;
  }

  public short ReadFieldSHORT(CResStruct pStructure, byte* szFieldID, int* bSuccess) {
    short retVal = NWNXLibPINVOKE.CResGFF_ReadFieldSHORT__SWIG_1(swigCPtr, CResStruct.getCPtr(pStructure), szFieldID, (global::System.IntPtr)bSuccess);
    return retVal;
  }

  public uint ReadFieldDWORD(CResStruct pStructure, byte* szFieldID, int* bSuccess, uint nDefault) {
    uint retVal = NWNXLibPINVOKE.CResGFF_ReadFieldDWORD__SWIG_0(swigCPtr, CResStruct.getCPtr(pStructure), szFieldID, (global::System.IntPtr)bSuccess, nDefault);
    return retVal;
  }

  public uint ReadFieldDWORD(CResStruct pStructure, byte* szFieldID, int* bSuccess) {
    uint retVal = NWNXLibPINVOKE.CResGFF_ReadFieldDWORD__SWIG_1(swigCPtr, CResStruct.getCPtr(pStructure), szFieldID, (global::System.IntPtr)bSuccess);
    return retVal;
  }

  public int ReadFieldINT(CResStruct pStructure, byte* szFieldID, int* bSuccess, int nDefault) {
    int retVal = NWNXLibPINVOKE.CResGFF_ReadFieldINT__SWIG_0(swigCPtr, CResStruct.getCPtr(pStructure), szFieldID, (global::System.IntPtr)bSuccess, nDefault);
    return retVal;
  }

  public int ReadFieldINT(CResStruct pStructure, byte* szFieldID, int* bSuccess) {
    int retVal = NWNXLibPINVOKE.CResGFF_ReadFieldINT__SWIG_1(swigCPtr, CResStruct.getCPtr(pStructure), szFieldID, (global::System.IntPtr)bSuccess);
    return retVal;
  }

  public ulong ReadFieldDWORD64(CResStruct pStructure, byte* szFieldID, int* bSuccess, ulong nDefault) {
    ulong retVal = NWNXLibPINVOKE.CResGFF_ReadFieldDWORD64__SWIG_0(swigCPtr, CResStruct.getCPtr(pStructure), szFieldID, (global::System.IntPtr)bSuccess, nDefault);
    return retVal;
  }

  public ulong ReadFieldDWORD64(CResStruct pStructure, byte* szFieldID, int* bSuccess) {
    ulong retVal = NWNXLibPINVOKE.CResGFF_ReadFieldDWORD64__SWIG_1(swigCPtr, CResStruct.getCPtr(pStructure), szFieldID, (global::System.IntPtr)bSuccess);
    return retVal;
  }

  public long ReadFieldINT64(CResStruct pStructure, byte* szFieldID, int* bSuccess, long nDefault) {
    long retVal = NWNXLibPINVOKE.CResGFF_ReadFieldINT64__SWIG_0(swigCPtr, CResStruct.getCPtr(pStructure), szFieldID, (global::System.IntPtr)bSuccess, nDefault);
    return retVal;
  }

  public long ReadFieldINT64(CResStruct pStructure, byte* szFieldID, int* bSuccess) {
    long retVal = NWNXLibPINVOKE.CResGFF_ReadFieldINT64__SWIG_1(swigCPtr, CResStruct.getCPtr(pStructure), szFieldID, (global::System.IntPtr)bSuccess);
    return retVal;
  }

  public float ReadFieldFLOAT(CResStruct pStructure, byte* szFieldID, int* bSuccess, float fDefault) {
    float retVal = NWNXLibPINVOKE.CResGFF_ReadFieldFLOAT__SWIG_0(swigCPtr, CResStruct.getCPtr(pStructure), szFieldID, (global::System.IntPtr)bSuccess, fDefault);
    return retVal;
  }

  public float ReadFieldFLOAT(CResStruct pStructure, byte* szFieldID, int* bSuccess) {
    float retVal = NWNXLibPINVOKE.CResGFF_ReadFieldFLOAT__SWIG_1(swigCPtr, CResStruct.getCPtr(pStructure), szFieldID, (global::System.IntPtr)bSuccess);
    return retVal;
  }

  public double ReadFieldDOUBLE(CResStruct pStructure, byte* szFieldID, int* bSuccess, double fDefault) {
    double ret = NWNXLibPINVOKE.CResGFF_ReadFieldDOUBLE__SWIG_0(swigCPtr, CResStruct.getCPtr(pStructure), szFieldID, (global::System.IntPtr)bSuccess, fDefault);
    return ret;
  }

  public double ReadFieldDOUBLE(CResStruct pStructure, byte* szFieldID, int* bSuccess) {
    double ret = NWNXLibPINVOKE.CResGFF_ReadFieldDOUBLE__SWIG_1(swigCPtr, CResStruct.getCPtr(pStructure), szFieldID, (global::System.IntPtr)bSuccess);
    return ret;
  }

  public CResRef ReadFieldCResRef(CResStruct pStructure, byte* szFieldID, int* bSuccess, CResRef sDefault) {
    CResRef ret = new CResRef(NWNXLibPINVOKE.CResGFF_ReadFieldCResRef__SWIG_0(swigCPtr, CResStruct.getCPtr(pStructure), szFieldID, (global::System.IntPtr)bSuccess, CResRef.getCPtr(sDefault)), true);
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public CResRef ReadFieldCResRef(CResStruct pStructure, byte* szFieldID, int* bSuccess) {
    CResRef ret = new CResRef(NWNXLibPINVOKE.CResGFF_ReadFieldCResRef__SWIG_1(swigCPtr, CResStruct.getCPtr(pStructure), szFieldID, (global::System.IntPtr)bSuccess), true);
    return ret;
  }

  public CExoString ReadFieldCExoString(CResStruct pStructure, byte* szFieldID, int* bSuccess, CExoString sDefault) {
    CExoString ret = new CExoString(NWNXLibPINVOKE.CResGFF_ReadFieldCExoString__SWIG_0(swigCPtr, CResStruct.getCPtr(pStructure), szFieldID, (global::System.IntPtr)bSuccess, CExoString.getCPtr(sDefault)), true);
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public CExoString ReadFieldCExoString(CResStruct pStructure, byte* szFieldID, int* bSuccess) {
    CExoString ret = new CExoString(NWNXLibPINVOKE.CResGFF_ReadFieldCExoString__SWIG_1(swigCPtr, CResStruct.getCPtr(pStructure), szFieldID, (global::System.IntPtr)bSuccess), true);
    return ret;
  }

  public CExoLocString ReadFieldCExoLocString(CResStruct pStructure, byte* szFieldID, int* bSuccess, CExoLocString sDefault) {
    CExoLocString ret = new CExoLocString(NWNXLibPINVOKE.CResGFF_ReadFieldCExoLocString__SWIG_0(swigCPtr, CResStruct.getCPtr(pStructure), szFieldID, (global::System.IntPtr)bSuccess, CExoLocString.getCPtr(sDefault)), true);
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public CExoLocString ReadFieldCExoLocString(CResStruct pStructure, byte* szFieldID, int* bSuccess) {
    CExoLocString ret = new CExoLocString(NWNXLibPINVOKE.CResGFF_ReadFieldCExoLocString__SWIG_1(swigCPtr, CResStruct.getCPtr(pStructure), szFieldID, (global::System.IntPtr)bSuccess), true);
    return ret;
  }

  public void* ReadFieldVOID(CResStruct pStructure, void* pVariable, uint nSize, byte* szFieldID, int* bSuccess, void* pDefault) {
    global::System.IntPtr retVal = NWNXLibPINVOKE.CResGFF_ReadFieldVOID__SWIG_0(swigCPtr, CResStruct.getCPtr(pStructure), (global::System.IntPtr)pVariable, nSize, szFieldID, (global::System.IntPtr)bSuccess, (global::System.IntPtr)pDefault);
    return (void*)retVal;
  }

  public void* ReadFieldVOID(CResStruct pStructure, void* pVariable, uint nSize, byte* szFieldID, int* bSuccess) {
    global::System.IntPtr retVal = NWNXLibPINVOKE.CResGFF_ReadFieldVOID__SWIG_1(swigCPtr, CResStruct.getCPtr(pStructure), (global::System.IntPtr)pVariable, nSize, szFieldID, (global::System.IntPtr)bSuccess);
    return (void*)retVal;
  }

  public int AddList(CResList pList, CResStruct pStructure, byte* szFieldID) {
    int retVal = NWNXLibPINVOKE.CResGFF_AddList(swigCPtr, CResList.getCPtr(pList), CResStruct.getCPtr(pStructure), szFieldID);
    return retVal;
  }

  public int AddListElement(CResStruct pStruct, CResList pList, uint nType) {
    int retVal = NWNXLibPINVOKE.CResGFF_AddListElement(swigCPtr, CResStruct.getCPtr(pStruct), CResList.getCPtr(pList), nType);
    return retVal;
  }

  public int AddStructToStruct(CResStruct pNewStruct, CResStruct pParentStruct, byte* szFieldID, uint nType) {
    int retVal = NWNXLibPINVOKE.CResGFF_AddStructToStruct(swigCPtr, CResStruct.getCPtr(pNewStruct), CResStruct.getCPtr(pParentStruct), szFieldID, nType);
    return retVal;
  }

  public int CreateGFFFile(CResStruct pStruct, CExoString sFileType, CExoString sVersion) {
    int retVal = NWNXLibPINVOKE.CResGFF_CreateGFFFile(swigCPtr, CResStruct.getCPtr(pStruct), CExoString.getCPtr(sFileType), CExoString.getCPtr(sVersion));
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
    return retVal;
  }

  public int WriteFieldBYTE(CResStruct pStructure, byte nVariable, byte* szFieldID) {
    int retVal = NWNXLibPINVOKE.CResGFF_WriteFieldBYTE(swigCPtr, CResStruct.getCPtr(pStructure), nVariable, szFieldID);
    return retVal;
  }

  public int WriteFieldCHAR(CResStruct pStructure, byte nVariable, byte* szFieldID) {
    int retVal = NWNXLibPINVOKE.CResGFF_WriteFieldCHAR(swigCPtr, CResStruct.getCPtr(pStructure), nVariable, szFieldID);
    return retVal;
  }

  public int WriteFieldWORD(CResStruct pStructure, ushort nVariable, byte* szFieldID) {
    int retVal = NWNXLibPINVOKE.CResGFF_WriteFieldWORD(swigCPtr, CResStruct.getCPtr(pStructure), nVariable, szFieldID);
    return retVal;
  }

  public int WriteFieldSHORT(CResStruct pStructure, short nVariable, byte* szFieldID) {
    int retVal = NWNXLibPINVOKE.CResGFF_WriteFieldSHORT(swigCPtr, CResStruct.getCPtr(pStructure), nVariable, szFieldID);
    return retVal;
  }

  public int WriteFieldDWORD(CResStruct pStructure, uint nVariable, byte* szFieldID) {
    int retVal = NWNXLibPINVOKE.CResGFF_WriteFieldDWORD(swigCPtr, CResStruct.getCPtr(pStructure), nVariable, szFieldID);
    return retVal;
  }

  public int WriteFieldINT(CResStruct pStructure, int nVariable, byte* szFieldID) {
    int retVal = NWNXLibPINVOKE.CResGFF_WriteFieldINT(swigCPtr, CResStruct.getCPtr(pStructure), nVariable, szFieldID);
    return retVal;
  }

  public int WriteFieldDWORD64(CResStruct pStructure, ulong nVariable, byte* szFieldID) {
    int retVal = NWNXLibPINVOKE.CResGFF_WriteFieldDWORD64(swigCPtr, CResStruct.getCPtr(pStructure), nVariable, szFieldID);
    return retVal;
  }

  public int WriteFieldINT64(CResStruct pStructure, long nVariable, byte* szFieldID) {
    int retVal = NWNXLibPINVOKE.CResGFF_WriteFieldINT64(swigCPtr, CResStruct.getCPtr(pStructure), nVariable, szFieldID);
    return retVal;
  }

  public int WriteFieldFLOAT(CResStruct pStructure, float fVariable, byte* szFieldID) {
    int retVal = NWNXLibPINVOKE.CResGFF_WriteFieldFLOAT(swigCPtr, CResStruct.getCPtr(pStructure), fVariable, szFieldID);
    return retVal;
  }

  public int WriteFieldDOUBLE(CResStruct pStructure, double fVariable, byte* szFieldID) {
    int retVal = NWNXLibPINVOKE.CResGFF_WriteFieldDOUBLE(swigCPtr, CResStruct.getCPtr(pStructure), fVariable, szFieldID);
    return retVal;
  }

  public int WriteFieldCResRef(CResStruct pStructure, CResRef sVariable, byte* szFieldID) {
    int retVal = NWNXLibPINVOKE.CResGFF_WriteFieldCResRef(swigCPtr, CResStruct.getCPtr(pStructure), CResRef.getCPtr(sVariable), szFieldID);
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
    return retVal;
  }

  public int WriteFieldCExoString(CResStruct pStructure, CExoString sVariable, byte* szFieldID) {
    int retVal = NWNXLibPINVOKE.CResGFF_WriteFieldCExoString(swigCPtr, CResStruct.getCPtr(pStructure), CExoString.getCPtr(sVariable), szFieldID);
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
    return retVal;
  }

  public int WriteFieldCExoLocString(CResStruct pStructure, CExoLocString sVariable, byte* szFieldID) {
    int retVal = NWNXLibPINVOKE.CResGFF_WriteFieldCExoLocString(swigCPtr, CResStruct.getCPtr(pStructure), CExoLocString.getCPtr(sVariable), szFieldID);
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
    return retVal;
  }

  public int WriteFieldVOID(CResStruct pStructure, void* pVariable, uint nSize, byte* szFieldID) {
    int retVal = NWNXLibPINVOKE.CResGFF_WriteFieldVOID(swigCPtr, CResStruct.getCPtr(pStructure), (global::System.IntPtr)pVariable, nSize, szFieldID);
    return retVal;
  }

  public int WriteGFFFile(CExoString sFileName, ushort nType) {
    int retVal = NWNXLibPINVOKE.CResGFF_WriteGFFFile__SWIG_0(swigCPtr, CExoString.getCPtr(sFileName), nType);
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
    return retVal;
  }

  public int WriteGFFFile(byte* szFileName) {
    int retVal = NWNXLibPINVOKE.CResGFF_WriteGFFFile__SWIG_1(swigCPtr, szFileName);
    return retVal;
  }

  public int WriteGFFData(CExoFile cFile, uint* nBytesWritten) {
    int retVal = NWNXLibPINVOKE.CResGFF_WriteGFFData(swigCPtr, CExoFile.getCPtr(cFile), (global::System.IntPtr)nBytesWritten);
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
    return retVal;
  }

  public int WriteGFFToPointer(void** pData, int* nLength) {
    int retVal = NWNXLibPINVOKE.CResGFF_WriteGFFToPointer(swigCPtr, (global::System.IntPtr)pData, (global::System.IntPtr)nLength);
    return retVal;
  }

  public void Pack(byte nPercentThreshold, uint nByteThreshold) {
    NWNXLibPINVOKE.CResGFF_Pack__SWIG_0(swigCPtr, nPercentThreshold, nByteThreshold);
  }

  public void Pack(byte nPercentThreshold) {
    NWNXLibPINVOKE.CResGFF_Pack__SWIG_1(swigCPtr, nPercentThreshold);
  }

  public void Pack() {
    NWNXLibPINVOKE.CResGFF_Pack__SWIG_2(swigCPtr);
  }

  public uint GetTotalSize() {
    uint retVal = NWNXLibPINVOKE.CResGFF_GetTotalSize(swigCPtr);
    return retVal;
  }

  public void InitializeForWriting() {
    NWNXLibPINVOKE.CResGFF_InitializeForWriting(swigCPtr);
  }

  public int PrepareHeader() {
    int retVal = NWNXLibPINVOKE.CResGFF_PrepareHeader(swigCPtr);
    return retVal;
  }

  public int FinalizeSetup() {
    int retVal = NWNXLibPINVOKE.CResGFF_FinalizeSetup(swigCPtr);
    return retVal;
  }

  public int ValidateAndSetup() {
    int retVal = NWNXLibPINVOKE.CResGFF_ValidateAndSetup(swigCPtr);
    return retVal;
  }

  public void ReleaseResource() {
    NWNXLibPINVOKE.CResGFF_ReleaseResource(swigCPtr);
  }

  public CResGFFStruct GetStruct(CResStruct pStructure) {
    global::System.IntPtr cPtr = NWNXLibPINVOKE.CResGFF_GetStruct(swigCPtr, CResStruct.getCPtr(pStructure));
    CResGFFStruct ret = (cPtr == global::System.IntPtr.Zero) ? null : new CResGFFStruct(cPtr, false);
    return ret;
  }

  public CResGFFField GetField(CResStruct pStructure, uint nFieldIndex) {
    global::System.IntPtr cPtr = NWNXLibPINVOKE.CResGFF_GetField(swigCPtr, CResStruct.getCPtr(pStructure), nFieldIndex);
    CResGFFField ret = (cPtr == global::System.IntPtr.Zero) ? null : new CResGFFField(cPtr, false);
    return ret;
  }

  public CResGFFLabel GetLabel(CResStruct pStructure, uint nFieldIndex) {
    global::System.IntPtr cPtr = NWNXLibPINVOKE.CResGFF_GetLabel(swigCPtr, CResStruct.getCPtr(pStructure), nFieldIndex);
    CResGFFLabel ret = (cPtr == global::System.IntPtr.Zero) ? null : new CResGFFLabel(cPtr, false);
    return ret;
  }

  public byte* GetDataField(CResGFFField pField, uint* nMaxSize) {
    byte* retVal = NWNXLibPINVOKE.CResGFF_GetDataField(swigCPtr, CResGFFField.getCPtr(pField), (global::System.IntPtr)nMaxSize);
    return retVal;
  }

  public byte* GetDataLayoutField(CResGFFField pField, uint* nMaxSize) {
    byte* retVal = NWNXLibPINVOKE.CResGFF_GetDataLayoutField(swigCPtr, CResGFFField.getCPtr(pField), (global::System.IntPtr)nMaxSize);
    return retVal;
  }

  public byte* GetDataLayoutList(CResGFFField pField, uint* nMaxSize) {
    byte* retVal = NWNXLibPINVOKE.CResGFF_GetDataLayoutList(swigCPtr, CResGFFField.getCPtr(pField), (global::System.IntPtr)nMaxSize);
    return retVal;
  }

  public uint GetFieldByLabel(CResStruct pStructure, byte* szFieldID) {
    uint retVal = NWNXLibPINVOKE.CResGFF_GetFieldByLabel(swigCPtr, CResStruct.getCPtr(pStructure), szFieldID);
    return retVal;
  }

  public int IsDataInPlace(uint nType) {
    int retVal = NWNXLibPINVOKE.CResGFF_IsDataInPlace(swigCPtr, nType);
    return retVal;
  }

  public byte* GetFieldLabel(CResStruct pStructure, uint nFieldIndex) {
    byte* retVal = NWNXLibPINVOKE.CResGFF_GetFieldLabel(swigCPtr, CResStruct.getCPtr(pStructure), nFieldIndex);
    return retVal;
  }

  public uint GetFieldCount(CResGFFStruct pStruct) {
    uint retVal = NWNXLibPINVOKE.CResGFF_GetFieldCount__SWIG_1(swigCPtr, CResGFFStruct.getCPtr(pStruct));
    return retVal;
  }

  public uint AddStruct(uint nType) {
    uint retVal = NWNXLibPINVOKE.CResGFF_AddStruct(swigCPtr, nType);
    return retVal;
  }

  public CResGFFField AddField(CResStruct pStructure, byte* szFieldID, uint nType) {
    global::System.IntPtr cPtr = NWNXLibPINVOKE.CResGFF_AddField(swigCPtr, CResStruct.getCPtr(pStructure), szFieldID, nType);
    CResGFFField ret = (cPtr == global::System.IntPtr.Zero) ? null : new CResGFFField(cPtr, false);
    return ret;
  }

  public uint AddLabel(byte* szFieldID) {
    uint retVal = NWNXLibPINVOKE.CResGFF_AddLabel(swigCPtr, szFieldID);
    return retVal;
  }

  public byte* AddDataField(uint nCurrentOffset, uint nCurrentSize, uint nNewSize) {
    byte* retVal = NWNXLibPINVOKE.CResGFF_AddDataField(swigCPtr, nCurrentOffset, nCurrentSize, nNewSize);
    return retVal;
  }

  public byte* AddDataLayoutField(uint nCurrentOffset, uint nCurrentSize, uint nNewSize) {
    byte* retVal = NWNXLibPINVOKE.CResGFF_AddDataLayoutField(swigCPtr, nCurrentOffset, nCurrentSize, nNewSize);
    return retVal;
  }

  public byte* AddDataLayoutList(uint nCurrentOffset, uint nCurrentSize, uint nNewSize) {
    byte* retVal = NWNXLibPINVOKE.CResGFF_AddDataLayoutList(swigCPtr, nCurrentOffset, nCurrentSize, nNewSize);
    return retVal;
  }

  public new void _Destructor() {
    NWNXLibPINVOKE.CResGFF__Destructor(swigCPtr);
  }

}

}

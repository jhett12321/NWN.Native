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
/*@SWIG:/__w/NWN.Native/NWN.Native/nwnx/Plugins/SWIG/SWIG_DotNET/API_NWNXLib.i,20,SWIG_DOTNET_EXTENSIONS@*/
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
      uint ret = NWNXLibPINVOKE.CResGFF_STRUCT_GROWSIZE_get(swigCPtr);
      return ret;
    } 
  }

  public uint FIELD_GROWSIZE {
    set {
      NWNXLibPINVOKE.CResGFF_FIELD_GROWSIZE_set(swigCPtr, value);
    } 
    get {
      uint ret = NWNXLibPINVOKE.CResGFF_FIELD_GROWSIZE_get(swigCPtr);
      return ret;
    } 
  }

  public uint LABEL_GROWSIZE {
    set {
      NWNXLibPINVOKE.CResGFF_LABEL_GROWSIZE_set(swigCPtr, value);
    } 
    get {
      uint ret = NWNXLibPINVOKE.CResGFF_LABEL_GROWSIZE_get(swigCPtr);
      return ret;
    } 
  }

  public uint DATAFIELD_GROWSIZE {
    set {
      NWNXLibPINVOKE.CResGFF_DATAFIELD_GROWSIZE_set(swigCPtr, value);
    } 
    get {
      uint ret = NWNXLibPINVOKE.CResGFF_DATAFIELD_GROWSIZE_get(swigCPtr);
      return ret;
    } 
  }

  public uint DATALAYOUTFIELD_GROWSIZE {
    set {
      NWNXLibPINVOKE.CResGFF_DATALAYOUTFIELD_GROWSIZE_set(swigCPtr, value);
    } 
    get {
      uint ret = NWNXLibPINVOKE.CResGFF_DATALAYOUTFIELD_GROWSIZE_get(swigCPtr);
      return ret;
    } 
  }

  public uint DATALAYOUTLIST_GROWSIZE {
    set {
      NWNXLibPINVOKE.CResGFF_DATALAYOUTLIST_GROWSIZE_set(swigCPtr, value);
    } 
    get {
      uint ret = NWNXLibPINVOKE.CResGFF_DATALAYOUTLIST_GROWSIZE_get(swigCPtr);
      return ret;
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
      NWNXLibPINVOKE.CResGFF_m_pDDFileHeader_set(swigCPtr, (global::System.IntPtr)value);
    } 
    get {
        global::System.IntPtr retVal = NWNXLibPINVOKE.CResGFF_m_pDDFileHeader_get(swigCPtr);
        return (byte*)retVal;
    }

  }

  public uint m_nHeaderOffset {
    set {
      NWNXLibPINVOKE.CResGFF_m_nHeaderOffset_set(swigCPtr, value);
    } 
    get {
      uint ret = NWNXLibPINVOKE.CResGFF_m_nHeaderOffset_get(swigCPtr);
      return ret;
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
      uint ret = NWNXLibPINVOKE.CResGFF_m_nStructAllocated_get(swigCPtr);
      return ret;
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
      uint ret = NWNXLibPINVOKE.CResGFF_m_nFieldAllocated_get(swigCPtr);
      return ret;
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
      uint ret = NWNXLibPINVOKE.CResGFF_m_nLabelAllocated_get(swigCPtr);
      return ret;
    } 
  }

  public byte* m_pDataField {
    set {
      NWNXLibPINVOKE.CResGFF_m_pDataField_set(swigCPtr, (global::System.IntPtr)value);
    } 
    get {
        global::System.IntPtr retVal = NWNXLibPINVOKE.CResGFF_m_pDataField_get(swigCPtr);
        return (byte*)retVal;
    }

  }

  public uint m_nDataFieldAllocated {
    set {
      NWNXLibPINVOKE.CResGFF_m_nDataFieldAllocated_set(swigCPtr, value);
    } 
    get {
      uint ret = NWNXLibPINVOKE.CResGFF_m_nDataFieldAllocated_get(swigCPtr);
      return ret;
    } 
  }

  public byte* m_pDataLayoutField {
    set {
      NWNXLibPINVOKE.CResGFF_m_pDataLayoutField_set(swigCPtr, (global::System.IntPtr)value);
    } 
    get {
        global::System.IntPtr retVal = NWNXLibPINVOKE.CResGFF_m_pDataLayoutField_get(swigCPtr);
        return (byte*)retVal;
    }

  }

  public uint m_nDataLayoutFieldAllocated {
    set {
      NWNXLibPINVOKE.CResGFF_m_nDataLayoutFieldAllocated_set(swigCPtr, value);
    } 
    get {
      uint ret = NWNXLibPINVOKE.CResGFF_m_nDataLayoutFieldAllocated_get(swigCPtr);
      return ret;
    } 
  }

  public uint m_nDataLayoutFieldWasted {
    set {
      NWNXLibPINVOKE.CResGFF_m_nDataLayoutFieldWasted_set(swigCPtr, value);
    } 
    get {
      uint ret = NWNXLibPINVOKE.CResGFF_m_nDataLayoutFieldWasted_get(swigCPtr);
      return ret;
    } 
  }

  public byte* m_pDataLayoutList {
    set {
      NWNXLibPINVOKE.CResGFF_m_pDataLayoutList_set(swigCPtr, (global::System.IntPtr)value);
    } 
    get {
        global::System.IntPtr retVal = NWNXLibPINVOKE.CResGFF_m_pDataLayoutList_get(swigCPtr);
        return (byte*)retVal;
    }

  }

  public uint m_nDataLayoutListAllocated {
    set {
      NWNXLibPINVOKE.CResGFF_m_nDataLayoutListAllocated_set(swigCPtr, value);
    } 
    get {
      uint ret = NWNXLibPINVOKE.CResGFF_m_nDataLayoutListAllocated_get(swigCPtr);
      return ret;
    } 
  }

  public uint m_nDataLayoutListWasted {
    set {
      NWNXLibPINVOKE.CResGFF_m_nDataLayoutListWasted_set(swigCPtr, value);
    } 
    get {
      uint ret = NWNXLibPINVOKE.CResGFF_m_nDataLayoutListWasted_get(swigCPtr);
      return ret;
    } 
  }

  public string m_pLabelBuffer {
    set {
      NWNXLibPINVOKE.CResGFF_m_pLabelBuffer_set(swigCPtr, value);
    } 
    get {
      string ret = NWNXLibPINVOKE.CResGFF_m_pLabelBuffer_get(swigCPtr);
      return ret;
    } 
  }

  public string m_pFileType {
    set {
      NWNXLibPINVOKE.CResGFF_m_pFileType_set(swigCPtr, value);
    } 
    get {
      string ret = NWNXLibPINVOKE.CResGFF_m_pFileType_get(swigCPtr);
      return ret;
    } 
  }

  public int m_bLoaded {
    set {
      NWNXLibPINVOKE.CResGFF_m_bLoaded_set(swigCPtr, value);
    } 
    get {
      int ret = NWNXLibPINVOKE.CResGFF_m_bLoaded_get(swigCPtr);
      return ret;
    } 
  }

  public int m_bResourceLoaded {
    set {
      NWNXLibPINVOKE.CResGFF_m_bResourceLoaded_set(swigCPtr, value);
    } 
    get {
      int ret = NWNXLibPINVOKE.CResGFF_m_bResourceLoaded_get(swigCPtr);
      return ret;
    } 
  }

  public int m_bSelfDemanded {
    set {
      NWNXLibPINVOKE.CResGFF_m_bSelfDemanded_set(swigCPtr, value);
    } 
    get {
      int ret = NWNXLibPINVOKE.CResGFF_m_bSelfDemanded_get(swigCPtr);
      return ret;
    } 
  }

  public int m_bDataPtrOwned {
    set {
      NWNXLibPINVOKE.CResGFF_m_bDataPtrOwned_set(swigCPtr, value);
    } 
    get {
      int ret = NWNXLibPINVOKE.CResGFF_m_bDataPtrOwned_get(swigCPtr);
      return ret;
    } 
  }

  public int m_bReplaceExistingFields {
    set {
      NWNXLibPINVOKE.CResGFF_m_bReplaceExistingFields_set(swigCPtr, value);
    } 
    get {
      int ret = NWNXLibPINVOKE.CResGFF_m_bReplaceExistingFields_get(swigCPtr);
      return ret;
    } 
  }

  public int m_bValidationFailed {
    set {
      NWNXLibPINVOKE.CResGFF_m_bValidationFailed_set(swigCPtr, value);
    } 
    get {
      int ret = NWNXLibPINVOKE.CResGFF_m_bValidationFailed_get(swigCPtr);
      return ret;
    } 
  }

  public CResGFF() : this(NWNXLibPINVOKE.new_CResGFF__SWIG_0(), true) {
  }

  public CResGFF(ushort nType, string cIDStr, CResRef cResRef) : this(NWNXLibPINVOKE.new_CResGFF__SWIG_1(nType, cIDStr, CResRef.getCPtr(cResRef)), true) {
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
  }

  public override int OnResourceServiced() {
    int ret = NWNXLibPINVOKE.CResGFF_OnResourceServiced(swigCPtr);
    return ret;
  }

  public override int OnResourceFreed() {
    int ret = NWNXLibPINVOKE.CResGFF_OnResourceFreed(swigCPtr);
    return ret;
  }

  public int GetDataFromFile(string pFileName) {
    int ret = NWNXLibPINVOKE.CResGFF_GetDataFromFile(swigCPtr, pFileName);
    return ret;
  }

  public int GetDataFromPointer(void* pData, int nDataSize) {
    int ret = NWNXLibPINVOKE.CResGFF_GetDataFromPointer(swigCPtr, (global::System.IntPtr)pData, nDataSize);
    return ret;
  }

  public void GetGFFFileInfo(CExoString pFileType, CExoString pVersion) {
    NWNXLibPINVOKE.CResGFF_GetGFFFileInfo(swigCPtr, CExoString.getCPtr(pFileType), CExoString.getCPtr(pVersion));
  }

  public uint GetElementType(CResStruct pStructure) {
    uint ret = NWNXLibPINVOKE.CResGFF_GetElementType(swigCPtr, CResStruct.getCPtr(pStructure));
    return ret;
  }

  public uint GetFieldCount(CResStruct pStructure) {
    uint ret = NWNXLibPINVOKE.CResGFF_GetFieldCount__SWIG_0(swigCPtr, CResStruct.getCPtr(pStructure));
    return ret;
  }

  public uint GetFieldType(CResStruct pStructure, string szFieldID, uint nFieldIndex) {
    uint ret = NWNXLibPINVOKE.CResGFF_GetFieldType__SWIG_0(swigCPtr, CResStruct.getCPtr(pStructure), szFieldID, nFieldIndex);
    return ret;
  }

  public uint GetFieldType(CResStruct pStructure, string szFieldID) {
    uint ret = NWNXLibPINVOKE.CResGFF_GetFieldType__SWIG_1(swigCPtr, CResStruct.getCPtr(pStructure), szFieldID);
    return ret;
  }

  public string GetFieldStringID(CResStruct pStructure, uint nFieldIndex) {
    string ret = NWNXLibPINVOKE.CResGFF_GetFieldStringID(swigCPtr, CResStruct.getCPtr(pStructure), nFieldIndex);
    return ret;
  }

  public uint GetFieldSize(CResStruct pStructure, string szFieldID, uint nFieldIndex) {
    uint ret = NWNXLibPINVOKE.CResGFF_GetFieldSize__SWIG_0(swigCPtr, CResStruct.getCPtr(pStructure), szFieldID, nFieldIndex);
    return ret;
  }

  public uint GetFieldSize(CResStruct pStructure, string szFieldID) {
    uint ret = NWNXLibPINVOKE.CResGFF_GetFieldSize__SWIG_1(swigCPtr, CResStruct.getCPtr(pStructure), szFieldID);
    return ret;
  }

  public int GetList(CResList pList, CResStruct pStructure, string szFieldID) {
    int ret = NWNXLibPINVOKE.CResGFF_GetList(swigCPtr, CResList.getCPtr(pList), CResStruct.getCPtr(pStructure), szFieldID);
    return ret;
  }

  public uint GetListCount(CResList pList) {
    uint ret = NWNXLibPINVOKE.CResGFF_GetListCount(swigCPtr, CResList.getCPtr(pList));
    return ret;
  }

  public int GetListElement(CResStruct pStruct, CResList pList, uint nIndex) {
    int ret = NWNXLibPINVOKE.CResGFF_GetListElement(swigCPtr, CResStruct.getCPtr(pStruct), CResList.getCPtr(pList), nIndex);
    return ret;
  }

  public int GetStructFromStruct(CResStruct pStruct, CResStruct pParentStruct, string szFieldID) {
    int ret = NWNXLibPINVOKE.CResGFF_GetStructFromStruct(swigCPtr, CResStruct.getCPtr(pStruct), CResStruct.getCPtr(pParentStruct), szFieldID);
    return ret;
  }

  public int GetTopLevelStruct(CResStruct pStructure) {
    int ret = NWNXLibPINVOKE.CResGFF_GetTopLevelStruct(swigCPtr, CResStruct.getCPtr(pStructure));
    return ret;
  }

  public byte ReadFieldBYTE(CResStruct pStructure, string szFieldID, int* bSuccess, byte nDefault) {
    byte ret = NWNXLibPINVOKE.CResGFF_ReadFieldBYTE__SWIG_0(swigCPtr, CResStruct.getCPtr(pStructure), szFieldID, (global::System.IntPtr)bSuccess, nDefault);
    return ret;
  }

  public byte ReadFieldBYTE(CResStruct pStructure, string szFieldID, int* bSuccess) {
    byte ret = NWNXLibPINVOKE.CResGFF_ReadFieldBYTE__SWIG_1(swigCPtr, CResStruct.getCPtr(pStructure), szFieldID, (global::System.IntPtr)bSuccess);
    return ret;
  }

  public char ReadFieldCHAR(CResStruct pStructure, string szFieldID, int* bSuccess, char nDefault) {
    char ret = NWNXLibPINVOKE.CResGFF_ReadFieldCHAR__SWIG_0(swigCPtr, CResStruct.getCPtr(pStructure), szFieldID, (global::System.IntPtr)bSuccess, nDefault);
    return ret;
  }

  public char ReadFieldCHAR(CResStruct pStructure, string szFieldID, int* bSuccess) {
    char ret = NWNXLibPINVOKE.CResGFF_ReadFieldCHAR__SWIG_1(swigCPtr, CResStruct.getCPtr(pStructure), szFieldID, (global::System.IntPtr)bSuccess);
    return ret;
  }

  public ushort ReadFieldWORD(CResStruct pStructure, string szFieldID, int* bSuccess, ushort nDefault) {
    ushort ret = NWNXLibPINVOKE.CResGFF_ReadFieldWORD__SWIG_0(swigCPtr, CResStruct.getCPtr(pStructure), szFieldID, (global::System.IntPtr)bSuccess, nDefault);
    return ret;
  }

  public ushort ReadFieldWORD(CResStruct pStructure, string szFieldID, int* bSuccess) {
    ushort ret = NWNXLibPINVOKE.CResGFF_ReadFieldWORD__SWIG_1(swigCPtr, CResStruct.getCPtr(pStructure), szFieldID, (global::System.IntPtr)bSuccess);
    return ret;
  }

  public short ReadFieldSHORT(CResStruct pStructure, string szFieldID, int* bSuccess, short nDefault) {
    short ret = NWNXLibPINVOKE.CResGFF_ReadFieldSHORT__SWIG_0(swigCPtr, CResStruct.getCPtr(pStructure), szFieldID, (global::System.IntPtr)bSuccess, nDefault);
    return ret;
  }

  public short ReadFieldSHORT(CResStruct pStructure, string szFieldID, int* bSuccess) {
    short ret = NWNXLibPINVOKE.CResGFF_ReadFieldSHORT__SWIG_1(swigCPtr, CResStruct.getCPtr(pStructure), szFieldID, (global::System.IntPtr)bSuccess);
    return ret;
  }

  public uint ReadFieldDWORD(CResStruct pStructure, string szFieldID, int* bSuccess, uint nDefault) {
    uint ret = NWNXLibPINVOKE.CResGFF_ReadFieldDWORD__SWIG_0(swigCPtr, CResStruct.getCPtr(pStructure), szFieldID, (global::System.IntPtr)bSuccess, nDefault);
    return ret;
  }

  public uint ReadFieldDWORD(CResStruct pStructure, string szFieldID, int* bSuccess) {
    uint ret = NWNXLibPINVOKE.CResGFF_ReadFieldDWORD__SWIG_1(swigCPtr, CResStruct.getCPtr(pStructure), szFieldID, (global::System.IntPtr)bSuccess);
    return ret;
  }

  public int ReadFieldINT(CResStruct pStructure, string szFieldID, int* bSuccess, int nDefault) {
    int ret = NWNXLibPINVOKE.CResGFF_ReadFieldINT__SWIG_0(swigCPtr, CResStruct.getCPtr(pStructure), szFieldID, (global::System.IntPtr)bSuccess, nDefault);
    return ret;
  }

  public int ReadFieldINT(CResStruct pStructure, string szFieldID, int* bSuccess) {
    int ret = NWNXLibPINVOKE.CResGFF_ReadFieldINT__SWIG_1(swigCPtr, CResStruct.getCPtr(pStructure), szFieldID, (global::System.IntPtr)bSuccess);
    return ret;
  }

  public uint ReadFieldDWORD64(CResStruct pStructure, string szFieldID, int* bSuccess, uint nDefault) {
    uint ret = NWNXLibPINVOKE.CResGFF_ReadFieldDWORD64__SWIG_0(swigCPtr, CResStruct.getCPtr(pStructure), szFieldID, (global::System.IntPtr)bSuccess, nDefault);
    return ret;
  }

  public uint ReadFieldDWORD64(CResStruct pStructure, string szFieldID, int* bSuccess) {
    uint ret = NWNXLibPINVOKE.CResGFF_ReadFieldDWORD64__SWIG_1(swigCPtr, CResStruct.getCPtr(pStructure), szFieldID, (global::System.IntPtr)bSuccess);
    return ret;
  }

  public int ReadFieldINT64(CResStruct pStructure, string szFieldID, int* bSuccess, int nDefault) {
    int ret = NWNXLibPINVOKE.CResGFF_ReadFieldINT64__SWIG_0(swigCPtr, CResStruct.getCPtr(pStructure), szFieldID, (global::System.IntPtr)bSuccess, nDefault);
    return ret;
  }

  public int ReadFieldINT64(CResStruct pStructure, string szFieldID, int* bSuccess) {
    int ret = NWNXLibPINVOKE.CResGFF_ReadFieldINT64__SWIG_1(swigCPtr, CResStruct.getCPtr(pStructure), szFieldID, (global::System.IntPtr)bSuccess);
    return ret;
  }

  public float ReadFieldFLOAT(CResStruct pStructure, string szFieldID, int* bSuccess, float fDefault) {
    float ret = NWNXLibPINVOKE.CResGFF_ReadFieldFLOAT__SWIG_0(swigCPtr, CResStruct.getCPtr(pStructure), szFieldID, (global::System.IntPtr)bSuccess, fDefault);
    return ret;
  }

  public float ReadFieldFLOAT(CResStruct pStructure, string szFieldID, int* bSuccess) {
    float ret = NWNXLibPINVOKE.CResGFF_ReadFieldFLOAT__SWIG_1(swigCPtr, CResStruct.getCPtr(pStructure), szFieldID, (global::System.IntPtr)bSuccess);
    return ret;
  }

  public double ReadFieldDOUBLE(CResStruct pStructure, string szFieldID, int* bSuccess, double fDefault) {
    double ret = NWNXLibPINVOKE.CResGFF_ReadFieldDOUBLE__SWIG_0(swigCPtr, CResStruct.getCPtr(pStructure), szFieldID, (global::System.IntPtr)bSuccess, fDefault);
    return ret;
  }

  public double ReadFieldDOUBLE(CResStruct pStructure, string szFieldID, int* bSuccess) {
    double ret = NWNXLibPINVOKE.CResGFF_ReadFieldDOUBLE__SWIG_1(swigCPtr, CResStruct.getCPtr(pStructure), szFieldID, (global::System.IntPtr)bSuccess);
    return ret;
  }

  public CResRef ReadFieldCResRef(CResStruct pStructure, string szFieldID, int* bSuccess, CResRef sDefault) {
    CResRef ret = new CResRef(NWNXLibPINVOKE.CResGFF_ReadFieldCResRef__SWIG_0(swigCPtr, CResStruct.getCPtr(pStructure), szFieldID, (global::System.IntPtr)bSuccess, CResRef.getCPtr(sDefault)), true);
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public CResRef ReadFieldCResRef(CResStruct pStructure, string szFieldID, int* bSuccess) {
    CResRef ret = new CResRef(NWNXLibPINVOKE.CResGFF_ReadFieldCResRef__SWIG_1(swigCPtr, CResStruct.getCPtr(pStructure), szFieldID, (global::System.IntPtr)bSuccess), true);
    return ret;
  }

  public CExoString ReadFieldCExoString(CResStruct pStructure, string szFieldID, int* bSuccess, CExoString sDefault) {
    CExoString ret = new CExoString(NWNXLibPINVOKE.CResGFF_ReadFieldCExoString__SWIG_0(swigCPtr, CResStruct.getCPtr(pStructure), szFieldID, (global::System.IntPtr)bSuccess, CExoString.getCPtr(sDefault)), true);
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public CExoString ReadFieldCExoString(CResStruct pStructure, string szFieldID, int* bSuccess) {
    CExoString ret = new CExoString(NWNXLibPINVOKE.CResGFF_ReadFieldCExoString__SWIG_1(swigCPtr, CResStruct.getCPtr(pStructure), szFieldID, (global::System.IntPtr)bSuccess), true);
    return ret;
  }

  public CExoLocString ReadFieldCExoLocString(CResStruct pStructure, string szFieldID, int* bSuccess, CExoLocString sDefault) {
    CExoLocString ret = new CExoLocString(NWNXLibPINVOKE.CResGFF_ReadFieldCExoLocString__SWIG_0(swigCPtr, CResStruct.getCPtr(pStructure), szFieldID, (global::System.IntPtr)bSuccess, CExoLocString.getCPtr(sDefault)), true);
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public CExoLocString ReadFieldCExoLocString(CResStruct pStructure, string szFieldID, int* bSuccess) {
    CExoLocString ret = new CExoLocString(NWNXLibPINVOKE.CResGFF_ReadFieldCExoLocString__SWIG_1(swigCPtr, CResStruct.getCPtr(pStructure), szFieldID, (global::System.IntPtr)bSuccess), true);
    return ret;
  }

  public void* ReadFieldVOID(CResStruct pStructure, void* pVariable, uint nSize, string szFieldID, int* bSuccess, void* pDefault) {
    global::System.IntPtr retVal = NWNXLibPINVOKE.CResGFF_ReadFieldVOID__SWIG_0(swigCPtr, CResStruct.getCPtr(pStructure), (global::System.IntPtr)pVariable, nSize, szFieldID, (global::System.IntPtr)bSuccess, (global::System.IntPtr)pDefault);
    return (void*)retVal;
  }

  public void* ReadFieldVOID(CResStruct pStructure, void* pVariable, uint nSize, string szFieldID, int* bSuccess) {
    global::System.IntPtr retVal = NWNXLibPINVOKE.CResGFF_ReadFieldVOID__SWIG_1(swigCPtr, CResStruct.getCPtr(pStructure), (global::System.IntPtr)pVariable, nSize, szFieldID, (global::System.IntPtr)bSuccess);
    return (void*)retVal;
  }

  public int AddList(CResList pList, CResStruct pStructure, string szFieldID) {
    int ret = NWNXLibPINVOKE.CResGFF_AddList(swigCPtr, CResList.getCPtr(pList), CResStruct.getCPtr(pStructure), szFieldID);
    return ret;
  }

  public int AddListElement(CResStruct pStruct, CResList pList, uint nType) {
    int ret = NWNXLibPINVOKE.CResGFF_AddListElement(swigCPtr, CResStruct.getCPtr(pStruct), CResList.getCPtr(pList), nType);
    return ret;
  }

  public int AddStructToStruct(CResStruct pNewStruct, CResStruct pParentStruct, string szFieldID, uint nType) {
    int ret = NWNXLibPINVOKE.CResGFF_AddStructToStruct(swigCPtr, CResStruct.getCPtr(pNewStruct), CResStruct.getCPtr(pParentStruct), szFieldID, nType);
    return ret;
  }

  public int CreateGFFFile(CResStruct pStruct, CExoString sFileType, CExoString sVersion) {
    int ret = NWNXLibPINVOKE.CResGFF_CreateGFFFile(swigCPtr, CResStruct.getCPtr(pStruct), CExoString.getCPtr(sFileType), CExoString.getCPtr(sVersion));
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public int WriteFieldBYTE(CResStruct pStructure, byte nVariable, string szFieldID) {
    int ret = NWNXLibPINVOKE.CResGFF_WriteFieldBYTE(swigCPtr, CResStruct.getCPtr(pStructure), nVariable, szFieldID);
    return ret;
  }

  public int WriteFieldCHAR(CResStruct pStructure, char nVariable, string szFieldID) {
    int ret = NWNXLibPINVOKE.CResGFF_WriteFieldCHAR(swigCPtr, CResStruct.getCPtr(pStructure), nVariable, szFieldID);
    return ret;
  }

  public int WriteFieldWORD(CResStruct pStructure, ushort nVariable, string szFieldID) {
    int ret = NWNXLibPINVOKE.CResGFF_WriteFieldWORD(swigCPtr, CResStruct.getCPtr(pStructure), nVariable, szFieldID);
    return ret;
  }

  public int WriteFieldSHORT(CResStruct pStructure, short nVariable, string szFieldID) {
    int ret = NWNXLibPINVOKE.CResGFF_WriteFieldSHORT(swigCPtr, CResStruct.getCPtr(pStructure), nVariable, szFieldID);
    return ret;
  }

  public int WriteFieldDWORD(CResStruct pStructure, uint nVariable, string szFieldID) {
    int ret = NWNXLibPINVOKE.CResGFF_WriteFieldDWORD(swigCPtr, CResStruct.getCPtr(pStructure), nVariable, szFieldID);
    return ret;
  }

  public int WriteFieldINT(CResStruct pStructure, int nVariable, string szFieldID) {
    int ret = NWNXLibPINVOKE.CResGFF_WriteFieldINT(swigCPtr, CResStruct.getCPtr(pStructure), nVariable, szFieldID);
    return ret;
  }

  public int WriteFieldDWORD64(CResStruct pStructure, uint nVariable, string szFieldID) {
    int ret = NWNXLibPINVOKE.CResGFF_WriteFieldDWORD64(swigCPtr, CResStruct.getCPtr(pStructure), nVariable, szFieldID);
    return ret;
  }

  public int WriteFieldINT64(CResStruct pStructure, int nVariable, string szFieldID) {
    int ret = NWNXLibPINVOKE.CResGFF_WriteFieldINT64(swigCPtr, CResStruct.getCPtr(pStructure), nVariable, szFieldID);
    return ret;
  }

  public int WriteFieldFLOAT(CResStruct pStructure, float fVariable, string szFieldID) {
    int ret = NWNXLibPINVOKE.CResGFF_WriteFieldFLOAT(swigCPtr, CResStruct.getCPtr(pStructure), fVariable, szFieldID);
    return ret;
  }

  public int WriteFieldDOUBLE(CResStruct pStructure, double fVariable, string szFieldID) {
    int ret = NWNXLibPINVOKE.CResGFF_WriteFieldDOUBLE(swigCPtr, CResStruct.getCPtr(pStructure), fVariable, szFieldID);
    return ret;
  }

  public int WriteFieldCResRef(CResStruct pStructure, CResRef sVariable, string szFieldID) {
    int ret = NWNXLibPINVOKE.CResGFF_WriteFieldCResRef(swigCPtr, CResStruct.getCPtr(pStructure), CResRef.getCPtr(sVariable), szFieldID);
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public int WriteFieldCExoString(CResStruct pStructure, CExoString sVariable, string szFieldID) {
    int ret = NWNXLibPINVOKE.CResGFF_WriteFieldCExoString(swigCPtr, CResStruct.getCPtr(pStructure), CExoString.getCPtr(sVariable), szFieldID);
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public int WriteFieldCExoLocString(CResStruct pStructure, CExoLocString sVariable, string szFieldID) {
    int ret = NWNXLibPINVOKE.CResGFF_WriteFieldCExoLocString(swigCPtr, CResStruct.getCPtr(pStructure), CExoLocString.getCPtr(sVariable), szFieldID);
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public int WriteFieldVOID(CResStruct pStructure, void* pVariable, uint nSize, string szFieldID) {
    int ret = NWNXLibPINVOKE.CResGFF_WriteFieldVOID(swigCPtr, CResStruct.getCPtr(pStructure), (global::System.IntPtr)pVariable, nSize, szFieldID);
    return ret;
  }

  public int WriteGFFFile(CExoString sFileName, ushort nType) {
    int ret = NWNXLibPINVOKE.CResGFF_WriteGFFFile__SWIG_0(swigCPtr, CExoString.getCPtr(sFileName), nType);
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public int WriteGFFFile(string szFileName) {
    int ret = NWNXLibPINVOKE.CResGFF_WriteGFFFile__SWIG_1(swigCPtr, szFileName);
    return ret;
  }

  public int WriteGFFData(CExoFile cFile, uint* nBytesWritten) {
    int ret = NWNXLibPINVOKE.CResGFF_WriteGFFData(swigCPtr, CExoFile.getCPtr(cFile), (global::System.IntPtr)nBytesWritten);
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public int WriteGFFToPointer(void** pData, int* nLength) {
    int ret = NWNXLibPINVOKE.CResGFF_WriteGFFToPointer(swigCPtr, (global::System.IntPtr)pData, (global::System.IntPtr)nLength);
    return ret;
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
    uint ret = NWNXLibPINVOKE.CResGFF_GetTotalSize(swigCPtr);
    return ret;
  }

  public void InitializeForWriting() {
    NWNXLibPINVOKE.CResGFF_InitializeForWriting(swigCPtr);
  }

  public int PrepareHeader() {
    int ret = NWNXLibPINVOKE.CResGFF_PrepareHeader(swigCPtr);
    return ret;
  }

  public int FinalizeSetup() {
    int ret = NWNXLibPINVOKE.CResGFF_FinalizeSetup(swigCPtr);
    return ret;
  }

  public int ValidateAndSetup() {
    int ret = NWNXLibPINVOKE.CResGFF_ValidateAndSetup(swigCPtr);
    return ret;
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
    global::System.IntPtr retVal = NWNXLibPINVOKE.CResGFF_GetDataField(swigCPtr, CResGFFField.getCPtr(pField), (global::System.IntPtr)nMaxSize);
    return (byte*)retVal;
  }

  public byte* GetDataLayoutField(CResGFFField pField, uint* nMaxSize) {
    global::System.IntPtr retVal = NWNXLibPINVOKE.CResGFF_GetDataLayoutField(swigCPtr, CResGFFField.getCPtr(pField), (global::System.IntPtr)nMaxSize);
    return (byte*)retVal;
  }

  public byte* GetDataLayoutList(CResGFFField pField, uint* nMaxSize) {
    global::System.IntPtr retVal = NWNXLibPINVOKE.CResGFF_GetDataLayoutList(swigCPtr, CResGFFField.getCPtr(pField), (global::System.IntPtr)nMaxSize);
    return (byte*)retVal;
  }

  public uint GetFieldByLabel(CResStruct pStructure, string szFieldID) {
    uint ret = NWNXLibPINVOKE.CResGFF_GetFieldByLabel(swigCPtr, CResStruct.getCPtr(pStructure), szFieldID);
    return ret;
  }

  public int IsDataInPlace(uint nType) {
    int ret = NWNXLibPINVOKE.CResGFF_IsDataInPlace(swigCPtr, nType);
    return ret;
  }

  public string GetFieldLabel(CResStruct pStructure, uint nFieldIndex) {
    string ret = NWNXLibPINVOKE.CResGFF_GetFieldLabel(swigCPtr, CResStruct.getCPtr(pStructure), nFieldIndex);
    return ret;
  }

  public uint GetFieldCount(CResGFFStruct pStruct) {
    uint ret = NWNXLibPINVOKE.CResGFF_GetFieldCount__SWIG_1(swigCPtr, CResGFFStruct.getCPtr(pStruct));
    return ret;
  }

  public uint AddStruct(uint nType) {
    uint ret = NWNXLibPINVOKE.CResGFF_AddStruct(swigCPtr, nType);
    return ret;
  }

  public CResGFFField AddField(CResStruct pStructure, string szFieldID, uint nType) {
    global::System.IntPtr cPtr = NWNXLibPINVOKE.CResGFF_AddField(swigCPtr, CResStruct.getCPtr(pStructure), szFieldID, nType);
    CResGFFField ret = (cPtr == global::System.IntPtr.Zero) ? null : new CResGFFField(cPtr, false);
    return ret;
  }

  public uint AddLabel(string szFieldID) {
    uint ret = NWNXLibPINVOKE.CResGFF_AddLabel(swigCPtr, szFieldID);
    return ret;
  }

  public byte* AddDataField(uint nCurrentOffset, uint nCurrentSize, uint nNewSize) {
    global::System.IntPtr retVal = NWNXLibPINVOKE.CResGFF_AddDataField(swigCPtr, nCurrentOffset, nCurrentSize, nNewSize);
    return (byte*)retVal;
  }

  public byte* AddDataLayoutField(uint nCurrentOffset, uint nCurrentSize, uint nNewSize) {
    global::System.IntPtr retVal = NWNXLibPINVOKE.CResGFF_AddDataLayoutField(swigCPtr, nCurrentOffset, nCurrentSize, nNewSize);
    return (byte*)retVal;
  }

  public byte* AddDataLayoutList(uint nCurrentOffset, uint nCurrentSize, uint nNewSize) {
    global::System.IntPtr retVal = NWNXLibPINVOKE.CResGFF_AddDataLayoutList(swigCPtr, nCurrentOffset, nCurrentSize, nNewSize);
    return (byte*)retVal;
  }

}

}

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

public unsafe class CVirtualMachineDebuggerInstance : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal CVirtualMachineDebuggerInstance(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(CVirtualMachineDebuggerInstance obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~CVirtualMachineDebuggerInstance() {
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
          NWNXLibPINVOKE.delete_CVirtualMachineDebuggerInstance(swigCPtr);
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

  public static unsafe implicit operator void*(CVirtualMachineDebuggerInstance self) {
    return (void*)self.swigCPtr.Handle;
  }

  public static unsafe CVirtualMachineDebuggerInstance FromPointer(void* pointer, bool memoryOwn = false) {
    return pointer != null ? new CVirtualMachineDebuggerInstance((global::System.IntPtr)pointer, memoryOwn) : null;
  }

  public static CVirtualMachineDebuggerInstance FromPointer(global::System.IntPtr pointer, bool memoryOwn = false) {
    return pointer != global::System.IntPtr.Zero ? new CVirtualMachineDebuggerInstance(pointer, memoryOwn) : null;
  }

  public bool Equals(CVirtualMachineDebuggerInstance other) {
    if (ReferenceEquals(null, other)) {
      return false;
    }

    if (ReferenceEquals(this, other)) {
      return true;
    }

    return Pointer.Equals(other.Pointer);
  }

  public override bool Equals(object obj) {
    return ReferenceEquals(this, obj) || obj is CVirtualMachineDebuggerInstance other && Equals(other);
  }

  public override int GetHashCode() {
    return swigCPtr.Handle.GetHashCode();
  }

  public static bool operator ==(CVirtualMachineDebuggerInstance left, CVirtualMachineDebuggerInstance right) {
    return Equals(left, right);
  }

  public static bool operator !=(CVirtualMachineDebuggerInstance left, CVirtualMachineDebuggerInstance right) {
    return !Equals(left, right);
  }
/*@SWIG@*/
  public CVirtualMachine m_pVMachine {
    set {
      NWNXLibPINVOKE.CVirtualMachineDebuggerInstance_m_pVMachine_set(swigCPtr, CVirtualMachine.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = NWNXLibPINVOKE.CVirtualMachineDebuggerInstance_m_pVMachine_get(swigCPtr);
      CVirtualMachine ret = (cPtr == global::System.IntPtr.Zero) ? null : new CVirtualMachine(cPtr, false);
      return ret;
    } 
  }

  public int* m_pnInstructionPointer {
    set {
      NWNXLibPINVOKE.CVirtualMachineDebuggerInstance_m_pnInstructionPointer_set(swigCPtr, value);
    } 
    get {
      int* retVal = NWNXLibPINVOKE.CVirtualMachineDebuggerInstance_m_pnInstructionPointer_get(swigCPtr);
      return retVal;
    }

  }

  public byte* m_pDebugInputMessageBuffer {
    set {
      NWNXLibPINVOKE.CVirtualMachineDebuggerInstance_m_pDebugInputMessageBuffer_set(swigCPtr, value);
    } 
    get {
      byte* retVal = NWNXLibPINVOKE.CVirtualMachineDebuggerInstance_m_pDebugInputMessageBuffer_get(swigCPtr);
      return retVal;
    }

  }

  public int m_nDebugInputMessageSize {
    set {
      NWNXLibPINVOKE.CVirtualMachineDebuggerInstance_m_nDebugInputMessageSize_set(swigCPtr, value);
    } 
    get {
      int retVal = NWNXLibPINVOKE.CVirtualMachineDebuggerInstance_m_nDebugInputMessageSize_get(swigCPtr);
      return retVal;
    }

  }

  public byte* m_pDebugOutputMessageBuffer {
    set {
      NWNXLibPINVOKE.CVirtualMachineDebuggerInstance_m_pDebugOutputMessageBuffer_set(swigCPtr, value);
    } 
    get {
      byte* retVal = NWNXLibPINVOKE.CVirtualMachineDebuggerInstance_m_pDebugOutputMessageBuffer_get(swigCPtr);
      return retVal;
    }

  }

  public int m_nDebugOutputMessageSize {
    set {
      NWNXLibPINVOKE.CVirtualMachineDebuggerInstance_m_nDebugOutputMessageSize_set(swigCPtr, value);
    } 
    get {
      int retVal = NWNXLibPINVOKE.CVirtualMachineDebuggerInstance_m_nDebugOutputMessageSize_get(swigCPtr);
      return retVal;
    }

  }

  public int m_nDebugSourceFileNames {
    set {
      NWNXLibPINVOKE.CVirtualMachineDebuggerInstance_m_nDebugSourceFileNames_set(swigCPtr, value);
    } 
    get {
      int retVal = NWNXLibPINVOKE.CVirtualMachineDebuggerInstance_m_nDebugSourceFileNames_get(swigCPtr);
      return retVal;
    }

  }

  public CExoString m_pDebugSourceFileNames {
    set {
      NWNXLibPINVOKE.CVirtualMachineDebuggerInstance_m_pDebugSourceFileNames_set(swigCPtr, CExoString.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = NWNXLibPINVOKE.CVirtualMachineDebuggerInstance_m_pDebugSourceFileNames_get(swigCPtr);
      CExoString ret = (cPtr == global::System.IntPtr.Zero) ? null : new CExoString(cPtr, false);
      return ret;
    } 
  }

  public int m_nDebugStructureDefines {
    set {
      NWNXLibPINVOKE.CVirtualMachineDebuggerInstance_m_nDebugStructureDefines_set(swigCPtr, value);
    } 
    get {
      int retVal = NWNXLibPINVOKE.CVirtualMachineDebuggerInstance_m_nDebugStructureDefines_get(swigCPtr);
      return retVal;
    }

  }

  public CExoString m_pDebugStructureNames {
    set {
      NWNXLibPINVOKE.CVirtualMachineDebuggerInstance_m_pDebugStructureNames_set(swigCPtr, CExoString.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = NWNXLibPINVOKE.CVirtualMachineDebuggerInstance_m_pDebugStructureNames_get(swigCPtr);
      CExoString ret = (cPtr == global::System.IntPtr.Zero) ? null : new CExoString(cPtr, false);
      return ret;
    } 
  }

  public int* m_pDebugStructureFields {
    set {
      NWNXLibPINVOKE.CVirtualMachineDebuggerInstance_m_pDebugStructureFields_set(swigCPtr, value);
    } 
    get {
      int* retVal = NWNXLibPINVOKE.CVirtualMachineDebuggerInstance_m_pDebugStructureFields_get(swigCPtr);
      return retVal;
    }

  }

  public void** m_ppDebugStructureFieldNames {
    set {
      NWNXLibPINVOKE.CVirtualMachineDebuggerInstance_m_ppDebugStructureFieldNames_set(swigCPtr, (global::System.IntPtr)value);
    } 
    get {
        global::System.IntPtr retVal = NWNXLibPINVOKE.CVirtualMachineDebuggerInstance_m_ppDebugStructureFieldNames_get(swigCPtr);
        return (void**)retVal;
    }

  }

  public void** m_ppDebugStructureTypeNames {
    set {
      NWNXLibPINVOKE.CVirtualMachineDebuggerInstance_m_ppDebugStructureTypeNames_set(swigCPtr, (global::System.IntPtr)value);
    } 
    get {
        global::System.IntPtr retVal = NWNXLibPINVOKE.CVirtualMachineDebuggerInstance_m_ppDebugStructureTypeNames_get(swigCPtr);
        return (void**)retVal;
    }

  }

  public int m_nDebugFunctionNames {
    set {
      NWNXLibPINVOKE.CVirtualMachineDebuggerInstance_m_nDebugFunctionNames_set(swigCPtr, value);
    } 
    get {
      int retVal = NWNXLibPINVOKE.CVirtualMachineDebuggerInstance_m_nDebugFunctionNames_get(swigCPtr);
      return retVal;
    }

  }

  public CExoString m_pDebugFunctionNames {
    set {
      NWNXLibPINVOKE.CVirtualMachineDebuggerInstance_m_pDebugFunctionNames_set(swigCPtr, CExoString.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = NWNXLibPINVOKE.CVirtualMachineDebuggerInstance_m_pDebugFunctionNames_get(swigCPtr);
      CExoString ret = (cPtr == global::System.IntPtr.Zero) ? null : new CExoString(cPtr, false);
      return ret;
    } 
  }

  public int* m_pDebugFunctionBinaryStart {
    set {
      NWNXLibPINVOKE.CVirtualMachineDebuggerInstance_m_pDebugFunctionBinaryStart_set(swigCPtr, value);
    } 
    get {
      int* retVal = NWNXLibPINVOKE.CVirtualMachineDebuggerInstance_m_pDebugFunctionBinaryStart_get(swigCPtr);
      return retVal;
    }

  }

  public int* m_pDebugFunctionBinaryEnd {
    set {
      NWNXLibPINVOKE.CVirtualMachineDebuggerInstance_m_pDebugFunctionBinaryEnd_set(swigCPtr, value);
    } 
    get {
      int* retVal = NWNXLibPINVOKE.CVirtualMachineDebuggerInstance_m_pDebugFunctionBinaryEnd_get(swigCPtr);
      return retVal;
    }

  }

  public int* m_pDebugFunctionParameters {
    set {
      NWNXLibPINVOKE.CVirtualMachineDebuggerInstance_m_pDebugFunctionParameters_set(swigCPtr, value);
    } 
    get {
      int* retVal = NWNXLibPINVOKE.CVirtualMachineDebuggerInstance_m_pDebugFunctionParameters_get(swigCPtr);
      return retVal;
    }

  }

  public CExoString m_pDebugFunctionReturnTypeNames {
    set {
      NWNXLibPINVOKE.CVirtualMachineDebuggerInstance_m_pDebugFunctionReturnTypeNames_set(swigCPtr, CExoString.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = NWNXLibPINVOKE.CVirtualMachineDebuggerInstance_m_pDebugFunctionReturnTypeNames_get(swigCPtr);
      CExoString ret = (cPtr == global::System.IntPtr.Zero) ? null : new CExoString(cPtr, false);
      return ret;
    } 
  }

  public void** m_ppDebugFunctionParamTypeNames {
    set {
      NWNXLibPINVOKE.CVirtualMachineDebuggerInstance_m_ppDebugFunctionParamTypeNames_set(swigCPtr, (global::System.IntPtr)value);
    } 
    get {
        global::System.IntPtr retVal = NWNXLibPINVOKE.CVirtualMachineDebuggerInstance_m_ppDebugFunctionParamTypeNames_get(swigCPtr);
        return (void**)retVal;
    }

  }

  public int m_nDebugVariables {
    set {
      NWNXLibPINVOKE.CVirtualMachineDebuggerInstance_m_nDebugVariables_set(swigCPtr, value);
    } 
    get {
      int retVal = NWNXLibPINVOKE.CVirtualMachineDebuggerInstance_m_nDebugVariables_get(swigCPtr);
      return retVal;
    }

  }

  public int* m_pDebugVariableBinaryStart {
    set {
      NWNXLibPINVOKE.CVirtualMachineDebuggerInstance_m_pDebugVariableBinaryStart_set(swigCPtr, value);
    } 
    get {
      int* retVal = NWNXLibPINVOKE.CVirtualMachineDebuggerInstance_m_pDebugVariableBinaryStart_get(swigCPtr);
      return retVal;
    }

  }

  public int* m_pDebugVariableBinaryEnd {
    set {
      NWNXLibPINVOKE.CVirtualMachineDebuggerInstance_m_pDebugVariableBinaryEnd_set(swigCPtr, value);
    } 
    get {
      int* retVal = NWNXLibPINVOKE.CVirtualMachineDebuggerInstance_m_pDebugVariableBinaryEnd_get(swigCPtr);
      return retVal;
    }

  }

  public int* m_pDebugVariableStackLocation {
    set {
      NWNXLibPINVOKE.CVirtualMachineDebuggerInstance_m_pDebugVariableStackLocation_set(swigCPtr, value);
    } 
    get {
      int* retVal = NWNXLibPINVOKE.CVirtualMachineDebuggerInstance_m_pDebugVariableStackLocation_get(swigCPtr);
      return retVal;
    }

  }

  public CExoString m_pDebugVariableTypeNames {
    set {
      NWNXLibPINVOKE.CVirtualMachineDebuggerInstance_m_pDebugVariableTypeNames_set(swigCPtr, CExoString.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = NWNXLibPINVOKE.CVirtualMachineDebuggerInstance_m_pDebugVariableTypeNames_get(swigCPtr);
      CExoString ret = (cPtr == global::System.IntPtr.Zero) ? null : new CExoString(cPtr, false);
      return ret;
    } 
  }

  public CExoString m_pDebugVariableNames {
    set {
      NWNXLibPINVOKE.CVirtualMachineDebuggerInstance_m_pDebugVariableNames_set(swigCPtr, CExoString.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = NWNXLibPINVOKE.CVirtualMachineDebuggerInstance_m_pDebugVariableNames_get(swigCPtr);
      CExoString ret = (cPtr == global::System.IntPtr.Zero) ? null : new CExoString(cPtr, false);
      return ret;
    } 
  }

  public int m_nDebugLineNumbers {
    set {
      NWNXLibPINVOKE.CVirtualMachineDebuggerInstance_m_nDebugLineNumbers_set(swigCPtr, value);
    } 
    get {
      int retVal = NWNXLibPINVOKE.CVirtualMachineDebuggerInstance_m_nDebugLineNumbers_get(swigCPtr);
      return retVal;
    }

  }

  public int* m_pDebugLineNumberFileName {
    set {
      NWNXLibPINVOKE.CVirtualMachineDebuggerInstance_m_pDebugLineNumberFileName_set(swigCPtr, value);
    } 
    get {
      int* retVal = NWNXLibPINVOKE.CVirtualMachineDebuggerInstance_m_pDebugLineNumberFileName_get(swigCPtr);
      return retVal;
    }

  }

  public int* m_pDebugLineNumberCodeLine {
    set {
      NWNXLibPINVOKE.CVirtualMachineDebuggerInstance_m_pDebugLineNumberCodeLine_set(swigCPtr, value);
    } 
    get {
      int* retVal = NWNXLibPINVOKE.CVirtualMachineDebuggerInstance_m_pDebugLineNumberCodeLine_get(swigCPtr);
      return retVal;
    }

  }

  public int* m_pDebugLineNumberBinaryStart {
    set {
      NWNXLibPINVOKE.CVirtualMachineDebuggerInstance_m_pDebugLineNumberBinaryStart_set(swigCPtr, value);
    } 
    get {
      int* retVal = NWNXLibPINVOKE.CVirtualMachineDebuggerInstance_m_pDebugLineNumberBinaryStart_get(swigCPtr);
      return retVal;
    }

  }

  public int* m_pDebugLineNumberBinaryEnd {
    set {
      NWNXLibPINVOKE.CVirtualMachineDebuggerInstance_m_pDebugLineNumberBinaryEnd_set(swigCPtr, value);
    } 
    get {
      int* retVal = NWNXLibPINVOKE.CVirtualMachineDebuggerInstance_m_pDebugLineNumberBinaryEnd_get(swigCPtr);
      return retVal;
    }

  }

  public int m_nDebugWatchViewArraySize {
    set {
      NWNXLibPINVOKE.CVirtualMachineDebuggerInstance_m_nDebugWatchViewArraySize_set(swigCPtr, value);
    } 
    get {
      int retVal = NWNXLibPINVOKE.CVirtualMachineDebuggerInstance_m_nDebugWatchViewArraySize_get(swigCPtr);
      return retVal;
    }

  }

  public int* m_pDebugWatchViewEmpty {
    set {
      NWNXLibPINVOKE.CVirtualMachineDebuggerInstance_m_pDebugWatchViewEmpty_set(swigCPtr, value);
    } 
    get {
      int* retVal = NWNXLibPINVOKE.CVirtualMachineDebuggerInstance_m_pDebugWatchViewEmpty_get(swigCPtr);
      return retVal;
    }

  }

  public int* m_pDebugWatchViewTouched {
    set {
      NWNXLibPINVOKE.CVirtualMachineDebuggerInstance_m_pDebugWatchViewTouched_set(swigCPtr, value);
    } 
    get {
      int* retVal = NWNXLibPINVOKE.CVirtualMachineDebuggerInstance_m_pDebugWatchViewTouched_get(swigCPtr);
      return retVal;
    }

  }

  public int* m_pDebugWatchViewExpanded {
    set {
      NWNXLibPINVOKE.CVirtualMachineDebuggerInstance_m_pDebugWatchViewExpanded_set(swigCPtr, value);
    } 
    get {
      int* retVal = NWNXLibPINVOKE.CVirtualMachineDebuggerInstance_m_pDebugWatchViewExpanded_get(swigCPtr);
      return retVal;
    }

  }

  public int* m_pDebugWatchViewStackLocations {
    set {
      NWNXLibPINVOKE.CVirtualMachineDebuggerInstance_m_pDebugWatchViewStackLocations_set(swigCPtr, value);
    } 
    get {
      int* retVal = NWNXLibPINVOKE.CVirtualMachineDebuggerInstance_m_pDebugWatchViewStackLocations_get(swigCPtr);
      return retVal;
    }

  }

  public CExoString m_pDebugWatchViewVariableNames {
    set {
      NWNXLibPINVOKE.CVirtualMachineDebuggerInstance_m_pDebugWatchViewVariableNames_set(swigCPtr, CExoString.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = NWNXLibPINVOKE.CVirtualMachineDebuggerInstance_m_pDebugWatchViewVariableNames_get(swigCPtr);
      CExoString ret = (cPtr == global::System.IntPtr.Zero) ? null : new CExoString(cPtr, false);
      return ret;
    } 
  }

  public CExoString m_pDebugWatchViewTypeNames {
    set {
      NWNXLibPINVOKE.CVirtualMachineDebuggerInstance_m_pDebugWatchViewTypeNames_set(swigCPtr, CExoString.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = NWNXLibPINVOKE.CVirtualMachineDebuggerInstance_m_pDebugWatchViewTypeNames_get(swigCPtr);
      CExoString ret = (cPtr == global::System.IntPtr.Zero) ? null : new CExoString(cPtr, false);
      return ret;
    } 
  }

  public CExoString m_pDebugWatchViewLineNumbers {
    set {
      NWNXLibPINVOKE.CVirtualMachineDebuggerInstance_m_pDebugWatchViewLineNumbers_set(swigCPtr, CExoString.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = NWNXLibPINVOKE.CVirtualMachineDebuggerInstance_m_pDebugWatchViewLineNumbers_get(swigCPtr);
      CExoString ret = (cPtr == global::System.IntPtr.Zero) ? null : new CExoString(cPtr, false);
      return ret;
    } 
  }

  public CExoString m_pDebugWatchViewVariableValues {
    set {
      NWNXLibPINVOKE.CVirtualMachineDebuggerInstance_m_pDebugWatchViewVariableValues_set(swigCPtr, CExoString.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = NWNXLibPINVOKE.CVirtualMachineDebuggerInstance_m_pDebugWatchViewVariableValues_get(swigCPtr);
      CExoString ret = (cPtr == global::System.IntPtr.Zero) ? null : new CExoString(cPtr, false);
      return ret;
    } 
  }

  public CVirtualMachineDebugLoader m_pDebugLoader {
    set {
      NWNXLibPINVOKE.CVirtualMachineDebuggerInstance_m_pDebugLoader_set(swigCPtr, CVirtualMachineDebugLoader.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = NWNXLibPINVOKE.CVirtualMachineDebuggerInstance_m_pDebugLoader_get(swigCPtr);
      CVirtualMachineDebugLoader ret = (cPtr == global::System.IntPtr.Zero) ? null : new CVirtualMachineDebugLoader(cPtr, false);
      return ret;
    } 
  }

  public CExoString m_sCurrentSourceFileName {
    set {
      NWNXLibPINVOKE.CVirtualMachineDebuggerInstance_m_sCurrentSourceFileName_set(swigCPtr, CExoString.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = NWNXLibPINVOKE.CVirtualMachineDebuggerInstance_m_sCurrentSourceFileName_get(swigCPtr);
      CExoString ret = (cPtr == global::System.IntPtr.Zero) ? null : new CExoString(cPtr, false);
      return ret;
    } 
  }

  public CScriptSourceFile m_pCurrentSourceScriptFile {
    set {
      NWNXLibPINVOKE.CVirtualMachineDebuggerInstance_m_pCurrentSourceScriptFile_set(swigCPtr, CScriptSourceFile.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = NWNXLibPINVOKE.CVirtualMachineDebuggerInstance_m_pCurrentSourceScriptFile_get(swigCPtr);
      CScriptSourceFile ret = (cPtr == global::System.IntPtr.Zero) ? null : new CScriptSourceFile(cPtr, false);
      return ret;
    } 
  }

  public int m_nActiveCallStackEntry {
    set {
      NWNXLibPINVOKE.CVirtualMachineDebuggerInstance_m_nActiveCallStackEntry_set(swigCPtr, value);
    } 
    get {
      int retVal = NWNXLibPINVOKE.CVirtualMachineDebuggerInstance_m_nActiveCallStackEntry_get(swigCPtr);
      return retVal;
    }

  }

  public CVirtualMachineDebuggerInstance() : this(NWNXLibPINVOKE.new_CVirtualMachineDebuggerInstance(), true) {
  }

  public int SpawnDebugger() {
    int retVal = NWNXLibPINVOKE.CVirtualMachineDebuggerInstance_SpawnDebugger(swigCPtr);
    return retVal;
  }

  public int DebuggerMainLoop() {
    int retVal = NWNXLibPINVOKE.CVirtualMachineDebuggerInstance_DebuggerMainLoop(swigCPtr);
    return retVal;
  }

  public void ShutDownDebugger() {
    NWNXLibPINVOKE.CVirtualMachineDebuggerInstance_ShutDownDebugger(swigCPtr);
  }

  public int GenerateLineNumberFromInstructionPointer(int nIP, int bExactCheck) {
    int retVal = NWNXLibPINVOKE.CVirtualMachineDebuggerInstance_GenerateLineNumberFromInstructionPointer__SWIG_0(swigCPtr, nIP, bExactCheck);
    return retVal;
  }

  public int GenerateLineNumberFromInstructionPointer(int nIP) {
    int retVal = NWNXLibPINVOKE.CVirtualMachineDebuggerInstance_GenerateLineNumberFromInstructionPointer__SWIG_1(swigCPtr, nIP);
    return retVal;
  }

  public int ReadIntegerFromInput(int* pnSize, int* pnInteger) {
    int retVal = NWNXLibPINVOKE.CVirtualMachineDebuggerInstance_ReadIntegerFromInput(swigCPtr, pnSize, pnInteger);
    return retVal;
  }

  public int ReadStringFromInput(int* pnSize, CExoString psString) {
    int retVal = NWNXLibPINVOKE.CVirtualMachineDebuggerInstance_ReadStringFromInput(swigCPtr, pnSize, CExoString.getCPtr(psString));
    return retVal;
  }

  public int ParseAndExecuteMessage(int* nSize) {
    int retVal = NWNXLibPINVOKE.CVirtualMachineDebuggerInstance_ParseAndExecuteMessage(swigCPtr, nSize);
    return retVal;
  }

  public byte* LoadDebugInfoLine(byte* pResourceData, uint nResourceSize, uint nOffsetStart, uint* pnOffsetEnd) {
    byte* retVal = NWNXLibPINVOKE.CVirtualMachineDebuggerInstance_LoadDebugInfoLine(swigCPtr, pResourceData, nResourceSize, nOffsetStart, pnOffsetEnd);
    return retVal;
  }

  public int LoadDebugInfo(CVirtualMachineDebugLoader pDebugLoader) {
    int retVal = NWNXLibPINVOKE.CVirtualMachineDebuggerInstance_LoadDebugInfo(swigCPtr, CVirtualMachineDebugLoader.getCPtr(pDebugLoader));
    return retVal;
  }

  public byte* LoadScriptLine(byte* pResourceData, uint nResourceSize, uint nOffsetStart, uint* pnOffsetEnd, int bIncludeReturns) {
    byte* retVal = NWNXLibPINVOKE.CVirtualMachineDebuggerInstance_LoadScriptLine(swigCPtr, pResourceData, nResourceSize, nOffsetStart, pnOffsetEnd, bIncludeReturns);
    return retVal;
  }

  public int GenerateFunctionIDFromInstructionPointer(int nIP) {
    int retVal = NWNXLibPINVOKE.CVirtualMachineDebuggerInstance_GenerateFunctionIDFromInstructionPointer(swigCPtr, nIP);
    return retVal;
  }

  public int GenerateTypeSize(CExoString pNDBString) {
    int retVal = NWNXLibPINVOKE.CVirtualMachineDebuggerInstance_GenerateTypeSize(swigCPtr, CExoString.getCPtr(pNDBString));
    return retVal;
  }

  public int GenerateStackSizeAtInstructionPointer(int nFunctionID, int nIP) {
    int retVal = NWNXLibPINVOKE.CVirtualMachineDebuggerInstance_GenerateStackSizeAtInstructionPointer(swigCPtr, nFunctionID, nIP);
    return retVal;
  }

  public int GenerateDebugVariableLocationForParameter(int nFunctionID, int nParameter) {
    int retVal = NWNXLibPINVOKE.CVirtualMachineDebuggerInstance_GenerateDebugVariableLocationForParameter(swigCPtr, nFunctionID, nParameter);
    return retVal;
  }

  public int GetNextDebugVariable(int nFunctionID, int nIP, int nStackLocationToExceed) {
    int retVal = NWNXLibPINVOKE.CVirtualMachineDebuggerInstance_GetNextDebugVariable(swigCPtr, nFunctionID, nIP, nStackLocationToExceed);
    return retVal;
  }

  public CExoString GenerateTypeName(CExoString pNDBString) {
    CExoString ret = new CExoString(NWNXLibPINVOKE.CVirtualMachineDebuggerInstance_GenerateTypeName(swigCPtr, CExoString.getCPtr(pNDBString)), true);
    return ret;
  }

  public CExoString GenerateTypeValueFromStackLocation(int nStackLocation, CExoString pTypeString) {
    CExoString ret = new CExoString(NWNXLibPINVOKE.CVirtualMachineDebuggerInstance_GenerateTypeValueFromStackLocation(swigCPtr, nStackLocation, CExoString.getCPtr(pTypeString)), true);
    return ret;
  }

  public CExoString GenerateCallStackParameterView(int nStackLocation, CExoString sVariableName, CExoString sTypeName) {
    CExoString ret = new CExoString(NWNXLibPINVOKE.CVirtualMachineDebuggerInstance_GenerateCallStackParameterView(swigCPtr, nStackLocation, CExoString.getCPtr(sVariableName), CExoString.getCPtr(sTypeName)), true);
    return ret;
  }

  public CExoString GenerateCallStackView(int nFunctionID, int nInstructionPointer, int nStackPointer) {
    CExoString ret = new CExoString(NWNXLibPINVOKE.CVirtualMachineDebuggerInstance_GenerateCallStackView(swigCPtr, nFunctionID, nInstructionPointer, nStackPointer), true);
    return ret;
  }

  public void ToggleWatchWindowExpansion(CExoString sLineNumber) {
    NWNXLibPINVOKE.CVirtualMachineDebuggerInstance_ToggleWatchWindowExpansion(swigCPtr, CExoString.getCPtr(sLineNumber));
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
  }

  public int DebuggerSingleStep(int bStepOver) {
    int retVal = NWNXLibPINVOKE.CVirtualMachineDebuggerInstance_DebuggerSingleStep__SWIG_0(swigCPtr, bStepOver);
    return retVal;
  }

  public int DebuggerSingleStep() {
    int retVal = NWNXLibPINVOKE.CVirtualMachineDebuggerInstance_DebuggerSingleStep__SWIG_1(swigCPtr);
    return retVal;
  }

  public int FindEmptyWatchViewEntry() {
    int retVal = NWNXLibPINVOKE.CVirtualMachineDebuggerInstance_FindEmptyWatchViewEntry(swigCPtr);
    return retVal;
  }

  public int FindWatchViewEntry(CExoString psVariableName, CExoString psTypeName, int nStackLocation) {
    int retVal = NWNXLibPINVOKE.CVirtualMachineDebuggerInstance_FindWatchViewEntry(swigCPtr, CExoString.getCPtr(psVariableName), CExoString.getCPtr(psTypeName), nStackLocation);
    return retVal;
  }

  public void SendWatchWindowEntry(CExoString psLineNumber, CExoString psVariableName, CExoString psVariableValue, CExoString psTypeName, int nStackLocation) {
    NWNXLibPINVOKE.CVirtualMachineDebuggerInstance_SendWatchWindowEntry(swigCPtr, CExoString.getCPtr(psLineNumber), CExoString.getCPtr(psVariableName), CExoString.getCPtr(psVariableValue), CExoString.getCPtr(psTypeName), nStackLocation);
  }

  public void SendWatchWindowUpdateCommands(int nActiveCallStackEntry) {
    NWNXLibPINVOKE.CVirtualMachineDebuggerInstance_SendWatchWindowUpdateCommands(swigCPtr, nActiveCallStackEntry);
  }

  public void SendCallStackWindowUpdateCommands() {
    NWNXLibPINVOKE.CVirtualMachineDebuggerInstance_SendCallStackWindowUpdateCommands(swigCPtr);
  }

  public void SendCodeWindowUpdateCommands(CExoString sDebugFileName, int nCodeLine) {
    NWNXLibPINVOKE.CVirtualMachineDebuggerInstance_SendCodeWindowUpdateCommands(swigCPtr, CExoString.getCPtr(sDebugFileName), nCodeLine);
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
  }

  public void SendLabelsAndKeywords() {
    NWNXLibPINVOKE.CVirtualMachineDebuggerInstance_SendLabelsAndKeywords(swigCPtr);
  }

  public int DebuggerDisplayCurrentLocation(int nActiveCallStackEntry, int bInternalDebug) {
    int retVal = NWNXLibPINVOKE.CVirtualMachineDebuggerInstance_DebuggerDisplayCurrentLocation__SWIG_0(swigCPtr, nActiveCallStackEntry, bInternalDebug);
    return retVal;
  }

  public int DebuggerDisplayCurrentLocation(int nActiveCallStackEntry) {
    int retVal = NWNXLibPINVOKE.CVirtualMachineDebuggerInstance_DebuggerDisplayCurrentLocation__SWIG_1(swigCPtr, nActiveCallStackEntry);
    return retVal;
  }

}

}

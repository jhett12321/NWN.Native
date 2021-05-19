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

public unsafe class CVirtualMachine : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal CVirtualMachine(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(CVirtualMachine obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~CVirtualMachine() {
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
          NWNXLibPINVOKE.delete_CVirtualMachine(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
    }
  }
/*@SWIG:/__w/NWN.Native/NWN.Native/nwnx/Plugins/SWIG/SWIG_DotNET/API_NWNXLib.i,20,SWIG_DOTNET_EXTENSIONS@*/
  public global::System.IntPtr Pointer {
    get {
      return swigCPtr.Handle;
    }
  }

  public static unsafe implicit operator void*(CVirtualMachine self) {
    return (void*)self.swigCPtr.Handle;
  }

  public static unsafe CVirtualMachine FromPointer(void* pointer, bool memoryOwn = false) {
    return pointer != null ? new CVirtualMachine((global::System.IntPtr)pointer, memoryOwn) : null;
  }

  public static CVirtualMachine FromPointer(global::System.IntPtr pointer, bool memoryOwn = false) {
    return pointer != global::System.IntPtr.Zero ? new CVirtualMachine(pointer, memoryOwn) : null;
  }

  public bool Equals(CVirtualMachine other) {
    if (ReferenceEquals(null, other)) {
      return false;
    }

    if (ReferenceEquals(this, other)) {
      return true;
    }

    return Pointer.Equals(other.Pointer);
  }

  public override bool Equals(object obj) {
    return ReferenceEquals(this, obj) || obj is CVirtualMachine other && Equals(other);
  }

  public override int GetHashCode() {
    return swigCPtr.Handle.GetHashCode();
  }

  public static bool operator ==(CVirtualMachine left, CVirtualMachine right) {
    return Equals(left, right);
  }

  public static bool operator !=(CVirtualMachine left, CVirtualMachine right) {
    return !Equals(left, right);
  }
/*@SWIG@*/
  public CScriptCompiler m_pJitCompiler {
    set {
      NWNXLibPINVOKE.CVirtualMachine_m_pJitCompiler_set(swigCPtr, CScriptCompiler.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = NWNXLibPINVOKE.CVirtualMachine_m_pJitCompiler_get(swigCPtr);
      CScriptCompiler ret = (cPtr == global::System.IntPtr.Zero) ? null : new CScriptCompiler(cPtr, false);
      return ret;
    } 
  }

  public int m_nReturnValueParameterType {
    set {
      NWNXLibPINVOKE.CVirtualMachine_m_nReturnValueParameterType_set(swigCPtr, value);
    } 
    get {
      int ret = NWNXLibPINVOKE.CVirtualMachine_m_nReturnValueParameterType_get(swigCPtr);
      return ret;
    } 
  }

  public void* m_pReturnValue {
    set {
      NWNXLibPINVOKE.CVirtualMachine_m_pReturnValue_set(swigCPtr, (global::System.IntPtr)value);
    } 
    get {
        global::System.IntPtr retVal = NWNXLibPINVOKE.CVirtualMachine_m_pReturnValue_get(swigCPtr);
        return (void*)retVal;
    }

  }

  public uint m_nInstructionsExecuted {
    set {
      NWNXLibPINVOKE.CVirtualMachine_m_nInstructionsExecuted_set(swigCPtr, value);
    } 
    get {
      uint ret = NWNXLibPINVOKE.CVirtualMachine_m_nInstructionsExecuted_get(swigCPtr);
      return ret;
    } 
  }

  public int m_nRecursionLevel {
    set {
      NWNXLibPINVOKE.CVirtualMachine_m_nRecursionLevel_set(swigCPtr, value);
    } 
    get {
      int ret = NWNXLibPINVOKE.CVirtualMachine_m_nRecursionLevel_get(swigCPtr);
      return ret;
    } 
  }

  public CVirtualMachineScriptArray m_pVirtualMachineScript {
    set {
      NWNXLibPINVOKE.CVirtualMachine_m_pVirtualMachineScript_set(swigCPtr, CVirtualMachineScriptArray.getCPtr(value));
    } 
    get {
        global::System.IntPtr cPtr = NWNXLibPINVOKE.CVirtualMachine_m_pVirtualMachineScript_get(swigCPtr);;
        CVirtualMachineScriptArray ret = (cPtr == global::System.IntPtr.Zero) ? null : new CVirtualMachineScriptArray(cPtr, false);
        return ret;
    }

  }

  public NativeArray<int> m_bValidObjectRunScript {
    set {
      NWNXLibPINVOKE.CVirtualMachine_m_bValidObjectRunScript_set(swigCPtr, value);
    } 
    get {
      global::System.IntPtr arrayPtr = NWNXLibPINVOKE.CVirtualMachine_m_bValidObjectRunScript_get(swigCPtr);
      NativeArray<int> retVal = new NativeArray<int>(arrayPtr, 8);

      return retVal; // int[8]
    }

  }

  public NativeArray<uint> m_oidObjectRunScript {
    set {
      NWNXLibPINVOKE.CVirtualMachine_m_oidObjectRunScript_set(swigCPtr, value);
    } 
    get {
      global::System.IntPtr arrayPtr = NWNXLibPINVOKE.CVirtualMachine_m_oidObjectRunScript_get(swigCPtr);
      NativeArray<uint> retVal = new NativeArray<uint>(arrayPtr, 8);

      return retVal; // uint[8]
    }

  }

  public CExoArrayListScriptParamArray m_lScriptParams {
    set {
      NWNXLibPINVOKE.CVirtualMachine_m_lScriptParams_set(swigCPtr, CExoArrayListScriptParamArray.getCPtr(value));
    } 
    get {
        global::System.IntPtr cPtr = NWNXLibPINVOKE.CVirtualMachine_m_lScriptParams_get(swigCPtr);;
        CExoArrayListScriptParamArray ret = (cPtr == global::System.IntPtr.Zero) ? null : new CExoArrayListScriptParamArray(cPtr, false);
        return ret;
    }

  }

  public CVirtualMachineStack m_cRunTimeStack {
    set {
      NWNXLibPINVOKE.CVirtualMachine_m_cRunTimeStack_set(swigCPtr, CVirtualMachineStack.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = NWNXLibPINVOKE.CVirtualMachine_m_cRunTimeStack_get(swigCPtr);
      CVirtualMachineStack ret = (cPtr == global::System.IntPtr.Zero) ? null : new CVirtualMachineStack(cPtr, false);
      return ret;
    } 
  }

  public int m_nInstructPtrLevel {
    set {
      NWNXLibPINVOKE.CVirtualMachine_m_nInstructPtrLevel_set(swigCPtr, value);
    } 
    get {
      int ret = NWNXLibPINVOKE.CVirtualMachine_m_nInstructPtrLevel_get(swigCPtr);
      return ret;
    } 
  }

  public NativeArray<int> m_pnRunTimeInstructPtr {
    set {
      NWNXLibPINVOKE.CVirtualMachine_m_pnRunTimeInstructPtr_set(swigCPtr, value);
    } 
    get {
      global::System.IntPtr arrayPtr = NWNXLibPINVOKE.CVirtualMachine_m_pnRunTimeInstructPtr_get(swigCPtr);
      NativeArray<int> retVal = new NativeArray<int>(arrayPtr, 128);

      return retVal; // int[128]
    }

  }

  public int m_nSecondaryInstructionPointer {
    set {
      NWNXLibPINVOKE.CVirtualMachine_m_nSecondaryInstructionPointer_set(swigCPtr, value);
    } 
    get {
      int ret = NWNXLibPINVOKE.CVirtualMachine_m_nSecondaryInstructionPointer_get(swigCPtr);
      return ret;
    } 
  }

  public int m_nStackSizeToSave {
    set {
      NWNXLibPINVOKE.CVirtualMachine_m_nStackSizeToSave_set(swigCPtr, value);
    } 
    get {
      int ret = NWNXLibPINVOKE.CVirtualMachine_m_nStackSizeToSave_get(swigCPtr);
      return ret;
    } 
  }

  public int m_nBaseStackSizeToSave {
    set {
      NWNXLibPINVOKE.CVirtualMachine_m_nBaseStackSizeToSave_set(swigCPtr, value);
    } 
    get {
      int ret = NWNXLibPINVOKE.CVirtualMachine_m_nBaseStackSizeToSave_get(swigCPtr);
      return ret;
    } 
  }

  public CVirtualMachineCmdImplementer m_pCmdImplementer {
    set {
      NWNXLibPINVOKE.CVirtualMachine_m_pCmdImplementer_set(swigCPtr, CVirtualMachineCmdImplementer.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = NWNXLibPINVOKE.CVirtualMachine_m_pCmdImplementer_get(swigCPtr);
      CVirtualMachineCmdImplementer ret = (cPtr == global::System.IntPtr.Zero) ? null : new CVirtualMachineCmdImplementer(cPtr, false);
      return ret;
    } 
  }

  public int m_bDebugGUIRequired {
    set {
      NWNXLibPINVOKE.CVirtualMachine_m_bDebugGUIRequired_set(swigCPtr, value);
    } 
    get {
      int ret = NWNXLibPINVOKE.CVirtualMachine_m_bDebugGUIRequired_get(swigCPtr);
      return ret;
    } 
  }

  public int m_bDebuggerSpawned {
    set {
      NWNXLibPINVOKE.CVirtualMachine_m_bDebuggerSpawned_set(swigCPtr, value);
    } 
    get {
      int ret = NWNXLibPINVOKE.CVirtualMachine_m_bDebuggerSpawned_get(swigCPtr);
      return ret;
    } 
  }

  public CVirtualMachineFile m_cVMFile {
    set {
      NWNXLibPINVOKE.CVirtualMachine_m_cVMFile_set(swigCPtr, CVirtualMachineFile.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = NWNXLibPINVOKE.CVirtualMachine_m_cVMFile_get(swigCPtr);
      CVirtualMachineFile ret = (cPtr == global::System.IntPtr.Zero) ? null : new CVirtualMachineFile(cPtr, false);
      return ret;
    } 
  }

  public CScriptLog m_pLog {
    set {
      NWNXLibPINVOKE.CVirtualMachine_m_pLog_set(swigCPtr, CScriptLog.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = NWNXLibPINVOKE.CVirtualMachine_m_pLog_get(swigCPtr);
      CScriptLog ret = (cPtr == global::System.IntPtr.Zero) ? null : new CScriptLog(cPtr, false);
      return ret;
    } 
  }

  public CExoArrayListCScriptLogPtr m_aScriptLog {
    set {
      NWNXLibPINVOKE.CVirtualMachine_m_aScriptLog_set(swigCPtr, CExoArrayListCScriptLogPtr.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = NWNXLibPINVOKE.CVirtualMachine_m_aScriptLog_get(swigCPtr);
      CExoArrayListCScriptLogPtr ret = (cPtr == global::System.IntPtr.Zero) ? null : new CExoArrayListCScriptLogPtr(cPtr, false);
      return ret;
    } 
  }

  public int m_bEnableScriptLogging {
    set {
      NWNXLibPINVOKE.CVirtualMachine_m_bEnableScriptLogging_set(swigCPtr, value);
    } 
    get {
      int ret = NWNXLibPINVOKE.CVirtualMachine_m_bEnableScriptLogging_get(swigCPtr);
      return ret;
    } 
  }

  public int m_bEnableScriptProfiling {
    set {
      NWNXLibPINVOKE.CVirtualMachine_m_bEnableScriptProfiling_set(swigCPtr, value);
    } 
    get {
      int ret = NWNXLibPINVOKE.CVirtualMachine_m_bEnableScriptProfiling_get(swigCPtr);
      return ret;
    } 
  }

  public uint m_nScriptStartTime {
    set {
      NWNXLibPINVOKE.CVirtualMachine_m_nScriptStartTime_set(swigCPtr, value);
    } 
    get {
      uint ret = NWNXLibPINVOKE.CVirtualMachine_m_nScriptStartTime_get(swigCPtr);
      return ret;
    } 
  }

  public uint m_nScriptEndTime {
    set {
      NWNXLibPINVOKE.CVirtualMachine_m_nScriptEndTime_set(swigCPtr, value);
    } 
    get {
      uint ret = NWNXLibPINVOKE.CVirtualMachine_m_nScriptEndTime_get(swigCPtr);
      return ret;
    } 
  }

  public uint m_nInstructionLimit {
    set {
      NWNXLibPINVOKE.CVirtualMachine_m_nInstructionLimit_set(swigCPtr, value);
    } 
    get {
      uint ret = NWNXLibPINVOKE.CVirtualMachine_m_nInstructionLimit_get(swigCPtr);
      return ret;
    } 
  }

  public CVirtualMachine() : this(NWNXLibPINVOKE.new_CVirtualMachine(), true) {
  }

  public int RunScript(CExoString psFileName, uint oid, int bOidValid, int nScriptEventID) {
    int ret = NWNXLibPINVOKE.CVirtualMachine_RunScript__SWIG_0(swigCPtr, CExoString.getCPtr(psFileName), oid, bOidValid, nScriptEventID);
    return ret;
  }

  public int RunScript(CExoString psFileName, uint oid, int bOidValid) {
    int ret = NWNXLibPINVOKE.CVirtualMachine_RunScript__SWIG_1(swigCPtr, CExoString.getCPtr(psFileName), oid, bOidValid);
    return ret;
  }

  public int RunScript(CExoString psFileName, uint oid) {
    int ret = NWNXLibPINVOKE.CVirtualMachine_RunScript__SWIG_2(swigCPtr, CExoString.getCPtr(psFileName), oid);
    return ret;
  }

  public int RunScriptChunk(CExoString sScriptChunk, uint oid, int bOidValid, int bWrapIntoMain) {
    int ret = NWNXLibPINVOKE.CVirtualMachine_RunScriptChunk__SWIG_0(swigCPtr, CExoString.getCPtr(sScriptChunk), oid, bOidValid, bWrapIntoMain);
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public int RunScriptChunk(CExoString sScriptChunk, uint oid, int bOidValid) {
    int ret = NWNXLibPINVOKE.CVirtualMachine_RunScriptChunk__SWIG_1(swigCPtr, CExoString.getCPtr(sScriptChunk), oid, bOidValid);
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public int RunScriptChunk(CExoString sScriptChunk, uint oid) {
    int ret = NWNXLibPINVOKE.CVirtualMachine_RunScriptChunk__SWIG_2(swigCPtr, CExoString.getCPtr(sScriptChunk), oid);
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public int RunScriptSituation(void* pScriptSituation, uint oid, int bOidValid) {
    int ret = NWNXLibPINVOKE.CVirtualMachine_RunScriptSituation__SWIG_0(swigCPtr, (global::System.IntPtr)pScriptSituation, oid, bOidValid);
    return ret;
  }

  public int RunScriptSituation(void* pScriptSituation, uint oid) {
    int ret = NWNXLibPINVOKE.CVirtualMachine_RunScriptSituation__SWIG_1(swigCPtr, (global::System.IntPtr)pScriptSituation, oid);
    return ret;
  }

  public int GetRunScriptReturnValue(int* nParameterType, void** pParameter) {
    int ret = NWNXLibPINVOKE.CVirtualMachine_GetRunScriptReturnValue(swigCPtr, (global::System.IntPtr)nParameterType, (global::System.IntPtr)pParameter);
    return ret;
  }

  public void SetDebugGUIFlag(int bValue) {
    NWNXLibPINVOKE.CVirtualMachine_SetDebugGUIFlag(swigCPtr, bValue);
  }

  public void SetScriptParameters(CExoArrayListScriptParam lParameters) {
    NWNXLibPINVOKE.CVirtualMachine_SetScriptParameters(swigCPtr, CExoArrayListScriptParam.getCPtr(lParameters));
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
  }

  public CExoString GetScriptParameter(CExoString paramName) {
    CExoString ret = new CExoString(NWNXLibPINVOKE.CVirtualMachine_GetScriptParameter(swigCPtr, CExoString.getCPtr(paramName)), true);
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void SetScriptParameter(CExoString paramName, CExoString paramValue) {
    NWNXLibPINVOKE.CVirtualMachine_SetScriptParameter(swigCPtr, CExoString.getCPtr(paramName), CExoString.getCPtr(paramValue));
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
  }

  public void SetCommandImplementer(CVirtualMachineCmdImplementer pImplementer) {
    NWNXLibPINVOKE.CVirtualMachine_SetCommandImplementer(swigCPtr, CVirtualMachineCmdImplementer.getCPtr(pImplementer));
  }

  public int StackPopInteger(int* nInteger) {
    int ret = NWNXLibPINVOKE.CVirtualMachine_StackPopInteger(swigCPtr, (global::System.IntPtr)nInteger);
    return ret;
  }

  public int StackPushInteger(int nInteger) {
    int ret = NWNXLibPINVOKE.CVirtualMachine_StackPushInteger(swigCPtr, nInteger);
    return ret;
  }

  public int StackPopFloat(float* fFloat) {
    int ret = NWNXLibPINVOKE.CVirtualMachine_StackPopFloat(swigCPtr, (global::System.IntPtr)fFloat);
    return ret;
  }

  public int StackPushFloat(float fFloat) {
    int ret = NWNXLibPINVOKE.CVirtualMachine_StackPushFloat(swigCPtr, fFloat);
    return ret;
  }

  public int StackPopVector(Vector vVector) {
    int ret = NWNXLibPINVOKE.CVirtualMachine_StackPopVector(swigCPtr, Vector.getCPtr(vVector));
    return ret;
  }

  public int StackPushVector(Vector vVector) {
    int ret = NWNXLibPINVOKE.CVirtualMachine_StackPushVector(swigCPtr, Vector.getCPtr(vVector));
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public int StackPopString(CExoString sString) {
    int ret = NWNXLibPINVOKE.CVirtualMachine_StackPopString(swigCPtr, CExoString.getCPtr(sString));
    return ret;
  }

  public int StackPushString(CExoString sString) {
    int ret = NWNXLibPINVOKE.CVirtualMachine_StackPushString(swigCPtr, CExoString.getCPtr(sString));
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public int StackPopObject(uint* poidObjectId) {
    int ret = NWNXLibPINVOKE.CVirtualMachine_StackPopObject(swigCPtr, (global::System.IntPtr)poidObjectId);
    return ret;
  }

  public int StackPushObject(uint oidObjectId) {
    int ret = NWNXLibPINVOKE.CVirtualMachine_StackPushObject(swigCPtr, oidObjectId);
    return ret;
  }

  public int StackPopEngineStructure(int nEngineStructure, void** ppEngineStructure) {
    int ret = NWNXLibPINVOKE.CVirtualMachine_StackPopEngineStructure(swigCPtr, nEngineStructure, (global::System.IntPtr)ppEngineStructure);
    return ret;
  }

  public int StackPushEngineStructure(int nEngineStructure, void* pEngineStructure) {
    int ret = NWNXLibPINVOKE.CVirtualMachine_StackPushEngineStructure(swigCPtr, nEngineStructure, (global::System.IntPtr)pEngineStructure);
    return ret;
  }

  public void DeleteScriptSituation(void* pScript) {
    NWNXLibPINVOKE.CVirtualMachine_DeleteScriptSituation(swigCPtr, (global::System.IntPtr)pScript);
  }

  public int ExecuteCode(int* nInstructionPointer, SWIGTYPE_p_DataBlockRef pCode, CVirtualMachineDebuggingContext pDebugContext) {
    int ret = NWNXLibPINVOKE.CVirtualMachine_ExecuteCode__SWIG_0(swigCPtr, (global::System.IntPtr)nInstructionPointer, SWIGTYPE_p_DataBlockRef.getCPtr(pCode), CVirtualMachineDebuggingContext.getCPtr(pDebugContext));
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public int ExecuteCode(int* nInstructionPointer, SWIGTYPE_p_DataBlockRef pCode) {
    int ret = NWNXLibPINVOKE.CVirtualMachine_ExecuteCode__SWIG_1(swigCPtr, (global::System.IntPtr)nInstructionPointer, SWIGTYPE_p_DataBlockRef.getCPtr(pCode));
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public int Test_RunAllScriptsInDirectory(CExoString sRunDirectoryAlias) {
    int ret = NWNXLibPINVOKE.CVirtualMachine_Test_RunAllScriptsInDirectory(swigCPtr, CExoString.getCPtr(sRunDirectoryAlias));
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public int DeleteScript(CVirtualMachineScript pScript) {
    int ret = NWNXLibPINVOKE.CVirtualMachine_DeleteScript(swigCPtr, CVirtualMachineScript.getCPtr(pScript));
    return ret;
  }

  public void InitializeScript(CVirtualMachineScript pScript, SWIGTYPE_p_DataBlockRef pData) {
    NWNXLibPINVOKE.CVirtualMachine_InitializeScript(swigCPtr, CVirtualMachineScript.getCPtr(pScript), SWIGTYPE_p_DataBlockRef.getCPtr(pData));
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
  }

  public int PopInstructionPtr(int* nInstructionPointer) {
    int ret = NWNXLibPINVOKE.CVirtualMachine_PopInstructionPtr(swigCPtr, (global::System.IntPtr)nInstructionPointer);
    return ret;
  }

  public int PushInstructionPtr(int nInstructionPointer) {
    int ret = NWNXLibPINVOKE.CVirtualMachine_PushInstructionPtr(swigCPtr, nInstructionPointer);
    return ret;
  }

  public int ReadScriptFile(CExoString sFileName, int nScriptEvent) {
    int ret = NWNXLibPINVOKE.CVirtualMachine_ReadScriptFile__SWIG_0(swigCPtr, CExoString.getCPtr(sFileName), nScriptEvent);
    return ret;
  }

  public int ReadScriptFile(CExoString sFileName) {
    int ret = NWNXLibPINVOKE.CVirtualMachine_ReadScriptFile__SWIG_1(swigCPtr, CExoString.getCPtr(sFileName));
    return ret;
  }

  public int RunScriptFile(int nInstructionPointer) {
    int ret = NWNXLibPINVOKE.CVirtualMachine_RunScriptFile(swigCPtr, nInstructionPointer);
    return ret;
  }

  public int SetUpJITCompiledScript(CExoString sScriptChunk, int bWrapIntoMain) {
    int ret = NWNXLibPINVOKE.CVirtualMachine_SetUpJITCompiledScript(swigCPtr, CExoString.getCPtr(sScriptChunk), bWrapIntoMain);
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public int SetUpScriptSituation(CVirtualMachineScript pScript) {
    int ret = NWNXLibPINVOKE.CVirtualMachine_SetUpScriptSituation(swigCPtr, CVirtualMachineScript.getCPtr(pScript));
    return ret;
  }

  public void Debugger(int* pnCurrentInstructionPointer) {
    NWNXLibPINVOKE.CVirtualMachine_Debugger(swigCPtr, (global::System.IntPtr)pnCurrentInstructionPointer);
  }

  public int StackPopCommand_Internal(void** pScript) {
    int ret = NWNXLibPINVOKE.CVirtualMachine_StackPopCommand_Internal(swigCPtr, (global::System.IntPtr)pScript);
    return ret;
  }

  public int SaveScriptSituation_Internal(CVirtualMachineScript pScript, CResGFF pRes, CResStruct pStruct) {
    int ret = NWNXLibPINVOKE.CVirtualMachine_SaveScriptSituation_Internal(swigCPtr, CVirtualMachineScript.getCPtr(pScript), CResGFF.getCPtr(pRes), CResStruct.getCPtr(pStruct));
    return ret;
  }

  public int LoadScriptSituation_Internal(void** pScript, CResGFF pRes, CResStruct pStruct) {
    int ret = NWNXLibPINVOKE.CVirtualMachine_LoadScriptSituation_Internal(swigCPtr, (global::System.IntPtr)pScript, CResGFF.getCPtr(pRes), CResStruct.getCPtr(pStruct));
    return ret;
  }

  public CScriptLog GetScriptLog(CExoString sScript) {
    global::System.IntPtr cPtr = NWNXLibPINVOKE.CVirtualMachine_GetScriptLog(swigCPtr, CExoString.getCPtr(sScript));
    CScriptLog ret = (cPtr == global::System.IntPtr.Zero) ? null : new CScriptLog(cPtr, false);
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

}

}

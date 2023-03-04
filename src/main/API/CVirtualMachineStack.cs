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

public unsafe class CVirtualMachineStack : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal CVirtualMachineStack(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(CVirtualMachineStack obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~CVirtualMachineStack() {
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
          NWNXLibPINVOKE.delete_CVirtualMachineStack(swigCPtr);
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

  public static unsafe implicit operator void*(CVirtualMachineStack self) {
    return (void*)self.swigCPtr.Handle;
  }

  public static unsafe CVirtualMachineStack FromPointer(void* pointer, bool memoryOwn = false) {
    return pointer != null ? new CVirtualMachineStack((global::System.IntPtr)pointer, memoryOwn) : null;
  }

  public static CVirtualMachineStack FromPointer(global::System.IntPtr pointer, bool memoryOwn = false) {
    return pointer != global::System.IntPtr.Zero ? new CVirtualMachineStack(pointer, memoryOwn) : null;
  }

  public bool Equals(CVirtualMachineStack other) {
    if (ReferenceEquals(null, other)) {
      return false;
    }

    if (ReferenceEquals(this, other)) {
      return true;
    }

    return Pointer.Equals(other.Pointer);
  }

  public override bool Equals(object obj) {
    return ReferenceEquals(this, obj) || obj is CVirtualMachineStack other && Equals(other);
  }

  public override int GetHashCode() {
    return swigCPtr.Handle.GetHashCode();
  }

  public static bool operator ==(CVirtualMachineStack left, CVirtualMachineStack right) {
    return Equals(left, right);
  }

  public static bool operator !=(CVirtualMachineStack left, CVirtualMachineStack right) {
    return !Equals(left, right);
  }

  public int m_nStackPointer {
    set {
      NWNXLibPINVOKE.CVirtualMachineStack_m_nStackPointer_set(swigCPtr, value);
    } 
    get {
      int retVal = NWNXLibPINVOKE.CVirtualMachineStack_m_nStackPointer_get(swigCPtr);
      return retVal;
    }

  }

  public int m_nBasePointer {
    set {
      NWNXLibPINVOKE.CVirtualMachineStack_m_nBasePointer_set(swigCPtr, value);
    } 
    get {
      int retVal = NWNXLibPINVOKE.CVirtualMachineStack_m_nBasePointer_get(swigCPtr);
      return retVal;
    }

  }

  public int m_nTotalSize {
    set {
      NWNXLibPINVOKE.CVirtualMachineStack_m_nTotalSize_set(swigCPtr, value);
    } 
    get {
      int retVal = NWNXLibPINVOKE.CVirtualMachineStack_m_nTotalSize_get(swigCPtr);
      return retVal;
    }

  }

  public byte* m_pchStackTypes {
    set {
      NWNXLibPINVOKE.CVirtualMachineStack_m_pchStackTypes_set(swigCPtr, value);
    } 
    get {
      byte* retVal = NWNXLibPINVOKE.CVirtualMachineStack_m_pchStackTypes_get(swigCPtr);
      return retVal;
    }

  }

  public StackElement m_pStackNodes {
    set {
      NWNXLibPINVOKE.CVirtualMachineStack_m_pStackNodes_set(swigCPtr, StackElement.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = NWNXLibPINVOKE.CVirtualMachineStack_m_pStackNodes_get(swigCPtr);
      StackElement ret = (cPtr == global::System.IntPtr.Zero) ? null : new StackElement(cPtr, false);
      return ret;
    } 
  }

  public CVirtualMachine m_pVMachine {
    set {
      NWNXLibPINVOKE.CVirtualMachineStack_m_pVMachine_set(swigCPtr, CVirtualMachine.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = NWNXLibPINVOKE.CVirtualMachineStack_m_pVMachine_get(swigCPtr);
      CVirtualMachine ret = (cPtr == global::System.IntPtr.Zero) ? null : new CVirtualMachine(cPtr, false);
      return ret;
    } 
  }

  public CVirtualMachineStack() : this(NWNXLibPINVOKE.new_CVirtualMachineStack(), true) {
  }

  public void InitializeStack() {
    NWNXLibPINVOKE.CVirtualMachineStack_InitializeStack(swigCPtr);
  }

  public void ModifyIntegerAtLocation(int nSourceLocation, int nDelta) {
    NWNXLibPINVOKE.CVirtualMachineStack_ModifyIntegerAtLocation(swigCPtr, nSourceLocation, nDelta);
  }

  public void AssignLocationToLocation(int nSourceLocation, int nDestLocation) {
    NWNXLibPINVOKE.CVirtualMachineStack_AssignLocationToLocation(swigCPtr, nSourceLocation, nDestLocation);
  }

  public void AddToTopOfStack(int nAuxCode) {
    NWNXLibPINVOKE.CVirtualMachineStack_AddToTopOfStack(swigCPtr, nAuxCode);
  }

  public void CopyFromStack(CVirtualMachineStack pStack, int nStackSizeToSave, int nBaseStackSizeToSave) {
    NWNXLibPINVOKE.CVirtualMachineStack_CopyFromStack(swigCPtr, CVirtualMachineStack.getCPtr(pStack), nStackSizeToSave, nBaseStackSizeToSave);
  }

  public int SaveStack(CResGFF pRes, CResStruct pStruct) {
    int retVal = NWNXLibPINVOKE.CVirtualMachineStack_SaveStack(swigCPtr, CResGFF.getCPtr(pRes), CResStruct.getCPtr(pStruct));
    return retVal;
  }

  public int LoadStack(CResGFF pRes, CResStruct pStruct) {
    int retVal = NWNXLibPINVOKE.CVirtualMachineStack_LoadStack(swigCPtr, CResGFF.getCPtr(pRes), CResStruct.getCPtr(pStruct));
    return retVal;
  }

  public void ClearStack() {
    NWNXLibPINVOKE.CVirtualMachineStack_ClearStack(swigCPtr);
  }

  public int GetBasePointer() {
    int retVal = NWNXLibPINVOKE.CVirtualMachineStack_GetBasePointer(swigCPtr);
    return retVal;
  }

  public void SetBasePointer(int nSize) {
    NWNXLibPINVOKE.CVirtualMachineStack_SetBasePointer(swigCPtr, nSize);
  }

  public int GetStackPointer() {
    int retVal = NWNXLibPINVOKE.CVirtualMachineStack_GetStackPointer(swigCPtr);
    return retVal;
  }

  public void SetStackPointer(int nSize) {
    NWNXLibPINVOKE.CVirtualMachineStack_SetStackPointer(swigCPtr, nSize);
  }

  public void _Destructor() {
    NWNXLibPINVOKE.CVirtualMachineStack__Destructor(swigCPtr);
  }

}

}

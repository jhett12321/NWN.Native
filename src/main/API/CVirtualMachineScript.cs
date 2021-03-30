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

public unsafe class CVirtualMachineScript : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  public CVirtualMachineScript(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  public CVirtualMachineScript(void* cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, (global::System.IntPtr)cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(CVirtualMachineScript obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~CVirtualMachineScript() {
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
          NWNXLibPINVOKE.delete_CVirtualMachineScript(swigCPtr);
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

  public static unsafe implicit operator void*(CVirtualMachineScript self) {
    return (void*)self.swigCPtr.Handle;
  }

  public static implicit operator global::System.IntPtr(CVirtualMachineScript self) {
    return self.swigCPtr.Handle;
  }

  public bool Equals(CVirtualMachineScript other) {
    if (ReferenceEquals(null, other)) {
      return false;
    }

    if (ReferenceEquals(this, other)) {
      return true;
    }

    return Pointer.Equals(other.Pointer);
  }

  public override bool Equals(object obj) {
    return ReferenceEquals(this, obj) || obj is CVirtualMachineScript other && Equals(other);
  }

  public override int GetHashCode() {
    return swigCPtr.Handle.GetHashCode();
  }

  public static bool operator ==(CVirtualMachineScript left, CVirtualMachineScript right) {
    return Equals(left, right);
  }

  public static bool operator !=(CVirtualMachineScript left, CVirtualMachineScript right) {
    return !Equals(left, right);
  }

  public CVirtualMachineStack m_pStack {
    set {
      NWNXLibPINVOKE.CVirtualMachineScript_m_pStack_set(swigCPtr, CVirtualMachineStack.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = NWNXLibPINVOKE.CVirtualMachineScript_m_pStack_get(swigCPtr);
      CVirtualMachineStack ret = (cPtr == global::System.IntPtr.Zero) ? null : new CVirtualMachineStack(cPtr, false);
      return ret;
    } 
  }

  public int m_nStackSize {
    set {
      NWNXLibPINVOKE.CVirtualMachineScript_m_nStackSize_set(swigCPtr, value);
    } 
    get {
      int ret = NWNXLibPINVOKE.CVirtualMachineScript_m_nStackSize_get(swigCPtr);
      return ret;
    } 
  }

  public int m_nInstructPtr {
    set {
      NWNXLibPINVOKE.CVirtualMachineScript_m_nInstructPtr_set(swigCPtr, value);
    } 
    get {
      int ret = NWNXLibPINVOKE.CVirtualMachineScript_m_nInstructPtr_get(swigCPtr);
      return ret;
    } 
  }

  public int m_nSecondaryInstructPtr {
    set {
      NWNXLibPINVOKE.CVirtualMachineScript_m_nSecondaryInstructPtr_set(swigCPtr, value);
    } 
    get {
      int ret = NWNXLibPINVOKE.CVirtualMachineScript_m_nSecondaryInstructPtr_get(swigCPtr);
      return ret;
    } 
  }

  public CExoString m_sScriptName {
    set {
      NWNXLibPINVOKE.CVirtualMachineScript_m_sScriptName_set(swigCPtr, CExoString.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = NWNXLibPINVOKE.CVirtualMachineScript_m_sScriptName_get(swigCPtr);
      CExoString ret = (cPtr == global::System.IntPtr.Zero) ? null : new CExoString(cPtr, false);
      return ret;
    } 
  }

  public SWIGTYPE_p_DataBlockRef m_pCode {
    set {
      NWNXLibPINVOKE.CVirtualMachineScript_m_pCode_set(swigCPtr, SWIGTYPE_p_DataBlockRef.getCPtr(value));
      if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      SWIGTYPE_p_DataBlockRef ret = new SWIGTYPE_p_DataBlockRef(NWNXLibPINVOKE.CVirtualMachineScript_m_pCode_get(swigCPtr), true);
      if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public int m_nScriptEventID {
    set {
      NWNXLibPINVOKE.CVirtualMachineScript_m_nScriptEventID_set(swigCPtr, value);
    } 
    get {
      int ret = NWNXLibPINVOKE.CVirtualMachineScript_m_nScriptEventID_get(swigCPtr);
      return ret;
    } 
  }

  public CVirtualMachineScript() : this(NWNXLibPINVOKE.new_CVirtualMachineScript(), true) {
  }

}

}

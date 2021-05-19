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

public unsafe class CVirtualMachineScriptArray : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal CVirtualMachineScriptArray(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(CVirtualMachineScriptArray obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~CVirtualMachineScriptArray() {
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
          NWNXLibPINVOKE.delete_CVirtualMachineScriptArray(swigCPtr);
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

  public static unsafe implicit operator void*(CVirtualMachineScriptArray self) {
    return (void*)self.swigCPtr.Handle;
  }

  public static unsafe CVirtualMachineScriptArray FromPointer(void* pointer, bool memoryOwn = false) {
    return pointer != null ? new CVirtualMachineScriptArray((global::System.IntPtr)pointer, memoryOwn) : null;
  }

  public static CVirtualMachineScriptArray FromPointer(global::System.IntPtr pointer, bool memoryOwn = false) {
    return pointer != global::System.IntPtr.Zero ? new CVirtualMachineScriptArray(pointer, memoryOwn) : null;
  }

  public bool Equals(CVirtualMachineScriptArray other) {
    if (ReferenceEquals(null, other)) {
      return false;
    }

    if (ReferenceEquals(this, other)) {
      return true;
    }

    return Pointer.Equals(other.Pointer);
  }

  public override bool Equals(object obj) {
    return ReferenceEquals(this, obj) || obj is CVirtualMachineScriptArray other && Equals(other);
  }

  public override int GetHashCode() {
    return swigCPtr.Handle.GetHashCode();
  }

  public static bool operator ==(CVirtualMachineScriptArray left, CVirtualMachineScriptArray right) {
    return Equals(left, right);
  }

  public static bool operator !=(CVirtualMachineScriptArray left, CVirtualMachineScriptArray right) {
    return !Equals(left, right);
  }
/*@SWIG@*/

  public CVirtualMachineScript this[int index] {
    get {
      return GetItem(index);
    }
    set {
      SetItem(index, value);
    }
  }
  public CVirtualMachineScriptArray(int nElements) : this(NWNXLibPINVOKE.new_CVirtualMachineScriptArray(nElements), true) {
  }

  public CVirtualMachineScript GetItem(int index) {
    CVirtualMachineScript ret = new CVirtualMachineScript(NWNXLibPINVOKE.CVirtualMachineScriptArray_GetItem(swigCPtr, index), true);
    return ret;
  }

  public void SetItem(int index, CVirtualMachineScript value) {
    NWNXLibPINVOKE.CVirtualMachineScriptArray_SetItem(swigCPtr, index, CVirtualMachineScript.getCPtr(value));
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
  }

  public static CVirtualMachineScriptArray FromPointer(CVirtualMachineScript ptr) {
    global::System.IntPtr cPtr = NWNXLibPINVOKE.CVirtualMachineScriptArray_FromPointer(CVirtualMachineScript.getCPtr(ptr));
    CVirtualMachineScriptArray ret = (cPtr == global::System.IntPtr.Zero) ? null : new CVirtualMachineScriptArray(cPtr, false);
    return ret;
  }

}

}

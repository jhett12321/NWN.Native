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

public unsafe class CVirtualMachineFile : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal CVirtualMachineFile(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(CVirtualMachineFile obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~CVirtualMachineFile() {
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
          NWNXLibPINVOKE.delete_CVirtualMachineFile(swigCPtr);
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

  public static unsafe implicit operator void*(CVirtualMachineFile self) {
    return (void*)self.swigCPtr.Handle;
  }

  public static unsafe CVirtualMachineFile FromPointer(void* pointer, bool memoryOwn = false) {
    return pointer != null ? new CVirtualMachineFile((global::System.IntPtr)pointer, memoryOwn) : null;
  }

  public static CVirtualMachineFile FromPointer(global::System.IntPtr pointer, bool memoryOwn = false) {
    return pointer != global::System.IntPtr.Zero ? new CVirtualMachineFile(pointer, memoryOwn) : null;
  }

  public bool Equals(CVirtualMachineFile other) {
    if (ReferenceEquals(null, other)) {
      return false;
    }

    if (ReferenceEquals(this, other)) {
      return true;
    }

    return Pointer.Equals(other.Pointer);
  }

  public override bool Equals(object obj) {
    return ReferenceEquals(this, obj) || obj is CVirtualMachineFile other && Equals(other);
  }

  public override int GetHashCode() {
    return swigCPtr.Handle.GetHashCode();
  }

  public static bool operator ==(CVirtualMachineFile left, CVirtualMachineFile right) {
    return Equals(left, right);
  }

  public static bool operator !=(CVirtualMachineFile left, CVirtualMachineFile right) {
    return !Equals(left, right);
  }
/*@SWIG@*/
  public CVirtualMachineFile() : this(NWNXLibPINVOKE.new_CVirtualMachineFile(), true) {
  }

  public int LoadFile(CExoString sFileName) {
    int retVal = NWNXLibPINVOKE.CVirtualMachineFile_LoadFile(swigCPtr, CExoString.getCPtr(sFileName));
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
    return retVal;
  }

  public void UnloadFile() {
    NWNXLibPINVOKE.CVirtualMachineFile_UnloadFile(swigCPtr);
  }

  public void GetData(byte** pData, uint* nSize) {
    NWNXLibPINVOKE.CVirtualMachineFile_GetData(swigCPtr, (global::System.IntPtr)pData, (global::System.IntPtr)nSize);
  }

}

}

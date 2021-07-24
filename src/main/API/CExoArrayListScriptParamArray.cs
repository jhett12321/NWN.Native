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

public unsafe class CExoArrayListScriptParamArray : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal CExoArrayListScriptParamArray(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(CExoArrayListScriptParamArray obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~CExoArrayListScriptParamArray() {
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
          NWNXLibPINVOKE.delete_CExoArrayListScriptParamArray(swigCPtr);
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

  public static unsafe implicit operator void*(CExoArrayListScriptParamArray self) {
    return (void*)self.swigCPtr.Handle;
  }

  public static unsafe CExoArrayListScriptParamArray FromPointer(void* pointer, bool memoryOwn = false) {
    return pointer != null ? new CExoArrayListScriptParamArray((global::System.IntPtr)pointer, memoryOwn) : null;
  }

  public static CExoArrayListScriptParamArray FromPointer(global::System.IntPtr pointer, bool memoryOwn = false) {
    return pointer != global::System.IntPtr.Zero ? new CExoArrayListScriptParamArray(pointer, memoryOwn) : null;
  }

  public bool Equals(CExoArrayListScriptParamArray other) {
    if (ReferenceEquals(null, other)) {
      return false;
    }

    if (ReferenceEquals(this, other)) {
      return true;
    }

    return Pointer.Equals(other.Pointer);
  }

  public override bool Equals(object obj) {
    return ReferenceEquals(this, obj) || obj is CExoArrayListScriptParamArray other && Equals(other);
  }

  public override int GetHashCode() {
    return swigCPtr.Handle.GetHashCode();
  }

  public static bool operator ==(CExoArrayListScriptParamArray left, CExoArrayListScriptParamArray right) {
    return Equals(left, right);
  }

  public static bool operator !=(CExoArrayListScriptParamArray left, CExoArrayListScriptParamArray right) {
    return !Equals(left, right);
  }
/*@SWIG@*/

  public CExoArrayListScriptParam this[int index] {
    get {
      return GetItem(index);
    }
    set {
      SetItem(index, value);
    }
  }
  public CExoArrayListScriptParamArray(int nElements) : this(NWNXLibPINVOKE.new_CExoArrayListScriptParamArray(nElements), true) {
  }

  public CExoArrayListScriptParam GetItem(int index) {
    CExoArrayListScriptParam ret = new CExoArrayListScriptParam(NWNXLibPINVOKE.CExoArrayListScriptParamArray_GetItem(swigCPtr, index), true);
    return ret;
  }

  public void SetItem(int index, CExoArrayListScriptParam value) {
    NWNXLibPINVOKE.CExoArrayListScriptParamArray_SetItem(swigCPtr, index, CExoArrayListScriptParam.getCPtr(value));
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
  }

  public static CExoArrayListScriptParamArray FromPointer(CExoArrayListScriptParam ptr) {
    global::System.IntPtr cPtr = NWNXLibPINVOKE.CExoArrayListScriptParamArray_FromPointer(CExoArrayListScriptParam.getCPtr(ptr));
    CExoArrayListScriptParamArray ret = (cPtr == global::System.IntPtr.Zero) ? null : new CExoArrayListScriptParamArray(cPtr, false);
    return ret;
  }

}

}

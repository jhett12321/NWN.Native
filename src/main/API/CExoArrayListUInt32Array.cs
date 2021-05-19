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

public unsafe class CExoArrayListUInt32Array : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal CExoArrayListUInt32Array(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(CExoArrayListUInt32Array obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~CExoArrayListUInt32Array() {
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
          NWNXLibPINVOKE.delete_CExoArrayListUInt32Array(swigCPtr);
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

  public static unsafe implicit operator void*(CExoArrayListUInt32Array self) {
    return (void*)self.swigCPtr.Handle;
  }

  public static unsafe CExoArrayListUInt32Array FromPointer(void* pointer, bool memoryOwn = false) {
    return pointer != null ? new CExoArrayListUInt32Array((global::System.IntPtr)pointer, memoryOwn) : null;
  }

  public static CExoArrayListUInt32Array FromPointer(global::System.IntPtr pointer, bool memoryOwn = false) {
    return pointer != global::System.IntPtr.Zero ? new CExoArrayListUInt32Array(pointer, memoryOwn) : null;
  }

  public bool Equals(CExoArrayListUInt32Array other) {
    if (ReferenceEquals(null, other)) {
      return false;
    }

    if (ReferenceEquals(this, other)) {
      return true;
    }

    return Pointer.Equals(other.Pointer);
  }

  public override bool Equals(object obj) {
    return ReferenceEquals(this, obj) || obj is CExoArrayListUInt32Array other && Equals(other);
  }

  public override int GetHashCode() {
    return swigCPtr.Handle.GetHashCode();
  }

  public static bool operator ==(CExoArrayListUInt32Array left, CExoArrayListUInt32Array right) {
    return Equals(left, right);
  }

  public static bool operator !=(CExoArrayListUInt32Array left, CExoArrayListUInt32Array right) {
    return !Equals(left, right);
  }
/*@SWIG@*/

  public CExoArrayListUInt32 this[int index] {
    get {
      return GetItem(index);
    }
    set {
      SetItem(index, value);
    }
  }
  public CExoArrayListUInt32Array(int nElements) : this(NWNXLibPINVOKE.new_CExoArrayListUInt32Array(nElements), true) {
  }

  public CExoArrayListUInt32 GetItem(int index) {
    CExoArrayListUInt32 ret = new CExoArrayListUInt32(NWNXLibPINVOKE.CExoArrayListUInt32Array_GetItem(swigCPtr, index), true);
    return ret;
  }

  public void SetItem(int index, CExoArrayListUInt32 value) {
    NWNXLibPINVOKE.CExoArrayListUInt32Array_SetItem(swigCPtr, index, CExoArrayListUInt32.getCPtr(value));
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
  }

  public static CExoArrayListUInt32Array FromPointer(CExoArrayListUInt32 ptr) {
    global::System.IntPtr cPtr = NWNXLibPINVOKE.CExoArrayListUInt32Array_FromPointer(CExoArrayListUInt32.getCPtr(ptr));
    CExoArrayListUInt32Array ret = (cPtr == global::System.IntPtr.Zero) ? null : new CExoArrayListUInt32Array(cPtr, false);
    return ret;
  }

}

}

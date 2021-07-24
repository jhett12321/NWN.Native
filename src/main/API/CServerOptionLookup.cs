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

public unsafe class CServerOptionLookup : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal CServerOptionLookup(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(CServerOptionLookup obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~CServerOptionLookup() {
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
          NWNXLibPINVOKE.delete_CServerOptionLookup(swigCPtr);
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

  public static unsafe implicit operator void*(CServerOptionLookup self) {
    return (void*)self.swigCPtr.Handle;
  }

  public static unsafe CServerOptionLookup FromPointer(void* pointer, bool memoryOwn = false) {
    return pointer != null ? new CServerOptionLookup((global::System.IntPtr)pointer, memoryOwn) : null;
  }

  public static CServerOptionLookup FromPointer(global::System.IntPtr pointer, bool memoryOwn = false) {
    return pointer != global::System.IntPtr.Zero ? new CServerOptionLookup(pointer, memoryOwn) : null;
  }

  public bool Equals(CServerOptionLookup other) {
    if (ReferenceEquals(null, other)) {
      return false;
    }

    if (ReferenceEquals(this, other)) {
      return true;
    }

    return Pointer.Equals(other.Pointer);
  }

  public override bool Equals(object obj) {
    return ReferenceEquals(this, obj) || obj is CServerOptionLookup other && Equals(other);
  }

  public override int GetHashCode() {
    return swigCPtr.Handle.GetHashCode();
  }

  public static bool operator ==(CServerOptionLookup left, CServerOptionLookup right) {
    return Equals(left, right);
  }

  public static bool operator !=(CServerOptionLookup left, CServerOptionLookup right) {
    return !Equals(left, right);
  }
/*@SWIG@*/
  public int* pData {
    set {
      NWNXLibPINVOKE.CServerOptionLookup_pData_set(swigCPtr, value);
    } 
    get {
      int* retVal = NWNXLibPINVOKE.CServerOptionLookup_pData_get(swigCPtr);
      return retVal;
    }

  }

  public int nType {
    set {
      NWNXLibPINVOKE.CServerOptionLookup_nType_set(swigCPtr, value);
    } 
    get {
      int retVal = NWNXLibPINVOKE.CServerOptionLookup_nType_get(swigCPtr);
      return retVal;
    }

  }

  public CServerOptionLookup() : this(NWNXLibPINVOKE.new_CServerOptionLookup(), true) {
  }

}

}

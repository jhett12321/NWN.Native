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

public unsafe class CResGFFStruct : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal CResGFFStruct(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(CResGFFStruct obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~CResGFFStruct() {
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
          NWNXLibPINVOKE.delete_CResGFFStruct(swigCPtr);
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

  public static unsafe implicit operator void*(CResGFFStruct self) {
    return (void*)self.swigCPtr.Handle;
  }

  public static unsafe CResGFFStruct FromPointer(void* pointer, bool memoryOwn = false) {
    return pointer != null ? new CResGFFStruct((global::System.IntPtr)pointer, memoryOwn) : null;
  }

  public static CResGFFStruct FromPointer(global::System.IntPtr pointer, bool memoryOwn = false) {
    return pointer != global::System.IntPtr.Zero ? new CResGFFStruct(pointer, memoryOwn) : null;
  }

  public bool Equals(CResGFFStruct other) {
    if (ReferenceEquals(null, other)) {
      return false;
    }

    if (ReferenceEquals(this, other)) {
      return true;
    }

    return Pointer.Equals(other.Pointer);
  }

  public override bool Equals(object obj) {
    return ReferenceEquals(this, obj) || obj is CResGFFStruct other && Equals(other);
  }

  public override int GetHashCode() {
    return swigCPtr.Handle.GetHashCode();
  }

  public static bool operator ==(CResGFFStruct left, CResGFFStruct right) {
    return Equals(left, right);
  }

  public static bool operator !=(CResGFFStruct left, CResGFFStruct right) {
    return !Equals(left, right);
  }
/*@SWIG@*/
  public uint m_nType {
    set {
      NWNXLibPINVOKE.CResGFFStruct_m_nType_set(swigCPtr, value);
    } 
    get {
      uint ret = NWNXLibPINVOKE.CResGFFStruct_m_nType_get(swigCPtr);
      return ret;
    } 
  }

  public uint m_nDataOrDataOffset {
    set {
      NWNXLibPINVOKE.CResGFFStruct_m_nDataOrDataOffset_set(swigCPtr, value);
    } 
    get {
      uint ret = NWNXLibPINVOKE.CResGFFStruct_m_nDataOrDataOffset_get(swigCPtr);
      return ret;
    } 
  }

  public uint m_nFieldCount {
    set {
      NWNXLibPINVOKE.CResGFFStruct_m_nFieldCount_set(swigCPtr, value);
    } 
    get {
      uint ret = NWNXLibPINVOKE.CResGFFStruct_m_nFieldCount_get(swigCPtr);
      return ret;
    } 
  }

  public CResGFFStruct() : this(NWNXLibPINVOKE.new_CResGFFStruct(), true) {
  }

}

}

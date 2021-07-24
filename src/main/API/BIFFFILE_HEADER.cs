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

public unsafe class BIFFFILE_HEADER : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal BIFFFILE_HEADER(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(BIFFFILE_HEADER obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~BIFFFILE_HEADER() {
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
          NWNXLibPINVOKE.delete_BIFFFILE_HEADER(swigCPtr);
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

  public static unsafe implicit operator void*(BIFFFILE_HEADER self) {
    return (void*)self.swigCPtr.Handle;
  }

  public static unsafe BIFFFILE_HEADER FromPointer(void* pointer, bool memoryOwn = false) {
    return pointer != null ? new BIFFFILE_HEADER((global::System.IntPtr)pointer, memoryOwn) : null;
  }

  public static BIFFFILE_HEADER FromPointer(global::System.IntPtr pointer, bool memoryOwn = false) {
    return pointer != global::System.IntPtr.Zero ? new BIFFFILE_HEADER(pointer, memoryOwn) : null;
  }

  public bool Equals(BIFFFILE_HEADER other) {
    if (ReferenceEquals(null, other)) {
      return false;
    }

    if (ReferenceEquals(this, other)) {
      return true;
    }

    return Pointer.Equals(other.Pointer);
  }

  public override bool Equals(object obj) {
    return ReferenceEquals(this, obj) || obj is BIFFFILE_HEADER other && Equals(other);
  }

  public override int GetHashCode() {
    return swigCPtr.Handle.GetHashCode();
  }

  public static bool operator ==(BIFFFILE_HEADER left, BIFFFILE_HEADER right) {
    return Equals(left, right);
  }

  public static bool operator !=(BIFFFILE_HEADER left, BIFFFILE_HEADER right) {
    return !Equals(left, right);
  }
/*@SWIG@*/
  public uint nFileType {
    set {
      NWNXLibPINVOKE.BIFFFILE_HEADER_nFileType_set(swigCPtr, value);
    } 
    get {
      uint retVal = NWNXLibPINVOKE.BIFFFILE_HEADER_nFileType_get(swigCPtr);
      return retVal;
    }

  }

  public uint nFileVersion {
    set {
      NWNXLibPINVOKE.BIFFFILE_HEADER_nFileVersion_set(swigCPtr, value);
    } 
    get {
      uint retVal = NWNXLibPINVOKE.BIFFFILE_HEADER_nFileVersion_get(swigCPtr);
      return retVal;
    }

  }

  public uint nNumVariableResources {
    set {
      NWNXLibPINVOKE.BIFFFILE_HEADER_nNumVariableResources_set(swigCPtr, value);
    } 
    get {
      uint retVal = NWNXLibPINVOKE.BIFFFILE_HEADER_nNumVariableResources_get(swigCPtr);
      return retVal;
    }

  }

  public uint nNumFixedResources {
    set {
      NWNXLibPINVOKE.BIFFFILE_HEADER_nNumFixedResources_set(swigCPtr, value);
    } 
    get {
      uint retVal = NWNXLibPINVOKE.BIFFFILE_HEADER_nNumFixedResources_get(swigCPtr);
      return retVal;
    }

  }

  public uint nTableOffset {
    set {
      NWNXLibPINVOKE.BIFFFILE_HEADER_nTableOffset_set(swigCPtr, value);
    } 
    get {
      uint retVal = NWNXLibPINVOKE.BIFFFILE_HEADER_nTableOffset_get(swigCPtr);
      return retVal;
    }

  }

  public NativeArray<byte> cOid {
    set {
      NWNXLibPINVOKE.BIFFFILE_HEADER_cOid_set(swigCPtr, value);
    } 
    get {
      global::System.IntPtr arrayPtr = NWNXLibPINVOKE.BIFFFILE_HEADER_cOid_get(swigCPtr);
      NativeArray<byte> retVal = new NativeArray<byte>(arrayPtr, 24);

      return retVal; // byte[24]
    }

  }

  public NativeArray<byte> pReserved {
    set {
      NWNXLibPINVOKE.BIFFFILE_HEADER_pReserved_set(swigCPtr, value);
    } 
    get {
      global::System.IntPtr arrayPtr = NWNXLibPINVOKE.BIFFFILE_HEADER_pReserved_get(swigCPtr);
      NativeArray<byte> retVal = new NativeArray<byte>(arrayPtr, 8);

      return retVal; // byte[8]
    }

  }

  public BIFFFILE_HEADER() : this(NWNXLibPINVOKE.new_BIFFFILE_HEADER(), true) {
  }

}

}

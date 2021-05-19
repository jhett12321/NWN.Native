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

public unsafe class CResGFFFileHeader : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal CResGFFFileHeader(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(CResGFFFileHeader obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~CResGFFFileHeader() {
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
          NWNXLibPINVOKE.delete_CResGFFFileHeader(swigCPtr);
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

  public static unsafe implicit operator void*(CResGFFFileHeader self) {
    return (void*)self.swigCPtr.Handle;
  }

  public static unsafe CResGFFFileHeader FromPointer(void* pointer, bool memoryOwn = false) {
    return pointer != null ? new CResGFFFileHeader((global::System.IntPtr)pointer, memoryOwn) : null;
  }

  public static CResGFFFileHeader FromPointer(global::System.IntPtr pointer, bool memoryOwn = false) {
    return pointer != global::System.IntPtr.Zero ? new CResGFFFileHeader(pointer, memoryOwn) : null;
  }

  public bool Equals(CResGFFFileHeader other) {
    if (ReferenceEquals(null, other)) {
      return false;
    }

    if (ReferenceEquals(this, other)) {
      return true;
    }

    return Pointer.Equals(other.Pointer);
  }

  public override bool Equals(object obj) {
    return ReferenceEquals(this, obj) || obj is CResGFFFileHeader other && Equals(other);
  }

  public override int GetHashCode() {
    return swigCPtr.Handle.GetHashCode();
  }

  public static bool operator ==(CResGFFFileHeader left, CResGFFFileHeader right) {
    return Equals(left, right);
  }

  public static bool operator !=(CResGFFFileHeader left, CResGFFFileHeader right) {
    return !Equals(left, right);
  }
/*@SWIG@*/
  public uint m_nFileType {
    set {
      NWNXLibPINVOKE.CResGFFFileHeader_m_nFileType_set(swigCPtr, value);
    } 
    get {
      uint ret = NWNXLibPINVOKE.CResGFFFileHeader_m_nFileType_get(swigCPtr);
      return ret;
    } 
  }

  public uint m_nFileVersion {
    set {
      NWNXLibPINVOKE.CResGFFFileHeader_m_nFileVersion_set(swigCPtr, value);
    } 
    get {
      uint ret = NWNXLibPINVOKE.CResGFFFileHeader_m_nFileVersion_get(swigCPtr);
      return ret;
    } 
  }

  public uint m_nStructOffset {
    set {
      NWNXLibPINVOKE.CResGFFFileHeader_m_nStructOffset_set(swigCPtr, value);
    } 
    get {
      uint ret = NWNXLibPINVOKE.CResGFFFileHeader_m_nStructOffset_get(swigCPtr);
      return ret;
    } 
  }

  public uint m_nStructCount {
    set {
      NWNXLibPINVOKE.CResGFFFileHeader_m_nStructCount_set(swigCPtr, value);
    } 
    get {
      uint ret = NWNXLibPINVOKE.CResGFFFileHeader_m_nStructCount_get(swigCPtr);
      return ret;
    } 
  }

  public uint m_nFieldOffset {
    set {
      NWNXLibPINVOKE.CResGFFFileHeader_m_nFieldOffset_set(swigCPtr, value);
    } 
    get {
      uint ret = NWNXLibPINVOKE.CResGFFFileHeader_m_nFieldOffset_get(swigCPtr);
      return ret;
    } 
  }

  public uint m_nFieldCount {
    set {
      NWNXLibPINVOKE.CResGFFFileHeader_m_nFieldCount_set(swigCPtr, value);
    } 
    get {
      uint ret = NWNXLibPINVOKE.CResGFFFileHeader_m_nFieldCount_get(swigCPtr);
      return ret;
    } 
  }

  public uint m_nLabelOffset {
    set {
      NWNXLibPINVOKE.CResGFFFileHeader_m_nLabelOffset_set(swigCPtr, value);
    } 
    get {
      uint ret = NWNXLibPINVOKE.CResGFFFileHeader_m_nLabelOffset_get(swigCPtr);
      return ret;
    } 
  }

  public uint m_nLabelCount {
    set {
      NWNXLibPINVOKE.CResGFFFileHeader_m_nLabelCount_set(swigCPtr, value);
    } 
    get {
      uint ret = NWNXLibPINVOKE.CResGFFFileHeader_m_nLabelCount_get(swigCPtr);
      return ret;
    } 
  }

  public uint m_nDataFieldOffset {
    set {
      NWNXLibPINVOKE.CResGFFFileHeader_m_nDataFieldOffset_set(swigCPtr, value);
    } 
    get {
      uint ret = NWNXLibPINVOKE.CResGFFFileHeader_m_nDataFieldOffset_get(swigCPtr);
      return ret;
    } 
  }

  public uint m_nDataFieldCount {
    set {
      NWNXLibPINVOKE.CResGFFFileHeader_m_nDataFieldCount_set(swigCPtr, value);
    } 
    get {
      uint ret = NWNXLibPINVOKE.CResGFFFileHeader_m_nDataFieldCount_get(swigCPtr);
      return ret;
    } 
  }

  public uint m_nDataLayoutFieldOffset {
    set {
      NWNXLibPINVOKE.CResGFFFileHeader_m_nDataLayoutFieldOffset_set(swigCPtr, value);
    } 
    get {
      uint ret = NWNXLibPINVOKE.CResGFFFileHeader_m_nDataLayoutFieldOffset_get(swigCPtr);
      return ret;
    } 
  }

  public uint m_nDataLayoutFieldCount {
    set {
      NWNXLibPINVOKE.CResGFFFileHeader_m_nDataLayoutFieldCount_set(swigCPtr, value);
    } 
    get {
      uint ret = NWNXLibPINVOKE.CResGFFFileHeader_m_nDataLayoutFieldCount_get(swigCPtr);
      return ret;
    } 
  }

  public uint m_nDataLayoutListOffset {
    set {
      NWNXLibPINVOKE.CResGFFFileHeader_m_nDataLayoutListOffset_set(swigCPtr, value);
    } 
    get {
      uint ret = NWNXLibPINVOKE.CResGFFFileHeader_m_nDataLayoutListOffset_get(swigCPtr);
      return ret;
    } 
  }

  public uint m_nDataLayoutListCount {
    set {
      NWNXLibPINVOKE.CResGFFFileHeader_m_nDataLayoutListCount_set(swigCPtr, value);
    } 
    get {
      uint ret = NWNXLibPINVOKE.CResGFFFileHeader_m_nDataLayoutListCount_get(swigCPtr);
      return ret;
    } 
  }

  public CResGFFFileHeader() : this(NWNXLibPINVOKE.new_CResGFFFileHeader(), true) {
  }

}

}

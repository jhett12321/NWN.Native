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

public unsafe class MaterialShaderParam : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal MaterialShaderParam(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(MaterialShaderParam obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~MaterialShaderParam() {
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
          NWNXLibPINVOKE.delete_MaterialShaderParam(swigCPtr);
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

  public static unsafe implicit operator void*(MaterialShaderParam self) {
    return (void*)self.swigCPtr.Handle;
  }

  public static unsafe MaterialShaderParam FromPointer(void* pointer, bool memoryOwn = false) {
    return pointer != null ? new MaterialShaderParam((global::System.IntPtr)pointer, memoryOwn) : null;
  }

  public static MaterialShaderParam FromPointer(global::System.IntPtr pointer, bool memoryOwn = false) {
    return pointer != global::System.IntPtr.Zero ? new MaterialShaderParam(pointer, memoryOwn) : null;
  }

  public bool Equals(MaterialShaderParam other) {
    if (ReferenceEquals(null, other)) {
      return false;
    }

    if (ReferenceEquals(this, other)) {
      return true;
    }

    return Pointer.Equals(other.Pointer);
  }

  public override bool Equals(object obj) {
    return ReferenceEquals(this, obj) || obj is MaterialShaderParam other && Equals(other);
  }

  public override int GetHashCode() {
    return swigCPtr.Handle.GetHashCode();
  }

  public static bool operator ==(MaterialShaderParam left, MaterialShaderParam right) {
    return Equals(left, right);
  }

  public static bool operator !=(MaterialShaderParam left, MaterialShaderParam right) {
    return !Equals(left, right);
  }

  public int m_nType {
    set {
      NWNXLibPINVOKE.MaterialShaderParam_m_nType_set(swigCPtr, value);
    } 
    get {
      int retVal = NWNXLibPINVOKE.MaterialShaderParam_m_nType_get(swigCPtr);
      return retVal;
    }

  }

  public NativeArray<byte> m_sMaterialName {
    set {
      NWNXLibPINVOKE.MaterialShaderParam_m_sMaterialName_set(swigCPtr, value);
    } 
    get {
      global::System.IntPtr arrayPtr = NWNXLibPINVOKE.MaterialShaderParam_m_sMaterialName_get(swigCPtr);
      NativeArray<byte> retVal = new NativeArray<byte>(arrayPtr, 16+1);

      return retVal; // byte[16+1]
    }

  }

  public NativeArray<byte> m_sParamName {
    set {
      NWNXLibPINVOKE.MaterialShaderParam_m_sParamName_set(swigCPtr, value);
    } 
    get {
      global::System.IntPtr arrayPtr = NWNXLibPINVOKE.MaterialShaderParam_m_sParamName_get(swigCPtr);
      NativeArray<byte> retVal = new NativeArray<byte>(arrayPtr, 64+1);

      return retVal; // byte[64+1]
    }

  }

  public int m_nValue {
    set {
      NWNXLibPINVOKE.MaterialShaderParam_m_nValue_set(swigCPtr, value);
    } 
    get {
      int retVal = NWNXLibPINVOKE.MaterialShaderParam_m_nValue_get(swigCPtr);
      return retVal;
    }

  }

  public float m_fValue1 {
    set {
      NWNXLibPINVOKE.MaterialShaderParam_m_fValue1_set(swigCPtr, value);
    } 
    get {
      float retVal = NWNXLibPINVOKE.MaterialShaderParam_m_fValue1_get(swigCPtr);
      return retVal;
    }

  }

  public float m_fValue2 {
    set {
      NWNXLibPINVOKE.MaterialShaderParam_m_fValue2_set(swigCPtr, value);
    } 
    get {
      float retVal = NWNXLibPINVOKE.MaterialShaderParam_m_fValue2_get(swigCPtr);
      return retVal;
    }

  }

  public float m_fValue3 {
    set {
      NWNXLibPINVOKE.MaterialShaderParam_m_fValue3_set(swigCPtr, value);
    } 
    get {
      float retVal = NWNXLibPINVOKE.MaterialShaderParam_m_fValue3_get(swigCPtr);
      return retVal;
    }

  }

  public float m_fValue4 {
    set {
      NWNXLibPINVOKE.MaterialShaderParam_m_fValue4_set(swigCPtr, value);
    } 
    get {
      float retVal = NWNXLibPINVOKE.MaterialShaderParam_m_fValue4_get(swigCPtr);
      return retVal;
    }

  }

  public MaterialShaderParam() : this(NWNXLibPINVOKE.new_MaterialShaderParam(), true) {
  }

}

}

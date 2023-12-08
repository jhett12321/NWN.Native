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

public unsafe class CNWSAreaGrassOverride : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal CNWSAreaGrassOverride(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(CNWSAreaGrassOverride obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~CNWSAreaGrassOverride() {
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
          NWNXLibPINVOKE.delete_CNWSAreaGrassOverride(swigCPtr);
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

  public static unsafe implicit operator void*(CNWSAreaGrassOverride self) {
    return (void*)self.swigCPtr.Handle;
  }

  public static unsafe CNWSAreaGrassOverride FromPointer(void* pointer, bool memoryOwn = false) {
    return pointer != null ? new CNWSAreaGrassOverride((global::System.IntPtr)pointer, memoryOwn) : null;
  }

  public static CNWSAreaGrassOverride FromPointer(global::System.IntPtr pointer, bool memoryOwn = false) {
    return pointer != global::System.IntPtr.Zero ? new CNWSAreaGrassOverride(pointer, memoryOwn) : null;
  }

  public bool Equals(CNWSAreaGrassOverride other) {
    if (ReferenceEquals(null, other)) {
      return false;
    }

    if (ReferenceEquals(this, other)) {
      return true;
    }

    return Pointer.Equals(other.Pointer);
  }

  public override bool Equals(object obj) {
    return ReferenceEquals(this, obj) || obj is CNWSAreaGrassOverride other && Equals(other);
  }

  public override int GetHashCode() {
    return swigCPtr.Handle.GetHashCode();
  }

  public static bool operator ==(CNWSAreaGrassOverride left, CNWSAreaGrassOverride right) {
    return Equals(left, right);
  }

  public static bool operator !=(CNWSAreaGrassOverride left, CNWSAreaGrassOverride right) {
    return !Equals(left, right);
  }

  public CExoString sTexture {
    set {
      NWNXLibPINVOKE.CNWSAreaGrassOverride_sTexture_set(swigCPtr, CExoString.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = NWNXLibPINVOKE.CNWSAreaGrassOverride_sTexture_get(swigCPtr);
      CExoString ret = (cPtr == global::System.IntPtr.Zero) ? null : new CExoString(cPtr, false);
      return ret;
    } 
  }

  public float fDensity {
    set {
      NWNXLibPINVOKE.CNWSAreaGrassOverride_fDensity_set(swigCPtr, value);
    } 
    get {
      float retVal = NWNXLibPINVOKE.CNWSAreaGrassOverride_fDensity_get(swigCPtr);
      return retVal;
    }

  }

  public float fHeight {
    set {
      NWNXLibPINVOKE.CNWSAreaGrassOverride_fHeight_set(swigCPtr, value);
    } 
    get {
      float retVal = NWNXLibPINVOKE.CNWSAreaGrassOverride_fHeight_get(swigCPtr);
      return retVal;
    }

  }

  public Vector vAmbient {
    set {
      NWNXLibPINVOKE.CNWSAreaGrassOverride_vAmbient_set(swigCPtr, Vector.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = NWNXLibPINVOKE.CNWSAreaGrassOverride_vAmbient_get(swigCPtr);
      Vector ret = (cPtr == global::System.IntPtr.Zero) ? null : new Vector(cPtr, false);
      return ret;
    } 
  }

  public Vector vDiffuse {
    set {
      NWNXLibPINVOKE.CNWSAreaGrassOverride_vDiffuse_set(swigCPtr, Vector.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = NWNXLibPINVOKE.CNWSAreaGrassOverride_vDiffuse_get(swigCPtr);
      Vector ret = (cPtr == global::System.IntPtr.Zero) ? null : new Vector(cPtr, false);
      return ret;
    } 
  }

  public CNWSAreaGrassOverride() : this(NWNXLibPINVOKE.new_CNWSAreaGrassOverride(), true) {
  }

}

}

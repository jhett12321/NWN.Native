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

public unsafe class CEncounterSpawnPoint : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal CEncounterSpawnPoint(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(CEncounterSpawnPoint obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~CEncounterSpawnPoint() {
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
          NWNXLibPINVOKE.delete_CEncounterSpawnPoint(swigCPtr);
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

  public static unsafe implicit operator void*(CEncounterSpawnPoint self) {
    return (void*)self.swigCPtr.Handle;
  }

  public static unsafe CEncounterSpawnPoint FromPointer(void* pointer, bool memoryOwn = false) {
    return pointer != null ? new CEncounterSpawnPoint((global::System.IntPtr)pointer, memoryOwn) : null;
  }

  public static CEncounterSpawnPoint FromPointer(global::System.IntPtr pointer, bool memoryOwn = false) {
    return pointer != global::System.IntPtr.Zero ? new CEncounterSpawnPoint(pointer, memoryOwn) : null;
  }

  public bool Equals(CEncounterSpawnPoint other) {
    if (ReferenceEquals(null, other)) {
      return false;
    }

    if (ReferenceEquals(this, other)) {
      return true;
    }

    return Pointer.Equals(other.Pointer);
  }

  public override bool Equals(object obj) {
    return ReferenceEquals(this, obj) || obj is CEncounterSpawnPoint other && Equals(other);
  }

  public override int GetHashCode() {
    return swigCPtr.Handle.GetHashCode();
  }

  public static bool operator ==(CEncounterSpawnPoint left, CEncounterSpawnPoint right) {
    return Equals(left, right);
  }

  public static bool operator !=(CEncounterSpawnPoint left, CEncounterSpawnPoint right) {
    return !Equals(left, right);
  }
/*@SWIG@*/
  public Vector m_vPosition {
    set {
      NWNXLibPINVOKE.CEncounterSpawnPoint_m_vPosition_set(swigCPtr, Vector.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = NWNXLibPINVOKE.CEncounterSpawnPoint_m_vPosition_get(swigCPtr);
      Vector ret = (cPtr == global::System.IntPtr.Zero) ? null : new Vector(cPtr, false);
      return ret;
    } 
  }

  public float m_fOrientation {
    set {
      NWNXLibPINVOKE.CEncounterSpawnPoint_m_fOrientation_set(swigCPtr, value);
    } 
    get {
      float retVal = NWNXLibPINVOKE.CEncounterSpawnPoint_m_fOrientation_get(swigCPtr);
      return retVal;
    }

  }

  public CEncounterSpawnPoint() : this(NWNXLibPINVOKE.new_CEncounterSpawnPoint(), true) {
  }

}

}

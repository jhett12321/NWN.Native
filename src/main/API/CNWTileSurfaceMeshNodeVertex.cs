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

public unsafe class CNWTileSurfaceMeshNodeVertex : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal CNWTileSurfaceMeshNodeVertex(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(CNWTileSurfaceMeshNodeVertex obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~CNWTileSurfaceMeshNodeVertex() {
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
          NWNXLibPINVOKE.delete_CNWTileSurfaceMeshNodeVertex(swigCPtr);
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

  public static unsafe implicit operator void*(CNWTileSurfaceMeshNodeVertex self) {
    return (void*)self.swigCPtr.Handle;
  }

  public static unsafe CNWTileSurfaceMeshNodeVertex FromPointer(void* pointer, bool memoryOwn = false) {
    return pointer != null ? new CNWTileSurfaceMeshNodeVertex((global::System.IntPtr)pointer, memoryOwn) : null;
  }

  public static CNWTileSurfaceMeshNodeVertex FromPointer(global::System.IntPtr pointer, bool memoryOwn = false) {
    return pointer != global::System.IntPtr.Zero ? new CNWTileSurfaceMeshNodeVertex(pointer, memoryOwn) : null;
  }

  public bool Equals(CNWTileSurfaceMeshNodeVertex other) {
    if (ReferenceEquals(null, other)) {
      return false;
    }

    if (ReferenceEquals(this, other)) {
      return true;
    }

    return Pointer.Equals(other.Pointer);
  }

  public override bool Equals(object obj) {
    return ReferenceEquals(this, obj) || obj is CNWTileSurfaceMeshNodeVertex other && Equals(other);
  }

  public override int GetHashCode() {
    return swigCPtr.Handle.GetHashCode();
  }

  public static bool operator ==(CNWTileSurfaceMeshNodeVertex left, CNWTileSurfaceMeshNodeVertex right) {
    return Equals(left, right);
  }

  public static bool operator !=(CNWTileSurfaceMeshNodeVertex left, CNWTileSurfaceMeshNodeVertex right) {
    return !Equals(left, right);
  }
/*@SWIG@*/
  public float fVirtualWasteOfSpace {
    set {
      NWNXLibPINVOKE.CNWTileSurfaceMeshNodeVertex_fVirtualWasteOfSpace_set(swigCPtr, value);
    } 
    get {
      float ret = NWNXLibPINVOKE.CNWTileSurfaceMeshNodeVertex_fVirtualWasteOfSpace_get(swigCPtr);
      return ret;
    } 
  }

  public Vector vCoord {
    set {
      NWNXLibPINVOKE.CNWTileSurfaceMeshNodeVertex_vCoord_set(swigCPtr, Vector.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = NWNXLibPINVOKE.CNWTileSurfaceMeshNodeVertex_vCoord_get(swigCPtr);
      Vector ret = (cPtr == global::System.IntPtr.Zero) ? null : new Vector(cPtr, false);
      return ret;
    } 
  }

  public Vector vTexCoord {
    set {
      NWNXLibPINVOKE.CNWTileSurfaceMeshNodeVertex_vTexCoord_set(swigCPtr, Vector.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = NWNXLibPINVOKE.CNWTileSurfaceMeshNodeVertex_vTexCoord_get(swigCPtr);
      Vector ret = (cPtr == global::System.IntPtr.Zero) ? null : new Vector(cPtr, false);
      return ret;
    } 
  }

  public Vector vNormal {
    set {
      NWNXLibPINVOKE.CNWTileSurfaceMeshNodeVertex_vNormal_set(swigCPtr, Vector.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = NWNXLibPINVOKE.CNWTileSurfaceMeshNodeVertex_vNormal_get(swigCPtr);
      Vector ret = (cPtr == global::System.IntPtr.Zero) ? null : new Vector(cPtr, false);
      return ret;
    } 
  }

  public CNWTileSurfaceMeshNodeVertex() : this(NWNXLibPINVOKE.new_CNWTileSurfaceMeshNodeVertex(), true) {
  }

}

}

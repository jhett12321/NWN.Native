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

public unsafe class CNWTileSurfaceMeshNodeFace : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  public CNWTileSurfaceMeshNodeFace(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  public CNWTileSurfaceMeshNodeFace(void* cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, (global::System.IntPtr)cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(CNWTileSurfaceMeshNodeFace obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~CNWTileSurfaceMeshNodeFace() {
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
          NWNXLibPINVOKE.delete_CNWTileSurfaceMeshNodeFace(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
    }
  }

  public System.IntPtr Pointer {
    get {
      return swigCPtr.Handle;
    }
  }

  public static unsafe implicit operator void*(CNWTileSurfaceMeshNodeFace self) {
    return (void*)self.swigCPtr.Handle;
  }

  public static implicit operator System.IntPtr(CNWTileSurfaceMeshNodeFace self) {
    return self.swigCPtr.Handle;
  }

  public bool Equals(CNWTileSurfaceMeshNodeFace other) {
    if (ReferenceEquals(null, other)) {
      return false;
    }

    if (ReferenceEquals(this, other)) {
      return true;
    }

    return Pointer.Equals(other.Pointer);
  }

  public override bool Equals(object obj) {
    return ReferenceEquals(this, obj) || obj is CNWTileSurfaceMeshNodeFace other && Equals(other);
  }

  public override int GetHashCode() {
    return swigCPtr.Handle.GetHashCode();
  }

  public static bool operator ==(CNWTileSurfaceMeshNodeFace left, CNWTileSurfaceMeshNodeFace right) {
    return Equals(left, right);
  }

  public static bool operator !=(CNWTileSurfaceMeshNodeFace left, CNWTileSurfaceMeshNodeFace right) {
    return !Equals(left, right);
  }

  public int* pnUselessPointer1 {
    set {
      NWNXLibPINVOKE.CNWTileSurfaceMeshNodeFace_pnUselessPointer1_set(swigCPtr, (global::System.IntPtr)value);
    }  
    get {
        System.IntPtr retVal = NWNXLibPINVOKE.CNWTileSurfaceMeshNodeFace_pnUselessPointer1_get(swigCPtr); 
        return (int*)retVal; 
    }

  }

  public int* pnUselessPointer2 {
    set {
      NWNXLibPINVOKE.CNWTileSurfaceMeshNodeFace_pnUselessPointer2_set(swigCPtr, (global::System.IntPtr)value);
    }  
    get {
        System.IntPtr retVal = NWNXLibPINVOKE.CNWTileSurfaceMeshNodeFace_pnUselessPointer2_get(swigCPtr); 
        return (int*)retVal; 
    }

  }

  public int* pnUselessPointer3 {
    set {
      NWNXLibPINVOKE.CNWTileSurfaceMeshNodeFace_pnUselessPointer3_set(swigCPtr, (global::System.IntPtr)value);
    }  
    get {
        System.IntPtr retVal = NWNXLibPINVOKE.CNWTileSurfaceMeshNodeFace_pnUselessPointer3_get(swigCPtr); 
        return (int*)retVal; 
    }

  }

  public int[] vertexindices {
    set {
      NWNXLibPINVOKE.CNWTileSurfaceMeshNodeFace_vertexindices_set(swigCPtr, value);
    }  
    get {
      int* arrayPtr = NWNXLibPINVOKE.CNWTileSurfaceMeshNodeFace_vertexindices_get(swigCPtr);
      int[] retVal = new int[3];

      for(int i = 0; i < 3; i++) {
        retVal[i] = arrayPtr[i];
      }

      return retVal;
    }

  }

  public int s {
    set {
      NWNXLibPINVOKE.CNWTileSurfaceMeshNodeFace_s_set(swigCPtr, value);
    } 
    get {
      int ret = NWNXLibPINVOKE.CNWTileSurfaceMeshNodeFace_s_get(swigCPtr);
      return ret;
    } 
  }

  public int matid {
    set {
      NWNXLibPINVOKE.CNWTileSurfaceMeshNodeFace_matid_set(swigCPtr, value);
    } 
    get {
      int ret = NWNXLibPINVOKE.CNWTileSurfaceMeshNodeFace_matid_get(swigCPtr);
      return ret;
    } 
  }

  public int[] neighbors {
    set {
      NWNXLibPINVOKE.CNWTileSurfaceMeshNodeFace_neighbors_set(swigCPtr, value);
    }  
    get {
      int* arrayPtr = NWNXLibPINVOKE.CNWTileSurfaceMeshNodeFace_neighbors_get(swigCPtr);
      int[] retVal = new int[3];

      for(int i = 0; i < 3; i++) {
        retVal[i] = arrayPtr[i];
      }

      return retVal;
    }

  }

  public Vector normal {
    set {
      NWNXLibPINVOKE.CNWTileSurfaceMeshNodeFace_normal_set(swigCPtr, Vector.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = NWNXLibPINVOKE.CNWTileSurfaceMeshNodeFace_normal_get(swigCPtr);
      Vector ret = (cPtr == global::System.IntPtr.Zero) ? null : new Vector(cPtr, false);
      return ret;
    } 
  }

  public float dist {
    set {
      NWNXLibPINVOKE.CNWTileSurfaceMeshNodeFace_dist_set(swigCPtr, value);
    } 
    get {
      float ret = NWNXLibPINVOKE.CNWTileSurfaceMeshNodeFace_dist_get(swigCPtr);
      return ret;
    } 
  }

  public CNWTileSurfaceMeshNodeFace() : this(NWNXLibPINVOKE.new_CNWTileSurfaceMeshNodeFace(), true) {
  }

}

}

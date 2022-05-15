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

public unsafe class CNWDoorSurfaceMesh : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal CNWDoorSurfaceMesh(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(CNWDoorSurfaceMesh obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~CNWDoorSurfaceMesh() {
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
          NWNXLibPINVOKE.delete_CNWDoorSurfaceMesh(swigCPtr);
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

  public static unsafe implicit operator void*(CNWDoorSurfaceMesh self) {
    return (void*)self.swigCPtr.Handle;
  }

  public static unsafe CNWDoorSurfaceMesh FromPointer(void* pointer, bool memoryOwn = false) {
    return pointer != null ? new CNWDoorSurfaceMesh((global::System.IntPtr)pointer, memoryOwn) : null;
  }

  public static CNWDoorSurfaceMesh FromPointer(global::System.IntPtr pointer, bool memoryOwn = false) {
    return pointer != global::System.IntPtr.Zero ? new CNWDoorSurfaceMesh(pointer, memoryOwn) : null;
  }

  public bool Equals(CNWDoorSurfaceMesh other) {
    if (ReferenceEquals(null, other)) {
      return false;
    }

    if (ReferenceEquals(this, other)) {
      return true;
    }

    return Pointer.Equals(other.Pointer);
  }

  public override bool Equals(object obj) {
    return ReferenceEquals(this, obj) || obj is CNWDoorSurfaceMesh other && Equals(other);
  }

  public override int GetHashCode() {
    return swigCPtr.Handle.GetHashCode();
  }

  public static bool operator ==(CNWDoorSurfaceMesh left, CNWDoorSurfaceMesh right) {
    return Equals(left, right);
  }

  public static bool operator !=(CNWDoorSurfaceMesh left, CNWDoorSurfaceMesh right) {
    return !Equals(left, right);
  }
/*@SWIG@*/
  public NativeArray<int> m_pnVertices {
    set {
      NWNXLibPINVOKE.CNWDoorSurfaceMesh_m_pnVertices_set(swigCPtr, value);
    } 
    get {
      global::System.IntPtr arrayPtr = NWNXLibPINVOKE.CNWDoorSurfaceMesh_m_pnVertices_get(swigCPtr);
      NativeArray<int> retVal = new NativeArray<int>(arrayPtr, 3);

      return retVal; // int[3]
    }

  }

  public NativeArray<global::System.IntPtr> m_ppfVertices {
    set {
      NWNXLibPINVOKE.CNWDoorSurfaceMesh_m_ppfVertices_set(swigCPtr, value);
    } 
    get {
      global::System.IntPtr arrayPtr = NWNXLibPINVOKE.CNWDoorSurfaceMesh_m_ppfVertices_get(swigCPtr);
      NativeArray<global::System.IntPtr> retVal = new NativeArray<global::System.IntPtr>(arrayPtr, 3);

      return retVal; // float*[3]
    }

  }

  public NativeArray<int> m_pnTriangles {
    set {
      NWNXLibPINVOKE.CNWDoorSurfaceMesh_m_pnTriangles_set(swigCPtr, value);
    } 
    get {
      global::System.IntPtr arrayPtr = NWNXLibPINVOKE.CNWDoorSurfaceMesh_m_pnTriangles_get(swigCPtr);
      NativeArray<int> retVal = new NativeArray<int>(arrayPtr, 3);

      return retVal; // int[3]
    }

  }

  public NativeArray<global::System.IntPtr> m_ppnTriangles {
    set {
      NWNXLibPINVOKE.CNWDoorSurfaceMesh_m_ppnTriangles_set(swigCPtr, value);
    } 
    get {
      global::System.IntPtr arrayPtr = NWNXLibPINVOKE.CNWDoorSurfaceMesh_m_ppnTriangles_get(swigCPtr);
      NativeArray<global::System.IntPtr> retVal = new NativeArray<global::System.IntPtr>(arrayPtr, 3);

      return retVal; // int*[3]
    }

  }

  public NativeArray<global::System.IntPtr> m_ppnTriangleMaterial {
    set {
      NWNXLibPINVOKE.CNWDoorSurfaceMesh_m_ppnTriangleMaterial_set(swigCPtr, value);
    } 
    get {
      global::System.IntPtr arrayPtr = NWNXLibPINVOKE.CNWDoorSurfaceMesh_m_ppnTriangleMaterial_get(swigCPtr);
      NativeArray<global::System.IntPtr> retVal = new NativeArray<global::System.IntPtr>(arrayPtr, 3);

      return retVal; // int*[3]
    }

  }

  public SWIGTYPE_p_a_2__Vector m_pvOpenLocations {
    set {
      NWNXLibPINVOKE.CNWDoorSurfaceMesh_m_pvOpenLocations_set(swigCPtr, SWIGTYPE_p_a_2__Vector.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = NWNXLibPINVOKE.CNWDoorSurfaceMesh_m_pvOpenLocations_get(swigCPtr);
      SWIGTYPE_p_a_2__Vector ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_a_2__Vector(cPtr, false);
      return ret;
    } 
  }

  public CNWDoorSurfaceMesh() : this(NWNXLibPINVOKE.new_CNWDoorSurfaceMesh(), true) {
  }

  public int LoadWalkMeshString(byte** pInput, uint* nInputSize, byte* pchBuffer, uint nBufferSize) {
    int retVal = NWNXLibPINVOKE.CNWDoorSurfaceMesh_LoadWalkMeshString(swigCPtr, (global::System.IntPtr)pInput, nInputSize, pchBuffer, nBufferSize);
    return retVal;
  }

  public int LoadWalkMesh(CResRef cWalkMesh) {
    int retVal = NWNXLibPINVOKE.CNWDoorSurfaceMesh_LoadWalkMesh(swigCPtr, CResRef.getCPtr(cWalkMesh));
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
    return retVal;
  }

  public int NoNonWalkPolysOnSurfaceMesh(int nDoorState, float fSourceX, float fSourceY, float fTargetX, float fTargetY, float fMinZ, float fMaxZ, float fPersonalSpace) {
    int retVal = NWNXLibPINVOKE.CNWDoorSurfaceMesh_NoNonWalkPolysOnSurfaceMesh(swigCPtr, nDoorState, fSourceX, fSourceY, fTargetX, fTargetY, fMinZ, fMaxZ, fPersonalSpace);
    return retVal;
  }

  public int IntersectLineSegments(Vector v1, Vector v2, Vector v3, Vector v4, Vector vIntersect) {
    int retVal = NWNXLibPINVOKE.CNWDoorSurfaceMesh_IntersectLineSegments(swigCPtr, Vector.getCPtr(v1), Vector.getCPtr(v2), Vector.getCPtr(v3), Vector.getCPtr(v4), Vector.getCPtr(vIntersect));
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
    return retVal;
  }

  public int GetMeshBoundingBox(Vector vPosition, Vector vOrientation, Vector vMin, Vector vMax) {
    int retVal = NWNXLibPINVOKE.CNWDoorSurfaceMesh_GetMeshBoundingBox(swigCPtr, Vector.getCPtr(vPosition), Vector.getCPtr(vOrientation), Vector.getCPtr(vMin), Vector.getCPtr(vMax));
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
    return retVal;
  }

  public void _Destructor() {
    NWNXLibPINVOKE.CNWDoorSurfaceMesh__Destructor(swigCPtr);
  }

}

}

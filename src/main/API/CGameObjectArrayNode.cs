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

public unsafe class CGameObjectArrayNode : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal CGameObjectArrayNode(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(CGameObjectArrayNode obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~CGameObjectArrayNode() {
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
          NWNXLibPINVOKE.delete_CGameObjectArrayNode(swigCPtr);
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

  public static unsafe implicit operator void*(CGameObjectArrayNode self) {
    return (void*)self.swigCPtr.Handle;
  }

  public static unsafe CGameObjectArrayNode FromPointer(void* pointer, bool memoryOwn = false) {
    return pointer != null ? new CGameObjectArrayNode((global::System.IntPtr)pointer, memoryOwn) : null;
  }

  public static CGameObjectArrayNode FromPointer(global::System.IntPtr pointer, bool memoryOwn = false) {
    return pointer != global::System.IntPtr.Zero ? new CGameObjectArrayNode(pointer, memoryOwn) : null;
  }

  public bool Equals(CGameObjectArrayNode other) {
    if (ReferenceEquals(null, other)) {
      return false;
    }

    if (ReferenceEquals(this, other)) {
      return true;
    }

    return Pointer.Equals(other.Pointer);
  }

  public override bool Equals(object obj) {
    return ReferenceEquals(this, obj) || obj is CGameObjectArrayNode other && Equals(other);
  }

  public override int GetHashCode() {
    return swigCPtr.Handle.GetHashCode();
  }

  public static bool operator ==(CGameObjectArrayNode left, CGameObjectArrayNode right) {
    return Equals(left, right);
  }

  public static bool operator !=(CGameObjectArrayNode left, CGameObjectArrayNode right) {
    return !Equals(left, right);
  }
/*@SWIG@*/
  public uint m_objectId {
    set {
      NWNXLibPINVOKE.CGameObjectArrayNode_m_objectId_set(swigCPtr, value);
    } 
    get {
      uint ret = NWNXLibPINVOKE.CGameObjectArrayNode_m_objectId_get(swigCPtr);
      return ret;
    } 
  }

  public ICGameObject m_objectPtr {
    set {
      NWNXLibPINVOKE.CGameObjectArrayNode_m_objectPtr_set(swigCPtr, value == null ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : value.GetInterfaceCPtr());
    } 
    get {
      global::System.IntPtr cPtr = NWNXLibPINVOKE.CGameObjectArrayNode_m_objectPtr_get(swigCPtr);
      CGameObject ret = (cPtr == global::System.IntPtr.Zero) ? null : new CGameObject(cPtr, false);
      return ret;
    } 
  }

  public CGameObjectArrayNode m_nextNode {
    set {
      NWNXLibPINVOKE.CGameObjectArrayNode_m_nextNode_set(swigCPtr, CGameObjectArrayNode.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = NWNXLibPINVOKE.CGameObjectArrayNode_m_nextNode_get(swigCPtr);
      CGameObjectArrayNode ret = (cPtr == global::System.IntPtr.Zero) ? null : new CGameObjectArrayNode(cPtr, false);
      return ret;
    } 
  }

  public CGameObjectArrayNode() : this(NWNXLibPINVOKE.new_CGameObjectArrayNode(), true) {
  }

}

}

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

public unsafe class CNWVisibilityNode : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal CNWVisibilityNode(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(CNWVisibilityNode obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~CNWVisibilityNode() {
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
          NWNXLibPINVOKE.delete_CNWVisibilityNode(swigCPtr);
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

  public static unsafe implicit operator void*(CNWVisibilityNode self) {
    return (void*)self.swigCPtr.Handle;
  }

  public static unsafe CNWVisibilityNode FromPointer(void* pointer, bool memoryOwn = false) {
    return pointer != null ? new CNWVisibilityNode((global::System.IntPtr)pointer, memoryOwn) : null;
  }

  public static CNWVisibilityNode FromPointer(global::System.IntPtr pointer, bool memoryOwn = false) {
    return pointer != global::System.IntPtr.Zero ? new CNWVisibilityNode(pointer, memoryOwn) : null;
  }

  public bool Equals(CNWVisibilityNode other) {
    if (ReferenceEquals(null, other)) {
      return false;
    }

    if (ReferenceEquals(this, other)) {
      return true;
    }

    return Pointer.Equals(other.Pointer);
  }

  public override bool Equals(object obj) {
    return ReferenceEquals(this, obj) || obj is CNWVisibilityNode other && Equals(other);
  }

  public override int GetHashCode() {
    return swigCPtr.Handle.GetHashCode();
  }

  public static bool operator ==(CNWVisibilityNode left, CNWVisibilityNode right) {
    return Equals(left, right);
  }

  public static bool operator !=(CNWVisibilityNode left, CNWVisibilityNode right) {
    return !Equals(left, right);
  }
/*@SWIG@*/
  public uint m_oidCreature {
    set {
      NWNXLibPINVOKE.CNWVisibilityNode_m_oidCreature_set(swigCPtr, value);
    } 
    get {
      uint ret = NWNXLibPINVOKE.CNWVisibilityNode_m_oidCreature_get(swigCPtr);
      return ret;
    } 
  }

  public byte m_bSeen {
    set {
      NWNXLibPINVOKE.CNWVisibilityNode_m_bSeen_set(swigCPtr, value);
    } 
    get {
      byte ret = NWNXLibPINVOKE.CNWVisibilityNode_m_bSeen_get(swigCPtr);
      return ret;
    } 
  }

  public byte m_bHeard {
    set {
      NWNXLibPINVOKE.CNWVisibilityNode_m_bHeard_set(swigCPtr, value);
    } 
    get {
      byte ret = NWNXLibPINVOKE.CNWVisibilityNode_m_bHeard_get(swigCPtr);
      return ret;
    } 
  }

  public byte m_nSanctuary {
    set {
      NWNXLibPINVOKE.CNWVisibilityNode_m_nSanctuary_set(swigCPtr, value);
    } 
    get {
      byte ret = NWNXLibPINVOKE.CNWVisibilityNode_m_nSanctuary_get(swigCPtr);
      return ret;
    } 
  }

  public byte m_bInvisible {
    set {
      NWNXLibPINVOKE.CNWVisibilityNode_m_bInvisible_set(swigCPtr, value);
    } 
    get {
      byte ret = NWNXLibPINVOKE.CNWVisibilityNode_m_bInvisible_get(swigCPtr);
      return ret;
    } 
  }

  public CNWVisibilityNode() : this(NWNXLibPINVOKE.new_CNWVisibilityNode(), true) {
  }

}

}

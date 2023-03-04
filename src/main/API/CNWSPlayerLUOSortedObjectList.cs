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

public unsafe class CNWSPlayerLUOSortedObjectList : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal CNWSPlayerLUOSortedObjectList(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(CNWSPlayerLUOSortedObjectList obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~CNWSPlayerLUOSortedObjectList() {
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
          NWNXLibPINVOKE.delete_CNWSPlayerLUOSortedObjectList(swigCPtr);
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

  public static unsafe implicit operator void*(CNWSPlayerLUOSortedObjectList self) {
    return (void*)self.swigCPtr.Handle;
  }

  public static unsafe CNWSPlayerLUOSortedObjectList FromPointer(void* pointer, bool memoryOwn = false) {
    return pointer != null ? new CNWSPlayerLUOSortedObjectList((global::System.IntPtr)pointer, memoryOwn) : null;
  }

  public static CNWSPlayerLUOSortedObjectList FromPointer(global::System.IntPtr pointer, bool memoryOwn = false) {
    return pointer != global::System.IntPtr.Zero ? new CNWSPlayerLUOSortedObjectList(pointer, memoryOwn) : null;
  }

  public bool Equals(CNWSPlayerLUOSortedObjectList other) {
    if (ReferenceEquals(null, other)) {
      return false;
    }

    if (ReferenceEquals(this, other)) {
      return true;
    }

    return Pointer.Equals(other.Pointer);
  }

  public override bool Equals(object obj) {
    return ReferenceEquals(this, obj) || obj is CNWSPlayerLUOSortedObjectList other && Equals(other);
  }

  public override int GetHashCode() {
    return swigCPtr.Handle.GetHashCode();
  }

  public static bool operator ==(CNWSPlayerLUOSortedObjectList left, CNWSPlayerLUOSortedObjectList right) {
    return Equals(left, right);
  }

  public static bool operator !=(CNWSPlayerLUOSortedObjectList left, CNWSPlayerLUOSortedObjectList right) {
    return !Equals(left, right);
  }

  public uint oidObject {
    set {
      NWNXLibPINVOKE.CNWSPlayerLUOSortedObjectList_oidObject_set(swigCPtr, value);
    } 
    get {
      uint retVal = NWNXLibPINVOKE.CNWSPlayerLUOSortedObjectList_oidObject_get(swigCPtr);
      return retVal;
    }

  }

  public float fDistanceToPlayer {
    set {
      NWNXLibPINVOKE.CNWSPlayerLUOSortedObjectList_fDistanceToPlayer_set(swigCPtr, value);
    } 
    get {
      float retVal = NWNXLibPINVOKE.CNWSPlayerLUOSortedObjectList_fDistanceToPlayer_get(swigCPtr);
      return retVal;
    }

  }

  public uint nCategory {
    set {
      NWNXLibPINVOKE.CNWSPlayerLUOSortedObjectList_nCategory_set(swigCPtr, value);
    } 
    get {
      uint retVal = NWNXLibPINVOKE.CNWSPlayerLUOSortedObjectList_nCategory_get(swigCPtr);
      return retVal;
    }

  }

  public CNWSPlayerLUOSortedObjectList() : this(NWNXLibPINVOKE.new_CNWSPlayerLUOSortedObjectList(), true) {
  }

}

}

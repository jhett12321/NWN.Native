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

public unsafe class CNWSInventory : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  public CNWSInventory(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  public CNWSInventory(void* cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, (global::System.IntPtr)cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(CNWSInventory obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~CNWSInventory() {
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
          NWNXLibPINVOKE.delete_CNWSInventory(swigCPtr);
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

  public static unsafe implicit operator void*(CNWSInventory self) {
    return (void*)self.swigCPtr.Handle;
  }

  public static implicit operator System.IntPtr(CNWSInventory self) {
    return self.swigCPtr.Handle;
  }

  public bool Equals(CNWSInventory other) {
    if (ReferenceEquals(null, other)) {
      return false;
    }

    if (ReferenceEquals(this, other)) {
      return true;
    }

    return Pointer.Equals(other.Pointer);
  }

  public override bool Equals(object obj) {
    return ReferenceEquals(this, obj) || obj is CNWSInventory other && Equals(other);
  }

  public override int GetHashCode() {
    return swigCPtr.Handle.GetHashCode();
  }

  public static bool operator ==(CNWSInventory left, CNWSInventory right) {
    return Equals(left, right);
  }

  public static bool operator !=(CNWSInventory left, CNWSInventory right) {
    return !Equals(left, right);
  }

  public uint[] m_pEquipSlot {
    set {
      NWNXLibPINVOKE.CNWSInventory_m_pEquipSlot_set(swigCPtr, value);
    }  
    get {
      uint* arrayPtr = NWNXLibPINVOKE.CNWSInventory_m_pEquipSlot_get(swigCPtr);
      uint[] retVal = new uint[18];

      for(int i = 0; i < 18; i++) {
        retVal[i] = arrayPtr[i];
      }

      return retVal;
    }

  }

  public CNWSInventory() : this(NWNXLibPINVOKE.new_CNWSInventory(), true) {
  }

  public int GetItemInInventory(CNWSItem pItem) {
    int ret = NWNXLibPINVOKE.CNWSInventory_GetItemInInventory(swigCPtr, CNWSItem.getCPtr(pItem));
    return ret;
  }

  public uint GetSlotFromItem(CNWSItem pItem) {
    uint ret = NWNXLibPINVOKE.CNWSInventory_GetSlotFromItem(swigCPtr, CNWSItem.getCPtr(pItem));
    return ret;
  }

  public CNWSItem GetItemInSlot(uint nSlot) {
    global::System.IntPtr cPtr = NWNXLibPINVOKE.CNWSInventory_GetItemInSlot(swigCPtr, nSlot);
    CNWSItem ret = (cPtr == global::System.IntPtr.Zero) ? null : new CNWSItem(cPtr, false);
    return ret;
  }

  public void PutItemInSlot(uint nSlot, CNWSItem pItem) {
    NWNXLibPINVOKE.CNWSInventory_PutItemInSlot(swigCPtr, nSlot, CNWSItem.getCPtr(pItem));
  }

  public int RemoveItem(CNWSItem pItem) {
    int ret = NWNXLibPINVOKE.CNWSInventory_RemoveItem(swigCPtr, CNWSItem.getCPtr(pItem));
    return ret;
  }

  public int GetArraySlotFromSlotFlag(uint nSlot) {
    int ret = NWNXLibPINVOKE.CNWSInventory_GetArraySlotFromSlotFlag(swigCPtr, nSlot);
    return ret;
  }

}

}

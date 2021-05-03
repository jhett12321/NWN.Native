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

public unsafe class CTlkTableTokenCustomArray : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  public CTlkTableTokenCustomArray(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  public CTlkTableTokenCustomArray(void* cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, (global::System.IntPtr)cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(CTlkTableTokenCustomArray obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~CTlkTableTokenCustomArray() {
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
          NWNXLibPINVOKE.delete_CTlkTableTokenCustomArray(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
    }
  }

  public CTlkTableTokenCustom this[int index] {
    get {
      return GetItem(index);
    }
    set {
      SetItem(index, value);
    }
  }

  public global::System.IntPtr Pointer {
    get {
      return swigCPtr.Handle;
    }
  }

  public static implicit operator void*(CTlkTableTokenCustomArray self) {
    return (void*)self.swigCPtr.Handle;
  }

  public static implicit operator global::System.IntPtr(CTlkTableTokenCustomArray self) {
    return self.swigCPtr.Handle;
  }

  public bool Equals(CTlkTableTokenCustomArray other) {
    if (ReferenceEquals(null, other)) {
      return false;
    }

    if (ReferenceEquals(this, other)) {
      return true;
    }

    return Pointer.Equals(other.Pointer);
  }

  public override bool Equals(object obj) {
    return ReferenceEquals(this, obj) || obj is CTlkTableTokenCustomArray other && Equals(other);
  }

  public override int GetHashCode() {
    return swigCPtr.Handle.GetHashCode();
  }

  public static bool operator ==(CTlkTableTokenCustomArray left, CTlkTableTokenCustomArray right) {
    return Equals(left, right);
  }

  public static bool operator !=(CTlkTableTokenCustomArray left, CTlkTableTokenCustomArray right) {
    return !Equals(left, right);
  }

  public CTlkTableTokenCustomArray(int nElements) : this(NWNXLibPINVOKE.new_CTlkTableTokenCustomArray(nElements), true) {
  }

  public CTlkTableTokenCustom GetItem(int index) {
    global::System.IntPtr cPtr = NWNXLibPINVOKE.CTlkTableTokenCustomArray_GetItem(swigCPtr, index);
    CTlkTableTokenCustom ret = (cPtr == global::System.IntPtr.Zero) ? null : new CTlkTableTokenCustom(cPtr, false);
    return ret;
  }

  public void SetItem(int index, CTlkTableTokenCustom value) {
    NWNXLibPINVOKE.CTlkTableTokenCustomArray_SetItem(swigCPtr, index, CTlkTableTokenCustom.getCPtr(value));
  }

  public static CTlkTableTokenCustomArray FromPointer(CTlkTableTokenCustom ptr) {
    global::System.IntPtr cPtr = NWNXLibPINVOKE.CTlkTableTokenCustomArray_FromPointer(CTlkTableTokenCustom.getCPtr(ptr));
    CTlkTableTokenCustomArray ret = (cPtr == global::System.IntPtr.Zero) ? null : new CTlkTableTokenCustomArray(cPtr, false);
    return ret;
  }

}

}

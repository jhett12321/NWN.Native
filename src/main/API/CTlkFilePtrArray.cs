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

public unsafe class CTlkFilePtrArray : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal CTlkFilePtrArray(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(CTlkFilePtrArray obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~CTlkFilePtrArray() {
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
          NWNXLibPINVOKE.delete_CTlkFilePtrArray(swigCPtr);
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

  public static unsafe implicit operator void*(CTlkFilePtrArray self) {
    return (void*)self.swigCPtr.Handle;
  }

  public static unsafe CTlkFilePtrArray FromPointer(void* pointer, bool memoryOwn = false) {
    return pointer != null ? new CTlkFilePtrArray((global::System.IntPtr)pointer, memoryOwn) : null;
  }

  public static CTlkFilePtrArray FromPointer(global::System.IntPtr pointer, bool memoryOwn = false) {
    return pointer != global::System.IntPtr.Zero ? new CTlkFilePtrArray(pointer, memoryOwn) : null;
  }

  public bool Equals(CTlkFilePtrArray other) {
    if (ReferenceEquals(null, other)) {
      return false;
    }

    if (ReferenceEquals(this, other)) {
      return true;
    }

    return Pointer.Equals(other.Pointer);
  }

  public override bool Equals(object obj) {
    return ReferenceEquals(this, obj) || obj is CTlkFilePtrArray other && Equals(other);
  }

  public override int GetHashCode() {
    return swigCPtr.Handle.GetHashCode();
  }

  public static bool operator ==(CTlkFilePtrArray left, CTlkFilePtrArray right) {
    return Equals(left, right);
  }

  public static bool operator !=(CTlkFilePtrArray left, CTlkFilePtrArray right) {
    return !Equals(left, right);
  }


  public CTlkFile this[int index] {
    get {
      return GetItem(index);
    }
    set {
      SetItem(index, value);
    }
  }
  public CTlkFilePtrArray(int nElements) : this(NWNXLibPINVOKE.new_CTlkFilePtrArray(nElements), true) {
  }

  public CTlkFile GetItem(int index) {
    global::System.IntPtr cPtr = NWNXLibPINVOKE.CTlkFilePtrArray_GetItem(swigCPtr, index);
    CTlkFile ret = (cPtr == global::System.IntPtr.Zero) ? null : new CTlkFile(cPtr, false);
    return ret;
  }

  public void SetItem(int index, CTlkFile value) {
    NWNXLibPINVOKE.CTlkFilePtrArray_SetItem(swigCPtr, index, CTlkFile.getCPtr(value));
  }

  public static CTlkFilePtrArray FromPointer(void** ptr) {
    global::System.IntPtr cPtr = NWNXLibPINVOKE.CTlkFilePtrArray_FromPointer((global::System.IntPtr)ptr);
    CTlkFilePtrArray ret = (cPtr == global::System.IntPtr.Zero) ? null : new CTlkFilePtrArray(cPtr, false);
    return ret;
  }

}

}

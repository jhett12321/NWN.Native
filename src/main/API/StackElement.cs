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

public unsafe class StackElement : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal StackElement(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(StackElement obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~StackElement() {
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
          NWNXLibPINVOKE.delete_StackElement(swigCPtr);
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

  public static unsafe implicit operator void*(StackElement self) {
    return (void*)self.swigCPtr.Handle;
  }

  public static unsafe StackElement FromPointer(void* pointer, bool memoryOwn = false) {
    return pointer != null ? new StackElement((global::System.IntPtr)pointer, memoryOwn) : null;
  }

  public static StackElement FromPointer(global::System.IntPtr pointer, bool memoryOwn = false) {
    return pointer != global::System.IntPtr.Zero ? new StackElement(pointer, memoryOwn) : null;
  }

  public bool Equals(StackElement other) {
    if (ReferenceEquals(null, other)) {
      return false;
    }

    if (ReferenceEquals(this, other)) {
      return true;
    }

    return Pointer.Equals(other.Pointer);
  }

  public override bool Equals(object obj) {
    return ReferenceEquals(this, obj) || obj is StackElement other && Equals(other);
  }

  public override int GetHashCode() {
    return swigCPtr.Handle.GetHashCode();
  }

  public static bool operator ==(StackElement left, StackElement right) {
    return Equals(left, right);
  }

  public static bool operator !=(StackElement left, StackElement right) {
    return !Equals(left, right);
  }

  public uint m_nStackObjectID {
    set {
      NWNXLibPINVOKE.StackElement_m_nStackObjectID_set(swigCPtr, value);
    } 
    get {
      uint retVal = NWNXLibPINVOKE.StackElement_m_nStackObjectID_get(swigCPtr);
      return retVal;
    }

  }

  public int m_nStackInt {
    set {
      NWNXLibPINVOKE.StackElement_m_nStackInt_set(swigCPtr, value);
    } 
    get {
      int retVal = NWNXLibPINVOKE.StackElement_m_nStackInt_get(swigCPtr);
      return retVal;
    }

  }

  public float m_fStackFloat {
    set {
      NWNXLibPINVOKE.StackElement_m_fStackFloat_set(swigCPtr, value);
    } 
    get {
      float retVal = NWNXLibPINVOKE.StackElement_m_fStackFloat_get(swigCPtr);
      return retVal;
    }

  }

  public CExoString m_sString {
    set {
      NWNXLibPINVOKE.StackElement_m_sString_set(swigCPtr, CExoString.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = NWNXLibPINVOKE.StackElement_m_sString_get(swigCPtr);
      CExoString ret = (cPtr == global::System.IntPtr.Zero) ? null : new CExoString(cPtr, false);
      return ret;
    } 
  }

  public void* m_pStackPtr {
    set {
      NWNXLibPINVOKE.StackElement_m_pStackPtr_set(swigCPtr, (global::System.IntPtr)value);
    } 
    get {
        global::System.IntPtr retVal = NWNXLibPINVOKE.StackElement_m_pStackPtr_get(swigCPtr);
        return (void*)retVal;
    }

  }

  public byte m_nType {
    set {
      NWNXLibPINVOKE.StackElement_m_nType_set(swigCPtr, value);
    } 
    get {
      byte retVal = NWNXLibPINVOKE.StackElement_m_nType_get(swigCPtr);
      return retVal;
    }

  }

  public StackElement() : this(NWNXLibPINVOKE.new_StackElement(), true) {
  }

  public enum Type {
    INVALID = 0x00,
    INTEGER = 0x03,
    FLOAT = 0x04,
    STRING = 0x05,
    OBJECT = 0x06,
    ENGST0 = 0x10,
    ENGST1 = 0x11,
    ENGST2 = 0x12,
    ENGST3 = 0x13,
    ENGST4 = 0x14,
    ENGST5 = 0x15,
    ENGST6 = 0x16,
    ENGST7 = 0x17,
    ENGST8 = 0x18,
    ENGST9 = 0x19
  }

}

}

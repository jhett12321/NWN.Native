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

public unsafe class CExoInputEvent : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal CExoInputEvent(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(CExoInputEvent obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~CExoInputEvent() {
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
          NWNXLibPINVOKE.delete_CExoInputEvent(swigCPtr);
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

  public static unsafe implicit operator void*(CExoInputEvent self) {
    return (void*)self.swigCPtr.Handle;
  }

  public static unsafe CExoInputEvent FromPointer(void* pointer, bool memoryOwn = false) {
    return pointer != null ? new CExoInputEvent((global::System.IntPtr)pointer, memoryOwn) : null;
  }

  public static CExoInputEvent FromPointer(global::System.IntPtr pointer, bool memoryOwn = false) {
    return pointer != global::System.IntPtr.Zero ? new CExoInputEvent(pointer, memoryOwn) : null;
  }

  public bool Equals(CExoInputEvent other) {
    if (ReferenceEquals(null, other)) {
      return false;
    }

    if (ReferenceEquals(this, other)) {
      return true;
    }

    return Pointer.Equals(other.Pointer);
  }

  public override bool Equals(object obj) {
    return ReferenceEquals(this, obj) || obj is CExoInputEvent other && Equals(other);
  }

  public override int GetHashCode() {
    return swigCPtr.Handle.GetHashCode();
  }

  public static bool operator ==(CExoInputEvent left, CExoInputEvent right) {
    return Equals(left, right);
  }

  public static bool operator !=(CExoInputEvent left, CExoInputEvent right) {
    return !Equals(left, right);
  }
/*@SWIG@*/
  public uint m_nValue {
    set {
      NWNXLibPINVOKE.CExoInputEvent_m_nValue_set(swigCPtr, value);
    } 
    get {
      uint ret = NWNXLibPINVOKE.CExoInputEvent_m_nValue_get(swigCPtr);
      return ret;
    } 
  }

  public uint m_nTimeStamp {
    set {
      NWNXLibPINVOKE.CExoInputEvent_m_nTimeStamp_set(swigCPtr, value);
    } 
    get {
      uint ret = NWNXLibPINVOKE.CExoInputEvent_m_nTimeStamp_get(swigCPtr);
      return ret;
    } 
  }

  public uint m_nSequenceNumber {
    set {
      NWNXLibPINVOKE.CExoInputEvent_m_nSequenceNumber_set(swigCPtr, value);
    } 
    get {
      uint ret = NWNXLibPINVOKE.CExoInputEvent_m_nSequenceNumber_get(swigCPtr);
      return ret;
    } 
  }

  public uint m_nMouseX {
    set {
      NWNXLibPINVOKE.CExoInputEvent_m_nMouseX_set(swigCPtr, value);
    } 
    get {
      uint ret = NWNXLibPINVOKE.CExoInputEvent_m_nMouseX_get(swigCPtr);
      return ret;
    } 
  }

  public uint m_nMouseY {
    set {
      NWNXLibPINVOKE.CExoInputEvent_m_nMouseY_set(swigCPtr, value);
    } 
    get {
      uint ret = NWNXLibPINVOKE.CExoInputEvent_m_nMouseY_get(swigCPtr);
      return ret;
    } 
  }

  public CExoInputEventDesc m_pInputEventDesc {
    set {
      NWNXLibPINVOKE.CExoInputEvent_m_pInputEventDesc_set(swigCPtr, CExoInputEventDesc.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = NWNXLibPINVOKE.CExoInputEvent_m_pInputEventDesc_get(swigCPtr);
      CExoInputEventDesc ret = (cPtr == global::System.IntPtr.Zero) ? null : new CExoInputEventDesc(cPtr, false);
      return ret;
    } 
  }

  public int m_nInputDevice {
    set {
      NWNXLibPINVOKE.CExoInputEvent_m_nInputDevice_set(swigCPtr, value);
    } 
    get {
      int ret = NWNXLibPINVOKE.CExoInputEvent_m_nInputDevice_get(swigCPtr);
      return ret;
    } 
  }

  public uint m_nInputDeviceElement {
    set {
      NWNXLibPINVOKE.CExoInputEvent_m_nInputDeviceElement_set(swigCPtr, value);
    } 
    get {
      uint ret = NWNXLibPINVOKE.CExoInputEvent_m_nInputDeviceElement_get(swigCPtr);
      return ret;
    } 
  }

  public CExoInputEvent() : this(NWNXLibPINVOKE.new_CExoInputEvent(), true) {
  }

}

}

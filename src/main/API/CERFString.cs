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

public unsafe class CERFString : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal CERFString(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(CERFString obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~CERFString() {
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
          NWNXLibPINVOKE.delete_CERFString(swigCPtr);
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

  public static unsafe implicit operator void*(CERFString self) {
    return (void*)self.swigCPtr.Handle;
  }

  public static unsafe CERFString FromPointer(void* pointer, bool memoryOwn = false) {
    return pointer != null ? new CERFString((global::System.IntPtr)pointer, memoryOwn) : null;
  }

  public static CERFString FromPointer(global::System.IntPtr pointer, bool memoryOwn = false) {
    return pointer != global::System.IntPtr.Zero ? new CERFString(pointer, memoryOwn) : null;
  }

  public bool Equals(CERFString other) {
    if (ReferenceEquals(null, other)) {
      return false;
    }

    if (ReferenceEquals(this, other)) {
      return true;
    }

    return Pointer.Equals(other.Pointer);
  }

  public override bool Equals(object obj) {
    return ReferenceEquals(this, obj) || obj is CERFString other && Equals(other);
  }

  public override int GetHashCode() {
    return swigCPtr.Handle.GetHashCode();
  }

  public static bool operator ==(CERFString left, CERFString right) {
    return Equals(left, right);
  }

  public static bool operator !=(CERFString left, CERFString right) {
    return !Equals(left, right);
  }
/*@SWIG@*/
  public uint m_nLanguageID {
    set {
      NWNXLibPINVOKE.CERFString_m_nLanguageID_set(swigCPtr, value);
    } 
    get {
      uint retVal = NWNXLibPINVOKE.CERFString_m_nLanguageID_get(swigCPtr);
      return retVal;
    }

  }

  public uint m_nSize {
    set {
      NWNXLibPINVOKE.CERFString_m_nSize_set(swigCPtr, value);
    } 
    get {
      uint retVal = NWNXLibPINVOKE.CERFString_m_nSize_get(swigCPtr);
      return retVal;
    }

  }

  public byte* m_pText {
    set {
      NWNXLibPINVOKE.CERFString_m_pText_set(swigCPtr, value);
    } 
    get {
      byte* retVal = NWNXLibPINVOKE.CERFString_m_pText_get(swigCPtr);
      return retVal;
    }

  }

  public CExoString GetText() {
    CExoString ret = new CExoString(NWNXLibPINVOKE.CERFString_GetText(swigCPtr), true);
    return ret;
  }

  public void SetText(CExoString sString) {
    NWNXLibPINVOKE.CERFString_SetText(swigCPtr, CExoString.getCPtr(sString));
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
  }

  public CERFString() : this(NWNXLibPINVOKE.new_CERFString(), true) {
  }

  public int Read() {
    int retVal = NWNXLibPINVOKE.CERFString_Read(swigCPtr);
    return retVal;
  }

  public int Reset() {
    int retVal = NWNXLibPINVOKE.CERFString_Reset(swigCPtr);
    return retVal;
  }

  public int Write(CExoFile cOutFile) {
    int retVal = NWNXLibPINVOKE.CERFString_Write(swigCPtr, CExoFile.getCPtr(cOutFile));
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
    return retVal;
  }

  public void _Destructor() {
    NWNXLibPINVOKE.CERFString__Destructor(swigCPtr);
  }

}

}

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

public unsafe class BindUpdate : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal BindUpdate(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(BindUpdate obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~BindUpdate() {
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
          NWNXLibPINVOKE.delete_BindUpdate(swigCPtr);
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

  public static unsafe implicit operator void*(BindUpdate self) {
    return (void*)self.swigCPtr.Handle;
  }

  public static unsafe BindUpdate FromPointer(void* pointer, bool memoryOwn = false) {
    return pointer != null ? new BindUpdate((global::System.IntPtr)pointer, memoryOwn) : null;
  }

  public static BindUpdate FromPointer(global::System.IntPtr pointer, bool memoryOwn = false) {
    return pointer != global::System.IntPtr.Zero ? new BindUpdate(pointer, memoryOwn) : null;
  }

  public bool Equals(BindUpdate other) {
    if (ReferenceEquals(null, other)) {
      return false;
    }

    if (ReferenceEquals(this, other)) {
      return true;
    }

    return Pointer.Equals(other.Pointer);
  }

  public override bool Equals(object obj) {
    return ReferenceEquals(this, obj) || obj is BindUpdate other && Equals(other);
  }

  public override int GetHashCode() {
    return swigCPtr.Handle.GetHashCode();
  }

  public static bool operator ==(BindUpdate left, BindUpdate right) {
    return Equals(left, right);
  }

  public static bool operator !=(BindUpdate left, BindUpdate right) {
    return !Equals(left, right);
  }
/*@SWIG@*/
  public uint m_player {
    set {
      NWNXLibPINVOKE.BindUpdate_m_player_set(swigCPtr, value);
    } 
    get {
      uint retVal = NWNXLibPINVOKE.BindUpdate_m_player_get(swigCPtr);
      return retVal;
    }

  }

  public int m_token {
    set {
      NWNXLibPINVOKE.BindUpdate_m_token_set(swigCPtr, value);
    } 
    get {
      int retVal = NWNXLibPINVOKE.BindUpdate_m_token_get(swigCPtr);
      return retVal;
    }

  }

  public string m_bind {
    set {
      NWNXLibPINVOKE.BindUpdate_m_bind_set(swigCPtr, value);
      if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      string ret = NWNXLibPINVOKE.BindUpdate_m_bind_get(swigCPtr);
      if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public SWIGTYPE_p_nlohmann__json m_value {
    set {
      NWNXLibPINVOKE.BindUpdate_m_value_set(swigCPtr, SWIGTYPE_p_nlohmann__json.getCPtr(value));
      if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      SWIGTYPE_p_nlohmann__json ret = new SWIGTYPE_p_nlohmann__json(NWNXLibPINVOKE.BindUpdate_m_value_get(swigCPtr), true);
      if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public bool IsValid() {
    bool ret = NWNXLibPINVOKE.BindUpdate_IsValid(swigCPtr);
    return ret;
  }

  public BindUpdate() : this(NWNXLibPINVOKE.new_BindUpdate(), true) {
  }

}

}

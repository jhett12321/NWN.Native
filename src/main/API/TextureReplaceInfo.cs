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

public unsafe class TextureReplaceInfo : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  public TextureReplaceInfo(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  public TextureReplaceInfo(void* cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, (global::System.IntPtr)cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(TextureReplaceInfo obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~TextureReplaceInfo() {
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
          NWNXLibPINVOKE.delete_TextureReplaceInfo(swigCPtr);
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

  public static unsafe implicit operator void*(TextureReplaceInfo self) {
    return (void*)self.swigCPtr.Handle;
  }

  public static implicit operator global::System.IntPtr(TextureReplaceInfo self) {
    return self.swigCPtr.Handle;
  }

  public bool Equals(TextureReplaceInfo other) {
    if (ReferenceEquals(null, other)) {
      return false;
    }

    if (ReferenceEquals(this, other)) {
      return true;
    }

    return Pointer.Equals(other.Pointer);
  }

  public override bool Equals(object obj) {
    return ReferenceEquals(this, obj) || obj is TextureReplaceInfo other && Equals(other);
  }

  public override int GetHashCode() {
    return swigCPtr.Handle.GetHashCode();
  }

  public static bool operator ==(TextureReplaceInfo left, TextureReplaceInfo right) {
    return Equals(left, right);
  }

  public static bool operator !=(TextureReplaceInfo left, TextureReplaceInfo right) {
    return !Equals(left, right);
  }

  public string m_sOldName {
    set {
      NWNXLibPINVOKE.TextureReplaceInfo_m_sOldName_set(swigCPtr, value);
    } 
    get {
      string ret = NWNXLibPINVOKE.TextureReplaceInfo_m_sOldName_get(swigCPtr);
      return ret;
    } 
  }

  public string m_sNewName {
    set {
      NWNXLibPINVOKE.TextureReplaceInfo_m_sNewName_set(swigCPtr, value);
    } 
    get {
      string ret = NWNXLibPINVOKE.TextureReplaceInfo_m_sNewName_get(swigCPtr);
      return ret;
    } 
  }

  public TextureReplaceInfo() : this(NWNXLibPINVOKE.new_TextureReplaceInfo(), true) {
  }

}

}

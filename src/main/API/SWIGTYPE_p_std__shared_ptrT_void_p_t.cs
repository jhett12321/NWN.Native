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

public class SWIGTYPE_p_std__shared_ptrT_void_p_t {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;

  internal SWIGTYPE_p_std__shared_ptrT_void_p_t(global::System.IntPtr cPtr, bool futureUse) {
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  protected SWIGTYPE_p_std__shared_ptrT_void_p_t() {
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(SWIGTYPE_p_std__shared_ptrT_void_p_t obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  public global::System.IntPtr Pointer {
    get {
      return swigCPtr.Handle;
    }
  }

  public static unsafe implicit operator void*(SWIGTYPE_p_std__shared_ptrT_void_p_t self) {
    return (void*)self.swigCPtr.Handle;
  }

  public static implicit operator global::System.IntPtr(SWIGTYPE_p_std__shared_ptrT_void_p_t self) {
    return self.swigCPtr.Handle;
  }

  public bool Equals(SWIGTYPE_p_std__shared_ptrT_void_p_t other) {
    if (ReferenceEquals(null, other)) {
      return false;
    }

    if (ReferenceEquals(this, other)) {
      return true;
    }

    return Pointer.Equals(other.Pointer);
  }

  public override bool Equals(object obj) {
    return ReferenceEquals(this, obj) || obj is SWIGTYPE_p_std__shared_ptrT_void_p_t other && Equals(other);
  }

  public override int GetHashCode() {
    return swigCPtr.Handle.GetHashCode();
  }

  public static bool operator ==(SWIGTYPE_p_std__shared_ptrT_void_p_t left, SWIGTYPE_p_std__shared_ptrT_void_p_t right) {
    return Equals(left, right);
  }

  public static bool operator !=(SWIGTYPE_p_std__shared_ptrT_void_p_t left, SWIGTYPE_p_std__shared_ptrT_void_p_t right) {
    return !Equals(left, right);
  }
}

}

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

public class SWIGTYPE_p_std__unordered_mapT_CExoString_std__vectorT_void_p_t_t {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;

  internal SWIGTYPE_p_std__unordered_mapT_CExoString_std__vectorT_void_p_t_t(global::System.IntPtr cPtr, bool futureUse) {
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  protected SWIGTYPE_p_std__unordered_mapT_CExoString_std__vectorT_void_p_t_t() {
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(SWIGTYPE_p_std__unordered_mapT_CExoString_std__vectorT_void_p_t_t obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  public global::System.IntPtr Pointer {
    get {
      return swigCPtr.Handle;
    }
  }

  public static unsafe implicit operator void*(SWIGTYPE_p_std__unordered_mapT_CExoString_std__vectorT_void_p_t_t self) {
    return (void*)self.swigCPtr.Handle;
  }

  public static unsafe SWIGTYPE_p_std__unordered_mapT_CExoString_std__vectorT_void_p_t_t FromPointer(void* pointer, bool memoryOwn = false) {
    return pointer != null ? new SWIGTYPE_p_std__unordered_mapT_CExoString_std__vectorT_void_p_t_t((global::System.IntPtr)pointer, memoryOwn) : null;
  }

  public static SWIGTYPE_p_std__unordered_mapT_CExoString_std__vectorT_void_p_t_t FromPointer(global::System.IntPtr pointer, bool memoryOwn = false) {
    return pointer != global::System.IntPtr.Zero ? new SWIGTYPE_p_std__unordered_mapT_CExoString_std__vectorT_void_p_t_t(pointer, memoryOwn) : null;
  }

  public bool Equals(SWIGTYPE_p_std__unordered_mapT_CExoString_std__vectorT_void_p_t_t other) {
    if (ReferenceEquals(null, other)) {
      return false;
    }

    if (ReferenceEquals(this, other)) {
      return true;
    }

    return Pointer.Equals(other.Pointer);
  }

  public override bool Equals(object obj) {
    return ReferenceEquals(this, obj) || obj is SWIGTYPE_p_std__unordered_mapT_CExoString_std__vectorT_void_p_t_t other && Equals(other);
  }

  public override int GetHashCode() {
    return swigCPtr.Handle.GetHashCode();
  }

  public static bool operator ==(SWIGTYPE_p_std__unordered_mapT_CExoString_std__vectorT_void_p_t_t left, SWIGTYPE_p_std__unordered_mapT_CExoString_std__vectorT_void_p_t_t right) {
    return Equals(left, right);
  }

  public static bool operator !=(SWIGTYPE_p_std__unordered_mapT_CExoString_std__vectorT_void_p_t_t left, SWIGTYPE_p_std__unordered_mapT_CExoString_std__vectorT_void_p_t_t right) {
    return !Equals(left, right);
  }
}

}

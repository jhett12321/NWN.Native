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

public unsafe class CNWSSysAdmin : CNWSClient {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;

  internal CNWSSysAdmin(global::System.IntPtr cPtr, bool cMemoryOwn) : base(NWNXLibPINVOKE.CNWSSysAdmin_SWIGUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(CNWSSysAdmin obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  protected override void Dispose(bool disposing) {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          NWNXLibPINVOKE.delete_CNWSSysAdmin(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      base.Dispose(disposing);
    }
  }
/*@SWIG:/__w/NWN.Native/NWN.Native/nwnx/Plugins/SWIG/SWIG_DotNET/DotNETExtensions.i,1,SWIG_DOTNET_EXTENSIONS@*/
  public global::System.IntPtr Pointer {
    get {
      return swigCPtr.Handle;
    }
  }

  public static unsafe implicit operator void*(CNWSSysAdmin self) {
    return (void*)self.swigCPtr.Handle;
  }

  public static unsafe CNWSSysAdmin FromPointer(void* pointer, bool memoryOwn = false) {
    return pointer != null ? new CNWSSysAdmin((global::System.IntPtr)pointer, memoryOwn) : null;
  }

  public static CNWSSysAdmin FromPointer(global::System.IntPtr pointer, bool memoryOwn = false) {
    return pointer != global::System.IntPtr.Zero ? new CNWSSysAdmin(pointer, memoryOwn) : null;
  }

  public bool Equals(CNWSSysAdmin other) {
    if (ReferenceEquals(null, other)) {
      return false;
    }

    if (ReferenceEquals(this, other)) {
      return true;
    }

    return Pointer.Equals(other.Pointer);
  }

  public override bool Equals(object obj) {
    return ReferenceEquals(this, obj) || obj is CNWSSysAdmin other && Equals(other);
  }

  public override int GetHashCode() {
    return swigCPtr.Handle.GetHashCode();
  }

  public static bool operator ==(CNWSSysAdmin left, CNWSSysAdmin right) {
    return Equals(left, right);
  }

  public static bool operator !=(CNWSSysAdmin left, CNWSSysAdmin right) {
    return !Equals(left, right);
  }
/*@SWIG@*/
  public CNWSSysAdmin(uint nPlayerID) : this(NWNXLibPINVOKE.new_CNWSSysAdmin(nPlayerID), true) {
  }

  public virtual CNWSSysAdmin AsNWSSysAdmin() {
    global::System.IntPtr cPtr = NWNXLibPINVOKE.CNWSSysAdmin_AsNWSSysAdmin(swigCPtr);
    CNWSSysAdmin ret = (cPtr == global::System.IntPtr.Zero) ? null : new CNWSSysAdmin(cPtr, false);
    return ret;
  }

  public new void _Destructor() {
    NWNXLibPINVOKE.CNWSSysAdmin__Destructor(swigCPtr);
  }

}

}

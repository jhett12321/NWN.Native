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

public unsafe class DataBlock : DataView {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;

  internal DataBlock(global::System.IntPtr cPtr, bool cMemoryOwn) : base(NWNXLibPINVOKE.DataBlock_SWIGUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(DataBlock obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  protected override void Dispose(bool disposing) {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          NWNXLibPINVOKE.delete_DataBlock(swigCPtr);
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

  public static unsafe implicit operator void*(DataBlock self) {
    return (void*)self.swigCPtr.Handle;
  }

  public static unsafe DataBlock FromPointer(void* pointer, bool memoryOwn = false) {
    return pointer != null ? new DataBlock((global::System.IntPtr)pointer, memoryOwn) : null;
  }

  public static DataBlock FromPointer(global::System.IntPtr pointer, bool memoryOwn = false) {
    return pointer != global::System.IntPtr.Zero ? new DataBlock(pointer, memoryOwn) : null;
  }

  public bool Equals(DataBlock other) {
    if (ReferenceEquals(null, other)) {
      return false;
    }

    if (ReferenceEquals(this, other)) {
      return true;
    }

    return Pointer.Equals(other.Pointer);
  }

  public override bool Equals(object obj) {
    return ReferenceEquals(this, obj) || obj is DataBlock other && Equals(other);
  }

  public override int GetHashCode() {
    return swigCPtr.Handle.GetHashCode();
  }

  public static bool operator ==(DataBlock left, DataBlock right) {
    return Equals(left, right);
  }

  public static bool operator !=(DataBlock left, DataBlock right) {
    return !Equals(left, right);
  }
/*@SWIG@*/
  public DataBlock(uint preallocate) : this(NWNXLibPINVOKE.new_DataBlock__SWIG_0(preallocate), true) {
  }

  public DataBlock() : this(NWNXLibPINVOKE.new_DataBlock__SWIG_1(), true) {
  }

  public DataBlock(void* data, uint length) : this(NWNXLibPINVOKE.new_DataBlock__SWIG_2((global::System.IntPtr)data, length), true) {
  }

  public DataBlock(SWIGTYPE_p_std__vectorT_unsigned_char_t data) : this(NWNXLibPINVOKE.new_DataBlock__SWIG_3(SWIGTYPE_p_std__vectorT_unsigned_char_t.getCPtr(data)), true) {
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
  }

  public DataBlock(string data) : this(NWNXLibPINVOKE.new_DataBlock__SWIG_4(data), true) {
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
  }

  public void* Data() {
    global::System.IntPtr retVal = NWNXLibPINVOKE.DataBlock_Data(swigCPtr);
    return (void*)retVal;
  }

  public void AllocateAtLeast(uint length) {
    NWNXLibPINVOKE.DataBlock_AllocateAtLeast(swigCPtr, length);
  }

  public void MarkUsed(uint length) {
    NWNXLibPINVOKE.DataBlock_MarkUsed(swigCPtr, length);
  }

  public void Prepend(void* payload, uint length, uint chunkSize) {
    NWNXLibPINVOKE.DataBlock_Prepend__SWIG_0(swigCPtr, (global::System.IntPtr)payload, length, chunkSize);
  }

  public void Prepend(void* payload, uint length) {
    NWNXLibPINVOKE.DataBlock_Prepend__SWIG_1(swigCPtr, (global::System.IntPtr)payload, length);
  }

  public void Append(void* payload, uint length, uint chunkSize) {
    NWNXLibPINVOKE.DataBlock_Append__SWIG_0(swigCPtr, (global::System.IntPtr)payload, length, chunkSize);
  }

  public void Append(void* payload, uint length) {
    NWNXLibPINVOKE.DataBlock_Append__SWIG_1(swigCPtr, (global::System.IntPtr)payload, length);
  }

  public void Compact() {
    NWNXLibPINVOKE.DataBlock_Compact(swigCPtr);
  }

}

}

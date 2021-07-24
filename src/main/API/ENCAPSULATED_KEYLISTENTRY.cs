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

public unsafe class ENCAPSULATED_KEYLISTENTRY : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal ENCAPSULATED_KEYLISTENTRY(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(ENCAPSULATED_KEYLISTENTRY obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~ENCAPSULATED_KEYLISTENTRY() {
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
          NWNXLibPINVOKE.delete_ENCAPSULATED_KEYLISTENTRY(swigCPtr);
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

  public static unsafe implicit operator void*(ENCAPSULATED_KEYLISTENTRY self) {
    return (void*)self.swigCPtr.Handle;
  }

  public static unsafe ENCAPSULATED_KEYLISTENTRY FromPointer(void* pointer, bool memoryOwn = false) {
    return pointer != null ? new ENCAPSULATED_KEYLISTENTRY((global::System.IntPtr)pointer, memoryOwn) : null;
  }

  public static ENCAPSULATED_KEYLISTENTRY FromPointer(global::System.IntPtr pointer, bool memoryOwn = false) {
    return pointer != global::System.IntPtr.Zero ? new ENCAPSULATED_KEYLISTENTRY(pointer, memoryOwn) : null;
  }

  public bool Equals(ENCAPSULATED_KEYLISTENTRY other) {
    if (ReferenceEquals(null, other)) {
      return false;
    }

    if (ReferenceEquals(this, other)) {
      return true;
    }

    return Pointer.Equals(other.Pointer);
  }

  public override bool Equals(object obj) {
    return ReferenceEquals(this, obj) || obj is ENCAPSULATED_KEYLISTENTRY other && Equals(other);
  }

  public override int GetHashCode() {
    return swigCPtr.Handle.GetHashCode();
  }

  public static bool operator ==(ENCAPSULATED_KEYLISTENTRY left, ENCAPSULATED_KEYLISTENTRY right) {
    return Equals(left, right);
  }

  public static bool operator !=(ENCAPSULATED_KEYLISTENTRY left, ENCAPSULATED_KEYLISTENTRY right) {
    return !Equals(left, right);
  }
/*@SWIG@*/
  public NativeArray<byte> resRef {
    set {
      NWNXLibPINVOKE.ENCAPSULATED_KEYLISTENTRY_resRef_set(swigCPtr, value);
    } 
    get {
      global::System.IntPtr arrayPtr = NWNXLibPINVOKE.ENCAPSULATED_KEYLISTENTRY_resRef_get(swigCPtr);
      NativeArray<byte> retVal = new NativeArray<byte>(arrayPtr, 16);

      return retVal; // byte[16]
    }

  }

  public uint nID {
    set {
      NWNXLibPINVOKE.ENCAPSULATED_KEYLISTENTRY_nID_set(swigCPtr, value);
    } 
    get {
      uint retVal = NWNXLibPINVOKE.ENCAPSULATED_KEYLISTENTRY_nID_get(swigCPtr);
      return retVal;
    }

  }

  public ushort nType {
    set {
      NWNXLibPINVOKE.ENCAPSULATED_KEYLISTENTRY_nType_set(swigCPtr, value);
    } 
    get {
      ushort retVal = NWNXLibPINVOKE.ENCAPSULATED_KEYLISTENTRY_nType_get(swigCPtr);
      return retVal;
    }

  }

  public ushort unused {
    set {
      NWNXLibPINVOKE.ENCAPSULATED_KEYLISTENTRY_unused_set(swigCPtr, value);
    } 
    get {
      ushort retVal = NWNXLibPINVOKE.ENCAPSULATED_KEYLISTENTRY_unused_get(swigCPtr);
      return retVal;
    }

  }

  public ENCAPSULATED_KEYLISTENTRY() : this(NWNXLibPINVOKE.new_ENCAPSULATED_KEYLISTENTRY(), true) {
  }

}

}

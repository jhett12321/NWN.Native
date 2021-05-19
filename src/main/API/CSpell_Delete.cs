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

public unsafe class CSpell_Delete : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal CSpell_Delete(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(CSpell_Delete obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~CSpell_Delete() {
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
          NWNXLibPINVOKE.delete_CSpell_Delete(swigCPtr);
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

  public static unsafe implicit operator void*(CSpell_Delete self) {
    return (void*)self.swigCPtr.Handle;
  }

  public static unsafe CSpell_Delete FromPointer(void* pointer, bool memoryOwn = false) {
    return pointer != null ? new CSpell_Delete((global::System.IntPtr)pointer, memoryOwn) : null;
  }

  public static CSpell_Delete FromPointer(global::System.IntPtr pointer, bool memoryOwn = false) {
    return pointer != global::System.IntPtr.Zero ? new CSpell_Delete(pointer, memoryOwn) : null;
  }

  public bool Equals(CSpell_Delete other) {
    if (ReferenceEquals(null, other)) {
      return false;
    }

    if (ReferenceEquals(this, other)) {
      return true;
    }

    return Pointer.Equals(other.Pointer);
  }

  public override bool Equals(object obj) {
    return ReferenceEquals(this, obj) || obj is CSpell_Delete other && Equals(other);
  }

  public override int GetHashCode() {
    return swigCPtr.Handle.GetHashCode();
  }

  public static bool operator ==(CSpell_Delete left, CSpell_Delete right) {
    return Equals(left, right);
  }

  public static bool operator !=(CSpell_Delete left, CSpell_Delete right) {
    return !Equals(left, right);
  }
/*@SWIG@*/
  public byte m_nSpellLevel {
    set {
      NWNXLibPINVOKE.CSpell_Delete_m_nSpellLevel_set(swigCPtr, value);
    } 
    get {
      byte ret = NWNXLibPINVOKE.CSpell_Delete_m_nSpellLevel_get(swigCPtr);
      return ret;
    } 
  }

  public byte m_nSpellSlot {
    set {
      NWNXLibPINVOKE.CSpell_Delete_m_nSpellSlot_set(swigCPtr, value);
    } 
    get {
      byte ret = NWNXLibPINVOKE.CSpell_Delete_m_nSpellSlot_get(swigCPtr);
      return ret;
    } 
  }

  public CSpell_Delete() : this(NWNXLibPINVOKE.new_CSpell_Delete(), true) {
  }

}

}

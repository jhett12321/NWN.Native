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

public unsafe class CNWSTransition : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal CNWSTransition(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(CNWSTransition obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~CNWSTransition() {
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
          NWNXLibPINVOKE.delete_CNWSTransition(swigCPtr);
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

  public static unsafe implicit operator void*(CNWSTransition self) {
    return (void*)self.swigCPtr.Handle;
  }

  public static unsafe CNWSTransition FromPointer(void* pointer, bool memoryOwn = false) {
    return pointer != null ? new CNWSTransition((global::System.IntPtr)pointer, memoryOwn) : null;
  }

  public static CNWSTransition FromPointer(global::System.IntPtr pointer, bool memoryOwn = false) {
    return pointer != global::System.IntPtr.Zero ? new CNWSTransition(pointer, memoryOwn) : null;
  }

  public bool Equals(CNWSTransition other) {
    if (ReferenceEquals(null, other)) {
      return false;
    }

    if (ReferenceEquals(this, other)) {
      return true;
    }

    return Pointer.Equals(other.Pointer);
  }

  public override bool Equals(object obj) {
    return ReferenceEquals(this, obj) || obj is CNWSTransition other && Equals(other);
  }

  public override int GetHashCode() {
    return swigCPtr.Handle.GetHashCode();
  }

  public static bool operator ==(CNWSTransition left, CNWSTransition right) {
    return Equals(left, right);
  }

  public static bool operator !=(CNWSTransition left, CNWSTransition right) {
    return !Equals(left, right);
  }
/*@SWIG@*/
  public CExoString m_sTransitionTarget {
    set {
      NWNXLibPINVOKE.CNWSTransition_m_sTransitionTarget_set(swigCPtr, CExoString.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = NWNXLibPINVOKE.CNWSTransition_m_sTransitionTarget_get(swigCPtr);
      CExoString ret = (cPtr == global::System.IntPtr.Zero) ? null : new CExoString(cPtr, false);
      return ret;
    } 
  }

  public uint m_oidCachedTransitionTarget {
    set {
      NWNXLibPINVOKE.CNWSTransition_m_oidCachedTransitionTarget_set(swigCPtr, value);
    } 
    get {
      uint retVal = NWNXLibPINVOKE.CNWSTransition_m_oidCachedTransitionTarget_get(swigCPtr);
      return retVal;
    }

  }

  public CNWSObject LookupTarget() {
    global::System.IntPtr cPtr = NWNXLibPINVOKE.CNWSTransition_LookupTarget(swigCPtr);
    CNWSObject ret = (cPtr == global::System.IntPtr.Zero) ? null : new CNWSObject(cPtr, false);
    return ret;
  }

  public void SetTarget(CNWSObject target) {
    NWNXLibPINVOKE.CNWSTransition_SetTarget__SWIG_0(swigCPtr, CNWSObject.getCPtr(target));
  }

  public void SetTarget(CExoString target) {
    NWNXLibPINVOKE.CNWSTransition_SetTarget__SWIG_1(swigCPtr, CExoString.getCPtr(target));
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
  }

  public void Unlink(int unlinkBothEnds) {
    NWNXLibPINVOKE.CNWSTransition_Unlink__SWIG_0(swigCPtr, unlinkBothEnds);
  }

  public void Unlink() {
    NWNXLibPINVOKE.CNWSTransition_Unlink__SWIG_1(swigCPtr);
  }

  public void LoadFromGff(CResGFF pRes, CResStruct pStruct) {
    NWNXLibPINVOKE.CNWSTransition_LoadFromGff(swigCPtr, CResGFF.getCPtr(pRes), CResStruct.getCPtr(pStruct));
  }

  public void SaveToGff(CResGFF pRes, CResStruct pStruct) {
    NWNXLibPINVOKE.CNWSTransition_SaveToGff(swigCPtr, CResGFF.getCPtr(pRes), CResStruct.getCPtr(pStruct));
  }

  public CNWSTransition() : this(NWNXLibPINVOKE.new_CNWSTransition(), true) {
  }

}

}

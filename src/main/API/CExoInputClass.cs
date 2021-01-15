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

public class CExoInputClass : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal CExoInputClass(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(CExoInputClass obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~CExoInputClass() {
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
          throw new global::System.MethodAccessException("C++ destructor does not have public access");
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
    }
  }

  public CExoString m_Label {
    set {
      NWNXLibPINVOKE.CExoInputClass_m_Label_set(swigCPtr, CExoString.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = NWNXLibPINVOKE.CExoInputClass_m_Label_get(swigCPtr);
      CExoString ret = (cPtr == global::System.IntPtr.Zero) ? null : new CExoString(cPtr, false);
      return ret;
    } 
  }

  public CExoLinkedListCExoInputEventDesc m_pUnassignedInputEventDescList {
    set {
      NWNXLibPINVOKE.CExoInputClass_m_pUnassignedInputEventDescList_set(swigCPtr, CExoLinkedListCExoInputEventDesc.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = NWNXLibPINVOKE.CExoInputClass_m_pUnassignedInputEventDescList_get(swigCPtr);
      CExoLinkedListCExoInputEventDesc ret = (cPtr == global::System.IntPtr.Zero) ? null : new CExoLinkedListCExoInputEventDesc(cPtr, false);
      return ret;
    } 
  }

  public CExoLinkedListCExoInputEventDesc m_pInputEventDescList {
    set {
      NWNXLibPINVOKE.CExoInputClass_m_pInputEventDescList_set(swigCPtr, CExoLinkedListCExoInputEventDesc.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = NWNXLibPINVOKE.CExoInputClass_m_pInputEventDescList_get(swigCPtr);
      CExoLinkedListCExoInputEventDesc ret = (cPtr == global::System.IntPtr.Zero) ? null : new CExoLinkedListCExoInputEventDesc(cPtr, false);
      return ret;
    } 
  }

}

}
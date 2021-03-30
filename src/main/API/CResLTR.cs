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

public unsafe class CResLTR : CRes {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;

  public CResLTR(global::System.IntPtr cPtr, bool cMemoryOwn) : base(NWNXLibPINVOKE.CResLTR_SWIGUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  public CResLTR(void* cPtr, bool cMemoryOwn) : base(NWNXLibPINVOKE.CResLTR_SWIGUpcast((global::System.IntPtr)cPtr), cMemoryOwn) {
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, (global::System.IntPtr)cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(CResLTR obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  protected override void Dispose(bool disposing) {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          NWNXLibPINVOKE.delete_CResLTR(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      base.Dispose(disposing);
    }
  }

  public global::System.IntPtr Pointer {
    get {
      return swigCPtr.Handle;
    }
  }

  public static unsafe implicit operator void*(CResLTR self) {
    return (void*)self.swigCPtr.Handle;
  }

  public static implicit operator global::System.IntPtr(CResLTR self) {
    return self.swigCPtr.Handle;
  }

  public bool Equals(CResLTR other) {
    if (ReferenceEquals(null, other)) {
      return false;
    }

    if (ReferenceEquals(this, other)) {
      return true;
    }

    return Pointer.Equals(other.Pointer);
  }

  public override bool Equals(object obj) {
    return ReferenceEquals(this, obj) || obj is CResLTR other && Equals(other);
  }

  public override int GetHashCode() {
    return swigCPtr.Handle.GetHashCode();
  }

  public static bool operator ==(CResLTR left, CResLTR right) {
    return Equals(left, right);
  }

  public static bool operator !=(CResLTR left, CResLTR right) {
    return !Equals(left, right);
  }

  public float*** m_pStartTripleLetterProb {
    set {
      NWNXLibPINVOKE.CResLTR_m_pStartTripleLetterProb_set(swigCPtr, (global::System.IntPtr)value);
    }  
    get {
        global::System.IntPtr retVal = NWNXLibPINVOKE.CResLTR_m_pStartTripleLetterProb_get(swigCPtr); 
        return (float***)retVal; 
    }

  }

  public float*** m_pMiddleTripleLetterProb {
    set {
      NWNXLibPINVOKE.CResLTR_m_pMiddleTripleLetterProb_set(swigCPtr, (global::System.IntPtr)value);
    }  
    get {
        global::System.IntPtr retVal = NWNXLibPINVOKE.CResLTR_m_pMiddleTripleLetterProb_get(swigCPtr); 
        return (float***)retVal; 
    }

  }

  public float*** m_pEndTripleLetterProb {
    set {
      NWNXLibPINVOKE.CResLTR_m_pEndTripleLetterProb_set(swigCPtr, (global::System.IntPtr)value);
    }  
    get {
        global::System.IntPtr retVal = NWNXLibPINVOKE.CResLTR_m_pEndTripleLetterProb_get(swigCPtr); 
        return (float***)retVal; 
    }

  }

  public float** m_pStartDoubleLetterProb {
    set {
      NWNXLibPINVOKE.CResLTR_m_pStartDoubleLetterProb_set(swigCPtr, (global::System.IntPtr)value);
    }  
    get {
        global::System.IntPtr retVal = NWNXLibPINVOKE.CResLTR_m_pStartDoubleLetterProb_get(swigCPtr); 
        return (float**)retVal; 
    }

  }

  public float** m_pMiddleDoubleLetterProb {
    set {
      NWNXLibPINVOKE.CResLTR_m_pMiddleDoubleLetterProb_set(swigCPtr, (global::System.IntPtr)value);
    }  
    get {
        global::System.IntPtr retVal = NWNXLibPINVOKE.CResLTR_m_pMiddleDoubleLetterProb_get(swigCPtr); 
        return (float**)retVal; 
    }

  }

  public float** m_pEndDoubleLetterProb {
    set {
      NWNXLibPINVOKE.CResLTR_m_pEndDoubleLetterProb_set(swigCPtr, (global::System.IntPtr)value);
    }  
    get {
        global::System.IntPtr retVal = NWNXLibPINVOKE.CResLTR_m_pEndDoubleLetterProb_get(swigCPtr); 
        return (float**)retVal; 
    }

  }

  public float* m_pStartSingleLetterProb {
    set {
      NWNXLibPINVOKE.CResLTR_m_pStartSingleLetterProb_set(swigCPtr, (global::System.IntPtr)value);
    }  
    get {
        global::System.IntPtr retVal = NWNXLibPINVOKE.CResLTR_m_pStartSingleLetterProb_get(swigCPtr); 
        return (float*)retVal; 
    }

  }

  public float* m_pMiddleSingleLetterProb {
    set {
      NWNXLibPINVOKE.CResLTR_m_pMiddleSingleLetterProb_set(swigCPtr, (global::System.IntPtr)value);
    }  
    get {
        global::System.IntPtr retVal = NWNXLibPINVOKE.CResLTR_m_pMiddleSingleLetterProb_get(swigCPtr); 
        return (float*)retVal; 
    }

  }

  public float* m_pEndSingleLetterProb {
    set {
      NWNXLibPINVOKE.CResLTR_m_pEndSingleLetterProb_set(swigCPtr, (global::System.IntPtr)value);
    }  
    get {
        global::System.IntPtr retVal = NWNXLibPINVOKE.CResLTR_m_pEndSingleLetterProb_get(swigCPtr); 
        return (float*)retVal; 
    }

  }

  public EXOLTRHEADER m_pLTRHeader {
    set {
      NWNXLibPINVOKE.CResLTR_m_pLTRHeader_set(swigCPtr, EXOLTRHEADER.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = NWNXLibPINVOKE.CResLTR_m_pLTRHeader_get(swigCPtr);
      EXOLTRHEADER ret = (cPtr == global::System.IntPtr.Zero) ? null : new EXOLTRHEADER(cPtr, false);
      return ret;
    } 
  }

  public byte* m_pLTRData {
    set {
      NWNXLibPINVOKE.CResLTR_m_pLTRData_set(swigCPtr, (global::System.IntPtr)value);
    }  
    get {
        global::System.IntPtr retVal = NWNXLibPINVOKE.CResLTR_m_pLTRData_get(swigCPtr); 
        return (byte*)retVal; 
    }

  }

  public uint m_nLTRNormalSize {
    set {
      NWNXLibPINVOKE.CResLTR_m_nLTRNormalSize_set(swigCPtr, value);
    } 
    get {
      uint ret = NWNXLibPINVOKE.CResLTR_m_nLTRNormalSize_get(swigCPtr);
      return ret;
    } 
  }

  public int m_bLoaded {
    set {
      NWNXLibPINVOKE.CResLTR_m_bLoaded_set(swigCPtr, value);
    } 
    get {
      int ret = NWNXLibPINVOKE.CResLTR_m_bLoaded_get(swigCPtr);
      return ret;
    } 
  }

  public CResLTR() : this(NWNXLibPINVOKE.new_CResLTR(), true) {
  }

  public override int OnResourceFreed() {
    int ret = NWNXLibPINVOKE.CResLTR_OnResourceFreed(swigCPtr);
    return ret;
  }

  public override int OnResourceServiced() {
    int ret = NWNXLibPINVOKE.CResLTR_OnResourceServiced(swigCPtr);
    return ret;
  }

}

}

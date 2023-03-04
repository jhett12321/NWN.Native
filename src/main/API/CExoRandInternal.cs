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

public unsafe class CExoRandInternal : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal CExoRandInternal(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(CExoRandInternal obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~CExoRandInternal() {
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
          NWNXLibPINVOKE.delete_CExoRandInternal(swigCPtr);
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

  public static unsafe implicit operator void*(CExoRandInternal self) {
    return (void*)self.swigCPtr.Handle;
  }

  public static unsafe CExoRandInternal FromPointer(void* pointer, bool memoryOwn = false) {
    return pointer != null ? new CExoRandInternal((global::System.IntPtr)pointer, memoryOwn) : null;
  }

  public static CExoRandInternal FromPointer(global::System.IntPtr pointer, bool memoryOwn = false) {
    return pointer != global::System.IntPtr.Zero ? new CExoRandInternal(pointer, memoryOwn) : null;
  }

  public bool Equals(CExoRandInternal other) {
    if (ReferenceEquals(null, other)) {
      return false;
    }

    if (ReferenceEquals(this, other)) {
      return true;
    }

    return Pointer.Equals(other.Pointer);
  }

  public override bool Equals(object obj) {
    return ReferenceEquals(this, obj) || obj is CExoRandInternal other && Equals(other);
  }

  public override int GetHashCode() {
    return swigCPtr.Handle.GetHashCode();
  }

  public static bool operator ==(CExoRandInternal left, CExoRandInternal right) {
    return Equals(left, right);
  }

  public static bool operator !=(CExoRandInternal left, CExoRandInternal right) {
    return !Equals(left, right);
  }

  public uint m_s1 {
    set {
      NWNXLibPINVOKE.CExoRandInternal_m_s1_set(swigCPtr, value);
    } 
    get {
      uint retVal = NWNXLibPINVOKE.CExoRandInternal_m_s1_get(swigCPtr);
      return retVal;
    }

  }

  public uint m_s2 {
    set {
      NWNXLibPINVOKE.CExoRandInternal_m_s2_set(swigCPtr, value);
    } 
    get {
      uint retVal = NWNXLibPINVOKE.CExoRandInternal_m_s2_get(swigCPtr);
      return retVal;
    }

  }

  public uint m_s3 {
    set {
      NWNXLibPINVOKE.CExoRandInternal_m_s3_set(swigCPtr, value);
    } 
    get {
      uint retVal = NWNXLibPINVOKE.CExoRandInternal_m_s3_get(swigCPtr);
      return retVal;
    }

  }

  public uint m_s4 {
    set {
      NWNXLibPINVOKE.CExoRandInternal_m_s4_set(swigCPtr, value);
    } 
    get {
      uint retVal = NWNXLibPINVOKE.CExoRandInternal_m_s4_get(swigCPtr);
      return retVal;
    }

  }

  public uint m_mask1 {
    set {
      NWNXLibPINVOKE.CExoRandInternal_m_mask1_set(swigCPtr, value);
    } 
    get {
      uint retVal = NWNXLibPINVOKE.CExoRandInternal_m_mask1_get(swigCPtr);
      return retVal;
    }

  }

  public uint m_mask2 {
    set {
      NWNXLibPINVOKE.CExoRandInternal_m_mask2_set(swigCPtr, value);
    } 
    get {
      uint retVal = NWNXLibPINVOKE.CExoRandInternal_m_mask2_get(swigCPtr);
      return retVal;
    }

  }

  public uint m_mask3 {
    set {
      NWNXLibPINVOKE.CExoRandInternal_m_mask3_set(swigCPtr, value);
    } 
    get {
      uint retVal = NWNXLibPINVOKE.CExoRandInternal_m_mask3_get(swigCPtr);
      return retVal;
    }

  }

  public uint m_mask4 {
    set {
      NWNXLibPINVOKE.CExoRandInternal_m_mask4_set(swigCPtr, value);
    } 
    get {
      uint retVal = NWNXLibPINVOKE.CExoRandInternal_m_mask4_get(swigCPtr);
      return retVal;
    }

  }

  public int m_shft1 {
    set {
      NWNXLibPINVOKE.CExoRandInternal_m_shft1_set(swigCPtr, value);
    } 
    get {
      int retVal = NWNXLibPINVOKE.CExoRandInternal_m_shft1_get(swigCPtr);
      return retVal;
    }

  }

  public int m_shft2 {
    set {
      NWNXLibPINVOKE.CExoRandInternal_m_shft2_set(swigCPtr, value);
    } 
    get {
      int retVal = NWNXLibPINVOKE.CExoRandInternal_m_shft2_get(swigCPtr);
      return retVal;
    }

  }

  public int m_shft3 {
    set {
      NWNXLibPINVOKE.CExoRandInternal_m_shft3_set(swigCPtr, value);
    } 
    get {
      int retVal = NWNXLibPINVOKE.CExoRandInternal_m_shft3_get(swigCPtr);
      return retVal;
    }

  }

  public int m_shft4 {
    set {
      NWNXLibPINVOKE.CExoRandInternal_m_shft4_set(swigCPtr, value);
    } 
    get {
      int retVal = NWNXLibPINVOKE.CExoRandInternal_m_shft4_get(swigCPtr);
      return retVal;
    }

  }

  public int m_k1 {
    set {
      NWNXLibPINVOKE.CExoRandInternal_m_k1_set(swigCPtr, value);
    } 
    get {
      int retVal = NWNXLibPINVOKE.CExoRandInternal_m_k1_get(swigCPtr);
      return retVal;
    }

  }

  public int m_k2 {
    set {
      NWNXLibPINVOKE.CExoRandInternal_m_k2_set(swigCPtr, value);
    } 
    get {
      int retVal = NWNXLibPINVOKE.CExoRandInternal_m_k2_get(swigCPtr);
      return retVal;
    }

  }

  public int m_k3 {
    set {
      NWNXLibPINVOKE.CExoRandInternal_m_k3_set(swigCPtr, value);
    } 
    get {
      int retVal = NWNXLibPINVOKE.CExoRandInternal_m_k3_get(swigCPtr);
      return retVal;
    }

  }

  public int m_k4 {
    set {
      NWNXLibPINVOKE.CExoRandInternal_m_k4_set(swigCPtr, value);
    } 
    get {
      int retVal = NWNXLibPINVOKE.CExoRandInternal_m_k4_get(swigCPtr);
      return retVal;
    }

  }

  public int m_q1 {
    set {
      NWNXLibPINVOKE.CExoRandInternal_m_q1_set(swigCPtr, value);
    } 
    get {
      int retVal = NWNXLibPINVOKE.CExoRandInternal_m_q1_get(swigCPtr);
      return retVal;
    }

  }

  public int m_q2 {
    set {
      NWNXLibPINVOKE.CExoRandInternal_m_q2_set(swigCPtr, value);
    } 
    get {
      int retVal = NWNXLibPINVOKE.CExoRandInternal_m_q2_get(swigCPtr);
      return retVal;
    }

  }

  public int m_q3 {
    set {
      NWNXLibPINVOKE.CExoRandInternal_m_q3_set(swigCPtr, value);
    } 
    get {
      int retVal = NWNXLibPINVOKE.CExoRandInternal_m_q3_get(swigCPtr);
      return retVal;
    }

  }

  public int m_q4 {
    set {
      NWNXLibPINVOKE.CExoRandInternal_m_q4_set(swigCPtr, value);
    } 
    get {
      int retVal = NWNXLibPINVOKE.CExoRandInternal_m_q4_get(swigCPtr);
      return retVal;
    }

  }

  public int m_p1 {
    set {
      NWNXLibPINVOKE.CExoRandInternal_m_p1_set(swigCPtr, value);
    } 
    get {
      int retVal = NWNXLibPINVOKE.CExoRandInternal_m_p1_get(swigCPtr);
      return retVal;
    }

  }

  public int m_p2 {
    set {
      NWNXLibPINVOKE.CExoRandInternal_m_p2_set(swigCPtr, value);
    } 
    get {
      int retVal = NWNXLibPINVOKE.CExoRandInternal_m_p2_get(swigCPtr);
      return retVal;
    }

  }

  public int m_p3 {
    set {
      NWNXLibPINVOKE.CExoRandInternal_m_p3_set(swigCPtr, value);
    } 
    get {
      int retVal = NWNXLibPINVOKE.CExoRandInternal_m_p3_get(swigCPtr);
      return retVal;
    }

  }

  public int m_p4 {
    set {
      NWNXLibPINVOKE.CExoRandInternal_m_p4_set(swigCPtr, value);
    } 
    get {
      int retVal = NWNXLibPINVOKE.CExoRandInternal_m_p4_get(swigCPtr);
      return retVal;
    }

  }

  public int m_bSeeded {
    set {
      NWNXLibPINVOKE.CExoRandInternal_m_bSeeded_set(swigCPtr, value);
    } 
    get {
      int retVal = NWNXLibPINVOKE.CExoRandInternal_m_bSeeded_get(swigCPtr);
      return retVal;
    }

  }

  public byte* m_pBuffer {
    set {
      NWNXLibPINVOKE.CExoRandInternal_m_pBuffer_set(swigCPtr, value);
    } 
    get {
      byte* retVal = NWNXLibPINVOKE.CExoRandInternal_m_pBuffer_get(swigCPtr);
      return retVal;
    }

  }

  public ushort m_pBufIndex {
    set {
      NWNXLibPINVOKE.CExoRandInternal_m_pBufIndex_set(swigCPtr, value);
    } 
    get {
      ushort retVal = NWNXLibPINVOKE.CExoRandInternal_m_pBufIndex_get(swigCPtr);
      return retVal;
    }

  }

  public ulong m_nEvent1 {
    set {
      NWNXLibPINVOKE.CExoRandInternal_m_nEvent1_set(swigCPtr, value);
    } 
    get {
      ulong retVal = NWNXLibPINVOKE.CExoRandInternal_m_nEvent1_get(swigCPtr);
      return retVal;
    }

  }

  public ulong m_nEvent2 {
    set {
      NWNXLibPINVOKE.CExoRandInternal_m_nEvent2_set(swigCPtr, value);
    } 
    get {
      ulong retVal = NWNXLibPINVOKE.CExoRandInternal_m_nEvent2_get(swigCPtr);
      return retVal;
    }

  }

  public ulong m_nEvent3 {
    set {
      NWNXLibPINVOKE.CExoRandInternal_m_nEvent3_set(swigCPtr, value);
    } 
    get {
      ulong retVal = NWNXLibPINVOKE.CExoRandInternal_m_nEvent3_get(swigCPtr);
      return retVal;
    }

  }

  public ulong m_nEvent4 {
    set {
      NWNXLibPINVOKE.CExoRandInternal_m_nEvent4_set(swigCPtr, value);
    } 
    get {
      ulong retVal = NWNXLibPINVOKE.CExoRandInternal_m_nEvent4_get(swigCPtr);
      return retVal;
    }

  }

  public uint m_nEvent5 {
    set {
      NWNXLibPINVOKE.CExoRandInternal_m_nEvent5_set(swigCPtr, value);
    } 
    get {
      uint retVal = NWNXLibPINVOKE.CExoRandInternal_m_nEvent5_get(swigCPtr);
      return retVal;
    }

  }

  public CExoRandInternal() : this(NWNXLibPINVOKE.new_CExoRandInternal(), true) {
  }

  public uint Rand() {
    uint retVal = NWNXLibPINVOKE.CExoRandInternal_Rand(swigCPtr);
    return retVal;
  }

  public CExoString GetString(ushort nLength) {
    CExoString ret = new CExoString(NWNXLibPINVOKE.CExoRandInternal_GetString(swigCPtr, nLength), true);
    return ret;
  }

  public void SignalEvent() {
    NWNXLibPINVOKE.CExoRandInternal_SignalEvent__SWIG_0(swigCPtr);
  }

  public void SignalEvent(uint nTimeStamp) {
    NWNXLibPINVOKE.CExoRandInternal_SignalEvent__SWIG_1(swigCPtr, nTimeStamp);
  }

  public void ReSeed(uint a, uint b, uint c, uint d) {
    NWNXLibPINVOKE.CExoRandInternal_ReSeed(swigCPtr, a, b, c, d);
  }

  public void GenSeed() {
    NWNXLibPINVOKE.CExoRandInternal_GenSeed(swigCPtr);
  }

  public void Add(byte* pBuf, int nSize) {
    NWNXLibPINVOKE.CExoRandInternal_Add(swigCPtr, pBuf, nSize);
  }

  public void _Destructor() {
    NWNXLibPINVOKE.CExoRandInternal__Destructor(swigCPtr);
  }

}

}

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

public unsafe class CNWSync : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal CNWSync(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(CNWSync obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~CNWSync() {
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
          NWNXLibPINVOKE.delete_CNWSync(swigCPtr);
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

  public static unsafe implicit operator void*(CNWSync self) {
    return (void*)self.swigCPtr.Handle;
  }

  public static unsafe CNWSync FromPointer(void* pointer, bool memoryOwn = false) {
    return pointer != null ? new CNWSync((global::System.IntPtr)pointer, memoryOwn) : null;
  }

  public static CNWSync FromPointer(global::System.IntPtr pointer, bool memoryOwn = false) {
    return pointer != global::System.IntPtr.Zero ? new CNWSync(pointer, memoryOwn) : null;
  }

  public bool Equals(CNWSync other) {
    if (ReferenceEquals(null, other)) {
      return false;
    }

    if (ReferenceEquals(this, other)) {
      return true;
    }

    return Pointer.Equals(other.Pointer);
  }

  public override bool Equals(object obj) {
    return ReferenceEquals(this, obj) || obj is CNWSync other && Equals(other);
  }

  public override int GetHashCode() {
    return swigCPtr.Handle.GetHashCode();
  }

  public static bool operator ==(CNWSync left, CNWSync right) {
    return Equals(left, right);
  }

  public static bool operator !=(CNWSync left, CNWSync right) {
    return !Equals(left, right);
  }

  public void* m_internal {
    set {
      NWNXLibPINVOKE.CNWSync_m_internal_set(swigCPtr, (global::System.IntPtr)value);
    } 
    get {
        global::System.IntPtr retVal = NWNXLibPINVOKE.CNWSync_m_internal_get(swigCPtr);
        return (void*)retVal;
    }

  }

  public byte* m_tmp1 {
    set {
      NWNXLibPINVOKE.CNWSync_m_tmp1_set(swigCPtr, value);
    } 
    get {
      byte* retVal = NWNXLibPINVOKE.CNWSync_m_tmp1_get(swigCPtr);
      return retVal;
    }

  }

  public uint m_tmp2 {
    set {
      NWNXLibPINVOKE.CNWSync_m_tmp2_set(swigCPtr, value);
    } 
    get {
      uint retVal = NWNXLibPINVOKE.CNWSync_m_tmp2_get(swigCPtr);
      return retVal;
    }

  }

  public unsafe class ManifestMetaData : global::System.IDisposable {
    private global::System.Runtime.InteropServices.HandleRef swigCPtr;
    protected bool swigCMemOwn;
  
    internal ManifestMetaData(global::System.IntPtr cPtr, bool cMemoryOwn) {
      swigCMemOwn = cMemoryOwn;
      swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
    }
  
    internal static global::System.Runtime.InteropServices.HandleRef getCPtr(ManifestMetaData obj) {
      return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
    }
  
    ~ManifestMetaData() {
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
            NWNXLibPINVOKE.delete_CNWSync_ManifestMetaData(swigCPtr);
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
  
    public static unsafe implicit operator void*(ManifestMetaData self) {
      return (void*)self.swigCPtr.Handle;
    }
  
    public static unsafe ManifestMetaData FromPointer(void* pointer, bool memoryOwn = false) {
      return pointer != null ? new ManifestMetaData((global::System.IntPtr)pointer, memoryOwn) : null;
    }
  
    public static ManifestMetaData FromPointer(global::System.IntPtr pointer, bool memoryOwn = false) {
      return pointer != global::System.IntPtr.Zero ? new ManifestMetaData(pointer, memoryOwn) : null;
    }
  
    public bool Equals(ManifestMetaData other) {
      if (ReferenceEquals(null, other)) {
        return false;
      }
  
      if (ReferenceEquals(this, other)) {
        return true;
      }
  
      return Pointer.Equals(other.Pointer);
    }
  
    public override bool Equals(object obj) {
      return ReferenceEquals(this, obj) || obj is ManifestMetaData other && Equals(other);
    }
  
    public override int GetHashCode() {
      return swigCPtr.Handle.GetHashCode();
    }
  
    public static bool operator ==(ManifestMetaData left, ManifestMetaData right) {
      return Equals(left, right);
    }
  
    public static bool operator !=(ManifestMetaData left, ManifestMetaData right) {
      return !Equals(left, right);
    }
  
    public byte field0_0x0 {
      set {
        NWNXLibPINVOKE.CNWSync_ManifestMetaData_field0_0x0_set(swigCPtr, value);
      } 
      get {
        byte retVal = NWNXLibPINVOKE.CNWSync_ManifestMetaData_field0_0x0_get(swigCPtr);
        return retVal;
      }
  
    }
  
    public long field1_0x1 {
      set {
        NWNXLibPINVOKE.CNWSync_ManifestMetaData_field1_0x1_set(swigCPtr, value);
      } 
      get {
        long ret = NWNXLibPINVOKE.CNWSync_ManifestMetaData_field1_0x1_get(swigCPtr);
        return ret;
      } 
    }
  
    public long field2_0x9 {
      set {
        NWNXLibPINVOKE.CNWSync_ManifestMetaData_field2_0x9_set(swigCPtr, value);
      } 
      get {
        long ret = NWNXLibPINVOKE.CNWSync_ManifestMetaData_field2_0x9_get(swigCPtr);
        return ret;
      } 
    }
  
    public int field3_0x11 {
      set {
        NWNXLibPINVOKE.CNWSync_ManifestMetaData_field3_0x11_set(swigCPtr, value);
      } 
      get {
        int retVal = NWNXLibPINVOKE.CNWSync_ManifestMetaData_field3_0x11_get(swigCPtr);
        return retVal;
      }
  
    }
  
    public byte field4_0x15 {
      set {
        NWNXLibPINVOKE.CNWSync_ManifestMetaData_field4_0x15_set(swigCPtr, value);
      } 
      get {
        byte retVal = NWNXLibPINVOKE.CNWSync_ManifestMetaData_field4_0x15_get(swigCPtr);
        return retVal;
      }
  
    }
  
    public byte field5_0x16 {
      set {
        NWNXLibPINVOKE.CNWSync_ManifestMetaData_field5_0x16_set(swigCPtr, value);
      } 
      get {
        byte retVal = NWNXLibPINVOKE.CNWSync_ManifestMetaData_field5_0x16_get(swigCPtr);
        return retVal;
      }
  
    }
  
    public byte field6_0x17 {
      set {
        NWNXLibPINVOKE.CNWSync_ManifestMetaData_field6_0x17_set(swigCPtr, value);
      } 
      get {
        byte retVal = NWNXLibPINVOKE.CNWSync_ManifestMetaData_field6_0x17_get(swigCPtr);
        return retVal;
      }
  
    }
  
    public byte field7_0x18 {
      set {
        NWNXLibPINVOKE.CNWSync_ManifestMetaData_field7_0x18_set(swigCPtr, value);
      } 
      get {
        byte retVal = NWNXLibPINVOKE.CNWSync_ManifestMetaData_field7_0x18_get(swigCPtr);
        return retVal;
      }
  
    }
  
    public byte field8_0x19 {
      set {
        NWNXLibPINVOKE.CNWSync_ManifestMetaData_field8_0x19_set(swigCPtr, value);
      } 
      get {
        byte retVal = NWNXLibPINVOKE.CNWSync_ManifestMetaData_field8_0x19_get(swigCPtr);
        return retVal;
      }
  
    }
  
    public byte field9_0x1a {
      set {
        NWNXLibPINVOKE.CNWSync_ManifestMetaData_field9_0x1a_set(swigCPtr, value);
      } 
      get {
        byte retVal = NWNXLibPINVOKE.CNWSync_ManifestMetaData_field9_0x1a_get(swigCPtr);
        return retVal;
      }
  
    }
  
    public byte field10_0x1b {
      set {
        NWNXLibPINVOKE.CNWSync_ManifestMetaData_field10_0x1b_set(swigCPtr, value);
      } 
      get {
        byte retVal = NWNXLibPINVOKE.CNWSync_ManifestMetaData_field10_0x1b_get(swigCPtr);
        return retVal;
      }
  
    }
  
    public byte field11_0x1c {
      set {
        NWNXLibPINVOKE.CNWSync_ManifestMetaData_field11_0x1c_set(swigCPtr, value);
      } 
      get {
        byte retVal = NWNXLibPINVOKE.CNWSync_ManifestMetaData_field11_0x1c_get(swigCPtr);
        return retVal;
      }
  
    }
  
    public byte field12_0x1d {
      set {
        NWNXLibPINVOKE.CNWSync_ManifestMetaData_field12_0x1d_set(swigCPtr, value);
      } 
      get {
        byte retVal = NWNXLibPINVOKE.CNWSync_ManifestMetaData_field12_0x1d_get(swigCPtr);
        return retVal;
      }
  
    }
  
    public byte field13_0x1e {
      set {
        NWNXLibPINVOKE.CNWSync_ManifestMetaData_field13_0x1e_set(swigCPtr, value);
      } 
      get {
        byte retVal = NWNXLibPINVOKE.CNWSync_ManifestMetaData_field13_0x1e_get(swigCPtr);
        return retVal;
      }
  
    }
  
    public byte field14_0x1f {
      set {
        NWNXLibPINVOKE.CNWSync_ManifestMetaData_field14_0x1f_set(swigCPtr, value);
      } 
      get {
        byte retVal = NWNXLibPINVOKE.CNWSync_ManifestMetaData_field14_0x1f_get(swigCPtr);
        return retVal;
      }
  
    }
  
    public byte field15_0x20 {
      set {
        NWNXLibPINVOKE.CNWSync_ManifestMetaData_field15_0x20_set(swigCPtr, value);
      } 
      get {
        byte retVal = NWNXLibPINVOKE.CNWSync_ManifestMetaData_field15_0x20_get(swigCPtr);
        return retVal;
      }
  
    }
  
    public byte field16_0x21 {
      set {
        NWNXLibPINVOKE.CNWSync_ManifestMetaData_field16_0x21_set(swigCPtr, value);
      } 
      get {
        byte retVal = NWNXLibPINVOKE.CNWSync_ManifestMetaData_field16_0x21_get(swigCPtr);
        return retVal;
      }
  
    }
  
    public byte field17_0x22 {
      set {
        NWNXLibPINVOKE.CNWSync_ManifestMetaData_field17_0x22_set(swigCPtr, value);
      } 
      get {
        byte retVal = NWNXLibPINVOKE.CNWSync_ManifestMetaData_field17_0x22_get(swigCPtr);
        return retVal;
      }
  
    }
  
    public byte field18_0x23 {
      set {
        NWNXLibPINVOKE.CNWSync_ManifestMetaData_field18_0x23_set(swigCPtr, value);
      } 
      get {
        byte retVal = NWNXLibPINVOKE.CNWSync_ManifestMetaData_field18_0x23_get(swigCPtr);
        return retVal;
      }
  
    }
  
    public byte field19_0x24 {
      set {
        NWNXLibPINVOKE.CNWSync_ManifestMetaData_field19_0x24_set(swigCPtr, value);
      } 
      get {
        byte retVal = NWNXLibPINVOKE.CNWSync_ManifestMetaData_field19_0x24_get(swigCPtr);
        return retVal;
      }
  
    }
  
    public byte field20_0x25 {
      set {
        NWNXLibPINVOKE.CNWSync_ManifestMetaData_field20_0x25_set(swigCPtr, value);
      } 
      get {
        byte retVal = NWNXLibPINVOKE.CNWSync_ManifestMetaData_field20_0x25_get(swigCPtr);
        return retVal;
      }
  
    }
  
    public byte field21_0x26 {
      set {
        NWNXLibPINVOKE.CNWSync_ManifestMetaData_field21_0x26_set(swigCPtr, value);
      } 
      get {
        byte retVal = NWNXLibPINVOKE.CNWSync_ManifestMetaData_field21_0x26_get(swigCPtr);
        return retVal;
      }
  
    }
  
    public byte field22_0x27 {
      set {
        NWNXLibPINVOKE.CNWSync_ManifestMetaData_field22_0x27_set(swigCPtr, value);
      } 
      get {
        byte retVal = NWNXLibPINVOKE.CNWSync_ManifestMetaData_field22_0x27_get(swigCPtr);
        return retVal;
      }
  
    }
  
    public byte field23_0x28 {
      set {
        NWNXLibPINVOKE.CNWSync_ManifestMetaData_field23_0x28_set(swigCPtr, value);
      } 
      get {
        byte retVal = NWNXLibPINVOKE.CNWSync_ManifestMetaData_field23_0x28_get(swigCPtr);
        return retVal;
      }
  
    }
  
    public byte field24_0x29 {
      set {
        NWNXLibPINVOKE.CNWSync_ManifestMetaData_field24_0x29_set(swigCPtr, value);
      } 
      get {
        byte retVal = NWNXLibPINVOKE.CNWSync_ManifestMetaData_field24_0x29_get(swigCPtr);
        return retVal;
      }
  
    }
  
    public byte field25_0x2a {
      set {
        NWNXLibPINVOKE.CNWSync_ManifestMetaData_field25_0x2a_set(swigCPtr, value);
      } 
      get {
        byte retVal = NWNXLibPINVOKE.CNWSync_ManifestMetaData_field25_0x2a_get(swigCPtr);
        return retVal;
      }
  
    }
  
    public byte field26_0x2b {
      set {
        NWNXLibPINVOKE.CNWSync_ManifestMetaData_field26_0x2b_set(swigCPtr, value);
      } 
      get {
        byte retVal = NWNXLibPINVOKE.CNWSync_ManifestMetaData_field26_0x2b_get(swigCPtr);
        return retVal;
      }
  
    }
  
    public byte field27_0x2c {
      set {
        NWNXLibPINVOKE.CNWSync_ManifestMetaData_field27_0x2c_set(swigCPtr, value);
      } 
      get {
        byte retVal = NWNXLibPINVOKE.CNWSync_ManifestMetaData_field27_0x2c_get(swigCPtr);
        return retVal;
      }
  
    }
  
    public byte field28_0x2d {
      set {
        NWNXLibPINVOKE.CNWSync_ManifestMetaData_field28_0x2d_set(swigCPtr, value);
      } 
      get {
        byte retVal = NWNXLibPINVOKE.CNWSync_ManifestMetaData_field28_0x2d_get(swigCPtr);
        return retVal;
      }
  
    }
  
    public byte field29_0x2e {
      set {
        NWNXLibPINVOKE.CNWSync_ManifestMetaData_field29_0x2e_set(swigCPtr, value);
      } 
      get {
        byte retVal = NWNXLibPINVOKE.CNWSync_ManifestMetaData_field29_0x2e_get(swigCPtr);
        return retVal;
      }
  
    }
  
    public byte field30_0x2f {
      set {
        NWNXLibPINVOKE.CNWSync_ManifestMetaData_field30_0x2f_set(swigCPtr, value);
      } 
      get {
        byte retVal = NWNXLibPINVOKE.CNWSync_ManifestMetaData_field30_0x2f_get(swigCPtr);
        return retVal;
      }
  
    }
  
    public byte field31_0x30 {
      set {
        NWNXLibPINVOKE.CNWSync_ManifestMetaData_field31_0x30_set(swigCPtr, value);
      } 
      get {
        byte retVal = NWNXLibPINVOKE.CNWSync_ManifestMetaData_field31_0x30_get(swigCPtr);
        return retVal;
      }
  
    }
  
    public byte field32_0x31 {
      set {
        NWNXLibPINVOKE.CNWSync_ManifestMetaData_field32_0x31_set(swigCPtr, value);
      } 
      get {
        byte retVal = NWNXLibPINVOKE.CNWSync_ManifestMetaData_field32_0x31_get(swigCPtr);
        return retVal;
      }
  
    }
  
    public byte field33_0x32 {
      set {
        NWNXLibPINVOKE.CNWSync_ManifestMetaData_field33_0x32_set(swigCPtr, value);
      } 
      get {
        byte retVal = NWNXLibPINVOKE.CNWSync_ManifestMetaData_field33_0x32_get(swigCPtr);
        return retVal;
      }
  
    }
  
    public byte field34_0x33 {
      set {
        NWNXLibPINVOKE.CNWSync_ManifestMetaData_field34_0x33_set(swigCPtr, value);
      } 
      get {
        byte retVal = NWNXLibPINVOKE.CNWSync_ManifestMetaData_field34_0x33_get(swigCPtr);
        return retVal;
      }
  
    }
  
    public byte field35_0x34 {
      set {
        NWNXLibPINVOKE.CNWSync_ManifestMetaData_field35_0x34_set(swigCPtr, value);
      } 
      get {
        byte retVal = NWNXLibPINVOKE.CNWSync_ManifestMetaData_field35_0x34_get(swigCPtr);
        return retVal;
      }
  
    }
  
    public byte field36_0x35 {
      set {
        NWNXLibPINVOKE.CNWSync_ManifestMetaData_field36_0x35_set(swigCPtr, value);
      } 
      get {
        byte retVal = NWNXLibPINVOKE.CNWSync_ManifestMetaData_field36_0x35_get(swigCPtr);
        return retVal;
      }
  
    }
  
    public byte field37_0x36 {
      set {
        NWNXLibPINVOKE.CNWSync_ManifestMetaData_field37_0x36_set(swigCPtr, value);
      } 
      get {
        byte retVal = NWNXLibPINVOKE.CNWSync_ManifestMetaData_field37_0x36_get(swigCPtr);
        return retVal;
      }
  
    }
  
    public byte field38_0x37 {
      set {
        NWNXLibPINVOKE.CNWSync_ManifestMetaData_field38_0x37_set(swigCPtr, value);
      } 
      get {
        byte retVal = NWNXLibPINVOKE.CNWSync_ManifestMetaData_field38_0x37_get(swigCPtr);
        return retVal;
      }
  
    }
  
    public byte field39_0x38 {
      set {
        NWNXLibPINVOKE.CNWSync_ManifestMetaData_field39_0x38_set(swigCPtr, value);
      } 
      get {
        byte retVal = NWNXLibPINVOKE.CNWSync_ManifestMetaData_field39_0x38_get(swigCPtr);
        return retVal;
      }
  
    }
  
    public byte field40_0x39 {
      set {
        NWNXLibPINVOKE.CNWSync_ManifestMetaData_field40_0x39_set(swigCPtr, value);
      } 
      get {
        byte retVal = NWNXLibPINVOKE.CNWSync_ManifestMetaData_field40_0x39_get(swigCPtr);
        return retVal;
      }
  
    }
  
    public byte field41_0x3a {
      set {
        NWNXLibPINVOKE.CNWSync_ManifestMetaData_field41_0x3a_set(swigCPtr, value);
      } 
      get {
        byte retVal = NWNXLibPINVOKE.CNWSync_ManifestMetaData_field41_0x3a_get(swigCPtr);
        return retVal;
      }
  
    }
  
    public byte field42_0x3b {
      set {
        NWNXLibPINVOKE.CNWSync_ManifestMetaData_field42_0x3b_set(swigCPtr, value);
      } 
      get {
        byte retVal = NWNXLibPINVOKE.CNWSync_ManifestMetaData_field42_0x3b_get(swigCPtr);
        return retVal;
      }
  
    }
  
    public byte field43_0x3c {
      set {
        NWNXLibPINVOKE.CNWSync_ManifestMetaData_field43_0x3c_set(swigCPtr, value);
      } 
      get {
        byte retVal = NWNXLibPINVOKE.CNWSync_ManifestMetaData_field43_0x3c_get(swigCPtr);
        return retVal;
      }
  
    }
  
    public byte field44_0x3d {
      set {
        NWNXLibPINVOKE.CNWSync_ManifestMetaData_field44_0x3d_set(swigCPtr, value);
      } 
      get {
        byte retVal = NWNXLibPINVOKE.CNWSync_ManifestMetaData_field44_0x3d_get(swigCPtr);
        return retVal;
      }
  
    }
  
    public byte field45_0x3e {
      set {
        NWNXLibPINVOKE.CNWSync_ManifestMetaData_field45_0x3e_set(swigCPtr, value);
      } 
      get {
        byte retVal = NWNXLibPINVOKE.CNWSync_ManifestMetaData_field45_0x3e_get(swigCPtr);
        return retVal;
      }
  
    }
  
    public byte field46_0x3f {
      set {
        NWNXLibPINVOKE.CNWSync_ManifestMetaData_field46_0x3f_set(swigCPtr, value);
      } 
      get {
        byte retVal = NWNXLibPINVOKE.CNWSync_ManifestMetaData_field46_0x3f_get(swigCPtr);
        return retVal;
      }
  
    }
  
    public byte field47_0x40 {
      set {
        NWNXLibPINVOKE.CNWSync_ManifestMetaData_field47_0x40_set(swigCPtr, value);
      } 
      get {
        byte retVal = NWNXLibPINVOKE.CNWSync_ManifestMetaData_field47_0x40_get(swigCPtr);
        return retVal;
      }
  
    }
  
    public byte field48_0x41 {
      set {
        NWNXLibPINVOKE.CNWSync_ManifestMetaData_field48_0x41_set(swigCPtr, value);
      } 
      get {
        byte retVal = NWNXLibPINVOKE.CNWSync_ManifestMetaData_field48_0x41_get(swigCPtr);
        return retVal;
      }
  
    }
  
    public byte field49_0x42 {
      set {
        NWNXLibPINVOKE.CNWSync_ManifestMetaData_field49_0x42_set(swigCPtr, value);
      } 
      get {
        byte retVal = NWNXLibPINVOKE.CNWSync_ManifestMetaData_field49_0x42_get(swigCPtr);
        return retVal;
      }
  
    }
  
    public byte field50_0x43 {
      set {
        NWNXLibPINVOKE.CNWSync_ManifestMetaData_field50_0x43_set(swigCPtr, value);
      } 
      get {
        byte retVal = NWNXLibPINVOKE.CNWSync_ManifestMetaData_field50_0x43_get(swigCPtr);
        return retVal;
      }
  
    }
  
    public byte field51_0x44 {
      set {
        NWNXLibPINVOKE.CNWSync_ManifestMetaData_field51_0x44_set(swigCPtr, value);
      } 
      get {
        byte retVal = NWNXLibPINVOKE.CNWSync_ManifestMetaData_field51_0x44_get(swigCPtr);
        return retVal;
      }
  
    }
  
    public byte field52_0x45 {
      set {
        NWNXLibPINVOKE.CNWSync_ManifestMetaData_field52_0x45_set(swigCPtr, value);
      } 
      get {
        byte retVal = NWNXLibPINVOKE.CNWSync_ManifestMetaData_field52_0x45_get(swigCPtr);
        return retVal;
      }
  
    }
  
    public byte field53_0x46 {
      set {
        NWNXLibPINVOKE.CNWSync_ManifestMetaData_field53_0x46_set(swigCPtr, value);
      } 
      get {
        byte retVal = NWNXLibPINVOKE.CNWSync_ManifestMetaData_field53_0x46_get(swigCPtr);
        return retVal;
      }
  
    }
  
    public byte field54_0x47 {
      set {
        NWNXLibPINVOKE.CNWSync_ManifestMetaData_field54_0x47_set(swigCPtr, value);
      } 
      get {
        byte retVal = NWNXLibPINVOKE.CNWSync_ManifestMetaData_field54_0x47_get(swigCPtr);
        return retVal;
      }
  
    }
  
    public byte field55_0x48 {
      set {
        NWNXLibPINVOKE.CNWSync_ManifestMetaData_field55_0x48_set(swigCPtr, value);
      } 
      get {
        byte retVal = NWNXLibPINVOKE.CNWSync_ManifestMetaData_field55_0x48_get(swigCPtr);
        return retVal;
      }
  
    }
  
    public byte field56_0x49 {
      set {
        NWNXLibPINVOKE.CNWSync_ManifestMetaData_field56_0x49_set(swigCPtr, value);
      } 
      get {
        byte retVal = NWNXLibPINVOKE.CNWSync_ManifestMetaData_field56_0x49_get(swigCPtr);
        return retVal;
      }
  
    }
  
    public byte field57_0x4a {
      set {
        NWNXLibPINVOKE.CNWSync_ManifestMetaData_field57_0x4a_set(swigCPtr, value);
      } 
      get {
        byte retVal = NWNXLibPINVOKE.CNWSync_ManifestMetaData_field57_0x4a_get(swigCPtr);
        return retVal;
      }
  
    }
  
    public byte field58_0x4b {
      set {
        NWNXLibPINVOKE.CNWSync_ManifestMetaData_field58_0x4b_set(swigCPtr, value);
      } 
      get {
        byte retVal = NWNXLibPINVOKE.CNWSync_ManifestMetaData_field58_0x4b_get(swigCPtr);
        return retVal;
      }
  
    }
  
    public byte field59_0x4c {
      set {
        NWNXLibPINVOKE.CNWSync_ManifestMetaData_field59_0x4c_set(swigCPtr, value);
      } 
      get {
        byte retVal = NWNXLibPINVOKE.CNWSync_ManifestMetaData_field59_0x4c_get(swigCPtr);
        return retVal;
      }
  
    }
  
    public byte field60_0x4d {
      set {
        NWNXLibPINVOKE.CNWSync_ManifestMetaData_field60_0x4d_set(swigCPtr, value);
      } 
      get {
        byte retVal = NWNXLibPINVOKE.CNWSync_ManifestMetaData_field60_0x4d_get(swigCPtr);
        return retVal;
      }
  
    }
  
    public byte field61_0x4e {
      set {
        NWNXLibPINVOKE.CNWSync_ManifestMetaData_field61_0x4e_set(swigCPtr, value);
      } 
      get {
        byte retVal = NWNXLibPINVOKE.CNWSync_ManifestMetaData_field61_0x4e_get(swigCPtr);
        return retVal;
      }
  
    }
  
    public byte field62_0x4f {
      set {
        NWNXLibPINVOKE.CNWSync_ManifestMetaData_field62_0x4f_set(swigCPtr, value);
      } 
      get {
        byte retVal = NWNXLibPINVOKE.CNWSync_ManifestMetaData_field62_0x4f_get(swigCPtr);
        return retVal;
      }
  
    }
  
    public byte field63_0x50 {
      set {
        NWNXLibPINVOKE.CNWSync_ManifestMetaData_field63_0x50_set(swigCPtr, value);
      } 
      get {
        byte retVal = NWNXLibPINVOKE.CNWSync_ManifestMetaData_field63_0x50_get(swigCPtr);
        return retVal;
      }
  
    }
  
    public byte field64_0x51 {
      set {
        NWNXLibPINVOKE.CNWSync_ManifestMetaData_field64_0x51_set(swigCPtr, value);
      } 
      get {
        byte retVal = NWNXLibPINVOKE.CNWSync_ManifestMetaData_field64_0x51_get(swigCPtr);
        return retVal;
      }
  
    }
  
    public byte field65_0x52 {
      set {
        NWNXLibPINVOKE.CNWSync_ManifestMetaData_field65_0x52_set(swigCPtr, value);
      } 
      get {
        byte retVal = NWNXLibPINVOKE.CNWSync_ManifestMetaData_field65_0x52_get(swigCPtr);
        return retVal;
      }
  
    }
  
    public byte field66_0x53 {
      set {
        NWNXLibPINVOKE.CNWSync_ManifestMetaData_field66_0x53_set(swigCPtr, value);
      } 
      get {
        byte retVal = NWNXLibPINVOKE.CNWSync_ManifestMetaData_field66_0x53_get(swigCPtr);
        return retVal;
      }
  
    }
  
    public byte field67_0x54 {
      set {
        NWNXLibPINVOKE.CNWSync_ManifestMetaData_field67_0x54_set(swigCPtr, value);
      } 
      get {
        byte retVal = NWNXLibPINVOKE.CNWSync_ManifestMetaData_field67_0x54_get(swigCPtr);
        return retVal;
      }
  
    }
  
    public byte field68_0x55 {
      set {
        NWNXLibPINVOKE.CNWSync_ManifestMetaData_field68_0x55_set(swigCPtr, value);
      } 
      get {
        byte retVal = NWNXLibPINVOKE.CNWSync_ManifestMetaData_field68_0x55_get(swigCPtr);
        return retVal;
      }
  
    }
  
    public byte field69_0x56 {
      set {
        NWNXLibPINVOKE.CNWSync_ManifestMetaData_field69_0x56_set(swigCPtr, value);
      } 
      get {
        byte retVal = NWNXLibPINVOKE.CNWSync_ManifestMetaData_field69_0x56_get(swigCPtr);
        return retVal;
      }
  
    }
  
    public byte field70_0x57 {
      set {
        NWNXLibPINVOKE.CNWSync_ManifestMetaData_field70_0x57_set(swigCPtr, value);
      } 
      get {
        byte retVal = NWNXLibPINVOKE.CNWSync_ManifestMetaData_field70_0x57_get(swigCPtr);
        return retVal;
      }
  
    }
  
    public byte field71_0x58 {
      set {
        NWNXLibPINVOKE.CNWSync_ManifestMetaData_field71_0x58_set(swigCPtr, value);
      } 
      get {
        byte retVal = NWNXLibPINVOKE.CNWSync_ManifestMetaData_field71_0x58_get(swigCPtr);
        return retVal;
      }
  
    }
  
    public byte field72_0x59 {
      set {
        NWNXLibPINVOKE.CNWSync_ManifestMetaData_field72_0x59_set(swigCPtr, value);
      } 
      get {
        byte retVal = NWNXLibPINVOKE.CNWSync_ManifestMetaData_field72_0x59_get(swigCPtr);
        return retVal;
      }
  
    }
  
    public byte field73_0x5a {
      set {
        NWNXLibPINVOKE.CNWSync_ManifestMetaData_field73_0x5a_set(swigCPtr, value);
      } 
      get {
        byte retVal = NWNXLibPINVOKE.CNWSync_ManifestMetaData_field73_0x5a_get(swigCPtr);
        return retVal;
      }
  
    }
  
    public byte field74_0x5b {
      set {
        NWNXLibPINVOKE.CNWSync_ManifestMetaData_field74_0x5b_set(swigCPtr, value);
      } 
      get {
        byte retVal = NWNXLibPINVOKE.CNWSync_ManifestMetaData_field74_0x5b_get(swigCPtr);
        return retVal;
      }
  
    }
  
    public byte field75_0x5c {
      set {
        NWNXLibPINVOKE.CNWSync_ManifestMetaData_field75_0x5c_set(swigCPtr, value);
      } 
      get {
        byte retVal = NWNXLibPINVOKE.CNWSync_ManifestMetaData_field75_0x5c_get(swigCPtr);
        return retVal;
      }
  
    }
  
    public byte field76_0x5d {
      set {
        NWNXLibPINVOKE.CNWSync_ManifestMetaData_field76_0x5d_set(swigCPtr, value);
      } 
      get {
        byte retVal = NWNXLibPINVOKE.CNWSync_ManifestMetaData_field76_0x5d_get(swigCPtr);
        return retVal;
      }
  
    }
  
    public byte field77_0x5e {
      set {
        NWNXLibPINVOKE.CNWSync_ManifestMetaData_field77_0x5e_set(swigCPtr, value);
      } 
      get {
        byte retVal = NWNXLibPINVOKE.CNWSync_ManifestMetaData_field77_0x5e_get(swigCPtr);
        return retVal;
      }
  
    }
  
    public byte field78_0x5f {
      set {
        NWNXLibPINVOKE.CNWSync_ManifestMetaData_field78_0x5f_set(swigCPtr, value);
      } 
      get {
        byte retVal = NWNXLibPINVOKE.CNWSync_ManifestMetaData_field78_0x5f_get(swigCPtr);
        return retVal;
      }
  
    }
  
    public byte field79_0x60 {
      set {
        NWNXLibPINVOKE.CNWSync_ManifestMetaData_field79_0x60_set(swigCPtr, value);
      } 
      get {
        byte retVal = NWNXLibPINVOKE.CNWSync_ManifestMetaData_field79_0x60_get(swigCPtr);
        return retVal;
      }
  
    }
  
    public byte field80_0x61 {
      set {
        NWNXLibPINVOKE.CNWSync_ManifestMetaData_field80_0x61_set(swigCPtr, value);
      } 
      get {
        byte retVal = NWNXLibPINVOKE.CNWSync_ManifestMetaData_field80_0x61_get(swigCPtr);
        return retVal;
      }
  
    }
  
    public byte field81_0x62 {
      set {
        NWNXLibPINVOKE.CNWSync_ManifestMetaData_field81_0x62_set(swigCPtr, value);
      } 
      get {
        byte retVal = NWNXLibPINVOKE.CNWSync_ManifestMetaData_field81_0x62_get(swigCPtr);
        return retVal;
      }
  
    }
  
    public byte field82_0x63 {
      set {
        NWNXLibPINVOKE.CNWSync_ManifestMetaData_field82_0x63_set(swigCPtr, value);
      } 
      get {
        byte retVal = NWNXLibPINVOKE.CNWSync_ManifestMetaData_field82_0x63_get(swigCPtr);
        return retVal;
      }
  
    }
  
    public byte field83_0x64 {
      set {
        NWNXLibPINVOKE.CNWSync_ManifestMetaData_field83_0x64_set(swigCPtr, value);
      } 
      get {
        byte retVal = NWNXLibPINVOKE.CNWSync_ManifestMetaData_field83_0x64_get(swigCPtr);
        return retVal;
      }
  
    }
  
    public byte field84_0x65 {
      set {
        NWNXLibPINVOKE.CNWSync_ManifestMetaData_field84_0x65_set(swigCPtr, value);
      } 
      get {
        byte retVal = NWNXLibPINVOKE.CNWSync_ManifestMetaData_field84_0x65_get(swigCPtr);
        return retVal;
      }
  
    }
  
    public byte field85_0x66 {
      set {
        NWNXLibPINVOKE.CNWSync_ManifestMetaData_field85_0x66_set(swigCPtr, value);
      } 
      get {
        byte retVal = NWNXLibPINVOKE.CNWSync_ManifestMetaData_field85_0x66_get(swigCPtr);
        return retVal;
      }
  
    }
  
    public byte field86_0x67 {
      set {
        NWNXLibPINVOKE.CNWSync_ManifestMetaData_field86_0x67_set(swigCPtr, value);
      } 
      get {
        byte retVal = NWNXLibPINVOKE.CNWSync_ManifestMetaData_field86_0x67_get(swigCPtr);
        return retVal;
      }
  
    }
  
    public long field87_0x68 {
      set {
        NWNXLibPINVOKE.CNWSync_ManifestMetaData_field87_0x68_set(swigCPtr, value);
      } 
      get {
        long ret = NWNXLibPINVOKE.CNWSync_ManifestMetaData_field87_0x68_get(swigCPtr);
        return ret;
      } 
    }
  
    public long field88_0x70 {
      set {
        NWNXLibPINVOKE.CNWSync_ManifestMetaData_field88_0x70_set(swigCPtr, value);
      } 
      get {
        long ret = NWNXLibPINVOKE.CNWSync_ManifestMetaData_field88_0x70_get(swigCPtr);
        return ret;
      } 
    }
  
    public ManifestMetaData() : this(NWNXLibPINVOKE.new_CNWSync_ManifestMetaData(), true) {
    }
  
  }

  public CNWSync() : this(NWNXLibPINVOKE.new_CNWSync(), true) {
  }

}

}

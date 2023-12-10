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

public unsafe class DataView : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  private bool swigCMemOwnBase;

  internal DataView(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwnBase = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(DataView obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~DataView() {
    Dispose(false);
  }

  public void Dispose() {
    Dispose(true);
    global::System.GC.SuppressFinalize(this);
  }

  protected virtual void Dispose(bool disposing) {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwnBase) {
          swigCMemOwnBase = false;
          NWNXLibPINVOKE.delete_DataView(swigCPtr);
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

  public static unsafe implicit operator void*(DataView self) {
    return (void*)self.swigCPtr.Handle;
  }

  public static unsafe DataView FromPointer(void* pointer, bool memoryOwn = false) {
    return pointer != null ? new DataView((global::System.IntPtr)pointer, memoryOwn) : null;
  }

  public static DataView FromPointer(global::System.IntPtr pointer, bool memoryOwn = false) {
    return pointer != global::System.IntPtr.Zero ? new DataView(pointer, memoryOwn) : null;
  }

  public bool Equals(DataView other) {
    if (ReferenceEquals(null, other)) {
      return false;
    }

    if (ReferenceEquals(this, other)) {
      return true;
    }

    return Pointer.Equals(other.Pointer);
  }

  public override bool Equals(object obj) {
    return ReferenceEquals(this, obj) || obj is DataView other && Equals(other);
  }

  public override int GetHashCode() {
    return swigCPtr.Handle.GetHashCode();
  }

  public static bool operator ==(DataView left, DataView right) {
    return Equals(left, right);
  }

  public static bool operator !=(DataView left, DataView right) {
    return !Equals(left, right);
  }

  public unsafe class Shared : global::System.IDisposable {
    private global::System.Runtime.InteropServices.HandleRef swigCPtr;
    private bool swigCMemOwnBase;
  
    internal Shared(global::System.IntPtr cPtr, bool cMemoryOwn) {
      swigCMemOwnBase = cMemoryOwn;
      swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
    }
  
    internal static global::System.Runtime.InteropServices.HandleRef getCPtr(Shared obj) {
      return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
    }
  
    ~Shared() {
      Dispose(false);
    }
  
    public void Dispose() {
      Dispose(true);
      global::System.GC.SuppressFinalize(this);
    }
  
    protected virtual void Dispose(bool disposing) {
      lock(this) {
        if (swigCPtr.Handle != global::System.IntPtr.Zero) {
          if (swigCMemOwnBase) {
            swigCMemOwnBase = false;
            NWNXLibPINVOKE.delete_DataView_Shared(swigCPtr);
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
  
    public static unsafe implicit operator void*(Shared self) {
      return (void*)self.swigCPtr.Handle;
    }
  
    public static unsafe Shared FromPointer(void* pointer, bool memoryOwn = false) {
      return pointer != null ? new Shared((global::System.IntPtr)pointer, memoryOwn) : null;
    }
  
    public static Shared FromPointer(global::System.IntPtr pointer, bool memoryOwn = false) {
      return pointer != global::System.IntPtr.Zero ? new Shared(pointer, memoryOwn) : null;
    }
  
    public bool Equals(Shared other) {
      if (ReferenceEquals(null, other)) {
        return false;
      }
  
      if (ReferenceEquals(this, other)) {
        return true;
      }
  
      return Pointer.Equals(other.Pointer);
    }
  
    public override bool Equals(object obj) {
      return ReferenceEquals(this, obj) || obj is Shared other && Equals(other);
    }
  
    public override int GetHashCode() {
      return swigCPtr.Handle.GetHashCode();
    }
  
    public static bool operator ==(Shared left, Shared right) {
      return Equals(left, right);
    }
  
    public static bool operator !=(Shared left, Shared right) {
      return !Equals(left, right);
    }
  
    public Shared(void* data, uint used, uint allocated, bool owned) : this(NWNXLibPINVOKE.new_DataView_Shared((global::System.IntPtr)data, used, allocated, owned), true) {
    }
  
    public void* m_data {
      set {
        NWNXLibPINVOKE.DataView_Shared_m_data_set(swigCPtr, (global::System.IntPtr)value);
        if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
      } 
      get {
          global::System.IntPtr retVal = NWNXLibPINVOKE.DataView_Shared_m_data_get(swigCPtr);
        if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
          return (void*)retVal;
      }
  
    }
  
    public uint m_used {
      set {
        NWNXLibPINVOKE.DataView_Shared_m_used_set(swigCPtr, value);
        if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
      } 
      get {
        uint ret = NWNXLibPINVOKE.DataView_Shared_m_used_get(swigCPtr);
        if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
        return ret;
      } 
    }
  
    public uint m_allocated {
      set {
        NWNXLibPINVOKE.DataView_Shared_m_allocated_set(swigCPtr, value);
        if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
      } 
      get {
        uint ret = NWNXLibPINVOKE.DataView_Shared_m_allocated_get(swigCPtr);
        if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
        return ret;
      } 
    }
  
    public bool m_owned {
      set {
        NWNXLibPINVOKE.DataView_Shared_m_owned_set(swigCPtr, value);
        if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
      } 
      get {
        bool ret = NWNXLibPINVOKE.DataView_Shared_m_owned_get(swigCPtr);
        if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
        return ret;
      } 
    }
  
  }

  public DataView.Shared m_shared {
    set {
      NWNXLibPINVOKE.DataView_m_shared_set(swigCPtr, DataView.Shared.getCPtr(value));
      if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      global::System.IntPtr cPtr = NWNXLibPINVOKE.DataView_m_shared_get(swigCPtr);
      DataView.Shared ret = (cPtr == global::System.IntPtr.Zero) ? null : new DataView.Shared(cPtr, true);
      if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public DataView.Shared m_parent {
    set {
      NWNXLibPINVOKE.DataView_m_parent_set(swigCPtr, DataView.Shared.getCPtr(value));
      if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      global::System.IntPtr cPtr = NWNXLibPINVOKE.DataView_m_parent_get(swigCPtr);
      DataView.Shared ret = (cPtr == global::System.IntPtr.Zero) ? null : new DataView.Shared(cPtr, true);
      if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public DataView(void* data, uint length) : this(NWNXLibPINVOKE.new_DataView((global::System.IntPtr)data, length), true) {
  }

  public void* Data() {
    global::System.IntPtr retVal = NWNXLibPINVOKE.DataView_Data(swigCPtr);
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
    return (void*)retVal;
  }

  public uint Used() {
    uint ret = NWNXLibPINVOKE.DataView_Used(swigCPtr);
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public uint Allocated() {
    uint ret = NWNXLibPINVOKE.DataView_Allocated(swigCPtr);
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public DataView View(uint offset, uint count) {
    global::System.IntPtr cPtr = NWNXLibPINVOKE.DataView_View(swigCPtr, offset, count);
    DataView ret = (cPtr == global::System.IntPtr.Zero) ? null : new DataView(cPtr, true);
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public DataBlock MakeCopy() {
    global::System.IntPtr cPtr = NWNXLibPINVOKE.DataView_MakeCopy(swigCPtr);
    DataBlock ret = (cPtr == global::System.IntPtr.Zero) ? null : new DataBlock(cPtr, true);
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool empty() {
    bool ret = NWNXLibPINVOKE.DataView_empty(swigCPtr);
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

}

}

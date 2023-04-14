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

public unsafe class CVirtualMachineScript : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal CVirtualMachineScript(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(CVirtualMachineScript obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~CVirtualMachineScript() {
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
          NWNXLibPINVOKE.delete_CVirtualMachineScript(swigCPtr);
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

  public static unsafe implicit operator void*(CVirtualMachineScript self) {
    return (void*)self.swigCPtr.Handle;
  }

  public static unsafe CVirtualMachineScript FromPointer(void* pointer, bool memoryOwn = false) {
    return pointer != null ? new CVirtualMachineScript((global::System.IntPtr)pointer, memoryOwn) : null;
  }

  public static CVirtualMachineScript FromPointer(global::System.IntPtr pointer, bool memoryOwn = false) {
    return pointer != global::System.IntPtr.Zero ? new CVirtualMachineScript(pointer, memoryOwn) : null;
  }

  public bool Equals(CVirtualMachineScript other) {
    if (ReferenceEquals(null, other)) {
      return false;
    }

    if (ReferenceEquals(this, other)) {
      return true;
    }

    return Pointer.Equals(other.Pointer);
  }

  public override bool Equals(object obj) {
    return ReferenceEquals(this, obj) || obj is CVirtualMachineScript other && Equals(other);
  }

  public override int GetHashCode() {
    return swigCPtr.Handle.GetHashCode();
  }

  public static bool operator ==(CVirtualMachineScript left, CVirtualMachineScript right) {
    return Equals(left, right);
  }

  public static bool operator !=(CVirtualMachineScript left, CVirtualMachineScript right) {
    return !Equals(left, right);
  }

  public CVirtualMachineStack m_pStack {
    set {
      NWNXLibPINVOKE.CVirtualMachineScript_m_pStack_set(swigCPtr, CVirtualMachineStack.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = NWNXLibPINVOKE.CVirtualMachineScript_m_pStack_get(swigCPtr);
      CVirtualMachineStack ret = (cPtr == global::System.IntPtr.Zero) ? null : new CVirtualMachineStack(cPtr, false);
      return ret;
    } 
  }

  public int m_nStackSize {
    set {
      NWNXLibPINVOKE.CVirtualMachineScript_m_nStackSize_set(swigCPtr, value);
    } 
    get {
      int retVal = NWNXLibPINVOKE.CVirtualMachineScript_m_nStackSize_get(swigCPtr);
      return retVal;
    }

  }

  public int m_nInstructPtr {
    set {
      NWNXLibPINVOKE.CVirtualMachineScript_m_nInstructPtr_set(swigCPtr, value);
    } 
    get {
      int retVal = NWNXLibPINVOKE.CVirtualMachineScript_m_nInstructPtr_get(swigCPtr);
      return retVal;
    }

  }

  public int m_nSecondaryInstructPtr {
    set {
      NWNXLibPINVOKE.CVirtualMachineScript_m_nSecondaryInstructPtr_set(swigCPtr, value);
    } 
    get {
      int retVal = NWNXLibPINVOKE.CVirtualMachineScript_m_nSecondaryInstructPtr_get(swigCPtr);
      return retVal;
    }

  }

  public CExoString m_sScriptName {
    set {
      NWNXLibPINVOKE.CVirtualMachineScript_m_sScriptName_set(swigCPtr, CExoString.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = NWNXLibPINVOKE.CVirtualMachineScript_m_sScriptName_get(swigCPtr);
      CExoString ret = (cPtr == global::System.IntPtr.Zero) ? null : new CExoString(cPtr, false);
      return ret;
    } 
  }

  public SWIGTYPE_p_std__shared_ptrT_DataBlock_t m_pCode {
    set {
      NWNXLibPINVOKE.CVirtualMachineScript_m_pCode_set(swigCPtr, SWIGTYPE_p_std__shared_ptrT_DataBlock_t.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = NWNXLibPINVOKE.CVirtualMachineScript_m_pCode_get(swigCPtr);
      SWIGTYPE_p_std__shared_ptrT_DataBlock_t ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_std__shared_ptrT_DataBlock_t(cPtr, false);
      return ret;
    } 
  }

  public SWIGTYPE_p_std__shared_ptrT_DataBlock_t m_pNDB {
    set {
      NWNXLibPINVOKE.CVirtualMachineScript_m_pNDB_set(swigCPtr, SWIGTYPE_p_std__shared_ptrT_DataBlock_t.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = NWNXLibPINVOKE.CVirtualMachineScript_m_pNDB_get(swigCPtr);
      SWIGTYPE_p_std__shared_ptrT_DataBlock_t ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_std__shared_ptrT_DataBlock_t(cPtr, false);
      return ret;
    } 
  }

  public int m_nScriptEventID {
    set {
      NWNXLibPINVOKE.CVirtualMachineScript_m_nScriptEventID_set(swigCPtr, value);
    } 
    get {
      int retVal = NWNXLibPINVOKE.CVirtualMachineScript_m_nScriptEventID_get(swigCPtr);
      return retVal;
    }

  }

  public unsafe class JmpData : global::System.IDisposable {
    private global::System.Runtime.InteropServices.HandleRef swigCPtr;
    protected bool swigCMemOwn;
  
    internal JmpData(global::System.IntPtr cPtr, bool cMemoryOwn) {
      swigCMemOwn = cMemoryOwn;
      swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
    }
  
    internal static global::System.Runtime.InteropServices.HandleRef getCPtr(JmpData obj) {
      return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
    }
  
    ~JmpData() {
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
            NWNXLibPINVOKE.delete_CVirtualMachineScript_JmpData(swigCPtr);
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
  
    public static unsafe implicit operator void*(JmpData self) {
      return (void*)self.swigCPtr.Handle;
    }
  
    public static unsafe JmpData FromPointer(void* pointer, bool memoryOwn = false) {
      return pointer != null ? new JmpData((global::System.IntPtr)pointer, memoryOwn) : null;
    }
  
    public static JmpData FromPointer(global::System.IntPtr pointer, bool memoryOwn = false) {
      return pointer != global::System.IntPtr.Zero ? new JmpData(pointer, memoryOwn) : null;
    }
  
    public bool Equals(JmpData other) {
      if (ReferenceEquals(null, other)) {
        return false;
      }
  
      if (ReferenceEquals(this, other)) {
        return true;
      }
  
      return Pointer.Equals(other.Pointer);
    }
  
    public override bool Equals(object obj) {
      return ReferenceEquals(this, obj) || obj is JmpData other && Equals(other);
    }
  
    public override int GetHashCode() {
      return swigCPtr.Handle.GetHashCode();
    }
  
    public static bool operator ==(JmpData left, JmpData right) {
      return Equals(left, right);
    }
  
    public static bool operator !=(JmpData left, JmpData right) {
      return !Equals(left, right);
    }
  
      public unsafe class Target : global::System.IDisposable {
        private global::System.Runtime.InteropServices.HandleRef swigCPtr;
        protected bool swigCMemOwn;
      
        internal Target(global::System.IntPtr cPtr, bool cMemoryOwn) {
          swigCMemOwn = cMemoryOwn;
          swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
        }
      
        internal static global::System.Runtime.InteropServices.HandleRef getCPtr(Target obj) {
          return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
        }
      
        ~Target() {
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
                NWNXLibPINVOKE.delete_CVirtualMachineScript_JmpData_Target(swigCPtr);
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
      
        public static unsafe implicit operator void*(Target self) {
          return (void*)self.swigCPtr.Handle;
        }
      
        public static unsafe Target FromPointer(void* pointer, bool memoryOwn = false) {
          return pointer != null ? new Target((global::System.IntPtr)pointer, memoryOwn) : null;
        }
      
        public static Target FromPointer(global::System.IntPtr pointer, bool memoryOwn = false) {
          return pointer != global::System.IntPtr.Zero ? new Target(pointer, memoryOwn) : null;
        }
      
        public bool Equals(Target other) {
          if (ReferenceEquals(null, other)) {
            return false;
          }
      
          if (ReferenceEquals(this, other)) {
            return true;
          }
      
          return Pointer.Equals(other.Pointer);
        }
      
        public override bool Equals(object obj) {
          return ReferenceEquals(this, obj) || obj is Target other && Equals(other);
        }
      
        public override int GetHashCode() {
          return swigCPtr.Handle.GetHashCode();
        }
      
        public static bool operator ==(Target left, Target right) {
          return Equals(left, right);
        }
      
        public static bool operator !=(Target left, Target right) {
          return !Equals(left, right);
        }
      
        public int nVMInstPtr {
          set {
            NWNXLibPINVOKE.CVirtualMachineScript_JmpData_Target_nVMInstPtr_set(swigCPtr, value);
          } 
          get {
            int retVal = NWNXLibPINVOKE.CVirtualMachineScript_JmpData_Target_nVMInstPtr_get(swigCPtr);
            return retVal;
          }
      
        }
      
        public int nInstPtr {
          set {
            NWNXLibPINVOKE.CVirtualMachineScript_JmpData_Target_nInstPtr_set(swigCPtr, value);
          } 
          get {
            int retVal = NWNXLibPINVOKE.CVirtualMachineScript_JmpData_Target_nInstPtr_get(swigCPtr);
            return retVal;
          }
      
        }
      
        public int nStackPtr {
          set {
            NWNXLibPINVOKE.CVirtualMachineScript_JmpData_Target_nStackPtr_set(swigCPtr, value);
          } 
          get {
            int retVal = NWNXLibPINVOKE.CVirtualMachineScript_JmpData_Target_nStackPtr_get(swigCPtr);
            return retVal;
          }
      
        }
      
        public int nInstPtrLevel {
          set {
            NWNXLibPINVOKE.CVirtualMachineScript_JmpData_Target_nInstPtrLevel_set(swigCPtr, value);
          } 
          get {
            int retVal = NWNXLibPINVOKE.CVirtualMachineScript_JmpData_Target_nInstPtrLevel_get(swigCPtr);
            return retVal;
          }
      
        }
      
        public Target() : this(NWNXLibPINVOKE.new_CVirtualMachineScript_JmpData_Target(), true) {
        }
      
      }
  
    public bool bFromLongJmp {
      set {
        NWNXLibPINVOKE.CVirtualMachineScript_JmpData_bFromLongJmp_set(swigCPtr, value);
      } 
      get {
        bool ret = NWNXLibPINVOKE.CVirtualMachineScript_JmpData_bFromLongJmp_get(swigCPtr);
        return ret;
      } 
    }
  
    public int nRetVal {
      set {
        NWNXLibPINVOKE.CVirtualMachineScript_JmpData_nRetVal_set(swigCPtr, value);
      } 
      get {
        int retVal = NWNXLibPINVOKE.CVirtualMachineScript_JmpData_nRetVal_get(swigCPtr);
        return retVal;
      }
  
    }
  
    public CVirtualMachineScript.JmpData.Target cTarget {
      set {
        NWNXLibPINVOKE.CVirtualMachineScript_JmpData_cTarget_set(swigCPtr, CVirtualMachineScript.JmpData.Target.getCPtr(value));
      } 
      get {
        global::System.IntPtr cPtr = NWNXLibPINVOKE.CVirtualMachineScript_JmpData_cTarget_get(swigCPtr);
        CVirtualMachineScript.JmpData.Target ret = (cPtr == global::System.IntPtr.Zero) ? null : new CVirtualMachineScript.JmpData.Target(cPtr, false);
        return ret;
      } 
    }
  
    public JmpData() : this(NWNXLibPINVOKE.new_CVirtualMachineScript_JmpData(), true) {
    }
  
  }

  public SWIGTYPE_p_std__unordered_mapT_std__string_CVirtualMachineScript__JmpData_t m_cLongJmpData {
    set {
      NWNXLibPINVOKE.CVirtualMachineScript_m_cLongJmpData_set(swigCPtr, SWIGTYPE_p_std__unordered_mapT_std__string_CVirtualMachineScript__JmpData_t.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = NWNXLibPINVOKE.CVirtualMachineScript_m_cLongJmpData_get(swigCPtr);
      SWIGTYPE_p_std__unordered_mapT_std__string_CVirtualMachineScript__JmpData_t ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_std__unordered_mapT_std__string_CVirtualMachineScript__JmpData_t(cPtr, false);
      return ret;
    } 
  }

  public CExoString m_sScriptChunk {
    set {
      NWNXLibPINVOKE.CVirtualMachineScript_m_sScriptChunk_set(swigCPtr, CExoString.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = NWNXLibPINVOKE.CVirtualMachineScript_m_sScriptChunk_get(swigCPtr);
      CExoString ret = (cPtr == global::System.IntPtr.Zero) ? null : new CExoString(cPtr, false);
      return ret;
    } 
  }

  public CVirtualMachineScript() : this(NWNXLibPINVOKE.new_CVirtualMachineScript(), true) {
  }

}

}

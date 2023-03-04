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

public unsafe class CScriptParseTreeNode : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal CScriptParseTreeNode(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(CScriptParseTreeNode obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~CScriptParseTreeNode() {
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
          NWNXLibPINVOKE.delete_CScriptParseTreeNode(swigCPtr);
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

  public static unsafe implicit operator void*(CScriptParseTreeNode self) {
    return (void*)self.swigCPtr.Handle;
  }

  public static unsafe CScriptParseTreeNode FromPointer(void* pointer, bool memoryOwn = false) {
    return pointer != null ? new CScriptParseTreeNode((global::System.IntPtr)pointer, memoryOwn) : null;
  }

  public static CScriptParseTreeNode FromPointer(global::System.IntPtr pointer, bool memoryOwn = false) {
    return pointer != global::System.IntPtr.Zero ? new CScriptParseTreeNode(pointer, memoryOwn) : null;
  }

  public bool Equals(CScriptParseTreeNode other) {
    if (ReferenceEquals(null, other)) {
      return false;
    }

    if (ReferenceEquals(this, other)) {
      return true;
    }

    return Pointer.Equals(other.Pointer);
  }

  public override bool Equals(object obj) {
    return ReferenceEquals(this, obj) || obj is CScriptParseTreeNode other && Equals(other);
  }

  public override int GetHashCode() {
    return swigCPtr.Handle.GetHashCode();
  }

  public static bool operator ==(CScriptParseTreeNode left, CScriptParseTreeNode right) {
    return Equals(left, right);
  }

  public static bool operator !=(CScriptParseTreeNode left, CScriptParseTreeNode right) {
    return !Equals(left, right);
  }

  public int nOperation {
    set {
      NWNXLibPINVOKE.CScriptParseTreeNode_nOperation_set(swigCPtr, value);
    } 
    get {
      int retVal = NWNXLibPINVOKE.CScriptParseTreeNode_nOperation_get(swigCPtr);
      return retVal;
    }

  }

  public CExoString m_psStringData {
    set {
      NWNXLibPINVOKE.CScriptParseTreeNode_m_psStringData_set(swigCPtr, CExoString.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = NWNXLibPINVOKE.CScriptParseTreeNode_m_psStringData_get(swigCPtr);
      CExoString ret = (cPtr == global::System.IntPtr.Zero) ? null : new CExoString(cPtr, false);
      return ret;
    } 
  }

  public int nIntegerData {
    set {
      NWNXLibPINVOKE.CScriptParseTreeNode_nIntegerData_set(swigCPtr, value);
    } 
    get {
      int retVal = NWNXLibPINVOKE.CScriptParseTreeNode_nIntegerData_get(swigCPtr);
      return retVal;
    }

  }

  public int nIntegerData2 {
    set {
      NWNXLibPINVOKE.CScriptParseTreeNode_nIntegerData2_set(swigCPtr, value);
    } 
    get {
      int retVal = NWNXLibPINVOKE.CScriptParseTreeNode_nIntegerData2_get(swigCPtr);
      return retVal;
    }

  }

  public int nIntegerData3 {
    set {
      NWNXLibPINVOKE.CScriptParseTreeNode_nIntegerData3_set(swigCPtr, value);
    } 
    get {
      int retVal = NWNXLibPINVOKE.CScriptParseTreeNode_nIntegerData3_get(swigCPtr);
      return retVal;
    }

  }

  public int nIntegerData4 {
    set {
      NWNXLibPINVOKE.CScriptParseTreeNode_nIntegerData4_set(swigCPtr, value);
    } 
    get {
      int retVal = NWNXLibPINVOKE.CScriptParseTreeNode_nIntegerData4_get(swigCPtr);
      return retVal;
    }

  }

  public float fFloatData {
    set {
      NWNXLibPINVOKE.CScriptParseTreeNode_fFloatData_set(swigCPtr, value);
    } 
    get {
      float retVal = NWNXLibPINVOKE.CScriptParseTreeNode_fFloatData_get(swigCPtr);
      return retVal;
    }

  }

  public NativeArray<float> fVectorData {
    set {
      NWNXLibPINVOKE.CScriptParseTreeNode_fVectorData_set(swigCPtr, value);
    } 
    get {
      global::System.IntPtr arrayPtr = NWNXLibPINVOKE.CScriptParseTreeNode_fVectorData_get(swigCPtr);
      NativeArray<float> retVal = new NativeArray<float>(arrayPtr, 3);

      return retVal; // float[3]
    }

  }

  public int m_nFileReference {
    set {
      NWNXLibPINVOKE.CScriptParseTreeNode_m_nFileReference_set(swigCPtr, value);
    } 
    get {
      int retVal = NWNXLibPINVOKE.CScriptParseTreeNode_m_nFileReference_get(swigCPtr);
      return retVal;
    }

  }

  public int nLine {
    set {
      NWNXLibPINVOKE.CScriptParseTreeNode_nLine_set(swigCPtr, value);
    } 
    get {
      int retVal = NWNXLibPINVOKE.CScriptParseTreeNode_nLine_get(swigCPtr);
      return retVal;
    }

  }

  public int nChar {
    set {
      NWNXLibPINVOKE.CScriptParseTreeNode_nChar_set(swigCPtr, value);
    } 
    get {
      int retVal = NWNXLibPINVOKE.CScriptParseTreeNode_nChar_get(swigCPtr);
      return retVal;
    }

  }

  public CScriptParseTreeNode pLeft {
    set {
      NWNXLibPINVOKE.CScriptParseTreeNode_pLeft_set(swigCPtr, CScriptParseTreeNode.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = NWNXLibPINVOKE.CScriptParseTreeNode_pLeft_get(swigCPtr);
      CScriptParseTreeNode ret = (cPtr == global::System.IntPtr.Zero) ? null : new CScriptParseTreeNode(cPtr, false);
      return ret;
    } 
  }

  public CScriptParseTreeNode pRight {
    set {
      NWNXLibPINVOKE.CScriptParseTreeNode_pRight_set(swigCPtr, CScriptParseTreeNode.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = NWNXLibPINVOKE.CScriptParseTreeNode_pRight_get(swigCPtr);
      CScriptParseTreeNode ret = (cPtr == global::System.IntPtr.Zero) ? null : new CScriptParseTreeNode(cPtr, false);
      return ret;
    } 
  }

  public int nType {
    set {
      NWNXLibPINVOKE.CScriptParseTreeNode_nType_set(swigCPtr, value);
    } 
    get {
      int retVal = NWNXLibPINVOKE.CScriptParseTreeNode_nType_get(swigCPtr);
      return retVal;
    }

  }

  public CExoString m_psTypeName {
    set {
      NWNXLibPINVOKE.CScriptParseTreeNode_m_psTypeName_set(swigCPtr, CExoString.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = NWNXLibPINVOKE.CScriptParseTreeNode_m_psTypeName_get(swigCPtr);
      CExoString ret = (cPtr == global::System.IntPtr.Zero) ? null : new CExoString(cPtr, false);
      return ret;
    } 
  }

  public int m_nStackPointer {
    set {
      NWNXLibPINVOKE.CScriptParseTreeNode_m_nStackPointer_set(swigCPtr, value);
    } 
    get {
      int retVal = NWNXLibPINVOKE.CScriptParseTreeNode_m_nStackPointer_get(swigCPtr);
      return retVal;
    }

  }

  public CScriptParseTreeNode() : this(NWNXLibPINVOKE.new_CScriptParseTreeNode(), true) {
  }

}

}

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

public unsafe class CScriptParseTreeNodeArray : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal CScriptParseTreeNodeArray(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(CScriptParseTreeNodeArray obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~CScriptParseTreeNodeArray() {
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
          NWNXLibPINVOKE.delete_CScriptParseTreeNodeArray(swigCPtr);
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

  public static unsafe implicit operator void*(CScriptParseTreeNodeArray self) {
    return (void*)self.swigCPtr.Handle;
  }

  public static unsafe CScriptParseTreeNodeArray FromPointer(void* pointer, bool memoryOwn = false) {
    return pointer != null ? new CScriptParseTreeNodeArray((global::System.IntPtr)pointer, memoryOwn) : null;
  }

  public static CScriptParseTreeNodeArray FromPointer(global::System.IntPtr pointer, bool memoryOwn = false) {
    return pointer != global::System.IntPtr.Zero ? new CScriptParseTreeNodeArray(pointer, memoryOwn) : null;
  }

  public bool Equals(CScriptParseTreeNodeArray other) {
    if (ReferenceEquals(null, other)) {
      return false;
    }

    if (ReferenceEquals(this, other)) {
      return true;
    }

    return Pointer.Equals(other.Pointer);
  }

  public override bool Equals(object obj) {
    return ReferenceEquals(this, obj) || obj is CScriptParseTreeNodeArray other && Equals(other);
  }

  public override int GetHashCode() {
    return swigCPtr.Handle.GetHashCode();
  }

  public static bool operator ==(CScriptParseTreeNodeArray left, CScriptParseTreeNodeArray right) {
    return Equals(left, right);
  }

  public static bool operator !=(CScriptParseTreeNodeArray left, CScriptParseTreeNodeArray right) {
    return !Equals(left, right);
  }
/*@SWIG@*/

  public CScriptParseTreeNode this[int index] {
    get {
      return GetItem(index);
    }
    set {
      SetItem(index, value);
    }
  }
  public CScriptParseTreeNodeArray(int nElements) : this(NWNXLibPINVOKE.new_CScriptParseTreeNodeArray(nElements), true) {
  }

  public CScriptParseTreeNode GetItem(int index) {
    CScriptParseTreeNode ret = new CScriptParseTreeNode(NWNXLibPINVOKE.CScriptParseTreeNodeArray_GetItem(swigCPtr, index), true);
    return ret;
  }

  public void SetItem(int index, CScriptParseTreeNode value) {
    NWNXLibPINVOKE.CScriptParseTreeNodeArray_SetItem(swigCPtr, index, CScriptParseTreeNode.getCPtr(value));
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
  }

  public static CScriptParseTreeNodeArray FromPointer(CScriptParseTreeNode ptr) {
    global::System.IntPtr cPtr = NWNXLibPINVOKE.CScriptParseTreeNodeArray_FromPointer(CScriptParseTreeNode.getCPtr(ptr));
    CScriptParseTreeNodeArray ret = (cPtr == global::System.IntPtr.Zero) ? null : new CScriptParseTreeNodeArray(cPtr, false);
    return ret;
  }

}

}

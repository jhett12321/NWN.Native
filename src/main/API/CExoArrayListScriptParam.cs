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

public unsafe class CExoArrayListScriptParam : global::System.IDisposable, global::System.Collections.IEnumerable, global::System.Collections.Generic.IEnumerable<ScriptParam>
 {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal CExoArrayListScriptParam(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(CExoArrayListScriptParam obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~CExoArrayListScriptParam() {
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
          NWNXLibPINVOKE.delete_CExoArrayListScriptParam(swigCPtr);
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

  public static unsafe implicit operator void*(CExoArrayListScriptParam self) {
    return (void*)self.swigCPtr.Handle;
  }

  public static unsafe CExoArrayListScriptParam FromPointer(void* pointer, bool memoryOwn = false) {
    return pointer != null ? new CExoArrayListScriptParam((global::System.IntPtr)pointer, memoryOwn) : null;
  }

  public static CExoArrayListScriptParam FromPointer(global::System.IntPtr pointer, bool memoryOwn = false) {
    return pointer != global::System.IntPtr.Zero ? new CExoArrayListScriptParam(pointer, memoryOwn) : null;
  }

  public bool Equals(CExoArrayListScriptParam other) {
    if (ReferenceEquals(null, other)) {
      return false;
    }

    if (ReferenceEquals(this, other)) {
      return true;
    }

    return Pointer.Equals(other.Pointer);
  }

  public override bool Equals(object obj) {
    return ReferenceEquals(this, obj) || obj is CExoArrayListScriptParam other && Equals(other);
  }

  public override int GetHashCode() {
    return swigCPtr.Handle.GetHashCode();
  }

  public static bool operator ==(CExoArrayListScriptParam left, CExoArrayListScriptParam right) {
    return Equals(left, right);
  }

  public static bool operator !=(CExoArrayListScriptParam left, CExoArrayListScriptParam right) {
    return !Equals(left, right);
  }

  public CExoArrayListScriptParam(global::System.Collections.IEnumerable c) : this() {
    if (c == null)
      throw new global::System.ArgumentNullException("c");
    foreach (ScriptParam element in c) {
      this.Add(element);
    }
  }

  public CExoArrayListScriptParam(global::System.Collections.Generic.IEnumerable<ScriptParam> c) : this() {
    if (c == null)
      throw new global::System.ArgumentNullException("c");
    foreach (ScriptParam element in c) {
      this.Add(element);
    }
  }

  public bool IsFixedSize {
    get {
      return false;
    }
  }

  public bool IsReadOnly {
    get {
      return false;
    }
  }

  public ScriptParam this[int index] {
    get {
      return InternalGetItem(index);
    }
    set {
      InternalSetItem(index, value);
    }
  }

  public int Capacity {
    get {
      return (int)array_size;
    }
    set {
      if (value < num)
        throw new global::System.ArgumentOutOfRangeException("Capacity");
      SetSize(value);
    }
  }

  public int Count {
    get {
      return (int)num;
    }
  }

  public bool IsSynchronized {
    get {
      return false;
    }
  }

  public void CopyTo(ScriptParam[] array)
  {
    CopyTo(0, array, 0, this.Count);
  }

  public void CopyTo(ScriptParam[] array, int arrayIndex)
  {
    CopyTo(0, array, arrayIndex, this.Count);
  }

  public void Clear()
  {
    SetSize(0);
  }

  public void CopyTo(int index, ScriptParam[] array, int arrayIndex, int count)
  {
    if (array == null)
      throw new global::System.ArgumentNullException("array");
    if (index < 0)
      throw new global::System.ArgumentOutOfRangeException("index", "Value is less than zero");
    if (arrayIndex < 0)
      throw new global::System.ArgumentOutOfRangeException("arrayIndex", "Value is less than zero");
    if (count < 0)
      throw new global::System.ArgumentOutOfRangeException("count", "Value is less than zero");
    if (array.Rank > 1)
      throw new global::System.ArgumentException("Multi dimensional array.", "array");
    if (index+count > this.Count || arrayIndex+count > array.Length)
      throw new global::System.ArgumentException("Number of elements to copy is too large.");
    for (int i=0; i<count; i++)
      array.SetValue(InternalGetItemCopy(index+i), arrayIndex+i);
  }

  public ScriptParam[] ToArray() {
    ScriptParam[] array = new ScriptParam[this.Count];
    this.CopyTo(array);
    return array;
  }

  global::System.Collections.Generic.IEnumerator<ScriptParam> global::System.Collections.Generic.IEnumerable<ScriptParam>.GetEnumerator() {
    return new CExoArrayListScriptParamEnumerator(this);
  }

  global::System.Collections.IEnumerator global::System.Collections.IEnumerable.GetEnumerator() {
    return new CExoArrayListScriptParamEnumerator(this);
  }

  public CExoArrayListScriptParamEnumerator GetEnumerator() {
    return new CExoArrayListScriptParamEnumerator(this);
  }

  // Type-safe enumerator
  /// Note that the IEnumerator documentation requires an InvalidOperationException to be thrown
  /// whenever the collection is modified. This has been done for changes in the size of the
  /// collection but not when one of the elements of the collection is modified as it is a bit
  /// tricky to detect unmanaged code that modifies the collection under our feet.
  public sealed class CExoArrayListScriptParamEnumerator : global::System.Collections.IEnumerator
    , global::System.Collections.Generic.IEnumerator<ScriptParam>
  {
    private CExoArrayListScriptParam collectionRef;
    private int currentIndex;
    private object currentObject;
    private int currentSize;

    public CExoArrayListScriptParamEnumerator(CExoArrayListScriptParam collection) {
      collectionRef = collection;
      currentIndex = -1;
      currentObject = null;
      currentSize = collectionRef.Count;
    }

    // Type-safe iterator Current
    public ScriptParam Current {
      get {
        if (currentIndex == -1)
          throw new global::System.InvalidOperationException("Enumeration not started.");
        if (currentIndex > currentSize - 1)
          throw new global::System.InvalidOperationException("Enumeration finished.");
        if (currentObject == null)
          throw new global::System.InvalidOperationException("Collection modified.");
        return (ScriptParam)currentObject;
      }
    }

    // Type-unsafe IEnumerator.Current
    object global::System.Collections.IEnumerator.Current {
      get {
        return Current;
      }
    }

    public bool MoveNext() {
      int size = collectionRef.Count;
      bool moveOkay = (currentIndex+1 < size) && (size == currentSize);
      if (moveOkay) {
        currentIndex++;
        currentObject = collectionRef[currentIndex];
      } else {
        currentObject = null;
      }
      return moveOkay;
    }

    public void Reset() {
      currentIndex = -1;
      currentObject = null;
      if (collectionRef.Count != currentSize) {
        throw new global::System.InvalidOperationException("Collection modified.");
      }
    }

    public void Dispose() {
        currentIndex = -1;
        currentObject = null;
    }
  }

  private int num {
    set {
      NWNXLibPINVOKE.CExoArrayListScriptParam_num_set(swigCPtr, value);
    } 
    get {
      int retVal = NWNXLibPINVOKE.CExoArrayListScriptParam_num_get(swigCPtr);
      return retVal;
    }

  }

  private int array_size {
    set {
      NWNXLibPINVOKE.CExoArrayListScriptParam_array_size_set(swigCPtr, value);
    } 
    get {
      int retVal = NWNXLibPINVOKE.CExoArrayListScriptParam_array_size_get(swigCPtr);
      return retVal;
    }

  }

  public void Add(ScriptParam t) {
    NWNXLibPINVOKE.CExoArrayListScriptParam_Add(swigCPtr, ScriptParam.getCPtr(t));
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
  }

  public void Pack() {
    NWNXLibPINVOKE.CExoArrayListScriptParam_Pack(swigCPtr);
  }

  private void Allocate(int s) {
    NWNXLibPINVOKE.CExoArrayListScriptParam_Allocate(swigCPtr, s);
  }

  public void SetSize(int s) {
    NWNXLibPINVOKE.CExoArrayListScriptParam_SetSize(swigCPtr, s);
  }

  public CExoArrayListScriptParam(int s) : this(NWNXLibPINVOKE.new_CExoArrayListScriptParam__SWIG_0(s), true) {
  }

  public CExoArrayListScriptParam() : this(NWNXLibPINVOKE.new_CExoArrayListScriptParam__SWIG_1(), true) {
  }

  public CExoArrayListScriptParam(CExoArrayListScriptParam list) : this(NWNXLibPINVOKE.new_CExoArrayListScriptParam__SWIG_2(CExoArrayListScriptParam.getCPtr(list)), true) {
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
  }

  public void RemoveAt(int index) {
    NWNXLibPINVOKE.CExoArrayListScriptParam_RemoveAt(swigCPtr, index);
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
  }

  private ScriptParam InternalGetItem(int index) {
    ScriptParam ret = new ScriptParam(NWNXLibPINVOKE.CExoArrayListScriptParam_InternalGetItem(swigCPtr, index), false);
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  private ScriptParam InternalGetItemCopy(int index) {
    ScriptParam ret = new ScriptParam(NWNXLibPINVOKE.CExoArrayListScriptParam_InternalGetItemCopy(swigCPtr, index), true);
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  private void InternalSetItem(int index, ScriptParam val) {
    NWNXLibPINVOKE.CExoArrayListScriptParam_InternalSetItem(swigCPtr, index, ScriptParam.getCPtr(val));
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
  }

  public void Insert(int index, ScriptParam x) {
    NWNXLibPINVOKE.CExoArrayListScriptParam_Insert(swigCPtr, index, ScriptParam.getCPtr(x));
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
  }

}

}

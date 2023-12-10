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

public unsafe class CExoArrayListCLastUpdatePartyObjectPtr : global::System.IDisposable, global::System.Collections.IEnumerable, global::System.Collections.Generic.IList<CLastUpdatePartyObject>
 {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal CExoArrayListCLastUpdatePartyObjectPtr(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(CExoArrayListCLastUpdatePartyObjectPtr obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~CExoArrayListCLastUpdatePartyObjectPtr() {
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
          NWNXLibPINVOKE.delete_CExoArrayListCLastUpdatePartyObjectPtr(swigCPtr);
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

  public static unsafe implicit operator void*(CExoArrayListCLastUpdatePartyObjectPtr self) {
    return (void*)self.swigCPtr.Handle;
  }

  public static unsafe CExoArrayListCLastUpdatePartyObjectPtr FromPointer(void* pointer, bool memoryOwn = false) {
    return pointer != null ? new CExoArrayListCLastUpdatePartyObjectPtr((global::System.IntPtr)pointer, memoryOwn) : null;
  }

  public static CExoArrayListCLastUpdatePartyObjectPtr FromPointer(global::System.IntPtr pointer, bool memoryOwn = false) {
    return pointer != global::System.IntPtr.Zero ? new CExoArrayListCLastUpdatePartyObjectPtr(pointer, memoryOwn) : null;
  }

  public bool Equals(CExoArrayListCLastUpdatePartyObjectPtr other) {
    if (ReferenceEquals(null, other)) {
      return false;
    }

    if (ReferenceEquals(this, other)) {
      return true;
    }

    return Pointer.Equals(other.Pointer);
  }

  public override bool Equals(object obj) {
    return ReferenceEquals(this, obj) || obj is CExoArrayListCLastUpdatePartyObjectPtr other && Equals(other);
  }

  public override int GetHashCode() {
    return swigCPtr.Handle.GetHashCode();
  }

  public static bool operator ==(CExoArrayListCLastUpdatePartyObjectPtr left, CExoArrayListCLastUpdatePartyObjectPtr right) {
    return Equals(left, right);
  }

  public static bool operator !=(CExoArrayListCLastUpdatePartyObjectPtr left, CExoArrayListCLastUpdatePartyObjectPtr right) {
    return !Equals(left, right);
  }

  public CExoArrayListCLastUpdatePartyObjectPtr(global::System.Collections.IEnumerable c) : this() {
    if (c == null)
      throw new global::System.ArgumentNullException("c");
    foreach (CLastUpdatePartyObject element in c) {
      this.Add(element);
    }
  }

  public CExoArrayListCLastUpdatePartyObjectPtr(global::System.Collections.Generic.IEnumerable<CLastUpdatePartyObject> c) : this() {
    if (c == null)
      throw new global::System.ArgumentNullException("c");
    foreach (CLastUpdatePartyObject element in c) {
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

  public CLastUpdatePartyObject this[int index] {
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

  public void CopyTo(CLastUpdatePartyObject[] array)
  {
    CopyTo(0, array, 0, this.Count);
  }

  public void CopyTo(CLastUpdatePartyObject[] array, int arrayIndex)
  {
    CopyTo(0, array, arrayIndex, this.Count);
  }

  public void Clear()
  {
    SetSize(0);
  }

  public void CopyTo(int index, CLastUpdatePartyObject[] array, int arrayIndex, int count)
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

  public CLastUpdatePartyObject[] ToArray() {
    CLastUpdatePartyObject[] array = new CLastUpdatePartyObject[this.Count];
    this.CopyTo(array);
    return array;
  }

  global::System.Collections.Generic.IEnumerator<CLastUpdatePartyObject> global::System.Collections.Generic.IEnumerable<CLastUpdatePartyObject>.GetEnumerator() {
    return new CExoArrayListCLastUpdatePartyObjectPtrEnumerator(this);
  }

  global::System.Collections.IEnumerator global::System.Collections.IEnumerable.GetEnumerator() {
    return new CExoArrayListCLastUpdatePartyObjectPtrEnumerator(this);
  }

  public CExoArrayListCLastUpdatePartyObjectPtrEnumerator GetEnumerator() {
    return new CExoArrayListCLastUpdatePartyObjectPtrEnumerator(this);
  }

  // Type-safe enumerator
  /// Note that the IEnumerator documentation requires an InvalidOperationException to be thrown
  /// whenever the collection is modified. This has been done for changes in the size of the
  /// collection but not when one of the elements of the collection is modified as it is a bit
  /// tricky to detect unmanaged code that modifies the collection under our feet.
  public sealed class CExoArrayListCLastUpdatePartyObjectPtrEnumerator : global::System.Collections.IEnumerator
    , global::System.Collections.Generic.IEnumerator<CLastUpdatePartyObject>
  {
    private CExoArrayListCLastUpdatePartyObjectPtr collectionRef;
    private int currentIndex;
    private object currentObject;
    private int currentSize;

    public CExoArrayListCLastUpdatePartyObjectPtrEnumerator(CExoArrayListCLastUpdatePartyObjectPtr collection) {
      collectionRef = collection;
      currentIndex = -1;
      currentObject = null;
      currentSize = collectionRef.Count;
    }

    // Type-safe iterator Current
    public CLastUpdatePartyObject Current {
      get {
        if (currentIndex == -1)
          throw new global::System.InvalidOperationException("Enumeration not started.");
        if (currentIndex > currentSize - 1)
          throw new global::System.InvalidOperationException("Enumeration finished.");
        if (currentObject == null)
          throw new global::System.InvalidOperationException("Collection modified.");
        return (CLastUpdatePartyObject)currentObject;
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
      NWNXLibPINVOKE.CExoArrayListCLastUpdatePartyObjectPtr_num_set(swigCPtr, value);
    } 
    get {
      int retVal = NWNXLibPINVOKE.CExoArrayListCLastUpdatePartyObjectPtr_num_get(swigCPtr);
      return retVal;
    }

  }

  private int array_size {
    set {
      NWNXLibPINVOKE.CExoArrayListCLastUpdatePartyObjectPtr_array_size_set(swigCPtr, value);
    } 
    get {
      int retVal = NWNXLibPINVOKE.CExoArrayListCLastUpdatePartyObjectPtr_array_size_get(swigCPtr);
      return retVal;
    }

  }

  public void Add(CLastUpdatePartyObject t) {
    NWNXLibPINVOKE.CExoArrayListCLastUpdatePartyObjectPtr_Add(swigCPtr, CLastUpdatePartyObject.getCPtr(t));
  }

  public void Pack() {
    NWNXLibPINVOKE.CExoArrayListCLastUpdatePartyObjectPtr_Pack(swigCPtr);
  }

  private void Allocate(int s) {
    NWNXLibPINVOKE.CExoArrayListCLastUpdatePartyObjectPtr_Allocate(swigCPtr, s);
  }

  public void SetSize(int s) {
    NWNXLibPINVOKE.CExoArrayListCLastUpdatePartyObjectPtr_SetSize(swigCPtr, s);
  }

  public CExoArrayListCLastUpdatePartyObjectPtr(int s) : this(NWNXLibPINVOKE.new_CExoArrayListCLastUpdatePartyObjectPtr__SWIG_0(s), true) {
  }

  public CExoArrayListCLastUpdatePartyObjectPtr() : this(NWNXLibPINVOKE.new_CExoArrayListCLastUpdatePartyObjectPtr__SWIG_1(), true) {
  }

  public CExoArrayListCLastUpdatePartyObjectPtr(CExoArrayListCLastUpdatePartyObjectPtr list) : this(NWNXLibPINVOKE.new_CExoArrayListCLastUpdatePartyObjectPtr__SWIG_2(CExoArrayListCLastUpdatePartyObjectPtr.getCPtr(list)), true) {
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
  }

  public void RemoveAt(int index) {
    NWNXLibPINVOKE.CExoArrayListCLastUpdatePartyObjectPtr_RemoveAt(swigCPtr, index);
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
  }

  public int IndexOf(CLastUpdatePartyObject t) {
    int retVal = NWNXLibPINVOKE.CExoArrayListCLastUpdatePartyObjectPtr_IndexOf(swigCPtr, CLastUpdatePartyObject.getCPtr(t));
    return retVal;
  }

  public int AddUnique(CLastUpdatePartyObject t) {
    int retVal = NWNXLibPINVOKE.CExoArrayListCLastUpdatePartyObjectPtr_AddUnique(swigCPtr, CLastUpdatePartyObject.getCPtr(t));
    return retVal;
  }

  private CLastUpdatePartyObject InternalGetItem(int index) {
    global::System.IntPtr cPtr = NWNXLibPINVOKE.CExoArrayListCLastUpdatePartyObjectPtr_InternalGetItem(swigCPtr, index);
    CLastUpdatePartyObject ret = (cPtr == global::System.IntPtr.Zero) ? null : new CLastUpdatePartyObject(cPtr, false);
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  private CLastUpdatePartyObject InternalGetItemCopy(int index) {
    global::System.IntPtr cPtr = NWNXLibPINVOKE.CExoArrayListCLastUpdatePartyObjectPtr_InternalGetItemCopy(swigCPtr, index);
    CLastUpdatePartyObject ret = (cPtr == global::System.IntPtr.Zero) ? null : new CLastUpdatePartyObject(cPtr, false);
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  private void InternalSetItem(int index, CLastUpdatePartyObject val) {
    NWNXLibPINVOKE.CExoArrayListCLastUpdatePartyObjectPtr_InternalSetItem(swigCPtr, index, CLastUpdatePartyObject.getCPtr(val));
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
  }

  public void Insert(int index, CLastUpdatePartyObject x) {
    NWNXLibPINVOKE.CExoArrayListCLastUpdatePartyObjectPtr_Insert(swigCPtr, index, CLastUpdatePartyObject.getCPtr(x));
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
  }

  public bool Contains(CLastUpdatePartyObject value) {
    bool ret = NWNXLibPINVOKE.CExoArrayListCLastUpdatePartyObjectPtr_Contains(swigCPtr, CLastUpdatePartyObject.getCPtr(value));
    return ret;
  }

  public int LastIndexOf(CLastUpdatePartyObject value) {
    int retVal = NWNXLibPINVOKE.CExoArrayListCLastUpdatePartyObjectPtr_LastIndexOf(swigCPtr, CLastUpdatePartyObject.getCPtr(value));
    return retVal;
  }

  public bool Remove(CLastUpdatePartyObject value) {
    bool ret = NWNXLibPINVOKE.CExoArrayListCLastUpdatePartyObjectPtr_Remove(swigCPtr, CLastUpdatePartyObject.getCPtr(value));
    return ret;
  }

}

}

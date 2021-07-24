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

public unsafe class CExoArrayListCStoreCustomerPtr : global::System.IDisposable, global::System.Collections.IEnumerable, global::System.Collections.Generic.IList<CStoreCustomer>
 {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal CExoArrayListCStoreCustomerPtr(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(CExoArrayListCStoreCustomerPtr obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~CExoArrayListCStoreCustomerPtr() {
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
          NWNXLibPINVOKE.delete_CExoArrayListCStoreCustomerPtr(swigCPtr);
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

  public static unsafe implicit operator void*(CExoArrayListCStoreCustomerPtr self) {
    return (void*)self.swigCPtr.Handle;
  }

  public static unsafe CExoArrayListCStoreCustomerPtr FromPointer(void* pointer, bool memoryOwn = false) {
    return pointer != null ? new CExoArrayListCStoreCustomerPtr((global::System.IntPtr)pointer, memoryOwn) : null;
  }

  public static CExoArrayListCStoreCustomerPtr FromPointer(global::System.IntPtr pointer, bool memoryOwn = false) {
    return pointer != global::System.IntPtr.Zero ? new CExoArrayListCStoreCustomerPtr(pointer, memoryOwn) : null;
  }

  public bool Equals(CExoArrayListCStoreCustomerPtr other) {
    if (ReferenceEquals(null, other)) {
      return false;
    }

    if (ReferenceEquals(this, other)) {
      return true;
    }

    return Pointer.Equals(other.Pointer);
  }

  public override bool Equals(object obj) {
    return ReferenceEquals(this, obj) || obj is CExoArrayListCStoreCustomerPtr other && Equals(other);
  }

  public override int GetHashCode() {
    return swigCPtr.Handle.GetHashCode();
  }

  public static bool operator ==(CExoArrayListCStoreCustomerPtr left, CExoArrayListCStoreCustomerPtr right) {
    return Equals(left, right);
  }

  public static bool operator !=(CExoArrayListCStoreCustomerPtr left, CExoArrayListCStoreCustomerPtr right) {
    return !Equals(left, right);
  }
/*@SWIG@*/
  public CExoArrayListCStoreCustomerPtr(global::System.Collections.IEnumerable c) : this() {
    if (c == null)
      throw new global::System.ArgumentNullException("c");
    foreach (CStoreCustomer element in c) {
      this.Add(element);
    }
  }

  public CExoArrayListCStoreCustomerPtr(global::System.Collections.Generic.IEnumerable<CStoreCustomer> c) : this() {
    if (c == null)
      throw new global::System.ArgumentNullException("c");
    foreach (CStoreCustomer element in c) {
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

  public CStoreCustomer this[int index] {
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

  public void CopyTo(CStoreCustomer[] array)
  {
    CopyTo(0, array, 0, this.Count);
  }

  public void CopyTo(CStoreCustomer[] array, int arrayIndex)
  {
    CopyTo(0, array, arrayIndex, this.Count);
  }

  public void Clear()
  {
    SetSize(0);
  }

  public void CopyTo(int index, CStoreCustomer[] array, int arrayIndex, int count)
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

  public CStoreCustomer[] ToArray() {
    CStoreCustomer[] array = new CStoreCustomer[this.Count];
    this.CopyTo(array);
    return array;
  }

  global::System.Collections.Generic.IEnumerator<CStoreCustomer> global::System.Collections.Generic.IEnumerable<CStoreCustomer>.GetEnumerator() {
    return new CExoArrayListCStoreCustomerPtrEnumerator(this);
  }

  global::System.Collections.IEnumerator global::System.Collections.IEnumerable.GetEnumerator() {
    return new CExoArrayListCStoreCustomerPtrEnumerator(this);
  }

  public CExoArrayListCStoreCustomerPtrEnumerator GetEnumerator() {
    return new CExoArrayListCStoreCustomerPtrEnumerator(this);
  }

  // Type-safe enumerator
  /// Note that the IEnumerator documentation requires an InvalidOperationException to be thrown
  /// whenever the collection is modified. This has been done for changes in the size of the
  /// collection but not when one of the elements of the collection is modified as it is a bit
  /// tricky to detect unmanaged code that modifies the collection under our feet.
  public sealed class CExoArrayListCStoreCustomerPtrEnumerator : global::System.Collections.IEnumerator
    , global::System.Collections.Generic.IEnumerator<CStoreCustomer>
  {
    private CExoArrayListCStoreCustomerPtr collectionRef;
    private int currentIndex;
    private object currentObject;
    private int currentSize;

    public CExoArrayListCStoreCustomerPtrEnumerator(CExoArrayListCStoreCustomerPtr collection) {
      collectionRef = collection;
      currentIndex = -1;
      currentObject = null;
      currentSize = collectionRef.Count;
    }

    // Type-safe iterator Current
    public CStoreCustomer Current {
      get {
        if (currentIndex == -1)
          throw new global::System.InvalidOperationException("Enumeration not started.");
        if (currentIndex > currentSize - 1)
          throw new global::System.InvalidOperationException("Enumeration finished.");
        if (currentObject == null)
          throw new global::System.InvalidOperationException("Collection modified.");
        return (CStoreCustomer)currentObject;
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
      NWNXLibPINVOKE.CExoArrayListCStoreCustomerPtr_num_set(swigCPtr, value);
    } 
    get {
      int retVal = NWNXLibPINVOKE.CExoArrayListCStoreCustomerPtr_num_get(swigCPtr);
      return retVal;
    }

  }

  private int array_size {
    set {
      NWNXLibPINVOKE.CExoArrayListCStoreCustomerPtr_array_size_set(swigCPtr, value);
    } 
    get {
      int retVal = NWNXLibPINVOKE.CExoArrayListCStoreCustomerPtr_array_size_get(swigCPtr);
      return retVal;
    }

  }

  public void Add(CStoreCustomer t) {
    NWNXLibPINVOKE.CExoArrayListCStoreCustomerPtr_Add(swigCPtr, CStoreCustomer.getCPtr(t));
  }

  public void Pack() {
    NWNXLibPINVOKE.CExoArrayListCStoreCustomerPtr_Pack(swigCPtr);
  }

  private void Allocate(int s) {
    NWNXLibPINVOKE.CExoArrayListCStoreCustomerPtr_Allocate(swigCPtr, s);
  }

  public void SetSize(int s) {
    NWNXLibPINVOKE.CExoArrayListCStoreCustomerPtr_SetSize(swigCPtr, s);
  }

  public CExoArrayListCStoreCustomerPtr(int s) : this(NWNXLibPINVOKE.new_CExoArrayListCStoreCustomerPtr__SWIG_0(s), true) {
  }

  public CExoArrayListCStoreCustomerPtr() : this(NWNXLibPINVOKE.new_CExoArrayListCStoreCustomerPtr__SWIG_1(), true) {
  }

  public CExoArrayListCStoreCustomerPtr(CExoArrayListCStoreCustomerPtr list) : this(NWNXLibPINVOKE.new_CExoArrayListCStoreCustomerPtr__SWIG_2(CExoArrayListCStoreCustomerPtr.getCPtr(list)), true) {
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
  }

  public void RemoveAt(int index) {
    NWNXLibPINVOKE.CExoArrayListCStoreCustomerPtr_RemoveAt(swigCPtr, index);
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
  }

  public int IndexOf(CStoreCustomer t) {
    int retVal = NWNXLibPINVOKE.CExoArrayListCStoreCustomerPtr_IndexOf(swigCPtr, CStoreCustomer.getCPtr(t));
    return retVal;
  }

  public int AddUnique(CStoreCustomer t) {
    int retVal = NWNXLibPINVOKE.CExoArrayListCStoreCustomerPtr_AddUnique(swigCPtr, CStoreCustomer.getCPtr(t));
    return retVal;
  }

  private CStoreCustomer InternalGetItem(int index) {
    global::System.IntPtr cPtr = NWNXLibPINVOKE.CExoArrayListCStoreCustomerPtr_InternalGetItem(swigCPtr, index);
    CStoreCustomer ret = (cPtr == global::System.IntPtr.Zero) ? null : new CStoreCustomer(cPtr, false);
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  private CStoreCustomer InternalGetItemCopy(int index) {
    global::System.IntPtr cPtr = NWNXLibPINVOKE.CExoArrayListCStoreCustomerPtr_InternalGetItemCopy(swigCPtr, index);
    CStoreCustomer ret = (cPtr == global::System.IntPtr.Zero) ? null : new CStoreCustomer(cPtr, false);
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  private void InternalSetItem(int index, CStoreCustomer val) {
    NWNXLibPINVOKE.CExoArrayListCStoreCustomerPtr_InternalSetItem(swigCPtr, index, CStoreCustomer.getCPtr(val));
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
  }

  public void Insert(int index, CStoreCustomer x) {
    NWNXLibPINVOKE.CExoArrayListCStoreCustomerPtr_Insert(swigCPtr, index, CStoreCustomer.getCPtr(x));
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
  }

  public bool Contains(CStoreCustomer value) {
    bool ret = NWNXLibPINVOKE.CExoArrayListCStoreCustomerPtr_Contains(swigCPtr, CStoreCustomer.getCPtr(value));
    return ret;
  }

  public int LastIndexOf(CStoreCustomer value) {
    int retVal = NWNXLibPINVOKE.CExoArrayListCStoreCustomerPtr_LastIndexOf(swigCPtr, CStoreCustomer.getCPtr(value));
    return retVal;
  }

  public bool Remove(CStoreCustomer value) {
    bool ret = NWNXLibPINVOKE.CExoArrayListCStoreCustomerPtr_Remove(swigCPtr, CStoreCustomer.getCPtr(value));
    return ret;
  }

}

}

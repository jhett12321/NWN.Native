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

public unsafe class CExoArrayListCExoString : global::System.IDisposable, global::System.Collections.IEnumerable, global::System.Collections.Generic.IList<CExoString>
 {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal CExoArrayListCExoString(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(CExoArrayListCExoString obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~CExoArrayListCExoString() {
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
          NWNXLibPINVOKE.delete_CExoArrayListCExoString(swigCPtr);
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

  public static unsafe implicit operator void*(CExoArrayListCExoString self) {
    return (void*)self.swigCPtr.Handle;
  }

  public static unsafe CExoArrayListCExoString FromPointer(void* pointer, bool memoryOwn = false) {
    return pointer != null ? new CExoArrayListCExoString((global::System.IntPtr)pointer, memoryOwn) : null;
  }

  public static CExoArrayListCExoString FromPointer(global::System.IntPtr pointer, bool memoryOwn = false) {
    return pointer != global::System.IntPtr.Zero ? new CExoArrayListCExoString(pointer, memoryOwn) : null;
  }

  public bool Equals(CExoArrayListCExoString other) {
    if (ReferenceEquals(null, other)) {
      return false;
    }

    if (ReferenceEquals(this, other)) {
      return true;
    }

    return Pointer.Equals(other.Pointer);
  }

  public override bool Equals(object obj) {
    return ReferenceEquals(this, obj) || obj is CExoArrayListCExoString other && Equals(other);
  }

  public override int GetHashCode() {
    return swigCPtr.Handle.GetHashCode();
  }

  public static bool operator ==(CExoArrayListCExoString left, CExoArrayListCExoString right) {
    return Equals(left, right);
  }

  public static bool operator !=(CExoArrayListCExoString left, CExoArrayListCExoString right) {
    return !Equals(left, right);
  }
/*@SWIG@*/
  public CExoArrayListCExoString(global::System.Collections.IEnumerable c) : this() {
    if (c == null)
      throw new global::System.ArgumentNullException("c");
    foreach (CExoString element in c) {
      this.Add(element);
    }
  }

  public CExoArrayListCExoString(global::System.Collections.Generic.IEnumerable<CExoString> c) : this() {
    if (c == null)
      throw new global::System.ArgumentNullException("c");
    foreach (CExoString element in c) {
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

  public CExoString this[int index] {
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

  public void CopyTo(CExoString[] array)
  {
    CopyTo(0, array, 0, this.Count);
  }

  public void CopyTo(CExoString[] array, int arrayIndex)
  {
    CopyTo(0, array, arrayIndex, this.Count);
  }

  public void Clear()
  {
    SetSize(0);
  }

  public void CopyTo(int index, CExoString[] array, int arrayIndex, int count)
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

  public CExoString[] ToArray() {
    CExoString[] array = new CExoString[this.Count];
    this.CopyTo(array);
    return array;
  }

  global::System.Collections.Generic.IEnumerator<CExoString> global::System.Collections.Generic.IEnumerable<CExoString>.GetEnumerator() {
    return new CExoArrayListCExoStringEnumerator(this);
  }

  global::System.Collections.IEnumerator global::System.Collections.IEnumerable.GetEnumerator() {
    return new CExoArrayListCExoStringEnumerator(this);
  }

  public CExoArrayListCExoStringEnumerator GetEnumerator() {
    return new CExoArrayListCExoStringEnumerator(this);
  }

  // Type-safe enumerator
  /// Note that the IEnumerator documentation requires an InvalidOperationException to be thrown
  /// whenever the collection is modified. This has been done for changes in the size of the
  /// collection but not when one of the elements of the collection is modified as it is a bit
  /// tricky to detect unmanaged code that modifies the collection under our feet.
  public sealed class CExoArrayListCExoStringEnumerator : global::System.Collections.IEnumerator
    , global::System.Collections.Generic.IEnumerator<CExoString>
  {
    private CExoArrayListCExoString collectionRef;
    private int currentIndex;
    private object currentObject;
    private int currentSize;

    public CExoArrayListCExoStringEnumerator(CExoArrayListCExoString collection) {
      collectionRef = collection;
      currentIndex = -1;
      currentObject = null;
      currentSize = collectionRef.Count;
    }

    // Type-safe iterator Current
    public CExoString Current {
      get {
        if (currentIndex == -1)
          throw new global::System.InvalidOperationException("Enumeration not started.");
        if (currentIndex > currentSize - 1)
          throw new global::System.InvalidOperationException("Enumeration finished.");
        if (currentObject == null)
          throw new global::System.InvalidOperationException("Collection modified.");
        return (CExoString)currentObject;
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
      NWNXLibPINVOKE.CExoArrayListCExoString_num_set(swigCPtr, value);
    } 
    get {
      int retVal = NWNXLibPINVOKE.CExoArrayListCExoString_num_get(swigCPtr);
      return retVal;
    }

  }

  private int array_size {
    set {
      NWNXLibPINVOKE.CExoArrayListCExoString_array_size_set(swigCPtr, value);
    } 
    get {
      int retVal = NWNXLibPINVOKE.CExoArrayListCExoString_array_size_get(swigCPtr);
      return retVal;
    }

  }

  public void Add(CExoString t) {
    NWNXLibPINVOKE.CExoArrayListCExoString_Add(swigCPtr, CExoString.getCPtr(t));
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
  }

  public void Pack() {
    NWNXLibPINVOKE.CExoArrayListCExoString_Pack(swigCPtr);
  }

  private void Allocate(int s) {
    NWNXLibPINVOKE.CExoArrayListCExoString_Allocate(swigCPtr, s);
  }

  public void SetSize(int s) {
    NWNXLibPINVOKE.CExoArrayListCExoString_SetSize(swigCPtr, s);
  }

  public CExoArrayListCExoString(int s) : this(NWNXLibPINVOKE.new_CExoArrayListCExoString__SWIG_0(s), true) {
  }

  public CExoArrayListCExoString() : this(NWNXLibPINVOKE.new_CExoArrayListCExoString__SWIG_1(), true) {
  }

  public CExoArrayListCExoString(CExoArrayListCExoString list) : this(NWNXLibPINVOKE.new_CExoArrayListCExoString__SWIG_2(CExoArrayListCExoString.getCPtr(list)), true) {
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
  }

  public void RemoveAt(int index) {
    NWNXLibPINVOKE.CExoArrayListCExoString_RemoveAt(swigCPtr, index);
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
  }

  private CExoString InternalGetItem(int index) {
    CExoString ret = new CExoString(NWNXLibPINVOKE.CExoArrayListCExoString_InternalGetItem(swigCPtr, index), false);
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  private CExoString InternalGetItemCopy(int index) {
    CExoString ret = new CExoString(NWNXLibPINVOKE.CExoArrayListCExoString_InternalGetItemCopy(swigCPtr, index), true);
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  private void InternalSetItem(int index, CExoString val) {
    NWNXLibPINVOKE.CExoArrayListCExoString_InternalSetItem(swigCPtr, index, CExoString.getCPtr(val));
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
  }

  public void Insert(int index, CExoString x) {
    NWNXLibPINVOKE.CExoArrayListCExoString_Insert(swigCPtr, index, CExoString.getCPtr(x));
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
  }

  public int IndexOf(CExoString t) {
    int retVal = NWNXLibPINVOKE.CExoArrayListCExoString_IndexOf(swigCPtr, CExoString.getCPtr(t));
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
    return retVal;
  }

  public int AddUnique(CExoString t) {
    int retVal = NWNXLibPINVOKE.CExoArrayListCExoString_AddUnique(swigCPtr, CExoString.getCPtr(t));
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
    return retVal;
  }

  public bool Contains(CExoString value) {
    bool ret = NWNXLibPINVOKE.CExoArrayListCExoString_Contains(swigCPtr, CExoString.getCPtr(value));
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public int LastIndexOf(CExoString value) {
    int retVal = NWNXLibPINVOKE.CExoArrayListCExoString_LastIndexOf(swigCPtr, CExoString.getCPtr(value));
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
    return retVal;
  }

  public bool Remove(CExoString value) {
    bool ret = NWNXLibPINVOKE.CExoArrayListCExoString_Remove(swigCPtr, CExoString.getCPtr(value));
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

}

}

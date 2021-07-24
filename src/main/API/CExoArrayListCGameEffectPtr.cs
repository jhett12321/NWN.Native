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

public unsafe class CExoArrayListCGameEffectPtr : global::System.IDisposable, global::System.Collections.IEnumerable, global::System.Collections.Generic.IList<CGameEffect>
 {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal CExoArrayListCGameEffectPtr(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(CExoArrayListCGameEffectPtr obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~CExoArrayListCGameEffectPtr() {
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
          NWNXLibPINVOKE.delete_CExoArrayListCGameEffectPtr(swigCPtr);
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

  public static unsafe implicit operator void*(CExoArrayListCGameEffectPtr self) {
    return (void*)self.swigCPtr.Handle;
  }

  public static unsafe CExoArrayListCGameEffectPtr FromPointer(void* pointer, bool memoryOwn = false) {
    return pointer != null ? new CExoArrayListCGameEffectPtr((global::System.IntPtr)pointer, memoryOwn) : null;
  }

  public static CExoArrayListCGameEffectPtr FromPointer(global::System.IntPtr pointer, bool memoryOwn = false) {
    return pointer != global::System.IntPtr.Zero ? new CExoArrayListCGameEffectPtr(pointer, memoryOwn) : null;
  }

  public bool Equals(CExoArrayListCGameEffectPtr other) {
    if (ReferenceEquals(null, other)) {
      return false;
    }

    if (ReferenceEquals(this, other)) {
      return true;
    }

    return Pointer.Equals(other.Pointer);
  }

  public override bool Equals(object obj) {
    return ReferenceEquals(this, obj) || obj is CExoArrayListCGameEffectPtr other && Equals(other);
  }

  public override int GetHashCode() {
    return swigCPtr.Handle.GetHashCode();
  }

  public static bool operator ==(CExoArrayListCGameEffectPtr left, CExoArrayListCGameEffectPtr right) {
    return Equals(left, right);
  }

  public static bool operator !=(CExoArrayListCGameEffectPtr left, CExoArrayListCGameEffectPtr right) {
    return !Equals(left, right);
  }
/*@SWIG@*/
  public CExoArrayListCGameEffectPtr(global::System.Collections.IEnumerable c) : this() {
    if (c == null)
      throw new global::System.ArgumentNullException("c");
    foreach (CGameEffect element in c) {
      this.Add(element);
    }
  }

  public CExoArrayListCGameEffectPtr(global::System.Collections.Generic.IEnumerable<CGameEffect> c) : this() {
    if (c == null)
      throw new global::System.ArgumentNullException("c");
    foreach (CGameEffect element in c) {
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

  public CGameEffect this[int index] {
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

  public void CopyTo(CGameEffect[] array)
  {
    CopyTo(0, array, 0, this.Count);
  }

  public void CopyTo(CGameEffect[] array, int arrayIndex)
  {
    CopyTo(0, array, arrayIndex, this.Count);
  }

  public void Clear()
  {
    SetSize(0);
  }

  public void CopyTo(int index, CGameEffect[] array, int arrayIndex, int count)
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

  public CGameEffect[] ToArray() {
    CGameEffect[] array = new CGameEffect[this.Count];
    this.CopyTo(array);
    return array;
  }

  global::System.Collections.Generic.IEnumerator<CGameEffect> global::System.Collections.Generic.IEnumerable<CGameEffect>.GetEnumerator() {
    return new CExoArrayListCGameEffectPtrEnumerator(this);
  }

  global::System.Collections.IEnumerator global::System.Collections.IEnumerable.GetEnumerator() {
    return new CExoArrayListCGameEffectPtrEnumerator(this);
  }

  public CExoArrayListCGameEffectPtrEnumerator GetEnumerator() {
    return new CExoArrayListCGameEffectPtrEnumerator(this);
  }

  // Type-safe enumerator
  /// Note that the IEnumerator documentation requires an InvalidOperationException to be thrown
  /// whenever the collection is modified. This has been done for changes in the size of the
  /// collection but not when one of the elements of the collection is modified as it is a bit
  /// tricky to detect unmanaged code that modifies the collection under our feet.
  public sealed class CExoArrayListCGameEffectPtrEnumerator : global::System.Collections.IEnumerator
    , global::System.Collections.Generic.IEnumerator<CGameEffect>
  {
    private CExoArrayListCGameEffectPtr collectionRef;
    private int currentIndex;
    private object currentObject;
    private int currentSize;

    public CExoArrayListCGameEffectPtrEnumerator(CExoArrayListCGameEffectPtr collection) {
      collectionRef = collection;
      currentIndex = -1;
      currentObject = null;
      currentSize = collectionRef.Count;
    }

    // Type-safe iterator Current
    public CGameEffect Current {
      get {
        if (currentIndex == -1)
          throw new global::System.InvalidOperationException("Enumeration not started.");
        if (currentIndex > currentSize - 1)
          throw new global::System.InvalidOperationException("Enumeration finished.");
        if (currentObject == null)
          throw new global::System.InvalidOperationException("Collection modified.");
        return (CGameEffect)currentObject;
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
      NWNXLibPINVOKE.CExoArrayListCGameEffectPtr_num_set(swigCPtr, value);
    } 
    get {
      int retVal = NWNXLibPINVOKE.CExoArrayListCGameEffectPtr_num_get(swigCPtr);
      return retVal;
    }

  }

  private int array_size {
    set {
      NWNXLibPINVOKE.CExoArrayListCGameEffectPtr_array_size_set(swigCPtr, value);
    } 
    get {
      int retVal = NWNXLibPINVOKE.CExoArrayListCGameEffectPtr_array_size_get(swigCPtr);
      return retVal;
    }

  }

  public void Add(CGameEffect t) {
    NWNXLibPINVOKE.CExoArrayListCGameEffectPtr_Add(swigCPtr, CGameEffect.getCPtr(t));
  }

  public void Pack() {
    NWNXLibPINVOKE.CExoArrayListCGameEffectPtr_Pack(swigCPtr);
  }

  private void Allocate(int s) {
    NWNXLibPINVOKE.CExoArrayListCGameEffectPtr_Allocate(swigCPtr, s);
  }

  public void SetSize(int s) {
    NWNXLibPINVOKE.CExoArrayListCGameEffectPtr_SetSize(swigCPtr, s);
  }

  public CExoArrayListCGameEffectPtr(int s) : this(NWNXLibPINVOKE.new_CExoArrayListCGameEffectPtr__SWIG_0(s), true) {
  }

  public CExoArrayListCGameEffectPtr() : this(NWNXLibPINVOKE.new_CExoArrayListCGameEffectPtr__SWIG_1(), true) {
  }

  public CExoArrayListCGameEffectPtr(CExoArrayListCGameEffectPtr list) : this(NWNXLibPINVOKE.new_CExoArrayListCGameEffectPtr__SWIG_2(CExoArrayListCGameEffectPtr.getCPtr(list)), true) {
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
  }

  public void RemoveAt(int index) {
    NWNXLibPINVOKE.CExoArrayListCGameEffectPtr_RemoveAt(swigCPtr, index);
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
  }

  public int IndexOf(CGameEffect t) {
    int retVal = NWNXLibPINVOKE.CExoArrayListCGameEffectPtr_IndexOf(swigCPtr, CGameEffect.getCPtr(t));
    return retVal;
  }

  public int AddUnique(CGameEffect t) {
    int retVal = NWNXLibPINVOKE.CExoArrayListCGameEffectPtr_AddUnique(swigCPtr, CGameEffect.getCPtr(t));
    return retVal;
  }

  private CGameEffect InternalGetItem(int index) {
    global::System.IntPtr cPtr = NWNXLibPINVOKE.CExoArrayListCGameEffectPtr_InternalGetItem(swigCPtr, index);
    CGameEffect ret = (cPtr == global::System.IntPtr.Zero) ? null : new CGameEffect(cPtr, false);
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  private CGameEffect InternalGetItemCopy(int index) {
    global::System.IntPtr cPtr = NWNXLibPINVOKE.CExoArrayListCGameEffectPtr_InternalGetItemCopy(swigCPtr, index);
    CGameEffect ret = (cPtr == global::System.IntPtr.Zero) ? null : new CGameEffect(cPtr, false);
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  private void InternalSetItem(int index, CGameEffect val) {
    NWNXLibPINVOKE.CExoArrayListCGameEffectPtr_InternalSetItem(swigCPtr, index, CGameEffect.getCPtr(val));
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
  }

  public void Insert(int index, CGameEffect x) {
    NWNXLibPINVOKE.CExoArrayListCGameEffectPtr_Insert(swigCPtr, index, CGameEffect.getCPtr(x));
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
  }

  public bool Contains(CGameEffect value) {
    bool ret = NWNXLibPINVOKE.CExoArrayListCGameEffectPtr_Contains(swigCPtr, CGameEffect.getCPtr(value));
    return ret;
  }

  public int LastIndexOf(CGameEffect value) {
    int retVal = NWNXLibPINVOKE.CExoArrayListCGameEffectPtr_LastIndexOf(swigCPtr, CGameEffect.getCPtr(value));
    return retVal;
  }

  public bool Remove(CGameEffect value) {
    bool ret = NWNXLibPINVOKE.CExoArrayListCGameEffectPtr_Remove(swigCPtr, CGameEffect.getCPtr(value));
    return ret;
  }

}

}

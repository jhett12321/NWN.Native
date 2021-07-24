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

public unsafe class CExoArrayListCNWSPersonalReputation : global::System.IDisposable, global::System.Collections.IEnumerable, global::System.Collections.Generic.IEnumerable<CNWSPersonalReputation>
 {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal CExoArrayListCNWSPersonalReputation(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(CExoArrayListCNWSPersonalReputation obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~CExoArrayListCNWSPersonalReputation() {
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
          NWNXLibPINVOKE.delete_CExoArrayListCNWSPersonalReputation(swigCPtr);
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

  public static unsafe implicit operator void*(CExoArrayListCNWSPersonalReputation self) {
    return (void*)self.swigCPtr.Handle;
  }

  public static unsafe CExoArrayListCNWSPersonalReputation FromPointer(void* pointer, bool memoryOwn = false) {
    return pointer != null ? new CExoArrayListCNWSPersonalReputation((global::System.IntPtr)pointer, memoryOwn) : null;
  }

  public static CExoArrayListCNWSPersonalReputation FromPointer(global::System.IntPtr pointer, bool memoryOwn = false) {
    return pointer != global::System.IntPtr.Zero ? new CExoArrayListCNWSPersonalReputation(pointer, memoryOwn) : null;
  }

  public bool Equals(CExoArrayListCNWSPersonalReputation other) {
    if (ReferenceEquals(null, other)) {
      return false;
    }

    if (ReferenceEquals(this, other)) {
      return true;
    }

    return Pointer.Equals(other.Pointer);
  }

  public override bool Equals(object obj) {
    return ReferenceEquals(this, obj) || obj is CExoArrayListCNWSPersonalReputation other && Equals(other);
  }

  public override int GetHashCode() {
    return swigCPtr.Handle.GetHashCode();
  }

  public static bool operator ==(CExoArrayListCNWSPersonalReputation left, CExoArrayListCNWSPersonalReputation right) {
    return Equals(left, right);
  }

  public static bool operator !=(CExoArrayListCNWSPersonalReputation left, CExoArrayListCNWSPersonalReputation right) {
    return !Equals(left, right);
  }
/*@SWIG@*/
  public CExoArrayListCNWSPersonalReputation(global::System.Collections.IEnumerable c) : this() {
    if (c == null)
      throw new global::System.ArgumentNullException("c");
    foreach (CNWSPersonalReputation element in c) {
      this.Add(element);
    }
  }

  public CExoArrayListCNWSPersonalReputation(global::System.Collections.Generic.IEnumerable<CNWSPersonalReputation> c) : this() {
    if (c == null)
      throw new global::System.ArgumentNullException("c");
    foreach (CNWSPersonalReputation element in c) {
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

  public CNWSPersonalReputation this[int index] {
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

  public void CopyTo(CNWSPersonalReputation[] array)
  {
    CopyTo(0, array, 0, this.Count);
  }

  public void CopyTo(CNWSPersonalReputation[] array, int arrayIndex)
  {
    CopyTo(0, array, arrayIndex, this.Count);
  }

  public void Clear()
  {
    SetSize(0);
  }

  public void CopyTo(int index, CNWSPersonalReputation[] array, int arrayIndex, int count)
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

  public CNWSPersonalReputation[] ToArray() {
    CNWSPersonalReputation[] array = new CNWSPersonalReputation[this.Count];
    this.CopyTo(array);
    return array;
  }

  global::System.Collections.Generic.IEnumerator<CNWSPersonalReputation> global::System.Collections.Generic.IEnumerable<CNWSPersonalReputation>.GetEnumerator() {
    return new CExoArrayListCNWSPersonalReputationEnumerator(this);
  }

  global::System.Collections.IEnumerator global::System.Collections.IEnumerable.GetEnumerator() {
    return new CExoArrayListCNWSPersonalReputationEnumerator(this);
  }

  public CExoArrayListCNWSPersonalReputationEnumerator GetEnumerator() {
    return new CExoArrayListCNWSPersonalReputationEnumerator(this);
  }

  // Type-safe enumerator
  /// Note that the IEnumerator documentation requires an InvalidOperationException to be thrown
  /// whenever the collection is modified. This has been done for changes in the size of the
  /// collection but not when one of the elements of the collection is modified as it is a bit
  /// tricky to detect unmanaged code that modifies the collection under our feet.
  public sealed class CExoArrayListCNWSPersonalReputationEnumerator : global::System.Collections.IEnumerator
    , global::System.Collections.Generic.IEnumerator<CNWSPersonalReputation>
  {
    private CExoArrayListCNWSPersonalReputation collectionRef;
    private int currentIndex;
    private object currentObject;
    private int currentSize;

    public CExoArrayListCNWSPersonalReputationEnumerator(CExoArrayListCNWSPersonalReputation collection) {
      collectionRef = collection;
      currentIndex = -1;
      currentObject = null;
      currentSize = collectionRef.Count;
    }

    // Type-safe iterator Current
    public CNWSPersonalReputation Current {
      get {
        if (currentIndex == -1)
          throw new global::System.InvalidOperationException("Enumeration not started.");
        if (currentIndex > currentSize - 1)
          throw new global::System.InvalidOperationException("Enumeration finished.");
        if (currentObject == null)
          throw new global::System.InvalidOperationException("Collection modified.");
        return (CNWSPersonalReputation)currentObject;
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
      NWNXLibPINVOKE.CExoArrayListCNWSPersonalReputation_num_set(swigCPtr, value);
    } 
    get {
      int retVal = NWNXLibPINVOKE.CExoArrayListCNWSPersonalReputation_num_get(swigCPtr);
      return retVal;
    }

  }

  private int array_size {
    set {
      NWNXLibPINVOKE.CExoArrayListCNWSPersonalReputation_array_size_set(swigCPtr, value);
    } 
    get {
      int retVal = NWNXLibPINVOKE.CExoArrayListCNWSPersonalReputation_array_size_get(swigCPtr);
      return retVal;
    }

  }

  public void Add(CNWSPersonalReputation t) {
    NWNXLibPINVOKE.CExoArrayListCNWSPersonalReputation_Add(swigCPtr, CNWSPersonalReputation.getCPtr(t));
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
  }

  public void Pack() {
    NWNXLibPINVOKE.CExoArrayListCNWSPersonalReputation_Pack(swigCPtr);
  }

  private void Allocate(int s) {
    NWNXLibPINVOKE.CExoArrayListCNWSPersonalReputation_Allocate(swigCPtr, s);
  }

  public void SetSize(int s) {
    NWNXLibPINVOKE.CExoArrayListCNWSPersonalReputation_SetSize(swigCPtr, s);
  }

  public CExoArrayListCNWSPersonalReputation(int s) : this(NWNXLibPINVOKE.new_CExoArrayListCNWSPersonalReputation__SWIG_0(s), true) {
  }

  public CExoArrayListCNWSPersonalReputation() : this(NWNXLibPINVOKE.new_CExoArrayListCNWSPersonalReputation__SWIG_1(), true) {
  }

  public CExoArrayListCNWSPersonalReputation(CExoArrayListCNWSPersonalReputation list) : this(NWNXLibPINVOKE.new_CExoArrayListCNWSPersonalReputation__SWIG_2(CExoArrayListCNWSPersonalReputation.getCPtr(list)), true) {
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
  }

  public void RemoveAt(int index) {
    NWNXLibPINVOKE.CExoArrayListCNWSPersonalReputation_RemoveAt(swigCPtr, index);
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
  }

  private CNWSPersonalReputation InternalGetItem(int index) {
    CNWSPersonalReputation ret = new CNWSPersonalReputation(NWNXLibPINVOKE.CExoArrayListCNWSPersonalReputation_InternalGetItem(swigCPtr, index), false);
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  private CNWSPersonalReputation InternalGetItemCopy(int index) {
    CNWSPersonalReputation ret = new CNWSPersonalReputation(NWNXLibPINVOKE.CExoArrayListCNWSPersonalReputation_InternalGetItemCopy(swigCPtr, index), true);
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  private void InternalSetItem(int index, CNWSPersonalReputation val) {
    NWNXLibPINVOKE.CExoArrayListCNWSPersonalReputation_InternalSetItem(swigCPtr, index, CNWSPersonalReputation.getCPtr(val));
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
  }

  public void Insert(int index, CNWSPersonalReputation x) {
    NWNXLibPINVOKE.CExoArrayListCNWSPersonalReputation_Insert(swigCPtr, index, CNWSPersonalReputation.getCPtr(x));
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
  }

}

}

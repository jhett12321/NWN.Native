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

public unsafe class UnorderedMapUInt64CachedRulesetEntry : global::System.IDisposable, global::System.Collections.Generic.IDictionary<ulong, CachedRulesetEntry> {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal UnorderedMapUInt64CachedRulesetEntry(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(UnorderedMapUInt64CachedRulesetEntry obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~UnorderedMapUInt64CachedRulesetEntry() {
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
          NWNXLibPINVOKE.delete_UnorderedMapUInt64CachedRulesetEntry(swigCPtr);
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

  public static unsafe implicit operator void*(UnorderedMapUInt64CachedRulesetEntry self) {
    return (void*)self.swigCPtr.Handle;
  }

  public static unsafe UnorderedMapUInt64CachedRulesetEntry FromPointer(void* pointer, bool memoryOwn = false) {
    return pointer != null ? new UnorderedMapUInt64CachedRulesetEntry((global::System.IntPtr)pointer, memoryOwn) : null;
  }

  public static UnorderedMapUInt64CachedRulesetEntry FromPointer(global::System.IntPtr pointer, bool memoryOwn = false) {
    return pointer != global::System.IntPtr.Zero ? new UnorderedMapUInt64CachedRulesetEntry(pointer, memoryOwn) : null;
  }

  public bool Equals(UnorderedMapUInt64CachedRulesetEntry other) {
    if (ReferenceEquals(null, other)) {
      return false;
    }

    if (ReferenceEquals(this, other)) {
      return true;
    }

    return Pointer.Equals(other.Pointer);
  }

  public override bool Equals(object obj) {
    return ReferenceEquals(this, obj) || obj is UnorderedMapUInt64CachedRulesetEntry other && Equals(other);
  }

  public override int GetHashCode() {
    return swigCPtr.Handle.GetHashCode();
  }

  public static bool operator ==(UnorderedMapUInt64CachedRulesetEntry left, UnorderedMapUInt64CachedRulesetEntry right) {
    return Equals(left, right);
  }

  public static bool operator !=(UnorderedMapUInt64CachedRulesetEntry left, UnorderedMapUInt64CachedRulesetEntry right) {
    return !Equals(left, right);
  }

  public bool IsReadOnly
  {
    get => false;
  }

  public int Count
  {
    get => (int)size();
  }

  public CachedRulesetEntry this[ulong key]
  {
    get
    {
      Iterator iterator = find(key);
      if (iterator.IsEqual(end()))
      {
         throw new global::System.Collections.Generic.KeyNotFoundException("The given key was not present in the UnorderedMap.");
      }

      return iterator.GetValue();
    }

    set => InternalSetValue(key, value);
  }

  public bool Remove(ulong key)
  {
    Iterator iterator = find(key);
    if (!iterator.IsEqual(end()))
    {
      InternalRemove(iterator);
      return true;
    }

    return false;
  }

  public bool TryGetValue(ulong key, out CachedRulesetEntry value)
  {
      Iterator iterator = find(key);
      if (iterator.IsEqual(end()))
      {
         value = default;
         return false;
      }

      value = iterator.GetValue();
      return true;
  }

  public global::System.Collections.Generic.ICollection<ulong> Keys
  {
    get
    {
      int startCount = Count;
      Iterator iterator = begin();
      Iterator endIterator = end();

      global::System.Collections.Generic.ICollection<ulong> keys = new global::System.Collections.Generic.List<ulong>();

      while (!iterator.IsEqual(endIterator))
      {
        if (Count != startCount)
        {
          throw new System.InvalidOperationException("Collection was modified; enumeration operation may not execute.");
        }

        keys.Add(iterator.GetKey());
        iterator = iterator.MoveNext();
      }

      return keys;
    }
  }

  public global::System.Collections.Generic.ICollection<CachedRulesetEntry> Values
  {
    get
    {
      int startCount = Count;
      Iterator iterator = begin();
      Iterator endIterator = end();

      global::System.Collections.Generic.ICollection<CachedRulesetEntry> values = new global::System.Collections.Generic.List<CachedRulesetEntry>();

      while (!iterator.IsEqual(endIterator))
      {
        if (Count != startCount)
        {
          throw new System.InvalidOperationException("Collection was modified; enumeration operation may not execute.");
        }

        values.Add(iterator.GetValue());
        iterator = iterator.MoveNext();
      }

      return values;
    }
  }

  public void Add(ulong key, CachedRulesetEntry value)
  {
    if (ContainsKey(key))
    {
      throw new global::System.ArgumentException(nameof(key), "An item with the same key has already been added.");
    }

    InternalSetValue(key, value);
  }

  public void Add(global::System.Collections.Generic.KeyValuePair<ulong, CachedRulesetEntry> item)
  {
    Add(item.Key, item.Value);
  }

  bool global::System.Collections.Generic.ICollection<global::System.Collections.Generic.KeyValuePair<ulong, CachedRulesetEntry>>.Contains(global::System.Collections.Generic.KeyValuePair<ulong, CachedRulesetEntry> keyValuePair)
  {
    return TryGetValue(keyValuePair.Key, out CachedRulesetEntry value) && value == keyValuePair.Value;
  }

  bool global::System.Collections.Generic.ICollection<global::System.Collections.Generic.KeyValuePair<ulong, CachedRulesetEntry>>.Remove(global::System.Collections.Generic.KeyValuePair<ulong, CachedRulesetEntry> keyValuePair)
  {
    Iterator iterator = find(keyValuePair.Key);
    if (!iterator.IsEqual(end()) && iterator.GetValue() == keyValuePair.Value)
    {
      InternalRemove(iterator);
      return true;
    }

    return false;
  }

  public void CopyTo(global::System.Collections.Generic.KeyValuePair<ulong, CachedRulesetEntry>[] array)
  {
    CopyTo(array, 0);
  }

  public void CopyTo(global::System.Collections.Generic.KeyValuePair<ulong, CachedRulesetEntry>[] array, int arrayIndex)
  {
    if (array == null)
      throw new global::System.ArgumentNullException("array");
    if (arrayIndex < 0)
      throw new global::System.ArgumentOutOfRangeException("arrayIndex", "Value is less than zero");
    if (array.Rank > 1)
      throw new global::System.ArgumentException("Multi dimensional array.", "array");
    if (arrayIndex+this.Count > array.Length)
      throw new global::System.ArgumentException("Number of elements to copy is too large.");

    int startCount = Count;
    Iterator iterator = begin();
    Iterator endIterator = end();

    for (int i = 0; i < Count && !iterator.IsEqual(endIterator); i++, iterator = iterator.MoveNext())
    {
      if (Count != startCount)
      {
        throw new System.InvalidOperationException("Collection was modified; enumeration operation may not execute.");
      }

      array.SetValue(new global::System.Collections.Generic.KeyValuePair<ulong, CachedRulesetEntry>(iterator.GetKey(), iterator.GetValue()), arrayIndex+i);
    }
  }

  public global::System.Collections.Generic.IEnumerator<global::System.Collections.Generic.KeyValuePair<ulong, CachedRulesetEntry>> GetEnumerator()
  {
    int startCount = Count;
    Iterator iterator = begin();
    Iterator endIterator = end();

    while (!iterator.IsEqual(endIterator))
    {
      if (Count != startCount)
      {
        throw new System.InvalidOperationException("Collection was modified; enumeration operation may not execute.");
      }

      yield return new global::System.Collections.Generic.KeyValuePair<ulong, CachedRulesetEntry>(iterator.GetKey(), iterator.GetValue());
      iterator = iterator.MoveNext();
    }
  }

  global::System.Collections.IEnumerator global::System.Collections.IEnumerable.GetEnumerator()
  {
    return GetEnumerator();
  }

  public UnorderedMapUInt64CachedRulesetEntry() : this(NWNXLibPINVOKE.new_UnorderedMapUInt64CachedRulesetEntry__SWIG_0(), true) {
  }

  public UnorderedMapUInt64CachedRulesetEntry(UnorderedMapUInt64CachedRulesetEntry other) : this(NWNXLibPINVOKE.new_UnorderedMapUInt64CachedRulesetEntry__SWIG_1(UnorderedMapUInt64CachedRulesetEntry.getCPtr(other)), true) {
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
  }

  private class Iterator : global::System.IDisposable {
    private global::System.Runtime.InteropServices.HandleRef swigCPtr;
    protected bool swigCMemOwn;
  
    internal Iterator(global::System.IntPtr cPtr, bool cMemoryOwn) {
      swigCMemOwn = cMemoryOwn;
      swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
    }
  
    internal static global::System.Runtime.InteropServices.HandleRef getCPtr(Iterator obj) {
      return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
    }
  
    ~Iterator() {
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
            NWNXLibPINVOKE.delete_UnorderedMapUInt64CachedRulesetEntry_Iterator(swigCPtr);
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
  
    public static unsafe implicit operator void*(Iterator self) {
      return (void*)self.swigCPtr.Handle;
    }
  
    public static unsafe Iterator FromPointer(void* pointer, bool memoryOwn = false) {
      return pointer != null ? new Iterator((global::System.IntPtr)pointer, memoryOwn) : null;
    }
  
    public static Iterator FromPointer(global::System.IntPtr pointer, bool memoryOwn = false) {
      return pointer != global::System.IntPtr.Zero ? new Iterator(pointer, memoryOwn) : null;
    }
  
    public bool Equals(Iterator other) {
      if (ReferenceEquals(null, other)) {
        return false;
      }
  
      if (ReferenceEquals(this, other)) {
        return true;
      }
  
      return Pointer.Equals(other.Pointer);
    }
  
    public override bool Equals(object obj) {
      return ReferenceEquals(this, obj) || obj is Iterator other && Equals(other);
    }
  
    public override int GetHashCode() {
      return swigCPtr.Handle.GetHashCode();
    }
  
    public static bool operator ==(Iterator left, Iterator right) {
      return Equals(left, right);
    }
  
    public static bool operator !=(Iterator left, Iterator right) {
      return !Equals(left, right);
    }
  
    public UnorderedMapUInt64CachedRulesetEntry.Iterator MoveNext() {
      UnorderedMapUInt64CachedRulesetEntry.Iterator ret = new UnorderedMapUInt64CachedRulesetEntry.Iterator(NWNXLibPINVOKE.UnorderedMapUInt64CachedRulesetEntry_Iterator_MoveNext(swigCPtr), true);
      return ret;
    }
  
    internal bool IsEqual(UnorderedMapUInt64CachedRulesetEntry.Iterator other) {
      bool ret = NWNXLibPINVOKE.UnorderedMapUInt64CachedRulesetEntry_Iterator_IsEqual(swigCPtr, UnorderedMapUInt64CachedRulesetEntry.Iterator.getCPtr(other));
      if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    }
  
    internal ulong GetKey() {
      ulong ret = NWNXLibPINVOKE.UnorderedMapUInt64CachedRulesetEntry_Iterator_GetKey(swigCPtr);
      return ret;
    }
  
    internal CachedRulesetEntry GetValue() {
      CachedRulesetEntry ret = new CachedRulesetEntry(NWNXLibPINVOKE.UnorderedMapUInt64CachedRulesetEntry_Iterator_GetValue(swigCPtr), true);
      return ret;
    }
  
    internal void SetValue(CachedRulesetEntry newValue) {
      NWNXLibPINVOKE.UnorderedMapUInt64CachedRulesetEntry_Iterator_SetValue(swigCPtr, CachedRulesetEntry.getCPtr(newValue));
      if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
    }
  
  }

  private uint size() {
    uint ret = NWNXLibPINVOKE.UnorderedMapUInt64CachedRulesetEntry_size(swigCPtr);
    return ret;
  }

  public void Clear() {
    NWNXLibPINVOKE.UnorderedMapUInt64CachedRulesetEntry_Clear(swigCPtr);
  }

  private UnorderedMapUInt64CachedRulesetEntry.Iterator find(ulong key) {
    UnorderedMapUInt64CachedRulesetEntry.Iterator ret = new UnorderedMapUInt64CachedRulesetEntry.Iterator(NWNXLibPINVOKE.UnorderedMapUInt64CachedRulesetEntry_find(swigCPtr, key), true);
    return ret;
  }

  private UnorderedMapUInt64CachedRulesetEntry.Iterator begin() {
    UnorderedMapUInt64CachedRulesetEntry.Iterator ret = new UnorderedMapUInt64CachedRulesetEntry.Iterator(NWNXLibPINVOKE.UnorderedMapUInt64CachedRulesetEntry_begin(swigCPtr), true);
    return ret;
  }

  private UnorderedMapUInt64CachedRulesetEntry.Iterator end() {
    UnorderedMapUInt64CachedRulesetEntry.Iterator ret = new UnorderedMapUInt64CachedRulesetEntry.Iterator(NWNXLibPINVOKE.UnorderedMapUInt64CachedRulesetEntry_end(swigCPtr), true);
    return ret;
  }

  public bool ContainsKey(ulong key) {
    bool ret = NWNXLibPINVOKE.UnorderedMapUInt64CachedRulesetEntry_ContainsKey(swigCPtr, key);
    return ret;
  }

  private void InternalSetValue(ulong key, CachedRulesetEntry value) {
    NWNXLibPINVOKE.UnorderedMapUInt64CachedRulesetEntry_InternalSetValue(swigCPtr, key, CachedRulesetEntry.getCPtr(value));
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
  }

  private void InternalRemove(UnorderedMapUInt64CachedRulesetEntry.Iterator itr) {
    NWNXLibPINVOKE.UnorderedMapUInt64CachedRulesetEntry_InternalRemove(swigCPtr, UnorderedMapUInt64CachedRulesetEntry.Iterator.getCPtr(itr));
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
  }

}

}

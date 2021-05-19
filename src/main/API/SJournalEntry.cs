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

public unsafe class SJournalEntry : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal SJournalEntry(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(SJournalEntry obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~SJournalEntry() {
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
          NWNXLibPINVOKE.delete_SJournalEntry(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
    }
  }
/*@SWIG:/__w/NWN.Native/NWN.Native/nwnx/Plugins/SWIG/SWIG_DotNET/API_NWNXLib.i,20,SWIG_DOTNET_EXTENSIONS@*/
  public global::System.IntPtr Pointer {
    get {
      return swigCPtr.Handle;
    }
  }

  public static unsafe implicit operator void*(SJournalEntry self) {
    return (void*)self.swigCPtr.Handle;
  }

  public static unsafe SJournalEntry FromPointer(void* pointer, bool memoryOwn = false) {
    return pointer != null ? new SJournalEntry((global::System.IntPtr)pointer, memoryOwn) : null;
  }

  public static SJournalEntry FromPointer(global::System.IntPtr pointer, bool memoryOwn = false) {
    return pointer != global::System.IntPtr.Zero ? new SJournalEntry(pointer, memoryOwn) : null;
  }

  public bool Equals(SJournalEntry other) {
    if (ReferenceEquals(null, other)) {
      return false;
    }

    if (ReferenceEquals(this, other)) {
      return true;
    }

    return Pointer.Equals(other.Pointer);
  }

  public override bool Equals(object obj) {
    return ReferenceEquals(this, obj) || obj is SJournalEntry other && Equals(other);
  }

  public override int GetHashCode() {
    return swigCPtr.Handle.GetHashCode();
  }

  public static bool operator ==(SJournalEntry left, SJournalEntry right) {
    return Equals(left, right);
  }

  public static bool operator !=(SJournalEntry left, SJournalEntry right) {
    return !Equals(left, right);
  }
/*@SWIG@*/
  public CExoLocString szName {
    set {
      NWNXLibPINVOKE.SJournalEntry_szName_set(swigCPtr, CExoLocString.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = NWNXLibPINVOKE.SJournalEntry_szName_get(swigCPtr);
      CExoLocString ret = (cPtr == global::System.IntPtr.Zero) ? null : new CExoLocString(cPtr, false);
      return ret;
    } 
  }

  public CExoLocString szText {
    set {
      NWNXLibPINVOKE.SJournalEntry_szText_set(swigCPtr, CExoLocString.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = NWNXLibPINVOKE.SJournalEntry_szText_get(swigCPtr);
      CExoLocString ret = (cPtr == global::System.IntPtr.Zero) ? null : new CExoLocString(cPtr, false);
      return ret;
    } 
  }

  public uint nCalendarDay {
    set {
      NWNXLibPINVOKE.SJournalEntry_nCalendarDay_set(swigCPtr, value);
    } 
    get {
      uint ret = NWNXLibPINVOKE.SJournalEntry_nCalendarDay_get(swigCPtr);
      return ret;
    } 
  }

  public uint nTimeOfDay {
    set {
      NWNXLibPINVOKE.SJournalEntry_nTimeOfDay_set(swigCPtr, value);
    } 
    get {
      uint ret = NWNXLibPINVOKE.SJournalEntry_nTimeOfDay_get(swigCPtr);
      return ret;
    } 
  }

  public CExoString szPlot_Id {
    set {
      NWNXLibPINVOKE.SJournalEntry_szPlot_Id_set(swigCPtr, CExoString.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = NWNXLibPINVOKE.SJournalEntry_szPlot_Id_get(swigCPtr);
      CExoString ret = (cPtr == global::System.IntPtr.Zero) ? null : new CExoString(cPtr, false);
      return ret;
    } 
  }

  public uint nState {
    set {
      NWNXLibPINVOKE.SJournalEntry_nState_set(swigCPtr, value);
    } 
    get {
      uint ret = NWNXLibPINVOKE.SJournalEntry_nState_get(swigCPtr);
      return ret;
    } 
  }

  public uint nPriority {
    set {
      NWNXLibPINVOKE.SJournalEntry_nPriority_set(swigCPtr, value);
    } 
    get {
      uint ret = NWNXLibPINVOKE.SJournalEntry_nPriority_get(swigCPtr);
      return ret;
    } 
  }

  public ushort nPictureIndex {
    set {
      NWNXLibPINVOKE.SJournalEntry_nPictureIndex_set(swigCPtr, value);
    } 
    get {
      ushort ret = NWNXLibPINVOKE.SJournalEntry_nPictureIndex_get(swigCPtr);
      return ret;
    } 
  }

  public int bQuestCompleted {
    set {
      NWNXLibPINVOKE.SJournalEntry_bQuestCompleted_set(swigCPtr, value);
    } 
    get {
      int ret = NWNXLibPINVOKE.SJournalEntry_bQuestCompleted_get(swigCPtr);
      return ret;
    } 
  }

  public int bQuestDisplayed {
    set {
      NWNXLibPINVOKE.SJournalEntry_bQuestDisplayed_set(swigCPtr, value);
    } 
    get {
      int ret = NWNXLibPINVOKE.SJournalEntry_bQuestDisplayed_get(swigCPtr);
      return ret;
    } 
  }

  public int bUpdated {
    set {
      NWNXLibPINVOKE.SJournalEntry_bUpdated_set(swigCPtr, value);
    } 
    get {
      int ret = NWNXLibPINVOKE.SJournalEntry_bUpdated_get(swigCPtr);
      return ret;
    } 
  }

  public SJournalEntry() : this(NWNXLibPINVOKE.new_SJournalEntry(), true) {
  }

}

}

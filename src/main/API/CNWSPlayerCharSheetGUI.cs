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

public unsafe class CNWSPlayerCharSheetGUI : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal CNWSPlayerCharSheetGUI(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(CNWSPlayerCharSheetGUI obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~CNWSPlayerCharSheetGUI() {
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
          NWNXLibPINVOKE.delete_CNWSPlayerCharSheetGUI(swigCPtr);
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

  public static unsafe implicit operator void*(CNWSPlayerCharSheetGUI self) {
    return (void*)self.swigCPtr.Handle;
  }

  public static unsafe CNWSPlayerCharSheetGUI FromPointer(void* pointer, bool memoryOwn = false) {
    return pointer != null ? new CNWSPlayerCharSheetGUI((global::System.IntPtr)pointer, memoryOwn) : null;
  }

  public static CNWSPlayerCharSheetGUI FromPointer(global::System.IntPtr pointer, bool memoryOwn = false) {
    return pointer != global::System.IntPtr.Zero ? new CNWSPlayerCharSheetGUI(pointer, memoryOwn) : null;
  }

  public bool Equals(CNWSPlayerCharSheetGUI other) {
    if (ReferenceEquals(null, other)) {
      return false;
    }

    if (ReferenceEquals(this, other)) {
      return true;
    }

    return Pointer.Equals(other.Pointer);
  }

  public override bool Equals(object obj) {
    return ReferenceEquals(this, obj) || obj is CNWSPlayerCharSheetGUI other && Equals(other);
  }

  public override int GetHashCode() {
    return swigCPtr.Handle.GetHashCode();
  }

  public static bool operator ==(CNWSPlayerCharSheetGUI left, CNWSPlayerCharSheetGUI right) {
    return Equals(left, right);
  }

  public static bool operator !=(CNWSPlayerCharSheetGUI left, CNWSPlayerCharSheetGUI right) {
    return !Equals(left, right);
  }

  public uint m_oidCreatureDisplayed {
    set {
      NWNXLibPINVOKE.CNWSPlayerCharSheetGUI_m_oidCreatureDisplayed_set(swigCPtr, value);
    } 
    get {
      uint retVal = NWNXLibPINVOKE.CNWSPlayerCharSheetGUI_m_oidCreatureDisplayed_get(swigCPtr);
      return retVal;
    }

  }

  public byte m_nActivePanel {
    set {
      NWNXLibPINVOKE.CNWSPlayerCharSheetGUI_m_nActivePanel_set(swigCPtr, value);
    } 
    get {
      byte retVal = NWNXLibPINVOKE.CNWSPlayerCharSheetGUI_m_nActivePanel_get(swigCPtr);
      return retVal;
    }

  }

  public CNWCreatureStatsUpdate m_pLastStatsUpdate {
    set {
      NWNXLibPINVOKE.CNWSPlayerCharSheetGUI_m_pLastStatsUpdate_set(swigCPtr, CNWCreatureStatsUpdate.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = NWNXLibPINVOKE.CNWSPlayerCharSheetGUI_m_pLastStatsUpdate_get(swigCPtr);
      CNWCreatureStatsUpdate ret = (cPtr == global::System.IntPtr.Zero) ? null : new CNWCreatureStatsUpdate(cPtr, false);
      return ret;
    } 
  }

  public int m_bForceInitialCharSheetUpdate {
    set {
      NWNXLibPINVOKE.CNWSPlayerCharSheetGUI_m_bForceInitialCharSheetUpdate_set(swigCPtr, value);
    } 
    get {
      int retVal = NWNXLibPINVOKE.CNWSPlayerCharSheetGUI_m_bForceInitialCharSheetUpdate_get(swigCPtr);
      return retVal;
    }

  }

  public uint ComputeCharacterSheetUpdateRequired(CNWSPlayer pPlayer) {
    uint retVal = NWNXLibPINVOKE.CNWSPlayerCharSheetGUI_ComputeCharacterSheetUpdateRequired(swigCPtr, CNWSPlayer.getCPtr(pPlayer));
    return retVal;
  }

  public void SetCreatureDisplayed(uint oidCreature) {
    NWNXLibPINVOKE.CNWSPlayerCharSheetGUI_SetCreatureDisplayed(swigCPtr, oidCreature);
  }

  public CNWSPlayerCharSheetGUI() : this(NWNXLibPINVOKE.new_CNWSPlayerCharSheetGUI(), true) {
  }

}

}

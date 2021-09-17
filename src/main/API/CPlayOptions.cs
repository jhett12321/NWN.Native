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

public unsafe class CPlayOptions : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal CPlayOptions(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(CPlayOptions obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~CPlayOptions() {
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
          NWNXLibPINVOKE.delete_CPlayOptions(swigCPtr);
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

  public static unsafe implicit operator void*(CPlayOptions self) {
    return (void*)self.swigCPtr.Handle;
  }

  public static unsafe CPlayOptions FromPointer(void* pointer, bool memoryOwn = false) {
    return pointer != null ? new CPlayOptions((global::System.IntPtr)pointer, memoryOwn) : null;
  }

  public static CPlayOptions FromPointer(global::System.IntPtr pointer, bool memoryOwn = false) {
    return pointer != global::System.IntPtr.Zero ? new CPlayOptions(pointer, memoryOwn) : null;
  }

  public bool Equals(CPlayOptions other) {
    if (ReferenceEquals(null, other)) {
      return false;
    }

    if (ReferenceEquals(this, other)) {
      return true;
    }

    return Pointer.Equals(other.Pointer);
  }

  public override bool Equals(object obj) {
    return ReferenceEquals(this, obj) || obj is CPlayOptions other && Equals(other);
  }

  public override int GetHashCode() {
    return swigCPtr.Handle.GetHashCode();
  }

  public static bool operator ==(CPlayOptions left, CPlayOptions right) {
    return Equals(left, right);
  }

  public static bool operator !=(CPlayOptions left, CPlayOptions right) {
    return !Equals(left, right);
  }
/*@SWIG@*/
  public int bAllKillable {
    set {
      NWNXLibPINVOKE.CPlayOptions_bAllKillable_set(swigCPtr, value);
    } 
    get {
      int retVal = NWNXLibPINVOKE.CPlayOptions_bAllKillable_get(swigCPtr);
      return retVal;
    }

  }

  public int bNonPartyKillable {
    set {
      NWNXLibPINVOKE.CPlayOptions_bNonPartyKillable_set(swigCPtr, value);
    } 
    get {
      int retVal = NWNXLibPINVOKE.CPlayOptions_bNonPartyKillable_get(swigCPtr);
      return retVal;
    }

  }

  public int bRequireResurrection {
    set {
      NWNXLibPINVOKE.CPlayOptions_bRequireResurrection_set(swigCPtr, value);
    } 
    get {
      int retVal = NWNXLibPINVOKE.CPlayOptions_bRequireResurrection_get(swigCPtr);
      return retVal;
    }

  }

  public int bLoseStolenItems {
    set {
      NWNXLibPINVOKE.CPlayOptions_bLoseStolenItems_set(swigCPtr, value);
    } 
    get {
      int retVal = NWNXLibPINVOKE.CPlayOptions_bLoseStolenItems_get(swigCPtr);
      return retVal;
    }

  }

  public int bLoseItems {
    set {
      NWNXLibPINVOKE.CPlayOptions_bLoseItems_set(swigCPtr, value);
    } 
    get {
      int retVal = NWNXLibPINVOKE.CPlayOptions_bLoseItems_get(swigCPtr);
      return retVal;
    }

  }

  public int bLoseExp {
    set {
      NWNXLibPINVOKE.CPlayOptions_bLoseExp_set(swigCPtr, value);
    } 
    get {
      int retVal = NWNXLibPINVOKE.CPlayOptions_bLoseExp_get(swigCPtr);
      return retVal;
    }

  }

  public int bLoseGold {
    set {
      NWNXLibPINVOKE.CPlayOptions_bLoseGold_set(swigCPtr, value);
    } 
    get {
      int retVal = NWNXLibPINVOKE.CPlayOptions_bLoseGold_get(swigCPtr);
      return retVal;
    }

  }

  public int nLoseGoldNum {
    set {
      NWNXLibPINVOKE.CPlayOptions_nLoseGoldNum_set(swigCPtr, value);
    } 
    get {
      int retVal = NWNXLibPINVOKE.CPlayOptions_nLoseGoldNum_get(swigCPtr);
      return retVal;
    }

  }

  public int nLoseExpNum {
    set {
      NWNXLibPINVOKE.CPlayOptions_nLoseExpNum_set(swigCPtr, value);
    } 
    get {
      int retVal = NWNXLibPINVOKE.CPlayOptions_nLoseExpNum_get(swigCPtr);
      return retVal;
    }

  }

  public int nLoseItemsNum {
    set {
      NWNXLibPINVOKE.CPlayOptions_nLoseItemsNum_set(swigCPtr, value);
    } 
    get {
      int retVal = NWNXLibPINVOKE.CPlayOptions_nLoseItemsNum_get(swigCPtr);
      return retVal;
    }

  }

  public int nPVPSetting {
    set {
      NWNXLibPINVOKE.CPlayOptions_nPVPSetting_set(swigCPtr, value);
    } 
    get {
      int retVal = NWNXLibPINVOKE.CPlayOptions_nPVPSetting_get(swigCPtr);
      return retVal;
    }

  }

  public int bPauseAndPlay {
    set {
      NWNXLibPINVOKE.CPlayOptions_bPauseAndPlay_set(swigCPtr, value);
    } 
    get {
      int retVal = NWNXLibPINVOKE.CPlayOptions_bPauseAndPlay_get(swigCPtr);
      return retVal;
    }

  }

  public int bOnePartyOnly {
    set {
      NWNXLibPINVOKE.CPlayOptions_bOnePartyOnly_set(swigCPtr, value);
    } 
    get {
      int retVal = NWNXLibPINVOKE.CPlayOptions_bOnePartyOnly_get(swigCPtr);
      return retVal;
    }

  }

  public int bEnforceLegalCharacters {
    set {
      NWNXLibPINVOKE.CPlayOptions_bEnforceLegalCharacters_set(swigCPtr, value);
    } 
    get {
      int retVal = NWNXLibPINVOKE.CPlayOptions_bEnforceLegalCharacters_get(swigCPtr);
      return retVal;
    }

  }

  public int bItemLevelRestrictions {
    set {
      NWNXLibPINVOKE.CPlayOptions_bItemLevelRestrictions_set(swigCPtr, value);
    } 
    get {
      int retVal = NWNXLibPINVOKE.CPlayOptions_bItemLevelRestrictions_get(swigCPtr);
      return retVal;
    }

  }

  public int bCDKeyBanListAllowList {
    set {
      NWNXLibPINVOKE.CPlayOptions_bCDKeyBanListAllowList_set(swigCPtr, value);
    } 
    get {
      int retVal = NWNXLibPINVOKE.CPlayOptions_bCDKeyBanListAllowList_get(swigCPtr);
      return retVal;
    }

  }

  public int bDisallowShouting {
    set {
      NWNXLibPINVOKE.CPlayOptions_bDisallowShouting_set(swigCPtr, value);
    } 
    get {
      int retVal = NWNXLibPINVOKE.CPlayOptions_bDisallowShouting_get(swigCPtr);
      return retVal;
    }

  }

  public int bShowDMJoinMessage {
    set {
      NWNXLibPINVOKE.CPlayOptions_bShowDMJoinMessage_set(swigCPtr, value);
    } 
    get {
      int retVal = NWNXLibPINVOKE.CPlayOptions_bShowDMJoinMessage_get(swigCPtr);
      return retVal;
    }

  }

  public int bBackupSavedCharacters {
    set {
      NWNXLibPINVOKE.CPlayOptions_bBackupSavedCharacters_set(swigCPtr, value);
    } 
    get {
      int retVal = NWNXLibPINVOKE.CPlayOptions_bBackupSavedCharacters_get(swigCPtr);
      return retVal;
    }

  }

  public int bAutoFailSaveOn1 {
    set {
      NWNXLibPINVOKE.CPlayOptions_bAutoFailSaveOn1_set(swigCPtr, value);
    } 
    get {
      int retVal = NWNXLibPINVOKE.CPlayOptions_bAutoFailSaveOn1_get(swigCPtr);
      return retVal;
    }

  }

  public int bValidateSpells {
    set {
      NWNXLibPINVOKE.CPlayOptions_bValidateSpells_set(swigCPtr, value);
    } 
    get {
      int retVal = NWNXLibPINVOKE.CPlayOptions_bValidateSpells_get(swigCPtr);
      return retVal;
    }

  }

  public int bExamineEffects {
    set {
      NWNXLibPINVOKE.CPlayOptions_bExamineEffects_set(swigCPtr, value);
    } 
    get {
      int retVal = NWNXLibPINVOKE.CPlayOptions_bExamineEffects_get(swigCPtr);
      return retVal;
    }

  }

  public int bExamineChallengeRating {
    set {
      NWNXLibPINVOKE.CPlayOptions_bExamineChallengeRating_set(swigCPtr, value);
    } 
    get {
      int retVal = NWNXLibPINVOKE.CPlayOptions_bExamineChallengeRating_get(swigCPtr);
      return retVal;
    }

  }

  public int bUseMaxHitPoints {
    set {
      NWNXLibPINVOKE.CPlayOptions_bUseMaxHitPoints_set(swigCPtr, value);
    } 
    get {
      int retVal = NWNXLibPINVOKE.CPlayOptions_bUseMaxHitPoints_get(swigCPtr);
      return retVal;
    }

  }

  public int bRestoreSpellsUses {
    set {
      NWNXLibPINVOKE.CPlayOptions_bRestoreSpellsUses_set(swigCPtr, value);
    } 
    get {
      int retVal = NWNXLibPINVOKE.CPlayOptions_bRestoreSpellsUses_get(swigCPtr);
      return retVal;
    }

  }

  public int bResetEncounterSpawnPool {
    set {
      NWNXLibPINVOKE.CPlayOptions_bResetEncounterSpawnPool_set(swigCPtr, value);
    } 
    get {
      int retVal = NWNXLibPINVOKE.CPlayOptions_bResetEncounterSpawnPool_get(swigCPtr);
      return retVal;
    }

  }

  public int bHideHitPointsGained {
    set {
      NWNXLibPINVOKE.CPlayOptions_bHideHitPointsGained_set(swigCPtr, value);
    } 
    get {
      int retVal = NWNXLibPINVOKE.CPlayOptions_bHideHitPointsGained_get(swigCPtr);
      return retVal;
    }

  }

  public int bPlayerPartyControl {
    set {
      NWNXLibPINVOKE.CPlayOptions_bPlayerPartyControl_set(swigCPtr, value);
    } 
    get {
      int retVal = NWNXLibPINVOKE.CPlayOptions_bPlayerPartyControl_get(swigCPtr);
      return retVal;
    }

  }

  public CPlayOptions() : this(NWNXLibPINVOKE.new_CPlayOptions(), true) {
  }

}

}

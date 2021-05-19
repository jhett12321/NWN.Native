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

public unsafe class CWorldTimer : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal CWorldTimer(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(CWorldTimer obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~CWorldTimer() {
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
          NWNXLibPINVOKE.delete_CWorldTimer(swigCPtr);
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

  public static unsafe implicit operator void*(CWorldTimer self) {
    return (void*)self.swigCPtr.Handle;
  }

  public static unsafe CWorldTimer FromPointer(void* pointer, bool memoryOwn = false) {
    return pointer != null ? new CWorldTimer((global::System.IntPtr)pointer, memoryOwn) : null;
  }

  public static CWorldTimer FromPointer(global::System.IntPtr pointer, bool memoryOwn = false) {
    return pointer != global::System.IntPtr.Zero ? new CWorldTimer(pointer, memoryOwn) : null;
  }

  public bool Equals(CWorldTimer other) {
    if (ReferenceEquals(null, other)) {
      return false;
    }

    if (ReferenceEquals(this, other)) {
      return true;
    }

    return Pointer.Equals(other.Pointer);
  }

  public override bool Equals(object obj) {
    return ReferenceEquals(this, obj) || obj is CWorldTimer other && Equals(other);
  }

  public override int GetHashCode() {
    return swigCPtr.Handle.GetHashCode();
  }

  public static bool operator ==(CWorldTimer left, CWorldTimer right) {
    return Equals(left, right);
  }

  public static bool operator !=(CWorldTimer left, CWorldTimer right) {
    return !Equals(left, right);
  }
/*@SWIG@*/
  public int m_bFixedSnapshotRate {
    set {
      NWNXLibPINVOKE.CWorldTimer_m_bFixedSnapshotRate_set(swigCPtr, value);
    } 
    get {
      int ret = NWNXLibPINVOKE.CWorldTimer_m_bFixedSnapshotRate_get(swigCPtr);
      return ret;
    } 
  }

  public int m_nFixedSnapshotsPerSecond {
    set {
      NWNXLibPINVOKE.CWorldTimer_m_nFixedSnapshotsPerSecond_set(swigCPtr, value);
    } 
    get {
      int ret = NWNXLibPINVOKE.CWorldTimer_m_nFixedSnapshotsPerSecond_get(swigCPtr);
      return ret;
    } 
  }

  public uint m_nTimeSnapshot {
    set {
      NWNXLibPINVOKE.CWorldTimer_m_nTimeSnapshot_set(swigCPtr, value);
    } 
    get {
      uint ret = NWNXLibPINVOKE.CWorldTimer_m_nTimeSnapshot_get(swigCPtr);
      return ret;
    } 
  }

  public uint m_nLastTimeSnapshot {
    set {
      NWNXLibPINVOKE.CWorldTimer_m_nLastTimeSnapshot_set(swigCPtr, value);
    } 
    get {
      uint ret = NWNXLibPINVOKE.CWorldTimer_m_nLastTimeSnapshot_get(swigCPtr);
      return ret;
    } 
  }

  public int m_bPaused {
    set {
      NWNXLibPINVOKE.CWorldTimer_m_bPaused_set(swigCPtr, value);
    } 
    get {
      int ret = NWNXLibPINVOKE.CWorldTimer_m_bPaused_get(swigCPtr);
      return ret;
    } 
  }

  public uint m_nPausedCalendarDay {
    set {
      NWNXLibPINVOKE.CWorldTimer_m_nPausedCalendarDay_set(swigCPtr, value);
    } 
    get {
      uint ret = NWNXLibPINVOKE.CWorldTimer_m_nPausedCalendarDay_get(swigCPtr);
      return ret;
    } 
  }

  public uint m_nPausedTimeOfDay {
    set {
      NWNXLibPINVOKE.CWorldTimer_m_nPausedTimeOfDay_set(swigCPtr, value);
    } 
    get {
      uint ret = NWNXLibPINVOKE.CWorldTimer_m_nPausedTimeOfDay_get(swigCPtr);
      return ret;
    } 
  }

  public uint m_nCalendarDayAdjustment {
    set {
      NWNXLibPINVOKE.CWorldTimer_m_nCalendarDayAdjustment_set(swigCPtr, value);
    } 
    get {
      uint ret = NWNXLibPINVOKE.CWorldTimer_m_nCalendarDayAdjustment_get(swigCPtr);
      return ret;
    } 
  }

  public uint m_nTimeOfDayAdjustment {
    set {
      NWNXLibPINVOKE.CWorldTimer_m_nTimeOfDayAdjustment_set(swigCPtr, value);
    } 
    get {
      uint ret = NWNXLibPINVOKE.CWorldTimer_m_nTimeOfDayAdjustment_get(swigCPtr);
      return ret;
    } 
  }

  public byte m_nMinutesPerHour {
    set {
      NWNXLibPINVOKE.CWorldTimer_m_nMinutesPerHour_set(swigCPtr, value);
    } 
    get {
      byte ret = NWNXLibPINVOKE.CWorldTimer_m_nMinutesPerHour_get(swigCPtr);
      return ret;
    } 
  }

  public uint m_nMillisecondsPerDay {
    set {
      NWNXLibPINVOKE.CWorldTimer_m_nMillisecondsPerDay_set(swigCPtr, value);
    } 
    get {
      uint ret = NWNXLibPINVOKE.CWorldTimer_m_nMillisecondsPerDay_get(swigCPtr);
      return ret;
    } 
  }

  public uint m_nSecondsPerDay {
    set {
      NWNXLibPINVOKE.CWorldTimer_m_nSecondsPerDay_set(swigCPtr, value);
    } 
    get {
      uint ret = NWNXLibPINVOKE.CWorldTimer_m_nSecondsPerDay_get(swigCPtr);
      return ret;
    } 
  }

  public CWorldTimer() : this(NWNXLibPINVOKE.new_CWorldTimer(), true) {
  }

  public void SetSnapshotTime() {
    NWNXLibPINVOKE.CWorldTimer_SetSnapshotTime(swigCPtr);
  }

  public uint GetSnapshotTime() {
    uint ret = NWNXLibPINVOKE.CWorldTimer_GetSnapshotTime(swigCPtr);
    return ret;
  }

  public uint GetSnapshotTimeDifference() {
    uint ret = NWNXLibPINVOKE.CWorldTimer_GetSnapshotTimeDifference(swigCPtr);
    return ret;
  }

  public uint ConvertToCalendarDay(uint nYear, uint nMonth, uint nDay) {
    uint ret = NWNXLibPINVOKE.CWorldTimer_ConvertToCalendarDay(swigCPtr, nYear, nMonth, nDay);
    return ret;
  }

  public uint ConvertToTimeOfDay(uint nHour, uint nMinute, uint nSecond, uint nMillisecond) {
    uint ret = NWNXLibPINVOKE.CWorldTimer_ConvertToTimeOfDay(swigCPtr, nHour, nMinute, nSecond, nMillisecond);
    return ret;
  }

  public void ConvertFromCalendarDay(uint nCalendarDay, uint* nYear, uint* nMonth, uint* nDay) {
    NWNXLibPINVOKE.CWorldTimer_ConvertFromCalendarDay(swigCPtr, nCalendarDay, (global::System.IntPtr)nYear, (global::System.IntPtr)nMonth, (global::System.IntPtr)nDay);
  }

  public void ConvertFromTimeOfDay(uint nTimeOfDay, uint* nHour, uint* nMinute, uint* nSecond, uint* nMillisecond) {
    NWNXLibPINVOKE.CWorldTimer_ConvertFromTimeOfDay(swigCPtr, nTimeOfDay, (global::System.IntPtr)nHour, (global::System.IntPtr)nMinute, (global::System.IntPtr)nSecond, (global::System.IntPtr)nMillisecond);
  }

  public void SetWorldTime(uint nYear, uint nMonth, uint nDay, uint nHour, uint nMinute, uint nSecond, uint nMillisecond, int bTakeSnapshot) {
    NWNXLibPINVOKE.CWorldTimer_SetWorldTime__SWIG_0(swigCPtr, nYear, nMonth, nDay, nHour, nMinute, nSecond, nMillisecond, bTakeSnapshot);
  }

  public void SetWorldTime(uint nYear, uint nMonth, uint nDay, uint nHour, uint nMinute, uint nSecond, uint nMillisecond) {
    NWNXLibPINVOKE.CWorldTimer_SetWorldTime__SWIG_1(swigCPtr, nYear, nMonth, nDay, nHour, nMinute, nSecond, nMillisecond);
  }

  public void SetWorldTime(uint nCalendarDay, uint nTimeOfDay, int bTakeSnapshot) {
    NWNXLibPINVOKE.CWorldTimer_SetWorldTime__SWIG_2(swigCPtr, nCalendarDay, nTimeOfDay, bTakeSnapshot);
  }

  public void SetWorldTime(uint nCalendarDay, uint nTimeOfDay) {
    NWNXLibPINVOKE.CWorldTimer_SetWorldTime__SWIG_3(swigCPtr, nCalendarDay, nTimeOfDay);
  }

  public uint GetTimeDifferenceFromWorldTime(uint nCalendarDay, uint nTimeOfDay) {
    uint ret = NWNXLibPINVOKE.CWorldTimer_GetTimeDifferenceFromWorldTime(swigCPtr, nCalendarDay, nTimeOfDay);
    return ret;
  }

  public uint GetTimeDifference(uint nCalendarDay1, uint nTimeOfDay1, uint nCalendarDay2, uint nTimeOfDay2) {
    uint ret = NWNXLibPINVOKE.CWorldTimer_GetTimeDifference(swigCPtr, nCalendarDay1, nTimeOfDay1, nCalendarDay2, nTimeOfDay2);
    return ret;
  }

  public void GetWorldTime(uint* nCalendarDay, uint* nTimeOfDay) {
    NWNXLibPINVOKE.CWorldTimer_GetWorldTime(swigCPtr, (global::System.IntPtr)nCalendarDay, (global::System.IntPtr)nTimeOfDay);
  }

  public uint AddWorldTimes(uint nCalendarDay1, uint nTimeOfDay1, uint nCalendarDay2, uint nTimeOfDay2, uint* nCalendarDayRes, uint* nTimeOfDayRes) {
    uint ret = NWNXLibPINVOKE.CWorldTimer_AddWorldTimes(swigCPtr, nCalendarDay1, nTimeOfDay1, nCalendarDay2, nTimeOfDay2, (global::System.IntPtr)nCalendarDayRes, (global::System.IntPtr)nTimeOfDayRes);
    return ret;
  }

  public uint SubtractWorldTimes(uint nCalendarDay1, uint nTimeOfDay1, uint nCalendarDay2, uint nTimeOfDay2, uint* nCalendarDayRes, uint* nTimeOfDayRes) {
    uint ret = NWNXLibPINVOKE.CWorldTimer_SubtractWorldTimes(swigCPtr, nCalendarDay1, nTimeOfDay1, nCalendarDay2, nTimeOfDay2, (global::System.IntPtr)nCalendarDayRes, (global::System.IntPtr)nTimeOfDayRes);
    return ret;
  }

  public int CompareWorldTimes(uint nCalendarDay1, uint nTimeOfDay1, uint nCalendarDay2, uint nTimeOfDay2) {
    int ret = NWNXLibPINVOKE.CWorldTimer_CompareWorldTimes(swigCPtr, nCalendarDay1, nTimeOfDay1, nCalendarDay2, nTimeOfDay2);
    return ret;
  }

  public void PauseWorldTimer() {
    NWNXLibPINVOKE.CWorldTimer_PauseWorldTimer(swigCPtr);
  }

  public void UnpauseWorldTimer() {
    NWNXLibPINVOKE.CWorldTimer_UnpauseWorldTimer(swigCPtr);
  }

  public uint GetWorldTimeCalendarDay() {
    uint ret = NWNXLibPINVOKE.CWorldTimer_GetWorldTimeCalendarDay(swigCPtr);
    return ret;
  }

  public CExoString GetWorldTimeCalendarDayString() {
    CExoString ret = new CExoString(NWNXLibPINVOKE.CWorldTimer_GetWorldTimeCalendarDayString(swigCPtr), true);
    return ret;
  }

  public uint GetWorldTimeTimeOfDay() {
    uint ret = NWNXLibPINVOKE.CWorldTimer_GetWorldTimeTimeOfDay(swigCPtr);
    return ret;
  }

  public CExoString GetWorldTimeTimeOfDayString() {
    CExoString ret = new CExoString(NWNXLibPINVOKE.CWorldTimer_GetWorldTimeTimeOfDayString(swigCPtr), true);
    return ret;
  }

  public CExoString TranslateWorldTimeToString(uint nCalendarDay, uint nTimeOfDay, CExoString sTranslatedDayString, CExoString sTranslatedMonthString) {
    CExoString ret = new CExoString(NWNXLibPINVOKE.CWorldTimer_TranslateWorldTimeToString(swigCPtr, nCalendarDay, nTimeOfDay, CExoString.getCPtr(sTranslatedDayString), CExoString.getCPtr(sTranslatedMonthString)), true);
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public uint GetWorldTimeYear() {
    uint ret = NWNXLibPINVOKE.CWorldTimer_GetWorldTimeYear(swigCPtr);
    return ret;
  }

  public uint GetWorldTimeMonth() {
    uint ret = NWNXLibPINVOKE.CWorldTimer_GetWorldTimeMonth(swigCPtr);
    return ret;
  }

  public uint GetWorldTimeDay() {
    uint ret = NWNXLibPINVOKE.CWorldTimer_GetWorldTimeDay(swigCPtr);
    return ret;
  }

  public uint GetWorldTimeHour() {
    uint ret = NWNXLibPINVOKE.CWorldTimer_GetWorldTimeHour(swigCPtr);
    return ret;
  }

  public uint GetWorldTimeMinute() {
    uint ret = NWNXLibPINVOKE.CWorldTimer_GetWorldTimeMinute(swigCPtr);
    return ret;
  }

  public uint GetWorldTimeSecond() {
    uint ret = NWNXLibPINVOKE.CWorldTimer_GetWorldTimeSecond(swigCPtr);
    return ret;
  }

  public uint GetWorldTimeMillisecond() {
    uint ret = NWNXLibPINVOKE.CWorldTimer_GetWorldTimeMillisecond(swigCPtr);
    return ret;
  }

  public void SetFixedSnapshotRate(int bActivate, int nSnapshotsPerSecond) {
    NWNXLibPINVOKE.CWorldTimer_SetFixedSnapshotRate(swigCPtr, bActivate, nSnapshotsPerSecond);
  }

  public uint GetCalendarDayFromSeconds(float fSeconds) {
    uint ret = NWNXLibPINVOKE.CWorldTimer_GetCalendarDayFromSeconds(swigCPtr, fSeconds);
    return ret;
  }

  public uint GetTimeOfDayFromSeconds(float fSeconds) {
    uint ret = NWNXLibPINVOKE.CWorldTimer_GetTimeOfDayFromSeconds(swigCPtr, fSeconds);
    return ret;
  }

  public void ResetTimer(CWorldTimer pTimer) {
    NWNXLibPINVOKE.CWorldTimer_ResetTimer(swigCPtr, CWorldTimer.getCPtr(pTimer));
  }

  public void SetMinutesPerHour(byte nMinutesPerHour) {
    NWNXLibPINVOKE.CWorldTimer_SetMinutesPerHour(swigCPtr, nMinutesPerHour);
  }

  public void AdvanceToTime(int nHour, int nMinute, int nSecond, int nMillisecond) {
    NWNXLibPINVOKE.CWorldTimer_AdvanceToTime(swigCPtr, nHour, nMinute, nSecond, nMillisecond);
  }

}

}

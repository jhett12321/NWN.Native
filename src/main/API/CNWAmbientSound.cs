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

public unsafe class CNWAmbientSound : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  public CNWAmbientSound(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  public CNWAmbientSound(void* cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, (global::System.IntPtr)cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(CNWAmbientSound obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~CNWAmbientSound() {
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
          NWNXLibPINVOKE.delete_CNWAmbientSound(swigCPtr);
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

  public static unsafe implicit operator void*(CNWAmbientSound self) {
    return (void*)self.swigCPtr.Handle;
  }

  public static implicit operator global::System.IntPtr(CNWAmbientSound self) {
    return self.swigCPtr.Handle;
  }

  public bool Equals(CNWAmbientSound other) {
    if (ReferenceEquals(null, other)) {
      return false;
    }

    if (ReferenceEquals(this, other)) {
      return true;
    }

    return Pointer.Equals(other.Pointer);
  }

  public override bool Equals(object obj) {
    return ReferenceEquals(this, obj) || obj is CNWAmbientSound other && Equals(other);
  }

  public override int GetHashCode() {
    return swigCPtr.Handle.GetHashCode();
  }

  public static bool operator ==(CNWAmbientSound left, CNWAmbientSound right) {
    return Equals(left, right);
  }

  public static bool operator !=(CNWAmbientSound left, CNWAmbientSound right) {
    return !Equals(left, right);
  }

  public int m_bMusicPlaying {
    set {
      NWNXLibPINVOKE.CNWAmbientSound_m_bMusicPlaying_set(swigCPtr, value);
    } 
    get {
      int ret = NWNXLibPINVOKE.CNWAmbientSound_m_bMusicPlaying_get(swigCPtr);
      return ret;
    } 
  }

  public int m_nMusicDelay {
    set {
      NWNXLibPINVOKE.CNWAmbientSound_m_nMusicDelay_set(swigCPtr, value);
    } 
    get {
      int ret = NWNXLibPINVOKE.CNWAmbientSound_m_nMusicDelay_get(swigCPtr);
      return ret;
    } 
  }

  public int m_nMusicDayTrack {
    set {
      NWNXLibPINVOKE.CNWAmbientSound_m_nMusicDayTrack_set(swigCPtr, value);
    } 
    get {
      int ret = NWNXLibPINVOKE.CNWAmbientSound_m_nMusicDayTrack_get(swigCPtr);
      return ret;
    } 
  }

  public int m_nMusicNightTrack {
    set {
      NWNXLibPINVOKE.CNWAmbientSound_m_nMusicNightTrack_set(swigCPtr, value);
    } 
    get {
      int ret = NWNXLibPINVOKE.CNWAmbientSound_m_nMusicNightTrack_get(swigCPtr);
      return ret;
    } 
  }

  public int m_bBattlePlaying {
    set {
      NWNXLibPINVOKE.CNWAmbientSound_m_bBattlePlaying_set(swigCPtr, value);
    } 
    get {
      int ret = NWNXLibPINVOKE.CNWAmbientSound_m_bBattlePlaying_get(swigCPtr);
      return ret;
    } 
  }

  public int m_nBattleTrack {
    set {
      NWNXLibPINVOKE.CNWAmbientSound_m_nBattleTrack_set(swigCPtr, value);
    } 
    get {
      int ret = NWNXLibPINVOKE.CNWAmbientSound_m_nBattleTrack_get(swigCPtr);
      return ret;
    } 
  }

  public int m_bSoundPlaying {
    set {
      NWNXLibPINVOKE.CNWAmbientSound_m_bSoundPlaying_set(swigCPtr, value);
    } 
    get {
      int ret = NWNXLibPINVOKE.CNWAmbientSound_m_bSoundPlaying_get(swigCPtr);
      return ret;
    } 
  }

  public int m_nSoundDayTrack {
    set {
      NWNXLibPINVOKE.CNWAmbientSound_m_nSoundDayTrack_set(swigCPtr, value);
    } 
    get {
      int ret = NWNXLibPINVOKE.CNWAmbientSound_m_nSoundDayTrack_get(swigCPtr);
      return ret;
    } 
  }

  public int m_nSoundNightTrack {
    set {
      NWNXLibPINVOKE.CNWAmbientSound_m_nSoundNightTrack_set(swigCPtr, value);
    } 
    get {
      int ret = NWNXLibPINVOKE.CNWAmbientSound_m_nSoundNightTrack_get(swigCPtr);
      return ret;
    } 
  }

  public byte m_nDayVolume {
    set {
      NWNXLibPINVOKE.CNWAmbientSound_m_nDayVolume_set(swigCPtr, value);
    } 
    get {
      byte ret = NWNXLibPINVOKE.CNWAmbientSound_m_nDayVolume_get(swigCPtr);
      return ret;
    } 
  }

  public byte m_nNightVolume {
    set {
      NWNXLibPINVOKE.CNWAmbientSound_m_nNightVolume_set(swigCPtr, value);
    } 
    get {
      byte ret = NWNXLibPINVOKE.CNWAmbientSound_m_nNightVolume_get(swigCPtr);
      return ret;
    } 
  }

  public virtual void PlayMusic(int bPlay) {
    NWNXLibPINVOKE.CNWAmbientSound_PlayMusic(swigCPtr, bPlay);
  }

  public virtual void SetMusicDelay(int nDelay) {
    NWNXLibPINVOKE.CNWAmbientSound_SetMusicDelay(swigCPtr, nDelay);
  }

  public virtual void SetMusicDayTrack(int nTrack) {
    NWNXLibPINVOKE.CNWAmbientSound_SetMusicDayTrack(swigCPtr, nTrack);
  }

  public virtual void SetMusicNightTrack(int nTrack) {
    NWNXLibPINVOKE.CNWAmbientSound_SetMusicNightTrack(swigCPtr, nTrack);
  }

  public virtual void PlayBattleMusic(int bPlay) {
    NWNXLibPINVOKE.CNWAmbientSound_PlayBattleMusic(swigCPtr, bPlay);
  }

  public virtual void SetBattleMusicTrack(int nTrack) {
    NWNXLibPINVOKE.CNWAmbientSound_SetBattleMusicTrack(swigCPtr, nTrack);
  }

  public virtual void PlayAmbientSound(int bPlay) {
    NWNXLibPINVOKE.CNWAmbientSound_PlayAmbientSound(swigCPtr, bPlay);
  }

  public virtual void SetAmbientDayTrack(int nTrack) {
    NWNXLibPINVOKE.CNWAmbientSound_SetAmbientDayTrack(swigCPtr, nTrack);
  }

  public virtual void SetAmbientNightTrack(int nTrack) {
    NWNXLibPINVOKE.CNWAmbientSound_SetAmbientNightTrack(swigCPtr, nTrack);
  }

}

}

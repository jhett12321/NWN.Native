//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 4.0.1
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------

namespace NWN.Native.API {

public interface ICNWItem {
  [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
  global::System.Runtime.InteropServices.HandleRef GetInterfaceCPtr();
  public byte[] m_nLayeredTextureColors { set; get; }
  public unsafe byte*[] m_pLayeredTextureColorsPerPart { set; get; }
  public uint m_nBaseItem  { set; get; }
  byte GetLayeredTextureColorPerPart(byte nTexture, byte nPart);
  void SetLayeredTextureColorPerPart(byte nTexture, byte nPart, byte nColor);
}

}
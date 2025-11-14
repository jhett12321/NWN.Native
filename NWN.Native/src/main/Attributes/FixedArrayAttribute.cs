using System;

namespace NWN.Native.Attributes;

[AttributeUsage(AttributeTargets.Field)]
public class FixedArrayAttribute(int size) : Attribute
{
  public int Size { get; } = size;
}

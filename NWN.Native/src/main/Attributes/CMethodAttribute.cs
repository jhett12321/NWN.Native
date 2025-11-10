using System;

namespace NWN.Native.Attributes;

[AttributeUsage(AttributeTargets.Method)]
public class CMethodAttribute(string entryPoint) : Attribute
{
  public string EntryPoint { get; } = entryPoint;
}

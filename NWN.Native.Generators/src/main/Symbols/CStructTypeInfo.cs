using System.Collections.Generic;
using Microsoft.CodeAnalysis;

namespace NWN.Native.Generators.Symbols;

internal sealed record CStructTypeInfo
{
  public INamedTypeSymbol Type { get; }

  public string Name { get; }

  public List<CMethodInfo> Methods { get; } = [];

  public CStructTypeInfo(INamedTypeSymbol type)
  {
    Type = type;
    Name = type.Name;

    foreach (ISymbol symbol in type.GetMembers())
    {
      switch (symbol)
      {
        case IMethodSymbol methodSymbol:
          Methods.Add(new CMethodInfo(methodSymbol));
          break;
      }
    }
  }
}

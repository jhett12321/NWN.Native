using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using Microsoft.CodeAnalysis;

namespace NWN.Native.Generators.Symbols;

internal sealed class CMethodInfo
{
  private const string MethodNameAttributeClassName = "CMethodAttribute";

  public IMethodSymbol Method { get; }

  public bool IsStatic { get; }

  public string Accessibility { get; }

  public string ReturnType { get; }

  public string Name { get; }

  public List<string> Parameters { get; }

  public List<string> ParameterNames { get; }

  public string? EntryPoint { get; }

  public CMethodInfo(IMethodSymbol method)
  {
    Method = method;
    IsStatic = method.IsStatic;
    Accessibility = GetAccessibility();
    Name = method.Name;
    ReturnType = method.ReturnType.ToString();
    EntryPoint = GetEntryPoint();
    Parameters = method.Parameters.Select(param => $"{param}").ToList();
    ParameterNames = method.Parameters.Select(param => param.Name).ToList();
  }

  private string? GetEntryPoint()
  {
    ImmutableArray<AttributeData> attributes = Method.GetAttributes();
    foreach (AttributeData attribute in attributes)
    {
      string? attributeType = attribute.AttributeClass?.Name;
      if (attributeType != MethodNameAttributeClassName)
      {
        continue;
      }

      string? entryPoint = attribute.ConstructorArguments[0].Value?.ToString();
      if (entryPoint != null)
      {
        return entryPoint;
      }
    }

    return null;
  }

  private string GetAccessibility()
  {
    return Method.DeclaredAccessibility switch
    {
      Microsoft.CodeAnalysis.Accessibility.Private => "private",
      Microsoft.CodeAnalysis.Accessibility.Protected => "protected",
      Microsoft.CodeAnalysis.Accessibility.Internal => "internal",
      Microsoft.CodeAnalysis.Accessibility.ProtectedOrInternal => "protected internal",
      Microsoft.CodeAnalysis.Accessibility.Public => "public",
      Microsoft.CodeAnalysis.Accessibility.ProtectedAndInternal => "protected internal",
      Microsoft.CodeAnalysis.Accessibility.NotApplicable => "internal",
      _ => throw new ArgumentOutOfRangeException()
    };
  }
}

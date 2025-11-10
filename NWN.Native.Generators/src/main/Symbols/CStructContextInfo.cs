using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using NWN.Native.Generators.Extensions;

namespace NWN.Native.Generators.Symbols;

internal sealed record CStructContextInfo
{
  public StructDeclarationSyntax Context { get; }

  public List<SyntaxNode> Parents { get; }

  public string GeneratedFileName { get; }

  public CStructContextInfo(StructDeclarationSyntax Context)
  {
    this.Context = Context;

    Parents = Context.GetParentNodes();
    GeneratedFileName = GetGeneratedFileName();
  }

  private string GetGeneratedFileName()
  {
    StringBuilder stringBuilder = new();
    foreach (SyntaxNode node in Parents)
    {
      switch (node)
      {
        case BaseNamespaceDeclarationSyntax namespaceDeclaration:
          stringBuilder.Append(namespaceDeclaration.Name);
          stringBuilder.Append('.');
          break;
        case TypeDeclarationSyntax typeDeclaration:
          stringBuilder.Append(typeDeclaration.Identifier.Text);
          stringBuilder.Append('.');
          break;
        default:
          throw new Exception($"Unexpected SyntaxNode {node.GetType().FullName}");
      }
    }

    stringBuilder.Append(Context.Identifier.Text);
    stringBuilder.Append(".g.cs");
    return stringBuilder.ToString();
  }
}

using System.Collections.Generic;
using System.Linq;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace NWN.Native.Generators.Extensions;

internal static class TypeSymbolExtensions
{
  public static string GetDeclarationString(this BaseNamespaceDeclarationSyntax namespaceDeclarationSyntax)
  {
    return $"namespace {namespaceDeclarationSyntax.Name}";
  }

  public static string GetDeclarationString(this TypeDeclarationSyntax typeDeclarationSyntax, params string[] additionalImplementingTypes)
  {
    if (additionalImplementingTypes.Length > 0)
    {
      return $"{typeDeclarationSyntax.Modifiers.ToString()} {typeDeclarationSyntax.Keyword} {typeDeclarationSyntax.Identifier.Text} : {string.Join(", ", additionalImplementingTypes)}";
    }

    return $"{typeDeclarationSyntax.Modifiers.ToString()} {typeDeclarationSyntax.Keyword} {typeDeclarationSyntax.Identifier.Text}";
  }

  public static List<SyntaxNode> GetParentNodes(this SyntaxNode syntaxNode)
  {
    List<SyntaxNode> parentNodes = [];
    SyntaxNode? parent = syntaxNode.Parent;

    while (parent != null)
    {
      if (parent is not CompilationUnitSyntax)
      {
        parentNodes.Add(parent);
      }

      parent = parent.Parent;
    }

    parentNodes.Reverse();
    return parentNodes;
  }
}

using Microsoft.CodeAnalysis;

namespace NWN.Native.Generators.Diagnostics;

internal static class DiagnosticConstants
{
  public static readonly DiagnosticDescriptor UnknownSyntaxNode = new(
    "CNW001",
    "Unknown syntax node",
    "This source generator does not support {0} nodes and this class cannot be generated",
    "syntax",
    DiagnosticSeverity.Error,
    true);

  public static readonly DiagnosticDescriptor StructNotPartial = new(
    "CNW002",
    "Struct not partial",
    "CStruct generated type must be partial",
    "syntax",
    DiagnosticSeverity.Error,
    true);

  public static readonly DiagnosticDescriptor MethodNotPartial = new(
    "CNW003",
    "Method not partial",
    "CStruct generated method must be partial",
    "syntax",
    DiagnosticSeverity.Error,
    true);
}

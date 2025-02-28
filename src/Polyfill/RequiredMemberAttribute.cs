#if !NET7_0_OR_GREATER

// ReSharper disable RedundantUsingDirective

using System.Diagnostics.CodeAnalysis;
using System.Diagnostics;

namespace System.Runtime.CompilerServices;

using Targets = AttributeTargets;

/// <summary>
/// Specifies that a type has required members or that a member is required.
/// </summary>
[ExcludeFromCodeCoverage]
[DebuggerNonUserCode]
[AttributeUsage(
    Targets.Class | Targets.Struct | Targets.Field | Targets.Property,
    Inherited = false)]
sealed class RequiredMemberAttribute : Attribute
{ }

#endif
#if !NET5_0_OR_GREATER

// ReSharper disable RedundantUsingDirective

using System.Diagnostics.CodeAnalysis;
using System.Diagnostics;

namespace System.Runtime.CompilerServices;

/// <summary>
/// Reserved to be used by the compiler for tracking metadata. This class should not be used by developers in source code.
/// </summary>
[ExcludeFromCodeCoverage]
[DebuggerNonUserCode]
static class IsExternalInit
{
}

#endif
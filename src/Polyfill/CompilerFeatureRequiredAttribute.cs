#if !NET7_0_OR_GREATER

// ReSharper disable RedundantUsingDirective

using System.Diagnostics.CodeAnalysis;
using System.Diagnostics;

namespace System.Runtime.CompilerServices;

/// <summary>
/// Indicates that compiler support for a particular feature is required for the location where this attribute is applied.
/// </summary>
[ExcludeFromCodeCoverage]
[DebuggerNonUserCode]
[AttributeUsage(
    AttributeTargets.All,
    AllowMultiple = true,
    Inherited = false)]
public sealed class CompilerFeatureRequiredAttribute : Attribute
{
    /// <summary>
    /// Initialize a new instance of <see cref="CompilerFeatureRequiredAttribute"/>
    /// </summary>
    public CompilerFeatureRequiredAttribute(string featureName) =>
        FeatureName = featureName;

    /// <summary>
    /// The name of the compiler feature.
    /// </summary>
    public string FeatureName { get; }

    /// <summary>
    /// If true, the compiler can choose to allow access to the location where this attribute is applied if it does not understand <see cref="FeatureName"/>.
    /// </summary>
    public bool IsOptional { get; init; }

    /// <summary>
    /// The <see cref="FeatureName"/> used for the ref structs C# feature.
    /// </summary>
    public const string RefStructs = nameof(RefStructs);

    /// <summary>
    /// The <see cref="FeatureName"/> used for the required members C# feature.
    /// </summary>
    public const string RequiredMembers = nameof(RequiredMembers);
}

#endif
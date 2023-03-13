#if(NETSTANDARD2_0 || NETFRAMEWORK || NETCOREAPP2_1 || NETCOREAPP2_0)

namespace System.Diagnostics.CodeAnalysis;

/// <summary>
///     Specifies that when a method returns <see cref="ReturnValue"/>,
///     the parameter will not be <see langword="null"/> even if the corresponding type allows it.
/// </summary>
[AttributeUsage(AttributeTargets.Parameter, Inherited = false)]
#if(PublicPolyfill)
public
#endif
sealed class NotNullWhenAttribute : Attribute
{
    /// <summary>
    ///     Gets the return value condition.
    ///     If the method returns this value, the associated parameter will not be <see langword="null"/>.
    /// </summary>
    public bool ReturnValue { get; }

    /// <summary>
    ///     Initializes the attribute with the specified return value condition.
    /// </summary>
    /// <param name="returnValue">
    ///     The return value condition.
    ///     If the method returns this value, the associated parameter will not be <see langword="null"/>.
    /// </param>
    public NotNullWhenAttribute(bool returnValue) =>
        ReturnValue = returnValue;
}
#endif
using System;

namespace MercanteDiVenezia.ExtensionsAndHelpers
{
    [ExcludeFromCoverage]
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Method | AttributeTargets.Property)]
    public class ExcludeFromCoverageAttribute : Attribute { }
}

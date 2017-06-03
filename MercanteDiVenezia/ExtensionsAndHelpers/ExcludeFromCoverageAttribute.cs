using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MercanteDiVenezia.ExtensionsAndHelpers
{
    [ExcludeFromCoverage]
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Method | AttributeTargets.Property)]
    public class ExcludeFromCoverageAttribute : Attribute { }
}

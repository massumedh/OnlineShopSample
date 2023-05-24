using System.Collections.Generic;
using System.Reflection;
using Xunit.Sdk;

namespace OnlineShopSample.Tests.Unit.Infrastructures.DummyData
{
    public class IntInvalidId : DataAttribute
    {
        public override IEnumerable<object[]> GetData(MethodInfo testMethod)
        {
            return new[] { new object[] { -1 } };
        }
    }
}
using System.Collections.Generic;
using System.Reflection;
using Xunit.Sdk;

namespace OnlineShopSample.Tests.Unit.Infrastructures.DummyData
{
    public class DummyString : DataAttribute
    {
        public override IEnumerable<object[]> GetData(MethodInfo testMethod)
        {
            return new[] { new object[] { "dummy_string" } };
        }
    }
}
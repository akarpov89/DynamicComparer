using NUnit.Framework;

namespace DynamicComparer.Test
{
    [TestFixture]
    public class ReflectionComparerTestSuit
    {
        private readonly ReflectionComparer _comparer = new ReflectionComparer();

        [TestCaseSource(typeof(TestCasesProvider), nameof(TestCasesProvider.TestCases))]
        public bool TestEquals(object x, object y)
        {
            return _comparer.Equals(x, y);
        }
    }
}
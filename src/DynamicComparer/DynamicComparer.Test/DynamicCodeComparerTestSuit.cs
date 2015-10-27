using NUnit.Framework;

namespace DynamicComparer.Test
{
    [TestFixture]
    public class DynamicCodeComparerTestSuit
    {
        private readonly DynamicCodeComparer _comparer = new DynamicCodeComparer();

        [TestCaseSource(typeof(TestCasesProvider), nameof(TestCasesProvider.TestCases))]
        public bool TestEquals(object x, object y)
        {
            return _comparer.Equals(x, y);
        }
    }
}

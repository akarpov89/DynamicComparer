using System;
using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;

namespace DynamicComparer.Test
{
    public class TestCasesProvider
    {
        private static TestCaseData Case(object x, object y, bool expected) 
            => new TestCaseData(x, y).Returns(expected).SetName($"({x}, {y})");

        public static IEnumerable TestCases
        {
            get
            {
                yield return Case(0, 0, true);
                yield return Case(0, 1, false);
                yield return Case(int.MaxValue, int.MaxValue, true);
                yield return Case(0.5, 0.5, true);
                yield return Case(42.0, 37.5, false);
                yield return Case(0.999, 0.999, true);
                yield return Case(0.999, 0.998, false);
                yield return Case(double.NaN, double.NaN, true);
                yield return Case(double.NaN, 0.5, false);
                yield return Case(0.5f, 0.5f, true);
                yield return Case(42.0f, 37.5f, false);
                yield return Case(0.999f, 0.999f, true);
                yield return Case(0.999f, 0.998f, false);
                yield return Case(float.NaN, float.NaN, true);
                yield return Case(float.NaN, 0.5f, false);
                yield return Case(null, null, true);
                yield return Case((int?) 1, (int?) 1, true);
                yield return Case((int?) 1, null, false);
                yield return Case((double?) 0.5, (double?) 0.5, true);
                yield return Case(new IntPtr(1), new IntPtr(1), true);
                yield return Case(new IntPtr(1), new IntPtr(2), false);
                yield return Case("text", "text", true);
                yield return Case("text", null, false);
                yield return Case("text", "text1", false);
                yield return Case(E.A, E.A, true);
                yield return Case(E.A, E.B, false);
                yield return Case(new DateTime(2016, 1, 19), new DateTime(2016, 1, 19), true);
                yield return Case(new DateTime(2016, 1, 19), new DateTime(2016, 1, 20), false);
                yield return Case(Primitive.Create(), Primitive.Create(), true);
                yield return Case(Primitive.Create(), Primitive.Create().WithNaNs(), false);
                yield return Case(new S(42, "42"), new S(42, "42"), true);
                yield return Case(new S(42, "42"), new S(42, "222"), false);
                yield return Case(new S(42, "42"), new S(412, "42"), false);
                yield return Case(new[] {1, 2, 3}, new[] {1, 2, 3}, true);
                yield return Case(new[] {1, 2, 3}, new[] {1, 2, 4}, false);
                yield return Case(new[] {"1", "2", "3"}, new[] {"1", "2", "3"}, true);
                yield return Case(new[] { "1", "2", "3" }, new[] { "1", "2", "3", "4" }, false);
                yield return Case(new[] { "1", "2", "3" }, new[] { "1", "2", "5" }, false);
                yield return Case(new[] { "1", "2", "3" }, new[] { "1", "2", "6" }, false);
                yield return Case(new[] { "1", "2", "3" }, new[] { "2", "3", "1" }, false);
                yield return Case(new List<int> {1, 2, 3}, new List<int> {1, 2, 3}, true);
                yield return Case(new List<int> { 1, 2, 3 }, new List<int> { 1, 2, 4 }, false);
                yield return Case(new List<int> { 1, 2, 3 }, new List<int> { 1, 2, 3, 5 }, false);
                yield return Case(
                    new X
                    {
                        A = Primitive.Create(),
                        B = new S(42, "42"),
                        C = new[] {1, 2, 3},
                        D = new List<int> {1, 2, 3},
                        E = new DateTime(2016, 1, 19)
                    },
                    new X
                    {
                        A = Primitive.Create(),
                        B = new S(42, "42"),
                        C = new[] {1, 2, 3},
                        D = new List<int> {1, 2, 3},
                        E = new DateTime(2016, 1, 19)
                    },
                    true);
                yield return Case(
                    new X
                    {
                        A = Primitive.Create(),
                        B = new S(42, "42"),
                        C = new[] { 1, 2, 3 },
                        D = new List<int> { 1, 2, 3 },
                        E = new DateTime(2016, 1, 19)
                    },
                    new X
                    {
                        A = Primitive.Create(),
                        B = new S(42, "42"),
                        C = new[] { 1, 2, 3 },
                        D = new List<int> { 1, 2, 3 },
                        E = new DateTime(2016, 1, 20)
                    },
                    false);
            }
        } 
    }
}
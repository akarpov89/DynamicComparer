using System;
using System.Collections.Generic;
using System.Linq;
using BenchmarkDotNet;
using BenchmarkDotNet.Logging;
using BenchmarkDotNet.Tasks;

namespace DynamicComparer.Benchmark
{
    public struct Struct
    {
        public int A;
        public double B;
        public string C;

        public Struct(int a, double b, string c)
        {
            A = a;
            B = b;
            C = c;
        }
    }

    public class SimpleClass
    {
        public int A { get; set; }
        public Struct B { get; set; }
    }

    public class ComplexClass
    {
        public int A { get; set; }
        public IntPtr B { get; set; }
        public UIntPtr C { get; set; }
        public string D { get; set; }
        public SimpleClass E { get; set; }
        public int? F { get; set; }
        public int[] G { get; set; }
        public List<int> H { get; set; }
        public double I { get; set; }
        public float J { get; set; }
    }



    [BenchmarkTask(platform: BenchmarkPlatform.X86, jitVersion: BenchmarkJitVersion.LegacyJit)]
    [BenchmarkTask(platform: BenchmarkPlatform.X64, jitVersion: BenchmarkJitVersion.LegacyJit)]
    [BenchmarkTask(platform: BenchmarkPlatform.X64, jitVersion: BenchmarkJitVersion.RyuJit)]
    public class ComplexComparisonTest
    {
        private static int[] MakeArray(int count)
        {
            var array = new int[count];

            for (int i = 0; i < array.Length; ++i)
                array[i] = i;

            return array;
        }

        private static List<int> MakeList(int count)
        {
            var list = new List<int>(count);

            for (int i = 0; i < list.Count; ++i)
                list.Add(i);

            return list;
        }

        private ComplexClass x = new ComplexClass
        {
            A = 2,
            B = new IntPtr(2),
            C = new UIntPtr(2),
            D = "Habrahabr!",
            E = new SimpleClass { A = 42, B = new Struct(42, 3.14, "meow") },
            F = 1,
            G = MakeArray(100),
            H = MakeList(100),
            I = double.MaxValue,
            J = float.MaxValue
        };

        private ComplexClass y = new ComplexClass
        {
            A = 2,
            B = new IntPtr(2),
            C = new UIntPtr(2),
            D = "Habrahabr!",
            E = new SimpleClass { A = 42, B = new Struct(42, 3.14, "meow") },
            F = 1,
            G = MakeArray(100),
            H = MakeList(100),
            I = double.MaxValue,
            J = float.MaxValue
        };

        private ReflectionComparer comparer = new ReflectionComparer();

        [Benchmark]
        public void ReflectionCompare()
        {
            var _ = comparer.Equals(x, y);
        }

        [Benchmark]
        public void ManualCompare()
        {
            if (x == y) return;
            if (x.A != y.A) return;
            if (x.B != y.B) return;
            if (x.C != y.C) return;
            if (x.D != y.D) return;
            if (x.E != y.E)
            {
                if (x.E.A != y.E.A) return;
                var s1 = x.E.B;
                var s2 = y.E.B;
                if (s1.A != s2.A) return;
                if (!s1.B.Equals(s2.B)) return;
                if (s1.C != s2.C) return;
            }
            if (x.F != y.F) return;
            if (x.G != y.G)
            {
                if (x.G?.Length != y.G?.Length) return;
                int[] a = x.G, b = y.G;
                for (int i = 0; i < a.Length; ++i)
                {
                    if (a[i] != b[i]) return;
                }
            }
            if (x.H != y.H)
            {
                if (!x.H.SequenceEqual(y.H)) return;
            }
            if (!x.I.Equals(y.I)) return;
            if (!x.J.Equals(y.J)) return;
        }
    }

    [BenchmarkTask(platform: BenchmarkPlatform.X86, jitVersion: BenchmarkJitVersion.LegacyJit)]
    [BenchmarkTask(platform: BenchmarkPlatform.X64, jitVersion: BenchmarkJitVersion.LegacyJit)]
    [BenchmarkTask(platform: BenchmarkPlatform.X64, jitVersion: BenchmarkJitVersion.RyuJit)]
    public class SimpleComparisonTest
    {
        private SimpleClass x = new SimpleClass { A = 42, B = new Struct(42, 3.14, "meow") };
        private SimpleClass y = new SimpleClass { A = 42, B = new Struct(42, 3.14, "meow") };

        private ReflectionComparer comparer = new ReflectionComparer();

        [Benchmark]
        public void ReflectionCompare()
        {
            var _ = comparer.Equals(x, y);
        }

        [Benchmark]
        public void ManualCompare()
        {
            if (x == y) return;
            if (x.A != y.A) return;
            var s1 = x.B;
            var s2 = y.B;
            if (s1.A != s2.A) return;
            if (!s1.B.Equals(s2.B)) return;
            if (s1.C != s2.C) return;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            IBenchmarkLogger[] loggers = 
            {
                new BenchmarkConsoleLogger(),
                new BenchmarkStreamLogger("reflection_vs_manual_simple.md")
            };
            var runner = new BenchmarkRunner(loggers);
            var reports = runner.RunCompetition(new SimpleComparisonTest()).ToList();
            runner.ReportExporter.Export(reports, runner.Logger);
        }
    }
}

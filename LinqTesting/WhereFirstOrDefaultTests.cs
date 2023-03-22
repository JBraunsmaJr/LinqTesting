using System.Linq;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Jobs;

namespace LinqTesting
{
    [SimpleJob(RuntimeMoniker.Net48)]
    [SimpleJob(RuntimeMoniker.Net70)]
    public class WhereFirstOrDefaultTests
    {
        [Benchmark]
        public int GreaterThan() => Shared.Array.Where(x => x > Shared.Search).FirstOrDefault();

        [Benchmark]
        public int LessThan() => Shared.Array.Where(x => x < Shared.Search).FirstOrDefault();

        [Benchmark]
        public int Equals() => Shared.Array.Where(x => x == Shared.Search).FirstOrDefault();

        [Benchmark]
        public int NotEqual() => Shared.Array.Where(x => x != Shared.Search).FirstOrDefault();

        [Benchmark]
        public int GreaterEqual() => Shared.Array.Where(x => x >= Shared.Search).FirstOrDefault();

        [Benchmark]
        public int LessEqual() => Shared.Array.Where(x => x <= Shared.Search).FirstOrDefault();
    }
}
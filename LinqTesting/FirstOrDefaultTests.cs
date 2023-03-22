using System.Linq;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Jobs;

namespace LinqTesting
{
    [SimpleJob(RuntimeMoniker.Net48)]
    [SimpleJob(RuntimeMoniker.Net70)]
    public class FirstOrDefaultTests
    {
        [Benchmark]
        public int GreaterThan() => Shared.Array.FirstOrDefault(x => x > Shared.Search);

        [Benchmark]
        public int LessThan() => Shared.Array.FirstOrDefault(x => x < Shared.Search);

        [Benchmark]
        public int Equals() => Shared.Array.FirstOrDefault(x => x == Shared.Search);

        [Benchmark]
        public int NotEqual() => Shared.Array.FirstOrDefault(x => x != Shared.Search);

        [Benchmark]
        public int GreaterEqual() => Shared.Array.FirstOrDefault(x => x >= Shared.Search);

        [Benchmark]
        public int LessEqual() => Shared.Array.FirstOrDefault(x => x <= Shared.Search);
    }
}
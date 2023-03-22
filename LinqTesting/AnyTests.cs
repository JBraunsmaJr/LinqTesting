using System.Linq;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Jobs;

namespace LinqTesting
{
    [SimpleJob(RuntimeMoniker.Net48)]
    [SimpleJob(RuntimeMoniker.Net70)]
    public class AnyTests
    {
        [Benchmark]
        public bool GreaterThan() => Shared.Array.Any(x => x > Shared.Search);

        [Benchmark]
        public bool LessThan() => Shared.Array.Any(x => x < Shared.Search);

        [Benchmark]
        public bool Equals() => Shared.Array.Any(x => x == Shared.Search);

        [Benchmark]
        public bool NotEqual() => Shared.Array.Any(x => x != Shared.Search);

        [Benchmark]
        public bool GreaterEqual() => Shared.Array.Any(x => x >= Shared.Search);

        [Benchmark]
        public bool LessEqual() => Shared.Array.Any(x => x <= Shared.Search);   
    }
}
using System.Linq;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Jobs;

namespace LinqTesting
{
    [SimpleJob(RuntimeMoniker.Net48)]
    [SimpleJob(RuntimeMoniker.Net70)]
    public class WhereAnyTests
    {
       
        [Benchmark]
        public bool GreaterThan() => Shared.Array.Where(x => x > Shared.Search).Any();

        [Benchmark]
        public bool LessThan() => Shared.Array.Where(x => x < Shared.Search).Any();

        [Benchmark]
        public bool Equals() => Shared.Array.Where(x => x == Shared.Search).Any();

        [Benchmark]
        public bool NotEqual() => Shared.Array.Where(x => x != Shared.Search).Any();

        [Benchmark]
        public bool GreaterEqual() => Shared.Array.Where(x => x >= Shared.Search).Any();

        [Benchmark]
        public bool LessEqual() => Shared.Array.Where(x => x <= Shared.Search).Any();
    }
}
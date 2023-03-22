using System.Linq;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Jobs;

namespace LinqTesting
{
    [SimpleJob(RuntimeMoniker.Net48)]
    [SimpleJob(RuntimeMoniker.Net70)]
    public class WhereAnyTests
    {
        private readonly int[] array = { 399, 895, 319, 946, 339, 948, 807, 520, 643, 312 };

        private int search = 895;
        
        [Benchmark]
        public bool GreaterThan() => array.Where(x => x > search).Any();

        [Benchmark]
        public bool LessThan() => array.Where(x => x < search).Any();

        [Benchmark]
        public bool Equals() => array.Where(x => x == search).Any();

        [Benchmark]
        public bool NotEqual() => array.Where(x => x != search).Any();

        [Benchmark]
        public bool GreaterEqual() => array.Where(x => x >= search).Any();

        [Benchmark]
        public bool LessEqual() => array.Where(x => x <= search).Any();
    }
}
using System.Linq;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Jobs;

namespace LinqTesting
{
    [SimpleJob(RuntimeMoniker.Net48)]
    [SimpleJob(RuntimeMoniker.Net70)]
    public class AnyTests
    {
        private readonly int[] array = { 399, 895, 319, 946, 339, 948, 807, 520, 643, 312 };

        private int search = 895;
        
        [Benchmark]
        public bool GreaterThan() => array.Any(x => x > search);

        [Benchmark]
        public bool LessThan() => array.Any(x => x < search);

        [Benchmark]
        public bool Equals() => array.Any(x => x == search);

        [Benchmark]
        public bool NotEqual() => array.Any(x => x != search);

        [Benchmark]
        public bool GreaterEqual() => array.Any(x => x >= search);

        [Benchmark]
        public bool LessEqual() => array.Any(x => x <= search);   
    }
}
using System.Linq;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Jobs;

namespace LinqTesting
{
    [SimpleJob(RuntimeMoniker.Net48)]
    [SimpleJob(RuntimeMoniker.Net70)]
    public class FirstOrDefaultTests
    {
        private readonly int[] array = { 399, 895, 319, 946, 339, 948, 807, 520, 643, 312 };

        private int search = 895;

        [Benchmark]
        public int GreaterThan() => array.FirstOrDefault(x => x > search);

        [Benchmark]
        public int LessThan() => array.FirstOrDefault(x => x < search);

        [Benchmark]
        public int Equals() => array.FirstOrDefault(x => x == search);

        [Benchmark]
        public int NotEqual() => array.FirstOrDefault(x => x != search);

        [Benchmark]
        public int GreaterEqual() => array.FirstOrDefault(x => x >= search);

        [Benchmark]
        public int LessEqual() => array.FirstOrDefault(x => x <= search);
    }
}
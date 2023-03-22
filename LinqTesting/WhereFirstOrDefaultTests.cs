using System.Linq;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Jobs;

namespace LinqTesting
{
    [SimpleJob(RuntimeMoniker.Net48)]
    [SimpleJob(RuntimeMoniker.Net70)]
    public class WhereFirstOrDefaultTests
    {
        private readonly int[] array = { 399, 895, 319, 946, 339, 948, 807, 520, 643, 312 };

        private int search = 895;

        [Benchmark]
        public int GreaterThan() => array.Where(x => x > search).FirstOrDefault();

        [Benchmark]
        public int LessThan() => array.Where(x => x < search).FirstOrDefault();

        [Benchmark]
        public int Equals() => array.Where(x => x == search).FirstOrDefault();

        [Benchmark]
        public int NotEqual() => array.Where(x => x != search).FirstOrDefault();

        [Benchmark]
        public int GreaterEqual() => array.Where(x => x >= search).FirstOrDefault();

        [Benchmark]
        public int LessEqual() => array.Where(x => x <= search).FirstOrDefault();
    }
}
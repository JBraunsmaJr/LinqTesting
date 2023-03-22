using System.Collections.Generic;
using System.Linq;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Jobs;

namespace LinqTesting
{
    [SimpleJob(RuntimeMoniker.Net48)]
    [SimpleJob(RuntimeMoniker.Net70)]
    public class ManualTests
    {
        private readonly int[] array = { 399, 895, 319, 946, 339, 948, 807, 520, 643, 312 };

        private int search = 895;
        
        [GlobalSetup]
        public void Setup()
        {
        }

        [Benchmark]
        public bool GreaterThan()
        {
            foreach(var value in array)
                if (value > search)
                    return true;
            return false;
        }

        [Benchmark]
        public bool LessThan()
        {
            foreach(var value in array)
                if (value < search)
                    return true;

            return false;
        }

        [Benchmark]
        public bool Equals()
        {
            foreach(var value in array)
                if (value == search)
                    return true;
            return false;
        }

        [Benchmark]
        public bool NotEqual()
        {
            foreach(var value in array)
                if (value != search)
                    return true;

            return false;
        }

        [Benchmark]
        public bool GreaterEqual()
        {
            foreach(var value in array)
                if (value >= search)
                    return true;
            return false;
        }

        [Benchmark]
        public bool LessEqual()
        {
            foreach(var value in array)
                if (value <= search)
                    return true;
            return false;
        }
    }
}
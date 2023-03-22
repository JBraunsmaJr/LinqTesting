using System;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Jobs;

namespace LinqTesting
{
    [SimpleJob(RuntimeMoniker.Net48)]
    [SimpleJob(RuntimeMoniker.Net70)]
    public class EqualityTests
    {
        private readonly Random _random = new Random(1234);
        private int left, right;
        
        
        [GlobalSetup]
        public void Setup()
        {
            left = _random.Next(0, 100);
            right = _random.Next(0, 100);
        }

        [Benchmark]
        public bool Greater() => left > right;

        [Benchmark]
        public bool LessThan() => left < right;

        [Benchmark]
        public bool GreaterEqual() => left >= right;

        [Benchmark]
        public bool LessEqual() => left <= right;

        [Benchmark]
        public bool Equals() => left == right;

        [Benchmark]
        public bool NotEqual() => left != right;
    }    
}


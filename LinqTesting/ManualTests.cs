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
        [Benchmark]
        public bool GreaterThan()
        {
            foreach(var value in Shared.Array)
                if (value > Shared.Search)
                    return true;
            return false;
        }

        [Benchmark]
        public bool LessThan()
        {
            foreach(var value in Shared.Array)
                if (value < Shared.Search)
                    return true;

            return false;
        }

        [Benchmark]
        public bool Equals()
        {
            foreach(var value in Shared.Array)
                if (value == Shared.Search)
                    return true;
            return false;
        }

        [Benchmark]
        public bool NotEqual()
        {
            foreach(var value in Shared.Array)
                if (value != Shared.Search)
                    return true;

            return false;
        }

        [Benchmark]
        public bool GreaterEqual()
        {
            foreach(var value in Shared.Array)
                if (value >= Shared.Search)
                    return true;
            return false;
        }

        [Benchmark]
        public bool LessEqual()
        {
            foreach(var value in Shared.Array)
                if (value <= Shared.Search)
                    return true;
            return false;
        }
    }
}
using System;
using System.Linq;
using System.Linq.Expressions;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Jobs;
using LinqTesting.Extensions;

namespace LinqTesting
{
    public class Person
    {
        public int Id { get; set; }
    }
    
    [RPlotExporter]
    public class LinqTests
    {

        private Func<int,bool> greaterPredicate = x=> x > Shared.Search;

        [Benchmark]
        public void WhereAny()
        {
            var exists = Shared.Array.Where(greaterPredicate).Any();
        }

        [Benchmark]
        public void Any()
        {
            var exists = Shared.Array.Any(greaterPredicate);
        }

        [Benchmark]
        public void MyExtensionAny()
        {
            var exists = Shared.Array.CustomAny(greaterPredicate);
        }


        [Benchmark]
        public void WhereFirstOrDefault()
        {
            var item = Shared.Array.Where(greaterPredicate).FirstOrDefault();
        }

        [Benchmark]
        public void FirstOrDefault()
        {
            var item = Shared.Array.FirstOrDefault(greaterPredicate);
        }

        [Benchmark]
        public void MyExtensionFirstOrDefault()
        {
            var item = Shared.Array.CustomFirstOrDefault(greaterPredicate);
        }

        [Benchmark]
        public void ForEachIt()
        {
            foreach(var item in Shared.Array)
                if (item > Shared.Search)
                    return;
        }
    }
}
using System;
using System.Linq;
using System.Linq.Expressions;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Jobs;

namespace LinqTesting
{
    public class Person
    {
        public int Id { get; set; }
    }
    
    [SimpleJob(RuntimeMoniker.Net48)]
    [SimpleJob(RuntimeMoniker.Net70)]
    public class LinqTests
    {
        // For repeatable results
        private readonly Random _random = new Random(1234);

        private Person[] _arrayTest;
        private int[] _plainArray;

        [Params(100)]
        public int TotalRecords;

        const int searchFor = 948;
        
        private Func<int,bool> greaterPredicate = x=> x > searchFor;
        private Func<int,bool> equalsPredicate = x => x == searchFor;

        [GlobalSetup]
        public void Setup()
        {
            _arrayTest = new Person[TotalRecords];
            _plainArray = new int[TotalRecords];
            
            for (var i = 0; i < TotalRecords; i++)
            {
                var id = _random.Next(0, 1000);
                
                var item = new Person
                {
                    Id = id
                };

                _plainArray[i] = id;
                _arrayTest[i] = item;
            }
        }

        [Benchmark(Baseline = true)]
        public void ManualGreater948_Foreach()
        {
            foreach(var item in _plainArray)
                if (greaterPredicate(item))
                    break;
        }

        public void ManualEqualsForEach()
        {
            foreach(var item in _plainArray)
                if (equalsPredicate(item))
                    break;
        }

        [Benchmark]
        public void WhereGreaterAny()
        {
            var result = _plainArray.Where(greaterPredicate).Any();
        }

        [Benchmark]
        public void AnyGreater()
        {
            var result = _plainArray.Any(greaterPredicate);
        }

        [Benchmark]
        public void FirstOrDefaultGreater()
        {
            var result = _plainArray.FirstOrDefault(greaterPredicate);
        }

        [Benchmark]
        public void WhereGreaterFirstOrDefault()
        {
            var result = _plainArray.Where(greaterPredicate).FirstOrDefault();
        }

        [Benchmark]
        public void FirstOrDefaultEquals()
        {
            var result = _plainArray.FirstOrDefault(equalsPredicate);
        }

        [Benchmark]
        public void WhereEqualsFirstOrDefault()
        {
            var result = _plainArray.Where(equalsPredicate).FirstOrDefault();
        }

        [Benchmark]
        public void AnyEquals()
        {
            var result = _plainArray.Any(equalsPredicate);
        }

        [Benchmark]
        public void WhereEqualsAny()
        {
            var result = _plainArray.Where(equalsPredicate).Any();
        }
        
        //
        // [Benchmark]
        // [BenchmarkCategory("Equals")]
        // public void ArrayWhereAnyEquals948()
        // {
        //     var result = _plainArray.Where(x => x == 948).Any();
        // }
        //
        // [Benchmark]
        // [BenchmarkCategory("Equals")]
        // public void ArrayAnyEquals948()
        // {
        //     var result = _plainArray.Any(x => x == 948);
        // }
        //
        // [Benchmark]
        // [BenchmarkCategory("Equals")]
        // public void ArrayWhereEquals948FirstDefault()
        // {
        //     var result = _plainArray.Where(x => x == 948).FirstOrDefault();
        // }
        //
        // [Benchmark]
        // [BenchmarkCategory("Equals")]
        // public void ArrayFirstOrDefaultEquals948()
        // {
        //     var result = _plainArray.FirstOrDefault(x => x == 948);
        // }
        //
        // [Benchmark]
        // [BenchmarkCategory("Greater")]
        // public void ArrayWhereGreater948FirstOrDefault()
        // {
        //     var result = _plainArray.Where(x => x > 948).FirstOrDefault();
        // }
        //
        // [Benchmark]
        // [BenchmarkCategory("Greater")]
        // public void ArrayFirstOrDefaultGreater948()
        // {
        //     var result = _plainArray.FirstOrDefault(x => x > 948);
        // }
    }
}
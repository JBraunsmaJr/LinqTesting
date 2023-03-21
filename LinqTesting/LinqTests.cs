using System;
using System.Linq;
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

        [Params(100)]
        public int TotalRecords;

        [GlobalSetup]
        public void Setup()
        {
            _arrayTest = new Person[TotalRecords];
            
            for (var i = 0; i < TotalRecords; i++)
            {
                var item = new Person
                {
                    Id = _random.Next(0,1000)
                };

                _arrayTest[i] = item;
            }
        }

        [Benchmark]
        [BenchmarkCategory("Greater")]
        public void ArrayWhereGreater948Any()
        {
            var result = _arrayTest.Where(x => x.Id > 948).Any();
        }

        [Benchmark]
        [BenchmarkCategory("Greater")]
        public void ArrayAnyGreater948()
        {
            var result = _arrayTest.Any(x => x.Id > 948);
        }
        
        [Benchmark]
        [BenchmarkCategory("Equals")]
        public void ArrayWhereAnyEquals948()
        {
            var result = _arrayTest.Where(x => x.Id == 948).Any();
        }
        
        [Benchmark]
        [BenchmarkCategory("Equals")]
        public void ArrayAnyEquals948()
        {
            var result = _arrayTest.Any(x => x.Id == 948);
        }

        [Benchmark]
        [BenchmarkCategory("Equals")]
        public void ArrayWhereEquals948FirstDefault()
        {
            var result = _arrayTest.Where(x => x.Id == 948).FirstOrDefault();
        }

        [Benchmark]
        [BenchmarkCategory("Equals")]
        public void ArrayFirstOrDefaultEquals948()
        {
            var result = _arrayTest.FirstOrDefault(x => x.Id == 948);
        }

        [Benchmark]
        [BenchmarkCategory("Greater")]
        public void ArrayWhereGreater948FirstOrDefault()
        {
            var result = _arrayTest.Where(x => x.Id > 948).FirstOrDefault();
        }
        
        [Benchmark]
        [BenchmarkCategory("Greater")]
        public void ArrayFirstOrDefaultGreater948()
        {
            var result = _arrayTest.FirstOrDefault(x => x.Id > 948);
        }

    }
}
using System;
using System.Linq;
using BenchmarkDotNet.Running;

namespace LinqTesting
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            BenchmarkRunner.Run<ManualTests>();
            BenchmarkRunner.Run<EqualityTests>();
            
            BenchmarkRunner.Run<AnyTests>();
            BenchmarkRunner.Run<WhereAnyTests>();

            BenchmarkRunner.Run<FirstOrDefaultTests>();
            BenchmarkRunner.Run<WhereFirstOrDefaultTests>();
            
            Random random = new Random(1234);

            var ids = new int[10];
            for (int i = 0; i < 10; i++)
                ids[i] = random.Next(0, 1000);

            Console.WriteLine(string.Join(", ", ids));
        }
    }
}
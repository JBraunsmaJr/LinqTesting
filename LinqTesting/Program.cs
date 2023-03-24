using System;
using System.Linq;
using BenchmarkDotNet.Running;

namespace LinqTesting
{
    internal class Program 
    {
        public static void Main(string[] args)
        {
            BenchmarkRunner.Run<LinqTests>();
        }
    }
}
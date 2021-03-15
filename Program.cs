using System;
using System.Collections.Generic;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;

namespace sharplab
{
    public class Program
    {
        static void Main(string[] args)
        {
            var summary = BenchmarkRunner.Run<Loop>();
            Console.Write(summary);
        }
    }

    [MemoryDiagnoser]
    public class Loop
    {
        private readonly List<int> elements;
        private int sum = 0;
        public Loop()
        {
            elements = new List<int>() {1,2,3,4,5,6,7,8,9,10};
        }

        [Benchmark(Baseline = true)]
        public void ForLoop()
        {
            sum = 0;
            for (int i = 0; i < elements.Count; i++)
            {
                sum += elements[i];
            }
        }

        [Benchmark(Baseline = false)]
        public void ForEachLoop()
        {
            sum = 0;
            foreach (var element in elements)
            {
                sum += element;
            }
        }

        [Benchmark(Baseline = false)]
        public void ForEachLambdaLoop()
        {
            sum = 0;
            elements.ForEach(
                x => sum += x
            );
        }
    }
}

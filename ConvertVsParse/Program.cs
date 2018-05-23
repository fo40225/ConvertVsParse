using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConvertVsParse
{
    using BenchmarkDotNet.Attributes;
    using BenchmarkDotNet.Running;

    public class ConvertVsParse
    {
        private List<string> data = new List<string>();

        [Params(1000, 1000000)]
        public int N;

        [GlobalSetup]
        public void Setup()
        {
            var rnd = new Random(42);
            for (int i = 0; i < 1000; i++)
            {
                this.data.Add(i.ToString());
            }
        }

        [Benchmark]
        public int[] Convert() => this.data.Select(x => System.Convert.ToInt32(x)).ToArray();

        [Benchmark]
        public int[] Parse() => this.data.Select(x => int.Parse(x)).ToArray();
    }

    class Program
    {
        static void Main(string[] args)
        {
            var summary = BenchmarkRunner.Run<ConvertVsParse>();
        }
    }
}

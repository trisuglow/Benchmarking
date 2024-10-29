using BenchmarkDotNet.Attributes;
using System.Text;

namespace ConsoleApp1

{
    public class Benchmarks
    {
        [Benchmark]
        public string Slow()
        {
            string a = "";
            for (int i = 0; i < 1024; i++)
            {
                a += "!";
            }

            return a;
        }

        [Benchmark]
        public string Fast()
        {
            var a = new StringBuilder();

            for (int i = 0; i < 1024; i++)
            {
                a.Append("!");
            }

            return a.ToString();
        }

        [Benchmark]
        public string Quick()
        {
            return new string('!', 1024);
        }
    }
}

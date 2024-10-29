using BenchmarkDotNet.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestHarness
{
    public static class Worker
    {
        [Benchmark()]
        public static string Slow()
        {
            string a = "";
            for (int i = 0; i < 1024; i++)
            {
                a += "!";
            }

            return a;
        }

        [Benchmark()]
        public static string Fast()
        {
            StringBuilder a = new StringBuilder();

            
            for (int i = 0; i < 1024; i++)
            {
                a.Append("!");
            }

            return a.ToString();
        }
    }
}

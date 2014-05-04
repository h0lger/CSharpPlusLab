using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication
{
    class Program
    {
        /// <summary>
        /// C#
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Stopwatch sw = new Stopwatch();
            CPlusLab.MathTest t = new CPlusLab.MathTest();
            long totTime = 0;
            int iterations = 30;
            double z = 0;
            for (int i = 0; i < iterations; i++)
            {
                sw.Start();
                z = t.MyMethod(5, 6, 10000000);
                sw.Stop();
                totTime += sw.ElapsedMilliseconds;
                sw.Reset();
            }
            Console.WriteLine(z);
            Console.WriteLine(totTime / iterations);
            Console.ReadLine();
        }

        ///// <summary>
        ///// C#
        ///// </summary>
        ///// <param name="args"></param>
        //static void Main(string[] args)
        //{
        //    Stopwatch sw = new Stopwatch();
        //    CSharpPlusLab.MathTest t = new CSharpPlusLab.MathTest();
        //    long totTime = 0;
        //    int iterations = 30;
        //    double z = 0;
        //    for (int i = 0; i < iterations; i++)
        //    {
        //        sw.Start();
        //        z = t.MyMethod(5, 6, 10000000);
        //        sw.Stop();
        //        totTime += sw.ElapsedMilliseconds;
        //        sw.Reset();
        //    }            
        //    Console.WriteLine(z);
        //    Console.WriteLine(totTime / iterations);
        //    Console.ReadLine();
        //}
    }
}

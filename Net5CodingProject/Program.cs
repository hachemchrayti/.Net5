using System;
using System.Diagnostics;
using System.Text;

namespace Net5CodingProject
{
    class Program
    {
        static void Main(string[] args)
        {

            string str = "";
            Console.WriteLine("Loop Started");
            var stopwatch = new Stopwatch();
            stopwatch.Start();
            for (int i = 0; i < 30000000; i++)
            {
                str = Guid.NewGuid().ToString();
            }
            stopwatch.Stop();
            Console.WriteLine("Loop Ended");
            Console.WriteLine("Loop Exceution Time in MS :" + stopwatch.ElapsedMilliseconds);

            Console.WriteLine("-------------------------------------------------------------");

            int ctr = 0;
            Console.WriteLine("Loop Started");
            stopwatch = new Stopwatch();
            stopwatch.Start();
            for (int i = 0; i < 30000000; i++)
            {
                ctr = ctr + 1;
            }
            stopwatch.Stop();
            Console.WriteLine("Loop Ended");
            Console.WriteLine("Loop Exceution Time in MS :" + stopwatch.ElapsedMilliseconds);
            Console.WriteLine("-------------------------------------------------------------");

            var str1 = "";
            Console.WriteLine("Loop Started");
            stopwatch = new Stopwatch();
            stopwatch.Start();
            for (int i = 0; i < 30000; i++)
            {
                str = "DotNet Tutorials" + str;
            }
            stopwatch.Stop();
            Console.WriteLine("Loop Ended");
            Console.WriteLine("Loop Exceution Time in MS :" + stopwatch.ElapsedMilliseconds);
            Console.WriteLine("-------------------------------------------------------------");

            StringBuilder stringBuilder = new StringBuilder();
            Console.WriteLine("Loop Started");
            stopwatch = new Stopwatch();
            stopwatch.Start();
            for (int i = 0; i < 30000; i++)
            {
                stringBuilder.Append("DotNet Tutorials");
            }
            stopwatch.Stop();
            Console.WriteLine("Loop Ended");
            Console.WriteLine("Loop Exceution Time in MS :" + stopwatch.ElapsedMilliseconds);
        }
    }
}

using System;
using System.Diagnostics;
using System.Text;

namespace Net5CodingProject
{
    class Program
    {
        static void Main(string[] args)
        {

            var result = Calculator.Sum(10, 25); // calling static method
            Calculator.Store(result);
            Console.WriteLine(result);

            var calcType = Calculator.Type; // accessing static variable
            Calculator.Type = "Scientific"; // assign value to static variable

            Console.WriteLine("---------------------------------------------------");

            StopWatch sw1 = new StopWatch();
            StopWatch sw2 = new StopWatch();
            Console.WriteLine(StopWatch.NoOfInstances); //2 

            StopWatch sw3 = new StopWatch();
            StopWatch sw4 = new StopWatch();
            Console.WriteLine(StopWatch.NoOfInstances);//4
        }
    }

    public class StopWatch
    {
        public static int NoOfInstances = 0;

        // instance constructor
        public StopWatch()
        {
            Console.WriteLine("Instance constructor called");
            StopWatch.NoOfInstances++;
        }

        // static constructor
        static StopWatch()
        {
            Console.WriteLine("Static constructor called");
        }




        // static method
        public static void DisplayInfo()
        {
            Console.WriteLine("DisplayInfo called");
        }

        // instance method
        public void Start() { }

        // instance method
        public void Stop() { }
    }

}

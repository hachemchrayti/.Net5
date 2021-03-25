using System;
using System.Diagnostics;
using System.Text;

namespace Net5CodingProject
{
    class Program
    {
        public void ChangeReferenceType(Student std2)
        {
            std2.StudentName = "Steve";
        }

        public void ChangeValueTypeValue(int x)
        {
            x = 200;

            Console.WriteLine(x);
        }

        public static void Main()
        {
            Student std1 = new Student();

            std1.StudentName = "Bill";

            Program p = new Program();
            p.ChangeReferenceType(std1);

            Console.WriteLine(std1.StudentName);

            Console.WriteLine("--------------------");
            int i = 100;

            Console.WriteLine(i);

            p.ChangeValueTypeValue(i);

            Console.WriteLine(i);

        }


    }

    public class Student
    {

        public string StudentName { get; set; }

    }

}

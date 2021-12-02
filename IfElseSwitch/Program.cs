using System;

namespace IfElseSwitch
{
    class Marks
    {
        public int Physics { get; set; }
        public int Chemistry { get; set; }
        public int Maths { get; set; }

        public void Result()
        {
            Console.WriteLine("");
        }
    }
    class Student
    {
        public string Name;
        public int Rno;

        public void Display()
        {
            Console.WriteLine("List of all Students :");
            for (int i = 0; i < num; i++)
            {
                Console.WriteLine("\tRoll No : {0}", i + 1);
                Console.Write("\t\tName : ");

            }
        }
    }
    class Program
    {
        public static void Main()
        {
            Console.WriteLine("How many Students");
            int num =Int32.Parse(Console.ReadLine());

            Student[] Students = new Student[num];

            Console.WriteLine("Enter the names of Students :");

            for (int i=0;i<num;i++)
            {
                Console.WriteLine("\tRoll No : {0}",i+1);
                Console.Write("\t\tName : ");

                Students[i].Name=Console.ReadLine();
                Students[i].Rno= i+1;
            }

        }
    }
}

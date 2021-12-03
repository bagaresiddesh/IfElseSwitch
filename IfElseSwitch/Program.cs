using System;

namespace IfElseSwitch
{
    class Marks
    {
        public int Physics { get; set; }
        public int Chemistry { get; set; }
        public int Maths { get; set; }
        public void Allocate()
        {
            Physics = Random();
            Chemistry = Random();
            Maths = Random();
        }
        static Random rand = new Random();
        static int Random()
        {
            return rand.Next(10, 101);
        }
        public string Result()
        {
            if ((Chemistry < 40) || (Physics < 40) || (Maths < 40))
            {
                return ("fail");
            }
            else
            {
                return ("pass");
            }
        }
        class Student : Marks
        {
            public string Name { get; set; }
            public int Rno { get; set; }
            public void Display()
            {
                Console.WriteLine("----------------------------------------------------------");
                Console.WriteLine("Result for {0} : {1}", Name, Result());
                Console.WriteLine("Physics: {0}  Chemistry: {1}  Maths: {2}", Physics, Chemistry, Maths);
                Console.WriteLine("Total: {0}/300", Physics + Chemistry + Maths);
                Console.WriteLine("Average: {0}", (Physics + Chemistry + Maths) / 3);
            }
        }
        class Program
        {
            public static void Main()
            {
                int num;

                Console.WriteLine("How many Students");
                num = Int32.Parse(Console.ReadLine());

                Student[] Students = new Student[num];

                Console.WriteLine("Enter the names of Students :");
                for (int i = 0; i < num; i++)
                {
                    Console.WriteLine("Roll No : {0} \tName: ", i + 1);
                    Students[i] = new Student();

                    Students[i].Name = Console.ReadLine();
                    Students[i].Rno = i + 1;

                    Students[i].Allocate();
                }
                for (int i = 0; i < num; i++)
                {
                    Students[i].Display();
                }
                Console.ReadLine();
            }
        }
    }
}
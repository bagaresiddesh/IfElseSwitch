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
            var rand = new Random();
            this.Physics = rand.Next(10,101);
            this.Chemistry = rand.Next(10,101);
            this.Maths = rand.Next(10,101);
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
                Console.WriteLine("Physics: {0}  Chemistry: {1}  Maths: {2}", this.Physics, this.Chemistry, this.Maths);
            }
        }
        class Program
        {
            public static void Main()
            {
                int num;

                Console.WriteLine("How many Students");
                num =Int32.Parse(Console.ReadLine());

                Student []Students = new Student[num];

                Console.WriteLine("Enter the names of Students :");

                for (int i=0;i<num;i++)
                {
                    Console.WriteLine("Roll No : {0} \tName: ", i+1);
                    Students[i] = new Student();

                    Students[i].Name=Console.ReadLine();
                    Students[i].Rno= i+1;
                }
                
                for (int i = 0; i < num; i++)
                {
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

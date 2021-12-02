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
            this.Physics = rand.Next(101);
            this.Chemistry = rand.Next(101);
            this.Maths = rand.Next(101);
        }
        public void Result()
        {
            Console.WriteLine("");
        }
    }
    class Student:Marks
    {
        public string Name { get; set; }
        public int Rno { get; set; }

        public Student(string name,int rno)
        {
            Name = name;
            Rno = rno;
        }
        public void Display()
        {
            Console.WriteLine("Marks : ");
            Console.Write("Physics: {0}  Chemistry: {1}  Maths: {2}", this.Physics, this.Chemistry, this.Maths);
        }
    }
    class Program
    {
        public static void Main()
        {
            Student s = new Student("aditya", 100);

            s.Allocate();
            s.Display();

            Console.ReadLine();

        }
    }
}

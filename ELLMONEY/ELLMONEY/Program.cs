using System;
using System.Collections.Generic;

namespace ELLMONEY
{
    class Program
    {
        public static List<Student> students = new List<Student>
        {
            new Student("Ahmad"),
            new Student("Mona"),
            new Student("Ali"),
            new Student("Harun"),
            new Student("Chala"),
            new Student("Sedra"),
            new Student("Ranim"),
            new Student("Obeid"),
            new Student("Ahmad A"),
            new Student("Hamza"),
            new Student("Rasha"),
            new Student("Yasmin"),
            new Student("Maryan"),
            new Student("Mohamad"),
            new Student("Ahed"),
        };
        static void Main(string[] args)
        {
            Begin();            
        }

        private static void Begin()
        {
            Console.Clear();
            Write.Line("[1] Add Money to everyone");
            Write.Line("[2] Take Money from everyone");
            Write.Line("[D] See everyone's money");

            string x = Return.Option();
            if (x == "1")
            {
                Write.Line("How much would you like to give each student?");
                int y = Return.Integer();
                foreach (Student s in students) Add(s, y);
            }
            else if (x == "2")
            {
                Write.Line("How much would you like to take from each student?");
                int y = Return.Integer();
                foreach (Student s in students) Subtract(s, y);
            }
            else if (x == "d") Display();
            Write.KeyPress();
            Begin();
        }

        private static void Add(Student s, int y) => s.money += y;
        private static void Subtract(Student s, int y) => s.money -= y;

        public static void Display()
        {
            foreach (Student s in students) Console.WriteLine($"{s.name}: {s.money}$");
        }

        
    }
}

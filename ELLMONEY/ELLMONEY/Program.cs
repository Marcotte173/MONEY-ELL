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
            Write.Line("[1] Add Money");
            Write.Line("[2] Take Money");
            Write.Line("[D] See everyone's money");

            string x = Return.Option();            
            if (x == "1")
            {
                bool multi = Choose(true);
                Write.Line("How much would you like to give?");
                int y = Return.Integer();
                if (multi)
                {
                    foreach (Student s in students) Add(s, y);
                    Write.Line($"{y} dollars has been given to each student");
                }
                else 
                {
                    Student s = GetStudent();
                }
            }
            else if (x == "2")
            {
                bool multi = Choose(false);
                Write.Line("How much would you like to take");
                int y = Return.Integer();
                if (multi)
                {
                    foreach (Student s in students) Subtract(s, y);
                    Write.Line($"{y} dollars has been taken from each student");
                }
            }
            else if (x == "d") Display();
            Write.KeyPress();
            Begin();
        }

        private static Student GetStudent()
        {
            
        }

        private static bool Choose(bool give)
        {
            Console.Clear();
            string x = (give) ? "give to" : "take from";
            Write.Line($"Would you like to {x} [1] a student or [2] the class?");
            string y = Return.Option();
            if (y == "1") return false;
            else if (y == "2") return true;
            else Choose(give);
            return true;
        }

        private static void Add(Student s, int y) => s.money += y;
        private static void Subtract(Student s, int y) => s.money -= y;

        public static void Display()
        {
            foreach (Student s in students) Console.WriteLine($"{s.name}: {s.money}$");
        }        
    }
}

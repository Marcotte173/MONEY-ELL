using System;
using System.IO;
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
            Console.WriteLine("[1] Add Money");
            Console.WriteLine("[2] Take Money");
            Console.WriteLine("[D] See everyone's money");

            string x = Return.Option();            
            if (x == "1")
            {
                bool multi = Choose(true);
                Console.WriteLine("How much would you like to give?");
                int y = Return.Integer();
                if (multi)
                {
                    foreach (Student s in students) Add(s, y);
                    Console.WriteLine($"{y} dollars has been given to each student");
                }
                else 
                {
                    Student s = GetStudent();
                    Add(s, y);
                    Console.WriteLine($"{y} dollars has been given to {s.name}");
                }
            }
            else if (x == "2")
            {
                bool multi = Choose(false);
                Console.WriteLine("How much would you like to take");
                int y = Return.Integer();
                if (multi)
                {
                    foreach (Student s in students) Subtract(s, y);
                    Console.WriteLine($"{y} dollars has been taken from each student");
                }
                else
                {
                    Student s = GetStudent();
                    Subtract(s, y);
                    Console.WriteLine($"{y} dollars has been taken from {s.name}");
                }
            }
            else if (x == "d") Display();
            Write.KeyPress();
            Begin();
        }

        private static Student GetStudent()
        {
            int choice;
            do
            {
                Console.Clear();
                Console.WriteLine("Which student would you like to select?");
                for (int i = 0; i < students.Count; i++)
                {
                    Console.WriteLine($"{i + 1} {students[i].name}");
                }
            } while (!int.TryParse(Console.ReadLine(), out choice));
            if (choice > 0 && choice <= students.Count) return students[choice - 1];
            else GetStudent();
            return null;
        }

        private static bool Choose(bool give)
        {
            Console.Clear();
            string x = (give) ? "give to" : "take from";
            Console.WriteLine($"Would you like to {x} [1] a student or [2] the class?");
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
            Console.Clear();
            foreach (Student s in students) Console.WriteLine($"{s.name}: {s.money}$");
        }        
    }
}

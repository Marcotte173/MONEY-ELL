using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;

namespace ELLMONEY
{
    class Program
    {
        public static bool bla;
        public static List<Student> students = new List<Student>
        {

        };

        public static List<Student> ELL = new List<Student> 
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
        public static List<Student> BLA = new List<Student>
        {
            new Student("Devon"),
            new Student("Kayden"),
            new Student("Cody"),
            new Student("Kyra"),
            new Student("Wesley"),
            new Student("Wes"),
            new Student("Austin"),
            new Student("Kai-C")
        };
        static void Main(string[] args)
        {
            Choose();          
        }

        private static void Choose()
        {
            Write.Line("Welcome to the classroom tracker");
            Write.Line("Which Class would you like to work with?");
            Write.Line("[1] BLA");
            Write.Line("[2] ELL");
            string x = Return.Option();
            if (x == "1")
            {
                bla = true;
                if (File.Exists("BLA.txt")) Load();
                else
                    students = BLA;
            }
            else if (x == "2")
            {
                if (File.Exists("ELL.txt")) Load();
                else
                    students = ELL;
            }
            else Choose();
            Begin();
        }

        private static void Begin()
        {
            Console.Clear();
            Write.Line("What would you like to do?\n\n");
            Write.Line("[1] Add Money");
            Write.Line("[2] Take Money");
            Write.Line("[3] Make a purchase");
            Write.Line("[4] Remove a purchase");
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
                    Add(s, y);
                    Write.Line($"{y} dollars has been given to {s.name}");
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
                else
                {
                    Student s = GetStudent();
                    Subtract(s, y);
                    Write.Line($"{y} dollars has been taken from {s.name}");
                }
            }
            else if (x == "d") Display();
            Write.KeyPress(1);
            Save();
            Begin();
        }

        public static void Save()
        {
            string path = (bla)?"BLA.txt":"ELL.txt";
            //Write some text to the test.txt file
            StreamWriter writer = new StreamWriter(path);
            foreach (Student s in students)
            {
                writer.Write($"{s.name},{s.money},{s.freeTime},{s.candy},{s.allTimeMoneyEarned},{s.moneySpent},");
            }            
            writer.Close();
            
        }

        public static void Load()
        {
            StreamReader reader = new StreamReader((bla) ? "BLA.txt" : "ELL.txt");
            string infostring = reader.ReadToEnd();
            string[] info = infostring.Split(',');
            List<string> newInfo = info.ToList();
            while (newInfo.Count >0)
            {
                if (newInfo.Count > 1)
                {
                    students.Add(new Student(newInfo[0], Convert.ToInt32(newInfo[1]), Convert.ToInt32(newInfo[2]), Convert.ToInt32(newInfo[3]), Convert.ToInt32(newInfo[4]), Convert.ToInt32(newInfo[5])));
                    for (int i = 0; i < 6; i++) newInfo.RemoveAt(0);
                }
                else newInfo.RemoveAt(0);
            }
            reader.Close();
        }

        private static Student GetStudent()
        {
            int choice;
            do
            {
                Console.Clear();
                Write.Line("Which student would you like to select?");
                for (int i = 0; i < students.Count; i++)
                {
                    Write.Line($"{i + 1} {students[i].name}");
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
            Write.Line($"Would you like to {x} [1] a student or [2] the class?");
            string y = Return.Option();
            if (y == "1") return false;
            else if (y == "2") return true;
            else Choose(give);
            return true;
        }

        private static void Add(Student s, int y)
        {
            s.money += y;
            s.allTimeMoneyEarned += y;
        }
        private static void Subtract(Student s, int y) => s.money -= y;

        public static void Display()
        {
            Console.Clear();
            Write.Line(String.Format("{0,-21}{1,-21}{2,-26}{3,-5}", Color.OWNER + "Name", Color.GOLD+"Money", Color.ENERGY+ "Free Time", Color.BLOOD+"Candy"+ Color.RESET));
            foreach (Student s in students) Write.Line(String.Format("{0,-11}{1,-13}{2,-13}{3,-5}",s.name,s.money,s.freeTime,s.candy));
        }        
    }
}
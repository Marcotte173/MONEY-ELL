using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Student
{
    public int money;
    public string name;
    public int freeTime;
    public int candy;
    public int allTimeMoneyEarned;
    public int moneySpent;
    public Student(string name)
    {
        this.name = name;
        money = 0;
        freeTime = 0;
        candy = 0;
        allTimeMoneyEarned = 0;
        moneySpent = 0;
    }
    public Student(string name, int money, int freeTime, int candy, int allTimeMoneyEarned, int moneySpent)
    {
        this.name = name;
        this.money = money;
        this.freeTime = freeTime;
        this.candy = candy;
        this.allTimeMoneyEarned = allTimeMoneyEarned;
        this.moneySpent = moneySpent;
    }
}
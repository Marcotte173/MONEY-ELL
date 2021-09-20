using System;
using System.Collections.Generic;
using System.Text;

public class Write
{
    internal static void Line(int x, int y, string words) { Console.SetCursorPosition(x, y); Console.Write(words); Console.WriteLine(Color.RESET); }
    internal static void Line(string words) { Console.WriteLine(words); Console.WriteLine(Color.RESET); }
    internal static void Line(int x, int y, string word1, string word2)
    {
        Console.SetCursorPosition(x, y);
        Console.Write(word1);
        Console.SetCursorPosition(x + 25, y);
        Console.Write(word2);
    }

    internal static void Line(int x, int y, string word1, string word2, string word3)
    {
        Console.SetCursorPosition(x, y);
        Console.Write(word1);
        Console.SetCursorPosition(x + 12, y);
        Console.Write(word2);
        Console.SetCursorPosition(x + 25, y);
        Console.Write(word3);
    }
    internal static void Line(int x, int y, string word1, string word2, string word3, string word4)
    {
        Console.SetCursorPosition(x, y);
        Console.Write(word1);
        Console.SetCursorPosition(x + 15, y);
        Console.Write(word2);
        Console.SetCursorPosition(x + 30, y);
        Console.Write(word3);
        Console.SetCursorPosition(x + 45, y);
        Console.Write(word4);
    }
    internal static void Line(int x, int y, string word1, string word2, string word3, string word4, string word5, string word6, string word7)
    {
        Console.SetCursorPosition(x, y);
        Console.Write(word1);
        Console.SetCursorPosition(x, y);
        Console.Write(word2);
        Console.SetCursorPosition(x + 15, y);
        Console.Write(word3);
        Console.SetCursorPosition(x + 30, y);
        Console.Write(word4);
        Console.SetCursorPosition(x + 45, y);
        Console.Write(word5);
        Console.SetCursorPosition(x + 60, y);
        Console.Write(word6);
        Console.SetCursorPosition(x + 75, y);
        Console.Write(word7);
    }
    internal static void KeyPress()
    {
        Write.Line("Press any key to continue");
        Console.ReadKey(true);
    }
    internal static void KeyPress(int a)
    {
        for (int i = 0; i < a; i++)
        {
            Console.WriteLine("");
        }
        Write.Line("Press any key to continue");
        Console.ReadKey(true);
    }
    internal static void KeyPress(int x, int y)
    {
        Console.SetCursorPosition(x, y);
        Write.Line("Press any key to continue");
        Console.ReadKey(true);
    }

    public static void Line(string colour, string text)
    {
        Console.Write($"{colour}" + $"{text}" + Color.RESET);
    }

    public static void Line(string colour, string text1, string text2, string text3)
    {
        Console.Write(
            $"{text1}"
            + colour + $"{text2}"
            + Color.RESET + $"{text3}\n");
    }

    public static void Line(string colour, string colour2, string text1, string text2, string text3, string text4, string text5)
    {
        Console.Write(
            $"{text1}"
            + colour
            + $"{text2}"
            + Color.RESET + $"{text3}"
            + colour2 + $"{text4}"
            + Color.RESET + $"{text5}\n");
    }

    public static void Line(string colour, string colour2, string colour3, string text1, string text2, string text3, string text4, string text5, string text6, string text7)
    {
        Console.Write(
            $"{text1}"
            + colour + $"{text2}"
            + Color.RESET + $"{text3}"
            + colour2 + $"{text4}"
            + Color.RESET + $"{text5}"
            + colour3 + $"{text6}"
            + Color.RESET
            + $"{text7}\n");
    }

    public static void Line(string colour1, string colour2, string colour3, string colour4, string text1, string text2, string text3, string text4, string text5, string text6, string text7, string text8, string text9)
    {
        Console.Write(
            $"{text1}"
            + colour1
            + $"{text2}"
            + Color.RESET
            + $"{text3}"
            + colour2
            + $"{text4}"
            + Color.RESET
            + $"{text5}"
            + colour3
            + $"{text6}"
            + Color.RESET
            + $"{text7}"
            + colour4
            + $"{text8}"
            + Color.RESET
            + $"{text9}\n");
    }

    public static void Line(string colour1, string colour2, string colour3, string colour4, string colour5, string text1, string text2, string text3, string text4, string text5, string text6, string text7, string text8, string text9, string text10, string text11)
    {
        Console.Write(
             $"{text1}"
             + colour1
             + $"{text2}"
             + Color.RESET
             + $"{text3}"
             + colour2
             + $"{text4}"
             + Color.RESET
             + $"{text5}"
             + colour3
             + $"{text6}"
             + Color.RESET
             + $"{text7}"
             + colour4
             + $"{text8}"
             + Color.RESET
             + $"{text9}"
             + colour5
             + $"{text10}"
             + Color.RESET
             + $"{text11}\n");
    }

    public static void Line(int x, int y, string colour, string colour2, string colour3, string text1, string text2, string text3, string text4, string text5, string text6, string text7)
    {
        Console.SetCursorPosition(x, y);
        Console.Write(
            $"{text1}"
            + colour + $"{text2}"
            + Color.RESET + $"{text3}"
            + colour2 + $"{text4}"
            + Color.RESET + $"{text5}"
            + colour3 + $"{text6}"
            + Color.RESET
            + $"{text7}\n");
    }

    public static void Line(int x, int y, string colour1, string colour2, string colour3, string colour4, string text1, string text2, string text3, string text4, string text5, string text6, string text7, string text8, string text9)
    {
        Console.SetCursorPosition(x, y);
        Console.Write(
            $"{text1}"
            + colour1
            + $"{text2}"
            + Color.RESET
            + $"{text3}"
            + colour2
            + $"{text4}"
            + Color.RESET
            + $"{text5}"
            + colour3
            + $"{text6}"
            + Color.RESET
            + $"{text7}"
            + colour4
            + $"{text8}"
            + Color.RESET
            + $"{text9}\n");
    }

    public static void Line(int x, int y, string colour1, string colour2, string colour3, string colour4, string colour5, string text1, string text2, string text3, string text4, string text5, string text6, string text7, string text8, string text9, string text10, string text11)
    {
        Console.Write(
             $"{text1}"
             + colour1
             + $"{text2}"
             + Color.RESET
             + $"{text3}"
             + colour2
             + $"{text4}"
             + Color.RESET
             + $"{text5}"
             + colour3
             + $"{text6}"
             + Color.RESET
             + $"{text7}"
             + colour4
             + $"{text8}"
             + Color.RESET
             + $"{text9}"
             + colour5
             + $"{text10}"
             + Color.RESET
             + $"{text11}\n");
    }
}
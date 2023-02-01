
using System;

public class Program
{
    public static void Main(string[] args)
    {
        NumbersToRoman toRoman = new NumbersToRoman();
        string str= toRoman.IntToRoman(5023);
        Console.WriteLine(str);
        Console.ReadKey();
    }
}
public class NumbersToRoman
{
    public string IntToRoman(int num)
    {
        string romanResult = "";
        Dictionary<string, int> romanNumbersDictionary = new() {
            {
                "I",
                1
            }, {
                "IV",
                4
            }, {
                "V",
                5
            }, {
                "IX",
                9
            }, {
                "X",
                10
            }, {
                "XL",
                40
            }, {
                "L",
                50
            }, {
                "XC",
                90
            }, {
                "C",
                100
            }, {
                "CD",
                400
            }, {
                "D",
                500
            }, {
                "CM",
                900
            }, {
                "M",
                1000
            }
        };
        foreach (var item in romanNumbersDictionary.Reverse())
        {
            if (num <= 0) break;
            while (num >= item.Value)
            {
                romanResult += item.Key;
                num -= item.Value;
            }
        }
        return romanResult;
    }
}
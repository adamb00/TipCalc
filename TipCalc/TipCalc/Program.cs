
using System;
using System.IO;
using TipCalc.Models;

namespace TipCalc
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("A számla végösszege?  ");
            TipCalculator t = new TipCalculator(Convert.ToDouble(Console.ReadLine()));
            Console.WriteLine(t);
            Console.ReadKey();
        }
    }
}
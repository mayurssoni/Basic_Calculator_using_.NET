using System;
using System.ComponentModel.Design;

namespace Calculator
{
    public static class Program
    {
        public static void Calculation()
        {

            Console.WriteLine(@"
                Operations Cheat Sheet:
                
                |----------------|-------|------------------|
                |Operation       |Symbol |Calculation       |
                |----------------|-------|------------------|
                |Addition        |+      | a + b = result   |
                |Subtraction     |-      | a - b = result   |
                |Multiplication  |*      | a * b = result   |
                |Division        |/      | a / b = result   |
                |----------------|-------|------------------|");

            Console.Write("\nEnter First Number:");
            double num1 = 0;
            num1 = Convert.ToDouble(Console.ReadLine());
            
            Console.Write("\nEnter Second Number:");
            double num2 = 0;
            num2 = Convert.ToDouble(Console.ReadLine());
            
            Console.Write("\nEnter Operation Symbol:");
            string symb = Console.ReadLine() ?? "+";
            if (symb == "X" ^ symb == "x") { symb = "*"; }
        }
        public static void Main(string[] args)
        {
            Console.WriteLine(@"Basic Calculator Program");
            Program.Calculation();
        }
    }
}

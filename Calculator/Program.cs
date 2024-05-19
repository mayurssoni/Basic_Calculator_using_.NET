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
        }
        public static void Main(string[] args)
        {
            Console.WriteLine(@"Basic Calculator Program");
            Program.Calculation();
        }
    }
}
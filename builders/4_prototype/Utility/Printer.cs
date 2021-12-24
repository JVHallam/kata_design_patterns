using System;
using practise_area.Models;

namespace practise_area.Utility
{
    public static class Printer
    {
        public static void Print(TestCase testCase)
        {
            Console.WriteLine($"A : {testCase.A}, B : {testCase.B}, C : {testCase.C}");
        }
    }
}

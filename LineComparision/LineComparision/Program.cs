﻿using System;

namespace LineComparision
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("... Welcome to Line Comparison Computation ... ");
            LineComparision Line = new LineComparision();
            Line.length();
            Console.ReadKey();
        }
    }
}

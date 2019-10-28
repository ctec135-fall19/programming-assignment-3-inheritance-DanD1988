/*
Author: Daniel Davidson
Date:   10/23/2019
CTEC 135: Microsoft Software Development with C# 

Module 5, Programming Assignment 3, Problem 3

    Demonstrate both the aggregation and composition relationships.

 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prob3
{
    class Program
    {
        static void Main(string[] args)
        {
            // initializing aggregation in the derived class
            string s = "Aggregation. String s has a relationship with inStr";
           
            AggClass mc = new AggClass(s);
           
            mc.printState();
            Console.WriteLine();
        }
    }
}

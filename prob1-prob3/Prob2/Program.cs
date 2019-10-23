/*
Author: Daniel Davidson
Date: 10/19/2019
CTEC 135: Microsoft Software Development with C#

Module 4, Programming Assignment 3, Problem 2

Prob 2: Demo of Field Access and Constructor Calling Sequence

  Create a class hierarchy that:
    Demonstrates the effect of the private and protected access modifiers on access to fields from child classes.
    Demonstrates the calling sequence of constructors.
    Demonstrates setting and getting field values.

*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prob2
{
    class Program
    {
        static void Main(string[] args)
        {
            RedBox rb = new RedBox();
            BlueBox bb = new BlueBox();
            GreenBox gb = new GreenBox();

            Console.WriteLine("calling Methods from GreenBox");
            
            
            gb.BoxMethod();
            gb.RedBoxMethod();
            // gb.BlueBoxMethod();
            Console.WriteLine();

            Console.WriteLine("Calling Methods from RedBox class");

            rb.BoxMethod();
            rb.RedBoxMethod();
            Console.WriteLine();

            // test BoxClass fields

            BoxClass bc = new BoxClass(888, 445);
            bc.PrintState();

            // test RedBox fields 

            //RedBox rb2 = new RedBox(123, 456, 434);
            //rb2.PrintState();
           // Console.ReadLine();
        }
    }
}

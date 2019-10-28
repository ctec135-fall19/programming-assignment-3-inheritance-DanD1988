/*
Author: Daniel Davidson
Date: 10/19/2019
CTEC 135: Microsoft Software Development with C#

Module 4, Programming Assignment 3, Problem 2

Prob 2: Demo of Field Access and Constructor Calling Sequence

  Create a class hierarchy that:
    * Demonstrates the effect of the private and protected access 
      modifiers on access to fields from child classes.
    * Demonstrates the calling sequence of constructors.
    * Demonstrates setting and getting field values.

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
            // Test Method Inheritence 

            RedBox rb = new RedBox();
            BlueBox bb = new BlueBox();

            // calling blue box methods to test inheritence.
            Console.WriteLine("Calling Methods from BlueBox");
            bb.BoxMethod();
            bb.RedBoxMethod();
            bb.BlueBoxMethod();
            Console.WriteLine();

            // calling red box methods to test inheritence.
            Console.WriteLine("Calling Methods from RedBox");
            rb.BoxMethod();
            rb.RedBoxMethod();
            Console.WriteLine();


            // test BoxClass fields 
            Console.WriteLine("These are the dimensions of the BoxClass");
            BoxClass bc = new BoxClass(316, 720);
            bc.PrintState();

            // test RedBox print state
            RedBox rb2 = new RedBox(1080, 940, 420);
            rb2.PrintState();
            Console.ReadLine();

            // test RedBox fields 

            //RedBox rb2 = new RedBox(123, 456, 434);
            //rb2.PrintState();
            // Console.ReadLine();

            //GreenBox gb = new GreenBox();

            //gb.GreenBox = "Green";

            //Console.WriteLine("GreenBox is now yellow.", gb.GreenBox);

        }
    }
}
           
        
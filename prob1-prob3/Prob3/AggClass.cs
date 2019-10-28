using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prob3
{
    class AggClass
    {
        private string str;
        private string str2;
        // strings are already a class aka object
        // can create another class

        // consructor 
        public AggClass(string inStr)
        {
            //Composition
            // MyClass own str. str does'nt exist outside of AggClass
            Console.WriteLine("Composition");
            Console.WriteLine();
            str = "This string is showing composition.\n";
            Console.WriteLine("Composition only exists within the class.\n");

            // another class part of AggClass

            // Aggragation 
            // str2 refers to object outside of AggClass
            
            str2 = inStr;

        }

        // creates the print statement for show aggregation and composition 
        public void printState()
        {
            Console.WriteLine("str: {0}", str);
            Console.WriteLine("str2: {0}", str2);
        }
       
    }
}
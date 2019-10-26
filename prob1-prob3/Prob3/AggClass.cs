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
            // MyClass own str. str does'nt exist outside of MyClass
            str = "This string is showing composition. Only exist from within the class.";

            // another class part of AggClass

            // Aggragation 
            // str2 refers to object outside of AggClass
            str2 = inStr;

        }

        public void printState()
        {
            Console.WriteLine("str: {0}", str);
            Console.WriteLine("str2: {0}", str2);
        }

    }
}
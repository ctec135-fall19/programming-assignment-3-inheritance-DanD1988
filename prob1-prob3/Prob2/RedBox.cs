using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prob2
{
    class RedBox : BoxClass
    {
        protected int RedBoxProtectedInt;

        // Constructors 

        public RedBox() { }

        public RedBox (int BoxPrivateInt, int BoxProtectedInt, int RedBoxProtectedInt)
        {
            this.RedBoxProtectedInt = RedBoxProtectedInt;
        }

        // methods 

        public void RedBoxMethod()
        {
            Console.WriteLine("RedBoxClass.RedBoxMethod");
        }

        public override void PrintState()
        {
            Console.WriteLine("RedBox");
            Console.WriteLine("\tRedBoxProtectedInt: {0}", RedBoxProtectedInt);
            base.PrintState();
        }


    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prob2
{
    class RedBox : BoxClass
    {
        // Fields       
        protected int redProtectedInt;

        // Constructors

        public RedBox() { }
        // setting the constructors for the box dimensions
        public RedBox(int boxPrivateIntHeight, int boxProtectedIntWidth, int redProtectedInt)
            : base(boxPrivateIntHeight, boxProtectedIntWidth)
        {
            this.redProtectedInt = redProtectedInt;
        }

        // Methods
        public void RedBoxMethod()
        {
            Console.WriteLine("RedBoxClass.RedBoxMethod");
        }

        public override void PrintState()
        {
            Console.WriteLine("RedBox Object");
            Console.WriteLine("\nredProtectedInt: {0}", redProtectedInt);
            base.PrintState();
        }




    }
}
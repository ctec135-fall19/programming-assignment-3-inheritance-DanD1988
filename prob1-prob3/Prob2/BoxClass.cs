using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prob2
{
    class BoxClass
    {
        // fields
        public string BoxPublicColor;
        private int BoxPrivateHeight;
        protected int BoxProtectedWidth;

        // constructors
        public BoxClass (int Height, int Width, string Color) 
        {
            height = Height;
        }

        public BoxClass (int ProtectedString, int PrivateInt)
        {
            this.BoxPrivateHeight = PrivateInt;
            this.BoxProtectedWidth = ProtectedString;
        }

        // methods 

        public void BoxMethod()
        {
            Console.WriteLine("BoxClass.BoxMethod");
        }

        public virtual void PrintState()
        {
            Console.WriteLine("The Box Object");
            Console.WriteLine("\t PrivateString:{0}", BoxProtectedWidth);
            Console.WriteLine("\t PrivateInt:{0}", BoxPrivateHeight);
        }
    }
}

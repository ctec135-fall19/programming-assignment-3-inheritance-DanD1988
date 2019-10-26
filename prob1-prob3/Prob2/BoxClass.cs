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
        private int boxPrivateIntHeight;
        protected int boxProtectedIntWidth;

        // constructors
        public BoxClass() { }

        public BoxClass(int privateIntHeight, int protectedIntWidth)
        {
            this.boxPrivateIntHeight = privateIntHeight;
            this.boxProtectedIntWidth = protectedIntWidth;
        }

        // methods 

        public void BoxMethod()
        {
            Console.WriteLine("Base.Class.BaseMethod");
        }

        public virtual void PrintState()
        {
            Console.WriteLine("BoxClass Object");
            Console.WriteLine("\tboxPrivateIntHeight:{0} inches", boxPrivateIntHeight);
            Console.WriteLine("\tboxProtectedIntWidth:{0} inches", boxProtectedIntWidth);
        }


    }
}

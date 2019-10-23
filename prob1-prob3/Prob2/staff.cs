using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prob2
{
    class Staff
    {
        private string staffPosition;
        public string Position
        {
            get { return staffPosition; }
            set
            {
                if (value.Length > 10) { staffPosition = value.Substring(0, 10); }
                else staffPosition = value;
            }           
        }

        // Properties
        public int Rating { get; set; }
        public double Pay { get; set; }

        // constructors 
        public Staff(string position, int rating, double pay)
        {
            Position = position;
            Rating = rating;
            Pay = pay;            
        }

        public Staff() : this("", 0, 0.0) { }
        public Staff(string position) : this(position, 0,0.0) { }

        // methods 
        
        public void PrintState()
        {
            Console.WriteLine("Position:\t{0}", Position);
            Console.WriteLine("Rating:\t{0}", Rating);
            Console.WriteLine("Pay:\t{0}", Pay);
        }

    }
}

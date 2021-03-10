using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualNewOverride
{
    // readonly ≈ semi-constant
    public class Person
    {
        string _1stname, _2ndname, _email;
        DateTime _DoB;  
            // Timespan: difference between two time

        // constructors can take in a old instance
        // when equate new instance to old one, doesn't simply copy -- BOTH POINT to the data "block", 
                // ONE updates, TWO refreshes data;

        public Person(string First, string Last, string email, DateTime DoB)
        {
            _1stname = First;
            _2ndname = Last;
            _email = email;
            _DoB = DoB;
        }

        public Person(string first, string last, DateTime dOb)
        {
            _1stname = first;
            _2ndname = last;
            _DoB = dOb;
        }

        public int ComputeAge(DateTime DoB)
        {
            return DateTime.Now;
            
        }

        public bool ConfirmAge(TimeSpan age)
        {
            return false;
        }

        public bool IsOverAge(TimeSpan age)
        {
            return Convert.ToInt32(age) >= 18;
        }
    }
}

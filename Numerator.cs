using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking_Project
{
    class Numerator
    {
        private int customerCounter = 1;
        private long interestAccountCounter = 100000;
        private long nonInterestAccountCounter = 100000;

        private static Numerator numerator;

        private Numerator()
        {

        }

        public int CustomerCounter()
        {
            return customerCounter++;
        }
        
        public long IntrestAccountCounter()
        {
            return interestAccountCounter++;
        }

        public long NonIntrestAccountCounter()
        {
            return nonInterestAccountCounter++;
        }

        public static Numerator GetInstance()
        {
            if (numerator == null)
               numerator = new Numerator();
            
                return numerator;
        }
    }
}

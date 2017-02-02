using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler
{
    public class Eulers
    {
        public Eulers()
        {

        }

        #region Problem 1
        public int MultipleThreeFive()
        {
            int output = 0;

            for (int i = 0; i < 1000; i++)
            {
                if (i % 3 == 0 || i % 5 == 0)
                {
                    output += i;
                }
            }

            return output;
        }
        #endregion

        #region Problem 2 - Fibonacci

        public int Fibbonaci()
        {
            int output = 0;
            int tempA = 0;
            int tempB = 1;
            int tempC = 0;

            while (tempB <= 4000000)
            {
                tempC = tempA + tempB;
                tempA = tempB;
                tempB = tempC;

                if (tempB % 2 == 0)
                {
                    output += tempC;
                }
                
            }
            return output;
        }
        #endregion


    }


}

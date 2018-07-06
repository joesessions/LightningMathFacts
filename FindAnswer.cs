using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LightningMathFacts
{
    class FindAnswer
    {
        public int mathIt(int Arg1, int Oper, int Arg2)
        {
            int output=0;
            if (Oper == 0)
            {
                output = Arg1 + Arg2;
            }
            else if (Oper == 1)
            {
                output = Arg1 - Arg2;
            }
            else if (Oper == 2)
            {
                output = Arg1 * Arg2;
            }
            else if (Oper == 3)
            {
                output = Arg1 / Arg2;
            }
            return output;
        }   
    }
}

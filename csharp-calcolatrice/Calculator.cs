using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_calcolatrice
{
    internal static class Calculator
    {
        public static int IntegerSum(int firstAddend, int secondAddend)
        {
           
                if(firstAddend is Int32 && secondAddend is Int32) 
                    return firstAddend + secondAddend;
                else
                    throw new Exception("Use only Integer");
            
        }
    }
}

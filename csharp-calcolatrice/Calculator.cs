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
            return firstAddend + secondAddend;
        }

        public static double DoubleSum(double firstAddend, double secondAddend)
        {
            return firstAddend + secondAddend;
        }

        public static int IntegerSubtractor(int firstSubtracting, int secondSubtracting)
        {
            return firstSubtracting - secondSubtracting;
        }

        public static double DoubleSubtractor(double firstSubtracting, double secondSubtracting)
        {
            return firstSubtracting - secondSubtracting;
        }

        public static int IntegerMultiplier(int firstMultiply, int secondMultiply)
        {
            return firstMultiply * secondMultiply;
        }

        public static double DoubleMultiplier(double firstMultiply, double secondMultiply)
        {
            return firstMultiply * secondMultiply;
        }
    }
}

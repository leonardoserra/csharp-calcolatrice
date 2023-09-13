using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Generics_csharp_calcolatrice
{
    internal static class Calculator
    { 
        public static T Sum<T>(T firstAddend, T secondAddend) where T : INumber<T>
        {
           return firstAddend + secondAddend;
        }

        public static T Subtractor<T>(T firstSubtracting, T secondSubtracting)where T : INumber<T> 
        {
            return firstSubtracting - secondSubtracting;
        }


        public static T Multiplier<T>(T firstMultiply, T secondMultiply) where T : INumber<T>
        {
            return firstMultiply * secondMultiply;
        }


        public static T AbsoluteValue<T>(T number) where T : INumber<T>
        {
            if (number == default(T))
                return default(T);
            else if (number > default(T))
                return number;
            else
                return -number;
        }

        public static T MinComparator<T>(T firstNumber, T secondNumber)where T: INumber<T>
        {
            if (firstNumber < secondNumber)
                return firstNumber;
            else if (firstNumber == secondNumber)
                return firstNumber;
            else
                return secondNumber;
        }


        public static T MaxComparator<T>(T firstNumber, T secondNumber)where T : INumber<T>
        {
            if (firstNumber > secondNumber)
                return firstNumber;
            else if (firstNumber == secondNumber)
                return firstNumber;
            else
                return secondNumber;
        }

        public static double NumberPower(int baseNumber, int exponent)
        {
            double result = baseNumber;
            if (result == 0 || exponent == 0)
            {
                return 1;
            }
            else if (exponent < 0)
            {
                //converto l'esponente negativo in positivo
                exponent = -exponent;
                for (int i = 1; i < exponent; i++)
                {
                    result *= baseNumber;
                }
                return (double)1 / result;

            }
            else
            {
                for (int i = 1; i < exponent; i++)
                {
                    result *= baseNumber;
                }
            }

            return result;
        }

    }
}

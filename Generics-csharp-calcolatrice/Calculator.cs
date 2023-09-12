﻿using System;
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

        public static int AbsoluteIntValue(int number)
        {
            if (number == 0) 
                return 0;
            else if (number > 0)
                return number;
            else 
                return number += number * (-2);
        }

        public static double AbsoluteDoubleValue(double number)
        {
            if (number == 0)
                return 0;
            else if (number > 0)
                return number;
            else
                return number += number * (-2);
        }

        public static int MinIntComparator(int firstNumber, int secondNumber)
        {
            if (firstNumber < secondNumber)
                return firstNumber;
            else if (firstNumber == secondNumber)
                return firstNumber;
            else
                return secondNumber;
        }

        public static double MinDoubleComparator(double firstNumber, double secondNumber)
        {
            if (firstNumber < secondNumber)
                return firstNumber;
            else if (firstNumber == secondNumber)
                return firstNumber;
            else
                return secondNumber;
        }

        public static int MaxIntComparator(int firstNumber, int secondNumber)
        {
            if (firstNumber > secondNumber)
                return firstNumber;
            else if (firstNumber == secondNumber)
                return firstNumber;
            else
                return secondNumber;
        }

        public static double MaxDoubleComparator(double firstNumber, double secondNumber)
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

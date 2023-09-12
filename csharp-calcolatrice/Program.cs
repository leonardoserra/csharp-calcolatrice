namespace csharp_calcolatrice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine(Calculator.IntegerSum(2, 8));
            Console.WriteLine(Calculator.DoubleSum(2.3, 8));
            Console.WriteLine(Calculator.IntegerSubtractor(2, 8));
            Console.WriteLine(Calculator.DoubleSubtractor(2.3, 8));
            Console.WriteLine(Calculator.IntegerMultiplier(2, 8));
            Console.WriteLine(Calculator.DoubleMultiplier(2.3, 8));
            Console.WriteLine(Calculator.AbsoluteIntValue(2));
            Console.WriteLine(Calculator.AbsoluteIntValue(-2));
            Console.WriteLine(Calculator.AbsoluteIntValue(0));
            Console.WriteLine(Calculator.AbsoluteDoubleValue(2.5));
            Console.WriteLine(Calculator.AbsoluteDoubleValue(-2.7));
            Console.WriteLine(Calculator.AbsoluteDoubleValue(0));


        }
    }
}
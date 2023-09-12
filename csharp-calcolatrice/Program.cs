namespace csharp_calcolatrice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //IL PRINCIPIO CHE RICHIEDE LA CONSEGNA È IL POLIMORFISMO, QUANDO CREI PIU FIRME DIVERSE DELLO STESSO METHOD
            
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
            Console.WriteLine(Calculator.MinIntComparator(3,7));
            Console.WriteLine(Calculator.MinIntComparator(6,6));
            Console.WriteLine(Calculator.MinDoubleComparator(3.8,7.4));
            Console.WriteLine(Calculator.MinDoubleComparator(0.8,0.8));
            Console.WriteLine(Calculator.MaxIntComparator(3, 7));
            Console.WriteLine(Calculator.MaxIntComparator(-3, -3));
            Console.WriteLine(Calculator.MaxDoubleComparator(3.8, 7.4));
            Console.WriteLine(Calculator.MaxDoubleComparator(-8.67, -8.67));


        }
    }
}
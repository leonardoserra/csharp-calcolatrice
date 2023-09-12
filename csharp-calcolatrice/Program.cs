namespace csharp_calcolatrice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //IL PRINCIPIO CHE RICHIEDE LA CONSEGNA È IL POLIMORFISMO, QUANDO CREI PIU FIRME DIVERSE DELLO STESSO METHOD

            
            Console.WriteLine("somma interi");
            Console.WriteLine(Calculator.IntegerSum(2, 8));
            Console.WriteLine();

            Console.WriteLine("somma double");
            Console.WriteLine(Calculator.DoubleSum(2.3, 8));
            Console.WriteLine();

            Console.WriteLine("sottrazione interi");
            Console.WriteLine(Calculator.IntegerSubtractor(2, 8));
            Console.WriteLine();

            Console.WriteLine("sottrazione double");
            Console.WriteLine(Calculator.DoubleSubtractor(2.3, 8));
            Console.WriteLine();

            Console.WriteLine("moltiplicazione interi");
            Console.WriteLine(Calculator.IntegerMultiplier(2, 8));
            Console.WriteLine();

            Console.WriteLine("moltiplicazione double");
            Console.WriteLine(Calculator.DoubleMultiplier(2.3, 8));
            Console.WriteLine();

            Console.WriteLine("valore assoluto intero positivo");
            Console.WriteLine(Calculator.AbsoluteIntValue(2));
            Console.WriteLine();

            Console.WriteLine("valore assoluto intero negativo");
            Console.WriteLine(Calculator.AbsoluteIntValue(-2));
            Console.WriteLine();

            Console.WriteLine("valore assoluto intero 0");
            Console.WriteLine(Calculator.AbsoluteIntValue(0));
            Console.WriteLine();

            Console.WriteLine("valore assoluto double positivo");
            Console.WriteLine(Calculator.AbsoluteDoubleValue(2.5));
            Console.WriteLine();

            Console.WriteLine("valore assoluto double positivo");
            Console.WriteLine(Calculator.AbsoluteDoubleValue(-2.7));
            Console.WriteLine();

            Console.WriteLine("valore assoluto double 0");
            Console.WriteLine(Calculator.AbsoluteDoubleValue(0));
            Console.WriteLine();

            Console.WriteLine("comparatore minoranza interi");
            Console.WriteLine(Calculator.MinIntComparator(3,7));
            Console.WriteLine();

            Console.WriteLine("comparatore minoranza interi uguali");
            Console.WriteLine(Calculator.MinIntComparator(6,6));
            Console.WriteLine();

            Console.WriteLine("comparatore minoranza double");
            Console.WriteLine(Calculator.MinDoubleComparator(3.8,7.4));
            Console.WriteLine();

            Console.WriteLine("comparatore minoranza double uguali");
            Console.WriteLine(Calculator.MinDoubleComparator(0.8,0.8));
            Console.WriteLine();

            Console.WriteLine("comparatore maggioranza interi");
            Console.WriteLine(Calculator.MaxIntComparator(3, 7));
            Console.WriteLine();

            Console.WriteLine("comparatore maggioranza interi uguali");
            Console.WriteLine(Calculator.MaxIntComparator(-3, -3));
            Console.WriteLine();

            Console.WriteLine("scomparatore maggioranza double");
            Console.WriteLine(Calculator.MaxDoubleComparator(3.8, 7.4));
            Console.WriteLine();

            Console.WriteLine("comparatore maggioranza double uguali");
            Console.WriteLine(Calculator.MaxDoubleComparator(-8.67, -8.67));
            Console.WriteLine();


        }
    }
}
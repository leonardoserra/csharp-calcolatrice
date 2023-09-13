namespace Generics_csharp_calcolatrice
{ 
    internal class Program
    {
        
        static void Main(string[] args)
        {
            //Il polimorfismo permette di ridefinire nelle classi derivate. Mentre l'overloading e applicabile unicamente sui membri della classe stessa


            Console.WriteLine("somma interi");
            Console.WriteLine(Calculator.Sum(2, 8));
            Console.WriteLine();

            Console.WriteLine("somma double");
            Console.WriteLine(Calculator.Sum(2.3, 8));
            Console.WriteLine();

            Console.WriteLine("sottrazione interi");
            Console.WriteLine(Calculator.Subtractor(2, 8));
            Console.WriteLine();

            Console.WriteLine("sottrazione double");
            Console.WriteLine(Calculator.Subtractor(2.3, 8));
            Console.WriteLine();

            Console.WriteLine("moltiplicazione interi");
            Console.WriteLine(Calculator.Multiplier(2, 8));
            Console.WriteLine();

            Console.WriteLine("moltiplicazione double");
            Console.WriteLine(Calculator.Multiplier(2.3, 8));
            Console.WriteLine();

            Console.WriteLine("valore assoluto intero positivo");
            Console.WriteLine(Calculator.AbsoluteValue(2));
            Console.WriteLine();

            Console.WriteLine("valore assoluto intero negativo");
            Console.WriteLine(Calculator.AbsoluteValue(-2));
            Console.WriteLine();

            Console.WriteLine("valore assoluto intero 0");
            Console.WriteLine(Calculator.AbsoluteValue(0));
            Console.WriteLine();

            Console.WriteLine("valore assoluto double positivo");
            Console.WriteLine(Calculator.AbsoluteValue(2.5));
            Console.WriteLine();

            Console.WriteLine("valore assoluto double positivo");
            Console.WriteLine(Calculator.AbsoluteValue(-2.7));
            Console.WriteLine();

            Console.WriteLine("valore assoluto double 0");
            Console.WriteLine(Calculator.AbsoluteValue(0));
            Console.WriteLine();

            Console.WriteLine("comparatore minoranza interi");
            Console.WriteLine(Calculator.MinComparator(3,7));
            Console.WriteLine();

            Console.WriteLine("comparatore minoranza interi uguali");
            Console.WriteLine(Calculator.MinComparator(6,6));
            Console.WriteLine();

            Console.WriteLine("comparatore minoranza double");
            Console.WriteLine(Calculator.MinComparator(3.8,7.4));
            Console.WriteLine();

            Console.WriteLine("comparatore minoranza double uguali");
            Console.WriteLine(Calculator.MinComparator(0.8,0.8));
            Console.WriteLine();

            Console.WriteLine("comparatore maggioranza interi");
            Console.WriteLine(Calculator.MaxComparator(3, 7));
            Console.WriteLine();

            Console.WriteLine("comparatore maggioranza interi uguali");
            Console.WriteLine(Calculator.MaxComparator(-3, -3));
            Console.WriteLine();

            Console.WriteLine("scomparatore maggioranza double");
            Console.WriteLine(Calculator.MaxComparator(3.8, 7.4));
            Console.WriteLine();

            Console.WriteLine("comparatore maggioranza double uguali");
            Console.WriteLine(Calculator.MaxComparator(-8.67, -8.67));
            Console.WriteLine();

            Console.WriteLine("BONUS potenza di intero");
            Console.WriteLine(Calculator.NumberPower(6,0));
            Console.WriteLine(Calculator.NumberPower(0,0));
            Console.WriteLine(Calculator.NumberPower(-2,8));
            Console.WriteLine(Calculator.NumberPower(2,3));
            Console.WriteLine(Calculator.NumberPower(2,-3));
            Console.WriteLine();


        }
    }
}
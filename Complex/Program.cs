using System;

namespace Complex
{
    class Program
    {
        static void Main(string[] args)
        {
            Complex[] complex = new Complex[5];
            complex[0] = new Complex(1, 3);
            complex[1] = new Complex(-1);
            complex[2] = Complex.CreateComplex(3, 3 * Math.PI / 4);
            complex[3] = new Complex(-1, 3);
            complex[4] = Complex.CreateComplex(-1,0);

            for (int i = 0; i < complex.Length; i++) {
                Console.WriteLine("{1}) Complex number: {0}", complex[i],i+1);
                Console.WriteLine("Re: {0:0.00}", complex[i].Re);
                Console.WriteLine("Im: {0:0.00}", complex[i].Im);
                Console.WriteLine("Abs: {0:0.00}", complex[i].Abs);
                Console.WriteLine("Arg: " + complex[i].ArgToString());
                Console.WriteLine();
            }

            Console.WriteLine("1 * 3: {0}",complex[0] * complex[2]);
            Console.WriteLine("1 / 3: {0}", complex[0] / complex[2]);
            Console.WriteLine("1 + 4: {0}", complex[0] + complex[3]);
            Console.WriteLine("1 - 4: {0}", complex[0] - complex[3]);

            Console.WriteLine("2 == 5: {0}", complex[1] == complex[4]);
            Console.WriteLine("2 != 4: {0}", complex[1] != complex[3]);
        }
    }
}

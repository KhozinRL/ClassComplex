using System;

namespace Complex
{
    class Program
    {
        static void Main(string[] args)
        {
            Complex c = Complex.CreateComplex(2, Math.PI);
            Console.WriteLine(c);

            double a = (double)c;

            Console.WriteLine(c.GetHashCode());
        }
    }
}

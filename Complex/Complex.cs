using System;
namespace Complex
{
    public class Complex
    {
        double re, im;
        private const double epsilon = 1e-5;
     

        public Complex(double real, double imaginary)
        { 
            Im = imaginary;
            Re = real;
        }

        public Complex(double Re) : this(Re, 0) { }

        public static Complex CreateComplex(double abs, double arg) {
            return new Complex(abs * Math.Cos(arg), abs * Math.Sin(arg));
        }

        public double Im {
            get {
                return im;
            }
            set {
                if (Math.Abs(value) > epsilon)
                {
                    im = value;
                }
                else
                {
                    im = 0;
                }
            }
        }

        public double Re {
            get
            {
                return re;
            }
            set
            {
                if (Math.Abs(value) > epsilon)
                {
                    re = value;
                }
                else {
                    re = 0;
                }
                
            }
        }

        public double Abs {
            get {
                return Math.Sqrt(Math.Pow(Re,2) + Math.Pow(Im,2));
            }
        }

        public double Arg {
            get {
                if (Re > 0)
                {
                    return Math.Atan(Im / Re);
                }
                if (Re < 0) {
                    return Math.Atan(Im / Re) + Math.PI;
                }
                else
                {
                    if (Im > 0)
                    {
                        return 0.5 * Math.PI;
                    }
                    else if (Im < 0)
                    {
                        return -0.5 * Math.PI;
                    }
                    else
                    {
                        return 0;
                    }
                }
                
            }
        }

        public static Complex operator +(Complex a, Complex b) {
            return new Complex(a.Re + b.Re, a.Im + b.Im);
        }

        public static Complex operator -(Complex a, Complex b) {
            return new Complex(a.Re - b.Re, a.Im - b.Im);
        }

        public static Complex operator *(Complex a, Complex b) {
            return new Complex(a.Re * b.Re - a.Im * b.Im, a.Re * b.Im + a.Im * b.Re);
        }

        public static Complex operator /(Complex a, Complex b) {
            Complex conjugate = new Complex(b.Re, -b.Im);

            return new Complex((a * conjugate).Re / Math.Pow(b.Abs, 2), (a * conjugate).Im / Math.Pow(b.Abs, 2));
        }

        public static bool operator ==(Complex a, Complex b) {
            return Math.Abs(a.Re - b.Re) < epsilon && Math.Abs(a.Im - b.Im) < epsilon;
        }

        public static bool operator !=(Complex a, Complex b) {
            return !(a == b);
        }

        public override bool Equals(object obj)
        {
            if (obj is Complex)
            {
                return this == (Complex)obj;
            }

            return false;
        }
        
        public override int GetHashCode()
        {
            return Re.GetHashCode() ^ Im.GetHashCode();
        }

        public static explicit operator double(Complex complex) {
            return complex.Re;
        }

        public static implicit operator Complex(double d) {
            return new Complex(d);
        }

        public override string ToString()
        {
            if (Im.Equals(0))
            {
                return Re.ToString();
            }
            if (Re.Equals(0))
            {
                return Im.ToString() + "i";
            }
            if (Im < 0)
            {
                return Re.ToString() + " - " + Math.Abs(Im).ToString() + "i";
            }
            
            return Re.ToString() + " + " + Im.ToString() + "i";
        }

    }
}

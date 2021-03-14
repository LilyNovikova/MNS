using System;

namespace ShN.Utils
{
    public class Complex
    {
        public double Real { get; private set; }
        public double Imag { get; private set; }

        public Complex()
        {
            Real = 0;
            Imag = 0;
        }

        public Complex(double re, double im)
        {
            Real = re;
            Imag = im;
        }

        public Complex(double re)
        {
            Real = re;
            Imag = 0;
        }

        public static Complex operator +(Complex complex)
        {
            return new Complex(complex.Real, complex.Imag);
        }

        public static Complex operator -(Complex complex)
        {
            return new Complex(-complex.Real, -complex.Imag);
        }

        public double Abs
        {
            get
            {
                return Math.Sqrt(Real * Real + Imag * Imag);
            }
        }
        public double Arg
        {
            get
            {
                return Math.Atan2(Imag, Real);
            }
        }


        // Definitions of non-member binary operator functions

        public static Complex operator +(Complex z1, Complex z2)
        {
            return new Complex(z1.Real + z2.Real, z1.Imag + z2.Imag);
        }

        public static Complex operator +(double doubleValue, Complex complex)
        {
            return new Complex(doubleValue + complex.Real, complex.Imag);
        }

        public static Complex operator +(Complex complex, double doubleValue)
        {
            return doubleValue + complex;
        }

        public static Complex operator -(Complex z1, Complex z2)
        {
            return new Complex(z1.Real - z2.Real, z1.Imag - z2.Imag);
        }

        public static Complex operator -(double doubleValue, Complex complex)
        {
            return new Complex(doubleValue - complex.Real, -complex.Imag);
        }

        public static Complex operator -(Complex complex, double doubleValue)
        {
            return new Complex(complex.Real - doubleValue, complex.Imag);
        }

        public static Complex operator *(Complex z1, Complex z2)  // ins
        {
            return new Complex(z1.Real * z2.Real - z1.Imag * z2.Imag,
                           z1.Real * z2.Imag + z1.Imag * z2.Real);
        }

        public static Complex operator *(Complex complex, double doubleValue)  // ins
        {
            return new Complex(complex.Real * doubleValue, complex.Imag * doubleValue);
        }

        public static Complex operator *(double doubleValue, Complex complex)
        {
            return complex * doubleValue;
        }

        public static Complex operator /(Complex z1, Complex z2)  //ins
        {
            var d = z2.Real * z2.Real + z2.Imag * z2.Imag;
            return new Complex((z1.Real * z2.Real + z1.Imag * z2.Imag) / d,
                           (z1.Imag * z2.Real - z1.Real * z2.Imag) / d);
        }

        public static Complex operator /(double doubleValue, Complex complex)  //ins
        {
            var d = complex.Real * complex.Real + complex.Imag * complex.Imag;
            return new Complex(doubleValue * complex.Real / d, -doubleValue * complex.Imag / d);
        }
        public static Complex operator /(Complex complex, double doubleValue)
        {
            return new Complex(complex.Real / doubleValue, complex.Imag / doubleValue);
        }

        public static bool operator ==(Complex z1, Complex z2)
        {
            return z1.Real == z2.Real && z1.Imag == z2.Imag;
        }

        public static bool operator !=(Complex z1, Complex z2)
        {
            return !(z1 == z2);
        }

        public override string ToString()
        {            
            return Imag == 0 ? Real.ToString() : $"{Real}+{Imag}i";
        }

        public Complex Copy()
        {
            return new Complex(Real, Imag);
        }
    }
}

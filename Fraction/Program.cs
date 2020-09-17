using System;

namespace Fraction
{
    class Fraction
    {
        private int numerator;
        private int denominator;

        public Fraction()
        {
            numerator = 0;
            denominator = 1;
            
        }

        public Fraction(int num, int den)
        {
            int pgcd = PGCD(num, den);
            this.numerator = num / pgcd;
            this.denominator = den / pgcd;
        }

        public static int PGCD(int num, int den)
        {
            int reste = num % den;
            while (reste != 0)
            {
                reste = num % den;
                Console.WriteLine(num + " = " + den + " x " + (num/den) + " + " + reste);
                if (num % den != 0)
                {
                    num = den;
                    den = reste;
                }
                
                
            }

            return den;
        }

        public int Numerator
        {
            get => numerator;
            set => numerator = value;
        }

        public int Denominator
        {
            get => denominator;
            set => denominator = value;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Fraction test = new Fraction(4,2);
            Console.WriteLine("(" + test.Numerator + "," + test.Denominator + ")");
            Console.WriteLine("Hello World!");
            
        }
    }
}
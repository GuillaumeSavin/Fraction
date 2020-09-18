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
                //Console.WriteLine(num + " = " + den + " x " + (num/den) + " + " + reste);
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

        public static Fraction operator +(Fraction fra, Fraction fra2)
        {
            int num = 0;
            int den = 0;
            
            if (fra.denominator == fra2.denominator)
            {
                num = fra.numerator + fra2.numerator;
                den = fra.denominator;
            }
            else
            {
                num = fra.numerator * fra2.denominator + fra2.numerator * fra.denominator;
                den = fra.denominator * fra2.denominator;
            }
            
            return new Fraction(num, den);
        }
        
        public static Fraction operator +(Fraction fra, int integer)
        {
            int num = 0;
            int den = 0;
            
            Fraction fra2 = new Fraction(integer, 1);
            
            if (fra.denominator == fra2.denominator)
            {
                num = fra.numerator + fra2.numerator;
                den = fra.denominator;
            }
            else
            {
                num = fra.numerator * fra2.denominator + fra2.numerator * fra.denominator;
                den = fra.denominator * fra2.denominator;
            }
            
            return new Fraction(num, den);
        }
        
        public static Fraction operator +(int integer, Fraction fra)
        {
            int num = 0;
            int den = 0;
            
            Fraction fra2 = new Fraction(integer, 1);
            
            if (fra.denominator == fra2.denominator)
            {
                num = fra.numerator + fra2.numerator;
                den = fra.denominator;
            }
            else
            {
                num = fra.numerator * fra2.denominator + fra2.numerator * fra.denominator;
                den = fra.denominator * fra2.denominator;
            }
            
            return new Fraction(num, den);
        }

        public override string ToString()
        {
            String str = "";

            str = "(" + this.numerator + ", " + this.denominator + ")";
            
            return str;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Fraction a = new Fraction();
            Console.WriteLine(a);
            Fraction b = new Fraction(2, -6);
            Console.WriteLine(b);
            Fraction c = new Fraction(8, 3);
            a = b + c;
            Console.WriteLine(a);
            a = b + 3;
            Console.WriteLine(a);
            a = 7 + b;
            Console.WriteLine(a);
        }
    }
}
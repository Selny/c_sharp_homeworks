
using System;

namespace hw2
{
    class Program
    {

        class Point 
        {
            public int x, y;

            public Point() 
            {
                x = y = 0;
            }
            public Point(int x, int y)
            {
                this.x = x;
                this.y = y;
            }

            public void ShowData()
            {
                Console.WriteLine($"X: {x}\nY: {y}");
            }
        }

        class Counter 
        {
            public int min, max, currentData;

            public Counter(int min, int max)
            {
                this.min = min;
                this.max = max;
                this.currentData = this.min;
            }

            public void increment()
            {
                if(currentData < max) currentData++;
                else currentData = min;
            }

            public int getCurrentData() => currentData;

        }

        class Fraction 
        {
            public int numerator, denominator;

            public Fraction()
            {
                numerator = denominator = 1;
            }
            public Fraction(int numerator, int denominator)
            {
                this.numerator = numerator;
                this.denominator = (denominator != 0) ? denominator : 1;
            }

            public Fraction sum(Fraction f) 
            {
                Fraction result = new Fraction();
                result.denominator = this.denominator * f.denominator;
                result.numerator = this.numerator * f.denominator + f.numerator * this.denominator;
                return Simplify(ref result);
            }

            public Fraction minus(Fraction f) 
            {
                Fraction result = new Fraction();
                result.denominator = this.denominator * f.denominator;
                result.numerator = this.numerator * f.denominator - f.numerator * this.denominator;
                return Simplify(ref result);
            }

            public Fraction multiply(Fraction f) 
            {
                Fraction result = new Fraction();
                result.denominator = this.denominator * f.denominator;
                result.numerator = this.numerator * f.numerator;
                return Simplify(ref result);
            }

            public Fraction divide(Fraction f) 
            {
                if (f.numerator == 0) 
                {
                    Console.WriteLine("Undefined fraction");
                    return f;
                }
                Fraction result = new Fraction();
                result.denominator = this.denominator * f.numerator;
                result.numerator = this.numerator * f.denominator;
                return Simplify(ref result);
            }

            public Fraction Simplify(ref Fraction f) 
            {
                //System.Console.WriteLine(f.numerator);
                //System.Console.WriteLine(f.denominator);
                int divider = (f.numerator > f.denominator) ? f.denominator : f.numerator;
                if (f.numerator < 0 && f.denominator < 0)
                {
                    f.numerator = f.numerator * - 1;
                    f.denominator = f.denominator * - 1;
                }
                while (f.numerator % divider != 0 || f.denominator % divider != 0) 
                {
                    if(f.numerator > 0 && f.denominator > 0) divider--;
                    else divider++;
                    if (divider == 0) return f;
                }

                f.numerator = f.numerator / divider;
                f.denominator = f.denominator / divider;

                return f;
            }

            public void PrintValue()
            {
                if (numerator == denominator) Console.WriteLine(1);
                else if (denominator == 1) Console.WriteLine(numerator);
                else Console.WriteLine($"{numerator}/{denominator}");
            }
            
        }

        static void Main(string[] args)
        {
            //Task 1
            Point p = new Point();
            p.ShowData();

            //Task 2
            Counter c = new Counter(0, 100);
            c.increment();
            Console.WriteLine(c.getCurrentData());
            c.increment();
            Console.WriteLine(c.getCurrentData());

            //Task 3
            Fraction a = new Fraction(4, 5);
            Fraction b = new Fraction(5, 4);

            (a.sum(b)).PrintValue();
            (a.minus(b)).PrintValue();
            (a.multiply(b)).PrintValue();
            (a.divide(b)).PrintValue();
        }
    }
}

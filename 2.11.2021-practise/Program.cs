using System;

namespace _2._11._2021_practise
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Task 1
            //MyClass myclass1 = new MyClass
            //{
            //    arr = new int[] { 1, -3, 5, 2, -4, 6, 0 }
            //};
            //myclass1.GetCounts();
            #endregion

            #region Task 2
            //Console.WriteLine(getSeason(1));
            #endregion

            #region Task 3
            MyMath myMath = new MyMath();
            Console.WriteLine("Add(20, 10) = " + myMath.Add(20, 10));
            Console.WriteLine("Add(20.2, 10.3) = " + myMath.Add(20.2, 10.3));
            Console.WriteLine("Subtract(20, 10) = " + myMath.Subtract(20, 10));
            Console.WriteLine("Subtract(20.5, 10.0) = " + myMath.Subtract(20.5, 10.0));
            Console.WriteLine("Divide(20, 10) = " + myMath.Divide(20, 10));
            Console.WriteLine("Divide(25.0, 2.5) = " + myMath.Divide(25.0, 2.5));
            Console.WriteLine("Multiple(20, 10) = " + myMath.Multiple(20, 10));
            Console.WriteLine("Multiple(2.04, 10) = " + myMath.Multiple(2.04, 10));
            Console.WriteLine("Calculate(20, '+', 30) = " + myMath.Calculate(20, '+', 30));
            Console.WriteLine("Calculate(20.2, '+', 20.3) = " + myMath.Calculate(20.2, '+', 20.3));
            Console.WriteLine("Calculate(20, '-', 10) = " + myMath.Calculate(20, '-', 10));
            Console.WriteLine("Calculate(20.5, '-', 10) = " + myMath.Calculate(20.5, '-', 10));
            Console.WriteLine("Calculate(2, '*', 10) = " + myMath.Calculate(2, '*', 10));
            Console.WriteLine("Calculate(2.04, '*', 10) = " + myMath.Calculate(2.04, '*', 10));
            Console.WriteLine("Calculate(20, '/', 5) = " + myMath.Calculate(20, '/', 5));
            Console.WriteLine("Calculate(25.5, '/', 5) = " + myMath.Calculate(25.5, '/', 5));
            Console.WriteLine("Calculate(29, '%', 5) = " + myMath.Calculate(29, '%', 5));
            Console.WriteLine("Calculate(29.0, '%', 5.5) = " + myMath.Calculate(29.0, '%', 5.5));
            #endregion
        }

        static string getSeason(int month)
        {

            if (month == 12 || month < 3)
            {
                return "Winter";
            }
            else if (month < 6)
            {
                return "Spring";
            }
            else if (month < 9)
            {
                return "Summer";
            }
            else if (month < 12)
            {
                return "Autumn";
            }
            else
            {
                return "Undefined";
            }
        }
    }
}

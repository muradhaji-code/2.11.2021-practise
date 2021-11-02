using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._11._2021_practise
{
    class MyMath
    {
        public int Add(int x, int y)
        {
            return x + y;
        }
        public double Add(double x, double y)
        {
            return x + y;
        }
        public int Subtract(int x, int y)
        {
            return x - y;
        }
        public double Subtract(double x, double y)
        {
            return x - y;
        }
        public double Divide(int x, int y)
        {
            return x / y;
        }
        public double Divide(double x, double y)
        {
            return x / y;
        }
        public int Multiple(int x, int y)
        {
            return x * y;
        }
        public double Multiple(double x, double y)
        {
            return x * y;
        }
        public dynamic Calculate(int x, char operand, int y)
        {
            switch (operand)
            {
                case '+':
                    return x + y;
                case '-':
                    return x - y;
                case '*':
                    return x * y;
                case '/':
                    return x / y;
                case '%':
                    return x % y;
                default:
                    return 0;
            }
        }
        public dynamic Calculate(double x, char operand, double y)
        {
            switch (operand)
            {
                case '+':
                    return x + y;
                case '-':
                    return x - y;
                case '*':
                    return x * y;
                case '/':
                    return x / y;
                case '%':
                    return x % y;
                default:
                    return 0;
            }
        }
    }
}

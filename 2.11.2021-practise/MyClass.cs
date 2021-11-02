using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._11._2021_practise
{
    class MyClass
    {
        public int[] arr;

        public void GetCounts()
        {
            int pos = 0, neg = 0, zero = 0;
            foreach (int x in this.arr)
            {
                if (x > 0)
                {
                    pos++;
                }
                else if (x < 0)
                {
                    neg++;
                }
                else
                {
                    zero++;
                }
            }
            Console.WriteLine($"Positive: {pos}, Negative: {neg}, Zero: {zero}");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumNumbers.Calculators
{
    public static class SumCalculator
    {
        public static List<int> Sum(List<int> num1, List<int> num2)
        {
            var result = new List<int>();

            num2.Reverse();

            for (var i = 0; i < num1.Count(); i++)
            {
                var n1 = GetValue(num1, i);
                var n2 = GetValue(num2, i);

                result.Add(n1 + n2);
            }

            return result;
        }

        private static int GetValue(List<int> array, int index)
        {
            if (index >= array.Count())
            {
                return 0;
            }
            else
            {
                return array[index];
            }
        }
    }
}

using SumNumbers.Calculators;
using SumNumbers.Parsers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumNumbers
{
    public class Program
    {
		public static void Main()
        {
            List<int> num1 = new List<int> { 1, 2, 3, 4, 5, 6 };
            List<int> num2 = new List<int> { 1, 2, 3, 4, 5, 6 };

            var result = SumCalculator.Sum(num1, num2);

            Console.WriteLine(result.ToInt());

            Console.ReadKey();
        }
	}
}

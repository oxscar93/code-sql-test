using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumNumbers.Parsers
{
    public static class NumSetParser
    {
        public static long ToInt(this List<int> numberSet)
        {
            var result = string.Empty;

            foreach (var item in numberSet)
            {
                result += item.ToString();
            }

            return Convert.ToInt64(result);
        }
    }
}

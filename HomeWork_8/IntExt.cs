using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_8
{
    public static class IntExt
    {
        public static int ArrMaxValue(this int[] i)
        {
            if (i.Length == 0) { Console.WriteLine("Array is empty"); return 0; }
            else
            {
                int max = i[0];
                foreach (int j in i)
                {
                    if ( j > max)
                        max = j;
                }
                return max;
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            const int MAX_NUMBERS_IN_ARRAY = 10;
            int[] numbers = new int[MAX_NUMBERS_IN_ARRAY];

            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = i;
            }
            string[,] names = new string[4, 3];
            names[0, 0] = "";

            var maxIndexOfRow = names.GetUpperBound(0);
            DateTime[][] dates = new DateTime[6][];
            dates[0] = new DateTime[15];
            dates[0][0] = DateTime.Now;
        }
    }
}

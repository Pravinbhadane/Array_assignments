using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_assign
{
    public class Max_Min_Number
    {
        static void Main(string[] args)
        {
            int[] array = new int[8];
            Console.WriteLine("Enter Array Elements");
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = Convert.ToInt32(Console.ReadLine());
            }

            int max = int.MinValue;  int min= int.MaxValue;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > max)
                {
                    max = array[i];
                }

                if (array[i] < min)
                {
                    min = array[i];
                }

            }
            Console.WriteLine($"Maximum Number is = {max}\nMinimum Number is = {min}");

        }
    }
}

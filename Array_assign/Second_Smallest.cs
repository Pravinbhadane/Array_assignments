using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_assign
{
    public class Second_Smallest
    {
        static void Main(string[] args)
        {
            int[] array = new int[8];
            Console.WriteLine("Enter Array Elements");

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = Convert.ToInt32(Console.ReadLine());
            }

            int smallest = int.MaxValue; int secondSmallest= int.MaxValue;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < smallest)
                {
                    smallest = array[i];
                }
                else if (array[i]< secondSmallest)
                {
                    secondSmallest = array[i];
                }
            }

        
            Console.WriteLine($"Second Smallest Value is  = {secondSmallest} sm {smallest}");

        }
    }
}

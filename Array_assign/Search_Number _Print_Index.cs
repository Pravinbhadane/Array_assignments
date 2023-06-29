using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_assign
{
    public class Search_Number__Print_Index
    {
        static void Main(string[] args)
        {

            int[] array = new int[] { 1, 2, 3, 4, 5, 6, 7, 8 };

            //Console.WriteLine("Enter Array Elements");
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    arr[i] = Convert.ToInt32(Console.ReadLine());
            //}

            //Console.WriteLine("Enter number to search");
            //int number = Convert.ToInt32(Console.ReadLine());

            int number = 4;

                for (int i = 0; i < array.Length; i++)
                {
                    if (array[i] == number)
                    {
                        Console.WriteLine($"Present At Index = {i}");
                        return;
                    }


                }
                Console.WriteLine("Number is not exist in the array");

           
        }
    }
}

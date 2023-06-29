using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_assign
{
    public class Merge_2Arrays
    {
        static void Main(string[] args)
        {
            int[] array = new int[5];
            Console.WriteLine("Enter 1st Array Elements");
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = Convert.ToInt32(Console.ReadLine());
            }

            int[] array2 = new int[5];
            Console.WriteLine("Enter 2nd Array Elements");
            for (int i = 0; i < array2.Length; i++)
            {
                array2[i] = Convert.ToInt32(Console.ReadLine());
            }
            int len = array.Length + array2.Length;

            int[] mergeArr = new int[len];
            int k = 0;

            for (int i = 0; i < array.Length; i++)
            {
                if (mergeArr.Contains(array[i])==false )
                {
                    mergeArr[k++] = array[i];
                }
            }

            for (int i = 0; i < array2.Length; i++)
            {
                if (mergeArr.Contains(array2[i]) == false)
                {
                    mergeArr[k++] = array2[i];
                }
            }

            foreach (var item in mergeArr)
            {
                Console.Write(item+" ");
            }
            Console.WriteLine();

        }
    }
}

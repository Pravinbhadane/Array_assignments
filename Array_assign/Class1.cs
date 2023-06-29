using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_assign
{
    public class Class1
    {
        static void Main(string[] args)
        {
            int[] array = new int[8];
            Console.WriteLine("Enter Array Elements");
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = Convert.ToInt32(Console.ReadLine());
            }
           

            int[]odd = new int[8];
            int[]even = new int[8];

            int j = 0; int k = 0;

            for (int i = 0; i < array.Length; i++)
            {
                if(array[i] % 2 == 0)
                {
                    even[j++]= array[i] ;
                }
                else
                {
                    odd[k++]= array[i] ;
                }
            }
            
            foreach (var item in even)
            {
                Console.Write(item);
            }
            Console.WriteLine();

            foreach (var item in odd)
            {
                Console.Write(item);
            }
            Console.WriteLine();
        }
    }
}

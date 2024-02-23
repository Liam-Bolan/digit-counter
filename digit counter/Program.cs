using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace digit_counter
{
    internal class Program
    {
        static int[] data = { 2, 5, 9, 5, 6, 7, 1, 3, 4, 6, 6, 6, 2, 9 };
        static void Main(string[] args)
        {

            int biggest = 0;

            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= biggest)
                {
                    biggest = data[i];

                }

            }
            for (int j = 1; j <= biggest; j++)
            {
                
            }

            
            Console.ReadLine();
        }
        
    }
}
            



        
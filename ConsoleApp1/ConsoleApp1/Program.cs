using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Balas(new int[]{ 5,7,9,13,45});
            Console.ReadLine();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="arr">arreyde verilanlari reverse etmak</param>
        static void Balas(int[] arr)
        {
            for (int i = arr.Length-1; i >= 0; i--)
            {
                Console.WriteLine(arr[i]);
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShellSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 5, 8, 6, 0, 9, 2, 4, 3, 5, 1 };
            ShellSort(arr);
            foreach (var item in arr)
                Console.WriteLine(item);
            Console.ReadLine();
        }
        static void ShellSort(int[] arr)
        {
            for (int i = arr.Length / 2; i > 0; i = i / 2)
            {            
                for (int k = i; k < arr.Length; k++)
                {
                    for (int j = k; j > 0; j--)
                    {
                        if (arr[j] < arr[j - 1])
                        {
                            (arr[j], arr[j - 1]) = (arr[j - 1], arr[j]);
                        }
                        else
                        {
                            break;
                        }
                    }
                }

            }
        }
    }
}

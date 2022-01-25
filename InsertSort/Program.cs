using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsertSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 9, 8, 7, 4, 6, 99, 5, 1, 3, 0 };

            InsertSort(arr);
            foreach (var item in arr)
            {
                Console.WriteLine(item + " ");
            }

            Console.ReadLine();
        }

        static void InsertSort(int[] arr)
        {
            //for循环先拿出数组中的第二条数据
            //因为要与前边的数据进行对比所以取第二条开始比较
            for (int i = 1; i < arr.Length; i++)
            {
                //拿第一层for循环拿到的数据
                //对他前边的所有数据进行比较
                for (int j = i; j > 0; j--)
                {
                    //如果前边的数据比它大，则交换两条数据的位置
                    if (arr[j] < arr[j - 1])
                    {
                        (arr[j], arr[j - 1]) = (arr[j - 1], arr[j]);
                    }
                    else//如果前边的数据比他小或者是和他相等，则不需要移动交换数据，跳出for循环
                        //让他与前边的其他元素进行比较
                    {
                        break;
                    }
                }
            }
        }
    }
}

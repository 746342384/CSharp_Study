using System;

namespace SelectSort
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] arr = { 5, 8, 6, 0, 9, 2, 4, 3, 5, 1 };
            SelectSort(arr);

            foreach (var item in arr)
            {
                Console.WriteLine(item);
            }

            Console.ReadLine();
        }
        static void SelectSort(int[] arr)
        {
            for (int i = 0; i < arr.Length - 1; i++)
            {
                //首先需要获取到最小值
                int minIndex = i;
                //从第二个值开始遍历
                for (int j = i + 1; j < arr.Length; j++)
                {
                    //拿下一个值跟最小值作比较，记录最小值索引
                    if (arr[j] < arr[minIndex])
                    {
                        minIndex = j;
                    }
                }
                //一轮比较之后，最小值的索引已经得到，然后进行数据的交换
                (arr[i], arr[minIndex]) = (arr[minIndex], arr[i]);
            }
        }
    }
}

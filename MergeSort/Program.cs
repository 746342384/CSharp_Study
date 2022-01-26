using System;

namespace MergeSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 4, 5, 3, 2, 1, 7, 6, 9, 8, 10 };
            MergeSort(arr, 0, arr.Length - 1);

            foreach (var item in arr)
            {
                Console.WriteLine(item);
            }

            Console.ReadLine();
        }
        static void MergeSort(int[] arr, int f, int e)
        {
            if (f < e)
            {
                int middle = (e + f) / 2;
                MergeSort(arr, f, middle);
                MergeSort(arr, middle + 1, e);
                MergeMethod(arr, f, middle, e);
                string str = "";
                foreach (var item in arr)
                {
                    str += item + " ";

                }
                Console.WriteLine(str);
            }
        }

        static void MergeMethod(int[] arr, int f, int m, int e)
        {
            //先申请空间，存储临时归并过的数据
            int[] tempArr = new int[e - f + 1];
            //从前后两个子序列的第一个元素开始比较
            //需要同时满足，前后两个序列的自增索引始终要小于子序列的末尾索引
            int fIndex = f, eIndex = m + 1, k = 0;
            while (eIndex <= e && fIndex <= m)
            {
                //既然满足了循环的条件，则从两个子序列的第一个元素开始相互比较
                if (arr[fIndex] > arr[eIndex])
                {
                    //将小的一个放到临时数组的前边，大的放后边
                    tempArr[k++] = arr[eIndex++];
                }
                else
                {
                    //否则反之
                    tempArr[k++] = arr[fIndex++];
                }
            }
            //当归并比较循环结束后，若还有没有比较的元素直接赋值到零时数组的末尾
            //使用两个while循环分别检查前后两个序列，是哪一个还有剩余的元素
            while (fIndex < m + 1)
            {
                tempArr[k++] = arr[fIndex++];
            }
            while (eIndex < e + 1)
            {
                tempArr[k++] = arr[eIndex++];
            }
            //将剩余的元素复制到临时数组之后，在将零时数组的值移动到原数组中
            for (k = 0, fIndex = f; fIndex < e + 1; k++, fIndex++)
            {
                arr[fIndex] = tempArr[k];
            }

        }
    }
}

using System;

namespace QuickSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 9, 8, 7, 4, 6, 99, 5, 1, 3, 0 };
            QuickSort(arr, 0, arr.Length - 1);
            foreach (var item in arr)
            {
                Console.WriteLine(item + " ");
            }
            Console.ReadLine();

        }
        static int GetPrivot(int[] arr, int left, int right)
        {
            //选择左边第一个值作为Privot,也可拿右边，也可随意选取数组中的某一条数据作为Privot
            int privot = arr[left];
            //使用while进行数据的比较>移动>完成划分
            //while循环满足left=right时即左右下标相遇，数组划分完成
            while (left < right)
            {
                //如果右标识大于Privot，则不需要移动，将右边标识下标自减，让其与下一个数值进行对比
                //如果对比数值比privot小时，则需要将该值移动到privot的左边，即可以用交换数据的位置来完成数据的移动
                while (left < right && arr[right] >= privot) right--;
                //此处与Swap()功能相同，即数据的交换
                (arr[right], arr[left]) = (arr[left], arr[right]);
                //完成右边数据的比较之后，则需要进行左边的数据移动
                while (left < right && arr[left] <= privot) left++;
                (arr[left], arr[right]) = (arr[right], arr[left]);

            }
            //整个循环结束之后，返回left的下标，即privot的下标
            return left;
        }

        static void QuickSort(int[] arr, int left, int right)
        {
            //此处开始数组的排序，首先需要获取到Privot，同时将原数组划分为两个区域
            //即privot左边都要小于Privot的值，右边反之
            if (left < right)
            {
                int privot = GetPrivot(arr, left, right);
                //划分完成之后，递归，将左右两边按照Getprivot的方法进行区域的划分
                //递归到没有元素进行移动时，即完成排序
                QuickSort(arr, privot + 1, right);
                QuickSort(arr, left, privot - 1);
            }
        }
    }
}

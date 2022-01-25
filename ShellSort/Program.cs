using System;

namespace ShellSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = RandomFloat(0, 1000000, 100000);
            DateTime beforDT = System.DateTime.Now;
            ShellSort(arr);
            DateTime afterDT = System.DateTime.Now;
            TimeSpan ts = afterDT.Subtract(beforDT);
            Console.WriteLine("DateTime总共花费{0}s.", ts.TotalSeconds);


            foreach (var item in arr)
                Console.WriteLine(item);

            Console.ReadLine();
        }

        static void ShellSort(int[] arr)
        {
            //第一次取其一半作为递减增量，后续取上一次递减增量的一半
            for (int i = arr.Length / 2; i > 0; i /= 2)
            {
                //使用插入排序，对使用递减增量划分之后的序列进行排序
                for (int k = i; k < arr.Length; k++)
                {
                    //声明零时变量用来存储当前用于和其他数值比较的数值
                    int temp = arr[k];
                    //循环于之前的相距递减增量间隔的数值进行对比，大于之前不交换数据
                    for (int j = k; j > i; j -= i)
                    {
                        if (temp < arr[j - i])
                            (arr[j], arr[j - i]) = (arr[j - i], arr[j]);
                        else
                            break;

                    }

                }

            }
        }
        static int[] RandomFloat(int minValue, int maxValue, int num)
        {
            int[] arrNum = new int[num];

            float tmp = 0;
            Random r = new Random();
            for (int i = 0; i <= num - 1; i++)
            {
                tmp = r.Next(minValue, maxValue);
                arrNum[i] = (int)tmp;
            }
            return arrNum;
        }
    }
}

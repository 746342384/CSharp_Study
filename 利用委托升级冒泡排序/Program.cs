using System;

namespace 利用委托升级冒泡排序
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 1, 3, 56, 7, 23, 5, 9 };
            Sort(array);
            for (int i = 0; i < array.Length - 1; i++)
                Console.WriteLine(array[i]);

            Employee[] employees = {
                new Employee("张三",20),
                new Employee("李四",30),
                new Employee("王麻子",10)
            };
            Sort<Employee>(employees, Employee.CompareSalary);
            foreach (var item in employees)
                Console.WriteLine(item.Name + ":" + item.Salary);

            Console.ReadLine();
        }

        /// <summary>
        /// 冒泡排序
        /// </summary>
        /// <param name="sortArray"></param>
        private static void Sort(int[] sortArray)
        {
            bool swapped;
            do
            {
                swapped = false;
                for (int i = 0; i < sortArray.Length - 1; i++)
                {
                    if (sortArray[i] > sortArray[i + 1])
                    {
                        int temp = sortArray[i];
                        sortArray[i] = sortArray[i + 1];
                        sortArray[i + 1] = temp;
                        swapped = true;
                    }
                }

            } while (swapped);
        }
        private static void Sort<T>(T[] data, Func<T, T, bool> compare)
        {
            bool swapped;
            do
            {
                swapped = false;
                for (int i = 0; i < data.Length - 1; i++)
                {
                    if (compare(data[i], data[i + 1]))
                    {
                        T temp = data[i];
                        data[i] = data[i + 1];
                        data[i + 1] = temp;
                        swapped = true;
                    }
                }

            } while (swapped);
        }
    }
}

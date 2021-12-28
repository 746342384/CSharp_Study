namespace 利用委托升级冒泡排序
{
    internal class Employee
    {
        public Employee(string name, double salary)
        {
            Name = name;
            Salary = salary;
        }

        public string Name { get; private set; }
        public double Salary { get; private set; }


        public static bool CompareSalary(Employee e1, Employee e2)
        {
            return e1.Salary > e2.Salary;
        }

    }
}

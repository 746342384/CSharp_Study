using System;
using System.Text.RegularExpressions;

namespace 正则表达式
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var str1 = "23432n";
            var str2 = "234234";
            // Console.WriteLine( Regex.IsMatch(str1, @"\d\d\d\d\d\d"));
            // Console.WriteLine( Regex.IsMatch(str2, @"\d\d\d\d\d\d"));
            // Console.WriteLine( Regex.IsMatch(str1, @"\d*"));
            // Console.WriteLine( Regex.IsMatch(str1, @"^\d*$"));
            // Console.WriteLine( Regex.IsMatch(str2, @"^\d*$"));
            // \d数字
            // \w 大小写字母 0-9 _
            // Console.WriteLine( Regex.IsMatch(str1, @"^\w*$"));
            // Console.WriteLine( Regex.IsMatch(str2, @"^\w*$"));
            // Console.WriteLine(Regex.IsMatch("a",@"[abcd]"));
            // Console.WriteLine(Regex.IsMatch("e",@"[abcd]"));
            // Console.WriteLine(Regex.IsMatch("e",@"[a-gx-z]"));
            // Console.WriteLine(Regex.IsMatch("h",@"[A-H]"));
            // Console.WriteLine(Regex.IsMatch("h",@"[^A-H]"));
            //是否是合法标识符
            // string re = @"^[a-zA-Z]\w*$";
            // Console.WriteLine(Regex.IsMatch("abcd",re));
            // Console.WriteLine(Regex.IsMatch("2sdf",re));
            // Console.WriteLine(Regex.IsMatch("sdfsd4sdf",re));
            // Console.WriteLine(Regex.IsMatch("_sdfadsf",re));
            // Console.WriteLine(Regex.IsMatch("_2sdfsdf",re));
            // Console.WriteLine(Regex.IsMatch("_2sdfsd3",re));
        }
    }
}
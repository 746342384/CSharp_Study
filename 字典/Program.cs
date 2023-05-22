using MyDictionary;

var dict = new MyDictionary<int, string>();
dict.Add(1, "1");
var str = dict.Get(1);

Console.WriteLine(str);

Console.ReadLine();
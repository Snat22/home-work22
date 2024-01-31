List<int> spisok8 = new List<int>(){1,2,3,4,5,56,6,6,7,10};
foreach (var i in spisok8)
{
    System.Console.Write(i+" ");
}
System.Console.WriteLine();
System.Console.Write($"MAX ELEMENT LIST: {spisok8.Max()}");
System.Console.WriteLine();
System.Console.Write($"MIN ELEMENT LIST: {spisok8.Min()}");
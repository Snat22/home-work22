List<string> spisok9 = new List<string> (){"Alisson","Bekijon","Sayf","Iso","Leo","Tom"};
System.Console.WriteLine("LIST BEFOR: ");
System.Console.WriteLine();
foreach (var it in spisok9)
{
    System.Console.WriteLine(it);
}

System.Console.WriteLine();
System.Console.WriteLine("LIST AFTER: ");
spisok9.RemoveAll(e=> e.Length <= 3);
foreach (var i in spisok9)
{
    System.Console.WriteLine(i);
}
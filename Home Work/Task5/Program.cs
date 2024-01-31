List<string> spisok5 = new List<string> (){"Salomon","Maqsad","Bemaqsad","Umed","Noumed","Sayfullo","Iskandar"};
System.Console.WriteLine("List befor: ");
System.Console.WriteLine();
foreach (var i in spisok5)
{
    System.Console.WriteLine(i);
}

System.Console.WriteLine();
System.Console.WriteLine("List After: ");
var reng = spisok5.GetRange(1,4);
foreach (var it in reng)
{
    System.Console.WriteLine(it);
}
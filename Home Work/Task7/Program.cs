List<string> spisok7 = new List<string>(){"Salmon","Sulaymon","Maruf","Husayn"};
System.Console.WriteLine("List befor:");
System.Console.WriteLine("<--------------->");
foreach (var i in spisok7)
{
    System.Console.WriteLine(i);
}
System.Console.WriteLine();
System.Console.WriteLine("List After:");
spisok7.Clear();
foreach (var it in spisok7)
{
    System.Console.WriteLine(it);
}
System.Console.WriteLine("<------------->");
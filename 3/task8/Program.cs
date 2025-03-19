Console.WriteLine("ВВедите строку");
string input = Console.ReadLine();

string output = System.Text.RegularExpressions.Regex.Replace(input, @"\s+", "_").ToLower();
Console.WriteLine(output);
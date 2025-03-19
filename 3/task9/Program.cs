using System.Text;

Console.WriteLine("1 строка:");
StringBuilder sb = new StringBuilder(Console.ReadLine());

Console.WriteLine("2 строка:");
string insertString = Console.ReadLine();
int middleIndex = sb.Length / 2;

sb.Insert(middleIndex, insertString);
Console.Write(sb);
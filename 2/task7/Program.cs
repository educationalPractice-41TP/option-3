using task7;

class Program
{
    static void Main(string[] args)
    {
        WeightConverter converter = new WeightConverter();

        converter.PrintTableUsingWhile();
        converter.PrintTableUsingDoWhile();
        converter.PrintTableUsingFor();
    }
}
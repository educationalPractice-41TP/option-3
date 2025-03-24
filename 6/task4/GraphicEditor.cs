using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task4
{
public class GraphicEditor : IDraw, IPaint
{
    // Явная реализация метода ApplyColor для интерфейса IDraw
    void IDraw.ApplyColor(string color)
    {
        Console.WriteLine($"Drawing with color: {color}");
    }

    // Явная реализация метода ApplyColor для интерфейса IPaint
    void IPaint.ApplyColor(string color)
    {
        Console.WriteLine($"Painting with color: {color}");
    }
}
}

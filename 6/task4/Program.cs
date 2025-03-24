using System;
using task4;

class Program
{
    static void Main(string[] args)
    {
        GraphicEditor editor = new GraphicEditor();

        IDraw drawInterface = editor;
        IPaint paintInterface = editor;

        drawInterface.ApplyColor("Красный");
        paintInterface.ApplyColor("Синий");
    }
}
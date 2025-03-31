namespace task3
{
    public class TextEditor
    {
        private string _text = "";

        public void Copy()
        {
            Console.WriteLine("Текст скопирован: " + _text);
        }

        public void Paste(string text)
        {
            _text += text;
            Console.WriteLine("Текст вставлен: " + text);
        }

        public void Undo()
        {
            Console.WriteLine("Последнее действие отменено.");
        }

        public void Redo()
        {
            Console.WriteLine("Последнее действие повторено.");
        }

        public void SetText(string text)
        {
            _text = text;
        }

        public string GetText()
        {
            return _text;
        }
    }
}

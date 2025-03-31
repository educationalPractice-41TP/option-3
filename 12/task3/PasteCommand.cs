namespace task3
{
    public class PasteCommand : ICommand
    {
        private TextEditor _textEditor;
        private string _textToPaste;

        public PasteCommand(TextEditor textEditor, string textToPaste)
        {
            _textEditor = textEditor;
            _textToPaste = textToPaste;
        }

        public void Execute()
        {
            _textEditor.Paste(_textToPaste);
        }

        public void Undo()
        {
            Console.WriteLine("Отмена команды вставки: " + _textToPaste);
        }
    }
}

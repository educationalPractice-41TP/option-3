namespace task3
{
    public class CopyCommand : ICommand
    {
        private TextEditor _textEditor;

        public CopyCommand(TextEditor textEditor)
        {
            _textEditor = textEditor;
        }

        public void Execute()
        {
            _textEditor.Copy();
        }

        public void Undo()
        {
            Console.WriteLine("Отмена команды копирования.");
        }
    }
}

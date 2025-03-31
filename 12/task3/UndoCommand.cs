namespace task3
{
    public class UndoCommand : ICommand
    {
        private TextEditor _textEditor;

        public UndoCommand(TextEditor textEditor)
        {
            _textEditor = textEditor;
        }

        public void Execute()
        {
            _textEditor.Undo();
        }

        public void Undo()
        {
            Console.WriteLine("Отмена команды отмены.");
        }
    }
}

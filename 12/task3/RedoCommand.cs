namespace task3
{
    public class RedoCommand : ICommand
    {
        private TextEditor _textEditor;

        public RedoCommand(TextEditor textEditor)
        {
            _textEditor = textEditor;
        }

        public void Execute()
        {
            _textEditor.Redo();
        }

        public void Undo()
        {
            Console.WriteLine("Отмена команды повтора.");
        }
    }
}

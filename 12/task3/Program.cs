using task3;

public class Program
{
    public static void Main(string[] args)
    {
        TextEditor editor = new TextEditor();
        editor.SetText("Hello, World!");

        EditorInvoker invoker = new EditorInvoker();

        // Копирование текста
        ICommand copyCommand = new CopyCommand(editor);
        invoker.SetCommand(copyCommand);
        invoker.ExecuteCommand();

        // Вставка текста
        ICommand pasteCommand = new PasteCommand(editor, "Это тест");
        invoker.SetCommand(pasteCommand);
        invoker.ExecuteCommand();

        // Отмена последнего действия
        ICommand undoCommand = new UndoCommand(editor);
        invoker.SetCommand(undoCommand);
        invoker.ExecuteCommand();

        // Повтор последнего действия
        ICommand redoCommand = new RedoCommand(editor);
        invoker.SetCommand(redoCommand);
        invoker.ExecuteCommand();
    }
}
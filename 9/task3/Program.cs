using task3;

public class Program
{
    public static void Main()
    {
        SettingsStorage<string> settingsStorage = new SettingsStorage<string>();

        SettingsManager<string> settingsManager = new SettingsManager<string>(settingsStorage);

        settingsStorage.Set("Тема", "Темная");
        settingsStorage.Set("Язык", "Русский");
        settingsStorage.Set("Размер шрифта", "14");

        settingsManager.ShowAllSettings();
        settingsManager.RemoveSetting("Язык");
        settingsManager.ShowAllSettings();
    }
}
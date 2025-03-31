using task2;

public class Program
{
    public static void Main(string[] args)
    {
        // Создаем базовое оружие
        IWeapon weapon = new BasicWeapon();
        Console.WriteLine($"{weapon.GetDescription()}, Урон: {weapon.GetDamage()}");

        // Добавляем огненное улучшение
        weapon = new FireEnhancementDecorator(weapon);
        Console.WriteLine($"{weapon.GetDescription()}, Урон: {weapon.GetDamage()}");

        // Добавляем ледяное улучшение
        weapon = new IceEnhancementDecorator(weapon);
        Console.WriteLine($"{weapon.GetDescription()}, Урон: {weapon.GetDamage()}");

        // Добавляем критическое улучшение
        weapon = new CriticalHitDecorator(weapon);
        Console.WriteLine($"{weapon.GetDescription()}, Урон: {weapon.GetDamage()}");
    }
}
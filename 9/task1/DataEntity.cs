namespace task1
{
public class DataEntity
{
    public int Id { get; set; }
    public string Name { get; set; }

    public DataEntity(int id, string name)
    {
        Id = id;
        Name = name;
    }

    public override string ToString()
    {
        return $"ID: {Id}, Имя: {Name}";
    }
}
}

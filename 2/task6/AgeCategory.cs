namespace task6
{
    class AgeCategory
    {
        public int Age { get; set; }

        public AgeCategory(int age)
        {
            Age = age;
        }

        public string GetCategory()
        {
            switch (Age)
            {
                case int n when (n < 1):
                    return "младенец";
                case int n when (n >= 1 && n <= 11):
                    return "ребенок";
                case int n when (n >= 12 && n <= 15):
                    return "подросток";
                case int n when (n >= 16 && n <= 25):
                    return "юноша";
                case int n when (n >= 26 && n <= 70):
                    return "мужчина";
                default:
                    return "старик";
            }
        }
    }
}

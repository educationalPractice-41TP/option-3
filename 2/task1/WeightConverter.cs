namespace task1
{
    class WeightConverter
    {
        public double Kilograms { get; set; }

        public WeightConverter(double kilograms)
        {
            Kilograms = kilograms;
        }

        public int GetFullTons()
        {
            return (int)(Kilograms / 1000);
        }
    }
}

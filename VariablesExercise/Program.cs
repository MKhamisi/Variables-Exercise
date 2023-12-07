namespace VariablesExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            string dogName = "Swabby";
            int dogAge = 14;
            char initial = 'M';
            bool playful = true;
            double dbNum = 5.33;
            decimal dcNum = 6.5m;

            Console.WriteLine($"My dog {dogName} {initial}, was {dogAge} years old when he died");
            Console.WriteLine($"It is {playful} that he was a playful dog in as much as he looked fierce");
            Console.WriteLine($"Double value is {dbNum} whereas decimal value is {dcNum})");
        }
    }
}

namespace h2task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float topCap = 5;
            float bottomCap = -5;

            Console.WriteLine($"Enter a number between {topCap} and {bottomCap}");
            float firstNumber = float.Parse(Console.ReadLine());
            Console.WriteLine($"Enter a number between {topCap} and {bottomCap}");
            float secondNumber = float.Parse(Console.ReadLine());
            Console.WriteLine($"Enter a number between {topCap} and {bottomCap}");
            float thirdNumber = float.Parse(Console.ReadLine());

            if (firstNumber <= topCap && secondNumber <= topCap && thirdNumber <= topCap 
                && firstNumber >= bottomCap && secondNumber >= bottomCap && thirdNumber >= bottomCap) 
            {
                Console.WriteLine($"The numbers are in range of {topCap} to {bottomCap}");
            }
            else
            {
                Console.WriteLine("The numbers are not in range");
            }
            
        }
    }
}
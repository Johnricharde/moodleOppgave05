internal class Program
{
    private static void Main(string[] args)
    {
        static void ReturnsNothingness()
        {
            Console.WriteLine("Denne metoden returnerer absolutt ingenting!");
        }

        ReturnsNothingness();
        Console.ReadKey();
    }
}
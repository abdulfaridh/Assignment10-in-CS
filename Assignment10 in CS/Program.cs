// See https://aka.ms/new-console-template for more information
class Assignment10
{
    static void Main()
    {
        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine("Multiplication Table for " + i + ":");
            for (int j = 1; j <= 10; j++)
            {
                Console.WriteLine(i + " x " + j + " = " + (i * j));
            }
            Console.WriteLine(); 
        }
    }
}

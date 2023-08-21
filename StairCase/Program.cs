namespace StairCase // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PrintStaircase(20);
        }
        static void PrintStaircase(int size)
        {
            for (int i = 1; i <= size; i++)
            {
                // Print spaces
                for (int j = 0; j < size - i; j++)
                {
                    Console.Write(" ");
                }

                // Print #
                for (int k = 0; k < i; k++)
                {
                    Console.Write("#");
                }

                Console.WriteLine(); // Move to the next line
            }
        }
    }
}
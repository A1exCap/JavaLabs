namespace JavaLabs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // First Exercise

            double y;
            Console.WriteLine("First table:");
            for (int x = -5; x <= 5; x++)
            {
                y = Math.Sqrt(Math.Pow(x, 2) + 2 * x - 1);

                if (double.IsNaN(y))
                {
                    Console.WriteLine($"value : {x} result: Exception: Negative number can't be under sqrt");
                }
                else
                {
                    y = Math.Sqrt(Math.Pow(x, 2) + 2 * x - 1);
                    Console.WriteLine($"value : {x} result: {y}");
                }
            }
            Console.WriteLine();
            Console.WriteLine("Second table:");
            for (int x = 10; x <= 20; x += 2)
            {
                if (x > 15)
                {
                    y = 4 * Math.Pow(x, 2) + 7 * x;
                }
                else
                {
                    y = Math.Log(x + 2);

                }
                Console.WriteLine($"value: {x} result: {y}");
            }

            // Second Exercise
            Console.WriteLine();
            Console.WriteLine("Array: ");
            int[,] A = new int[10, 10];
            Random rand = new Random();

            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    A[i, j] = rand.Next(-100, 100);
                    Console.Write(A[i, j] + "\t");
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            long multiply = 1;
            long maxOfMultiplied = 0;

            for (int i = 0; i < 10; i++)
            {
                multiply = 1;
                for (int j = 0; j < 10; j++)
                {
                    if (A[i, j] > 0)
                    {
                        multiply *= A[i, j];
                    }
                }
                if (multiply > maxOfMultiplied)
                {
                    maxOfMultiplied = multiply;
                }
                Console.WriteLine($"Multiplied result of all positive numbers of {i + 1} row : {multiply}");
            }

            Console.WriteLine($"Maximum of multiplied positive numbers from each row: {maxOfMultiplied}");
        }
    }
}

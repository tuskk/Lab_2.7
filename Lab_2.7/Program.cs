using System;
namespace Lab_2._7
{
    public class Executor
    {
        private double a;
        private double b;
        private double c;
        private double d;

        public Executor(double a, double b, double c, double d)
        {
            this.a = a;
            this.b = b;
            this.c = c;
            this.d = d;
        }

        public double CalculateExpression()
        {
            double result = 0;

            if ((41 - d) >= 0)
            {
                double denominator = Math.Sqrt(41 - d) - b * a + c;

                if (denominator != 0)
                {
                    result = (a * b / 4 - 1) / denominator;
                }
                else
                {
                    Console.WriteLine("Error: Division by zero");
                }
            }
            else
            {
                Console.WriteLine("Error: Arithmetic exception");
            }

            return result;
        }
    }

    public class Program
    {
        public static void Main()
        {
            int Repline;
            do
            {
                Console.Write("Enter the number of objects: ");
                int numObjects = Convert.ToInt32(Console.ReadLine());

                Executor[] executors = new Executor[numObjects];

                for (int i = 0; i < numObjects; i++)
                {
                    Console.WriteLine($"\nEnter information for Executor {i + 1}:");

                    Console.Write("a: ");
                    double a = Convert.ToDouble(Console.ReadLine());

                    Console.Write("b: ");
                    double b = Convert.ToDouble(Console.ReadLine());

                    Console.Write("c: ");
                    double c = Convert.ToDouble(Console.ReadLine());

                    Console.Write("d: ");
                    double d = Convert.ToDouble(Console.ReadLine());

                    executors[i] = new Executor(a, b, c, d);
                }

                Console.WriteLine("\nResults:");

                for (int i = 0; i < numObjects; i++)
                {
                    double result = executors[i].CalculateExpression();

                    if (result != 0)
                    {
                        Console.WriteLine($"Executor {i + 1}: {result:F2}");
                    }
                }
                Console.WriteLine("Repeat?(1 = yes,0 = no)");
                Repline = int.Parse(Console.ReadLine());
            } while (Repline == 1 & Repline != 0);
            Console.ReadKey();
        }

    }
}

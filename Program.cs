using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите значение для бетта:");
        string betaInput = Console.ReadLine();

        if (!double.TryParse(betaInput, out double beta) || beta == 0)
        {
            Console.WriteLine("Неправильный формат или значение бетта равно нулю.");
            return;
        }

        double numerator = 1 + Math.Pow(Math.Sin(beta), 2);
        double numerator2 = Math.Cos(2 * beta);

        if (numerator2 == 0)
        {
            Console.WriteLine("Знаменатель равен нулю, деление на ноль невозможно.");
        }
        else
        {
            double result = numerator / numerator2;
            Console.WriteLine($"Значение Z = {result}");
            Console.ReadKey();
        }
    }
}


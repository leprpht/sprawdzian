namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Rozpoczynam sprawdzian)");
            Zadanie_5_6();
            Console.WriteLine("Kończę sprawdzian.");
        }

        static void Zadanie_1()
        {
            Console.WriteLine("Rozpoczynam zadanie 1");
            int a = 11;
            int b = 123;
            while (b >= a)
            {
                Console.WriteLine(b / 3);
                b--;
            }

            Console.WriteLine("Kończę zadanie 1");
        }
        static void Zadanie_2()
        {
            Console.WriteLine("Rozpoczynam zadanie 2");
            PrintTriangle(10);
            Console.WriteLine("Kończę zadanie 2");
        }
        static void Zadanie_3()
        {
            Console.WriteLine("Rozpoczynam zadanie 3");
            DateTime today = DateTime.Now;
            string finalText;
            if (DateTime.Now.Hour <= 12)
                finalText = $"Dzień dobry, dzisiaj {DateTime.Now.DayOfWeek}, czyli {(int)DateTime.Now.DayOfWeek} dzień tygodnia";
            else
                finalText = $"Dobry wieczór, dzisiaj {DateTime.Now.DayOfWeek}, czyli {(int)DateTime.Now.DayOfWeek} dzień tygodnia";
            Console.WriteLine(finalText);
            Console.WriteLine("Kończę zadanie 3");
        }
        static void Zadanie_4()
        {
            Console.WriteLine("Rozpoczynam zadanie 4");
            double[] numbers = { 1.5, -2.22, 4.56, -7, 8.01, 0.0 };

            FindMaxAbsoluteValue(numbers);
            Console.WriteLine("The MAX value = " + FindMaxAbsoluteValue(numbers));
            Console.WriteLine("Kończę zadanie 4");
        }
        static void Zadanie_5_6()
        {
            Console.WriteLine("Rozpoczynam pętlę.");
            Console.WriteLine("Podaj numer zadania od 1 do 4, które mam wyświetlić.");
            int n;
            while (true)
            {
                try
                {
                    n = int.Parse(Console.ReadLine());
                    if (n == 0)
                        break;
                    if (n == 1)
                        Zadanie_1();
                    if (n == 2)
                        Zadanie_2();
                    if (n == 3)
                        Zadanie_3();
                    if (n == 4)
                        Zadanie_4();
                    if (n > 4 || n < 0)
                    {
                        throw new ArgumentOutOfRangeException("Nie ma takiego zadania, wybierz ponownie.");
                        break;
                    }
                        
                }
                catch (Exception e)
                {
                    Console.WriteLine("Numer nie został wprowadzony. Czy chcesz spróbować ponownie?");
                    Console.WriteLine(e.ToString());
                }
            }



            Console.WriteLine("Kończę pętlę.");
        }
        static void PrintTriangle(int x)
        {
            int x2 = x - 1;
            int symbolNumber = 1;
            for (int i = 0; i <x; i++)
            {
                for (int j = 0; j < x2; j++)
                    Console.Write(" ");
                x2--;
                for (int k = 0; k < symbolNumber; k++)
                {
                    Console.Write("$");
                }
                symbolNumber = symbolNumber + 2;
                Console.WriteLine();
            }
        }
        static double FindMaxAbsoluteValue(double[] numbers)
        {
            double maxAbsolute;
            if (numbers[0] < 0)
                maxAbsolute = -1 * numbers[0];
            else
                maxAbsolute = numbers[0];
            int n = numbers.Length;
            for (int i = 1; i < n; i++)
            {
                if (numbers[i] < 0)
                    numbers[i] = -1 * numbers[i];
                if (numbers[i] > maxAbsolute)
                    maxAbsolute = numbers[i];
            }
            return maxAbsolute;
        }
}

}
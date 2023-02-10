using System;
using System.Text;
using System.IO;
using System.Runtime.InteropServices;

class Work
{
    public static void Tabl()
    {
        Console.WriteLine("Таблица значиний функций.");
        Console.WriteLine();
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine("F1 = 5-3*cos(x)       F2 = √(1 + sin^2(x))");
        int a = 0;
        int n = 20;
        double[] mas1 = new double[n];
        double[] mas2 = new double[n];
        double[] xx = new double[n];
        double pi = Math.PI;
        double b = 2 * pi;
        double d = (b - a) / (n - 1);
        double x = a;
        double max1 = 0;
        double max2 = 0;
        Console.ResetColor();
        Console.WriteLine(" _______________________________");
        Console.WriteLine("| i \t| x \t| F1 \t| F2 \t|");
        for (int i = 1; i <= n; i++)
        {
            double F1 = 5 - 3 * Math.Cos(x);
            double F2 = Math.Sqrt(1 + Math.Pow(Math.Sin(x), 2));
            if (F1 > max1)
            {
                max1 = F1;
            }
            if (F2 > max2)
            {
                max2 = F2;
            }
            mas1[i - 1] = F1;
            mas2[i - 1] = F2;
            xx[i - 1] = x;
            Console.WriteLine("|-------|-------|-------|-------|");
            Console.WriteLine("| {0} \t| {1} \t| {2} \t| {3} \t|", i, Math.Round(x, 2), Math.Round(F1, 2), Math.Round(F2, 2));
            x += d;
        }
        Console.WriteLine("|_______|_______|_______|_______|");
        Console.WriteLine();
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine($"Максимальное значение F1 = {Math.Round(max1, 2)}");
        Console.WriteLine($"Максимальное значение F2 = {Math.Round(max2, 2)}");
        Console.ForegroundColor = ConsoleColor.DarkGreen;
        Console.WriteLine();
        Console.Write("Для выхода в меню нажмите enter . . .");
    }


    public static double f(double x)
    {
        double l = Math.Exp(2 * x) * Math.Sin(2 * x);
        return l;
    }
    static void Prim()
    {
        int n = 100000;
        Console.Write("Введите начало отрезка: ");
        double a = int.Parse(Console.ReadLine());
        Console.Write("Введите конец отрезка: ");
        double b = int.Parse(Console.ReadLine());
        double h = (b - a) / n;
        double x = a;
        double sm = 0;
        while (x < b)
        {
            sm += h * f(x);
            x += h;
        }
        Console.WriteLine("Интеграл = {0}", Math.Round(sm, 3));
    }


    public static double foo(double x)
    {
        double l = Math.Exp(2 * x) * Math.Sin(2 * x);
        return l;
    }
    static void Trap()
    {
        int n = 100000;
        Console.Write("Введите начало отрезка: ");
        double a = int.Parse(Console.ReadLine());
        Console.Write("Введите конец отрезка: ");
        double b = int.Parse(Console.ReadLine());
        double h = (b - a) / n;
        double x = a;
        double sm = 0;
        while (x < b)
        {
            sm += h * ((foo(x) + foo(x - h)) / 2);
            x += h;
        }
        Console.WriteLine("Интеграл = {0}", Math.Round(sm, 3));
        Console.WriteLine();
    }

    public static void Fio()
    {
        Console.WriteLine("Об авторе:");
        Console.WriteLine();
        Console.WriteLine("Работу выполнил студент 1-ого курса группы МО-221");
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine("Мусияк Егор Алексеевич");
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine();
        Console.Write("Для выхода в меню нажмите enter . . .");
    }
    public static void Koren()
    {
        Console.WriteLine("Этот модуль еще в разработке");
        Console.Write("");
    }

    static void Main()
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("ff");
            Console.Clear();
            Console.WriteLine("Меню РГР");
            Console.WriteLine("1. Значение определенного интеграла");
            Console.WriteLine("2. Таблица значений функций");
            Console.WriteLine("3. Поиск корня на промежутке");
            Console.WriteLine("4. Об авторе");
            Console.Write("");
            int v = int.Parse(Console.ReadLine());
            Console.Clear();
            if (v == 1)
            {

                while (true)
                {

                    Console.WriteLine("Вычисление интеграла");
                    Console.WriteLine();
                    Console.WriteLine("1. Методом трапеций");
                    Console.WriteLine("2. Методом прямоугольников");
                    Console.WriteLine("3. Выход в меню");
                    Console.Write("");
                    int o = int.Parse(Console.ReadLine());
                    if (o == 2)
                    {
                        Console.Clear();
                        Prim();
                        Console.Write("Чтобы вернуться назад - enter");
                        string ii = Console.ReadLine();
                        ii += "g";
                        Console.Clear();
                    }
                    if (o == 1)
                    {
                        Console.Clear();
                        Trap();
                        Console.Write("Чтобы вернуться назад - enter");
                        string ii = Console.ReadLine();
                        ii += "g";
                        Console.Clear();


                    }
                    if (o == 3)
                    {
                        Console.Clear();
                        break;
                    }
                }

            }
            if (v == 2)
            {
                Console.Clear();
                Tabl();
                string g = Console.ReadLine();
                g += "";
                Console.Clear();
                Console.ResetColor();
                Console.Clear();

            }
            if (v == 4)
            {
                Console.Clear();
                Fio();
                string ji = Console.ReadLine();
                ji += "g";
                Console.ResetColor();
                Console.Clear();
            }
            if (v == 3)
            {
                Console.Clear();
                Koren();
                string bb = Console.ReadLine();
                Console.Clear();

            }
            Console.Clear();
        }

    }
}
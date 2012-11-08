using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalkaOznaczona
{
    class Program
    {
        enum MetodyCalkowania { Prostokatow = 1, Trapezow = 2 }
        static void Main(string[] args)
        {
            double a=0, b=1;
            uint n=10;

            MetodyCalkowania metoda = MetodyCalkowania.Prostokatow;

            Console.BufferHeight = 40;
            Console.WindowHeight =          //wysokość okna
                Console.BufferHeight < Console.LargestWindowHeight ? Console.BufferHeight : Console.LargestWindowHeight;
            Console.BufferWidth = 80;
            Console.WindowWidth =           //szerokość okna
                Console.BufferWidth < Console.LargestWindowWidth ? Console.BufferWidth : Console.LargestWindowWidth;

            char c;
            do
            {
                Console.BackgroundColor = ConsoleColor.Blue;
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.Clear();
                Console.CursorLeft = Console.WindowWidth / 2 - 16;
                Console.CursorTop = Console.WindowHeight / 2 - 16;
                Console.WriteLine("Program obliczający całkę oznaczoną");
                Console.CursorLeft = Console.WindowWidth / 2 - 16;
                Console.CursorTop = Console.WindowHeight / 2 - 14;
                Console.WriteLine("z funkcji nieujemnej i całkowalnej.");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.CursorLeft = Console.WindowWidth / 2 - 33;
                Console.CursorTop = Console.WindowHeight / 2 - 7;
                Console.WriteLine("Przedział całkowania: <{0}; {1}>", a, b);
                Console.CursorLeft = Console.WindowWidth / 2 - 33;
                Console.CursorTop = Console.WindowHeight / 2 - 5;
                Console.WriteLine("Liczba podziałów: {0}", n);
                Console.CursorLeft = Console.WindowWidth / 2 - 33;
                Console.CursorTop = Console.WindowHeight / 2 - 3;
                Console.WriteLine("Metoda całkowania: {0}", metoda);
                Console.SetCursorPosition(Console.WindowWidth / 2 - 33, Console.WindowHeight / 2);
                Console.WriteLine("_________________________________________________________________");
                Console.CursorLeft = Console.WindowWidth / 2 - 33;
                Console.CursorTop = Console.WindowHeight / 2 + 4;
                Console.WriteLine("MENU");
                Console.CursorLeft = Console.WindowWidth / 2 - 10;
                Console.CursorTop = Console.WindowHeight / 2 + 4;
                Console.WriteLine("A - Zmiana przedziału");
                Console.CursorLeft = Console.WindowWidth / 2 - 10;
                Console.CursorTop = Console.WindowHeight / 2 + 6;
                Console.WriteLine("B - Zmiana liczby podziałów");
                Console.CursorLeft = Console.WindowWidth / 2 - 10;
                Console.CursorTop = Console.WindowHeight / 2 + 8;
                Console.WriteLine("C - Zmiana metody całkowania");
                Console.CursorLeft = Console.WindowWidth / 2 - 10;
                Console.CursorTop = Console.WindowHeight / 2 + 10;
                Console.WriteLine("D - Policz całkę");
                Console.CursorLeft = Console.WindowWidth / 2 - 10;
                Console.CursorTop = Console.WindowHeight / 2 + 12;
                Console.WriteLine("K - Koniec");


                c = Console.ReadKey(true).KeyChar;

                switch (c)
                {
                    case 'a':
                    case 'A':
                        do
                        {
                            Console.BackgroundColor = ConsoleColor.DarkGreen;
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.Clear();
                            Console.SetCursorPosition(Console.WindowWidth / 2 - 33, Console.WindowHeight / 2 - 15);
                            Console.WriteLine("Obecny przedział całkowania: <{0}; {1}>", a, b);
                            Console.SetCursorPosition(Console.WindowWidth / 2 - 33, Console.WindowHeight / 2 - 13);
                            Console.WriteLine("_________________________________________________________________");
                            if (a > b)
                            {
                                Console.SetCursorPosition(Console.WindowWidth / 2 - 23, Console.WindowHeight / 2 + 5);
                                Console.WriteLine("Przedział musi zaczynać się liczbą mniejszą");
                            }
                            Console.SetCursorPosition(Console.WindowWidth / 2 - 33, Console.WindowHeight / 2 - 10);
                            Console.WriteLine("Wprowadź początek przedziału");
                            Console.SetCursorPosition(Console.WindowWidth / 2 + 2, Console.WindowHeight / 2 - 10);
                            a = Convert.ToDouble(Console.ReadLine());
                            Console.SetCursorPosition(Console.WindowWidth / 2 - 33, Console.WindowHeight / 2 - 7);
                            Console.WriteLine("Wprowadź koniec przedziału");
                            Console.SetCursorPosition(Console.WindowWidth / 2 + 2, Console.WindowHeight / 2 - 7);
                            b = Convert.ToDouble(Console.ReadLine());
                        }
                        while (a > b);
                        break;
                    case 'b':
                    case 'B':
                        Console.BackgroundColor = ConsoleColor.DarkRed;
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Clear();
                        Console.SetCursorPosition(Console.WindowWidth / 2 - 33, Console.WindowHeight / 2 - 15);
                        Console.WriteLine("Obecna liczba podziałów: {0}", n);
                        Console.SetCursorPosition(Console.WindowWidth / 2 - 33, Console.WindowHeight / 2 - 13);
                        Console.WriteLine("_________________________________________________________________");
                        Console.SetCursorPosition(Console.WindowWidth / 2 - 33, Console.WindowHeight / 2 - 10);
                        Console.WriteLine("Wprowadź liczbę podziałów");
                        Console.SetCursorPosition(Console.WindowWidth / 2 + 2, Console.WindowHeight / 2 - 10);
                        n = Convert.ToUInt32(Console.ReadLine());
                        if (n == 0)
                        {
                            Console.SetCursorPosition(Console.WindowWidth / 2 - 23, Console.WindowHeight / 2 + 5);
                            throw new Exception("Liczba podziałów musi być większa od zera.");
                        }
                        break;

                    case 'c':
                    case 'C':
                        int m = 1;
                        do
                        {
                            Console.BackgroundColor = ConsoleColor.DarkRed;
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.Clear();
                            Console.SetCursorPosition(Console.WindowWidth / 2 - 33, Console.WindowHeight / 2 - 15);
                            Console.WriteLine("Obecna metoda całkowania: {0}", metoda);
                            Console.SetCursorPosition(Console.WindowWidth / 2 - 33, Console.WindowHeight / 2 - 13);
                            Console.WriteLine("_________________________________________________________________");
                            if (m != 1)
                            {
                                Console.SetCursorPosition(Console.WindowWidth / 2 - 33, Console.WindowHeight / 2 - 10);
                                Console.WriteLine("Wybierz metodę całkowania - wciśnij 1 lub 2");
                            }
                            Console.SetCursorPosition(Console.WindowWidth / 2 - 20, Console.WindowHeight / 2 - 7);
                            Console.WriteLine("1 - metoda prostokątów");
                            Console.SetCursorPosition(Console.WindowWidth / 2 - 20, Console.WindowHeight / 2 - 4);
                            Console.WriteLine("2 - metoda trapezów");
                            Console.SetCursorPosition(Console.WindowWidth / 2 - 20, Console.WindowHeight / 2 - 1);
                            m = Convert.ToUInt16(Console.ReadLine());
                        }
                        while (!(m == 1 || m == 2));
                        metoda = (MetodyCalkowania)m;
                        break;


                    case 'd':
                    case 'D':
                        double suma = 0;
                        double dx = (b - a) / n;
                        double x = a;
                        switch (metoda)
                        {
                            case MetodyCalkowania.Prostokatow:
                                for (int i = 0; i < n; i++)
                                {
                                    x += dx;
                                    suma += x * x * x * (x + 1) + 2;
                                }
                                suma *= dx;
                                break;
                            case MetodyCalkowania.Trapezow:
                                for (int i = 1; i < n; i++)
                                {
                                    x += dx;
                                    suma += x * x * x * (x + 1) + 2;
                                }
                                suma += (a * a * a * (a + 1) + b * b * b * (b + 1) + 4) / 2;
                                suma *= dx;
                                break;
                        }
                        Console.Clear();
                        Console.SetCursorPosition(Console.WindowWidth / 2 - 25, Console.WindowHeight / 2 - 15);
                        Console.Write("Przybliżona wartość całki funkcji f(x)");
                        Console.SetCursorPosition(Console.WindowWidth / 2 - 25, Console.WindowHeight / 2 - 12);
                        Console.Write("w przedziale <{0}; {1}> wynosi: {2}", a, b, suma);
                        Console.ReadKey(true);
                        break;
                }
            }

            while (!(c == 'K' || c == 'k'));

                        
        
            }

}
}

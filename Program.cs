﻿using System;

namespace kalkjulejta
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Witaj w kalkulatorze!");
            Console.WriteLine("Co chcesz zrobić? Wybierz jedną z opcji:");
            Console.WriteLine("1. Dodawanie");
            Console.WriteLine("2. Odejmowanie");
            Console.WriteLine("3. Mnożenie");
            Console.WriteLine("4. Dzielenie");
            Console.WriteLine("5. Potęgowanie");
            Console.WriteLine("6. Pierwiastkowanie");
            Console.WriteLine("7. Funkcje trygoniggeryczna");
            Console.WriteLine("8. Wyjście");

            string option = Console.ReadLine();

            switch (option)
            {
                case "1":
                    Suma();
                    break;
                case "2":
                    Różnica();
                    break;
                case "3":
                    Iloczyn();
                    break;
                case "4":
                    Iloraz();
                    break;
                case "5":
                    Potęga();
                    break;
                case "6":
                    Pierwiastek();
                    break;
                case "7":
                    funTryg():
                    break;
                case "8":
                    Wyjscie();
                    break;
                default:
                    Console.WriteLine("Nieprawidłowa opcja. Spróbuj ponownie.");
                    break;
            }
        }

        static void Suma()
        {
            Console.WriteLine("Podaj pierwszą liczbę:");
            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Podaj drugą liczbę:");
            double num2 = Convert.ToDouble(Console.ReadLine());

            double sum = num1 + num2;
            Console.WriteLine("Suma: " + sum);
        }

        static void Różnica()
        {
            Console.WriteLine("Podaj pierwszą liczbę:");
            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Podaj drugą liczbę:");
            double num2 = Convert.ToDouble(Console.ReadLine());

            double difference = num1 - num2;
            Console.WriteLine("Różnica: " + difference);
        }

        static void Iloczyn()
        {
            Console.WriteLine("Podaj pierwszą liczbę:");
            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Podaj drugą liczbę:");
            double num2 = Convert.ToDouble(Console.ReadLine());

            double product = num1 * num2;
            Console.WriteLine("Iloczyn: " + product);
        }

        static void Iloraz()
        {
            Console.WriteLine("Podaj pierwszą liczbę:");
            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Podaj drugą liczbę:");
            double num2 = Convert.ToDouble(Console.ReadLine());

            double quotient = num1 / num2;
            Console.WriteLine("Iloraz: " + quotient);
        }

        static void Potęga()
        {
            Console.WriteLine("Podaj podstawę:");
            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Podaj wykładnik:");
            double num2 = Convert.ToDouble(Console.ReadLine());

            double power = Math.Pow(num1, num2);
            Console.WriteLine("Potęga: " + power);
        }

        static void Pierwiastek()
        {
            Console.WriteLine("Podaj liczbę:");
            double num = Convert.ToDouble(Console.ReadLine());

            double root = Math.Sqrt(num);
            Console.WriteLine("Pierwiastek: " + root);
        }

        static void funTryg()
        {
            Console.WriteLine("Podaj kąt w stopniach:");
            double angle = Convert.ToDouble(Console.ReadLine());

            double sin = Math.Sin(angle);
            double cos = Math.Cos(angle);
            double tan = Math.Tan(angle);

            Console.WriteLine("Sin: " + sin);
            Console.WriteLine("Cos: " + cos);
            Console.WriteLine("Tan: " + tan);
        }

        static void Wyjscie()
        {
            Console.WriteLine("Do widzenia!");
            Environment.Exit(0);
        }
    }
}
﻿using System;

class Program
{
    static void Main()
    {
        while (true)
        {
            Console.WriteLine("Введите значение, которое хотите перевести в другую единицу измерения: ");

            double value;
            if (double.TryParse(Console.ReadLine(), out value))
            {
                Console.Write("Введите единицу измерения (кг - килограммы, г - граммы, км - киллометры, м - метры): ");

                string UnitsOfMeasurement = Console.ReadLine();
                switch (UnitsOfMeasurement)
                {
                    case "кг":
                        Console.WriteLine("Во что переводить? (1 - граммы, 2 - миллиграммы, 3 - микрограммы)");

                        ConsoleKey choice = Console.ReadKey(true).Key;

                        switch (choice)
                        {
                            case ConsoleKey.D1:
                                Console.WriteLine($"{value} кг =  {value *= 1000} гр.");
                                break;
                            case ConsoleKey.D2:
                                Console.WriteLine($"{value} кг =  {value *= 1000000} миллигр.");
                                break;
                            case ConsoleKey.D3:
                                Console.WriteLine($"{value} кг =  {value *= 1000000000} микрогр.");
                                break;
                            default:
                                Console.WriteLine("Некорректный ввод!\nХотите продолжить? (Y/N)");

                                while (true)
                                {
                                    ConsoleKey choice2 = Console.ReadKey(true).Key;
                                    switch (choice2)
                                    {
                                        case ConsoleKey.Y:
                                            break;
                                        case ConsoleKey.N:
                                            return;
                                        default:
                                            Console.WriteLine("Некорректный ввод");
                                            continue;
                                    }
                                    continue;
                                }
                        }
                        break;

                    case "г":
                        Console.WriteLine("Во что переводить? (1 - киллограммы, 2 - миллиграммы, 3 - микрограммы)");

                        ConsoleKey Key = Console.ReadKey(true).Key;

                        switch (Key)
                        {
                            case ConsoleKey.D1:
                                Console.WriteLine($"{value} гр =  {value /= 1000} кг.");
                                break;
                            case ConsoleKey.D2:
                                Console.WriteLine($"{value} гр =  {value *= 1000} млг.");
                                break;
                            case ConsoleKey.D3:
                                Console.WriteLine($"{value} гр =  {value *= 1000000} мкг.");
                                break;
                            default:
                                Console.WriteLine("Некорректный ввод!\nХотите продолжить? (Y/N)");

                                while (true)
                                {
                                    ConsoleKey choice2 = Console.ReadKey(true).Key;
                                    switch (choice2)
                                    {
                                        case ConsoleKey.Y:
                                            break;
                                        case ConsoleKey.N:
                                            return;
                                        default:
                                            Console.WriteLine("Некорректный ввод");
                                            continue;
                                    }
                                    continue;
                                }
                        }
                        break;

                    case "км":
                        Console.WriteLine("Во что переводить? (1 - метры, 2 - миллиметры, 3 - микрометры)");

                        ConsoleKey key = Console.ReadKey(true).Key;

                        switch (key)
                        {
                            case ConsoleKey.D1:
                                Console.WriteLine($"{value} км =  {value *= 1000} м.");
                                break;
                            case ConsoleKey.D2:
                                Console.WriteLine($"{value} км =  {value *= 1000000} млм.");
                                break;
                            case ConsoleKey.D3:
                                Console.WriteLine($"{value} км =  {value *= 1000000000} мкм.");
                                break;
                            default:
                                Console.WriteLine("Некорректный ввод!\nХотите продолжить? (Y/N)");

                                while (true)
                                {
                                    ConsoleKey choice2 = Console.ReadKey(true).Key;
                                    switch (choice2)
                                    {
                                        case ConsoleKey.Y:
                                            break;
                                        case ConsoleKey.N:
                                            return;
                                        default:
                                            Console.WriteLine("Некорректный ввод");
                                            continue;
                                    }
                                    continue;
                                }
                        }
                        break;
                    case "м":
                        Console.WriteLine("Во что переводить? (1 - киллометры, 2 - миллиметры, 3 - микрометры)");

                        ConsoleKey keykey = Console.ReadKey(true).Key;

                        switch (keykey)
                        {
                            case ConsoleKey.D1:
                                Console.WriteLine($"{value} м = {value /= 1000} км.");
                                break;
                            case ConsoleKey.D2:
                                Console.WriteLine($"{value} м = {value *= 1000} млм.");
                                break;
                            case ConsoleKey.D3:
                                Console.WriteLine($"{value} м = {value *= 1000000} мкм.");
                                break;
                            default:
                                Console.WriteLine("Некорректный ввод!\nХотите продолжить? (Y/N)");

                                while (true)
                                {
                                    ConsoleKey choice2 = Console.ReadKey(true).Key;
                                    switch (choice2)
                                    {
                                        case ConsoleKey.Y:
                                            break;
                                        case ConsoleKey.N:
                                            return;
                                        default:
                                            Console.WriteLine("Некорректный ввод");
                                            continue;
                                    }
                                    continue;
                                }
                        }
                        break;
                }
            }
            else
            {
                Console.WriteLine("Некорректный ввод! Хотите продолжить? Y/N");
                while (true)
                {
                    ConsoleKey Key = Console.ReadKey(true).Key;
                    switch (Key)
                    {
                        case ConsoleKey.Y:
                            break;
                        case ConsoleKey.N:
                            return;
                        default:
                            Console.WriteLine();
                            continue;
                    }
                    break;
                }
            }
        }
    }
}
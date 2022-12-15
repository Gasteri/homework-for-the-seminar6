/*Задача 43: 
Напишите программу, которая найдёт точку пересечения двух прямых, 
заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
значения b1, k1, b2 и k2 задаются пользователем. b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5) */

Console.Write("Введите k1: ");
double k1 = InputInt();
Console.Write("Введите b1: ");
double b1 = InputInt();
Console.Write("Введите k2: ");
double k2 = InputInt();
Console.Write("Введите b2: ");
double b2 = InputInt();
double InputInt()
    {
        bool isParsed = double.TryParse(Console.ReadLine(), out double num);

        if (!isParsed)
        {
            Console.WriteLine("Incorrect number");
            return -1;
        }
        else
        {
            return num;
        }
    }
 
var x = -(b1 - b2) / (k1 - k2);
var y = k1 * x + b1;
 
x = Math.Round(x, 3);
y = Math.Round(y, 3);
 
Console.WriteLine($"Пересечение в точке: ({x};{y})");





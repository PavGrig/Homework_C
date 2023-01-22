// Задача 1. Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
/*
int CountPositiveNums (int numberNums)
{
    int count = 0;
    for(int current = 1; current <= numberNums; current++)
    {
        Console.Write("Input a " + current + " number: ");
        int nums = Convert.ToInt32(Console.ReadLine());
        if (nums > 0)
        count++;
    }
    return count;
}

Console.Write("Input the number of numbers: ");
int numberNums = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("The number of positive numbers from the entered: " + CountPositiveNums(numberNums));*/

// Задача 2. Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
/*
void CoordinateIntersectionPointTwoStraightLines(double b1, double k1, double b2, double k2)
{
    double x = 0;
    double y = 0;
    if(k1 == k2 && b1 == b2)
    Console.WriteLine("The specified straight lines coincide!");
    else if(k1 == k2)
    Console.WriteLine("The specified straight lines parallel!");
    else 
    {
        x = (b2 - b1)/(k1 - k2);
        y = x * k1 + b1;
        Console.WriteLine("The specified straight lines intersect at a point with coordinates: (" + x + "; " + y + ")");
    }
}


Console.Write("Input a coefficient k1: ");
double k1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Input a coefficient b1: ");
double b1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Input a coefficient k2: ");
double k2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Input a coefficient b2: ");
double b2 = Convert.ToDouble(Console.ReadLine());

CoordinateIntersectionPointTwoStraightLines(b1, k1, b2, k2);*/
// Задача 1. Напишите программу, которая принимает на вход два числа (A и B) и с помощью цикла возводит число A в натуральную степень B.
/*
int Num1PowNum2 (int num1, int num2)
{   
    int result = 1;
    while (num2 != 0)
    {
        result *= num1;
        num2 --;
    }
    return result;
}

Console.Write("Input a first number: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a first number: ");
int num2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("The first number to the power of the second number: " + Num1PowNum2(num1, num2));*/

//Вариант 2. Если второе число отрицательное:
/*
int Num1PowNum2 (int num1, int num2)
{   
    int result = 1;
    if (num2 < 0)
    num2 *= -1;
    while (num2 != 0)
    {
        result *= num1;
        num2 --;
    }
    return result;
}

Console.Write("Input a first number: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a first number: ");
int num2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("The first number to the power of the second number: " + Num1PowNum2(num1, num2));*/

// Задача 2. Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
/*
int SumDigNum(int num)
{
    int sum = 0;
    while (num != 0)
    {
        sum += num%10;
        num /=10;
    }
    return sum;
}

Console.Write("Input a number: ");
int num = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("The sum of the digits of the number: " + SumDigNum(num));*/

//Вариант 2. Если число отрицательное.
/*
int SumDigNum(int num)
{
    int sum = 0;
    if (num < 0)
    num *= -1;
    while (num != 0)
    {
        sum += num%10;
        num /=10;
    }
    return sum;
}

Console.Write("Input a number: ");
int num = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("The sum of the digits of the number: " + SumDigNum(num));*/


//Задача 3. Напишите программу, которая задаёт массив из m элементов, которые вводит пользователь, и выводит массив на экран.
/*
int[] CreateArray(int size)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
    Console.Write("Input a number of array: ");
    array[i] = Convert.ToInt32(Console.ReadLine());
    }
    return array;
} 

void ShowArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");
    Console.WriteLine();
}

Console.Write("Input a size of array: ");
int size = Convert.ToInt32(Console.ReadLine());

int[] newArray = CreateArray(size);
ShowArray(newArray);*/
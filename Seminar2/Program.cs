//Задача №1. Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
/*
int SecondNumberNum(int num) 
{ 
    int second = (num / 10) % 10;
    return second;
} 

Console.Write("Input a three-digit number: ");
int num = Convert.ToInt32(Console.ReadLine());

if (num > 99 && num <= 999)
Console.WriteLine($"The second digit of this number is {SecondNumberNum(num)}");
else
Console.WriteLine("Number is not correct.");
*/

// Задача №2. Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
/*
int ThirdNumberNum(int num) 
{   
    int third = -1;
    if (num >= 100)
    {
        while (num > 999)
        {
            num = num / 10;
        }

        third = num % 10;
    }
      
    return third;
} 

Console.Write("Input a number: ");
int num = Convert.ToInt32(Console.ReadLine());

if (ThirdNumberNum(num) == -1)
Console.WriteLine("There is no third digit.");
else
Console.WriteLine($"The third digit of a given number is {ThirdNumberNum(num)}");*/

//Задача №3. Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

/*
bool Weekend(int num) 
{ 
    if (num > 5 && num <= 7)
    return true;
    else
    return false;
} 
Console.Write("Input the number of the day of the week: ");
int num = Convert.ToInt32(Console.ReadLine());

if (num >= 1 && num <= 7)
Console.WriteLine(Weekend(num));
else
Console.WriteLine("The number of the day of the week is not correct.");*/
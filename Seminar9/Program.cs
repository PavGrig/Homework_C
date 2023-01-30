// Задача 1. Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
/*
void ShowNums(int num)
{
    Console.Write(num + " ");
    if(num > 1) ShowNums(num - 1);
}

ShowNums(10);*/

// Задача 2. Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
/*
int SumNumsBetweenTwoNums(int num1, int num2)
{
    if(num1 > num2) return num1 + SumNumsBetweenTwoNums(num1 - 1, num2);
    if(num1 < num2) return num1 + SumNumsBetweenTwoNums(num1 + 1, num2);
    else return num1;
}

Console.WriteLine(SumNumsBetweenTwoNums(10, 2));
*/
// Задача 3. Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
/*
int AckermanFunction (int m, int n)
{
    if (m == 0) return n + 1;
    else if ((m > 0) && (n == 0)) return AckermanFunction(m - 1, 1);
    else return AckermanFunction(m - 1, AckermanFunction(m, n - 1));
}
Console.WriteLine(AckermanFunction(3,2));*/
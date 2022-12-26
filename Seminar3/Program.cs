// Задача №1. Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
/*
int RevNum(int num)
{
   int rev = 0;
   while (num != 0)
   {
    int currev = num %10;
    num = num / 10;
    rev = rev * 10 + currev; 
   }
   return rev;
}

bool Palindrom(int num, int rev)
{
    if (num == rev) return true;
    else return false;
}

Console.Write("Input a number: ");
int num = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(num);
int rev = RevNum(num);
Console.WriteLine(rev);
Console.WriteLine(Palindrom(num, rev));
*/

// Задача 2. Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
/*
double Distance (double x1, double x2, double y1, double y2, double z1, double z2)
{
    return Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2) + Math.Pow((z2 - z1), 2));
}

Console.Write("Enter the X coordinate of the first point: ");
double x1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter the Y coordinate of the first point: ");
double y1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter the Z coordinate of the first point: ");
double z1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Enter the X coordinate of the second point: ");
double x2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter the Y coordinate of the second point: ");
double y2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter the Z coordinate of the second point: ");
double z2 = Convert.ToInt32(Console.ReadLine());

double result = Distance(x1, x2, y1, y2, z1, z2);

Console.WriteLine(result);
*/

// Задача №3. Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
/*
void GetAllCube(int num)
{
    int curnum = 1;
    while(curnum <= num)
    {
    Console.Write(Math.Pow(curnum, 3) + " ");
    curnum ++;
    }
}

Console.Write("Input a number: ");
int num = Convert.ToInt32(Console.ReadLine());

GetAllCube(num);
*/
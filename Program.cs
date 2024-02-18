// Задача 1: Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23.

int a = 184;
if (a % 7 == 0 && a % 23 == 0)
{
    Console.WriteLine("Кратно 7 и 23");
}
else
{
    Console.WriteLine("Число не кратно");
}

// Задача 2: Напишите программу, 
// которая принимает на вход координаты точки (X и Y), 
// причём X ≠ 0 и Y ≠ 0 и выдаёт номер координатной четверти плоскости, 
// в которой находится эта точка.

int x = -3;
int y = 2;
if (x > 0 && y > 0)
{
    Console.WriteLine("1");
}
if (x < 0 && y > 0)
{
    Console.WriteLine("2");
}
if (x < 0 && y < 0)
{
    Console.WriteLine("3");
}
if (x > 0 && y < 0)
{
    Console.WriteLine("4");
}

// Задача 3: Напишите программу, 
// которая принимает на вход целое число из отрезка [10, 99]
// и показывает наибольшую цифру числа.

int number = 57;
int firstDigit = number / 10;
int secondDigit = number % 10;
if (firstDigit > secondDigit)
{
    Console.WriteLine(firstDigit);
}
else
{
    Console.WriteLine(secondDigit);
}


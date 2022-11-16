// Задача 10: Напишите программу, которая принимает 
// на вход трёхзначное число и на выходе показывает 
// вторую цифру этого числа. 
// Выполнить с помощью числовых операций (целочисленное деление, 
// остаток от деления).

// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.WriteLine("Введите целое трёхзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());

bool ThreeDigit(int num)
{
    if (num < 0) num = -num;
    return num > 99 && num < 1000;
}

int Middle(int num)
{
    if (num < 0) num = -num;
    return (num / 10) % 10;
}

if (ThreeDigit(number) == false) Console.WriteLine("Введённое число не является трёхзначным");
else
{
    int middleDigit = Middle(number);
    Console.WriteLine($"Вторая цифра числа {number} -> {middleDigit}");
}
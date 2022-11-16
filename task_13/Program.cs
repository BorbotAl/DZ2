// Задача 13: Напишите программу, которая выводит третью цифру 
// заданного числа или сообщает, что третьей цифры нет. 
// Выполнить с помощью числовых операций (целочисленное деление, 
// остаток от деления).

// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.WriteLine("Введите целое число: ");
int number = Convert.ToInt32(Console.ReadLine());

bool MoreTwoDigits(int num)
{
    if (num < 0) num = -num;
    return num > 99;
}

int ThirdDigit(int num)
{
    if (num < 0) num = -num;
    while (num / 1000 > 0)
    {
        num = num / 10;
    }
    return num % 10;
}

if (MoreTwoDigits(number) == true)
{
    int thirdDig = ThirdDigit(number);
    Console.WriteLine($"Третья цифра числа {number} -> {thirdDig}");
}
else Console.WriteLine("Третьей цифры нет");
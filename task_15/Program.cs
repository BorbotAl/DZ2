// Задача 15: Напишите программу, которая принимает на вход цифру, 
// обозначающую день недели, и проверяет, является ли этот 
// день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

Console.WriteLine("Введите номер дня недели: ");
int day = Convert.ToInt32(Console.ReadLine());

bool Week(int num)
{
    return num >= 1 && num <= 7;
}

bool WeekEnd(int num)
{
    return num == 6 || num == 7;
}

if (Week(day) == true)
{
    string resultStr = WeekEnd(day) == true ? "Да" : "Нет";
    Console.WriteLine($"День недели номер {day} выходной? --> {resultStr}");
}
else Console.WriteLine("Нет дня недели с таким номером");
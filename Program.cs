﻿//Написать программу, которая будет выдавать название дня недели по номеру
//-> 3 - Среда
//-> 5 - Пятница

Console.Clear();

Console.WriteLine("Введите номер дня недели ");

int dayWeek = int.Parse(Console.ReadLine()!);

if (dayWeek == 1)
{
    Console.WriteLine ("Понедельник");
}

else if (dayWeek == 2)
{
    Console.WriteLine ("Вторник");
}

else if (dayWeek == 3)
{
    Console.WriteLine ("Среда");
}

else if (dayWeek == 4)
{
    Console.WriteLine ("Четверг");
}

else if (dayWeek == 5)
{
    Console.WriteLine ("Пятница");
}

else if (dayWeek == 6)
{
    Console.WriteLine ("Суббота");
}

else if (dayWeek == 7)
{
    Console.WriteLine ("Воскресенье");
}

else
Console.WriteLine ("Введите другое число ");
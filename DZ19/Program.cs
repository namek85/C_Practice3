﻿//Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

//14212 -> нет

//12821 -> да

//23432 -> да

Console.WriteLine("Введите пятизначное число");
int N = Convert.ToInt32(Console.ReadLine());

if ((N > 100000) || (N < 10000))
Console.WriteLine("Ошибка");

else
{

   if (((N % 10) == (N / 10000)) && ((N / 10 % 10) == (N / 1000 % 10)))
{
    Console.WriteLine("Да");
}
else {

Console.WriteLine("Нет");
}
}



﻿//Напишите программу, которая принимает на вход цифру, обозначающую
//день недели, и проверяет, является ли этот день выходным.
//                6 -> да
//                7 -> да
//                1 -> нет

Console.WriteLine("Введите номер дня недели");
int dayNumber = Convert.ToInt32(Console.ReadLine());
if (dayNumber == 6 || dayNumber == 7)
{
 Console.WriteLine(" Выходной");   
}
   
    else
    {
        Console.WriteLine("Будни");
    }


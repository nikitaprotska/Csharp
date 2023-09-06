﻿/*
Напишите программу, которая принимает на вход число N и 
выдаёт произведение чисел от 1 до N.
4 -> 24
5 -> 120
*/

System.Console.WriteLine("Введите число: ");
int userNumber = Convert.ToInt32(Console.ReadLine());

int ProductOfNumber(int number) //Метод произведение чисел
{
    int product = 1;
    while (number != 0)
    {
        product *= number; 
        number--;
    }
    return product;
}
Console.WriteLine(ProductOfNumber(userNumber));
/*
Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

6 -> да
7 -> да
1 -> нет

*/

Console.WriteLine("Введите число от 1 до 7: ");
int weekday = Convert.ToInt32(Console.ReadLine());

if (weekday <= 5)
{
    Console.WriteLine("Нет, сегодня не выходной");
}
else if(5 <= weekday)
{
    Console.WriteLine("Да, сегодня выходной");
}
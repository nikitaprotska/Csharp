/*
Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа.

456 -> 46
782 -> 72
918 -> 98
*/

int number = new Random().Next(99, 1000);
Console.WriteLine(number);

int number1 = number / 100;
Console.WriteLine(number1);

int number2 = number % 10;
Console.WriteLine(number2);

int number3 = number1 *10;
int number4 = number3+number2;
Console.WriteLine(number4);
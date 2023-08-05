/*
Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23.

14 -> нет
46 -> нет
161 -> да
*/

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int number1 = 7;
int number2 = 23;

if (number % number1 == 0 & number %number2 == 0)
{
    Console.WriteLine("Да");
}
else
{
       Console.WriteLine("Нет");
}

/*
Console.WriteLine("Введите число: ");
int usernumber = Convert.ToInt32(Console.ReadLine());
int number1 = 7;
int number2 = 23;

if (usernumber % (number1*number2) == 0)
{
    Console.WriteLine($"Число {usernumber} - кратно {number1} и {number2}");
}
else 
{
    Console.WriteLine($"Число {usernumber} - не кратно {number1} и {number2}");
}
*/

/*
Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12
*/

Console.WriteLine("Введите число: ");
int usernumber = Convert.ToInt32(Console.ReadLine());
int num = 0;
for (int i = usernumber; i > 0; i /= 10)
{
    num = i % 10 + num;    
}
Console.WriteLine("Сумма цифр в числе равна: " + num);
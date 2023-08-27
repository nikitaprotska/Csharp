/*
Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да
*/

Console.WriteLine("Введите пятизначное число: ");
int usernumber = Convert.ToInt32(Console.ReadLine());
int palindrom = 0;
if(usernumber<10000||usernumber>= 100000)
{
    Console.WriteLine("Число не пятизначное");
}
for (int i = usernumber; i > 0; i /= 10)
{
    palindrom = i % 10 + palindrom * 10;    
}
if (usernumber==palindrom)
{
    Console.WriteLine("Да");
}
else
{
    Console.WriteLine("Нет");
}
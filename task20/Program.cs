/*
Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.
d = √ [ (x 2 -x 1) 2 + (y 2 -y 1) 2

A (3,6); B (2,1) -> 5,09
A (7,-5); B (1,-1) -> 7,21

Math.Sqrt
*/

Console.WriteLine("Введите координаты двух точек: ");

int numberX1 = Convert.ToInt32(Console.ReadLine());
int numberY1 = Convert.ToInt32(Console.ReadLine());
int numberX2 = Convert.ToInt32(Console.ReadLine());
int numberY2 = Convert.ToInt32(Console.ReadLine());

double numberXY = Math.Sqrt((numberX2 - numberX1)*(numberX2 - numberX1) + (numberY2-numberY1)*(numberY2-numberY1));
double roundedNumber = Math.Round(numberXY, 2); 
Console.WriteLine(roundedNumber);

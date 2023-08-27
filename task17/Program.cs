System.Console.WriteLine("Введите X и Y вашей точки: ");
int userX = Convert.ToInt32(Console.ReadLine());
int userY = Convert.ToInt32(Console.ReadLine());

if(userX > 0 && userY > 0)
{
    System.Console.WriteLine($"Точка [{userX} : {userY}] находится в первой четверти ");
}
else if(userX < 0 && userY > 0)
{
    System.Console.WriteLine($"Точка [{userX} : {userY}] находится во второй четверти ");
}
else if(userX < 0 && userY < 0)
{
    System.Console.WriteLine($"Точка [{userX} : {userY}] находится в третьей четверти ");
}
else 
{
    System.Console.WriteLine($"Точка [{userX} : {userY}] находится в четвертой четверти ");
}
/*
Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3
*/

Console.Write("Введите длину массива: ");
int arrayLength = Convert.ToInt32(Console.ReadLine());

int[] lengthNumbers = new int[arrayLength];

void InputNumbers(int arrayLength) // прием числе от пользователя
{
    for (int i = 0; i < arrayLength; i++)
    {
        Console.Write($"Введите {i} число: ");
        lengthNumbers[i] = Convert.ToInt32(Console.ReadLine());
    }
}

int Comparison(int[] lengthNumbers)
{
  int count = 0;
  for (int i = 0; i < lengthNumbers.Length; i++)
  {
    if(lengthNumbers[i] > 0 ) count += 1; 
  }
  return count;
}

InputNumbers(arrayLength);

Console.WriteLine($"Введено чисел больше 0: {Comparison(lengthNumbers)} ");
//Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//5 2 6 7
//Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

Console.WriteLine("Введите количество строк");
int one = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов");
int two = Convert.ToInt32(Console.ReadLine());

int [,] GetArray()
{
    int [,] a = new int [one,two];
    for (int i = 0; i < a.GetLength(0); i++)
    {
        for (int j = 0; j < a.GetLength(1); j++)
        {
            a [i,j] = new Random().Next(10);
        }
    }
    return a;
}


void PrintArray(int[,] a)
{
    for (int i = 0; i < a.GetLength(0); i++)
    {
        for (int j = 0; j < a.GetLength(1); j++)
        {
            Console.Write(a[i,j]);
        }
        Console.WriteLine();
    }
}
int SumRow(int[,] a, int i)
{
  int sum = a[i,0];
  for (int j = 1; j < a.GetLength(1); j++)
  {
    sum += a[i,j];
  }
  return sum;
}
int [,] m = GetArray();
PrintArray(m);

int minSum = 0;
int sum = SumRow(m, 0);
for (int i = 1; i < m.GetLength(0); i++)
{
  int tempSum = SumRow(m, i);
  if (sum > tempSum)
  {
    sum = tempSum;
    minSum = i;
  }
}

Console.WriteLine($"\nСтрока с наименьшей суммой ({sum}) - №({minSum+1})");



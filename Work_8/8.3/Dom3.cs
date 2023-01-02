//Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//5 2 6 7
//Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

int one= 5;
int two= 5;
int [,] GetArray(int [,] a)
{ 
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

int [,] f = new int [one,two];
PrintArray(GetArray(f));

Console.WriteLine();

int [,] s = new int [one,two];
PrintArray(GetArray(s));

Console.WriteLine("Вывод:");

int [,] r = new int [one,two];
SumMatrix(f,s,r);
PrintArray(r);

void SumMatrix(int[,] f, int[,] s, int[,] r)
{
  for (int i = 0; i < r.GetLength(0); i++)
  {
    for (int j = 0; j < r.GetLength(1); j++)
    {
      int sum = 0;
      for (int k = 0; k < f.GetLength(1); k++)
      {
        sum += f[i,k] * s[k,j];
      }
      r[i,j] = sum;
    }
  }
}
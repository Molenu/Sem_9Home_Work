// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//В итоге получается вот такой массив:
//7 4 2 1
//9 5 3 2
//8 4 4 2

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
int [,] ChageColumns(int[,] a)
{
    for (int i = 0; i < a.GetLength(0); i++)
    {
        for (int j = 0; j < a.GetLength(1); j++)
        {
            for (int z = 0; z < a.GetLength(1)-1; z++)
            {
                if (a[i,z]<a[i,z+1])
                {
                    int mes = a[i,z+1];
                    a[i,z+1] = a[i,z];
                    a[i,z] = mes;
                }
            }
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

int [,] job = GetArray();
PrintArray(job);

Console.WriteLine();

PrintArray(ChageColumns(job));

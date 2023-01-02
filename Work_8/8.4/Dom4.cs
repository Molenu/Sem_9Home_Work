// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

int [,,] a3D = new int [2,2,2];
GetArray(a3D);
PrintArray(a3D);

void GetArray(int [,,] a)
{
    // int count = 10;
    for (int i = 0; i < a.GetLength(0); i++)
    {
        for (int j = 0; j < a.GetLength(1); j++)
        {
            for (int k = 0; k < a.GetLength(2); k++)
            {
                a [i,j,k] = new Random().Next(0,100);
            }
        }
    }
}

void PrintArray(int [,,] a)
{
    for (int i = 0; i < a.GetLength(0); i++)
    {
        for (int j = 0; j < a.GetLength(1); j++)
        {
            Console.WriteLine();
            for (int k = 0; k < a.GetLength(2); k++)
            {
                Console.Write($"{a3D[i,j,k]}({i},{j},{k})  ");
            }
        }
    }
}
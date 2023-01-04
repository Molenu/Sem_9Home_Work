// Задача 68: Напишите программу вычисления функции Аккермана 
// с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29
Console.WriteLine("Введите положительное число numOne");
int numOne = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите положительное число numTwo");
int numTwo = Convert.ToInt32(Console.ReadLine());
int Job(int numOne, int numTwo)
{
  if (numOne == 0)
    return numTwo + 1;
  else
    if ((numOne != 0) && (numTwo == 0))
      return Job(numOne - 1, 1);
    else
      return Job(numOne - 1, Job(numOne, numTwo - 1));
}
Console.WriteLine(Job(numOne,numTwo));

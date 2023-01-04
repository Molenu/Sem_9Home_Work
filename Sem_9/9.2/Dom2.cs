// Задача 66: Задайте значения M и N. Напишите программу, 
// которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30
Console.WriteLine("Введите число numOne");
int numOne = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число numTwo");
int numTwo = Convert.ToInt32(Console.ReadLine());

int numSum (int start, int end)
{
    if (start==end)
    {
        return start;
    }
    if (start>end)
    {
        Console.WriteLine("Неправильно!");
        return(0);
    }
    return (start+numSum(start+1,end));
}
Console.WriteLine(numSum(numOne,numTwo));
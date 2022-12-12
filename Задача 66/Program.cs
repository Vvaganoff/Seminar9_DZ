//Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

//M = 1; N = 15-> 120
//M = 4; N = 8. -> 30

Console.Write("Введите число M: ");
int numStart = Convert.ToInt32(Console.ReadLine());


Console.Write("Введите число N: ");
int numEnd = Convert.ToInt32(Console.ReadLine());
int sum = 0;
Console.WriteLine($"Сумма элементов между {numStart} и {numEnd} равна {CountSum(numStart, numEnd, sum + numStart)}");

int CountSum (int numStart, int numEnd, int sum)
{
    if (numStart == numEnd)
    {
        return sum;
    }
    return CountSum(++numStart, numEnd, sum + numStart);
}

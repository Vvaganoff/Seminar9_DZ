//Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
//m = 2, n = 3->A(m, n) = 9
//m = 3, n = 2->A(m, n) = 29

Console.Write("Введите число M: ");
int numM = Convert.ToInt32(Console.ReadLine());


Console.Write("Введите число N: ");
int numN = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Значение функции Аккермана для чисел {numM} и {numN} равно: {A(numM, numN)}");


int A(int n, int m)
{
    if (n == 0)
        return m + 1;
    else
      if ((n != 0) && (m == 0))
        return A(n - 1, 1);
    else
        return A(n - 1, A(n, m - 1));
}
/*Задача 2: Задайте значения M и N.
 Напишите программу, которая 
 найдёт сумму натуральных элементов в промежутке от M до N.
 Выполнить с помощью рекурсии.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30*/

Console.Write("Введите значение M: ");
int M = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите значение N: ");
int N = Convert.ToInt32(Console.ReadLine());
int count = M;
int summ  = M;
int RecursionF(int n)
{
    if (count == N)
    {
        
        return summ;
    }
    else
    {
        count++;
        summ += count;
        return RecursionF(count);
    }
}
Console.WriteLine(RecursionF(N));
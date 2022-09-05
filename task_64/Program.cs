﻿/*
Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке
от M до N.
M = 1; N = 5. -> ""1, 2, 3, 4, 5""
M = 4; N = 8. -> ""4, 6, 7, 8""
*/

int M = Convert.ToInt32(Console.ReadLine());
int N = Convert.ToInt32(Console.ReadLine());


string PrintNumbers(int start, int end)
{
    if (start == end) return start.ToString();
    return (start + ", " + PrintNumbers(start + 1, end));
}

Console.WriteLine($"Числа от {M} до {N}: {PrintNumbers(M, N)}");
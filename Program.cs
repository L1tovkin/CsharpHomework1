﻿/* Задача.2 Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

a = 5; b = 7 -> max = 7
a = 2 b = 10 -> max = 10
a = -9 b = -3 -> max = -3

*/

/*
Console.WriteLine("Введите число a: ");
int a = int.Parse(Console.ReadLine());

Console.WriteLine("Введите число b: ");
int b = int.Parse(Console.ReadLine());

if (b > a){
    Console.WriteLine($"{b} больше чем {a}");
}
*/

/* Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22

*/

/*
Console.Write("Введите первое число: ");
int a = int.Parse(Console.ReadLine());
Console.Write("Введите второе число: ");
int b = int.Parse(Console.ReadLine());
Console.Write("Введите третье число: ");
int c = int.Parse(Console.ReadLine());
int max = a;

if (b > max) max = b;
if (c > max) max = c;

    
Console.WriteLine($"{max} максимальное число");
*/

/* Задача 6:
Напишите прогу, на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
4 -> да
-3 -> нет
7 -> нет
*/

Console.WriteLine("Введите число: ");
int n = int.Parse(Console.ReadLine());

if (n % 2 == 0){
    Console.WriteLine($"{n} четное число");
}
else {
    Console.WriteLine($"{n} нечетное число");
}

//S1Homework task 8 - 

Console.Clear();
Console.WriteLine("ЗАДАЧА: Напишете программу которая на вход принимает число N, а на выходе показывает все четные числа от 1 до N \nИТОГ: Программа работает корректно");
Console.Write("Введите число ");
int a = Convert.ToInt32(Console.ReadLine()!);
for (int i = 0; i <= a; i += 2)
    Console.Write($"{i} ");
Console.WriteLine();
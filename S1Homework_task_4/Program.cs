//S1Homework task 4 - 

Console.Clear();
Console.WriteLine("ЗАДАЧА: Напишете программу которая принемает на вход 3 числа и выдает максимальное \nИТОГ: Программа работает корректно");

int max = 0;

Console.Write("Введите первое число: "); 
int a = Convert.ToInt32(Console.ReadLine()!);

Console.Write("Введите второе число: "); 
int b = Convert.ToInt32(Console.ReadLine()!);

Console.Write("Введите третье число: "); 
int c = Convert.ToInt32(Console.ReadLine()!);

if (a > max)
    max = a;

if (b > max) 
    max = b;

if (c > max) 
    max = c;

Console.WriteLine(max);
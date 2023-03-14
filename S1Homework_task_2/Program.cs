//S1Homework task 2 - 

Console.Clear();
Console.WriteLine("ЗАДАЧА: Напишете программу которая на вход принимает 2 числа и выдает какое число больше, а какое меньше \nИТОГ: Программа работает корректно");

Console.Write("Введите первое число: "); 
int a = Convert.ToInt32(Console.ReadLine()!);

Console.Write("Введите второе число: "); 
int b = Convert.ToInt32(Console.ReadLine()!);

if(a > b)
    Console.WriteLine(a);
else if(b > a)
    Console.WriteLine(b);
else
    Console.WriteLine("числа равны");
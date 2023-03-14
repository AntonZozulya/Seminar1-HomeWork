//S1Homework task 6 - 

Console.Clear();
Console.WriteLine("ЗАДАЧА: Напишете программу которая принемает число на вход и выдает является ли число четным - делится ли оно на 2 без остатка или нет \nИТОГ: Программа работает корректно");

int a = Convert.ToInt32(Console.ReadLine()!);

if(a%2 == 0)
    Console.WriteLine("Четное");
else
    Console.WriteLine("Нечетное");
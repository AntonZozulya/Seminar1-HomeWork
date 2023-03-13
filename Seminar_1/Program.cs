// Ввод чисел - первый вариант

// Console.Clear(); 
// int n = Convert.ToInt32(Console.ReadLine()!);
// Console.WriteLine(n * 3);

//Интерполяция это способ создания сложной строки из простой строки к примеру:
//нам необходимо вывести значение в конечной (простой строке) Console.WriteLine("Результат a + b = a + b"); 
// чтобы переменные принемали в себя истеное значение которое лежит внутри переменной, для этого это простую
// строку необходимо перевести в сложную (интерполяция) вот таким вот образом: Console.WriteLine($"Результат {a} + {b} = {a + b}");

// Как это выглядит на примере:
// ВЫВОД С ПРОСТОЙ СТРОКОЙ:
    // Console.Clear(); 
    // Console.Write("Введите 1 - первое сисчло:");
    // int a = Convert.ToInt32(Console.ReadLine()!);
    // Console.Write("Введите 2 - второе сисчло:");
    // int b = Convert.ToInt32(Console.ReadLine()!);
    // Console.WriteLine("Результат a + b = a + b");

// Как это выглядит на примере:
// ВЫВОД С СЛОЖНОЙ СТРОКОЙ:
    // Console.Clear(); 
    // Console.Write("Введите 1 - первое сисчло:");
    // int a = Convert.ToInt32(Console.ReadLine()!);
    // Console.Write("Введите 2 - второе сисчло:");
    // int b = Convert.ToInt32(Console.ReadLine()!);
    // Console.WriteLine($"Результат {a} + {b} = {a + b}");

// Необходимо спросить у пользователя 2 числа и узнать, какое из них наибольшее.
// 1 > 2
// 2 > 1
// 1 = 2

// Цикл while
    // Console.Clear(); 
    // Console.Write("Введите 1 - первое сисчло:");
    // int a = Convert.ToInt32(Console.ReadLine()!);
    // Console.Write("Введите 2 - второе сисчло:");
    // int b = Convert.ToInt32(Console.ReadLine()!);
    // if(a > b)
    //     Console.WriteLine(a);
    // else if(a < b)
    //     Console.WriteLine(b);
    // else
    //     Console.WriteLine("=");

// Цикл for
    // for(int i = 1; i <= 10; i++) // 1 2 3 4 5 6 7 8 9 10 
    //     Console.Write($"{i} ");
    // Console.WriteLine();

    // for(int i = 1; i <= 10; i+=2) // 3 5 7 9
    //     Console.Write($"{i} ");
    // Console.WriteLine();

    // for(int i = 10; i > 0; i--) // 10 9 8 7 6 5 4 3 2 1 
    //     Console.Write($"{i} ");
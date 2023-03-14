//Task 1
// int n = int.Parse(Console.ReadLine()!);  // 1 способ

    // Console.Clear(); → Для очищения терминала
    // Console.Write("Введите число "); 
    // int n = int.Parse(Console.ReadLine()!);
    // Console.WriteLine(n * n);

// int n = Convert.ToInt32(Console.ReadLine()!); // 2 способ

    // Console.Clear();
    // Console.WriteLine("Напишете программу которая на вход принемает число и выдает его квадрат число умноженное на само себя");
    // Console.Write("Введите число "); 
    // int n = Convert.ToInt32(Console.ReadLine()!);
    // Console.WriteLine(n * n);



//Task 2
// Console.Clear();
// Console.WriteLine("Напишете программу которая на вход принемает 2 числа и проверяет, является ли первое число квадратом второго");

// a = 25  -  b = 5 - да
// a = 2   -  b = 5 - нет
// a = 9   -  b = 5 - да
// a = -3  -  b = 5 - нет

    // Console.Write("Введите 1 число: ");
    // int n = int.Parse(Console.ReadLine()!); //либо int n = int.Convert.ToInt32(Console.ReadLine()!);
    // Console.Write("Введите 2 число: ");
    // int m = int.Parse(Console.ReadLine()!);
    // if (m * m == n)
    //     Console.WriteLine("Yes");
    // else
    //     Console.WriteLine("No");



//Task 3
// Console.Clear();
// Console.WriteLine("Напишете программу которая будет выдавать название дня недели по заданному номеру");

//1 = понедельник
//2 = вторник
//3 = среда
//4 = четверг
//5 = пятница

// Console.Write("Введите день недели: ");
//     int n = Convert.ToInt32(Console.ReadLine()!); 
//     while (n < 1 || n > 7) // || - это означает "ИЛИ" это алгебра
//     {
//         Console.Write("Вы ошиблись, \nВведите день недели: "); // \n - это переход на новую строчку
//         n = Convert.ToInt32(Console.ReadLine()!);
//     }
//     if(n == 1)
//         Console.Write("Понедельник");
//     else if(n == 2) // else if - иначе если
//         Console.Write("Вторник");
//     else if(n == 3) // else if - иначе если
//         Console.Write("Среда");
//     else if(n == 4) // else if - иначе если
//         Console.Write("Четверг");
//     else if(n == 5) // else if - иначе если
//         Console.Write("Пятница");
//     else if(n == 6) // else if - иначе если
//         Console.Write("Суббота");
//     else
//         Console.Write("Воскресение");
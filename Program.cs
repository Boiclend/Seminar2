// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа. Через строку решать нельзя.

// Console.WriteLine("Введите трехзначное число");
// int Number = Convert.ToInt32(Console.ReadLine());
// if (Number > 999  || Number < 100) {
//     Console.WriteLine("Это не трехзначное число!");
//     return;
// }
// int result = Number / 10;
// result = result % 10;
// Console.WriteLine($"Вторая цифра числа {Number} = "+ result);


// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.Через строку решать нельзя.

// Console.WriteLine("Введите трехзначное число");
// int number = Convert.ToInt32(Console.ReadLine());

// int result = -1;
// if (number >= 100)
// {
//     while (number > 999)
// {
//     number = number / 10;
// }
//     result = number % 10;
// }
            
// Console.WriteLine(result);


// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());

switch(number) {
    case 1:
        Console.WriteLine("нет");
        break;
    case 2:
        Console.WriteLine("нет");
        break;
    case 3:
        Console.WriteLine("нет");
        break;
    case 4:
        Console.WriteLine("нет");
        break;
    case 5:
        Console.WriteLine("нет");
        break;
    case 6:
        Console.WriteLine("да");
        break;
    case 7:
        Console.WriteLine("да");
        break;
}
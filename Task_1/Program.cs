// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
//Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

int RaisePow(int a, int b) {
    
    for (int count = 2; count<=b; count++) {
        a = a * a;
    }
    return a;
}
Console.WriteLine("Введите число A: ");
int a = int.Parse(Console.ReadLine());

Console.WriteLine("Введите число B: ");
int b = int.Parse(Console.ReadLine());



Console.WriteLine($"Результат возведения числа A в степень B равен {RaisePow(a, b)} ");


// Console.WriteLine("Введите число A: ");
// double a = double.Parse(Console.ReadLine());

// Console.WriteLine("Введите число B: ");
// double b = double.Parse(Console.ReadLine());

// if (b > 0 && b % 1 == 0)
// {
//     a = Math.Pow(a, b);
// }
// else
// {
//     Console.WriteLine("Число B должно быть натуральным целым числом. Введите число B: ");
//     b = double.Parse(Console.ReadLine());
//     a = Math.Pow(a, b);
// }

// Console.WriteLine($"Результат возведения числа A в степень B равен {a} ");




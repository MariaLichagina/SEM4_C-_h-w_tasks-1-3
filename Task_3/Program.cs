// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

int [] arr = new int [8];
Random randNumArr = new Random();

for (int i = 0; i < arr.Length; i++)
{
   arr[i] = randNumArr.Next(-15, 100);
}

Console.WriteLine($"[{String.Join(", ", arr)}]");
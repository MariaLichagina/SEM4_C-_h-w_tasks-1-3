// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

int[] GetArr() {
int [] arr = new int [8];
Random randNumArr = new Random();

for (int i = 0; i < arr.Length; i++)
{
   arr[i] = randNumArr.Next(int.MinValue, int.MaxValue);
}
return arr;
}

Console.WriteLine($"[{String.Join(", ", GetArr())}]");
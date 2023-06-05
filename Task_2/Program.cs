// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12


int Sum(int number)
{
int sum = 0;
while (number > 9) {
 sum += number%10;
 number = number/10;
}
sum += number;
return sum;

}

int Abs(int number)
{
if (number < 0)
number *= -1;

return number;
}

Console.WriteLine("Введите число: ");
int num = int.Parse(Console.ReadLine());
int abs = Abs(num);
int sum = Sum(abs);
Console.WriteLine(sum);




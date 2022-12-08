//Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.


int a;
Console.WriteLine($"Введите число: ");
int.TryParse(Console.ReadLine()!, out a);

int sum = 0;

while (a > 0)
{
    sum = sum + a % 10;
    a = a / 10;
}

Console.WriteLine(sum);





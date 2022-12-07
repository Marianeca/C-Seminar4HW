// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) 
// и возводит число A в натуральную степень B.

int A, B;

Console.WriteLine($"Введите число A: ");
int.TryParse(Console.ReadLine()!, out A);

Console.WriteLine($"Введите число B: ");
int.TryParse(Console.ReadLine()!, out B);

int result = A;

for (int i = 1; i < B; i++)
{
    result = result * A;

}
Console.WriteLine(result);




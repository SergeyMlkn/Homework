// Задача 27: Напишите метод, который принимает на вход число и выдаёт сумму цифр в числе.

Console.WriteLine("Введите свое число");
int num = Convert.ToInt32(Console.ReadLine());
int i = 1;
int sum = 0;
while (num != 0)
{
    i = num % 10;
    sum = sum + i;
    num = num / 10;
}
Console.WriteLine(sum);
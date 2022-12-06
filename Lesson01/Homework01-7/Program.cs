// Напишите метод, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// Math.Pow использовать нельзя
// 3, 5 -> 243 (3⁵)

int Method(int num, int y)
{
    int i;
    int result = 1;
    for (i = 1; i <= y; i++)
    {
        result = result * num;
    }
    return result;
}
int res = Method(3, 5);
Console.WriteLine(res);
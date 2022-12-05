// Напишите программу, которая будет принимать на вход два числа 
// и выводить, является ли второе число кратным первому. Если второе число не кратно первому, то программа выводит остаток от деления

// в программу вводится число 1 и число 2
// найти остаток деления ч1 на ч2
// проверить (если остаток не равен 0, то показать)

Console.WriteLine("start");

int firstNumber = 25;
int secondNumber = 5;

int remainder = firstNumber % secondNumber;

if (remainder != 0)
{
    Console.WriteLine(remainder);
}
else
{
    Console.WriteLine("КРАТНО");
}
Console.WriteLine("end");
// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел 

Console.WriteLine("Введите первое число: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int number2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите третье число: ");
int number3 = Convert.ToInt32(Console.ReadLine());
    int maxnumber = number1;
    if (maxnumber < number2)
    {
    maxnumber=number2;
    }
    if (maxnumber < number3)
    {
    maxnumber=number3;
    }
    Console.WriteLine(maxnumber);

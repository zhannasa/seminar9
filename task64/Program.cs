// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
//N = 5 -> "5, 4, 3, 2, 1"
//N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"
 
Console.WriteLine("Enter the natural number:");
int number = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(NaturalNumber(number));

int NaturalNumber(int num)
{
    if (num < 1)
    {
        Console.WriteLine("The number isn't positive!");
    }
    else if (num == 1)
    {
        return 1;
    }    
    else
    {
        Console.Write($"{num}, ");
        NaturalNumber(num - 1);
        return 1;
    }  
    return num;    
}

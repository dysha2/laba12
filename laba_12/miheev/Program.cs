﻿// See https://aka.ms/new-console-template for more information
void PrintMenu()
{
    Console.WriteLine("1.Ввести А\n" +
        "2.Ввести B\n" +
        "3.Вычислить A+B\n" +
        "4.Вычислить A-B\n" +
        "5.Вычислить A*B\n" +
        "6.Вычислить A/B\n");
}
<<<<<<< HEAD
double Division(int a, int b) => (double)(a / b);
int Addition(int a, int b)
{
    return a + b;
}
int Subtraction(int x, int y) => x - y;
int Multiplication(int a, int b) => a * b;
int InputA()
=======
int InputB()
>>>>>>> InputB
{
    do
    {
        Console.WriteLine("Введите A");
<<<<<<< HEAD
        if (int.TryParse(Console.ReadLine(), out int a))
        {
            return a;
        }
        Console.WriteLine("Введите целое число");
    }while (true);
=======
        if (int.TryParse(Console.ReadLine(), out int b))
        {
            return b;
        }
        Console.WriteLine("Введите целое число");
    } while (true);
>>>>>>> InputB
}
PrintMenu();
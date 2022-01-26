// See https://aka.ms/new-console-template for more information
void PrintMenu()
{
    Console.WriteLine("1.Ввести А\n" +
        "2.Ввести B\n" +
        "3.Вычислить A+B\n" +
        "4.Вычислить A-B\n" +
        "5.Вычислить A*B\n" +
        "6.Вычислить A/B\n");
}
double Division(int a, int b) => (double)(a / b);
int Addition(int a, int b)
{
    return a + b;
}
PrintMenu();
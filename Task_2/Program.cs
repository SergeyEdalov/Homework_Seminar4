// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// 452 -> 11
// 82 -> 10
// 9012 -> 12


Console.Write("Enter count: ");
int A = Convert.ToInt32(Console.ReadLine());
int c = A % 10;
if (A < 100)
{
    int b = A / 10;
    int d = b + c;
    Console.Write(d);
}
else
{
    while (A > 99)
    {
        A = A / 10;
        int d = A % 10;
        c = c + d;
    }
    A = A / 10;
    c = c + A;
    Console.Write(c);
}
    


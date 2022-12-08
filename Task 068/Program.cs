// Напиcfnm программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.
Console.WriteLine("Введите неотрицательное число m:");
int m = int.Parse(Console.ReadLine());

Console.WriteLine("Введите неотрицательное число n:");
int n = int.Parse(Console.ReadLine());

///Метод вычисления функции Аккермана:
int Ack (int m, int n)
{
    if (m == 0) return n + 1;
    if (m != 0 && n == 0) return Ack(m - 1, 1);
    if (m > 0 && n > 0) return Ack(m - 1, Ack(m, n - 1));
return Ack(m, n);
}

Console.WriteLine($"Функция Аккермана для чисел A({m},{n}) = {Ack(m, n)}");

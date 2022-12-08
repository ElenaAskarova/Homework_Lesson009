//  Задать значения M и N. 
// Написать программу, которая найдёт сумму натуральных элементов в промежутке от M до N

Console.WriteLine("Введите начальное число M:");
int numM = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите начальное число N:");
int numN = Convert.ToInt32(Console.ReadLine());

///Метод нахождения суммы натуральных элементов в промежутке от M до N
void NumberSum (int numM, int numN, int sum)
{
    if (numM > numN) 
    {
        Console.WriteLine($"Сумма натуральных элементов в промежутке от M до N: {sum}"); 
        return;
    }
    sum = sum + (numM++);
    NumberSum(numM, numN, sum);
}

NumberSum(numM, numN, 0);


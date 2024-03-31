// Задача 1: Задайте значения M и N. Напишите
// программу, которая выведет все натуральные числа
// в промежутке от M до N. Использовать рекурсию, не
// использовать циклы.
// M = 1; N = 5 -> "1, 2, 3, 4, 5"
// M = 4; N = 8 -> "4, 5, 6, 7, 8"

void Main()
{
    int M = ReadInt("Введите число M > 0: ");
    int N = ReadInt("Введите число N > M: ");
    if (M < 0 || N < 0 || N < M)
    {
        System.Console.WriteLine("Введены некорректные числа!");
        return;
    }
    PrintNumbers(M, N);
}
Main();

int ReadInt(string msg)
{
    System.Console.WriteLine(msg);
    return Convert.ToInt32(Console.ReadLine());
}

void PrintNumbers(int M, int N)
{
    if (M > N) return;
    System.Console.Write(M + " , ");
    PrintNumbers(M + 1, N);
}
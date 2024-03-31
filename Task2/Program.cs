// Задача 2: Напишите программу вычисления функции
// Аккермана с помощью рекурсии. Даны два
// неотрицательных числа m и n. 
// m = 2, n = 3->A(m, n) = 29

// !!! Ошибка в условии !!!

// Вот правильные вычисления из таблицы Аккермана:
// m = 2, n = 3->A(m, n) = 9 !!!
// m = 3, n = 2->A(m, n) = 29 !!!

void Main()
{
    int m = ReadInt("Введите неотрицательное число m: ");
    int n = ReadInt("Введите неотрицательное число n: ");
    if (m < 0 || n < 0)
    {
        System.Console.WriteLine("Введены некорректные числа!");
        return;
    }
    System.Console.WriteLine($"A({m}, {n}) = {FunctionAkkermana(m, n)}");
}
Main();

int ReadInt(string msg)
{
    System.Console.WriteLine(msg);
    return Convert.ToInt32(Console.ReadLine());
}

int FunctionAkkermana(int M, int N)
{
    if (M == 0)
        return N + 1;
    if (M > 0 && N == 0)
        return FunctionAkkermana(M - 1, 1);
    else
        return FunctionAkkermana(M - 1, FunctionAkkermana(M, N - 1));
}

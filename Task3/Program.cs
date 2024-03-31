// Задача 3: Задайте произвольный массив. Выведите
// его элементы, начиная с конца. Использовать
// рекурсию, не использовать циклы.
// [1, 2, 5, 0, 10, 34] => 34 10 0 5 2 1 

void Main()
{
    int arraySize = ReadInt("Введите размер массива: ");
    int[] array = GenerateArray(arraySize, 0, 99);
    System.Console.Write("[ ");
    PrintArray(array);
    System.Console.Write("] => ");
    PrintArrayRecurs(array);
}
Main();

int ReadInt(string msg)
{
    System.Console.WriteLine(msg);
    return Convert.ToInt32(Console.ReadLine());
}

int[] GenerateArray(int arraySize, int LeftRange, int RightRange)
{
    int[] tempArray = new int[arraySize];
    Random rand = new Random();
    for (int i = 0; i < arraySize; i++)
        tempArray[i] = rand.Next(LeftRange, RightRange + 1);
    return tempArray;
}

void PrintArray(int[] arrayForPrint)
{
    foreach (int number in arrayForPrint)
        System.Console.Write(number + " , ");
}

void PrintArrayRecurs(int[] arrayForPrint, int i = 0)
{
    if (i == arrayForPrint.Length) return;
    PrintArrayRecurs(arrayForPrint, i + 1);
    System.Console.Write(arrayForPrint[i] + "  ");
}
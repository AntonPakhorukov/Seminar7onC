/*
Задача 51: Задайте двумерный массив. Найдите сумму
 элементов, находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Сумма элементов главной диагонали: 1+9+2 = 12
*/
Console.Clear();
Console.WriteLine("Введите количесвто строк двумерного массива: ");
int rowCount = int.Parse(Console.ReadLine());
Console.WriteLine("Введите количесвто столбцов двумерного массива: ");
int columnCount = int.Parse(Console.ReadLine());
int[,] FillArray(int rows, int column)
{
    int[,] filledArray = new int[rows, column];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < column; j++)
        {
            filledArray[i, j] = i + j;
        }
    }
    return filledArray;
}
int[,] array = FillArray(rowCount, columnCount);
void PrintArray(int[,] inputArray) {
    for (int i = 0; i < inputArray.GetLength(0); i++) {
        for (int j = 0; j < inputArray.GetLength(1); j++) {
            Console.Write(" " + inputArray[i, j]);
        }
        Console.WriteLine();
    }
}
PrintArray(array);
Console.WriteLine();
int GetSum(int[,] inputArray) {
    int sum = 0;
    for (int i = 0; i < inputArray.GetLength(0); i++)
    {
        for (int j = 0; j < inputArray.GetLength(1); j++)
        {
            if (i == j) {
                sum = sum + inputArray[i,j];
                Console.Write(inputArray[i,j] + " ");
            }
        }
    }
    return sum;
}
int result = GetSum(array);
Console.WriteLine();
Console.WriteLine(result);

/*
int SumDiag(int[,] array)
{
    int rows = array.GetLength(0);
    int columns = array.GetLength(1);
    int sum = 0;
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            if (i == j)
                sum = sum + array[i, j];
        }
    }
    return sum;
}
*/
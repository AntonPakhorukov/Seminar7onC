/*
Задача 49: Задайте двумерный массив. Найдите элементы, у которых оба индекса чётные, и замените эти элементы на их квадраты.
Например, изначально массив
 выглядел вот так:
1 4 7 2
5 9 2 3
8 4 2 4
Новый массив будет выглядеть 
вот так:
1 4 49 2
5 9 2 4
8 4 4 4
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
int[,] GetSquare(int[,] inputArray) {
    for (int i = 0; i < inputArray.GetLength(0); i = i + 2){
        for (int j = 0; j < inputArray.GetLength(1); j = j + 2) {
            inputArray[i,j] = inputArray[i,j] * inputArray[i,j];
        }
    } 
    return inputArray;
}
PrintArray(GetSquare(array));
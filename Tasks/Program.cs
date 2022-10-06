Console.Clear();
Console.WriteLine("Введите количесвто строк двумерного массива: ");
int rowCount = int.Parse(Console.ReadLine());
Console.WriteLine("Введите количесвто столбцов двумерного массива: ");
int columnCount = int.Parse(Console.ReadLine());
int[,] array = FillArray(rowCount, columnCount, 1, 10);
int[,] FillArray(int rows, int column, int min, int max) {
int[,] filledArray = new int[rows, column];
for (int i = 0; i < rows; i++) {
    for (int j = 0; j < column; j++) {
        filledArray[i, j] = new Random().Next(min, max + 1);
    }
}
return filledArray;
}
void PrintArray(int[,] inputArray) {
    for (int i = 0; i < inputArray.GetLength(0); i++) {
        for (int j = 0; j < inputArray.GetLength(1); j++) {
            Console.Write(" " + inputArray[i, j]);
        }
        Console.WriteLine();
    }
}
PrintArray(array);
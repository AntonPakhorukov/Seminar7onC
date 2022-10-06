/*
Задача 53: Задайте двумерный массив. Напишите программу, которая поменяет местами первую и последнюю строку 
Изначальный массив: 	
1 4 7 2
5 9 2 3
8 4 2 4
Итоговый массив: 	
8 4 2 4
5 9 2 3
1 4 7 2
*/
Console.Clear();
Console.WriteLine("Введите количесвто строк двумерного массива: ");
int rowCount = int.Parse(Console.ReadLine());
Console.WriteLine("Введите количесвто столбцов двумерного массива: ");
int columnCount = int.Parse(Console.ReadLine());
int[,] FillArray(int rows, int column, int min, int max) {
int[,] filledArray = new int[rows, column];
for (int i = 0; i < rows; i++) {
    for (int j = 0; j < column; j++) {
        filledArray[i, j] = new Random().Next(min, max + 1);
    }
}
return filledArray;
}
int[,] array = FillArray(rowCount, columnCount, 1, 9);
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
int[,] GetChangeRow(int[,] inputArray) {
    int[] rowOne = new int[columnCount];
    int[] rowFinish = new int[columnCount];
    for (int i = 0; i < inputArray.GetLength(1); i++) {
        rowOne[i] = inputArray[0, i];
    }
    for (int j = 0; j < inputArray.GetLength(1); j++) {
        rowFinish[j] = inputArray[inputArray.GetLength(0) - 1, j];
    }
    
    for (int x = 0; x < inputArray.GetLength(1); x++) {
        inputArray[inputArray.GetLength(0) - 1, x] = rowOne[x];
    }
    for (int y = 0; y < inputArray.GetLength(1); y++) {
        inputArray[0, y] = rowFinish[y];
    }

    return inputArray;
}
int[,] newArray = GetChangeRow(array);
PrintArray(newArray);

/*
int [,] ChangeRows (int[,] array)
{
    int[,] changeArray = new int [array.GetLength(0), array.GetLength(1)];
    
    for (int i = 0; i < array.GetLength(0)-1; i++)
    {
        int temp = array[0,i];
        array[0,i] = array[array.GetLength(0)-1, i];
        array[array.GetLength(0)-1, i] = temp;
    }
    return changeArray;
}
*/

/*
FillArra(array);
int[,] FillArra(int [,] filladArra)
{

    for (int i = 0; i < filladArra.GetLength(0); i++)
    {
        for (int j = 0; j < filladArra.GetLength(1); j++)
        {
            if (i == 0)
            {
                (filladArra[i, j], filladArra[filladArra.GetLength(1)-1, j]) = (filladArra[filladArra.GetLength(1)-1, j], filladArra[i, j]);
            }
        }
    }
    return filladArra;
}
Console.WriteLine();
PrintArray(array);
*/
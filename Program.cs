
Console.WriteLine("Task 54");
// Задайте двемерный массив. Напишите программу, которая
// упорядочит по убыванию элементы каждой строки двумерного массива.

Console.Write("Enter number of rows: ");
int rowsNum = Convert.ToInt32(Console.ReadLine());

Console.Write("Enter number of columns: ");
int columnsNum = Convert.ToInt32(Console.ReadLine());

int[,] matrix54 = new int[rowsNum, columnsNum];

void FillArray(int[,] array)
{
    for (int row=0; row<array.GetLength(0); row++)
    {
        for (int column=0; column<array.GetLength(1); column++)
        {
            array[row, column] = new Random().Next(0, 11);
        }
    }
}

void PrintArray(int[,] array)
{
    for (int row=0; row<array.GetLength(0); row++)
    {
        for (int column=0; column<array.GetLength(1); column++)
        {
            Console.Write(array[row, column] + " ");
        }
        Console.WriteLine();
    }
}

void SortArray(int[,] array)
{
    for (int row=0; row<array.GetLength(0); row++)
    {
        // Creating an array same size as the row
        int[] rowExtract = new int[array.GetLength(1)];
        // Extracting each row to the array
        for (int column=0; column<array.GetLength(1); column++)
        {
            rowExtract[column] = array[row, column];
        }
        // Sorting the array consisting of the extracted row
        Array.Sort(rowExtract);
        Array.Reverse(rowExtract);
        // Swapping the existing row with the sorted array
        // by looping through the whole row again
        for (int column=0; column<array.GetLength(1); column++)
        {
            array[row, column] = rowExtract[column];
        }
    }
}

Console.WriteLine("Before:");
FillArray(matrix54);
PrintArray(matrix54);
Console.WriteLine("After:");
SortArray(matrix54);
PrintArray(matrix54);


Console.WriteLine("\nTask 56");
// Задайте прямоугольный двумерный массив. Напишите программу,
// которая будет находить строку с наименьшей суммой элементов.

Console.Write("Enter number of rows: ");
int rowsNum56 = Convert.ToInt32(Console.ReadLine());

Console.Write("Enter number of columns: ");
int columnsNum56 = Convert.ToInt32(Console.ReadLine());

int[,] matrix56 = new int[rowsNum56, columnsNum56];

void SmallestSumRow(int[,] array)
{
    int minRowIndex = 0;
    int minRowSum = int.MaxValue;
    for (int row=0; row<array.GetLength(0); row++)
    {
        int sum = 0;
        for (int column=0; column<array.GetLength(1); column++)
        {
            sum += array[row, column];
        }
        if (sum<minRowSum)
        {
            minRowSum = sum;
            minRowIndex = row;
        }
    }
    Console.WriteLine($"\nIndex of the row with the smallest sum is [{minRowIndex}] and its sum is {minRowSum}");
}

FillArray(matrix56);
PrintArray(matrix56);
SmallestSumRow(matrix56);
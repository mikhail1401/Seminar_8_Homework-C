
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
    Console.WriteLine($"Index of the row with the smallest sum is [{minRowIndex}] and its sum is {minRowSum}");
}

FillArray(matrix56);
PrintArray(matrix56);
SmallestSumRow(matrix56);


Console.WriteLine("\nTask 58");
// Задайте две матрицы. Напишите программу, которая
// будет находить произведение двух матриц.

Console.Write("Enter a number of rows for the 1st matrix: ");
int rowsNum581 = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter a number of columns for the 2nd matrix: ");
int columnsNum581 = Convert.ToInt32(Console.ReadLine());

Console.Write("Enter a number of rows for the 2st matrix: ");
int rowsNum582 = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter a number of columns for the 2nd matrix: ");
int columnsNum582 = Convert.ToInt32(Console.ReadLine());

int[,] matrix581 = new int[rowsNum581, columnsNum581];
int[,] matrix582 = new int[rowsNum582, columnsNum582];

// 2 matrices can be multipled if the number of columns in the 1st matrix
// is equal to the rows in the 2nd matrix.

// The result matrix will have the same numbers of rows as the 1st matrix
// and the same number of columns as the 2nd matrix.

void MatrixMultiplication(int[,] array1, int[,] array2)
{
    if(array1.GetLength(1)!=array2.GetLength(0))
    {
        Console.WriteLine("The multiplication is not possible");
    }
    else
    {
        int[,] matrix3 = new int[array1.GetLength(0), array2.GetLength(1)];
        for (int row3=0; row3<matrix3.GetLength(0); row3++)
        {
            for (int column3=0; column3<matrix3.GetLength(1); column3++)
            {
                
                // Extracting the row for multiplication from the 1st array
                int[] rowToMultiple = new int[array1.GetLength(1)];
                for (int column1=0; column1<array1.GetLength(1); column1++)
                    {
                    rowToMultiple[column1] = array1[row3, column1];
                    }
                // Extracting the column for multiplication from the 2nd array
                int[] columnToMultiple = new int[array2.GetLength(0)];
                for (int row2=0; row2<array2.GetLength(0); row2++)
                {
                    columnToMultiple[row2] = array2[row2, column3];
                }
                
                // Making multiplication for the current matrix3 element
                int result = 0;
                for (int i=0; i<rowToMultiple.Length; i++)
                {
                    result += rowToMultiple[i] * columnToMultiple[i];
                }
                matrix3[row3, column3] = result;

                Console.Write(matrix3[row3, column3] + " ");
            }
            Console.WriteLine();
        }
    }
}

FillArray(matrix581);
FillArray(matrix582);
Console.WriteLine("matrix1: ");
PrintArray(matrix581);
Console.WriteLine("matrix2: ");
PrintArray(matrix582);
Console.WriteLine("Multiplication result: ");
MatrixMultiplication(matrix581, matrix582);


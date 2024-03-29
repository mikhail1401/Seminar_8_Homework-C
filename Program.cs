﻿
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


Console.WriteLine("\nTask 60");
// Сформулируйте трёхмерный массив из неповторяющихся
// двузначных чисел. Напшиите программу, которая будет построчно
// выводить массив, добавляя индексы кжадого элемента

// Three-demensinoal array SYNTAX:
// int[,,] array3 = new int[x, y, z];

// There are only 90 two-digit numbers
// We need to ensure the array has 90 elements
// bool valid = false;
// int x=0, y=0, z=0;
// while (!valid)
// {
//     x = new Random().Next(1, 46);
//     y = new Random().Next(1, 46);
//     z = new Random().Next(1, 46);
//     if(x*y*z == 90) valid = true;
// }

// Console.WriteLine($"This array dimensions will be x={x}, y={y}, z={z}");
// int[,,] cube = new int[x, y, z];

// void Fill3dArray(int[,,] array)
// {
//     int count = 0;
//     int[] usedNumbers = new int[90];
//     int randomNumber = 0;
//     while (count<90)
//     {
//         randomNumber = new Random().Next(10, 91);
//         if (!usedNumbers.Contains(randomNumber))
//         {
//             usedNumbers[count] = randomNumber;
//             count++;
//         }
//     }
//     count=0;
//     for (int a=0; a<array.GetLength(0); a++)
//     {
//         for (int b=0; b<array.GetLength(1); b++)
//         {
//             for (int c=0; c<array.GetLength(2); c++)
//             {
//                 array[a, b, c] = usedNumbers[count];
//                 count++;
//             }
//         }
//     }
// }

// void Print3dArray(int[,,] array)
// {
//     for (int a=0; a<array.GetLength(0); a++)
//     {
//         for (int b=0; b<array.GetLength(1); b++)
//         {
//             for (int c=0; c<array.GetLength(2); c++)
//             {
//                 Console.Write($"{array[a, b, c]}[{a}, {b}, {c}] ");
//             }
//             Console.WriteLine();
//         }
//         Console.WriteLine();
//     }
// }

// Fill3dArray(cube);
// Print3dArray(cube);


Console.WriteLine("\nTask 62");
// Заоплните спирально массив 4 на 4

int side = 4;
int[,] array62 = new int[side, side];

void FillFourArraySpiral(int[,] array)
{
    int value = 1;
    int minColumn = 0;
    int minRow = 0;
    int maxColumn = array.GetLength(1)-1;
    int maxRow = array.GetLength(0)-1;
    
    while (value<=16)
    {
        for (int i=minColumn; i<=maxColumn; i++)
        {
            array[minRow, i] = value;
            value++;
        }
        minRow++;

        for (int i=minRow; i<=maxRow; i++)
        {
            array[i, maxColumn] = value;
            value++;
        }
        maxColumn--;

        for (int i=maxColumn; i>=minColumn; i--)
        {
            array[maxRow, i] = value;
            value++;
        }
        maxRow--;

        for (int i=maxRow; i>=minRow; i--)
        {
            array[i, minColumn] = value;
            value++;
        }
        minColumn++;
    }

    for (int row=0; row<array.GetLength(0); row++)
    {
        for (int column=0; column<array.GetLength(1); column++)
        {
            Console.Write(array[row, column] + " ");
        }
        Console.WriteLine();
    }
}

FillFourArraySpiral(array62);
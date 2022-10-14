/*
Напишите программу, которая заполнит спирально массив 4 на 4.
Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07
*/

void printColorData(string data)
{
    Console.ForegroundColor = ConsoleColor.Green;
    Console.Write(data);
    Console.ResetColor();
}
void print2DArray(int[,] arrayToPrint)
{
    Console.Write("\t");
    for (int i = 0; i < arrayToPrint.GetLength(1); i++)
    {
        printColorData(i + "\t");
    }
    Console.WriteLine();
    for (int i = 0; i < arrayToPrint.GetLength(0); i++)
    {
        printColorData(i + "\t");
        for (int j = 0; j < arrayToPrint.GetLength(1); j++)
        {
            Console.Write(arrayToPrint[i, j] + "\t");
        }
        Console.WriteLine();
    }
}
int[,] getSpiralArray(int rows, int columns)
{
    int[,] spiralArray = new int[rows, columns];
    int t = 0;
    int j = 0;
    int startPoint = 01;
    int rows1 = rows;
    int columns2 = columns;
    while (startPoint <= rows1 * columns2)
    {
        for (int i = t; i < columns; i++)
        {
            spiralArray[j, i] = startPoint++;
        }
        j = columns - 1;
        for (int i = t + 1; i < rows; i++)
        {
            spiralArray[i, j] = startPoint++;
        }
        for (int i = columns - 2; i >= t; i--)
        {
            spiralArray[j, i] = startPoint++;
        }
        j = t;
        for (int i = rows - 2; i > t; i--)
        {
            spiralArray[i, j] = startPoint++;
        }
        rows--;
        columns--;
        t++;
        j = t;
    }
    return spiralArray;
}

int[,] spiralArray = getSpiralArray(4, 4);
print2DArray(spiralArray);
/*
Задайте две матрицы. Напишите программу, которая 
будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18
*/

int[,] generate2DArray(int height, int width, int randomStart, int randomEnd)
{
    int[,] twoDArray = new int[height, width];
    for (int i = 0; i < height; i++)
    {
        for (int j = 0; j < width; j++)
        {
            twoDArray[i, j] = new Random().Next(randomStart, randomEnd + 1);
        }
    }
    return twoDArray;
}
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
int[,] getMultiplicationMatrix(int[,] Matrix1, int[,] Matrix2)
{
    int[,] resultOfMult = new int[Matrix1.GetLength(0),Matrix2.GetLength(1)];
    if (Matrix1.GetLength(1) == Matrix2.GetLength(0))
    {
        for (int i = 0; i < Matrix1.GetLength(0); i++)
        {
            for (int j = 0; j < Matrix2.GetLength(1); j++)
            {
                for (int k = 0; k < Matrix2.GetLength(0); k++)
                {
                    resultOfMult[i,j] += Matrix1[i,k] * Matrix2[k,j];
                }
            }
        }
    }
    else 
    {
        Console.WriteLine("Перемножить матрицы невозможно");
    }
    return resultOfMult;
}

int[,] generatedMatrix1 = generate2DArray(2, 2, 1, 10);
int[,] generatedMatrix2 = generate2DArray(2, 2, 1, 10);
print2DArray(generatedMatrix1);
Console.WriteLine();
print2DArray(generatedMatrix2);
Console.WriteLine();
int[,] multOfMatrix = getMultiplicationMatrix(generatedMatrix1,generatedMatrix2);
print2DArray(multOfMatrix);
/*
Задайте двумерный массив. Напишите программу, которая упорядочит 
по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2
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
int[,] getsortedMaxMinArray(int[,] inputArray)
{
    for (int i = 0; i < inputArray.GetLength(0); i++)
    {
        for (int k = 0; k < inputArray.GetLength(1) - 1; k++)
        {
            for (int j = k + 1; j < inputArray.GetLength(1); j++)
            {
                if (inputArray[i, k] < inputArray[i, j])
                {
                    int temp = inputArray[i, k];
                    inputArray[i, k] = inputArray[i, j];
                    inputArray[i, j] = temp;
                }
            }
        }

    }
    return inputArray;
}

int[,] generatedArray = generate2DArray(3, 4, 1, 10);
print2DArray(generatedArray);
int[,] sortedArray = getsortedMaxMinArray(generatedArray);
print2DArray(sortedArray);
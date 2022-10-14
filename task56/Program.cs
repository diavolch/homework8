/*
Задайте прямоугольный двумерный массив. Напишите программу, 
которая будет находить строку с наименьшей суммой элементов.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке 
и выдаёт номер строки с наименьшей суммой элементов: 1 строка
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
int[] getSumArray(int[,] inputArray)
{
    int[] sumOfArray = new int[inputArray.GetLength(0)];
    for (int i = 0; i < inputArray.GetLength(0); i++)
    {
        for (int j = 0; j < inputArray.GetLength(1); j++)
        {
            sumOfArray[i] += inputArray[i, j];
        }
    }
    return sumOfArray;
}
int getMinInSumOfArray(int[] sumOfArray)
{
    int minIndex = 0;
    for (int i = 1; i < sumOfArray.Length; i++)
    {
        if (sumOfArray[i] < sumOfArray[minIndex])
        {
            minIndex = i;
        }
    }
    return minIndex + 1;
}
void printSumOfArray(int[] inputArray)
{
    for (int i = 0; i < inputArray.Length; i++)
    {
        Console.Write(inputArray[i] + " ");
    }
    Console.WriteLine();
} 

int[,] generatedArray = generate2DArray(3, 4, 1, 10);
print2DArray(generatedArray);
int[] sumOfArray = getSumArray(generatedArray);
printSumOfArray(sumOfArray);
int higthNumber = getMinInSumOfArray(sumOfArray);
Console.WriteLine($"{higthNumber} строка");
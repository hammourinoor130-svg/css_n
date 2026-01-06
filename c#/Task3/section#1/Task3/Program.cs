//task1//
int[,] arr1 = new int[3, 3];
for (int i = 0; i < 3; i++)
{
    for (int j = 0; j < 3; j++)
    {
        Console.Write($"Enter value [{i},{j}]: ");
        arr1[i, j] = int.Parse(Console.ReadLine());
    }
}

Console.WriteLine("\nThe array:");
for (int i = 0; i < 3; i++)
{
    for (int j = 0; j < 3; j++)
    {
        Console.Write(arr1[i, j] + "\t");
    }
    Console.WriteLine();
}
//task2//
int[,] arr2 = {
    { 1, 2, 3, 4 },
    { 5, 6, 7, 8 },
    { 9, 10, 11, 12 },
    { 13, 14, 15, 16 }
};
for (int i = 0; i < 4; i++)
{
    int rSum = 0;
    for (int j = 0; j < 4; j++)
    {
        rSum += arr2[i, j];
    }
    Console.WriteLine($"Sum of row {i} = {rSum}");
}

Console.WriteLine();
for (int j = 0; j < 4; j++)
{
    int cSum = 0;
    for (int i = 0; i < 4; i++)
    {
        cSum += arr2[i, j];
    }
    Console.WriteLine($"Sum of column {j} = {cSum}");
}
//task3//
        Random rand = new Random();
        int[,] arr3 = new int[5, 5];
        for (int i = 0; i < 5; i++)
        {
            for (int j = 0; j < 5; j++)
            {
                arr3[i, j] = rand.Next(1, 51);
            }
        }
        Console.WriteLine("The 5x5 array is:");
        for (int i = 0; i < 5; i++)
        {
            for (int j = 0; j < 5; j++)
            {
                Console.Write(arr3[i, j] + "\t");
            }
            Console.WriteLine();
        }
        Console.WriteLine("\nLargest value in each row:");
        for (int i = 0; i < 5; i++)
        {
            int max = arr3[i, 0];
            for (int j = 1; j < 5; j++)
            {
                if (arr3[i, j] > max)
                    max = arr3[i, j];
            }
            Console.WriteLine($"Row {i}: {max}");
        }
        Console.WriteLine("\nSmallest value in each column:");
        for (int j = 0; j < 5; j++)
        {
            int min = arr3[0, j];
            for (int i = 1; i < 5; i++)
            {
                if (arr3[i, j] < min)
                    min = arr3[i, j];
            }
            Console.WriteLine($"Column {j}: {min}");
        }
    



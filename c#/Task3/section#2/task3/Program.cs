//task4//
int[][] jagged = new int[3][];
 jagged[0] = new int[2]; 
 jagged[1] = new int[3];  
 jagged[2] = new int[4]; 

 for (int i = 0; i < jagged.Length; i++)
 {
     for (int j = 0; j < jagged[i].Length; j++)
     {
         Console.Write($"Enter value for row {i}, element {j}: ");
         jagged[i][j] = int.Parse(Console.ReadLine());
     }
 }
 Console.WriteLine("\nThe Jagged Array:");
 for (int i = 0; i < jagged.Length; i++)
 {
     for (int j = 0; j < jagged[i].Length; j++)
     {
         Console.Write(jagged[i][j] + "\t");
     }
     Console.WriteLine();
}
//task5//
 Console.Write("enter number of rows: ");
 int rows = int.Parse(Console.ReadLine());

 int[][] jagged2 = new int[rows][];
 for (int i = 0; i < rows; i++)
 {
     Console.Write($"enter number of elements for row {i}: ");
     int length = int.Parse(Console.ReadLine());
     jagged2[i] = new int[length];
 }

 for (int i = 0; i < rows; i++)
 {
     for (int j = 0; j < jagged2[i].Length; j++)
     {
         Console.Write($"Enter value for row {i}, element {j}: ");
         jagged2[i][j] = int.Parse(Console.ReadLine());
     }
 }
 Console.WriteLine("\nThe Jagged Array :");
 for (int i = 0; i < rows; i++)
 {
     for (int j = 0; j < jagged2[i].Length; j++)
     {
         Console.Write(jagged2[i][j] + "\t");
     }
     Console.WriteLine();
 }
//task6//
        Random rand = new Random();
        int[][] jagged3 = new int[5][];

        for (int i = 0; i < jagged3.Length; i++)
        {
            jagged3[i] = new int[i + 1];  
            for (int j = 0; j < jagged3[i].Length; j++)
            {
                jagged3[i][j] = rand.Next(1, 101); 
            }
        }

        for (int i = 0; i < jagged3.Length; i++)
        {
            int sum = 0;
            Console.Write($"Row {i}: ");
            for (int j = 0; j < jagged3[i].Length; j++)
            {
                Console.Write(jagged3[i][j] + "\t");
                sum += jagged3[i][j];
            }
            Console.WriteLine($" | Sum = {sum}");
        }
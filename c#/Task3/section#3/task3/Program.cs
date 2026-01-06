//task7//
        List<int> numbers = new List<int>();

        for (int i = 0; i < 5; i++)
        {
            Console.Write($"Enter number {i + 1}: ");
            int num = int.Parse(Console.ReadLine());
            numbers.Add(num);
        }

        Console.WriteLine("\nThe numbers in the list are:");
        foreach (int num in numbers)
        {
            Console.WriteLine(num);
}
    //task8//
        List<string> studentNames = new List<string>();

        for (int i = 0; i < 5; i++)
        {
            Console.Write($"Enter name {i + 1}: ");
            string name = Console.ReadLine();
            studentNames.Add(name);
        }

        studentNames.Sort();

        Console.WriteLine("\nStudent names sorted alphabetically:");
        foreach (string name in studentNames)
        {
            Console.WriteLine(name);
}
    //task9//
        List<int> Numbers = new List<int>();
        int input;

        Console.WriteLine("Enter numbers (enter -1 to stop):");
        while (true)
        {
            input = int.Parse(Console.ReadLine());
            if (input == -1)
                break;
            Numbers.Add(input);
        }

        Console.WriteLine("\nNumbers entered:");
        foreach (int num in Numbers)
            Console.WriteLine(num);

        double average = Numbers.Count > 0 ? Numbers.Average() : 0;
        Console.WriteLine($"\nAverage: {average}");

       
        if (Numbers.Count > 0)
        {
            int max = Numbers.Max();
            int min = Numbers.Min();
            Console.WriteLine($"Largest number: {max}");
            Console.WriteLine($"Smallest number: {min}");
        }

        
        Numbers.Sort();
        Console.WriteLine("\nNumbers sorted ascending:");
        foreach (int num in Numbers)
            Console.WriteLine(num);
    
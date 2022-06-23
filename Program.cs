Console.WriteLine("Evens numbers betwwn 2 numbers\n");

Console.WriteLine("Enter the first number: ");
int firtsNumber = Int32.Parse(Console.ReadLine() ?? "o");

Console.WriteLine("Enter the second number: ");
int secondNumber = Int32.Parse(Console.ReadLine() ?? "1000");

for (int i = firtsNumber; i <= secondNumber; i++)
{
    if (i % 2 == 0)
    {
        Console.WriteLine(i);
    }
}

Console.WriteLine("End of the program");
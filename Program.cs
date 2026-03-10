// See https://aka.ms/new-console-template for more information

Console.WriteLine("Hello, World!");
Console.BackgroundColor = ConsoleColor.Green;
Console.ForegroundColor = ConsoleColor.Black;
Console.WriteLine("Hello, World!");

static double CalculateMin(int[] values)
{
    return 0.0;
}

static double CalculateAverage(int[] values)
{
    double sum = 0;

    for (int i = 0; i < values.Length; i++)
    {
        sum += values[i];
    }

    return sum / values.Length;
}

//add calculateMac function here
static double CalculateMax(int[] values)
{
    return 0.0;
}

static double CalculateMinn(int[] values)
{
    return 0.0;
}
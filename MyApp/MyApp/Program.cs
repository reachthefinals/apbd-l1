// See https://aka.ms/new-console-template for more information

Console.WriteLine("Hello, World!");

static double GetAverage(int[] numbers)
{
    int sum = 0;
    foreach (var number in numbers)
    {
        sum += number;
    }

    return (double)sum / numbers.Length;
}

static double GetMax(int[] numbers)
{
    int max = Int32.MinValue;
    foreach(var number in numbers)
    {
        if(number > max) {
            max = number;
        }
    }

    return max;
}

int[] arr = { 2, 1, 31, 6, 9 };
Console.WriteLine(GetAverage(arr));
Console.WriteLine(GetMax(arr));

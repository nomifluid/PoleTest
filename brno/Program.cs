bool Run()
{
    Console.WriteLine("Kolik čísel?");
    int length = int.Parse(Console.ReadLine());
    if (length <= 0) return false;

    Console.WriteLine("Zadej čísla");
    int[] numbers = new int[length];
    for (int i = 0; i < length; i++)
    {
        numbers[i] = int.Parse(Console.ReadLine());
    }

    Console.WriteLine("Zadaná čísla:");
    foreach (int n in numbers)
    {
        Console.WriteLine(n);
    }

    int[] average = { numbers[0], numbers[length - 1] };
    Console.WriteLine($"Průměr prvního a posledního čísla je {average.Average()}.");

    return true;
}

try
{
    while (Run())
    {

    }
}
catch { }

Console.WriteLine("Nashle!");
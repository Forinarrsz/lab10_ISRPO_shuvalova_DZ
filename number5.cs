using System;

class Program1
{
    static async Task Main()
    {
        Console.WriteLine("Ждём данные...");
        int result = await GetDataAsync();
        Console.WriteLine("Данные получены!");
        Console.WriteLine($"Результат: {result}");
    }

    static async Task<int> GetDataAsync()
    {
        await Task.Delay(2000);
        return 42;
    }
}
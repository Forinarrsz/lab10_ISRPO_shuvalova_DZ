using System;
using System.Collections.Generic;

interface IPrintable
{
    void PrintInfo();
}

class Book : IPrintable
{
    public string Title { get; set; }
    public string Author { get; set; }

    public void PrintInfo()
    {
        Console.WriteLine($"Книга: {Title}, автор: {Author}");
    }
}

class Magazine : IPrintable
{
    public string Name { get; set; }
    public int IssueNumber { get; set; }

    public void PrintInfo()
    {
        Console.WriteLine($"Журнал: {Name}, номер выпуска: {IssueNumber}");
    }
}

class Program3
{
    static void Main()
    {
        List<IPrintable> printables = new List<IPrintable>
        {
            new Book { Title = "Война и мир", Author = "Лев Толстой" },
            new Magazine { Name = "National Geographic", IssueNumber = 5 },
            new Book { Title = "Преступление и наказание", Author = "Ф.М. Достоевский" },
            new Magazine { Name = "Time", IssueNumber = 12 }
        };

        foreach (var item in printables)
        {
            item.PrintInfo();
        }
    }
}
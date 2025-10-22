interface IPerson
{
    string GetDescription();
}

class Student : IPerson
{
    public string Name;
    public int Age;
    public string Specialty;
    public string GetDescription() => $"{Name}, {Age} лет, {Specialty}";
}

class Teacher : IPerson
{
    public string Name;
    public string Department;
    public string GetDescription() => $"{Name}, кафедра {Department}";
}

class Program
{
    static async Task Main()
    {
        var students = await LoadStudentsAsync();
        var people = new List<IPerson>();
        people.AddRange(students);
        people.Add(new Teacher { Name = "Иванов", Department = "Математика" });
        people.Add(new Teacher { Name = "Петров", Department = "Физика" });

        var studentsOver20 = people.OfType<Student>().Where(s => s.Age > 20);
        Console.WriteLine("Студенты старше 20:");
        foreach (var s in studentsOver20)
            Console.WriteLine(s.GetDescription());

        var mathTeachers = people.OfType<Teacher>().Where(t => t.Department == "Математика");
        Console.WriteLine("\nУчителя кафедры Математика:");
        foreach (var t in mathTeachers)
            Console.WriteLine(t.GetDescription());

        var sorted = people.OrderBy(p =>
        {
            if (p is Student s) return s.Name;
            if (p is Teacher t) return t.Name;
            return "";
        });
        Console.WriteLine("\nОтсортировано по имени:");
        foreach (var p in sorted)
            Console.WriteLine(p.GetDescription());
    }

    static async Task<List<Student>> LoadStudentsAsync()
    {
        await Task.Delay(2000);
        return new List<Student>
        {
            new Student { Name="Алексей", Age=23, Specialty="Информатика" },
            new Student { Name="Мария", Age=19, Specialty="История" }
        };
    }
}
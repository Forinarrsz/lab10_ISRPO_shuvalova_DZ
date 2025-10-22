using System.Linq;
namespace lab11_ISRPO
{
    internal class Program
    {
        static void Main(string[] args)
        {//1
            var student = new { Name = "Иван", Age = 20, Group = "A1" };
            Console.WriteLine($"Name: {student.Name}, Age: {student.Age}, Group: {student.Group}");

            var students = new List<dynamic>
        {
            new { Name = "Анна", Age = 21, Group = "ISP-231" },
            new { Name = "Петр", Age = 22, Group = "ISP-231" },
            new { Name = "Мария", Age = 19, Group = "ISP-242" },
            new { Name = "Дмитрий", Age = 23, Group = "ISP-253" },
            new { Name = "Ольга", Age = 20, Group = "ISP-211" }
        };
            Console.WriteLine("{0,-10} | {1,-5} | {2,-5}", "Name", "Age", "Group");
            Console.WriteLine(new string('-', 30));
            foreach (var s in students)
            {
                Console.WriteLine("{0,-10} | {1,-5} | {2,-5}", s.Name, s.Age, s.Group);
            }


            //2
            List<int> numbers = new List<int>();
            for (int i = 1; i <= 20; i++)
            {
                numbers.Add(i);
            }

            List<int> evenNumbers = numbers.FindAll(n => n % 2 == 0);
            List<int> multiplesOfThree = numbers.FindAll(n => n % 3 == 0);

            Console.WriteLine("Чётные числа:");
            foreach (var num in evenNumbers)
            {
                Console.WriteLine(num);
            }

            Console.WriteLine("Кратные 3:");
            foreach (var num in multiplesOfThree)
            {
                Console.WriteLine(num);
            }

            //4
            string[] cities = { "Киев", "Москва", "Волгоград","Калуга", "Волжский", "Лондон", "Караганда", "Париж", "Кантон" };

            var kCities = cities.Where(c => c.StartsWith("К"));
            var sortedCities = cities.OrderBy(c => c.Length);
            var longCities = cities.Where(c => c.Length > 6);

            Console.WriteLine("Города, начинающиеся на 'К':");
            foreach (var c in kCities)
                Console.WriteLine(c);

            Console.WriteLine("По длине:");
            foreach (var c in sortedCities)
                Console.WriteLine(c);

            Console.WriteLine("Длина более 6 символов:");
            foreach (var c in longCities)
                Console.WriteLine(c);





        }
    }
}

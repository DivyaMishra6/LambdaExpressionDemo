using LambdaExpressionProblem;

namespace LambadaPracticeProblem
{
    public class Program
    {
        public static void Main(string[] args)
        {
            List<Student> studentList = new List<Student>
        {
            new Student { Id = 1, Name = "Divya", PhoneNumber = "845236978", Address = "Lucknow", Age = 25 },
            new Student { Id = 2, Name = "Shweta", PhoneNumber = "9752235812", Address = "Alhabad", Age = 26 },
            new Student { Id = 3, Name = "Madhu", PhoneNumber = "9863517478", Address = "Deoria", Age = 28 },
            new Student { Id = 1, Name = "Priya", PhoneNumber = "845236978", Address = "Lucknow", Age = 18 },
            new Student { Id = 2, Name = "Shiva", PhoneNumber = "9752235812", Address = "Alhabad", Age = 14 },
            new Student { Id = 3, Name = "Pari", PhoneNumber = "9863517478", Address = "Deoria", Age = 12}
        };

            Console.WriteLine("Student Details:");
            studentList.ForEach(student =>
            {
                Console.WriteLine($"ID: {student.Id}");
                Console.WriteLine($"Name: {student.Name}");
                Console.WriteLine($"Phone Number: {student.PhoneNumber}");
                Console.WriteLine($"Address: {student.Address}");
                Console.WriteLine($"Age: {student.Age}");
                Console.WriteLine();
            });
        }
    }

}
using LambdaExpressionProblem;

namespace LambadaPracticeProblem
{
    public class Program
    {
        public static void Main(string[] args)
        {

            List<Student> students = new List<Student>();

            // Add default values to the list
            students.Add(new Student { Id = 1, Name = "Priya", PhoneNumber = "7218533707", Address = "Lucknow", Age = 25 });
            students.Add(new Student { Id = 2, Name = "Pooja", PhoneNumber = "922429072", Address = "Deoria", Age = 23 });
            students.Add(new Student { Id = 3, Name = "Pari", PhoneNumber = "9856734567", Address = "Aalhabad", Age = 18 });
            students.Add(new Student { Id = 4, Name = "Shiva", PhoneNumber = "789654231", Address = "mumbai", Age = 14 });
            students.Add(new Student { Id = 5, Name = "Pihu", PhoneNumber = "9527616356", Address = "Delhi", Age = 16 });

            // Display all student details
            Console.WriteLine("All Student Details:");
            foreach (var student in students)
            {
                Console.WriteLine($"Id: {student.Id}, Name: {student.Name}, Phone Number: {student.PhoneNumber}, Address: {student.Address}, Age: {student.Age}");
            }



            // Sort students data in descending order based on TotalMarks (not mentioned in the Student class)
            // Assuming you want to sort by Age in descending order
            var sortedStudents = students.OrderByDescending(student => student.Age);
            Console.WriteLine("\nStudents sorted by age in descending order:");
            foreach (var student in sortedStudents)
            {
                Console.WriteLine($"Id: {student.Id}, Name: {student.Name}, Phone Number: {student.PhoneNumber}, Address: {student.Address}, Age: {student.Age}");
            }

            // Display all the student records in each address
            var studentsByAddress = students.GroupBy(student => student.Address);
            Console.WriteLine("\nStudents by Address:");
            foreach (var group in studentsByAddress)
            {
                Console.WriteLine($"Address: {group.Key}");
                foreach (var student in group)
                {
                    Console.WriteLine($"Id: {student.Id}, Name: {student.Name}, Phone Number: {student.PhoneNumber}, Age: {student.Age}");
                }
                Console.WriteLine();
            }

            // Fetch first three students records
            var firstThreeStudents = students.Take(3);
            Console.WriteLine("\nFirst three students:");
            foreach (var student in firstThreeStudents)
            {
                Console.WriteLine($"Id: {student.Id}, Name: {student.Name}, Phone Number: {student.PhoneNumber}, Address: {student.Address}, Age: {student.Age}");
            }


            // Search for a particular student based on name using lambda expression

            var searchName = "Pari";
            var searchedStudent = students.FirstOrDefault(student => student.Name.Equals(searchName, StringComparison.OrdinalIgnoreCase));
            if (searchedStudent != null)
            {
                Console.WriteLine($"\nStudent found - Id: {searchedStudent.Id}, Name: {searchedStudent.Name}, Phone Number: {searchedStudent.PhoneNumber}, Address: {searchedStudent.Address}, Age: {searchedStudent.Age}");
            }
            else
            {
                Console.WriteLine($"\nStudent with name '{searchName}' not found.");
            }
        }
    }

}
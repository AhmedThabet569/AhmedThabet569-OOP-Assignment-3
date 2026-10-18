namespace Generics
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            StudentStore studentStore = new();
            studentStore.AddStudent(new Student { Id=1,Name= "ahmed" });
            studentStore.AddStudent(new Student { Id = 2, Name = "ali" }); 
            Student _student = studentStore.GetById(1);
            Console.WriteLine($"id is {_student.Id} name is {_student.Name}, ");

        }
    }
}

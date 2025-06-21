namespace Prototype
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Teacher teacher = new Teacher("John Doe", "Mathematics");
            Teacher teacherClone = (Teacher)teacher.ShallowClone();
            Console.WriteLine($"Original Teacher: {teacher.Name}, Course: {teacher.Course}");
            Console.WriteLine($"Cloned Teacher: {teacherClone.Name}, Course: {teacherClone.Course}");

            Student student = new Student("Jane Smith", teacherClone);
            Student studentClone = (Student)student.ShallowClone();
            Console.WriteLine($"Original Student: {student.Name}, Teacher: {student.Teacher.Name}");
            Console.WriteLine($"Cloned Student: {studentClone.Name}, Teacher: {studentClone.Teacher.Name}");

            teacherClone.Name = "Jane Doe"; // Change the name of the cloned teacher    
            Console.WriteLine($"After modifying cloned teacher:");
            Console.WriteLine($"Original Teacher: {teacher.Name}, Course: {teacher.Course}");
            Console.WriteLine($"Cloned Teacher: {teacherClone.Name}, Course: {teacherClone.Course}");   
        }
    }
}

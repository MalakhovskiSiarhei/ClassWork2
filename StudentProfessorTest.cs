namespace ClassWork2
{
    internal class StudentProfessorTest 
    {
        static void Main(string[] args)
        {
            Person person = new Person();
            person.Greet("Приветствую");

            Person student = new Person();
            student.Greet("Hello");
            student.SetAge(12);

            Person teacher = new Person();
            teacher.Greet("Приветствую");
            //teacher.SetAge(int age = Convert.ToInt32(Console.ReadLine());
            teacher.SetAge(22);
            teacher.Explane("Объясняю");
        }
    }
}
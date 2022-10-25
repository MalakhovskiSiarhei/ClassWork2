namespace ClassWork2
{
    internal class StudentProfessorTest 
    {
        public void Main(string[] args)
        {
            Person person = new Person();
            person.Greet("Приветствую");

            Person student = new Person();
            student.Greet("Hello");
            student.SetAge();

            Person teacher = new Person();
            teacher.Greet("Приветствую");
            teacher.SetAge();
            teacher.Explain();
        }
    }
}
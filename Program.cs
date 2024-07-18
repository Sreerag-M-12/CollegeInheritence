using System.Runtime.ConstrainedExecution;
using CollegeInheritence.Models;

namespace CollegeInheritence
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person(101,"Ramesh",new DateTime(1990,12,10));
            Student student = new Student(102, "Suresh",new DateTime(2002,11,9) , "Computer Engg");
            Professor professor = new Professor(103, "Ajesh", new DateTime(1980, 11, 9), 55000);

            PrintOutput(person);
            PrintOutput(student);
            PrintOutput(professor);

        }

        static void PrintOutput(Person person)
        {
            
            Console.WriteLine($"==========={person.GetType().Name}===========");
            Console.WriteLine(person.PrintDetails());
            
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollegeInheritence.Models
{
    internal class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime DateOfBirth { get; set; }
     
        public Person() { }

        public Person(int id, string name, DateTime dob)
        {
            Id = id;
            Name = name;
            DateOfBirth = dob;
         
        }

        public virtual string PrintDetails()
        {
            return $"User Id: {Id} \n" +
                $"User Name: {Name} \n" +
                $"Date of Birth: {DateOfBirth} \n" ;
        }
    }
}

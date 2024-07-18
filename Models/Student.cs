using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollegeInheritence.Models
{
    internal class Student:Person
    {
        public string Branch { get; set; }

        public Student() { }
        public Student(int id, string name, DateTime dob, string branch) : base(id, name, dob)
        {
            Branch = branch;
        }
        public override string PrintDetails()
        {
            return $"{base.PrintDetails()}" +
                $"Branch: {Branch}";
        }
    }
}

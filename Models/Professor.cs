using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollegeInheritence.Models
{
    internal class Professor:Person
    {
        public double Salary { get; set; }

        public Professor() { }
        public Professor(int id, string name, DateTime dob, double sal) : base(id, name, dob)
        {
            Salary=sal;
        }
        public override string PrintDetails()
        {
            return $"{base.PrintDetails()}" +
                $"Salary: {Salary}";
        }
    }
}

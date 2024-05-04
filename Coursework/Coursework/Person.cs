using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coursework
{
    // Person class
    public class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Telephone { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Role { get; set; }
    }

    // Administrator class (inherits from Person)
    public class Administrator : Person
    {
        public bool FullTime { get; set; }
        public int WorkingHours { get; set; }
        public int Salary { get; set; }
        public int PersonId { get; set; }
    }

    // TeachingStaff class (inherits from Person)
    public class TeachingStaff : Person
    {
        public decimal Salary { get; set; }
        public string Subjects { get; set; }
        public int PersonId { get; set; }
    }

    // Student class (inherits from Person)
    public class Student : Person
    {
        public string CurrentSubjects { get; set; }
        public string PreviousSubjects { get; set; }

        public int PersonId { get; set; }
    }

}

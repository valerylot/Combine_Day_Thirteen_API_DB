using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Combine_Day_Thirteen_API_DB.Models
{
    public class Student : BaseEntity
    {
        // public int Id {get; set;} // no longer need because inheriting base entity

        public string FirstName {get; set;}

        public string LastName {get; set;}

        public string Email {get; set;}
    }
}

//Student student = new Student();
//student.FirstName = "Isaiah" {this is the set}
//we would also be able to Console.WriteLine(Student.LastName); {get}
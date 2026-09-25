using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Combine_Day_Thirteen_API_DB.Models;

namespace Combine_Day_Thirteen_API_DB.Services
{
    public interface IStudentServices
    {
        //2 methods. A method that gets all students, and a method that creates a student

        List<Student> GetAll();

        Student AddStudent(Student newStudent); //parameters are just placeholders for incoming information

        Student Replace (int id, Student student);

        Student Patch (int id, Student changes);
    }
}
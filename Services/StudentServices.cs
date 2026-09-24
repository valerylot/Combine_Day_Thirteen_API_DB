using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Combine_Day_Thirteen_API_DB.Data;
using Combine_Day_Thirteen_API_DB.Models;

namespace Combine_Day_Thirteen_API_DB.Services
{
    public class StudentServices : IStudentServices
    {
        private AppDbContext _db;
        
        //CONSTRUCTOR 
        public StudentServices(AppDbContext db) //Constructor must have same name as Class
        {
            _db = db;

            //when our StudentServices Class is called
            //The constructor runs automatically
            //we pass in our database as a parameter and set inside of our _db variable
        }

        public List<Student> GetAll()
        {
            return _db.Students.ToList();
        }

        public Student AddStudent(Student newStudent)
        {
            //the database assigns the ID so we can ignore any ID the client sent
            newStudent.Id = 0;

            _db.Students.Add(newStudent); //this stages the add

            _db.SaveChanges(); //actually writes it to our students.db

            return newStudent;
        }
    }
}
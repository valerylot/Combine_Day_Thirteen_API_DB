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

        public Student Replace (int id, Student student)
        {
            //we must FIND the student that we are updating
            //and store that student and eventually change it

            Student? existingStudent = _db.Students.Find(id); 
            //if we find something in the database EF Core tracks it

            if(existingStudent == null)
            {
                return null;
            }

            existingStudent.FirstName = student.FirstName;
            existingStudent.LastName = student.LastName;
            existingStudent.Age = student.Age;
            existingStudent.IsVaccinated = student.IsVaccinated;

            //_db.Students.Update(existingStudent); //this is the old way
            _db.SaveChanges();
            //when we pull an entity from our DB it is tracked and ef core knows if changes are being made to it
            //it is not a simple copy of the information

            return existingStudent;
        }

        //PATCH: changes ONLY the fields the client sent.
        //A field the client left out arrives as "" or (blank / null), so blank means leave it alone
        public Student Patch(int id, Student changes)
        {
            Student? existingStudent = _db.Students.Find(id);

            if(existingStudent == null)
            {
                return null;
            }

            //if a field has a blank or white space, we do NOT change it
            //IsNullOrWhiteSpace id true for null, "" and " "
            if (string.IsNullOrWhiteSpace(changes.FirstName) == false)
            {
                existingStudent.FirstName = changes.FirstName;
            }

            if(string.IsNullOrWhiteSpace(changes.LastName) != true)
            {
                existingStudent.LastName = changes.LastName;
            }

            if (!string.IsNullOrWhiteSpace(changes.Email))
            {
                existingStudent.Email = changes.Email;
            }
            //EF Core tracks our entity automatically, but it doesnt save it so that's why we do .SaveChanges();
            _db.SaveChanges();

            return existingStudent;
        }
    }
}
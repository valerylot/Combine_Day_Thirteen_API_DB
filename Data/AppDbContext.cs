using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Combine_Day_Thirteen_API_DB.Models;
using Microsoft.EntityFrameworkCore;

namespace Combine_Day_Thirteen_API_DB.Data
{
    public class AppDbContext : DbContext //Db Context is our connection to the Database
    {
        //Constructor runs automatically when a class is called (a special kind of method)
        //Constructor method and class share the same name
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
            
        }
        //This IS the student's table as far as our C# code is concerned
        public DbSet<Student> Students{get; set;}
    }
}
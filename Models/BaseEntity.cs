using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Combine_Day_Thirteen_API_DB.Models
{
    public class BaseEntity
    {
        public int Id {get; set;}
        public string Attendance {get; set;} = string.Empty;
        public int? Age {get; set;} = null;
        public bool IsVaccinated {get; set;}

    }
}
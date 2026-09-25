
namespace Combine_Day_Thirteen_API_DB.Models
{
    public class Staff : BaseEntity
    {
    //    public int Id {get; set;} //this is Id is our unique identifier for our table 
    // no longer need Id because it's INHERITING from BaseEntity

       public string FullName {get; set;} = string.Empty;

       public string Job {get; set;} = string.Empty;

       public bool HasComputer {get; set;} = false; //we can assign values to our properties


    }
}
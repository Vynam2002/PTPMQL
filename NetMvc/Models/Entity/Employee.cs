using System.ComponentModel.DataAnnotations;
namespace NetMvc.Models.Entity
{
    public class Employee : Person
    {
        public string EmployeeID { get; set; }
        public string FullName { get; set; }
    }
}
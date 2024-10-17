
using System.Security.AccessControl;
using System.ComponentModel.DataAnnotations;
namespace DEMO.Models
{
    public class Employee
    {
        [Key]
        public int EmployeeID { get; set; }
        public string FullName { get; set; }
        public string Address { get; set; }
    }
}

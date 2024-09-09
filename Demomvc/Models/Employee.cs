using System.ComponentModel.DataAnnotations;

namespace Demomvc.Models
{
    public class Employee
    {
        [Key]
        public string EmployeeId { get; set; }
        public int Age { get; set; }
        public string PersonId { get; set; }
        public string FullName { get; set; }




    }
}
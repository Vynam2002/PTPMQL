using System.Security.AccessControl;
using System.ComponentModel.DataAnnotations;
namespace MVC.Models
{
    public class Employee
    {
        [Key]
        public int Tuoi { get; set; }
        public string GioiTinh { get; set; }
    }
}
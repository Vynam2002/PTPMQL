using System.Security.AccessControl;
using System.ComponentModel.DataAnnotations;
namespace MVC.Models

{
    public class Person
    {
        [Key]
        public string CCCD { get; set; }

        public string HoVaTen { get; set; }

        public string DiaChi { get; set; }
    }
}
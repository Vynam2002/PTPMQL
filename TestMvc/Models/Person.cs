using System.Security.AccessControl;
using System.ComponentModel.DataAnnotations;
namespace TestMvc.Models 
{
    public class Person
    {
        public string FullName { get; set; }
        public int Age { get; set; }
        public string Address { get; set; }
    }
}
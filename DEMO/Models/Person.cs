

using System.ComponentModel.DataAnnotations;
namespace DEMO.Models
{
    public class Person
    {
        [Key]
        public int PersonID { get; set; }
        public string FullName { get; set; }
        public string Address { get; set; }
    }
}

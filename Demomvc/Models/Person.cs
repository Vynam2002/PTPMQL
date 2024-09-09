using System.ComponentModel.DataAnnotations;

namespace Demomvc.Models
{
    public class Person
    {
        [Key]
        public string PersonId { get; set; }
        public string FullName { get; set; }




    }
}
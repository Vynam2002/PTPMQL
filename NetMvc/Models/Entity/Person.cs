using System.Security.AccessControl;
using System.ComponentModel.DataAnnotations;
namespace NetMvc.Models.Entity

{
    public class Person 
    {
        [Key]     
        public string PersonID { get; set; }
        public string FullName { get; set; }
    }
}
using System.Security.AccessControl;
using System.ComponentModel.DataAnnotations;
namespace NetMvc.Models.Entity

{
    public class Student 
    {
        [Key]     
        public string StrudentID { get; set; }
        public string FullName { get; set; }
    }
}
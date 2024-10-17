using System.Security.AccessControl;
using System.ComponentModel.DataAnnotations;

{
    public class Person
    {
        [Key]
        public int CCCD { get; set; }
        public string HoTen { get; set; }
        public string QueQuan { get; set; }
       
    }
}

using System.ComponentModel.DataAnnotations;

namespace Demomvc.Models {

    public class Student
    {
        [Key]
        public int masinhvien   { get; set; }
        public string hovaten { get; set; }
    }
}


using System.Security.AccessControl;
using System.ComponentModel.DataAnnotations;
namespace DEMO.Models
{
    public class Person
    {
        [Key]
        public int CCCD { get; set; }
        public string HOTEN { get; set; }
        public string QUEQUAN{ get; set; }
    }
}

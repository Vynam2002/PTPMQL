using System.ComponentModel.DataAnnotations;

namespace Demomvc.Models
{
    public class HeThongPhanPhoi
    {
        [Key]
        public string MaHTPP { get; set; }
        public string TenHTPP { get; set; }



    }
}
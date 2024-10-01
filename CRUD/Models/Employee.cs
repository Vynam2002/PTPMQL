using System.Security.AccessControl;
using System.ComponentModel.DataAnnotations;
namespace CRUD.Models

{
    public class Employee : Person
    {
      
        public int Tuoi { get; set; }
        public string GioiTinh { get; set; }

    }
}
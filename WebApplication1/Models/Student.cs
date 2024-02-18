using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Models
{
    public class Student
    {
        public int Id { get; set; }
        [StringLength(50), Required(ErrorMessage = "{0} Alanı Gereklidir!")]
        public string Name { get; set; }
        [StringLength(50), Required(ErrorMessage = "{0} Alanı Gereklidir!")]
        public string Surname { get; set; }
        [StringLength(50)]
        public string? Email { get; set; }
        [StringLength(15)]
        public string? Phone { get; set; }
        public string? Address { get; set; }
        [StringLength(150)]
        public string? StudentClass { get; set; }
        [StringLength(100)]
        public string? City { get; set; }
    }
}

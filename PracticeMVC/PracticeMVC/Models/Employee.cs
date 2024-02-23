using System.ComponentModel.DataAnnotations;

namespace PracticeMVC.Models
{
    public class Employee
    {
        [Key]
        public int EmpId { get; set; }

        [Required]
        public string EmpName { get; set; }

        [Required]
        public string Gender { get; set; }

        public string? City { get; set; }
    }
}

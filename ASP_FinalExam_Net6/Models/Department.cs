
using System.ComponentModel.DataAnnotations;

namespace ASP_FinalExam_Net6.Models
{
    public class Department
    {
        [Key]
        public int Id { get; set; }

        [Display(Name ="Full Name")]
        [Required(ErrorMessage = "Please enter name"), MaxLength(100)]
        public string Name { get; set; }

        
        [MinLength(0)]
        public int EmployeeCount { get; set; }

        public ICollection<Employee> Employees { get; set; }

    }
}

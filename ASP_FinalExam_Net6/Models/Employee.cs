using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Xml.Linq;
using Xunit.Sdk;

namespace ASP_FinalExam_Net6.Models
{
    public class Employee
    {
        [Key]
        public int Id { get; set; }

        [Display(Name = "Full Name")]
        [Required(ErrorMessage = "Please enter name"), MaxLength(100)]
        public string Name { get; set; }

       
        public Boolean IsManager { get; set; }

        [ForeignKey("Department")]
        public int? DepartmentId { get; set; }
        public Department Department { get; set; }
    }
}

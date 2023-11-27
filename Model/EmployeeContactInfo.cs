using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;
 

namespace Employee_Management_System.Model
{
    public class EmployeeContactInfo
    {
        [Key]
        public Guid EmpId { get; set; }

        [Required]
        public string? EmpName { get; set; }
        public string? Email { get; set; }

        [NotNull]
        public string PhoneNumber { get; set; }
        public string? Address { get; set; }
        public DateTime CreatedDateTime { get; set; } = DateTime.Now;

    }
}

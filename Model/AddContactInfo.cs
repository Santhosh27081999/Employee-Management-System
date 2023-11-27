using System.Diagnostics.CodeAnalysis;

namespace Employee_Management_System.Model
{
    public class AddContactInfo
    {
        public string? EmpName { get; set; }
        public string? Email { get; set; }

        [NotNull]
        public string PhoneNumber { get; set; }
        public string? Address { get; set; }
    }
}

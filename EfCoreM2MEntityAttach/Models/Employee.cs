using System.ComponentModel.DataAnnotations;

namespace EfCoreM2MEntityAttach.Models
{
    public partial class Employee
    {
        [Key]
        public int EmployeeId { get; set; }
        public string LastName { get; set; } = string.Empty;
        public string FirstName { get; set; } = string.Empty;
        public DateTime? BirthDate { get; set; }
        public DateTime? HireDate { get; set; }
        public string City { get; set; } = string.Empty;
        public string Country { get; set; } = string.Empty;
        public List<Territory> Territories { get; set; } = new();
    }
}

using System.ComponentModel.DataAnnotations;

namespace EfCoreM2MEntityAttach.Models
{
    public partial class Territory
    {
        [Key]
        public string TerritoryId { get; set; } = string.Empty;
        public string TerritoryDescription { get; set; } = string.Empty;
        public List<Employee> Employees { get; set; } = new();
    }
}

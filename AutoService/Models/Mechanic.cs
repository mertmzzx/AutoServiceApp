using System.ComponentModel.DataAnnotations;

namespace AutoService.Models
{
    public class Mechanic
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Mechanic name is required")]
        [StringLength(100, ErrorMessage = "Name cannot exceed 100 chars")]
        public string Name { get; set; } = string.Empty;

        [Phone(ErrorMessage = "Invalid phone number")]
        public string? Phone { get; set; }

        // Navigation
        public List<ServiceRecord> ServiceRecords { get; set; } = new();
    }
}

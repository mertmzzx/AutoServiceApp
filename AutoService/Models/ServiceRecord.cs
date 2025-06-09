using System.ComponentModel.DataAnnotations;

namespace AutoService.Models
{
    public class ServiceRecord
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Date is required")]
        public DateTime Date { get; set; }

        [Required(ErrorMessage = "Description is required")]
        [StringLength(200, ErrorMessage = "Max 200 characters allowed")]
        public string Description { get; set; } = string.Empty;

        [Range(0.01, double.MaxValue, ErrorMessage = "Cost must be positive")]
        public decimal Cost { get; set; }

        // FKs
        [Required(ErrorMessage = "Car must be chosen or created")]
        public int CarId { get; set; }
        public Car Car { get; set; } = null!;

        [Required(ErrorMessage = "Mechanic must be chosen")]
        public int MechanicId { get; set; }
        public Mechanic Mechanic { get; set; } = null!;
    }
}

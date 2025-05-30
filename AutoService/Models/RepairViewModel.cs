using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoService.Models
{
    public class RepairViewModel
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public string Description { get; set; } = string.Empty;
        public decimal Cost { get; set; }
        public string CarPlate { get; set; } = string.Empty;
        public string MechanicName { get; set; } = string.Empty;
    }
}

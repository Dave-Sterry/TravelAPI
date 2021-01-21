using System.ComponentModel.DataAnnotations;

namespace TravelAPI.Models
{
    public class Packlist
    {
        public int PacklistId { get; set; }
        [Required]
        [StringLength(400)]
        public string Items { get; set; }
    }
}
using System.ComponentModel.DataAnnotations;

namespace TravelAPI.Models
{
    public class PackList
    {
        public int ListId { get; set; }
        [Required]
        [StringLength(400)]
        public string Items { get; set; }
    }
}
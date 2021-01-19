using System.ComponentModel.DataAnnotations;

namespace TravelAPI.Models
{
    public class City
    {
        public int CityId { get; set; }
        [Required]
        [StringLength(50)]
        public string Name { get; set; }
        [Required]
        public string Attraction { get; set; }
        [Required]
        [Range(1, 10, ErrorMessage = "Rating must be between 1-10")]
        public int Rating { get; set; }
    }
}
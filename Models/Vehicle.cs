using System.ComponentModel.DataAnnotations;

namespace OD533_BlazorApp.Models
{
    public class Vehicle
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Make is required")]
        public required string Make { get; set; }

        [Required(ErrorMessage = "Model is required")]
        public required string Model { get; set; }

        [Range(1, int.MaxValue, ErrorMessage = "Year must be a positive number")]
        public int Year { get; set; }

        public string? LicensePlate { get; set; }
    }
}

using System.ComponentModel.DataAnnotations;

namespace BlazorApp8.Models
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

        // Costruttore che inizializza Make e Model
        public Vehicle()
        {
            Make = string.Empty;
            Model = string.Empty;
        }

    }
}

using System.ComponentModel.DataAnnotations;

namespace SharedLibrary.Models
{
    public class HealthEdu
    {
        public int Id { get; set; }
        [Required]
        public string Class {  get; set; } = string.Empty;
        public string Title { get; set; } = string.Empty;
        [Required]
        public string? Link { get; set; }
       


    }
}

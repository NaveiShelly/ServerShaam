using System.ComponentModel.DataAnnotations;

namespace Server.Models
{
    public class TaskModel
    {
        public int Id { get; set; }

        [Required]
        public string Title { get; set; } = string.Empty;

        public string Description { get; set; } = string.Empty;

        [Required]
        public string Priority { get; set; } = "Medium";

        [Required]
        public string DueDate { get; set; } = ""; // Use string to match Angular's format

        [Required]
        public string Status { get; set; } = "Pending";
    }
}

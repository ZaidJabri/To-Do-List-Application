using System.ComponentModel.DataAnnotations;

namespace To_Do_List_Application.Models
{
    public class TaskItem
    {
        [Required]
        public required int Id { get; set; }
        [Required]
        [MaxLength(100)]
        public required string Title { get; set; }
        [Required]
        public Boolean IsCompleted { get; set; } = false;
    }
}

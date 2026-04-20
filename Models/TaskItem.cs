using System.ComponentModel.DataAnnotations;

namespace TaskManagerApp.Models
{
    public class TaskItem
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Title is needed")]
        public string Title { get; set; }

        [Required(ErrorMessage = "Description is needed")]
        public string Description { get; set; }

        public bool IsCompleted { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.Now;
    }
}

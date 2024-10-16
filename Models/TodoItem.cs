using System.ComponentModel.DataAnnotations;

namespace InteractiveTodoApp.Models
{
    public class TodoItem
    {
        // Unique identifier for each Todo item
        public int Id { get; set; }

        // Title of the Todo item
        [Required] // Ensures that the title is provided
        [StringLength(100)] // Limits the length of the title
        public string Title { get; set; }

        // Indicates whether the Todo item is completed
        public bool IsCompleted { get; set; } = false; // Defaults to false when created
    }
}

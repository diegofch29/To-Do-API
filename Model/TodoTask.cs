using System.ComponentModel.DataAnnotations;

namespace to_do_api.Model
{
    /// <summary>
    /// Represents a todo task in the application
    /// </summary>
    public class TodoTask
    {
        /// <summary>
        /// Unique identifier for the task
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Title of the task 
        /// </summary>
        [Required]
        [MaxLength(100)]
        public required string Title { get; set; }

        /// <summary>
        /// Optional description of the task 
        /// </summary>
        [MaxLength(500)]
        public string? Description { get; set; }

        /// <summary>
        /// Date and time when the task was created
        /// </summary>
        public DateTime CreatedAt { get; set; }

        /// <summary>
        /// Due date for the task
        /// </summary>
        public DateTime DueDate { get; set; }

        /// <summary>
        /// Indicates whether the task has been completed
        /// </summary>
        public bool IsCompleted { get; set; } = false;
    }
}
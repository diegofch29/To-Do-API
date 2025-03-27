using System.ComponentModel.DataAnnotations;

namespace to_do_api.Data.DTOs
{
    /// <summary>
    /// Data Transfer Object for creating a new todo task
    /// </summary>
    public class TodoTaskCreateDTO
    {
        /// <summary>
        /// The title of the todo task. Required field with maximum length of 100 characters.
        /// </summary>
        [Required]
        [MaxLength(100)]
        public required string Title { get; set; }

        /// <summary>
        /// Optional description of the todo task with maximum length of 500 characters.
        /// </summary>
        [MaxLength(500)]
        public string? Description { get; set; }

        /// <summary>
        /// The due date for completing the todo task.
        /// </summary>
        public DateTime DueDate { get; set; }
    }
}
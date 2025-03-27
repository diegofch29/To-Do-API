using System.ComponentModel.DataAnnotations;

namespace to_do_api.Data.DTOs
{
    /// <summary>
    /// Data Transfer Object for updating a Todo task
    /// </summary>
    public class TodoTaskUpdateDTO
    {
        /// <summary>
        /// The title of the todo task. Required, maximum 100 characters.
        /// </summary>
        [Required]
        [MaxLength(100)]
        public required string Title { get; set; }

        /// <summary>
        /// Optional description of the todo task. Maximum 500 characters.
        /// </summary>
        [MaxLength(500)]
        public string? Description { get; set; }

        /// <summary>
        /// The due date for the todo task
        /// </summary>
        public DateTime DueDate { get; set; }

        /// <summary>
        /// Indicates whether the task is completed
        /// </summary>
        public bool IsCompleted { get; set; }
    }
}
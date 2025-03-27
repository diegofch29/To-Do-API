using to_do_api.Data.DTOs;
using to_do_api.Model;

namespace to_do_api.Services.Interfaces;

public interface ITaskService
{
    /// <summary>
    /// Retrieves all tasks for a specific user
    /// </summary>
    /// <param name="userName">Username of the task owner</param>
    /// <returns>List of tasks belonging to the user</returns>
    Task<List<TodoTask>> GetTasksByUser(string userName);

    /// <summary>
    /// Retrieves a specific task by its ID
    /// </summary>
    /// <param name="taskId">ID of the task to retrieve</param>
    /// <returns>The requested task</returns>
    Task<TodoTask> GetTaskById(int taskId);

    /// <summary>
    /// Updates an existing task
    /// </summary>
    /// <param name="id">ID of the task to update</param>
    /// <param name="taskToUpdate">Updated task data</param>
    /// <returns>The updated task</returns>
    Task<TodoTask> UpdateTaskById(int id,TodoTaskUpdateDTO taskToUpdate);

    /// <summary>
    /// Deletes a task by its ID
    /// </summary>
    /// <param name="taskId">ID of the task to delete</param>
    Task DeleteTaskById(int taskId);

    /// <summary>
    /// Creates a new task
    /// </summary>
    /// <param name="task">Task data to create</param>
    /// <returns>The created task</returns>
    Task<TodoTask> CreateTask(TodoTaskCreateDTO task);
}
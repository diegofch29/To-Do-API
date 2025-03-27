using to_do_api.Data.DTOs;
using to_do_api.Model;
using to_do_api.Repositories;
using to_do_api.Services.Interfaces;

namespace to_do_api.Services
{
    public class TaskService : ITaskService
    {
        private readonly ITaskRepository _taskRepository;

        public TaskService(ITaskRepository taskRepository)
        {
            _taskRepository = taskRepository;
        }

        /// <summary>
        /// Creates a new todo task
        /// </summary>
        /// <param name="task">DTO containing the task information to create</param>
        /// <returns>The newly created TodoTask</returns>
        public async Task<TodoTask> CreateTask(TodoTaskCreateDTO task)
        {
            var newTask = new TodoTask
            {
                Title = task.Title,
                Description = task.Description,
                DueDate = task.DueDate.ToUniversalTime(),
                CreatedAt = DateTime.UtcNow
            };
            return await _taskRepository.AddAsync(newTask);
        }

        /// <summary>
        /// Deletes a task by its ID
        /// </summary>
        /// <param name="taskId">ID of the task to delete</param>
        /// <exception cref="KeyNotFoundException">Thrown when task is not found</exception>
        public async Task DeleteTaskById(int taskId)
        {
            var task = await _taskRepository.GetByIdAsync(taskId);
            if (task == null) throw new KeyNotFoundException("Task not found");
            await _taskRepository.DeleteAsync(task);
        }

        /// <summary>
        /// Retrieves a task by its ID
        /// </summary>
        /// <param name="taskId">ID of the task to retrieve</param>
        /// <returns>The requested TodoTask</returns>
        /// <exception cref="KeyNotFoundException">Thrown when task is not found</exception>
        public async Task<TodoTask> GetTaskById(int taskId)
        {
            var task = await _taskRepository.GetByIdAsync(taskId);
            if (task == null) throw new KeyNotFoundException("Task not found");
            return task;
        }

        /// <summary>
        /// Retrieves all tasks for a specific user
        /// </summary>
        /// <param name="userName">Username to filter tasks</param>
        /// <returns>List of tasks for the specified user</returns>
        public async Task<List<TodoTask>> GetTasksByUser(string userName)
        {
            var tasks = await _taskRepository.GetAllAsync();
            return tasks.ToList();
        }

        /// <summary>
        /// Updates an existing task by its ID
        /// </summary>
        /// <param name="id">ID of the task to update</param>
        /// <param name="taskToUpdate">DTO containing the updated task information</param>
        /// <returns>The updated TodoTask</returns>
        /// <exception cref="KeyNotFoundException">Thrown when task is not found</exception>
        public async Task<TodoTask> UpdateTaskById(int id, TodoTaskUpdateDTO taskToUpdate)
        {
            var existingTask = await _taskRepository.GetByIdAsync(id);
            if (existingTask == null) throw new KeyNotFoundException("Task not found");

            existingTask.Title = taskToUpdate.Title;
            existingTask.Description = taskToUpdate.Description;
            existingTask.IsCompleted = taskToUpdate.IsCompleted;

            await _taskRepository.UpdateAsync(existingTask);
            return existingTask;
        }
    }
}
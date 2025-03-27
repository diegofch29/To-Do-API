using to_do_api.Model;

namespace to_do_api.Repositories
{
    public interface ITaskRepository : IRepository<TodoTask>
    {
        /// <summary>
        /// Retrieves all completed tasks from the repository asynchronously.
        /// </summary>
        /// <returns>A collection of completed TodoTask items wrapped in a Task.</returns>
        Task<IEnumerable<TodoTask>> GetCompletedTasksAsync();
    }
}
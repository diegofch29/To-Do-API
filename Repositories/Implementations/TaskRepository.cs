using Microsoft.EntityFrameworkCore;
using to_do_api.Data;
using to_do_api.Model;

namespace to_do_api.Repositories
{
    /// <summary>
    /// Repository class for handling ToDo task operations in the database
    /// Implements ITaskRepository interface and inherits from the base Repository class
    /// </summary>
    public class TaskRepository : Repository<TodoTask>, ITaskRepository
    {
        private readonly TodoDbContext _context;

        /// <summary>
        /// Initializes a new instance of the TaskRepository class
        /// </summary>
        /// <param name="context">The database context</param>
        public TaskRepository(TodoDbContext context) : base(context)
        {
            _context = context;
        }

        /// <summary>
        /// Retrieves all completed tasks from the database
        /// </summary>
        /// <returns>A collection of completed TodoTask entities</returns>
        public async Task<IEnumerable<TodoTask>> GetCompletedTasksAsync()
        {
            return await _context.Tasks
                .Where(t => t.IsCompleted)
                .ToListAsync();
        }
    }
}
using Microsoft.EntityFrameworkCore;
using to_do_api.Data;

namespace to_do_api.Repositories
{
    public class Repository<T> : IRepository<T> where T : class
    {
        private readonly TodoDbContext _context;
        private readonly DbSet<T> _dbSet;

        /// <summary>
        /// Initializes a new instance of the Repository class
        /// </summary>
        /// <param name="context">The database context</param>
        public Repository(TodoDbContext context)
        {
            _context = context;
            _dbSet = context.Set<T>();
        }

        /// <summary>
        /// Retrieves all entities of type T from the database
        /// </summary>
        /// <returns>A collection of all entities</returns>
        public async Task<IEnumerable<T>> GetAllAsync()
            => await _dbSet.ToListAsync();

        /// <summary>
        /// Retrieves a specific entity by its ID
        /// </summary>
        /// <param name="id">The ID of the entity to retrieve</param>
        /// <returns>The entity if found, null otherwise</returns>
        public async Task<T> GetByIdAsync(int id)
            => await _dbSet.FindAsync(id);

        /// <summary>
        /// Adds a new entity to the database
        /// </summary>
        /// <param name="entity">The entity to add</param>
        /// <returns>The added entity</returns>
        public async Task<T> AddAsync(T entity)
        {
            await _dbSet.AddAsync(entity);
            await _context.SaveChangesAsync();
            return entity;
        }

        /// <summary>
        /// Updates an existing entity in the database
        /// </summary>
        /// <param name="entity">The entity to update</param>
        public async Task UpdateAsync(T entity)
        {
            _dbSet.Update(entity);
            await _context.SaveChangesAsync();
        }

        /// <summary>
        /// Removes an entity from the database
        /// </summary>
        /// <param name="entity">The entity to delete</param>
        public async Task DeleteAsync(T entity)
        {
            _dbSet.Remove(entity);
            await _context.SaveChangesAsync();
        }
    }
}
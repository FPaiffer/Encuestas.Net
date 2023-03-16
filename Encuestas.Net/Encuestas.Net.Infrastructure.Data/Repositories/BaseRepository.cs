using Encuestas.Net.Infrastructure.Data.Contexts;
using Microsoft.EntityFrameworkCore;

namespace Encuestas.Net.Infrastructure.Data.Repositories
{
	/// <summary>
	/// BaseRepository
	/// </summary>
	/// <typeparam name="T"></typeparam>
	public class BaseRepository<T> where T : class
    {
		/// <summary>
		/// The context
		/// </summary>
		protected readonly DataBaseContext Context;

		/// <summary>
		/// Initializes a new instance of the <see cref="BaseRepository{T}"/> class.
		/// </summary>
		/// <param name="context">The context.</param>
		public BaseRepository(DataBaseContext context) => Context = context;

		//Create
		/// <summary>
		/// Inserts the specified entity.
		/// </summary>
		/// <param name="entity">The entity.</param>
		/// <returns></returns>
		public T Insert(T entity)
        {
            Context.Set<T>().Add(entity);
            Context.SaveChanges();
            return entity;
        }
		/// <summary>
		/// Inserts the asynchronous.
		/// </summary>
		/// <param name="entity">The entity.</param>
		/// <returns></returns>
		public async Task<T> InsertAsync(T entity)
        {
			await Context.Set<T>().AddAsync(entity);
            await Context.SaveChangesAsync();
            return entity;
        }
		//Read
		/// <summary>
		/// Gets the by identifier.
		/// </summary>
		/// <param name="id">The identifier.</param>
		/// <returns></returns>
		public T GetById(int id)
        {
            var entity = Context.Set<T>().Find(id);
            return entity;
        }
		/// <summary>
		/// Gets the by identifier.
		/// </summary>
		/// <param name="id">The identifier.</param>
		/// <returns></returns>
		public T GetById(decimal id)
        {
            var entity = Context.Set<T>().Find(id);
            return entity;
        }
		/// <summary>
		/// Gets the by identifier.
		/// </summary>
		/// <param name="id">The identifier.</param>
		/// <returns></returns>
		public T GetById(Guid id)
        {
            var entity = Context.Set<T>().Find(id);
            return entity;
        }

		/// <summary>
		/// Gets the by identifier asynchronous.
		/// </summary>
		/// <param name="id">The identifier.</param>
		/// <returns></returns>
		public async Task<T> GetByIdAsync(int id)
        {
            var entity = await Context.Set<T>().FindAsync(id);
            return entity;
        }
		/// <summary>
		/// Gets the by identifier asynchronous.
		/// </summary>
		/// <param name="id">The identifier.</param>
		/// <returns></returns>
		public async Task<T> GetByIdAsync(decimal id)
        {
            var entity = await Context.Set<T>().FindAsync(id);
            return entity;
        }
		/// <summary>
		/// Gets the by identifier asynchronous.
		/// </summary>
		/// <param name="id">The identifier.</param>
		/// <returns></returns>
		public async Task<T> GetByIdAsync(Guid id)
        {
            var entity = await Context.Set<T>().FindAsync(id);
            return entity;
        }
		/// <summary>
		/// Gets all.
		/// </summary>
		/// <returns></returns>
		public List<T> GetAll() => Context.Set<T>().ToList();

		/// <summary>
		/// Gets all asynchronous.
		/// </summary>
		/// <returns></returns>
		public Task<List<T>> GetAllAsync() => Context.Set<T>().ToListAsync();
		//Update
		/// <summary>
		/// Updates the specified entity.
		/// </summary>
		/// <param name="entity">The entity.</param>
		/// <returns></returns>
		public T Update(T entity)
        {
            Context.Entry(entity).State = EntityState.Modified;
            Context.SaveChanges();
            return entity;
        }
		/// <summary>
		/// Updates the asynchronous.
		/// </summary>
		/// <param name="entity">The entity.</param>
		/// <returns></returns>
		public async Task<T> UpdateAsync(T entity)
        {
            Context.Entry(entity).State = EntityState.Modified;
            await Context.SaveChangesAsync();
            return entity;
        }

		//Delete
		/// <summary>
		/// Removes the specified entidade.
		/// </summary>
		/// <param name="entidade">The entidade.</param>
		public void Remove(T entidade)
        {
            Context.Set<T>().Remove(entidade);
            Context.SaveChanges();
        }

		/// <summary>
		/// Removes the asynchronous.
		/// </summary>
		/// <param name="entidade">The entidade.</param>
		public async Task RemoveAsync(T entidade)
        {
            Context.Set<T>().Remove(entidade);
            await Context.SaveChangesAsync();
        }
    }

}

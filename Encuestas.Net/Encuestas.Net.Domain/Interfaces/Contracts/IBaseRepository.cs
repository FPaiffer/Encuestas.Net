
namespace Encuestas.Net.Domain.Interfaces.Contracts
{
	/// <summary>
	/// IBaseRepository
	/// </summary>
	/// <typeparam name="T"></typeparam>
	public interface IBaseRepository<T> where T : class
    {
		/// <summary>
		/// Gets all asynchronous.
		/// </summary>
		/// <returns></returns>
		Task<List<T>> GetAllAsync();
		/// <summary>
		/// Inserts the asynchronous.
		/// </summary>
		/// <param name="entity">The entity.</param>
		/// <returns></returns>
		Task<T> InsertAsync(T entity);
		/// <summary>
		/// Updates the asynchronous.
		/// </summary>
		/// <param name="entity">The entity.</param>
		/// <returns></returns>
		Task<T> UpdateAsync(T entity);
		/// <summary>
		/// Removes the asynchronous.
		/// </summary>
		/// <param name="entity">The entity.</param>
		/// <returns></returns>
		Task RemoveAsync(T entity);
    }
}

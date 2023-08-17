namespace WebProject.Core.IRepositories
{
    public interface IGenericRepository<T> where T : class
    {
        Task<IEnumerable<T>> AllAsync();

        Task<bool> AddAsync(T entity);

        Task<T> GetByGuidIdAsync(Guid id);

        Task<T> GetByIntIdAsync(int id);
    }
}

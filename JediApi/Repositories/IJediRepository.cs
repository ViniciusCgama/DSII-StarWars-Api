using JediApi.Models;

namespace JediApi.Repositories
{
    public interface IJediRepository
    {
        Task<jedi> GetByIdAsync(int id);
        Task<List<jedi>> GetAllAsync();
        Task<jedi> AddAsync(jedi jedi);
        Task<bool> UpdateAsync(jedi jedi);
        Task<bool> DeleteAsync(int id);
    }
}

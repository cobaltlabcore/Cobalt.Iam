using System.Collections.Generic;
using System.Threading.Tasks;

namespace Cobalt.Iam.Abstractions;

public interface IUserRepository
{
    Task<User?> GetByIdAsync(string id);
    Task<IEnumerable<User>> GetAllAsync();
    Task<int> AddAsync(User user);
    Task<int> UpdateAsync(User user);
    Task<int> DeleteAsync(string id); 
}
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Cobalt.Iam.Abstractions;

public interface IRoleRepository
{
    Task<Role> GetByIdAsync(string id);
    Task<IEnumerable<Role>> GetAllAsync();
    Task<int> AddAsync(Role role);
    Task<int> UpdateAsync(Role role);
    Task<int> DeleteAsync(string id);
}
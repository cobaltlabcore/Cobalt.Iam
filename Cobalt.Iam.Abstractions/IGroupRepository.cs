using System.Collections.Generic;
using System.Threading.Tasks;

namespace Cobalt.Iam.Abstractions;

public interface IGroupRepository
{
    Task<Group> GetByIdAsync(string id);
    Task<IEnumerable<Group>> GetAllAsync();
    Task<int> AddAsync(Group group);
    Task<int> UpdateAsync(Group group);
    Task<int> DeleteAsync(string id);
}
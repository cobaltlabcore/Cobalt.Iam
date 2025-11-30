using System.Data;
using Cobalt.Iam.Abstractions;
using Dapper;

namespace Cobalt.Iam;

public class UserRepository : IUserRepository
{
    private readonly IDbConnection _connection;
    private readonly string _tableName;

    public UserRepository(IDbConnection connection, RepositoryOptions options)
    {
        _connection = connection;
        _tableName = options.UsersTableName;
    }
    
    public async Task<User?> GetByIdAsync(string id)
    {
        var sql = $"SELECT * FROM {_tableName} WHERE Id = @Id";
        
        return await _connection
            .QuerySingleOrDefaultAsync<User>(sql, new { Id = id })
            .ConfigureAwait(false);
    }

    public async Task<IEnumerable<User>> GetAllAsync()
    {
        var sql = $"SELECT * FROM {_tableName}";
        
        return await _connection
            .QueryAsync<User>(sql)
            .ConfigureAwait(false);
    }

    public async Task<int> AddAsync(User user)
    {
        var sql = $@"INSERT INTO {_tableName} (Name, Email, CreatedDate) 
                     VALUES (@Name, @Email, @CreatedDate)";
        
        return await _connection
            .ExecuteAsync(sql, user)
            .ConfigureAwait(false);
    }

    public async Task<int> UpdateAsync(User user)
    {
        var sql = $@"UPDATE {_tableName} 
                     SET Name = @Name, Email = @Email 
                     WHERE Id = @Id";
        
        return await _connection
            .ExecuteAsync(sql, user)
            .ConfigureAwait(false);
    }

    public async Task<int> DeleteAsync(string id)
    {
        var sql = $"DELETE FROM {_tableName} WHERE Id = @Id";
        
        return await _connection
            .ExecuteAsync(sql, new { Id = id })
            .ConfigureAwait(false);
    }
}
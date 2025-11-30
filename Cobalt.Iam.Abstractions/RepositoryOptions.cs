namespace Cobalt.Iam.Abstractions;

public class RepositoryOptions
{
    public string UsersTableName { get; set;} = "Users";
    public string GroupsTableName { get; set;} = "Groups";
    public string RolesTableName { get; set;} = "Roles";
}
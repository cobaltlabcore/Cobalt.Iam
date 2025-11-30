using System;
using System.Collections.Generic;

namespace Cobalt.Iam.Abstractions;

public class User
{
    public Ulid? Id { get; set; }
    public string? Name { get; set; }
    public string? FullName { get; set; }
    public string? Email { get; set; }
    public string? Password { get; set; }
    public List<Role>? Roles { get; set; } // or not
    public List<Group>? Groups { get; set; } // or not
}
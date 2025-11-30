using System;
using System.Collections.Generic;

namespace Cobalt.Iam.Abstractions;

public class Group
{
    public Ulid? Id { get; set; }
    public string? Name { get; set; }
    public List<User>? Users { get; set; }
    public List<Role>? Roles { get; set; }
}
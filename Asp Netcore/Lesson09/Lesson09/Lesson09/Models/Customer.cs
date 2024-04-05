using System;
using System.Collections.Generic;

namespace Lesson09.Models;

public partial class Customer
{
    public string? Fullname { get; set; }

    public string? Username { get; set; }

    public string? Password { get; set; }

    public string? Address { get; set; }

    public string? Email { get; set; }

    public string? Phone { get; set; }

    public int Id { get; set; }
}

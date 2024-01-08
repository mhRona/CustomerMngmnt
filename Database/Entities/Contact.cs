﻿using System;
using System.Collections.Generic;

namespace CustomerManagement.Database.Entities;

public partial class Contact
{
    public int Id { get; set; }

    public string FullName { get; set; } = null!;

    public string? OfficeNumber { get; set; }

    public string? Email { get; set; }

    public int CustomerId { get; set; }

    public bool IsDeleted { get; set; }

    public DateTime Created { get; set; }

    public virtual Customer Customer { get; set; } = null!;
}

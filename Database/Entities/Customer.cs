using System;
using System.Collections.Generic;

namespace CustomerManagement.Database.Entities;

public partial class Customer
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public int CustomerNumber { get; set; }

    public bool IsDeleted { get; set; }

    public DateTime Created { get; set; }

    public virtual ICollection<Address> Addresses { get; } = new List<Address>();

    public virtual ICollection<Contact> Contacts { get; } = new List<Contact>();
}

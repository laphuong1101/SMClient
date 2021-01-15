using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for WCFMyDbContext
/// </summary>
public class WCFMyDbContext : DbContext
{

    public WCFMyDbContext() : base("MyConnectionStringWCF")
    {

    }

    public DbSet<Student> Students { get; set; }
}
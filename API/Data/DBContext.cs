using System;
using API.Entities;
using Microsoft.EntityFrameworkCore;

namespace API.Data;

public class DBContext(DbContextOptions options) : DbContext(options)
{
    public DbSet<AppUser> _appUsers{ get; set; }
}

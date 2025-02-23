﻿using Microsoft.EntityFrameworkCore;

namespace MvcTask.DataAccsessLayer;

public class AppDbContext:DbContext
{
    
    public DbSet<Product> Products { get; set; }
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {

    }
}

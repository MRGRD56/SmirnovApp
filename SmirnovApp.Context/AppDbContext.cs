using Microsoft.EntityFrameworkCore;
using System;

namespace SmirnovApp.Context
{
    public class AppDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer(@"Server=localhost\SQLEXPRESS;Database=SmirnovApp;Trusted_connection=True;");
        }
    }
}

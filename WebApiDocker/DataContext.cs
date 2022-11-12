using Microsoft.EntityFrameworkCore;
using WebApiDocker.Model;

namespace WebApiDocker;

public class DataContext : DbContext
{
    public DbSet<Film> Film { get; set; }

    public DataContext(DbContextOptions<DataContext> options) : base(options)
    {
    }
}
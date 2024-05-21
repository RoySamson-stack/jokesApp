using Microsoft.EntityFrameworkCore;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }

    public DbSet<MyModel> MyModels { get; set; }
}

public class MyModel
{
    public int Id { get; set; }
    public string Name { get; set; }
    // Add other properties as needed
}

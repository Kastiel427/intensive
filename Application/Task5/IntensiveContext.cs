using System.Data.Entity;

namespace Task5
{
    class IntensiveContext : DbContext 
    {
        public DbSet<Project> Projects { get; set; }

        public DbSet<Task> Tasks { get; set; }
    }
}

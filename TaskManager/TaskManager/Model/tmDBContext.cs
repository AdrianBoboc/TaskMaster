using System.Data.Entity;

namespace TaskManager.Model
{
    class tmDBContext : DbContext
    {
        public DbSet<Status> Statuses { get; set; }
        public DbSet<Task> Tasks { get; set; }
    }
}

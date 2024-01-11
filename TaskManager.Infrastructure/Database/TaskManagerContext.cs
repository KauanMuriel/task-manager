using TaskManager.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task = TaskManager.Domain.Entities.Task;

namespace TaskManager.Infrastructure.Database
{
    public class TaskManagerContext : DbContext
    {
        public DbSet<Task> Tasks { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<TimeTracker> TimeTrackers { get; set; }
        public DbSet<Project> Projects { get; set; }
        public DbSet<Collaborator> Collaborators { get; set; }

        public TaskManagerContext(DbContextOptions<TaskManagerContext> options) : base(options) { }
    }
}

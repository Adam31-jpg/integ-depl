using Microsoft.EntityFrameworkCore;
using ProbabilityX_API.Configurations;
using ProbabilityX_API.Models;

namespace ProbabilityX_API.Settings
{
    public partial class ProbabilityXContext : DbContext
    {
        public ProbabilityXContext()
        {

        }

        public ProbabilityXContext(DbContextOptions<ProbabilityXContext> options) : base(options) { }

        public virtual DbSet<TodoModel> Todos { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.SetTodo();
        }
    }
}

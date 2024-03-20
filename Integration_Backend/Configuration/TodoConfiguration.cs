using Microsoft.EntityFrameworkCore;
using ProbabilityX_API.Models;

namespace ProbabilityX_API.Configurations
{
    public static class TodoConfiguration
    {
        public static void SetTodo(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TodoModel>(entity =>
            {
                entity.ToTable("todo");

                entity.Property(x => x.Id)
                    .HasColumnName("id")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("INT UNSIGNED")
                    .IsRequired();

                entity.Property(x => x.Name)
                    .HasColumnName("name")
                    .HasMaxLength(255)
                    .IsRequired();

            });
        }
    }
}


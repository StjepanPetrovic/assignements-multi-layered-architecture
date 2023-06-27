using Data_access_layer;
using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace Entity_layer.Entities
{
    public partial class AssignementsModel : DbContext
    {
        public AssignementsModel()
            : base("name=AssignementsModel")
        {
        }

        public virtual DbSet<Assignment> Assignments { get; set; }
        public virtual DbSet<AssignmentStatus> AssignmentStatuses { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Assignment>()
                .Property(e => e.Student)
                .IsUnicode(false);

            modelBuilder.Entity<Assignment>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<AssignmentStatus>()
                .Property(e => e.Status)
                .IsUnicode(false);

            modelBuilder.Entity<AssignmentStatus>()
                .HasMany(e => e.Assignments)
                .WithRequired(e => e.AssignmentStatus)
                .HasForeignKey(e => e.IdAssignmentStatuses)
                .WillCascadeOnDelete(false);
        }
    }
}

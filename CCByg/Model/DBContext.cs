using Microsoft.EntityFrameworkCore;

namespace CCByg.Model
{
    public partial class DBContext : DbContext
    {
        public DBContext()
        {
        }

        public DBContext(DbContextOptions<DBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Item> Items { get; set; }
        public virtual DbSet<ItemAllocation> ItemAllocations { get; set; }
        public virtual DbSet<Project> Projects { get; set; }
        public virtual DbSet<Staff> Staffs { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Data Source=ccbyg.database.windows.net;Initial Catalog=CCByg;Persist Security Info=True;User ID=ccbyg;Password=Database123");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Item>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.AmountAllocated).HasColumnName("amountAllocated");

                entity.Property(e => e.AmountAvailable).HasColumnName("amountAvailable");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<ItemAllocation>(entity =>
            {
                entity.ToTable("ItemAllocation");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Amount).HasColumnName("amount");

                entity.Property(e => e.ItemId).HasColumnName("itemId");

                entity.Property(e => e.ProjectId).HasColumnName("projectId");

                entity.HasOne(d => d.Item)
                    .WithMany(p => p.ItemAllocations)
                    .HasForeignKey(d => d.ItemId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__ItemAlloc__itemI__5070F446");

                entity.HasOne(d => d.Project)
                    .WithMany(p => p.ItemAllocations)
                    .HasForeignKey(d => d.ProjectId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__ItemAlloc__proje__4F7CD00D");
            });

            modelBuilder.Entity<Project>(entity =>
            {
                entity.ToTable("Project");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Adress)
                    .HasColumnName("adress")
                    .HasMaxLength(50);

                entity.Property(e => e.Deadline)
                    .HasColumnName("deadline")
                    .HasColumnType("date");

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(50);

                entity.Property(e => e.Start)
                    .HasColumnName("start")
                    .HasColumnType("date");

                entity.Property(e => e.Telephone)
                    .HasColumnName("telephone")
                    .HasMaxLength(50);

                entity.Property(e => e.Zipcode)
                    .HasColumnName("zipcode")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Staff>(entity =>
            {
                entity.ToTable("Staff");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Adress)
                    .HasColumnName("adress")
                    .HasMaxLength(50);

                entity.Property(e => e.EmployedSince)
                    .HasColumnName("employedSince")
                    .HasColumnType("date");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasMaxLength(50);

                entity.Property(e => e.Position)
                    .HasColumnName("position")
                    .HasMaxLength(50);

                entity.Property(e => e.Telephone)
                    .HasColumnName("telephone")
                    .HasMaxLength(50);

                entity.Property(e => e.Zipcode)
                    .HasColumnName("zipcode")
                    .HasMaxLength(50);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}

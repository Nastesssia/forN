using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace RepairRequestsProject
{
    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=Model11")
        {
        }

        public virtual DbSet<Clients> Clients { get; set; }
        public virtual DbSet<ClientsReviews> ClientsReviews { get; set; }
        public virtual DbSet<Managers> Managers { get; set; }
        public virtual DbSet<MasterComments> MasterComments { get; set; }
        public virtual DbSet<MasterQualityManager> MasterQualityManager { get; set; }
        public virtual DbSet<Masters> Masters { get; set; }
        public virtual DbSet<Operators> Operators { get; set; }
        public virtual DbSet<Parts> Parts { get; set; }
        public virtual DbSet<PartsOrders> PartsOrders { get; set; }
        public virtual DbSet<Requests> Requests { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<Users> Users { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Clients>()
                .Property(e => e.clientName)
                .IsUnicode(false);

            modelBuilder.Entity<Clients>()
                .Property(e => e.clientPhone)
                .IsUnicode(false);

            modelBuilder.Entity<Clients>()
                .HasMany(e => e.Requests)
                .WithRequired(e => e.Clients)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ClientsReviews>()
                .Property(e => e.comment)
                .IsUnicode(false);

            modelBuilder.Entity<ClientsReviews>()
                .Property(e => e.qrCode)
                .IsUnicode(false);

            modelBuilder.Entity<Managers>()
                .Property(e => e.managerName)
                .IsUnicode(false);

            modelBuilder.Entity<Managers>()
                .Property(e => e.managerPhone)
                .IsUnicode(false);

            modelBuilder.Entity<Managers>()
                .HasMany(e => e.MasterQualityManager)
                .WithRequired(e => e.Managers)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<MasterComments>()
                .Property(e => e.message)
                .IsUnicode(false);

            modelBuilder.Entity<MasterQualityManager>()
                .Property(e => e.appealReason)
                .IsUnicode(false);

            modelBuilder.Entity<Masters>()
                .Property(e => e.masterType)
                .IsUnicode(false);

            modelBuilder.Entity<Masters>()
                .Property(e => e.masterName)
                .IsUnicode(false);

            modelBuilder.Entity<Masters>()
                .Property(e => e.masterPhone)
                .IsUnicode(false);

            modelBuilder.Entity<Masters>()
                .HasMany(e => e.MasterComments)
                .WithRequired(e => e.Masters)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Masters>()
                .HasMany(e => e.MasterQualityManager)
                .WithRequired(e => e.Masters)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Operators>()
                .Property(e => e.operatorName)
                .IsUnicode(false);

            modelBuilder.Entity<Operators>()
                .Property(e => e.operatoPhone)
                .IsUnicode(false);

            modelBuilder.Entity<Parts>()
                .Property(e => e.partsName)
                .IsUnicode(false);

            modelBuilder.Entity<Parts>()
                .Property(e => e.partsDescription)
                .IsUnicode(false);

            modelBuilder.Entity<Parts>()
                .Property(e => e.price)
                .HasPrecision(10, 2);

            modelBuilder.Entity<Parts>()
                .HasMany(e => e.PartsOrders)
                .WithRequired(e => e.Parts)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Requests>()
                .Property(e => e.homeTechType)
                .IsUnicode(false);

            modelBuilder.Entity<Requests>()
                .Property(e => e.homeTechModel)
                .IsUnicode(false);

            modelBuilder.Entity<Requests>()
                .Property(e => e.problemDescription)
                .IsUnicode(false);

            modelBuilder.Entity<Requests>()
                .Property(e => e.requestStatus)
                .IsUnicode(false);

            modelBuilder.Entity<Requests>()
                .Property(e => e.repairParts)
                .IsUnicode(false);

            modelBuilder.Entity<Requests>()
                .HasMany(e => e.ClientsReviews)
                .WithRequired(e => e.Requests)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Requests>()
                .HasMany(e => e.MasterComments)
                .WithRequired(e => e.Requests)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Requests>()
                .HasMany(e => e.MasterQualityManager)
                .WithRequired(e => e.Requests)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Requests>()
                .HasMany(e => e.PartsOrders)
                .WithRequired(e => e.Requests)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Users>()
                .Property(e => e.fio)
                .IsUnicode(false);

            modelBuilder.Entity<Users>()
                .Property(e => e.phone)
                .IsUnicode(false);

            modelBuilder.Entity<Users>()
                .Property(e => e.login)
                .IsUnicode(false);

            modelBuilder.Entity<Users>()
                .Property(e => e.password)
                .IsUnicode(false);

            modelBuilder.Entity<Users>()
                .Property(e => e.type)
                .IsUnicode(false);

            modelBuilder.Entity<Users>()
                .HasMany(e => e.Clients)
                .WithRequired(e => e.Users)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Users>()
                .HasMany(e => e.Managers)
                .WithRequired(e => e.Users)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Users>()
                .HasMany(e => e.Masters)
                .WithRequired(e => e.Users)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Users>()
                .HasMany(e => e.Operators)
                .WithRequired(e => e.Users)
                .WillCascadeOnDelete(false);
        }
    }
}

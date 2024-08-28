using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.Extensions.Configuration;

namespace ProjectPRN.Models
{
    public partial class Budget_WinApp_PRN391Context : DbContext
    {
        public Budget_WinApp_PRN391Context()
        {
        }

        public Budget_WinApp_PRN391Context(DbContextOptions<Budget_WinApp_PRN391Context> options)
            : base(options)
        {
        }

        public virtual DbSet<Bank> Banks { get; set; } = null!;
        public virtual DbSet<Budget> Budgets { get; set; } = null!;
        public virtual DbSet<Expense> Expenses { get; set; } = null!;
        public virtual DbSet<Income> Incomes { get; set; } = null!;
        public virtual DbSet<Saving> Savings { get; set; } = null!;
        public virtual DbSet<User> Users { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var builder = new ConfigurationBuilder()
                          .SetBasePath(Directory.GetCurrentDirectory())
                          .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);
            IConfigurationRoot configuration = builder.Build();
            optionsBuilder.UseSqlServer(configuration.GetConnectionString("MyCnn"));

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Bank>(entity =>
            {
                entity.Property(e => e.BankId).HasColumnName("BankID");

                entity.Property(e => e.BankName).HasMaxLength(100);

                entity.Property(e => e.BankPrice).HasColumnType("money");

                entity.Property(e => e.BudgetId).HasColumnName("BudgetID");

                entity.Property(e => e.Status).HasMaxLength(100);

                entity.HasOne(d => d.Budget)
                    .WithMany(p => p.Banks)
                    .HasForeignKey(d => d.BudgetId)
                    .HasConstraintName("FK__Banks__BudgetID__300424B4");
            });

            modelBuilder.Entity<Budget>(entity =>
            {
                entity.Property(e => e.BudgetId).HasColumnName("BudgetID");

                entity.Property(e => e.ExpenseId).HasColumnName("ExpenseID");

                entity.Property(e => e.Status).HasMaxLength(200);

                entity.Property(e => e.UnitPrice).HasColumnType("money");
            });

            modelBuilder.Entity<Expense>(entity =>
            {
                entity.Property(e => e.ExpenseId).HasColumnName("ExpenseID");

                entity.Property(e => e.BudgetId).HasColumnName("BudgetID");

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.ExpenseName).HasMaxLength(100);

                entity.Property(e => e.ExpensePrice).HasColumnType("money");

                entity.Property(e => e.Invoice).HasMaxLength(100);

                entity.HasOne(d => d.Budget)
                    .WithMany(p => p.Expenses)
                    .HasForeignKey(d => d.BudgetId)
                    .HasConstraintName("FK__Expenses__Budget__31EC6D26");
            });

            modelBuilder.Entity<Income>(entity =>
            {
                entity.Property(e => e.IncomeId).HasColumnName("IncomeID");

                entity.Property(e => e.BudgetId).HasColumnName("BudgetID");

                entity.Property(e => e.DateStart).HasColumnType("datetime");

                entity.Property(e => e.IncomePrice).HasColumnType("money");

                entity.Property(e => e.IncomeName).HasMaxLength(100);

                entity.Property(e => e.Status).HasMaxLength(100);

                entity.HasOne(d => d.Budget)
                    .WithMany(p => p.Incomes)
                    .HasForeignKey(d => d.BudgetId)
                    .HasConstraintName("FK__Incomes__BudgetI__30F848ED");
            });

            modelBuilder.Entity<Saving>(entity =>
            {
                entity.HasKey(e => e.SaveId)
                    .HasName("PK__Savings__1450D386AE91E5CA");

                entity.Property(e => e.SaveId).HasColumnName("SaveID");

                entity.Property(e => e.BankId).HasColumnName("BankID");

                entity.Property(e => e.DateStart).HasColumnType("datetime");

                entity.Property(e => e.Interest).HasMaxLength(100);

                entity.Property(e => e.SaveName).HasMaxLength(100);

                entity.Property(e => e.SavePrice).HasColumnType("money");

                entity.Property(e => e.Status).HasMaxLength(100);

                entity.HasOne(d => d.Bank)
                    .WithMany(p => p.Savings)
                    .HasForeignKey(d => d.BankId)
                    .HasConstraintName("FK__Savings__BankID__2F10007B");
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.Property(e => e.Address).HasMaxLength(200);

                entity.Property(e => e.BudgetId).HasColumnName("BudgetID");

                entity.Property(e => e.DateOfBith).HasColumnType("date");

                entity.Property(e => e.Email)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Name).HasMaxLength(100);

                entity.Property(e => e.Password)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Phone)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UserName).HasMaxLength(100);

                entity.HasOne(d => d.Budget)
                    .WithMany(p => p.Users)
                    .HasForeignKey(d => d.BudgetId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Users__BudgetID__2E1BDC42");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}

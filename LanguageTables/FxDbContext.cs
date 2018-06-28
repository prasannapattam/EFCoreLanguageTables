using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace LanguageTables
{
    class FxDbContext<TEntity>: DbContext
        where TEntity: class
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=.\SQLExpress;Database=Sugar;Trusted_Connection=True");
            //Console.WriteLine();
            //Console.WriteLine("OnConfiguring");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // setting the DBSet of the profile
            modelBuilder.Entity<TEntity>(t =>
            {
                t.ToTable("Employee");
                t.HasKey("Id");
                t.Property("Name").HasColumnName("Name");
            });

            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("-------- Executing OnModelCreating");
        }
    }
}

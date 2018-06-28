using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;

namespace LanguageTables
{
    class FxLanguageDbContext<TEntity, TLanguage> : FxDbContext<TEntity>
        where TEntity: class
    {
        private string tableSuffix;
        public FxLanguageDbContext(string culture)
        {
            if(culture == "dx") // for default use 
            {
                this.tableSuffix = "";
            }
            else
            {
                this.tableSuffix = "_" + culture;
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // setting up the language parameters
            string tableName = "Employee" + this.tableSuffix;
            modelBuilder.Entity<EmployeeLanguageModel>( t =>
            {
                t.ToTable(tableName);
                t.HasKey("Id");
                t.Property("Name").HasColumnName("Name");
            });
                

            modelBuilder.Entity<TEntity>()
                .HasOne(typeof(EmployeeLanguageModel), "Language")
                .WithOne()
                .HasForeignKey(typeof(EmployeeLanguageModel), "Id");
        }
    }
}

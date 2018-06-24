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
            this.tableSuffix = culture;
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // setting up the language parameters
            string tableName = "Employee_" + this.tableSuffix;
            modelBuilder.Entity<EmployeeLanguageModel>().ToTable(tableName)
                .HasKey("Id");

            modelBuilder.Entity<TEntity>()
                .HasOne(typeof(EmployeeLanguageModel), "Language")
                .WithOne()
                .HasForeignKey(typeof(EmployeeLanguageModel), "Id");
        }
    }
}

using DPI.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DPILocalStorage
{
    public class SQLiteDbContext : DbContext
    {
        public SQLiteDbContext()
        {

        }
        public DbSet<IFactory> Factories { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionBuilder)
        {
            optionBuilder.UseSqlite("Data Source=DPISolution.db ");
        }
    }
}

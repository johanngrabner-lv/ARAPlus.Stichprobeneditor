using ARAPlus.Stichprobeneditor.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace ARAPlus.Stichprobeneditor.Repository.Impl.MSSQLServer
{
    public class StichprobenContext:DbContext
    {
        public StichprobenContext(DbContextOptions<StichprobenContext> options)
        : base(options)
        {
        }
        public StichprobenContext()
        {

        }
        public DbSet<Artikel> Artikel{ get; set; }
        public DbSet<Packstoff>Packstoffs { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=StichprobenEditorDB;Trusted_Connection=True;MultipleActiveResultSets=true");
        }
    }
}

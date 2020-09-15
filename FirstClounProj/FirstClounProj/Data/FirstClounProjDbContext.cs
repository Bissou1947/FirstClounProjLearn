using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FirstClounProj.Data
{
    public class FirstClounProjDbContext : DbContext
    {
        public FirstClounProjDbContext(DbContextOptions<FirstClounProjDbContext> options)
        :base(options)
        {
        
        }

        public DbSet<Books> Books { get; set; }
        public DbSet<Languages> Languages { get; set; }

        //this ignored because we usethe code is startup.cs in ConfigureServices method
        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    optionsBuilder.UseSqlServer("Server=.;Database=FirstClounProjDb;Integrated Security=True;");
        //    base.OnConfiguring(optionsBuilder);
        //}
    }
}

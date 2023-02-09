using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Yazılım_Akademisi_odev.Models;


namespace Yazılım_Akademisi_odev.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<Daire> Daireler { get; set; }
    }
}


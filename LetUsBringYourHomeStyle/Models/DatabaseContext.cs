using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static LetUsBringYourHomeStyle.Models.homeStyle;

namespace LetUsBringYourHomeStyle.Models
{
    public class DatabaseContext: DbContext
    {
        public static DatabaseContext instance;
        public static DatabaseContext getInstance()
        {
            return instance;
        }
        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options)
        {
            instance = this;
        }
        public DbSet<Admin> Admin { get; set; }
        public DbSet<Firma> Firma { get; set; }
        public DbSet<Namjestaj> Namjestaj { get; set; }
        public DbSet<PredstavnikFirme> PredstavnikFirme { get; set; }
        public DbSet<Popust> Popust { get; set; }
        public DbSet<Recenzija> Recenzija { get; set; }
        //public DbSet<TEntity> Kategorija { get; set; }
        public DbSet<RegistrovaniKorisnik> RegistrovaniKorisnik { get; set; }
        public DbSet<SistemskiKorisnik> SistemskiKorisnik { get; set; }
        public DbSet<Savjet> Savjet { get; set; }
        public DbSet<Dimenzija> Dimenzija { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Admin>().ToTable("Admin");
            modelBuilder.Entity<Firma>().ToTable("Firma");
            modelBuilder.Entity<Namjestaj>().ToTable("Namjestaj");
            modelBuilder.Entity<PredstavnikFirme>().ToTable("PredstavnikFirme");
            modelBuilder.Entity<Popust>().ToTable("Recenzija");
            modelBuilder.Entity<RegistrovaniKorisnik>().ToTable("RegistrovaniKorisnik");
            modelBuilder.Entity<SistemskiKorisnik>().ToTable("SistemskiKorisnik");
            modelBuilder.Entity<Savjet>().ToTable("Savjet");
            modelBuilder.Entity<Dimenzija>().ToTable("Dimenzija");
        }

    }
}

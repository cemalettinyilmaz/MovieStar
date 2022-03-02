using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Validation;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieStarEFUygulama.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext() : base("conBaglantim")
        {
            // Database.Connection.ConnectionString("server=.;database=MovieStarDB2;uid=sa;password=123;");
            this.Configuration.LazyLoadingEnabled = true;
        }
        public DbSet<Film> Filmler { get; set; }
        public DbSet<Tur> Turler { get; set; }
        public DbSet<Oyuncu> Oyuncular { get; set; }
        public DbSet<IletisimBilgi> IletisimBilgileri { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Oyuncu>()
                .HasOptional(x => x.IletisimBilgileri)
                .WithRequired(x => x.Oyuncu);


            modelBuilder.Entity<Film>()
                .Property(x => x.IMDBPuani)
                .HasPrecision(2, 1);


            base.OnModelCreating(modelBuilder);

        }
        public override int SaveChanges()
        {
            try
            {
                return base.SaveChanges();
            }
            catch (DbEntityValidationException ex)
            {
                string errorMessages = string.Join("; ", ex.EntityValidationErrors.SelectMany(x => x.ValidationErrors).Select(x => x.PropertyName + ": " + x.ErrorMessage));
                throw new DbEntityValidationException(errorMessages);
            }
        }
    }

}

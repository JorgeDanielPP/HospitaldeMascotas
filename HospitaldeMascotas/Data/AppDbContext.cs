using HospitaldeMascotas.Models;
using Microsoft.EntityFrameworkCore;

namespace HospitaldeMascotas.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }
        public DbSet<Mascota> Mascota { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // base.OnModelCreating(modelBuilder);
            //  modelBuilder.Entity<Appointments>().HasIndex(c => c.IdCita).IsUnique();
            //  modelBuilder.Entity<Pets>().HasIndex(c => c.IdPet).IsUnique();
            //  modelBuilder.Entity<MedicalHistory>().HasIndex(c => c.IdHistorial).IsUnique();
            //  modelBuilder.Entity<VeterinaryDoctor>().HasIndex(c => c.IdVeterinario).IsUnique();


            modelBuilder.Entity<Mascota>(entity =>
            {
                entity.HasKey(p => p.IdMascota);

                entity.Property(p => p.IdMascota)
                .UseIdentityColumn()
                .ValueGeneratedOnAdd();

                entity.Property(p => p.NombreMascota).HasMaxLength(50);
                entity.Property(p => p.Raza).HasMaxLength(25);
                entity.Property(p => p.Edad).HasMaxLength(2);
                entity.Property(p => p.Sexo).HasMaxLength(1);
                entity.Property(p => p.Color).HasMaxLength(20);
                entity.Property(p => p.NombrePropietario).HasMaxLength(100);
                entity.Property(p => p.CedulaPropietario).HasMaxLength(12);
                entity.Property(p => p.DireccionPropietario).HasMaxLength(10);
                entity.Property(p => p.TelefonoPropietario).HasMaxLength(10);
            });
                modelBuilder.Entity<Mascota>().ToTable("Mascota");


        }
    }
}

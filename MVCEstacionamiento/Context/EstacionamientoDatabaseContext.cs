using Microsoft.EntityFrameworkCore;
using MVCEstacionamiento.Models;

namespace MVCEstacionamiento.Context
{
    public class EstacionamientoDatabaseContext:DbContext
    {
        public EstacionamientoDatabaseContext(DbContextOptions<EstacionamientoDatabaseContext> options) : base(options)
        {
        }

        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Vehiculo> Vehiculos { get; set; }
        public DbSet<Espacio> Espacios { get; set; }
        public DbSet<Reserva> Reservas { get; set; }
        public DbSet<ReciboDePago> ReciboDePagos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Cliente>()
                .HasMany(c => c.Vehiculos)
                .WithOne(v => v.Propietario)
                .HasForeignKey(v => v.ClienteId);

            modelBuilder.Entity<Cliente>()
                .HasMany(c => c.Reservas)
                .WithOne(r => r.Cliente)
                .HasForeignKey(r => r.ClienteId);

            modelBuilder.Entity<Espacio>()
                .HasMany(e => e.Reservas)
                .WithOne(r => r.Espacio)
                .HasForeignKey(r => r.EspacioId);
        }
    }
}

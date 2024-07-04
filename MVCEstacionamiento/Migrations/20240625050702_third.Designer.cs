﻿// <auto-generated />
using System;
using MVCEstacionamiento.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace MVCEstacionamiento.Migrations
{
    [DbContext(typeof(EstacionamientoDatabaseContext))]
    [Migration("20240625050702_third")]
    partial class third
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("MVCEstacionamiento.Models.Cliente", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("DNI")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("telefono")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Clientes");
                });

            modelBuilder.Entity("MVCEstacionamiento.Models.Espacio", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<bool>("Disponible")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.ToTable("Espacios");
                });

            modelBuilder.Entity("MVCEstacionamiento.Models.ReciboDePago", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<decimal>("Monto")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("PrecioXHora")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("ReservaId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ReservaId");

                    b.ToTable("ReciboDePagos");
                });

            modelBuilder.Entity("MVCEstacionamiento.Models.Reserva", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("ClienteId")
                        .HasColumnType("int");

                    b.Property<int>("EspacioId")
                        .HasColumnType("int");

                    b.Property<DateOnly?>("FechaEgreso")
                        .HasColumnType("date");

                    b.Property<DateOnly>("FechaIngreso")
                        .HasColumnType("date");

                    b.Property<TimeOnly?>("HoraEgreso")
                        .HasColumnType("time");

                    b.Property<TimeOnly?>("HoraIngreso")
                        .IsRequired()
                        .HasColumnType("time");

                    b.HasKey("Id");

                    b.HasIndex("ClienteId");

                    b.HasIndex("EspacioId");

                    b.ToTable("Reservas");
                });

            modelBuilder.Entity("MVCEstacionamiento.Models.Vehiculo", b =>
                {
                    b.Property<string>("Patente")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("ClienteId")
                        .HasColumnType("int");

                    b.Property<string>("Marca")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Modelo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("Tipo")
                        .HasColumnType("int");

                    b.HasKey("Patente");

                    b.HasIndex("ClienteId");

                    b.ToTable("Vehiculos");
                });

            modelBuilder.Entity("MVCEstacionamiento.Models.ReciboDePago", b =>
                {
                    b.HasOne("MVCEstacionamiento.Models.Reserva", "Reserva")
                        .WithMany()
                        .HasForeignKey("ReservaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Reserva");
                });

            modelBuilder.Entity("MVCEstacionamiento.Models.Reserva", b =>
                {
                    b.HasOne("MVCEstacionamiento.Models.Cliente", "Cliente")
                        .WithMany("Reservas")
                        .HasForeignKey("ClienteId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MVCEstacionamiento.Models.Espacio", "Espacio")
                        .WithMany("Reservas")
                        .HasForeignKey("EspacioId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Cliente");

                    b.Navigation("Espacio");
                });

            modelBuilder.Entity("MVCEstacionamiento.Models.Vehiculo", b =>
                {
                    b.HasOne("MVCEstacionamiento.Models.Cliente", "Propietario")
                        .WithMany("Vehiculos")
                        .HasForeignKey("ClienteId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Propietario");
                });

            modelBuilder.Entity("MVCEstacionamiento.Models.Cliente", b =>
                {
                    b.Navigation("Reservas");

                    b.Navigation("Vehiculos");
                });

            modelBuilder.Entity("MVCEstacionamiento.Models.Espacio", b =>
                {
                    b.Navigation("Reservas");
                });
#pragma warning restore 612, 618
        }
    }
}
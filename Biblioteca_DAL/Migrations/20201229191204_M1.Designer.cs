﻿// <auto-generated />
using System;
using Biblioteca_DAL;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Biblioteca_DataAccess.Migrations
{
    [DbContext(typeof(BibliotecaDBContext))]
    [Migration("20201229191204_M1")]
    partial class M1
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.1");

            modelBuilder.Entity("Biblioteca_DAL.Model.Autor", b =>
                {
                    b.Property<int>("AutorId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Apellido")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime>("FechaNacimiento")
                        .HasColumnType("datetime2");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("AutorId");

                    b.ToTable("Autor");
                });

            modelBuilder.Entity("Biblioteca_DAL.Model.Editorial", b =>
                {
                    b.Property<int>("EditorialId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("EditorialId");

                    b.ToTable("Editorial");
                });

            modelBuilder.Entity("Biblioteca_DAL.Model.Lector", b =>
                {
                    b.Property<int>("LectorId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Apellido")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Direccion")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime?>("FechaAlta")
                        .HasColumnType("datetime2");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Telefono")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("LectorId");

                    b.ToTable("Lector");
                });

            modelBuilder.Entity("Biblioteca_DAL.Model.LectorCredencial", b =>
                {
                    b.Property<int>("LectorCredencialId")
                        .HasColumnType("int");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("UserPassword")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("LectorCredencialId");

                    b.ToTable("LectorCredencial");
                });

            modelBuilder.Entity("Biblioteca_DAL.Model.Libro", b =>
                {
                    b.Property<int>("LibroId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("AutorId")
                        .HasColumnType("int");

                    b.Property<int>("EditorialId")
                        .HasColumnType("int");

                    b.Property<DateTime>("FechaLanzamiento")
                        .HasColumnType("datetime2");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("LibroId");

                    b.HasIndex("AutorId");

                    b.HasIndex("EditorialId");

                    b.ToTable("Libro");
                });

            modelBuilder.Entity("Biblioteca_DAL.Model.Prestacion", b =>
                {
                    b.Property<int>("PrestacionId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<DateTime>("FechaDevolucion")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("FechaRetiro")
                        .HasColumnType("datetime2");

                    b.Property<int>("LectorId")
                        .HasColumnType("int");

                    b.Property<int>("LibroId")
                        .HasColumnType("int");

                    b.HasKey("PrestacionId");

                    b.HasIndex("LectorId");

                    b.HasIndex("LibroId");

                    b.ToTable("Prestacion");
                });

            modelBuilder.Entity("Biblioteca_DAL.Model.LectorCredencial", b =>
                {
                    b.HasOne("Biblioteca_DAL.Model.Lector", "Lector")
                        .WithMany()
                        .HasForeignKey("LectorCredencialId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Lector");
                });

            modelBuilder.Entity("Biblioteca_DAL.Model.Libro", b =>
                {
                    b.HasOne("Biblioteca_DAL.Model.Autor", "Autor")
                        .WithMany()
                        .HasForeignKey("AutorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Biblioteca_DAL.Model.Editorial", "Editorial")
                        .WithMany()
                        .HasForeignKey("EditorialId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Autor");

                    b.Navigation("Editorial");
                });

            modelBuilder.Entity("Biblioteca_DAL.Model.Prestacion", b =>
                {
                    b.HasOne("Biblioteca_DAL.Model.Lector", "Lector")
                        .WithMany()
                        .HasForeignKey("LectorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Biblioteca_DAL.Model.Libro", "Libro")
                        .WithMany()
                        .HasForeignKey("LibroId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Lector");

                    b.Navigation("Libro");
                });
#pragma warning restore 612, 618
        }
    }
}
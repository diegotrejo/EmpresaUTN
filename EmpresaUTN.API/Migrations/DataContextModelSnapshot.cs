﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace EmpresaUTN.API.Migrations
{
    [DbContext(typeof(DataContext))]
    partial class DataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.5");

            modelBuilder.Entity("EmpresaUTN.Modelos.Canton", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("CabeceraCantonal")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int?>("ProvinciaId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("ProvinciaId");

                    b.ToTable("Cantones");
                });

            modelBuilder.Entity("EmpresaUTN.Modelos.Pais", b =>
                {
                    b.Property<int>("CodigoPais")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Capital")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("CodigoISO")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Idioma")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Moneda")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("Poblacion")
                        .HasColumnType("INTEGER");

                    b.HasKey("CodigoPais");

                    b.ToTable("Paises");
                });

            modelBuilder.Entity("EmpresaUTN.Modelos.Provincia", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("ActividadEconomica")
                        .HasColumnType("TEXT");

                    b.Property<int>("Area")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int?>("PaisCodigoPais")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("PaisCodigoPais");

                    b.ToTable("Provincias");
                });

            modelBuilder.Entity("EmpresaUTN.Modelos.Canton", b =>
                {
                    b.HasOne("EmpresaUTN.Modelos.Provincia", "Provincia")
                        .WithMany("Cantones")
                        .HasForeignKey("ProvinciaId");

                    b.Navigation("Provincia");
                });

            modelBuilder.Entity("EmpresaUTN.Modelos.Provincia", b =>
                {
                    b.HasOne("EmpresaUTN.Modelos.Pais", "Pais")
                        .WithMany("Provincias")
                        .HasForeignKey("PaisCodigoPais");

                    b.Navigation("Pais");
                });

            modelBuilder.Entity("EmpresaUTN.Modelos.Pais", b =>
                {
                    b.Navigation("Provincias");
                });

            modelBuilder.Entity("EmpresaUTN.Modelos.Provincia", b =>
                {
                    b.Navigation("Cantones");
                });
#pragma warning restore 612, 618
        }
    }
}
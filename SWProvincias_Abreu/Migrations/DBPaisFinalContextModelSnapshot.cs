﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SWProvincias_Abreu.Data;

namespace SWProvincias_Abreu.Migrations
{
    [DbContext(typeof(DBPaisFinalContext))]
    partial class DBPaisFinalContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.25")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("SWProvincias_Abreu.Models.Ciudad", b =>
                {
                    b.Property<int>("IdCiudad")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("varchar(50)");

                    b.Property<int>("ProvinciaId")
                        .HasColumnType("int");

                    b.HasKey("IdCiudad");

                    b.HasIndex("ProvinciaId");

                    b.ToTable("Ciudad");
                });

            modelBuilder.Entity("SWProvincias_Abreu.Models.Provincia", b =>
                {
                    b.Property<int>("IdProvincia")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("varchar(50)");

                    b.HasKey("IdProvincia");

                    b.ToTable("Provincias");
                });

            modelBuilder.Entity("SWProvincias_Abreu.Models.Ciudad", b =>
                {
                    b.HasOne("SWProvincias_Abreu.Models.Provincia", "Provincia")
                        .WithMany("Cidudades")
                        .HasForeignKey("ProvinciaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}

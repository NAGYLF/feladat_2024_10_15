﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebApplication2.Models;

#nullable disable

namespace WebApplication2.Migrations
{
    [DbContext(typeof(TargyDbContext))]
    [Migration("20241015123416_CreateDatabase")]
    partial class CreateDatabase
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("WebApplication2.Models.Targy", b =>
                {
                    b.Property<Guid>("Azon")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<int>("Jegy")
                        .HasColumnType("int");

                    b.Property<string>("Leiras")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<DateTime>("Letrehozas_ideje")
                        .HasColumnType("datetime(6)");

                    b.HasKey("Azon");

                    b.ToTable("NewTargy");
                });
#pragma warning restore 612, 618
        }
    }
}

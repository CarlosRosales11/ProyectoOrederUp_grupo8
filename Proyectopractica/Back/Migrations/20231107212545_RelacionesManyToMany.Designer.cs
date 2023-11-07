﻿// <auto-generated />
using System;
using Back.Clases;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Back.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20231107212545_RelacionesManyToMany")]
    partial class RelacionesManyToMany
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Back.Clases.IngredienteOpcion", b =>
                {
                    b.Property<int>("IdIngredienteopcion")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdIngredienteopcion"));

                    b.Property<int>("IngredientesIdIngredientes")
                        .HasColumnType("int");

                    b.Property<int>("OpcionIdOpcion")
                        .HasColumnType("int");

                    b.HasKey("IdIngredienteopcion");

                    b.HasIndex("IngredientesIdIngredientes");

                    b.HasIndex("OpcionIdOpcion");

                    b.ToTable("ingredientesOpciones");
                });

            modelBuilder.Entity("Back.Clases.Ingredientes", b =>
                {
                    b.Property<int>("IdIngredientes")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdIngredientes"));

                    b.Property<string>("Descripcion")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Precio")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("IdIngredientes");

                    b.ToTable("ingredientes");
                });

            modelBuilder.Entity("Back.Clases.Opcion", b =>
                {
                    b.Property<int>("IdOpcion")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdOpcion"));

                    b.Property<int>("Cantidad")
                        .HasColumnType("int");

                    b.Property<string>("Descripcion")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Precio")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Tipo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IdOpcion");

                    b.ToTable("opciones");
                });

            modelBuilder.Entity("Back.Clases.Pedido", b =>
                {
                    b.Property<int>("IdPedido")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdPedido"));

                    b.Property<bool>("Cargado")
                        .HasColumnType("bit");

                    b.Property<DateTime>("Fecha")
                        .HasColumnType("datetime2");

                    b.Property<int>("cantidad")
                        .HasColumnType("int");

                    b.HasKey("IdPedido");

                    b.ToTable("pedidos");
                });

            modelBuilder.Entity("Back.Clases.Usuario", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<string>("Contraseña")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("usuarios");
                });

            modelBuilder.Entity("Back.Clases.IngredienteOpcion", b =>
                {
                    b.HasOne("Back.Clases.Ingredientes", "Ingredientes")
                        .WithMany("opciones")
                        .HasForeignKey("IngredientesIdIngredientes")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Back.Clases.Opcion", "Opcion")
                        .WithMany("ingredientes")
                        .HasForeignKey("OpcionIdOpcion")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Ingredientes");

                    b.Navigation("Opcion");
                });

            modelBuilder.Entity("Back.Clases.Ingredientes", b =>
                {
                    b.Navigation("opciones");
                });

            modelBuilder.Entity("Back.Clases.Opcion", b =>
                {
                    b.Navigation("ingredientes");
                });
#pragma warning restore 612, 618
        }
    }
}

﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using WebProdutos.Models;

#nullable disable

namespace WebProdutos.Migrations
{
    [DbContext(typeof(ProdutoContext))]
    partial class ProdutoContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("WebProdutos.Models.Produto", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("Id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("estoque")
                        .HasColumnType("integer");

                    b.Property<string>("nome")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<decimal>("valor")
                        .HasColumnType("numeric");

                    b.HasKey("Id");

                    b.ToTable("Produto");
                });
#pragma warning restore 612, 618
        }
    }
}

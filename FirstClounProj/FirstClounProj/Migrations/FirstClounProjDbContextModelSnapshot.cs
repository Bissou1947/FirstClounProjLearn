﻿// <auto-generated />
using System;
using FirstClounProj.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace FirstClounProj.Migrations
{
    [DbContext(typeof(FirstClounProjDbContext))]
    partial class FirstClounProjDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("FirstClounProj.Data.Books", b =>
                {
                    b.Property<int>("bookId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("bookAuthor")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("bookCategory")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("bookDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("bookLanguage")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("bookTitle")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("bookTotalPages")
                        .HasColumnType("int");

                    b.Property<DateTime?>("createdDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("updateDate")
                        .HasColumnType("datetime2");

                    b.HasKey("bookId");

                    b.ToTable("Books");
                });
#pragma warning restore 612, 618
        }
    }
}

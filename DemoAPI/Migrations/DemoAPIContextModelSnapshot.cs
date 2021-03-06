﻿// <auto-generated />
using DemoAPI.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DemoAPI.Migrations
{
    [DbContext(typeof(DemoAPIContext))]
    partial class DemoAPIContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("DemoAPI.Models.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Category");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Zoutjes"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Fruit"
                        });
                });

            modelBuilder.Entity("DemoAPI.Models.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("Product");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CategoryId = 1,
                            Description = "Lekkere chips",
                            Name = "Zoute chips",
                            Price = 2.0
                        },
                        new
                        {
                            Id = 2,
                            CategoryId = 1,
                            Description = "Goed voor de dorst",
                            Name = "Zoute pinda's",
                            Price = 2.0
                        },
                        new
                        {
                            Id = 3,
                            CategoryId = 1,
                            Description = "Wie houdt er niet van",
                            Name = "Paprika chips",
                            Price = 1.5
                        },
                        new
                        {
                            Id = 4,
                            CategoryId = 1,
                            Description = "Gezond en lekker!",
                            Name = "Cashewnoten",
                            Price = 1.25
                        },
                        new
                        {
                            Id = 5,
                            CategoryId = 2,
                            Description = "Boordevol vitamine C",
                            Name = "Appels",
                            Price = 1.75
                        },
                        new
                        {
                            Id = 6,
                            CategoryId = 2,
                            Description = "Helpen ook om goed te slapen",
                            Name = "Bananen",
                            Price = 2.0
                        },
                        new
                        {
                            Id = 7,
                            CategoryId = 2,
                            Description = "Hier kan je wijn van maken",
                            Name = "Druiven",
                            Price = 2.5
                        },
                        new
                        {
                            Id = 8,
                            CategoryId = 2,
                            Description = "Deze smaken lekker",
                            Name = "Kersen",
                            Price = 2.25
                        });
                });

            modelBuilder.Entity("DemoAPI.Models.Product", b =>
                {
                    b.HasOne("DemoAPI.Models.Category", "Category")
                        .WithMany()
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}

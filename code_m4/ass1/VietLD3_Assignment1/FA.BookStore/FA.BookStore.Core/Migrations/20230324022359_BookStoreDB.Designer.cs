﻿// <auto-generated />
using System;
using FA.BookStore.Core.DataContext;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace FA.BookStore.Core.Migrations
{
    [DbContext(typeof(BookStoreContext))]
    [Migration("20230324022359_BookStoreDB")]
    partial class BookStoreDB
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.15")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("FA.BookStore.Core.Models.Book", b =>
                {
                    b.Property<int>("BookId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("BookId"), 1L, 1);

                    b.Property<int>("AuthorId")
                        .HasColumnType("int");

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("ImgUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<DateTime>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.Property<int>("PublisherId")
                        .HasColumnType("int");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<string>("Summary")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("BookId");

                    b.HasIndex("CategoryId");

                    b.HasIndex("PublisherId");

                    b.ToTable("Book", (string)null);

                    b.HasData(
                        new
                        {
                            BookId = 1,
                            AuthorId = 1,
                            CategoryId = 3,
                            CreateDate = new DateTime(2023, 3, 24, 9, 23, 59, 538, DateTimeKind.Local).AddTicks(7316),
                            ImgUrl = "",
                            IsActive = true,
                            ModifiedDate = new DateTime(2023, 3, 24, 9, 23, 59, 538, DateTimeKind.Local).AddTicks(7339),
                            Price = 100000.0,
                            PublisherId = 1,
                            Quantity = 2,
                            Summary = "b1",
                            Title = "b1"
                        },
                        new
                        {
                            BookId = 2,
                            AuthorId = 2,
                            CategoryId = 2,
                            CreateDate = new DateTime(2023, 3, 24, 9, 23, 59, 538, DateTimeKind.Local).AddTicks(7344),
                            ImgUrl = "",
                            IsActive = true,
                            ModifiedDate = new DateTime(2023, 3, 24, 9, 23, 59, 538, DateTimeKind.Local).AddTicks(7345),
                            Price = 100000.0,
                            PublisherId = 2,
                            Quantity = 4,
                            Summary = "b2",
                            Title = "b2"
                        },
                        new
                        {
                            BookId = 3,
                            AuthorId = 2,
                            CategoryId = 1,
                            CreateDate = new DateTime(2023, 3, 24, 9, 23, 59, 538, DateTimeKind.Local).AddTicks(7348),
                            ImgUrl = "",
                            IsActive = false,
                            ModifiedDate = new DateTime(2023, 3, 24, 9, 23, 59, 538, DateTimeKind.Local).AddTicks(7349),
                            Price = 100000.0,
                            PublisherId = 3,
                            Quantity = 4,
                            Summary = "b3",
                            Title = "b3"
                        });
                });

            modelBuilder.Entity("FA.BookStore.Core.Models.Category", b =>
                {
                    b.Property<int>("CategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CategoryId"), 1L, 1);

                    b.Property<string>("CategoryName")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CategoryId");

                    b.ToTable("Category", (string)null);

                    b.HasData(
                        new
                        {
                            CategoryId = 1,
                            CategoryName = "abc",
                            Description = "abc"
                        },
                        new
                        {
                            CategoryId = 2,
                            CategoryName = "vcd",
                            Description = "vcd"
                        },
                        new
                        {
                            CategoryId = 3,
                            CategoryName = "dfr",
                            Description = "dfg"
                        });
                });

            modelBuilder.Entity("FA.BookStore.Core.Models.Comment", b =>
                {
                    b.Property<int>("CommentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CommentId"), 1L, 1);

                    b.Property<int>("BookId")
                        .HasColumnType("int");

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsActice")
                        .HasColumnType("bit");

                    b.HasKey("CommentId");

                    b.HasIndex("BookId");

                    b.ToTable("Comments");

                    b.HasData(
                        new
                        {
                            CommentId = 1,
                            BookId = 1,
                            Content = "c1",
                            CreatedDate = new DateTime(2023, 3, 24, 9, 23, 59, 538, DateTimeKind.Local).AddTicks(7456),
                            IsActice = true
                        },
                        new
                        {
                            CommentId = 2,
                            BookId = 2,
                            Content = "c2",
                            CreatedDate = new DateTime(2023, 3, 24, 9, 23, 59, 538, DateTimeKind.Local).AddTicks(7460),
                            IsActice = true
                        },
                        new
                        {
                            CommentId = 3,
                            BookId = 3,
                            Content = "c3",
                            CreatedDate = new DateTime(2023, 3, 24, 9, 23, 59, 538, DateTimeKind.Local).AddTicks(7462),
                            IsActice = true
                        },
                        new
                        {
                            CommentId = 4,
                            BookId = 3,
                            Content = "c4",
                            CreatedDate = new DateTime(2023, 3, 24, 9, 23, 59, 538, DateTimeKind.Local).AddTicks(7463),
                            IsActice = true
                        });
                });

            modelBuilder.Entity("FA.BookStore.Core.Models.Publisher", b =>
                {
                    b.Property<int>("PublisherId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PublisherId"), 1L, 1);

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("PublisherId");

                    b.ToTable("Publishers");

                    b.HasData(
                        new
                        {
                            PublisherId = 1,
                            Description = "p1",
                            Name = "p1"
                        },
                        new
                        {
                            PublisherId = 2,
                            Description = "p2",
                            Name = " p2"
                        },
                        new
                        {
                            PublisherId = 3,
                            Description = "p3",
                            Name = "p3"
                        });
                });

            modelBuilder.Entity("FA.BookStore.Core.Models.Book", b =>
                {
                    b.HasOne("FA.BookStore.Core.Models.Category", "Category")
                        .WithMany("Books")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("FA.BookStore.Core.Models.Publisher", "Publisher")
                        .WithMany("Books")
                        .HasForeignKey("PublisherId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");

                    b.Navigation("Publisher");
                });

            modelBuilder.Entity("FA.BookStore.Core.Models.Comment", b =>
                {
                    b.HasOne("FA.BookStore.Core.Models.Book", "Book")
                        .WithMany("Comments")
                        .HasForeignKey("BookId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Book");
                });

            modelBuilder.Entity("FA.BookStore.Core.Models.Book", b =>
                {
                    b.Navigation("Comments");
                });

            modelBuilder.Entity("FA.BookStore.Core.Models.Category", b =>
                {
                    b.Navigation("Books");
                });

            modelBuilder.Entity("FA.BookStore.Core.Models.Publisher", b =>
                {
                    b.Navigation("Books");
                });
#pragma warning restore 612, 618
        }
    }
}

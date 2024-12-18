﻿// <auto-generated />
using System;
using AbrarHamdy_S1.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace AbrarHamdy_S1.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20241120082931_FirstMigration")]
    partial class FirstMigration
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("AbrarHamdy_S1.Models.Category", b =>
                {
                    b.Property<int>("CategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CategoryId"));

                    b.Property<string>("CategoryName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CategoryId");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("AbrarHamdy_S1.Models.Director", b =>
                {
                    b.Property<int>("DirectorId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("DirectorId"));

                    b.Property<string>("DirectorContact")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DirectorEmailAddress")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DirectorName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("DirectorId");

                    b.ToTable("Directors");
                });

            modelBuilder.Entity("AbrarHamdy_S1.Models.Movie", b =>
                {
                    b.Property<int>("MovieId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("MovieId"));

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<DateTime>("MovieReleaseYear")
                        .HasColumnType("datetime2");

                    b.Property<string>("MovieTitle")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("MovieId");

                    b.HasIndex("CategoryId");

                    b.ToTable("Movies");
                });

            modelBuilder.Entity("AbrarHamdy_S1.Models.Nationality", b =>
                {
                    b.Property<int>("NationalityId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("NationalityId"));

                    b.Property<int>("DirectorId")
                        .HasColumnType("int");

                    b.Property<string>("NationalityName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("NationalityId");

                    b.HasIndex("DirectorId")
                        .IsUnique();

                    b.ToTable("Nationalities");
                });

            modelBuilder.Entity("DirectorMovie", b =>
                {
                    b.Property<int>("directorsDirectorId")
                        .HasColumnType("int");

                    b.Property<int>("moviesMovieId")
                        .HasColumnType("int");

                    b.HasKey("directorsDirectorId", "moviesMovieId");

                    b.HasIndex("moviesMovieId");

                    b.ToTable("DirectorMovie");
                });

            modelBuilder.Entity("AbrarHamdy_S1.Models.Movie", b =>
                {
                    b.HasOne("AbrarHamdy_S1.Models.Category", "category")
                        .WithMany("movies")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("category");
                });

            modelBuilder.Entity("AbrarHamdy_S1.Models.Nationality", b =>
                {
                    b.HasOne("AbrarHamdy_S1.Models.Director", "director")
                        .WithOne("nationality")
                        .HasForeignKey("AbrarHamdy_S1.Models.Nationality", "DirectorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("director");
                });

            modelBuilder.Entity("DirectorMovie", b =>
                {
                    b.HasOne("AbrarHamdy_S1.Models.Director", null)
                        .WithMany()
                        .HasForeignKey("directorsDirectorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("AbrarHamdy_S1.Models.Movie", null)
                        .WithMany()
                        .HasForeignKey("moviesMovieId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("AbrarHamdy_S1.Models.Category", b =>
                {
                    b.Navigation("movies");
                });

            modelBuilder.Entity("AbrarHamdy_S1.Models.Director", b =>
                {
                    b.Navigation("nationality")
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}

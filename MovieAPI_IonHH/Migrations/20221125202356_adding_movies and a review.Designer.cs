﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MovieAPI_IonHH.Context;

#nullable disable

namespace MovieAPIIonHH.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20221125202356_adding_movies and a review")]
    partial class addingmoviesandareview
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Core.Models.Movies", b =>
                {
                    b.Property<int>("MovieId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("MovieId"));

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("Overview")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Runtime")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Year")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("MovieId");

                    b.ToTable("Movies");

                    b.HasData(
                        new
                        {
                            MovieId = 1,
                            IsDeleted = false,
                            Overview = "",
                            Runtime = 102,
                            Title = "Strange World",
                            Year = "2022"
                        },
                        new
                        {
                            MovieId = 2,
                            IsDeleted = false,
                            Overview = "",
                            Runtime = 103,
                            Title = "Black Adam",
                            Year = "2022"
                        },
                        new
                        {
                            MovieId = 3,
                            IsDeleted = false,
                            Overview = "",
                            Runtime = 104,
                            Title = "R.I.P.D. 2: Rise of the Damned",
                            Year = "2022"
                        },
                        new
                        {
                            MovieId = 4,
                            IsDeleted = false,
                            Overview = "",
                            Runtime = 105,
                            Title = "Black Panther: Wakanda Forever",
                            Year = "2022"
                        },
                        new
                        {
                            MovieId = 5,
                            IsDeleted = false,
                            Overview = "",
                            Runtime = 102,
                            Title = "Disenchanted",
                            Year = "2022"
                        },
                        new
                        {
                            MovieId = 6,
                            IsDeleted = false,
                            Overview = "",
                            Runtime = 102,
                            Title = "Smile",
                            Year = "2022"
                        },
                        new
                        {
                            MovieId = 7,
                            IsDeleted = false,
                            Overview = "",
                            Runtime = 102,
                            Title = "Terrifier 2",
                            Year = "2022"
                        },
                        new
                        {
                            MovieId = 8,
                            IsDeleted = false,
                            Overview = "",
                            Runtime = 102,
                            Title = "Sniper: The White Raven",
                            Year = "2022"
                        },
                        new
                        {
                            MovieId = 9,
                            IsDeleted = false,
                            Overview = "",
                            Runtime = 102,
                            Title = "Paradise City",
                            Year = "2022"
                        },
                        new
                        {
                            MovieId = 10,
                            IsDeleted = false,
                            Overview = "",
                            Runtime = 102,
                            Title = "Hex",
                            Year = "2022"
                        },
                        new
                        {
                            MovieId = 11,
                            IsDeleted = false,
                            Overview = "",
                            Runtime = 102,
                            Title = "Medieval",
                            Year = "2022"
                        },
                        new
                        {
                            MovieId = 12,
                            IsDeleted = false,
                            Overview = "",
                            Runtime = 102,
                            Title = "Jeepers Creepers: Reborn",
                            Year = "2022"
                        },
                        new
                        {
                            MovieId = 13,
                            IsDeleted = false,
                            Overview = "",
                            Runtime = 102,
                            Title = "The Lair",
                            Year = "2022"
                        },
                        new
                        {
                            MovieId = 14,
                            IsDeleted = false,
                            Overview = "",
                            Runtime = 102,
                            Title = "Tad the Lost Explorer and the Emerald Tablet",
                            Year = "2022"
                        },
                        new
                        {
                            MovieId = 15,
                            IsDeleted = false,
                            Overview = "",
                            Runtime = 102,
                            Title = "Emily the Criminal",
                            Year = "2022"
                        },
                        new
                        {
                            MovieId = 16,
                            IsDeleted = false,
                            Overview = "",
                            Runtime = 102,
                            Title = "Lost Bullet 2",
                            Year = "2022"
                        },
                        new
                        {
                            MovieId = 17,
                            IsDeleted = false,
                            Overview = "",
                            Runtime = 102,
                            Title = "Enola Holmes 2",
                            Year = "2022"
                        },
                        new
                        {
                            MovieId = 18,
                            IsDeleted = false,
                            Overview = "",
                            Runtime = 102,
                            Title = "The Menu",
                            Year = "2022"
                        },
                        new
                        {
                            MovieId = 19,
                            IsDeleted = false,
                            Overview = "",
                            Runtime = 102,
                            Title = "On the Line",
                            Year = "2022"
                        },
                        new
                        {
                            MovieId = 20,
                            IsDeleted = false,
                            Overview = "",
                            Runtime = 102,
                            Title = "MexZombies",
                            Year = "2022"
                        },
                        new
                        {
                            MovieId = 21,
                            IsDeleted = false,
                            Overview = "",
                            Runtime = 102,
                            Title = "Margaux",
                            Year = "2022"
                        },
                        new
                        {
                            MovieId = 22,
                            IsDeleted = false,
                            Overview = "",
                            Runtime = 102,
                            Title = "All Quiet on the Western Front",
                            Year = "2022"
                        },
                        new
                        {
                            MovieId = 23,
                            IsDeleted = false,
                            Overview = "",
                            Runtime = 102,
                            Title = "Beast",
                            Year = "2022"
                        },
                        new
                        {
                            MovieId = 24,
                            IsDeleted = false,
                            Overview = "",
                            Runtime = 102,
                            Title = "Corrective Measures",
                            Year = "2022"
                        },
                        new
                        {
                            MovieId = 25,
                            IsDeleted = false,
                            Overview = "",
                            Runtime = 102,
                            Title = "Avatar: The Way of Water\n",
                            Year = "2022"
                        },
                        new
                        {
                            MovieId = 26,
                            IsDeleted = false,
                            Overview = "",
                            Runtime = 102,
                            Title = "Overdose",
                            Year = "2022"
                        },
                        new
                        {
                            MovieId = 27,
                            IsDeleted = false,
                            Overview = "",
                            Runtime = 102,
                            Title = "The Soccer Football Movie",
                            Year = "2022"
                        },
                        new
                        {
                            MovieId = 28,
                            IsDeleted = false,
                            Overview = "",
                            Runtime = 102,
                            Title = "The Friendship Game",
                            Year = "2022"
                        },
                        new
                        {
                            MovieId = 29,
                            IsDeleted = false,
                            Overview = "",
                            Runtime = 102,
                            Title = "Cuando Sea Joven",
                            Year = "2022"
                        },
                        new
                        {
                            MovieId = 30,
                            IsDeleted = false,
                            Overview = "",
                            Runtime = 102,
                            Title = "Tom and Jerry Snowman's Land",
                            Year = "2022"
                        },
                        new
                        {
                            MovieId = 31,
                            IsDeleted = false,
                            Overview = "",
                            Runtime = 102,
                            Title = "Blade of the 47 Ronin",
                            Year = "2022"
                        },
                        new
                        {
                            MovieId = 32,
                            IsDeleted = false,
                            Overview = "",
                            Runtime = 102,
                            Title = "Avatar",
                            Year = "2022"
                        },
                        new
                        {
                            MovieId = 33,
                            IsDeleted = false,
                            Overview = "",
                            Runtime = 102,
                            Title = "Thor: Love and Thunder",
                            Year = "2022"
                        },
                        new
                        {
                            MovieId = 34,
                            IsDeleted = false,
                            Overview = "",
                            Runtime = 102,
                            Title = "Spider-Man: No Way Home",
                            Year = "2022"
                        },
                        new
                        {
                            MovieId = 35,
                            IsDeleted = false,
                            Overview = "",
                            Runtime = 102,
                            Title = "The School for Good and Evil",
                            Year = "2022"
                        },
                        new
                        {
                            MovieId = 36,
                            IsDeleted = false,
                            Overview = "",
                            Runtime = 103,
                            Title = "Jurassic World Dominion",
                            Year = "2021"
                        },
                        new
                        {
                            MovieId = 37,
                            IsDeleted = false,
                            Overview = "",
                            Runtime = 102,
                            Title = "Watcher",
                            Year = "2021"
                        },
                        new
                        {
                            MovieId = 38,
                            IsDeleted = false,
                            Overview = "",
                            Runtime = 103,
                            Title = "Top Gun: Maverick",
                            Year = "2021"
                        },
                        new
                        {
                            MovieId = 39,
                            IsDeleted = false,
                            Overview = "",
                            Runtime = 102,
                            Title = "Bullet Train",
                            Year = "2021"
                        },
                        new
                        {
                            MovieId = 40,
                            IsDeleted = false,
                            Overview = "",
                            Runtime = 103,
                            Title = "The Red Book Ritual",
                            Year = "2021"
                        },
                        new
                        {
                            MovieId = 41,
                            IsDeleted = false,
                            Overview = "",
                            Runtime = 102,
                            Title = "The Invitation",
                            Year = "2021"
                        },
                        new
                        {
                            MovieId = 42,
                            IsDeleted = false,
                            Overview = "",
                            Runtime = 102,
                            Title = "To Kill the Beast",
                            Year = "2020"
                        },
                        new
                        {
                            MovieId = 43,
                            IsDeleted = false,
                            Overview = "",
                            Runtime = 102,
                            Title = "Fullmetal Alchemist: The Final Alchemy",
                            Year = "2022"
                        },
                        new
                        {
                            MovieId = 44,
                            IsDeleted = false,
                            Overview = "",
                            Runtime = 102,
                            Title = "Minions: The Rise of Gru",
                            Year = "2020"
                        },
                        new
                        {
                            MovieId = 45,
                            IsDeleted = false,
                            Overview = "",
                            Runtime = 102,
                            Title = "Sonic the Hedgehog 2",
                            Year = "2020"
                        });
                });

            modelBuilder.Entity("Core.Models.Reviews", b =>
                {
                    b.Property<int>("ReviewId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ReviewId"));

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<int>("MovieId")
                        .HasColumnType("int");

                    b.Property<double>("Rating")
                        .HasColumnType("float");

                    b.Property<string>("User")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ReviewId");

                    b.HasIndex("MovieId");

                    b.ToTable("Reviews");

                    b.HasData(
                        new
                        {
                            ReviewId = 1,
                            Date = new DateTime(2022, 11, 25, 16, 23, 56, 58, DateTimeKind.Local).AddTicks(5350),
                            Description = "Lorem Ipsum is simply dummy text of the printing",
                            IsDeleted = false,
                            MovieId = 1,
                            Rating = 2.5,
                            User = "Testing@mail.com"
                        });
                });

            modelBuilder.Entity("Core.Models.Reviews", b =>
                {
                    b.HasOne("Core.Models.Movies", "Movie")
                        .WithMany("Reviews")
                        .HasForeignKey("MovieId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Movie");
                });

            modelBuilder.Entity("Core.Models.Movies", b =>
                {
                    b.Navigation("Reviews");
                });
#pragma warning restore 612, 618
        }
    }
}

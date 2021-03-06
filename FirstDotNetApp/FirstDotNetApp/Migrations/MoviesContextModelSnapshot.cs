﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SecondDotNetApp.Data;

namespace SecondDotNetApp.Migrations
{
    [DbContext(typeof(MoviesContext))]
    partial class MoviesContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.3");

            modelBuilder.Entity("SecondDotNetApp.Models.Movies.Movie", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Author")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("TEXT");

                    b.Property<string>("Genre")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.Property<string>("Poster")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Movies");

                    b.HasData(
                        new
                        {
                            Id = -1,
                            Author = "Todd Phillips",
                            CreatedAt = new DateTime(2019, 10, 3, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Genre = "Crime , Drama , Thriller",
                            Name = "Joker",
                            Poster = "https://www.kinopoisk.ru/images/film_big/1048334.jpg"
                        },
                        new
                        {
                            Id = -2,
                            Author = "David Leitch",
                            CreatedAt = new DateTime(2019, 8, 2, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Genre = "Action , Adventure",
                            Name = "Fast & Furious Presents: Hobbs & Shaw",
                            Poster = "https://www.eventsonglobe.com/wp-content/uploads/2019/11/Fast-Furious-Presents-Hobbs-and-Shaw-HD-1080p-Download.jpg"
                        },
                        new
                        {
                            Id = -3,
                            Author = "Jon Favreau",
                            CreatedAt = new DateTime(2019, 7, 19, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Genre = "Adventure , Animation , Drama , Family , Musical",
                            Name = "The Lion King",
                            Poster = "https://i0.wp.com/itc.ua/wp-content/uploads/2019/07/oblozhka-4.jpg?fit=1280%2C800&quality=100&strip=all&ssl=1"
                        },
                        new
                        {
                            Id = -4,
                            Author = "Joachim Rønning",
                            CreatedAt = new DateTime(2019, 10, 18, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Genre = "Adventure , Family , Fantasy",
                            Name = "Maleficent: Mistress of Evil",
                            Poster = "https://is1-ssl.mzstatic.com/image/thumb/Video123/v4/bb/82/fd/bb82fd41-0c5b-2380-7757-7246c9e48600/DIS_MAL2UAE_CENS_WW_WW_ARTWORK_EN_0x0_1YRWNX000000GS.lsr/268x0w.jpg"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}

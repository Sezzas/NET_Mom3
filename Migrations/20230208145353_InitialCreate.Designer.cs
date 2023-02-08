﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using NET_Mom3.Data;

#nullable disable

namespace NETMom3.Migrations
{
    [DbContext(typeof(CDContext))]
    [Migration("20230208145353_InitialCreate")]
    partial class InitialCreate
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.2");

            modelBuilder.Entity("NET_Mom3.Models.Artist", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Artist");
                });

            modelBuilder.Entity("NET_Mom3.Models.CD", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int?>("ArtistId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Length")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.Property<DateOnly>("PublishedDate")
                        .HasColumnType("TEXT");

                    b.Property<int>("Tracks")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("ArtistId");

                    b.ToTable("CD");
                });

            modelBuilder.Entity("NET_Mom3.Models.CD", b =>
                {
                    b.HasOne("NET_Mom3.Models.Artist", "Artist")
                        .WithMany()
                        .HasForeignKey("ArtistId");

                    b.Navigation("Artist");
                });
#pragma warning restore 612, 618
        }
    }
}
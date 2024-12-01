﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Veripark.Data.Context;

#nullable disable

namespace Veripark.Data.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20231202112355_MusteriTip_Tablosuna_MaxCozumSuresi_eklenmesi")]
    partial class MusteriTip_Tablosuna_MaxCozumSuresi_eklenmesi
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Veripark.Entity.Entities.MusteriTip", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("MaxCozumSuresi")
                        .HasColumnType("int");

                    b.Property<string>("MusteriTipAdi")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Silindi")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.ToTable("MusteriTipler");
                });

            modelBuilder.Entity("Veripark.Entity.Entities.OlayOncelik", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("MaxCozumSuresi")
                        .HasColumnType("int");

                    b.Property<string>("OlayOncelikAdi")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Silindi")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.ToTable("OlayOncelikler");
                });

            modelBuilder.Entity("Veripark.Entity.Entities.OlayTip", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("OlayOncelikId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("OlayTipAdi")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Silindi")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.HasIndex("OlayOncelikId");

                    b.ToTable("OlayTipler");
                });

            modelBuilder.Entity("Veripark.Entity.Entities.Sikayet", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("MyProperty")
                        .HasColumnType("int");

                    b.Property<bool>("Silindi")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.ToTable("Sikayetler");
                });

            modelBuilder.Entity("Veripark.Entity.Entities.OlayTip", b =>
                {
                    b.HasOne("Veripark.Entity.Entities.OlayOncelik", "OlayOncelik")
                        .WithMany()
                        .HasForeignKey("OlayOncelikId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("OlayOncelik");
                });
#pragma warning restore 612, 618
        }
    }
}

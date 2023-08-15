﻿// <auto-generated />
using AuthorizeVeAuthentication.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace AuthorizeVeAuthentication.Migrations
{
    [DbContext(typeof(Context))]
    [Migration("20230815132737_kullanici1")]
    partial class kullanici1
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("AuthorizeVeAuthentication.Models.TbKullanici", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<string>("ad")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("role")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("sifre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("soyad")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("Kullanicilar");

                    b.HasData(
                        new
                        {
                            id = 1,
                            ad = "Kullanıcı1",
                            email = "kullanici1@gmail.com",
                            role = "Yönetici",
                            sifre = "kullanici1",
                            soyad = "Kullanıcı1"
                        },
                        new
                        {
                            id = 2,
                            ad = "Kullanıcı2",
                            email = "kullanici2@gmail.com",
                            role = "Admin",
                            sifre = "kullanici2",
                            soyad = "Kullanıcı2"
                        },
                        new
                        {
                            id = 3,
                            ad = "Kullanıcı3",
                            email = "kullanici3@gmail.com",
                            role = "Üye",
                            sifre = "kullanici3",
                            soyad = "Kullanıcı3"
                        },
                        new
                        {
                            id = 4,
                            ad = "Kullanıcı4",
                            email = "kullanici4@gmail.com",
                            role = "Ban",
                            sifre = "kullanici4",
                            soyad = "Kullanıcı4"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}

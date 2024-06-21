﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using apicrypto.Data;

#nullable disable

namespace apicrypto.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("apicrypto.Models.Comment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("datetime2");

                    b.Property<int?>("CryptocurrencyId")
                        .HasColumnType("int");

                    b.Property<int?>("DcaInvestmentId")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CryptocurrencyId");

                    b.HasIndex("DcaInvestmentId");

                    b.ToTable("Comments");
                });

            modelBuilder.Entity("apicrypto.Models.Cryptocurrency", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Symbol")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Cryptocurrency");
                });

            modelBuilder.Entity("apicrypto.Models.DcaInvestment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CryptoPrice")
                        .HasColumnType("int");

                    b.Property<string>("CryptoType")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("EndDate")
                        .HasColumnType("int");

                    b.Property<int>("InvestedAmount")
                        .HasColumnType("int");

                    b.Property<int>("StartDate")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("DcaInvestments");
                });

            modelBuilder.Entity("apicrypto.Models.Comment", b =>
                {
                    b.HasOne("apicrypto.Models.Cryptocurrency", "Cryptocurrency")
                        .WithMany("Comments")
                        .HasForeignKey("CryptocurrencyId");

                    b.HasOne("apicrypto.Models.DcaInvestment", "DcaInvestment")
                        .WithMany("Comments")
                        .HasForeignKey("DcaInvestmentId");

                    b.Navigation("Cryptocurrency");

                    b.Navigation("DcaInvestment");
                });

            modelBuilder.Entity("apicrypto.Models.Cryptocurrency", b =>
                {
                    b.Navigation("Comments");
                });

            modelBuilder.Entity("apicrypto.Models.DcaInvestment", b =>
                {
                    b.Navigation("Comments");
                });
#pragma warning restore 612, 618
        }
    }
}

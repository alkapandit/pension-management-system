﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using UserServices.Data;

#nullable disable

namespace UserServices.Migrations
{
    [DbContext(typeof(UserServicesContext))]
    [Migration("20220830131631_initial")]
    partial class initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("UserServices.Models.PensionStatus", b =>
                {
                    b.Property<string>("PensionId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Active")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ApprovedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("PensionName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("PensionReleaseDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Status")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("PensionId");

                    b.HasIndex("Email");

                    b.ToTable("PensionStatus");
                });

            modelBuilder.Entity("UserServices.Models.Request", b =>
                {
                    b.Property<int>("RequestId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("RequestId"), 1L, 1);

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PensionId")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PensionName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("RequestDate")
                        .HasColumnType("datetime2");

                    b.HasKey("RequestId");

                    b.ToTable("Request");
                });

            modelBuilder.Entity("UserServices.Models.User", b =>
                {
                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Aadhar")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AccountNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Age")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BankName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BankType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FullName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Gender")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Mobile")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PAN")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("RegisterDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Roles")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Email");

                    b.ToTable("User");
                });

            modelBuilder.Entity("UserServices.Models.PensionStatus", b =>
                {
                    b.HasOne("UserServices.Models.User", "Users")
                        .WithMany()
                        .HasForeignKey("Email");

                    b.Navigation("Users");
                });
#pragma warning restore 612, 618
        }
    }
}
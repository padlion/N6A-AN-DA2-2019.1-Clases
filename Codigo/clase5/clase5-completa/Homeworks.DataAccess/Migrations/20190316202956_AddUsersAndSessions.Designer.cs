﻿// <auto-generated />
using System;
using Homeworks.DataAccess;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Homeworks.DataAccess.Migrations
{
    [DbContext(typeof(HomeworksContext))]
    [Migration("20190316202956_AddUsersAndSessions")]
    partial class AddUsersAndSessions
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.2-servicing-10034")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Homeworks.Domain.Exercise", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<Guid?>("HomeworkId");

                    b.Property<string>("Problem");

                    b.Property<int>("Score");

                    b.HasKey("Id");

                    b.HasIndex("HomeworkId");

                    b.ToTable("Exercises");
                });

            modelBuilder.Entity("Homeworks.Domain.Homework", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Description");

                    b.Property<DateTime>("DueDate");

                    b.HasKey("Id");

                    b.ToTable("Homeworks");
                });

            modelBuilder.Entity("Homeworks.Domain.Session", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<Guid>("token");

                    b.Property<Guid?>("userId");

                    b.HasKey("Id");

                    b.HasIndex("userId");

                    b.ToTable("Sessions");
                });

            modelBuilder.Entity("Homeworks.Domain.User", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.Property<string>("Password");

                    b.Property<string>("UserName");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("Homeworks.Domain.Exercise", b =>
                {
                    b.HasOne("Homeworks.Domain.Homework")
                        .WithMany("Exercises")
                        .HasForeignKey("HomeworkId");
                });

            modelBuilder.Entity("Homeworks.Domain.Session", b =>
                {
                    b.HasOne("Homeworks.Domain.User", "user")
                        .WithMany()
                        .HasForeignKey("userId");
                });
#pragma warning restore 612, 618
        }
    }
}
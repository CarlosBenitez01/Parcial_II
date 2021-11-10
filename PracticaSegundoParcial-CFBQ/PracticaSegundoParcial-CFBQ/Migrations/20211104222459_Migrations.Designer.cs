﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PracticaSegundoParcial_CFBQ.Data;

namespace PracticaSegundoParcial_CFBQ.Migrations
{
    [DbContext(typeof(AplicattionDbContext))]
    [Migration("20211104222459_Migrations")]
    partial class Migrations
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.11")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("PracticaSegundoParcial_CFBQ.Dominio.Course", b =>
                {
                    b.Property<int>("CourseId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Credits")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CourseId");

                    b.ToTable("Courses");
                });

            modelBuilder.Entity("PracticaSegundoParcial_CFBQ.Dominio.Enrollements", b =>
                {
                    b.Property<int>("EnrollementID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CourseID")
                        .HasColumnType("int");

                    b.Property<int?>("Grade")
                        .HasColumnType("int");

                    b.Property<int>("StudentsID")
                        .HasColumnType("int");

                    b.HasKey("EnrollementID");

                    b.HasIndex("CourseID");

                    b.HasIndex("StudentsID");

                    b.ToTable("Enrollements");
                });

            modelBuilder.Entity("PracticaSegundoParcial_CFBQ.Dominio.Students", b =>
                {
                    b.Property<int>("StudentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("EnrollementsDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("FirtsMidName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.HasKey("StudentId");

                    b.ToTable("Students");
                });

            modelBuilder.Entity("PracticaSegundoParcial_CFBQ.Dominio.Enrollements", b =>
                {
                    b.HasOne("PracticaSegundoParcial_CFBQ.Dominio.Course", "Course")
                        .WithMany("Enrollements")
                        .HasForeignKey("CourseID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("PracticaSegundoParcial_CFBQ.Dominio.Students", "Students")
                        .WithMany("Enrollements")
                        .HasForeignKey("StudentsID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Course");

                    b.Navigation("Students");
                });

            modelBuilder.Entity("PracticaSegundoParcial_CFBQ.Dominio.Course", b =>
                {
                    b.Navigation("Enrollements");
                });

            modelBuilder.Entity("PracticaSegundoParcial_CFBQ.Dominio.Students", b =>
                {
                    b.Navigation("Enrollements");
                });
#pragma warning restore 612, 618
        }
    }
}

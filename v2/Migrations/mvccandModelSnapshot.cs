﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using v2.Models;

namespace v2.Migrations
{
    [DbContext(typeof(mvccand))]
    partial class mvccandModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.13")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("v2.Models.candidat", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Candidats");
                });

            modelBuilder.Entity("v2.Models.offre", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("candidatId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("candidatId");

                    b.ToTable("Offres");
                });

            modelBuilder.Entity("v2.Models.offre", b =>
                {
                    b.HasOne("v2.Models.candidat", null)
                        .WithMany("Offres")
                        .HasForeignKey("candidatId");
                });

            modelBuilder.Entity("v2.Models.candidat", b =>
                {
                    b.Navigation("Offres");
                });
#pragma warning restore 612, 618
        }
    }
}

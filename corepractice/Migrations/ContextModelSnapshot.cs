﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using corepractice.Data;

namespace corepractice.Migrations
{
    [DbContext(typeof(Context))]
    partial class ContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("corepractice.Models.Group", b =>
                {
                    b.Property<int>("GroupId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(256);

                    b.Property<string>("GroupName")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.HasKey("GroupId");

                    b.ToTable("Group");
                });

            modelBuilder.Entity("corepractice.Models.User", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DateOfBirth");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(256);

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.Property<string>("Mobile")
                        .HasMaxLength(50);

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(128);

                    b.Property<string>("Phone")
                        .HasMaxLength(50);

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.HasKey("UserId");

                    b.ToTable("User");
                });
#pragma warning restore 612, 618
        }
    }
}
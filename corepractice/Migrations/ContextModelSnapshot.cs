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
                        .HasMaxLength(256);

                    b.Property<string>("GroupName")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.HasKey("GroupId");

                    b.ToTable("Group");

                    b.HasData(
                        new
                        {
                            GroupId = 1,
                            Description = "Australian Broadcasting Corporation",
                            GroupName = "ABC"
                        },
                        new
                        {
                            GroupId = 4,
                            Description = "British Broadcasting Corporation",
                            GroupName = "BBC"
                        },
                        new
                        {
                            GroupId = 6,
                            Description = "Canadian Broadcasting Corporation",
                            GroupName = "CBC"
                        });
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

                    b.Property<string>("Firstname")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.Property<string>("Lastname")
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

                    b.HasData(
                        new
                        {
                            UserId = 2,
                            DateOfBirth = new DateTime(1990, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "Test@gmail.com",
                            Firstname = "partho33332",
                            Lastname = "paul1112452",
                            Mobile = "04565465464112312",
                            Password = "test123123123",
                            Phone = "256356523",
                            Username = "rwete"
                        },
                        new
                        {
                            UserId = 3,
                            DateOfBirth = new DateTime(2200, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "test",
                            Firstname = "test",
                            Lastname = "test",
                            Mobile = "56",
                            Password = "sg",
                            Phone = "655",
                            Username = "gs"
                        },
                        new
                        {
                            UserId = 4,
                            DateOfBirth = new DateTime(2200, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "fgdg",
                            Firstname = "dfgdg",
                            Lastname = "dgdg",
                            Mobile = "dfgdg",
                            Password = "dfgd",
                            Phone = "dgf",
                            Username = "gs"
                        },
                        new
                        {
                            UserId = 9,
                            DateOfBirth = new DateTime(1986, 8, 22, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "aud@gmail.com",
                            Firstname = "Andrew",
                            Lastname = "Freeman",
                            Mobile = "13838383838",
                            Password = "pswd2020",
                            Phone = "08268485",
                            Username = "skyfat"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}

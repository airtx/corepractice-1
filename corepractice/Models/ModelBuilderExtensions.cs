using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace corepractice.Models
{
    public static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().HasData(
                new User
                {
                    UserId = 2,
                    Username = "rwete",
                    Password = "test123123123",
                    Firstname = "partho33332",
                    Lastname = "paul1112452",
                    DateOfBirth = DateTime.Parse("1990-07-01"),
                    Email = "Test@gmail.com",
                    Phone = "256356523",
                    Mobile = "04565465464112312"
                },
                new User
                {
                    UserId = 3,
                    Username = "gs",
                    Password = "sg",
                    Firstname = "test",
                    Lastname = "test",
                    DateOfBirth = DateTime.Parse("2200-01-01"),
                    Email = "test",
                    Phone = "655",
                    Mobile = "56"
                },
                new User
                {
                    UserId = 4,
                    Username = "gs",
                    Password = "dfgd",
                    Firstname = "dfgdg",
                    Lastname = "dgdg",
                    DateOfBirth = DateTime.Parse("2200-01-01"),
                    Email = "fgdg",
                    Phone = "dgf",
                    Mobile = "dfgdg"
                },
                new User
                {
                    UserId = 9,
                    Username = "skyfat",
                    Password = "pswd2020",
                    Firstname = "Andrew",
                    Lastname = "Freeman",
                    DateOfBirth = DateTime.Parse("1986-08-22"),
                    Email = "aud@gmail.com",
                    Phone = "08268485",
                    Mobile = "13838383838"
                }
            );

            modelBuilder.Entity<Group>().HasData(
                new Group { GroupId = 1, GroupName = "ABC", Description = "Australian Broadcasting Corporation" },
                new Group { GroupId = 4, GroupName = "BBC", Description = "British Broadcasting Corporation" },
                new Group { GroupId = 6, GroupName = "CBC", Description = "Canadian Broadcasting Corporation" }
            );
        }
    }
}

using corepractice.Data;
using corepractice.Models;
using System;
using System.Linq;

namespace ContosoUniversity.Data
{
    public static class DbInitializer
    {
        public static void Initialize(Context context)
        {
            context.Database.EnsureCreated();

            // Look for any users.
            if (context.User.Any())
            {
                return;   // DB has been seeded
            }

            var users = new User[]
            {
                new User{UserId=2,Username="rwete",Password="",FirstName="partho33332",LastName="paul1112452",
                    DateOfBirth=DateTime.Parse("1990-07-01"),Email="Test@gmail.com",Phone="256356523",Mobile="04565465464112312"
                },
                new User{UserId=3,Username="gs",Password="sg",FirstName="test",LastName="test",
                    DateOfBirth=DateTime.Parse("2200-01-01"),Email="test",Phone="655",Mobile="56"
                },
                new User{UserId=4,Username="gs",Password="dfgd",FirstName="dfgdg",LastName="dgdg",
                    DateOfBirth=DateTime.Parse("2200-01-01"),Email="fgdg",Phone="dgf",Mobile="dfgdg"
                },
                new User{UserId=9,Username="skyfat",Password="pswd2020",FirstName="Andrew",LastName="Freeman",
                    DateOfBirth=DateTime.Parse("1986-08-22"),Email="aud@gmail.com",Phone="08268485",Mobile="13838383838"
                },
            };
            foreach (User item in users)
            {
                context.User.Add(item);
            }
            context.SaveChanges();

            var groups = new Group[]
            {
                new Group{GroupId=1,GroupName="ABC",Description="Australian Broadcasting Corporation"},
                new Group{GroupId=4,GroupName="BBC",Description="British Broadcasting Corporation"},
                new Group{GroupId=6,GroupName="CBC",Description="Canadian Broadcasting Corporation"}
            };
            foreach (Group item in groups)
            {
                context.Group.Add(item);
            }
            context.SaveChanges();
        }
    }
}
using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace corepractice.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Group",
                columns: table => new
                {
                    GroupId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    GroupName = table.Column<string>(maxLength: 50, nullable: false),
                    Description = table.Column<string>(maxLength: 256, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Group", x => x.GroupId);
                });

            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    UserId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Username = table.Column<string>(maxLength: 50, nullable: false),
                    Password = table.Column<string>(maxLength: 128, nullable: false),
                    Lastname = table.Column<string>(maxLength: 100, nullable: false),
                    Firstname = table.Column<string>(maxLength: 100, nullable: false),
                    DateOfBirth = table.Column<DateTime>(nullable: false),
                    Email = table.Column<string>(maxLength: 256, nullable: false),
                    Phone = table.Column<string>(maxLength: 50, nullable: true),
                    Mobile = table.Column<string>(maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.UserId);
                });

            migrationBuilder.InsertData(
                table: "Group",
                columns: new[] { "GroupId", "Description", "GroupName" },
                values: new object[,]
                {
                    { 1, "Australian Broadcasting Corporation", "ABC" },
                    { 4, "British Broadcasting Corporation", "BBC" },
                    { 6, "Canadian Broadcasting Corporation", "CBC" }
                });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "UserId", "DateOfBirth", "Email", "Firstname", "Lastname", "Mobile", "Password", "Phone", "Username" },
                values: new object[,]
                {
                    { 2, new DateTime(1990, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Test@gmail.com", "partho33332", "paul1112452", "04565465464112312", "test123123123", "256356523", "rwete" },
                    { 3, new DateTime(2200, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "test", "test", "test", "56", "sg", "655", "gs" },
                    { 4, new DateTime(2200, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "fgdg", "dfgdg", "dgdg", "dfgdg", "dfgd", "dgf", "gs" },
                    { 9, new DateTime(1986, 8, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "aud@gmail.com", "Andrew", "Freeman", "13838383838", "pswd2020", "08268485", "skyfat" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Group");

            migrationBuilder.DropTable(
                name: "User");
        }
    }
}

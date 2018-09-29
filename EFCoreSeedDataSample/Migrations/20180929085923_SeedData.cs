using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EFCoreSeedDataSample.Migrations
{
    public partial class SeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("c4e27fc0-8d63-4ffb-8fb1-60225dec9e7a"), "Stu 1" },
                    { new Guid("9ac6a7be-8bc5-4271-98e0-672dd35bb85d"), "Stu 2" },
                    { new Guid("72dab05d-5c6b-43e0-8ec0-3ecd0552a27d"), "Stu 3" },
                    { new Guid("07cbf7c5-08ce-45a6-be8b-d83895edc56c"), "Stu 4" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("07cbf7c5-08ce-45a6-be8b-d83895edc56c"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("72dab05d-5c6b-43e0-8ec0-3ecd0552a27d"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("9ac6a7be-8bc5-4271-98e0-672dd35bb85d"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("c4e27fc0-8d63-4ffb-8fb1-60225dec9e7a"));
        }
    }
}

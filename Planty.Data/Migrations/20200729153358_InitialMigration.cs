﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Planty.Data.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    Price = table.Column<decimal>(nullable: false),
                    Quantity = table.Column<int>(nullable: false),
                    Discriminator = table.Column<string>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    LatinName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Products");
        }
    }
}

using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace Maonot.Migrations
{
    public partial class g : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "g",
                table: "Messages");

            migrationBuilder.AddColumn<string>(
                name: "G",
                table: "FaultForms",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "G",
                table: "FaultForms");

            migrationBuilder.AddColumn<string>(
                name: "g",
                table: "Messages",
                nullable: true);
        }
    }
}

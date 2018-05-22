using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace Maonot.Migrations
{
    public partial class deleteFault : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FaultForms");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "FaultForms",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Apartment = table.Column<int>(nullable: false),
                    Description = table.Column<string>(nullable: false),
                    FullName = table.Column<string>(nullable: false),
                    G = table.Column<string>(nullable: true),
                    PhoneNumber = table.Column<string>(nullable: true),
                    RoomNum = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FaultForms", x => x.ID);
                });
        }
    }
}

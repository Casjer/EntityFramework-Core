using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EjemploEF.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Clientes",
                columns: table => new
                {
                    ClienteId = table.Column<int>(type: "INTEGER", unicode: false, maxLength: 100, nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nombre = table.Column<string>(type: "TEXT", unicode: false, maxLength: 100, nullable: false),
                    Apellido = table.Column<string>(type: "TEXT", unicode: false, maxLength: 100, nullable: false),
                    Cedula = table.Column<string>(type: "TEXT", unicode: false, maxLength: 15, nullable: true),
                    Direccion = table.Column<string>(type: "TEXT", unicode: false, maxLength: 15, nullable: true),
                    FechaNacimiento = table.Column<DateTime>(type: "date", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clientes", x => x.ClienteId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Clientes");
        }
    }
}

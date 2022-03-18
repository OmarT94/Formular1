using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Formular1.Server.Migrations
{
    public partial class Messe : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "HotelZimmers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdTeilnehmer = table.Column<int>(type: "int", nullable: false),
                    Übernachtung = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Anreisedatum = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Abreisetag = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ZimmerForm = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HotelZimmers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TeilnehmerPVLives",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdTeilnehmer = table.Column<int>(type: "int", nullable: false),
                    TeilnahmePVLive = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    amSamstag = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    amSonntag = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    mitKollegen = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AnzahlKollege = table.Column<int>(type: "int", nullable: false),
                    AnredeKollege = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NameKollege = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EmailKollege = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Minderjährig = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TeilnehmerPVLives", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Teilnehmers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Anrede = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    mitBegleitung = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BgAnrede = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BgName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BgEmail = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Teilnehmers", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "HotelZimmers");

            migrationBuilder.DropTable(
                name: "TeilnehmerPVLives");

            migrationBuilder.DropTable(
                name: "Teilnehmers");
        }
    }
}

using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Gestor.API.DataBase.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Concession",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    concession = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Concession", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "GalleryType",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    galleryType = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GalleryType", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Galeria",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcessionId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    dataAtualizacao = table.Column<DateTime>(type: "datetime2", nullable: false),
                    GalleryTypeId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    titulo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ElaboradorId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    qtdFotos = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Galeria", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Galeria_Concession_ConcessionId",
                        column: x => x.ConcessionId,
                        principalTable: "Concession",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Galeria_GalleryType_GalleryTypeId",
                        column: x => x.GalleryTypeId,
                        principalTable: "GalleryType",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Galeria_ConcessionId",
                table: "Galeria",
                column: "ConcessionId");

            migrationBuilder.CreateIndex(
                name: "IX_Galeria_GalleryTypeId",
                table: "Galeria",
                column: "GalleryTypeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Galeria");

            migrationBuilder.DropTable(
                name: "Concession");

            migrationBuilder.DropTable(
                name: "GalleryType");
        }
    }
}

using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace UserAuth.Migrations
{
    public partial class photo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "PhotoGallery",
                columns: table => new
                {
                    PhotoID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PhotoName = table.Column<string>(nullable: false),
                    Description = table.Column<string>(nullable: false),
                    Image = table.Column<byte[]>(nullable: false),
                    Timestamp = table.Column<DateTime>(nullable: false),
                    UserName = table.Column<string>(nullable: false),
                    UserId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PhotoGallery", x => x.PhotoID);
                    table.ForeignKey(
                        name: "FK_PhotoGallery_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_PhotoGallery_UserId",
                table: "PhotoGallery",
                column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PhotoGallery");
        }
    }
}

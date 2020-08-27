using Microsoft.EntityFrameworkCore.Migrations;

namespace Avengers.Migrations
{
    public partial class DropVideoAgain : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ReviewItems_Video_VideoId",
                table: "ReviewItems");

            migrationBuilder.DropTable(
                name: "Video");

            migrationBuilder.DropIndex(
                name: "IX_ReviewItems_VideoId",
                table: "ReviewItems");

            migrationBuilder.DropColumn(
                name: "VideoId",
                table: "ReviewItems");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "VideoId",
                table: "ReviewItems",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Video",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Avatar = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Source = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Type = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Video", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ReviewItems_VideoId",
                table: "ReviewItems",
                column: "VideoId");

            migrationBuilder.AddForeignKey(
                name: "FK_ReviewItems_Video_VideoId",
                table: "ReviewItems",
                column: "VideoId",
                principalTable: "Video",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}

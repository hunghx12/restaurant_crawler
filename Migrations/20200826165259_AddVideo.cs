using Microsoft.EntityFrameworkCore.Migrations;

namespace Avengers.Migrations
{
    public partial class AddVideo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "VideoId",
                table: "ReviewItems",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Videos",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false),
                    Source = table.Column<string>(nullable: true),
                    Avatar = table.Column<string>(nullable: true),
                    Type = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Videos", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ReviewItems_VideoId",
                table: "ReviewItems",
                column: "VideoId");

            migrationBuilder.AddForeignKey(
                name: "FK_ReviewItems_Videos_VideoId",
                table: "ReviewItems",
                column: "VideoId",
                principalTable: "Videos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ReviewItems_Videos_VideoId",
                table: "ReviewItems");

            migrationBuilder.DropTable(
                name: "Videos");

            migrationBuilder.DropIndex(
                name: "IX_ReviewItems_VideoId",
                table: "ReviewItems");

            migrationBuilder.DropColumn(
                name: "VideoId",
                table: "ReviewItems");
        }
    }
}

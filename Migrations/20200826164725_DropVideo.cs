using Microsoft.EntityFrameworkCore.Migrations;

namespace Avengers.Migrations
{
    public partial class DropVideo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ReviewItems_Videos_VideoId",
                table: "ReviewItems");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Videos",
                table: "Videos");

            migrationBuilder.RenameTable(
                name: "Videos",
                newName: "Video");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Video",
                table: "Video",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ReviewItems_Video_VideoId",
                table: "ReviewItems",
                column: "VideoId",
                principalTable: "Video",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ReviewItems_Video_VideoId",
                table: "ReviewItems");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Video",
                table: "Video");

            migrationBuilder.RenameTable(
                name: "Video",
                newName: "Videos");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Videos",
                table: "Videos",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ReviewItems_Videos_VideoId",
                table: "ReviewItems",
                column: "VideoId",
                principalTable: "Videos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}

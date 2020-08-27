using Microsoft.EntityFrameworkCore.Migrations;

namespace Avengers.Migrations
{
    public partial class DropHashTag : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Hashtag");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Hashtag",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ReviewItemId = table.Column<int>(type: "int", nullable: true),
                    Url = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Hashtag", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Hashtag_ReviewItems_ReviewItemId",
                        column: x => x.ReviewItemId,
                        principalTable: "ReviewItems",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Hashtag_ReviewItemId",
                table: "Hashtag",
                column: "ReviewItemId");
        }
    }
}

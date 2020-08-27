using Microsoft.EntityFrameworkCore.Migrations;

namespace Avengers.Migrations
{
    public partial class AddHashtag : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Hashtags",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    Url = table.Column<string>(nullable: true),
                    ReviewItemId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Hashtags", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Hashtags_ReviewItems_ReviewItemId",
                        column: x => x.ReviewItemId,
                        principalTable: "ReviewItems",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Hashtags_ReviewItemId",
                table: "Hashtags",
                column: "ReviewItemId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Hashtags");
        }
    }
}

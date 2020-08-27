using Microsoft.EntityFrameworkCore.Migrations;

namespace Avengers.Migrations
{
    public partial class AddUsers : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ReviewItems_Owners_OwnerId",
                table: "ReviewItems");

            migrationBuilder.DropTable(
                name: "Owners");

            migrationBuilder.DropTable(
                name: "UserLikes");

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    VerifyingPercent = table.Column<int>(nullable: true),
                    TrustPercent = table.Column<int>(nullable: true),
                    Rank = table.Column<int>(nullable: true),
                    Level = table.Column<string>(nullable: true),
                    Idx = table.Column<int>(nullable: true),
                    IsFollow = table.Column<bool>(nullable: true),
                    TotalReviewsFormat = table.Column<string>(nullable: true),
                    TotalPicturesFormat = table.Column<string>(nullable: true),
                    IsSelf = table.Column<bool>(nullable: true),
                    Username = table.Column<string>(nullable: true),
                    DisplayName = table.Column<string>(nullable: true),
                    Avatar = table.Column<string>(nullable: true),
                    Url = table.Column<string>(nullable: true),
                    TotalReviews = table.Column<int>(nullable: true),
                    TotalPictures = table.Column<int>(nullable: true),
                    UrlReviews = table.Column<string>(nullable: true),
                    UrlAlbums = table.Column<string>(nullable: true),
                    IsVerified = table.Column<bool>(nullable: true),
                    MobileCover = table.Column<string>(nullable: true),
                    ReviewItemId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Users_ReviewItems_ReviewItemId",
                        column: x => x.ReviewItemId,
                        principalTable: "ReviewItems",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Users_ReviewItemId",
                table: "Users",
                column: "ReviewItemId");

            migrationBuilder.AddForeignKey(
                name: "FK_ReviewItems_Users_OwnerId",
                table: "ReviewItems",
                column: "OwnerId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ReviewItems_Users_OwnerId",
                table: "ReviewItems");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.CreateTable(
                name: "Owners",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Avatar = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Idx = table.Column<int>(type: "int", nullable: true),
                    IsFollow = table.Column<bool>(type: "bit", nullable: true),
                    IsSelf = table.Column<bool>(type: "bit", nullable: true),
                    IsVerified = table.Column<bool>(type: "bit", nullable: true),
                    Level = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MobileCover = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Rank = table.Column<int>(type: "int", nullable: true),
                    TotalPictures = table.Column<int>(type: "int", nullable: true),
                    TotalPicturesFormat = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TotalReviews = table.Column<int>(type: "int", nullable: true),
                    TotalReviewsFormat = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TrustPercent = table.Column<int>(type: "int", nullable: true),
                    Url = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UrlAlbums = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UrlReviews = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Username = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VerifyingPercent = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Owners", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UserLikes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Avatar = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Idx = table.Column<int>(type: "int", nullable: true),
                    IsFollow = table.Column<bool>(type: "bit", nullable: true),
                    IsSelf = table.Column<bool>(type: "bit", nullable: true),
                    IsVerified = table.Column<bool>(type: "bit", nullable: true),
                    Level = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MobileCover = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Rank = table.Column<int>(type: "int", nullable: true),
                    ReviewItemId = table.Column<int>(type: "int", nullable: true),
                    TotalPictures = table.Column<int>(type: "int", nullable: true),
                    TotalPicturesFormat = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TotalReviews = table.Column<int>(type: "int", nullable: true),
                    TotalReviewsFormat = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TrustPercent = table.Column<int>(type: "int", nullable: true),
                    Url = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UrlAlbums = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UrlReviews = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Username = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VerifyingPercent = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserLikes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserLikes_ReviewItems_ReviewItemId",
                        column: x => x.ReviewItemId,
                        principalTable: "ReviewItems",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_UserLikes_ReviewItemId",
                table: "UserLikes",
                column: "ReviewItemId");

            migrationBuilder.AddForeignKey(
                name: "FK_ReviewItems_Owners_OwnerId",
                table: "ReviewItems",
                column: "OwnerId",
                principalTable: "Owners",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}

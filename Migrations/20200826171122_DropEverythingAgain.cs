using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Avengers.Migrations
{
    public partial class DropEverythingAgain : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Users_ReviewItems_ReviewItemId",
                table: "Users");

            migrationBuilder.DropTable(
                name: "Hashtags");

            migrationBuilder.DropTable(
                name: "Pictures");

            migrationBuilder.DropTable(
                name: "ReviewItems");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Videos");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Videos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false),
                    Avatar = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Source = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Type = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Videos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Hashtags",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ReviewItemId = table.Column<int>(type: "int", nullable: true),
                    Url = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Hashtags", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Pictures",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false),
                    BgColor = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Height = table.Column<int>(type: "int", nullable: true),
                    PhotoDetailUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PredefineAlbumID = table.Column<int>(type: "int", nullable: true),
                    ReviewItemId = table.Column<int>(type: "int", nullable: true),
                    TotalLikes = table.Column<int>(type: "int", nullable: true),
                    Url = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Width = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pictures", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false),
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
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ReviewItems",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false),
                    AvgRating = table.Column<double>(type: "float", nullable: false),
                    CanDelete = table.Column<bool>(type: "bit", nullable: true),
                    CanEdit = table.Column<bool>(type: "bit", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedOnTimeDiff = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeviceName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeviceType = table.Column<int>(type: "int", nullable: true),
                    DeviceUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EditUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HasThitCay = table.Column<bool>(type: "bit", nullable: true),
                    IsAllowComment = table.Column<bool>(type: "bit", nullable: true),
                    IsDirectDetail = table.Column<bool>(type: "bit", nullable: true),
                    IsDraft = table.Column<bool>(type: "bit", nullable: true),
                    IsFirstUserReview = table.Column<bool>(type: "bit", nullable: true),
                    IsLiked = table.Column<bool>(type: "bit", nullable: true),
                    OptionsId = table.Column<int>(type: "int", nullable: true),
                    OwnerId = table.Column<int>(type: "int", nullable: true),
                    ResId = table.Column<int>(type: "int", nullable: true),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TotalComment = table.Column<int>(type: "int", nullable: true),
                    TotalLike = table.Column<int>(type: "int", nullable: true),
                    TotalPictures = table.Column<int>(type: "int", nullable: true),
                    TotalView = table.Column<int>(type: "int", nullable: true),
                    TotalViews = table.Column<int>(type: "int", nullable: true),
                    Type = table.Column<int>(type: "int", nullable: true),
                    TypeName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Url = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VideoId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ReviewItems", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ReviewItems_Options_OptionsId",
                        column: x => x.OptionsId,
                        principalTable: "Options",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ReviewItems_Users_OwnerId",
                        column: x => x.OwnerId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ReviewItems_Videos_VideoId",
                        column: x => x.VideoId,
                        principalTable: "Videos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Hashtags_ReviewItemId",
                table: "Hashtags",
                column: "ReviewItemId");

            migrationBuilder.CreateIndex(
                name: "IX_Pictures_ReviewItemId",
                table: "Pictures",
                column: "ReviewItemId");

            migrationBuilder.CreateIndex(
                name: "IX_ReviewItems_OptionsId",
                table: "ReviewItems",
                column: "OptionsId");

            migrationBuilder.CreateIndex(
                name: "IX_ReviewItems_OwnerId",
                table: "ReviewItems",
                column: "OwnerId");

            migrationBuilder.CreateIndex(
                name: "IX_ReviewItems_VideoId",
                table: "ReviewItems",
                column: "VideoId");

            migrationBuilder.CreateIndex(
                name: "IX_Users_ReviewItemId",
                table: "Users",
                column: "ReviewItemId");

            migrationBuilder.AddForeignKey(
                name: "FK_Hashtags_ReviewItems_ReviewItemId",
                table: "Hashtags",
                column: "ReviewItemId",
                principalTable: "ReviewItems",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Pictures_ReviewItems_ReviewItemId",
                table: "Pictures",
                column: "ReviewItemId",
                principalTable: "ReviewItems",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Users_ReviewItems_ReviewItemId",
                table: "Users",
                column: "ReviewItemId",
                principalTable: "ReviewItems",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}

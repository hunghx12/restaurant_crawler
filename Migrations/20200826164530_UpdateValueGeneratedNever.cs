using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Avengers.Migrations
{
    public partial class UpdateValueGeneratedNever : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Options",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Guest = table.Column<string>(nullable: true),
                    VisitAgain = table.Column<string>(nullable: true),
                    MoneySpend = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Options", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Videos",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Source = table.Column<string>(nullable: true),
                    Avatar = table.Column<string>(nullable: true),
                    Type = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Videos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ReviewItems",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false),
                    Title = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    Type = table.Column<int>(nullable: true),
                    TypeName = table.Column<string>(nullable: true),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    CreatedOnTimeDiff = table.Column<string>(nullable: true),
                    DeviceName = table.Column<string>(nullable: true),
                    DeviceUrl = table.Column<string>(nullable: true),
                    DeviceType = table.Column<int>(nullable: true),
                    IsAllowComment = table.Column<bool>(nullable: true),
                    HasThitCay = table.Column<bool>(nullable: true),
                    TotalViews = table.Column<int>(nullable: true),
                    TotalPictures = table.Column<int>(nullable: true),
                    AvgRating = table.Column<double>(nullable: false),
                    VideoId = table.Column<int>(nullable: true),
                    OwnerId = table.Column<int>(nullable: true),
                    OptionsId = table.Column<int>(nullable: true),
                    Url = table.Column<string>(nullable: true),
                    TotalLike = table.Column<int>(nullable: true),
                    TotalComment = table.Column<int>(nullable: true),
                    IsLiked = table.Column<bool>(nullable: true),
                    CanDelete = table.Column<bool>(nullable: true),
                    CanEdit = table.Column<bool>(nullable: true),
                    ResId = table.Column<int>(nullable: true),
                    TotalView = table.Column<int>(nullable: true),
                    IsDraft = table.Column<bool>(nullable: true),
                    IsFirstUserReview = table.Column<bool>(nullable: true),
                    IsDirectDetail = table.Column<bool>(nullable: true),
                    EditUrl = table.Column<string>(nullable: true)
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
                        name: "FK_ReviewItems_Videos_VideoId",
                        column: x => x.VideoId,
                        principalTable: "Videos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Hashtags",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false),
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

            migrationBuilder.CreateTable(
                name: "Pictures",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false),
                    Url = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    Width = table.Column<int>(nullable: true),
                    Height = table.Column<int>(nullable: true),
                    BgColor = table.Column<string>(nullable: true),
                    TotalLikes = table.Column<int>(nullable: true),
                    PredefineAlbumID = table.Column<int>(nullable: true),
                    PhotoDetailUrl = table.Column<string>(nullable: true),
                    ReviewItemId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pictures", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Pictures_ReviewItems_ReviewItemId",
                        column: x => x.ReviewItemId,
                        principalTable: "ReviewItems",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false),
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
                name: "FK_Users_ReviewItems_ReviewItemId",
                table: "Users");

            migrationBuilder.DropTable(
                name: "Hashtags");

            migrationBuilder.DropTable(
                name: "Pictures");

            migrationBuilder.DropTable(
                name: "ReviewItems");

            migrationBuilder.DropTable(
                name: "Options");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Videos");
        }
    }
}

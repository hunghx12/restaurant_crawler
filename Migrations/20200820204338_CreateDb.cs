using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Avengers.Migrations
{
    public partial class CreateDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Notes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RestaurantId = table.Column<int>(nullable: false),
                    UserId = table.Column<int>(nullable: false),
                    ListId = table.Column<string>(nullable: true),
                    ListName = table.Column<string>(nullable: true),
                    CreatedOn = table.Column<DateTime>(nullable: false),
                    Description = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Notes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Places",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CityId = table.Column<int>(nullable: false),
                    ExcludeIds = table.Column<string>(nullable: true),
                    Query = table.Column<string>(nullable: true),
                    Count = table.Column<int>(nullable: false),
                    Total = table.Column<int>(nullable: false),
                    LastId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Places", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Items",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    Address = table.Column<string>(nullable: true),
                    AvgRating = table.Column<double>(nullable: false),
                    AvgRatingText = table.Column<string>(nullable: true),
                    RestaurantStatus = table.Column<int>(nullable: false),
                    Phone = table.Column<string>(nullable: true),
                    PhotoUrl = table.Column<string>(nullable: true),
                    TotalReviews = table.Column<int>(nullable: false),
                    TotalFavourites = table.Column<int>(nullable: false),
                    TotalViews = table.Column<int>(nullable: false),
                    TotalPictures = table.Column<int>(nullable: false),
                    TotalCheckIns = table.Column<int>(nullable: false),
                    Url = table.Column<string>(nullable: true),
                    Tags = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    NoteId = table.Column<int>(nullable: true),
                    HasPromotion = table.Column<bool>(nullable: false),
                    HasMemberCard = table.Column<bool>(nullable: false),
                    MemberCardDiscount = table.Column<string>(nullable: true),
                    Latitude = table.Column<double>(nullable: false),
                    Longitude = table.Column<double>(nullable: false),
                    ResUsername = table.Column<string>(nullable: true),
                    ResCreatedOn = table.Column<DateTime>(nullable: false),
                    LstCategory = table.Column<string>(nullable: true),
                    LstCuisine = table.Column<string>(nullable: true),
                    PriceMin = table.Column<int>(nullable: false),
                    PriceMax = table.Column<int>(nullable: false),
                    PriceMinDisplay = table.Column<string>(nullable: true),
                    PriceMaxDisplay = table.Column<string>(nullable: true),
                    DisplayOrder = table.Column<string>(nullable: true),
                    City = table.Column<string>(nullable: true),
                    District = table.Column<string>(nullable: true),
                    FAvgRating = table.Column<int>(nullable: false),
                    FTotalReviews = table.Column<int>(nullable: false),
                    ResUrlAlbums = table.Column<string>(nullable: true),
                    ResUrlReviews = table.Column<string>(nullable: true),
                    ContributeStatus = table.Column<string>(nullable: true),
                    CanDelete = table.Column<bool>(nullable: false),
                    ListOwnerId = table.Column<int>(nullable: false),
                    ListId = table.Column<int>(nullable: false),
                    UserId = table.Column<int>(nullable: false),
                    IsRestaurantCollection = table.Column<bool>(nullable: false),
                    TotalService = table.Column<int>(nullable: false),
                    UrlRewriteName = table.Column<string>(nullable: true),
                    LocationUrlRewriteName = table.Column<string>(nullable: true),
                    RestaurantId = table.Column<int>(nullable: false),
                    MainCategoryId = table.Column<int>(nullable: false),
                    TotalSaves = table.Column<int>(nullable: false),
                    Status = table.Column<int>(nullable: false),
                    TotalSavesFormat = table.Column<string>(nullable: true),
                    TotalReviewsFormat = table.Column<string>(nullable: true),
                    TotalPicturesFormat = table.Column<string>(nullable: true),
                    IsAds = table.Column<bool>(nullable: false),
                    MobileBgColor = table.Column<string>(nullable: true),
                    IsBooking = table.Column<bool>(nullable: false),
                    IsDelivery = table.Column<bool>(nullable: false),
                    BookingUrl = table.Column<string>(nullable: true),
                    DeliveryUrl = table.Column<string>(nullable: true),
                    HasVideo = table.Column<bool>(nullable: false),
                    HasBooking = table.Column<bool>(nullable: false),
                    HasDelivery = table.Column<bool>(nullable: false),
                    MasterCategoryId = table.Column<int>(nullable: false),
                    PromotionId = table.Column<string>(nullable: true),
                    PromotionTitle = table.Column<string>(nullable: true),
                    PromotionUrl = table.Column<string>(nullable: true),
                    Floor = table.Column<string>(nullable: true),
                    IsSaved = table.Column<bool>(nullable: false),
                    IsOpening = table.Column<bool>(nullable: false),
                    Distance = table.Column<double>(nullable: false),
                    PromotionPlainTitle = table.Column<string>(nullable: true),
                    DistanceText = table.Column<string>(nullable: true),
                    MobileBookingUrl = table.Column<string>(nullable: true),
                    PlaceId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Items", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Items_Notes_NoteId",
                        column: x => x.NoteId,
                        principalTable: "Notes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Items_Places_PlaceId",
                        column: x => x.PlaceId,
                        principalTable: "Places",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "LstReviews",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    reviewProfileUrl = table.Column<string>(nullable: true),
                    reviewUserDisplayName = table.Column<string>(nullable: true),
                    reviewUserAvatar = table.Column<string>(nullable: true),
                    reviewUrl = table.Column<string>(nullable: true),
                    AvgRatingText = table.Column<string>(nullable: true),
                    ShortReview = table.Column<bool>(nullable: false),
                    UserVerified = table.Column<bool>(nullable: false),
                    ReviewId = table.Column<int>(nullable: false),
                    Comment = table.Column<string>(nullable: true),
                    UserId = table.Column<int>(nullable: false),
                    UserFoodyId = table.Column<int>(nullable: false),
                    Username = table.Column<string>(nullable: true),
                    UserAvatar = table.Column<string>(nullable: true),
                    UserGender = table.Column<string>(nullable: true),
                    UserFirstName = table.Column<string>(nullable: true),
                    UserLastName = table.Column<string>(nullable: true),
                    AvgRating = table.Column<double>(nullable: false),
                    ItemId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LstReviews", x => x.Id);
                    table.ForeignKey(
                        name: "FK_LstReviews_Items_ItemId",
                        column: x => x.ItemId,
                        principalTable: "Items",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Services",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Type = table.Column<int>(nullable: false),
                    Url = table.Column<string>(nullable: true),
                    Title = table.Column<string>(nullable: true),
                    Text = table.Column<string>(nullable: true),
                    Avatar = table.Column<string>(nullable: true),
                    BackgroundColor = table.Column<string>(nullable: true),
                    RestaurantId = table.Column<int>(nullable: false),
                    Description = table.Column<string>(nullable: true),
                    ItemId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Services", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Services_Items_ItemId",
                        column: x => x.ItemId,
                        principalTable: "Items",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Items_NoteId",
                table: "Items",
                column: "NoteId");

            migrationBuilder.CreateIndex(
                name: "IX_Items_PlaceId",
                table: "Items",
                column: "PlaceId");

            migrationBuilder.CreateIndex(
                name: "IX_LstReviews_ItemId",
                table: "LstReviews",
                column: "ItemId");

            migrationBuilder.CreateIndex(
                name: "IX_Services_ItemId",
                table: "Services",
                column: "ItemId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "LstReviews");

            migrationBuilder.DropTable(
                name: "Services");

            migrationBuilder.DropTable(
                name: "Items");

            migrationBuilder.DropTable(
                name: "Notes");

            migrationBuilder.DropTable(
                name: "Places");
        }
    }
}

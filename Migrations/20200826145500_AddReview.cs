using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Avengers.Migrations
{
    public partial class AddReview : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_LstReviews_Items_ItemId",
                table: "LstReviews");

            migrationBuilder.DropForeignKey(
                name: "FK_Services_Items_ItemId",
                table: "Services");

            migrationBuilder.DropTable(
                name: "Items");

            migrationBuilder.DropIndex(
                name: "IX_Services_ItemId",
                table: "Services");

            migrationBuilder.DropIndex(
                name: "IX_LstReviews_ItemId",
                table: "LstReviews");

            migrationBuilder.DropColumn(
                name: "ItemId",
                table: "Services");

            migrationBuilder.DropColumn(
                name: "ItemId",
                table: "LstReviews");

            migrationBuilder.AddColumn<int>(
                name: "RestaurantItemId",
                table: "Services",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "RestaurantItemId",
                table: "LstReviews",
                nullable: true);

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
                name: "Owners",
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
                    MobileCover = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Owners", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "RestaurantItems",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CateId = table.Column<int>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    Address = table.Column<string>(nullable: true),
                    AvgRating = table.Column<double>(nullable: true),
                    AvgRatingText = table.Column<string>(nullable: true),
                    RestaurantStatus = table.Column<int>(nullable: false),
                    Phone = table.Column<string>(nullable: true),
                    PhotoUrl = table.Column<string>(nullable: true),
                    TotalReviews = table.Column<int>(nullable: true),
                    TotalFavourites = table.Column<int>(nullable: true),
                    TotalViews = table.Column<int>(nullable: true),
                    TotalPictures = table.Column<int>(nullable: true),
                    TotalCheckIns = table.Column<int>(nullable: true),
                    Url = table.Column<string>(nullable: true),
                    Tags = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    NoteId = table.Column<int>(nullable: true),
                    HasPromotion = table.Column<bool>(nullable: true),
                    HasMemberCard = table.Column<bool>(nullable: true),
                    MemberCardDiscount = table.Column<string>(nullable: true),
                    Latitude = table.Column<double>(nullable: true),
                    Longitude = table.Column<double>(nullable: true),
                    ResUsername = table.Column<string>(nullable: true),
                    ResCreatedOn = table.Column<DateTime>(nullable: false),
                    LstCategory = table.Column<string>(nullable: true),
                    LstCuisine = table.Column<string>(nullable: true),
                    PriceMin = table.Column<int>(nullable: true),
                    PriceMax = table.Column<int>(nullable: true),
                    PriceMinDisplay = table.Column<string>(nullable: true),
                    PriceMaxDisplay = table.Column<string>(nullable: true),
                    DisplayOrder = table.Column<string>(nullable: true),
                    City = table.Column<string>(nullable: true),
                    District = table.Column<string>(nullable: true),
                    FAvgRating = table.Column<double>(nullable: true),
                    FTotalReviews = table.Column<int>(nullable: true),
                    ResUrlAlbums = table.Column<string>(nullable: true),
                    ResUrlReviews = table.Column<string>(nullable: true),
                    ContributeStatus = table.Column<string>(nullable: true),
                    CanDelete = table.Column<bool>(nullable: true),
                    ListOwnerId = table.Column<int>(nullable: true),
                    ListId = table.Column<int>(nullable: true),
                    UserId = table.Column<int>(nullable: true),
                    IsRestaurantCollection = table.Column<bool>(nullable: true),
                    TotalService = table.Column<int>(nullable: true),
                    UrlRewriteName = table.Column<string>(nullable: true),
                    LocationUrlRewriteName = table.Column<string>(nullable: true),
                    RestaurantId = table.Column<int>(nullable: true),
                    MainCategoryId = table.Column<int>(nullable: true),
                    TotalSaves = table.Column<int>(nullable: true),
                    Status = table.Column<int>(nullable: true),
                    TotalSavesFormat = table.Column<string>(nullable: true),
                    TotalReviewsFormat = table.Column<string>(nullable: true),
                    TotalPicturesFormat = table.Column<string>(nullable: true),
                    IsAds = table.Column<bool>(nullable: true),
                    MobileBgColor = table.Column<string>(nullable: true),
                    IsBooking = table.Column<bool>(nullable: true),
                    IsDelivery = table.Column<bool>(nullable: true),
                    BookingUrl = table.Column<string>(nullable: true),
                    DeliveryUrl = table.Column<string>(nullable: true),
                    HasVideo = table.Column<bool>(nullable: true),
                    HasBooking = table.Column<bool>(nullable: true),
                    HasDelivery = table.Column<bool>(nullable: true),
                    MasterCategoryId = table.Column<int>(nullable: true),
                    PromotionId = table.Column<string>(nullable: true),
                    PromotionTitle = table.Column<string>(nullable: true),
                    PromotionUrl = table.Column<string>(nullable: true),
                    Floor = table.Column<string>(nullable: true),
                    IsSaved = table.Column<bool>(nullable: true),
                    IsOpening = table.Column<bool>(nullable: true),
                    Distance = table.Column<double>(nullable: true),
                    PromotionPlainTitle = table.Column<string>(nullable: true),
                    DistanceText = table.Column<string>(nullable: true),
                    MobileBookingUrl = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RestaurantItems", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RestaurantItems_Notes_NoteId",
                        column: x => x.NoteId,
                        principalTable: "Notes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
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
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
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
                        name: "FK_ReviewItems_Owners_OwnerId",
                        column: x => x.OwnerId,
                        principalTable: "Owners",
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

            migrationBuilder.CreateTable(
                name: "Pictures",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
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
                name: "UserLikes",
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
                    table.PrimaryKey("PK_UserLikes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserLikes_ReviewItems_ReviewItemId",
                        column: x => x.ReviewItemId,
                        principalTable: "ReviewItems",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Services_RestaurantItemId",
                table: "Services",
                column: "RestaurantItemId");

            migrationBuilder.CreateIndex(
                name: "IX_LstReviews_RestaurantItemId",
                table: "LstReviews",
                column: "RestaurantItemId");

            migrationBuilder.CreateIndex(
                name: "IX_Hashtags_ReviewItemId",
                table: "Hashtags",
                column: "ReviewItemId");

            migrationBuilder.CreateIndex(
                name: "IX_Pictures_ReviewItemId",
                table: "Pictures",
                column: "ReviewItemId");

            migrationBuilder.CreateIndex(
                name: "IX_RestaurantItems_NoteId",
                table: "RestaurantItems",
                column: "NoteId");

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
                name: "IX_UserLikes_ReviewItemId",
                table: "UserLikes",
                column: "ReviewItemId");

            migrationBuilder.AddForeignKey(
                name: "FK_LstReviews_RestaurantItems_RestaurantItemId",
                table: "LstReviews",
                column: "RestaurantItemId",
                principalTable: "RestaurantItems",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Services_RestaurantItems_RestaurantItemId",
                table: "Services",
                column: "RestaurantItemId",
                principalTable: "RestaurantItems",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_LstReviews_RestaurantItems_RestaurantItemId",
                table: "LstReviews");

            migrationBuilder.DropForeignKey(
                name: "FK_Services_RestaurantItems_RestaurantItemId",
                table: "Services");

            migrationBuilder.DropTable(
                name: "Hashtags");

            migrationBuilder.DropTable(
                name: "Pictures");

            migrationBuilder.DropTable(
                name: "RestaurantItems");

            migrationBuilder.DropTable(
                name: "UserLikes");

            migrationBuilder.DropTable(
                name: "ReviewItems");

            migrationBuilder.DropTable(
                name: "Options");

            migrationBuilder.DropTable(
                name: "Owners");

            migrationBuilder.DropTable(
                name: "Videos");

            migrationBuilder.DropIndex(
                name: "IX_Services_RestaurantItemId",
                table: "Services");

            migrationBuilder.DropIndex(
                name: "IX_LstReviews_RestaurantItemId",
                table: "LstReviews");

            migrationBuilder.DropColumn(
                name: "RestaurantItemId",
                table: "Services");

            migrationBuilder.DropColumn(
                name: "RestaurantItemId",
                table: "LstReviews");

            migrationBuilder.AddColumn<int>(
                name: "ItemId",
                table: "Services",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ItemId",
                table: "LstReviews",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Items",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AvgRating = table.Column<double>(type: "float", nullable: true),
                    AvgRatingText = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BookingUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CanDelete = table.Column<bool>(type: "bit", nullable: true),
                    CateId = table.Column<int>(type: "int", nullable: true),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ContributeStatus = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeliveryUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DisplayOrder = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Distance = table.Column<double>(type: "float", nullable: true),
                    DistanceText = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    District = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FAvgRating = table.Column<double>(type: "float", nullable: true),
                    FTotalReviews = table.Column<int>(type: "int", nullable: true),
                    Floor = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HasBooking = table.Column<bool>(type: "bit", nullable: true),
                    HasDelivery = table.Column<bool>(type: "bit", nullable: true),
                    HasMemberCard = table.Column<bool>(type: "bit", nullable: true),
                    HasPromotion = table.Column<bool>(type: "bit", nullable: true),
                    HasVideo = table.Column<bool>(type: "bit", nullable: true),
                    IsAds = table.Column<bool>(type: "bit", nullable: true),
                    IsBooking = table.Column<bool>(type: "bit", nullable: true),
                    IsDelivery = table.Column<bool>(type: "bit", nullable: true),
                    IsOpening = table.Column<bool>(type: "bit", nullable: true),
                    IsRestaurantCollection = table.Column<bool>(type: "bit", nullable: true),
                    IsSaved = table.Column<bool>(type: "bit", nullable: true),
                    Latitude = table.Column<double>(type: "float", nullable: true),
                    ListId = table.Column<int>(type: "int", nullable: true),
                    ListOwnerId = table.Column<int>(type: "int", nullable: true),
                    LocationUrlRewriteName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Longitude = table.Column<double>(type: "float", nullable: true),
                    LstCategory = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LstCuisine = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MainCategoryId = table.Column<int>(type: "int", nullable: true),
                    MasterCategoryId = table.Column<int>(type: "int", nullable: true),
                    MemberCardDiscount = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MobileBgColor = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MobileBookingUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NoteId = table.Column<int>(type: "int", nullable: true),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhotoUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PriceMax = table.Column<int>(type: "int", nullable: true),
                    PriceMaxDisplay = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PriceMin = table.Column<int>(type: "int", nullable: true),
                    PriceMinDisplay = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PromotionId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PromotionPlainTitle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PromotionTitle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PromotionUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ResCreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ResUrlAlbums = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ResUrlReviews = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ResUsername = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RestaurantId = table.Column<int>(type: "int", nullable: true),
                    RestaurantStatus = table.Column<int>(type: "int", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: true),
                    Tags = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TotalCheckIns = table.Column<int>(type: "int", nullable: true),
                    TotalFavourites = table.Column<int>(type: "int", nullable: true),
                    TotalPictures = table.Column<int>(type: "int", nullable: true),
                    TotalPicturesFormat = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TotalReviews = table.Column<int>(type: "int", nullable: true),
                    TotalReviewsFormat = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TotalSaves = table.Column<int>(type: "int", nullable: true),
                    TotalSavesFormat = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TotalService = table.Column<int>(type: "int", nullable: true),
                    TotalViews = table.Column<int>(type: "int", nullable: true),
                    Url = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UrlRewriteName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<int>(type: "int", nullable: true)
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
                });

            migrationBuilder.CreateIndex(
                name: "IX_Services_ItemId",
                table: "Services",
                column: "ItemId");

            migrationBuilder.CreateIndex(
                name: "IX_LstReviews_ItemId",
                table: "LstReviews",
                column: "ItemId");

            migrationBuilder.CreateIndex(
                name: "IX_Items_NoteId",
                table: "Items",
                column: "NoteId");

            migrationBuilder.AddForeignKey(
                name: "FK_LstReviews_Items_ItemId",
                table: "LstReviews",
                column: "ItemId",
                principalTable: "Items",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Services_Items_ItemId",
                table: "Services",
                column: "ItemId",
                principalTable: "Items",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}

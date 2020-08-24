using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Avengers.Models
{
    public class Note
    {
        public int? RestaurantId { get; set; }
        public int? UserId { get; set; }
        public string ListId { get; set; }
        public string ListName { get; set; }
        public DateTime CreatedOn { get; set; }
        public string Description { get; set; }
        [JsonIgnore]
        public int Id { get; set; }
    }

    public class LstReview
    {
        [JsonIgnore]
        public int Id { get; set; }
        public string reviewProfileUrl { get; set; }
        public string reviewUserDisplayName { get; set; }
        public string reviewUserAvatar { get; set; }
        public string reviewUrl { get; set; }
        public string AvgRatingText { get; set; }
        public bool? ShortReview { get; set; }
        public bool? UserVerified { get; set; }
        public int? ReviewId { get; set; }
        public string Comment { get; set; }
        public int? UserId { get; set; }
        public int? UserFoodyId { get; set; }
        public string Username { get; set; }
        public string UserAvatar { get; set; }
        public string UserGender { get; set; }
        public string UserFirstName { get; set; }
        public string UserLastName { get; set; }
        public double? AvgRating { get; set; }
    }

    public class Item
    {
        public int Id { get; set; }
        public int? CateId { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public double? AvgRating { get; set; }
        public string AvgRatingText { get; set; }
        public int RestaurantStatus { get; set; }
        public string Phone { get; set; }
        public string PhotoUrl { get; set; }
        public int? TotalReviews { get; set; }
        public int? TotalFavourites { get; set; }
        public int? TotalViews { get; set; }
        public int? TotalPictures { get; set; }
        public int? TotalCheckIns { get; set; }
        public string Url { get; set; }
        public string Tags { get; set; }
        public string Description { get; set; }
        public Note Note { get; set; }
        public bool? HasPromotion { get; set; }
        public bool? HasMemberCard { get; set; }
        public string MemberCardDiscount { get; set; }
        public double? Latitude { get; set; }
        public double? Longitude { get; set; }
        public string ResUsername { get; set; }
        public DateTime ResCreatedOn { get; set; }
        //public List<string> LstPicture { get; set; }
        public List<LstReview> LstReview { get; set; }
        public string LstCategory { get; set; }
        public string LstCuisine { get; set; }
        public int? PriceMin { get; set; }
        public int? PriceMax { get; set; }
        public string PriceMinDisplay { get; set; }
        public string PriceMaxDisplay { get; set; }
        public string DisplayOrder { get; set; }
        public string City { get; set; }
        public string District { get; set; }
        public double? FAvgRating { get; set; }
        public int? FTotalReviews { get; set; }
        public string ResUrlAlbums { get; set; }
        public string ResUrlReviews { get; set; }
        public string ContributeStatus { get; set; }
        public bool? CanDelete { get; set; }
        public int? ListOwnerId { get; set; }
        public int? ListId { get; set; }
        public int? UserId { get; set; }
        public bool? IsRestaurantCollection { get; set; }
        public List<Service> Services { get; set; }
        public int? TotalService { get; set; }
        public string UrlRewriteName { get; set; }
        public string LocationUrlRewriteName { get; set; }
        public int? RestaurantId { get; set; }
        public int? MainCategoryId { get; set; }
        public int? TotalSaves { get; set; }
        public int? Status { get; set; }
        public string TotalSavesFormat { get; set; }
        public string TotalReviewsFormat { get; set; }
        public string TotalPicturesFormat { get; set; }
        public bool? IsAds { get; set; }
        public string MobileBgColor { get; set; }
        public bool? IsBooking { get; set; }
        public bool? IsDelivery { get; set; }
        public string BookingUrl { get; set; }
        public string DeliveryUrl { get; set; }
        public bool? HasVideo { get; set; }
        public bool? HasBooking { get; set; }
        public bool? HasDelivery { get; set; }
        public int? MasterCategoryId { get; set; }
        public string PromotionId { get; set; }
        public string PromotionTitle { get; set; }
        public string PromotionUrl { get; set; }
        public string Floor { get; set; }
        public bool? IsSaved { get; set; }
        public bool? IsOpening { get; set; }
        public double? Distance { get; set; }
        public string PromotionPlainTitle { get; set; }
        public string DistanceText { get; set; }
        public string MobileBookingUrl { get; set; }
    }

    public class Place
    {
        public int CityId { get; set; }
        public string ExcludeIds { get; set; }
        public string Query { get; set; }
        public List<Item> Items { get; set; }
        public int? Count { get; set; }
        public int? Total { get; set; }
        public string LastId { get; set; }
    }

    public class Service
    {
        [JsonIgnore]
        public int Id { get; set; }
        public int? Type { get; set; }
        public string Url { get; set; }
        public string Title { get; set; }
        public string Text { get; set; }
        public string Avatar { get; set; }
        public string BackgroundColor { get; set; }
        public int? RestaurantId { get; set; }
        public string Description { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Avengers.Models;
using Avengers.Slaves;
using Avengers.WorldSaver;
using Microsoft.EntityFrameworkCore;

namespace Avengers.Paparazzi
{
    public class HomePagePlacesPaparazzi
    {
        private static HomePagePlacesPaparazzi instance;
        private HomePagePlacesPaparazzi() { }
        public static HomePagePlacesPaparazzi GetIntance()
        {
            if (instance == null)
            {
                instance = new HomePagePlacesPaparazzi();
            }
            return instance;
        }

        public async Task RunLikeABitch()
        {
            int currentPage = 0;
            using var context = new YummyContext();
            while (true)
            {
                var httpRequestHelper = HttpRequestHelper.GetIntance();
                var baseUrl = "https://www.foody.vn";
                var endpoint = "__get/Place/HomeListPlace";
                var headers = new Dictionary<string, string>()
                {
                    {"host", "www.foody.vn" },
                    {"User-Agent", "Mozilla/5.0 (Macintosh; Intel Mac OS X 10_15_6) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/84.0.4147.125 Safari/537.36" },
                    {"X-Requested-With", "XMLHttpRequest" }
                };

                // cateId: 12 Sang trong
                // cateId: 39 Buffet
                // cateId: 1 Nha hang
                // cateId: 11 An vat via he
                // cateId: 56 An chay
                // cateId: 3 Quan an
                // cateId: 54 Quan nhau

                int cateId = 1;
                var parameters = new Dictionary<string, string>()
                {
                    {"page", currentPage.ToString() },
                    {"lat", "21.033333" },
                    {"lon", "105.85" },
                    {"count", "300" },
                    {"type", "1" },
                    {"cateId", cateId.ToString() }
                };
                var result = await httpRequestHelper.GetAsync<PlaceRoot>(baseUrl, endpoint, headers, parameters);
                if (result.Items.Count == 0)
                {
                    break;
                }
                var count = 0;

                using (var transaction = context.Database.BeginTransaction())
                {

                    foreach (var i in result.Items)
                    {
                        if (!context.RestaurantItems.Any(o => o.Id == i.Id))
                        {
                            count++;
                            i.CateId = cateId;
                            await context.RestaurantItems.AddAsync(i);
                        }
                    }

                    await context.Database.ExecuteSqlInterpolatedAsync($"SET IDENTITY_INSERT RestaurantItems ON;");
                    await context.SaveChangesAsync();
                    await context.Database.ExecuteSqlInterpolatedAsync($"SET IDENTITY_INSERT RestaurantItems OFF");
                    transaction.Commit();
                }
                Console.WriteLine("Page " + currentPage++ + " crawled. Size: " + count);
            }
        }
    }
}

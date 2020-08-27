using System;
using System.Threading;
using System.Threading.Tasks;
using Avengers.Paparazzi;

namespace Avengers
{
    class Program
    {
        static async Task Main(string[] args)
        {
            //await HomePagePlacesPaparazzi.GetIntance().RunLikeABitch();

            // Be careful. Please consider using parallel, or you will have to pay for it :)
            // I mean it. I've spent 13 hours on this for my stupidity.
            await RestaurantReviewPaparazzi.GetIntance().RunLikeABitch();
        }
    }
}

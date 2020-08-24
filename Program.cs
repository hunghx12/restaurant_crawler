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
            var currentPage = 0;
            while (true)
            {
                var stillRun = await HomePagePlacesPaparazzi.GetIntance().RunLikeABitch(currentPage++);
                if (!stillRun) break;
                Console.WriteLine("Sleep 1s to avoid DoS Server");
                Thread.Sleep(1000);
            }

        }
    }
}

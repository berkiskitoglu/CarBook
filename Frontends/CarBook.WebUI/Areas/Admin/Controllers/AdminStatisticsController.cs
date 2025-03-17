using CarBook.Dto.SocialMediaDtos;
using CarBook.Dto.StatisticDtos;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace CarBook.WebUI.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Route("Admin/AdminStatistics")]
    public class AdminStatisticsController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;
        public AdminStatisticsController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        [Route("Index")]
        public async Task<IActionResult> Index()
        {
            Random random = new Random();
            var client = _httpClientFactory.CreateClient();

            #region İstatistik1
            var responseMessage = await client.GetAsync("https://localhost:7117/api/Statistics/GetCarCount");
            if (responseMessage.IsSuccessStatusCode)
            {
                int v1 = random.Next(0, 101);
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<ResultStatisticDto>(jsonData);
                ViewBag.v = values.carCount;
                ViewBag.v1 = v1;
            }
            #endregion

            #region İstatistik2
            var responseMessage2 = await client.GetAsync("https://localhost:7117/api/Statistics/GetLocationCount");
            if (responseMessage2.IsSuccessStatusCode)
            {
                int locationCountRandom = random.Next(0, 101);
                var jsonData2 = await responseMessage2.Content.ReadAsStringAsync();
                var values2 = JsonConvert.DeserializeObject<ResultStatisticDto>(jsonData2);
                ViewBag.locationCount = values2.locationCount;
                ViewBag.locationCountRandom = locationCountRandom;
            }
            #endregion

            #region İstatistik3
            var responseMessage3 = await client.GetAsync("https://localhost:7117/api/Statistics/GetAuthorCount");
            if (responseMessage3.IsSuccessStatusCode)
            {
                int authorCountRandom = random.Next(0, 101);
                var jsonData3 = await responseMessage3.Content.ReadAsStringAsync();
                var values3 = JsonConvert.DeserializeObject<ResultStatisticDto>(jsonData3);
                ViewBag.authorCount = values3.authorCount;
                ViewBag.authorCountRandom = authorCountRandom;
            }
            #endregion




            #region İstatistik4
            var responseMessage4 = await client.GetAsync("https://localhost:7117/api/Statistics/GetBlogCount");
            if (responseMessage4.IsSuccessStatusCode)
            {
                int blogCountRandom = random.Next(0, 101);
                var jsonData4 = await responseMessage4.Content.ReadAsStringAsync();
                var values4 = JsonConvert.DeserializeObject<ResultStatisticDto>(jsonData4);
                ViewBag.blogCount = values4.blogCount;
                ViewBag.blogCountRandom = blogCountRandom;
            }
            #endregion

            #region İstatistik5
            var responseMessage5 = await client.GetAsync("https://localhost:7117/api/Statistics/GetBrandCount");
            if (responseMessage5.IsSuccessStatusCode)
            {
                int brandCountRandom = random.Next(0, 101);
                var jsonData5 = await responseMessage5.Content.ReadAsStringAsync();
                var values5 = JsonConvert.DeserializeObject<ResultStatisticDto>(jsonData5);
                ViewBag.brandCount = values5.brandCount;
                ViewBag.brandCountRandom = brandCountRandom;
            }
            #endregion

            #region İstatistik6
            var responseMessage6 = await client.GetAsync("https://localhost:7117/api/Statistics/GetAvgRentPriceForHourly");
            if (responseMessage6.IsSuccessStatusCode)
            {
                int avgRentPriceForHourlyRandom = random.Next(0, 101);
                var jsonData6 = await responseMessage6.Content.ReadAsStringAsync();
                var values6 = JsonConvert.DeserializeObject<ResultStatisticDto>(jsonData6);
                ViewBag.avgRentPriceForHourly = values6.avgRentPriceForHourly.ToString("0.00"); 
                ViewBag.avgRentPriceForHourlyRandom = avgRentPriceForHourlyRandom;
            }
            #endregion

            #region İstatistik7
            var responseMessage7 = await client.GetAsync("https://localhost:7117/api/Statistics/GetAvgRentPriceForDaily");
            if (responseMessage7.IsSuccessStatusCode)
            {
                int avgRentPriceForDailyRandom = random.Next(0, 101);
                var jsonData7 = await responseMessage7.Content.ReadAsStringAsync();
                var values7 = JsonConvert.DeserializeObject<ResultStatisticDto>(jsonData7);
                ViewBag.avgRentPriceForDaily = values7.avgRentPriceForDaily.ToString("0.00"); 
                ViewBag.avgRentPriceForDailyRandom = avgRentPriceForDailyRandom;
            }
            #endregion

            #region İstatistik8
            var responseMessage8 = await client.GetAsync("https://localhost:7117/api/Statistics/GetAvgRentPriceForWeekly");
            if (responseMessage8.IsSuccessStatusCode)
            {
                int avgRentPriceForWeeklyRandom = random.Next(0, 101);
                var jsonData8 = await responseMessage8.Content.ReadAsStringAsync();
                var values8 = JsonConvert.DeserializeObject<ResultStatisticDto>(jsonData8);
                ViewBag.avgRentPriceForWeekly = values8.avgRentPriceForWeekly.ToString("0.00");
                ViewBag.avgRentPriceForWeeklyRandom = avgRentPriceForWeeklyRandom;
            }
            #endregion

            #region İstatistik9
            var responseMessage9 = await client.GetAsync("https://localhost:7117/api/Statistics/GetAvgRentPriceForMonthly");
            if (responseMessage9.IsSuccessStatusCode)
            {
                int avgRentPriceForMonthlyRandom = random.Next(0, 101);
                var jsonData9 = await responseMessage9.Content.ReadAsStringAsync();
                var values9 = JsonConvert.DeserializeObject<ResultStatisticDto>(jsonData9);
                ViewBag.avgRentPriceForMonthly = values9.avgRentPriceForMonthly.ToString("0.00");
                ViewBag.avgRentPriceForMonthlyRandom = avgRentPriceForMonthlyRandom;
            }
            #endregion

            #region İstatistik10
            var responseMessage10 = await client.GetAsync("https://localhost:7117/api/Statistics/GetCarCountByTransmissionIsAuto");
            if (responseMessage10.IsSuccessStatusCode)
            {
                int carCountByTranmissionIsAutoRandom = random.Next(0, 101);
                var jsonData10 = await responseMessage10.Content.ReadAsStringAsync();
                var values10 = JsonConvert.DeserializeObject<ResultStatisticDto>(jsonData10);
                ViewBag.carCountByTranmissionIsAuto = values10.carCountByTransmissionIsAuto;
                ViewBag.carCountByTranmissionIsAutoRandom = carCountByTranmissionIsAutoRandom;
            }
            #endregion

            #region İstatistik11
            var responseMessage11 = await client.GetAsync("https://localhost:7117/api/Statistics/GetBrandNameByMaxCar");
            if (responseMessage11.IsSuccessStatusCode)
            {
                int brandNameByMaxCarRandom = random.Next(0, 101);
                var jsonData11 = await responseMessage11.Content.ReadAsStringAsync();
                var values11 = JsonConvert.DeserializeObject<ResultStatisticDto>(jsonData11);
                ViewBag.brandNameByMaxCar = values11.brandNameByMaxCar;
                ViewBag.brandNameByMaxCarRandom = brandNameByMaxCarRandom;
            }
            #endregion

            #region İstatistik12
            var responseMessage12 = await client.GetAsync("https://localhost:7117/api/Statistics/GetBlogTitleByMaxBlogComment");
            if (responseMessage12.IsSuccessStatusCode)
            {
                int blogTitleByMaxBlogCommentRandom = random.Next(0, 101);
                var jsonData12 = await responseMessage12.Content.ReadAsStringAsync();
                var values12 = JsonConvert.DeserializeObject<ResultStatisticDto>(jsonData12);
                ViewBag.blogTitleByMaxBlogComment = values12.blogTitleByMaxBlogComment;
                ViewBag.blogTitleByMaxBlogCommentRandom = blogTitleByMaxBlogCommentRandom;
            }
            #endregion

       

            #region İstatistik13
            var responseMessage13 = await client.GetAsync("https://localhost:7117/api/Statistics/GetCarCountByFuelGasolineOrDiesel");
            if (responseMessage13.IsSuccessStatusCode)
            {
                int carCountByFuelGasolineOrDieselRandom = random.Next(0, 101);
                var jsonData13 = await responseMessage13.Content.ReadAsStringAsync();
                var values13 = JsonConvert.DeserializeObject<ResultStatisticDto>(jsonData13);
                ViewBag.carCountByFuelGasolineOrDiesel = values13.carCountByFuelGasolineOrDiesel;
                ViewBag.carCountByFuelGasolineOrDieselRandom = carCountByFuelGasolineOrDieselRandom;
            }
            #endregion

            #region İstatistik14
            var responseMessage14 = await client.GetAsync("https://localhost:7117/api/Statistics/GetCarCountByFuelElectric");
            if (responseMessage14.IsSuccessStatusCode)
            {
                int carCountByFuelElectricRandom = random.Next(0, 101);
                var jsonData14 = await responseMessage14.Content.ReadAsStringAsync();
                var values14 = JsonConvert.DeserializeObject<ResultStatisticDto>(jsonData14);
                ViewBag.carCountByFuelElectric = values14.carCountByFuelElectric;
                ViewBag.carCountByFuelElectricRandom = carCountByFuelElectricRandom;
            }
            #endregion

            #region İstatistik15
            var responseMessage15 = await client.GetAsync("https://localhost:7117/api/Statistics/GetCarBrandAndModelByRentPriceDailyMax");
            if (responseMessage15.IsSuccessStatusCode)
            {
                int carBrandAndModelByRentPriceDailyMaxRandom = random.Next(0, 101);
                var jsonData15 = await responseMessage15.Content.ReadAsStringAsync();
                var values15 = JsonConvert.DeserializeObject<ResultStatisticDto>(jsonData15);
                ViewBag.carBrandAndModelByRentPriceDailyMax = values15.carBrandAndModelByRentPriceDailyMax;
                ViewBag.carBrandAndModelByRentPriceDailyMaxRandom = carBrandAndModelByRentPriceDailyMaxRandom;
            }
            #endregion

            #region İstatistik16
            var responseMessage16 = await client.GetAsync("https://localhost:7117/api/Statistics/GetCarBrandAndModelByRentPriceDailyMin");
            if (responseMessage16.IsSuccessStatusCode)
            {
                int carBrandAndModelByRentPriceDailyMinRandom = random.Next(0, 101);
                var jsonData16 = await responseMessage16.Content.ReadAsStringAsync();
                var values16 = JsonConvert.DeserializeObject<ResultStatisticDto>(jsonData16);
                ViewBag.carBrandAndModelByRentPriceDailyMin = values16.carBrandAndModelByRentPriceDailyMin;
                ViewBag.carBrandAndModelByRentPriceDailyMinRandom = carBrandAndModelByRentPriceDailyMinRandom;
            }
            #endregion

            return View();
        }
    }
}


using CarBook.Application.Interfaces.StatisticInterfaces;
using CarBook.Persistence.Context;
using CarBook.Persistence.Dtos;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.Persistence.Repositories.StatisticRepositories
{
    public class StatisticRepository : IStatisticRepository
    {
        private readonly CarBookContext _context;

        public StatisticRepository(CarBookContext context)
        {
            _context = context;
        }

        public string GetBlogTitleByMaxBlogComment()
        {
            var values = _context.Comments.GroupBy(x => x.BlogID).
                             Select(y => new
                             {
                                 BlogID = y.Key,
                                 Count = y.Count()
                             }).OrderByDescending(z => z.Count).Take(1).FirstOrDefault();
            string blogName = _context.Blogs.Where(x => x.BlogID == values.BlogID).Select(y => y.Title).FirstOrDefault();
            return blogName;
        }

        public string GetBrandNameByMaxCar()
        {
            var values = _context.Cars.GroupBy(x => x.BrandID).
                            Select(y => new
                            {
                                BrandID = y.Key,
                                Count = y.Count()
                            }).OrderByDescending(z => z.Count).Take(1).FirstOrDefault();
            string brandName = _context.Brands.Where(x => x.BrandID == values.BrandID).Select(y => y.Name).FirstOrDefault();
            return brandName;
        }

        public int GetAuthorCount()
        {
            var value = _context.Authors.Count();
            return value;
        }

        public decimal GetAvgRentPriceForDaily()
        {
            var AvgPriceForDaily = _context.Database
          .SqlQuery<AvgRentPrice>($"EXEC GetAvgDailyPriceCar")
          .AsEnumerable()
          .Select(x => x.Amount)
          .FirstOrDefault();

            return AvgPriceForDaily;
        }

        public decimal GetAvgRentPriceForHourly()
        {
            var AvgPriceForHourly = _context.Database
           .SqlQuery<AvgRentPrice>($"EXEC GetAvgHourlyPriceCar")
           .AsEnumerable()
           .Select(x => x.Amount)
           .FirstOrDefault();

            return AvgPriceForHourly;
        }

        public decimal GetAvgRentPriceForMonthly()
        {
            var AvgPriceForMonthly = _context.Database
            .SqlQuery<AvgRentPrice>($"EXEC GetAvgMounthlyPriceCar")
            .AsEnumerable()
            .Select(x => x.Amount)
            .FirstOrDefault();

            return AvgPriceForMonthly;
        }

        public decimal GetAvgRentPriceForWeekly()
        {
            var AvgPriceForWeekly = _context.Database
           .SqlQuery<AvgRentPrice>($"EXEC GetAvgWeeklyPriceCar")
           .AsEnumerable()
           .Select(x => x.Amount)
           .FirstOrDefault();

            return AvgPriceForWeekly;
        }

        public int GetBlogCount()
        {
            var value = _context.Blogs.Count();
            return value;
        }

        public int GetBrandCount()
        {
            var value = _context.Brands.Count();
            return value;
        }

        public string GetCarBrandAndModelByRentPriceDailyMax()
        {
            var CarBrandAndModelByRentPriceDailyMax = _context.Database
           .SqlQuery<CarBrandAndModelByRentPriceDailyMin>($"EXEC GetMaxDailyPriceCars")
           .AsEnumerable()
           .Select(x => x.Model)
           .FirstOrDefault();

            return CarBrandAndModelByRentPriceDailyMax;
        }

        public string GetCarBrandAndModelByRentPriceDailyMin()
        {
            var CarBrandAndModelByRentPriceDailyMin = _context.Database
           .SqlQuery<CarBrandAndModelByRentPriceDailyMin>($"EXEC GetMinDailyPriceCars")
           .AsEnumerable()
           .Select(x => x.Model)
           .FirstOrDefault();

            return CarBrandAndModelByRentPriceDailyMin;
        }

        public int GetCarCount()
        {
            var value = _context.Cars.Count();
            return value;
        }

        public int GetCarCountByFuelElectric()
        {
            var value = _context.Cars.Where(x => x.Fuel == "Elektirik").Count();
            return value;
        }

        public int GetCarCountByFuelGasolineOrDiesel()
        {
            var value = _context.Cars.Where(x => x.Fuel == "Benzin" || x.Fuel == "Dizel").Count();
            return value;
        }

        public int GetCarCountByTransmissionIsAuto()
        {
            var value = _context.Cars.Where(x => x.Transmission == "Otomatik").Count();
            return value;
        }

        public int GetLocationCount()
        {
            var value = _context.Locations.Count();
            return value;
        }
    }
}

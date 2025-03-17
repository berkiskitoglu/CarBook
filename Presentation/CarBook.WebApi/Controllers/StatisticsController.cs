using CarBook.Application.Features.Mediator.Queries.StatisticQueries;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace CarBook.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StatisticsController : Controller
    {
        private readonly IMediator _mediator;

        public StatisticsController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet("GetCarCount")]
        public async Task<IActionResult> GetCarCount()
        {
            var value = await _mediator.Send(new GetCarCountQuery());
            return Ok(value);
        }

        [HttpGet("GetLocationCount")]
        public async Task<IActionResult> GetLocationCount()
        {
            var value = await _mediator.Send(new GetLocationCountQuery());
            return Ok(value);
        }

        [HttpGet("GetAuthorCount")]
        public async Task<IActionResult> GetAuthorCount()
        {
            var value = await _mediator.Send(new GetAuthorCountQuery());
            return Ok(value);
        }

        [HttpGet("GetBlogCount")]
        public async Task<IActionResult> GetBlogCount()
        {
            var value = await _mediator.Send(new GetBlogCountQuery());
            return Ok(value);
        }

        [HttpGet("GetBrandCount")]
        public async Task<IActionResult> GetBrandCount()
        {
            var value = await _mediator.Send(new GetBrandCountQuery());
            return Ok(value);
        }

        [HttpGet("GetAvgRentPriceForHourly")]
        public async Task<IActionResult> GetAvgRentPriceForHourly()
        {
            var value = await _mediator.Send(new GetAvgRentPriceForHourlyQuery());
            return Ok(value);
        }

        [HttpGet("GetAvgRentPriceForDaily")]
        public async Task<IActionResult> GetAvgRentPriceForDaily()
        {
            var value = await _mediator.Send(new GetAvgRentPriceForDailyQuery());
            return Ok(value);
        }

        [HttpGet("GetAvgRentPriceForWeekly")]
        public async Task<IActionResult> GetAvgRentPriceForWeekly()
        {
            var value = await _mediator.Send(new GetAvgRentPriceForWeeklyQuery());
            return Ok(value);
        }

        [HttpGet("GetAvgRentPriceForMonthly")]
        public async Task<IActionResult> GetAvgRentPriceForMonthly()
        {
            var value = await _mediator.Send(new GetAvgRentPriceForMonthlyQuery());
            return Ok(value);
        }

        [HttpGet("GetCarCountByTransmissionIsAuto")]
        public async Task<IActionResult> GetCarCountByTransmissionIsAuto()
        {
            var value = await _mediator.Send(new GetCarCountByTransmissionIsAutoQuery());
            return Ok(value);
        }

        [HttpGet("GetBrandNameByMaxCar")]
        public async Task<IActionResult> GetBrandNameByMaxCar()
        {
            var value = await _mediator.Send(new GetBrandNameByMaxCarQuery());
            return Ok(value);
        }

        [HttpGet("GetBlogTitleByMaxBlogComment")]
        public async Task<IActionResult> GetBlogTitleByMaxBlogComment()
        {
            var value = await _mediator.Send(new GetBlogTitleByMaxBlogCommentQuery());
            return Ok(value);
        }

        [HttpGet("GetCarCountByFuelGasolineOrDiesel")]
        public async Task<IActionResult> GetCarCountByFuelGasolineOrDiesel()
        {
            var value = await _mediator.Send(new GetCarCountByFuelGasolineOrDieselQuery());
            return Ok(value);
        }

        [HttpGet("GetCarCountByFuelElectric")]
        public async Task<IActionResult> GetCarCountByFuelElectric()
        {
            var value = await _mediator.Send(new GetCarCountByFuelElectricQuery());
            return Ok(value);
        }

        [HttpGet("GetCarBrandAndModelByRentPriceDailyMax")]
        public async Task<IActionResult> GetCarBrandAndModelByRentPriceDailyMax()
        {
            var value = await _mediator.Send(new GetCarBrandAndModelByRentPriceDailyMaxQuery());
            return Ok(value);
        }

        [HttpGet("GetCarBrandAndModelByRentPriceDailyMin")]
        public async Task<IActionResult> GetCarBrandAndModelByRentPriceDailyMin()
        {
            var value = await _mediator.Send(new GetCarBrandAndModelByRentPriceDailyMinQuery());
            return Ok(value);
        }

       
    }
}

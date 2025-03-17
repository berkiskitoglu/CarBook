using CarBook.Application.Features.Mediator.Queries.StatisticQueries;
using CarBook.Application.Features.Mediator.Results.StatisticResults;
using CarBook.Application.Interfaces.StatisticInterfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.Application.Features.Mediator.Handlers.StatisticHandlers
{
    public class GetAvgRentPriceForHourlyQueryHandler : IRequestHandler<GetAvgRentPriceForHourlyQuery, GetAvgRentPriceForHourlyQueryResult>
    {
        private readonly IStatisticRepository _repository;

        public GetAvgRentPriceForHourlyQueryHandler(IStatisticRepository repository)
        {
            _repository = repository;
        }

        public async Task<GetAvgRentPriceForHourlyQueryResult> Handle(GetAvgRentPriceForHourlyQuery request, CancellationToken cancellationToken)
        {
            var value = _repository.GetAvgRentPriceForHourly();
            return new GetAvgRentPriceForHourlyQueryResult
            {
                AvgRentPriceForHourly = value
            };
                
        }
    }
 
}

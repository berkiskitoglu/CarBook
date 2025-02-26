using CarBook.Application.Features.CQRS.Results.BrandResults;
using CarBook.Application.Interfaces;
using CarBook.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.Application.Features.CQRS.Handlers.BrandHandlers
{
    public class GetBrandQueryHandler
    {
        private readonly IRepository<Brand> _repoistory;

        public GetBrandQueryHandler(IRepository<Brand> repoistory)
        {
            _repoistory = repoistory;
        }

        public async Task<List<GetBrandQueryResult>> Handle()
        {
            var values = await _repoistory.GetAllAsync();
            return values.Select(x => new GetBrandQueryResult
            {
                BrandID = x.BrandID,
                Name = x.Name,
            }).ToList();
        }
    }
}

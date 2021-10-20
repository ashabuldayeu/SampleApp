using MediatR;
using SampleApp.Models;
using SampleApp.Repositories;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace SampleApp.Queries.Handlers
{
    public class GetSampleModelListQueryHandler : IRequestHandler<GetSampleModelListQuery, List<SampleModel>>
    {
        private readonly IReadonlyRepository _readonlyRepository;

        public GetSampleModelListQueryHandler(IReadonlyRepository readonlyRepository)
        {
            _readonlyRepository = readonlyRepository;
        }

        public async Task<List<SampleModel>> Handle(GetSampleModelListQuery request, CancellationToken cancellationToken)
        {
            return _readonlyRepository.GetList();
        }
    }
}
